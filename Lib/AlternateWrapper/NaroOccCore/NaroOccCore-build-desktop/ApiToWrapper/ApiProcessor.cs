using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace ApiToWrapper
{
    public class Match
    {
        public string name;
        public string retType;
        public bool isRead;
        public bool isWrite;
        public bool isStatic;
    }

   public class ApiProcessor
    {
       public static void RebuildVcProj(string NaroOccCoreFolder, string outPath)
       {
           var mainFolderCppOld = NaroOccCoreFolder+@"\Occ\";
           var dirInfoOldMain = new DirectoryInfo(mainFolderCppOld);
           var dirSubFolders = dirInfoOldMain.GetDirectories();

           using (StreamWriter sw = new StreamWriter(outPath, false))
           {
               foreach (var subdir in dirSubFolders)
               {
                   var files = new DirectoryInfo(subdir.FullName).GetFiles("*.cpp");
                   foreach (var file in files)
                   {
                       var partName = file.FullName.Replace(Path.GetFullPath(NaroOccCoreFolder), string.Empty);
                       var portion = "<File RelativePath=\"" + partName + "\"></File>";
                       sw.WriteLine(portion);

                   }
               }
               sw.WriteLine("<File RelativePath=\"NaroExport.cpp\"></File>");
           }
       }

       public static void Process()
       {
           DirectoryInfo dInfo = new DirectoryInfo(@"..\..\..\OCWrappersExt\out\");
           DirectoryInfo[] subdirs = dInfo.GetDirectories();

           var apiFiles = new List<string>();
           var excludedPackages = new List<string>();
           using (var pExcluded = new StreamReader(@"..\..\ExclusionFiles\excluded-packages.txt"))
           {
               while (!pExcluded.EndOfStream)
               {
                   var line = pExcluded.ReadLine();
                   excludedPackages.Add(line);
               }
           }


           foreach (var dir in subdirs)
           {
               using (var StreamWriter = new StreamWriter(dir.FullName + ".api", false))
               {
                   StreamWriter.WriteLine(" <Namespace Name=\"" + dir.Name + "\">");

                   // replace with xml parsing and exclude unused classes
                   foreach (var file in dir.GetFiles("*.api_base"))
                   {
                       if (excludedPackages.Contains(file.Name))
                           continue;
                       var sr = new StreamReader(file.FullName);
                       while (!sr.EndOfStream)
                       {

                           var line = sr.ReadLine();
                           StreamWriter.WriteLine(line);
                       }
                       sr.Close();
                   }
                   StreamWriter.WriteLine(" </Namespace>");
               }
           }
           excludedClasses = new List<string>();
           using (var srExcluded = new StreamReader(@"..\..\ExclusionFiles\excluded-classes.txt"))
           {
               while (!srExcluded.EndOfStream)
               {
                   var line = srExcluded.ReadLine();
                   excludedClasses.Add(line);
               }
           }

           List<string> excludedMethods = new List<string>();
           using (var srExcluded = new StreamReader(@"..\..\ExclusionFiles\excluded-methods.txt"))
           {
               while (!srExcluded.EndOfStream)
               {
                   var line = srExcluded.ReadLine();
                   excludedMethods.Add(line);
               }
           }
           apiFiles = new List<string>();
           var content = string.Empty;
           foreach (var file in dInfo.GetFiles("*.api"))
           {
               if (file.Name == "FULL.api")
                   continue;

               using (var StreamReader = new StreamReader(file.FullName))
               {
                   content = "<API IsRef=\"true\">" + Environment.NewLine +
                       "<Generator Name=\"Occ\">" + Environment.NewLine +
                       "<Namespace Name=\"NaroCppCore\">" + Environment.NewLine +
                       "<Namespace Name=\"Occ\">" + Environment.NewLine;

                   while (StreamReader.Peek() >= 0)
                   {
                       var line = StreamReader.ReadLine();
                       line = ApplyReplace(line);
                       content += line + Environment.NewLine;
                   }

                   content += "	</Namespace>" + Environment.NewLine +
                       "</Namespace>" + Environment.NewLine +
                       "</Generator>" + Environment.NewLine +
                       "</API>";
               }

               using (var streamWriter = new StreamWriter(file.FullName, false))
               {
                   streamWriter.Write(content);
               }

               //* load the XML document from the specified file.
               XmlDocument xmlDoc = new XmlDocument(); //* create an xml document object.
               var filename = file.FullName;
               xmlDoc.Load(filename);
               List<string> readProp = new List<string>();
               List<string> writeProp = new List<string>();
               List<string> staticProp = new List<string>();
               XmlNodeList classes = xmlDoc.GetElementsByTagName("Class");

               for (int i = classes.Count - 1; i >= 0; i--)
               {
                   var classNode = classes[i];
                   var className = classNode.Attributes.GetNamedItem("Name").Value;

                   var classNameNoUnderscore = className.Replace("_", string.Empty);

                   if (excludedClasses.Contains(classNameNoUnderscore) || excludedClasses.Contains(className))
                   {
                       classNode.RemoveAll();
                       classNode.ParentNode.RemoveChild(classNode);
                       continue;
                   }

                   matches.Clear();

                   XmlNodeList methods = classNode.ChildNodes;
                   XmlNodeList methodsList = methods.Count == 1 ? methods[0].ChildNodes : methods[1].ChildNodes;

                   List<string> entireNodes = new List<string>();

                   Dictionary<string, int> occurencesCount = new Dictionary<string, int>();
                   for (int j = methodsList.Count; j >= 0; j--)
                   {
                       XmlNode node = methodsList[j];
                       if (node == null)
                           continue;
                       if (node.Name != "Method")
                           continue;
                       var methodName = node.Attributes.GetNamedItem("Name").Value;

                       if (methodName.StartsWith("Set"))
                           methodName = methodName.Replace("Set", "");

                       if (!occurencesCount.ContainsKey(methodName))
                           occurencesCount.Add(methodName, 1);
                       else
                           occurencesCount[methodName]++;
                   }

                   for (int j = methodsList.Count; j >= 0; j--)
                   {
                       XmlNode node = methodsList[j];
                       if (node == null)
                           continue;

                       if (entireNodes.Contains(node.OuterXml))
                       {
                           methodsList[j].ParentNode.RemoveChild(methodsList[j]);
                       }
                       else
                           entireNodes.Add(node.OuterXml);

                       if (HasInvalidParameterOrReturn(node))
                       {
                           methodsList[j].ParentNode.RemoveChild(methodsList[j]);
                           continue;
                       }

                       if (node.Name != "Method")
                           continue;
                       var methodName = node.Attributes.GetNamedItem("Name").Value;

                       if (excludedMethods.Contains(classNameNoUnderscore + "." + methodName) || excludedMethods.Contains(classNameNoUnderscore + "." + methodName.Replace("Set", "")))
                       {
                           methodsList[j].ParentNode.RemoveChild(methodsList[j]);
                           continue;
                       }
                       bool isRead = false;
                       bool isWrite = false;
                       bool isStatic = false;

                       if (isRead = IsReadProperty(node))
                       {
                           readProp.Add(methodName);
                       }
                       if (isWrite = IsWriteProperty(node))
                       {
                           writeProp.Add(methodName.Replace("Set", string.Empty));
                       }
                       if (isStatic = IsStatic(node))
                       {
                           staticProp.Add(methodName);
                       }
                   }

                   foreach (var match in matches)
                   {
                       if (match.isRead)
                           occurencesCount[match.name]--;
                       if (match.isWrite)
                           occurencesCount[match.name]--;
                   }
                   var toDelete = new List<Match>();
                   for (int t = 0; t < matches.Count; t++)
                   {
                       if (occurencesCount[matches[t].name] != 0)
                       {
                           toDelete.Add(matches[t]);
                       }
                   }
                   matches = matches.Except(toDelete).ToList();

                   for (int t = methodsList.Count; t >= 0; t--)
                   {
                       XmlNode node = methodsList[t];
                       if (node == null)
                           continue;
                       if (node.Name != "Method")
                           continue;
                       var methodName = node.Attributes.GetNamedItem("Name").Value;
                       if (methodName.StartsWith("Set"))
                           methodName = methodName.Replace("Set", "");
                       if (occurencesCount[methodName] == 0)
                           methodsList[t].ParentNode.RemoveChild(methodsList[t]);
                   }

                   if (matches.Count > 0)
                   {
                       XmlElement propertiesNode = xmlDoc.CreateElement("Properties");

                       foreach (var match in matches)
                       {
                           XmlElement property = xmlDoc.CreateElement("Property");
                           var attrName = xmlDoc.CreateAttribute("Name");
                           attrName.InnerText = match.name;
                           property.SetAttributeNode(attrName);
                           var attrType = xmlDoc.CreateAttribute("ReturnType");
                           attrType.InnerText = match.retType;
                           property.SetAttributeNode(attrType);

                           XmlElement attrs = xmlDoc.CreateElement("Attrs");
                           if (match.isRead)
                           {
                               var attrsIs = xmlDoc.CreateAttribute("IsReadProperty");
                               attrsIs.InnerText = "true";
                               attrs.SetAttributeNode(attrsIs);
                           }
                           if (match.isWrite)
                           {
                               var attrsIs = xmlDoc.CreateAttribute("IsWriteProperty");
                               attrsIs.InnerText = "true";
                               attrs.SetAttributeNode(attrsIs);
                           }
                           if (match.isStatic)
                           {
                               var attrsIs = xmlDoc.CreateAttribute("IsStatic");
                               attrsIs.InnerText = "true";
                               attrs.SetAttributeNode(attrsIs);
                           }
                           property.PrependChild(attrs);
                           propertiesNode.PrependChild(property);
                       }
                       classNode.PrependChild(propertiesNode);
                   }
               }
               xmlDoc.Save(filename);
           }

           // merge all api files in one

          
           using (var streamWriter = new StreamWriter(@"..\..\FULL.api", false))
           {
               streamWriter.Write("<API IsRef=\"true\">" + Environment.NewLine +
                   "<Generator Name=\"Occ\">" + Environment.NewLine +
                   "<Namespace Name=\"NaroCppCore\">" + Environment.NewLine +
                   "<Namespace Name=\"Occ\">" + Environment.NewLine);
               foreach (FileInfo file in dInfo.GetFiles("*.api"))
               {
                   if (file.Name == "FULL.api")
                       continue;
                   using (var StreamReader = new StreamReader(file.FullName))
                   {
                       var fileContent = StreamReader.ReadToEnd();


                       fileContent = fileContent.Replace("<API IsRef=\"true\">", "");
                       fileContent = fileContent.Replace("<Generator Name=\"Occ\">", "");
                       fileContent = fileContent.Replace("<Namespace Name=\"NaroCppCore\">", "");
                       fileContent = fileContent.Replace("<Namespace Name=\"Occ\">", "");
                       fileContent = fileContent.Replace("</Namespace>", "");
                       fileContent = fileContent.Replace("</Generator>", "");
                       fileContent = fileContent.Replace("</API>", "");
                       streamWriter.WriteLine(fileContent);
                       streamWriter.WriteLine("	</Namespace>");
                   }
               }
               streamWriter.Write("	</Namespace>" + Environment.NewLine +
                   "</Namespace>" + Environment.NewLine +
                   "</Generator>" + Environment.NewLine +
                   "</API>");
           }
       }

       private static bool HasInvalidParameterOrReturn(XmlNode node)
       {
           List<string> allTypes = new List<string>();
           if (node.Name == "Method")
           {
               var retType = node.Attributes.GetNamedItem("ReturnType");
               allTypes.Add(retType.Value);
           }

           var parameters = node.ChildNodes;
           foreach (XmlNode param in parameters)
           {
               if (param.Name != "Parameters")
                   continue;
               foreach (XmlNode child in param.ChildNodes)
               {
                   var paramType = child.Attributes.GetNamedItem("ParamType").Value;
                   allTypes.Add(paramType);
               }
           }
           foreach (var invalid in invalidTypes)
           {
               if (allTypes.Contains(invalid))
                   return true;
           }
           return false;
       }

       private static List<string> invalidTypes = new List<string> {"Geom2dCurve", "StandardIStream", "StandardOStream", "IntAnaQuadric", "StandardUUID",
													"Geom2d_Curve", "Standard_IStream", "Standard_OStream", "IntAna_Quadric", "Standard_UUID",
													"Aspect_RenderingContext","WNT_Uint", "BOPTools_SSIntersectionAttribute", "Visual3d_ContextView",
													"Interface_InterfaceModel", "Interface_CheckIterator", "IFSelect_Selection", "IFSelect_SelectionIterator",
													"IFSelect_WorkLibrary", "Interface_Protocol","Interface_HGraph","Interface_Graph", "Graphic3d_HArray1OfBytes",
													"Message_Messenger","Graphic3d_MapOfStructure", "Poly_Polygon3D","Poly_PolygonOnTriangulation", "TColgp_Array1OfPnt2d",
													"TColStd_ListOfInteger","TColStd_Array1OfReal", "Prs3d_Presentation", "TColStd_SequenceOfExtendedString",
													"TColStd_HArray1OfReal", "Graphic3d_Structure", "TColStd_Array2OfReal", "TColStd_HSequenceOfTransient",
													"TColStd_HSequenceOfInteger", "TColStd_HSequenceOfAsciiString", "TColStd_HArray1OfReal", "Graphic3d_Structure",
													"BRepClass3d_SolidExplorer", "Select3D_Projector", "IntTools_Context", "Graphic3d_PtrFrameBuffer", "TColStd_SequenceOfAsciiString",
       "TColStd_HArray1OfByte", "Aspect_GradientBackground", "Geom2dHatch_Hatcher", "Image_PixMap", "gp_Quaternion", "Visual3d_NListOfLayerItem",
       "Graphic3d_BufferType", "Visual3d_NListOfLayerItem"};

       private static bool IsReadProperty(XmlNode node)
       {
           var retType = node.Attributes.GetNamedItem("ReturnType");

           if (retType.Value == "void")
               return false;
           if (node.Attributes.GetNamedItem("Name").Value.StartsWith("Set"))
               return false;
           var parameters = node.ChildNodes;
           foreach (XmlNode param in parameters)
           {
               if (param.Name != "Parameters")
                   continue;
               if (param.ChildNodes.Count == 0)
               {
                   var res = matches.Where(p => p.name == node.Attributes.GetNamedItem("Name").Value).FirstOrDefault();
                   if (res != null)
                   {
                       res.isRead = true;
                   }
                   else
                   {
                       matches.Add(new Match() { name = node.Attributes.GetNamedItem("Name").Value, isRead = true, retType = retType.Value });
                   }
                   return true;
               }

               return false;
           }
           return false;
       }

       private static bool IsStatic(XmlNode node)
       {
           var retType = node.Attributes.GetNamedItem("ReturnType");

           if (retType.Value == "void")
               return false;
           var parameters = node.ChildNodes;
           foreach (XmlNode param in parameters)
           {
               if (param.Name == "Attrs")
               {
                   if (param.ChildNodes.Count == 1)
                   {
                       if (param.ChildNodes[0].Name == "IsStatic")
                       {
                           var res = matches.Where(p => p.name == node.Attributes.GetNamedItem("Name").Value).FirstOrDefault();
                           if (res != null)
                               res.isStatic = true;
                           return true;
                       }
                   }
               }
           }
           return false;
       }

       private static bool IsWriteProperty(XmlNode node)
       {
           var retType = node.Attributes.GetNamedItem("ReturnType");
           if (retType.Value != "void")
               return false;

           var name = node.Attributes.GetNamedItem("Name");
           if (name.Value == string.Empty || !name.Value.StartsWith("Set") || name.Value == "Set")
               return false;

           var parameters = node.ChildNodes;
           foreach (XmlNode param in parameters)
           {
               if (param.Name != "Parameters")
                   continue;
               if (param.ChildNodes.Count == 1)
               {
                   var paramNodeFinal = param.ChildNodes[0];
                   var paramType = paramNodeFinal.Attributes.GetNamedItem("ParamType").Value;
                   var mName = name.Value.Replace("Set", string.Empty);
                   var res = matches.Where(p => p.name == mName).FirstOrDefault();
                   if (res != null)
                   {
                       res.isWrite = true;
                       res.retType = paramType;
                   }
                   else
                   {
                       matches.Add(new Match() { name = node.Attributes.GetNamedItem("Name").Value.Replace("Set", string.Empty), isWrite = true, retType = paramType });
                   }
                   return true;
               }

               return false;
           }
           return false;
       }




       private static string ApplyReplace(string content)
       {
           content = content.Replace("System::Boolean", "bool");
           content = content.Replace("System::String", "string");
           content = content.Replace("System::IntPtr", "IntPtr");
           content = content.Replace("WNTUint", "IntPtr");
           content = content.Replace("Standard_Address", "IntPtr");
           content = content.Replace("OCNaroWrappers::OC", "");
           content = content.Replace("Standard_Real", "double");
           content = content.Replace("Standard_Byte", "int");
           content = content.Replace("Standard_Integer", "int");
           content = content.Replace("Standard_Character", "char");
           content = content.Replace("Standard_ExtCharacter", "char");
           content = content.Replace("WNT_Dword", "double");
           content = content.Replace("^", "");

           content = content.Replace("Quantity_Parameter", "double");
           content = content.Replace("Quantity_Length", "double");
           content = content.Replace("Quantity_Factor", "double");
           content = content.Replace("Quantity_PlaneAngle", "double");
           content = content.Replace("Quantity_Ratio", "double");
           content = content.Replace("Quantity_Rate", "double");
           content = content.Replace("Quantity_Coefficient", "double");

           content = content.Replace("Standard_ShortReal", "double");
           content = content.Replace("V3d_Coordinate", "double");
           content = content.Replace("ReturnType=\"OC", "ReturnType=\"");
           content = content.Replace("ParamType=\"OC", "ParamType=\"");

           if (content.Contains("&"))
           {
               content = content.Replace("&", "");
               content = content.Replace("<Parameter ", " <Parameter IsRef=\"true\" ");
           }
           return content;
       }

       public static List<Match> matches = new List<Match>();
       public static List<string> excludedClasses;
    }
}
