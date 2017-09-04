#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using ErrorReportCommon.Messages;
using ICSharpCode.SharpZipLib.Zip;
using NaroCppCore.Occ.IFSelect;
using NaroCppCore.Occ.STEPControl;
using NaroCppCore.Occ.TopTools;
using NaroCppCore.Occ.TopoDS;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class MeshTopoShapeInterpreter : AttributeInterpreterBase
    {
        #region Properties

        public TopoDSShape Shape
        {
            get { return _value; }
            set
            {
                _value = value;
                OnModified();
            }
        }

        #endregion

        #region Overridden methods

        public override void Serialize(AttributeData data)
        {
            SerializeMesh(data);
        }

        public override void Deserialize(AttributeData data)
        {
            DeserializeMesh(data);
        }

        #endregion

        #region Methods

        private void SerializeMesh(AttributeData data)
        {
            var shapes = new List<TopoDSShape> {Shape};
            SaveShapeToStep(shapes, DiffFileName);
            var filedata = FileToData(DiffFileName);
            var compressedData = Pack(filedata);
            var str = Convert.ToBase64String(compressedData);
            data.WriteAttribute("Data", str);
            File.Delete(DiffFileName);
        }

        private void DeserializeMesh(AttributeData data)
        {
            var dataString = data.ReadAttributeString("Data");
            var compressedData = Convert.FromBase64String(dataString);
            var fileData = Unpack(compressedData);
            var fileStream = File.OpenWrite(DiffFileName);
            fileStream.Write(fileData, 0, fileData.Length);
            fileStream.Close();
            LoadStepFile(DiffFileName);
            File.Delete(DiffFileName);
        }

        public static void SaveShapeToStep(IEnumerable<TopoDSShape> shapes, string fileName)
        {
            var aWriter = new STEPControlWriter();
            foreach (var shape in shapes)
                if (shape != null)
                {
                    aWriter.Transfer(shape, STEPControlStepModelType.STEPControl_ShellBasedSurfaceModel, true);
                }

            var status = aWriter.Write(fileName);
            if (status == IFSelectReturnStatus.IFSelect_RetError ||
                status == IFSelectReturnStatus.IFSelect_RetFail)
                NaroMessage.Show("Error has occured while saving to STEP format");
        }

        public static byte[] FileToData(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    var fs = File.OpenRead(fileName);
                    var data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    fs.Close();
                    return data;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public static byte[] Pack(byte[] data)
        {
            var memStream = new MemoryStream();
            if (data != null)
            {
                var zipOutput = new ZipOutputStream(memStream);

                var entry = new ZipEntry("file.data");
                zipOutput.PutNextEntry(entry);

                zipOutput.Write(data, 0, data.Length);

                zipOutput.CloseEntry();
                zipOutput.Close();
            }
            return memStream.ToArray();
        }

        public static byte[] Unpack(byte[] compressedData)
        {
            var memZipStream = new MemoryStream(compressedData);
            var memStream = new MemoryStream();
            var zipInput = new ZipInputStream(memZipStream);
            zipInput.GetNextEntry();

            int size;
            var data = new byte[2048];

            do
            {
                size = zipInput.Read(data, 0, data.Length);
                memStream.Write(data, 0, size);
            } while (size > 0);

            var streamdata = memStream.ToArray();
            zipInput.CloseEntry();
            zipInput.Close();
            memStream.Close();
            return streamdata;
        }


        private void LoadStepFile(string fileName)
        {
            var aReader = new STEPControlReader();

            aReader.ReadFile(fileName);
            aReader.WS().MapReader().TraceLevel = (2); // increase default trace level

            aReader.PrintCheckLoad(false, IFSelectPrintCount.IFSelect_ItemsByEntity);

            // Root transfers
            var nbr = aReader.NbRootsForTransfer;
            aReader.PrintCheckTransfer(false, IFSelectPrintCount.IFSelect_ItemsByEntity);

            for (var n = 1; n <= nbr; n++)
            {
                aReader.TransferRoot(n);
            } // Collecting resulting entities

            var nbs = aReader.NbShapes;

            var aSequence = new TopToolsHSequenceOfShape();
            for (var i = 1; i <= nbs; i++)
            {
                aSequence.Append(aReader.Shape(i));
            }
            Shape = aSequence.Value(1);
        }

        #endregion

        #region Data members

        private const string DiffFileName = "diff.step";
        private TopoDSShape _value;

        #endregion
    }
}