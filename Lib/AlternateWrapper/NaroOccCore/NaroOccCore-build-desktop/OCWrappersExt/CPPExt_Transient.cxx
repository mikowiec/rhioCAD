#include <windows.h>

#include <EDL_API.hxx>

#include <MS.hxx>
#include <MS_MetaSchema.hxx>
#include <MS_Class.hxx>
#include <MS_GenClass.hxx>
#include <MS_InstClass.hxx>
#include <MS_Package.hxx>
#include <MS_Error.hxx>
#include <MS_Imported.hxx>

#include <MS_InstMet.hxx>
#include <MS_ClassMet.hxx>
#include <MS_Construc.hxx>
#include <MS_ExternMet.hxx>
 
#include <MS_Param.hxx>
#include <MS_Field.hxx>
#include <MS_GenType.hxx>
#include <MS_Enum.hxx>
#include <MS_PrimType.hxx>

#include <MS_HSequenceOfMemberMet.hxx>
#include <MS_HSequenceOfExternMet.hxx>
#include <MS_HSequenceOfParam.hxx>
#include <MS_HSequenceOfField.hxx>
#include <MS_HSequenceOfGenType.hxx>
#include <MS_HSequenceOfClass.hxx>
#include <TColStd_HSequenceOfHAsciiString.hxx>
#include <TColStd_HSequenceOfInteger.hxx>
#include <TCollection_HAsciiString.hxx>

#include <Standard_NoSuchObject.hxx>

#include <CPPExt_Define.hxx>
#include <WOKTools_Messages.hxx>

// Extraction of a transient handle
void CPP_TransientHandle(const Handle(EDL_API)& api,
						 const Handle(TCollection_HAsciiString)& aClass,
						 const Handle(TCollection_HAsciiString)& aMother,
						 const Handle(TCollection_HAsciiString)& aFileName)
{
	// we create the handle...
	api->AddVariable("%HTName", aClass->ToCString());
	api->AddVariable("%HTInherits", aMother->ToCString());
	api->Apply("%HTHandle", "HandleTransient");

	// ...now we write the result
	api->OpenFile("HTFile", aFileName->ToCString());
	api->WriteFile("HTFile", "%HTHandle");
	api->CloseFile("HTFile");
}

// Extraction of a transient .ixx .jxx and _0.cxx
//   the supplement variable is used for non inline methods generated 
//   by the extractor like destructor (added to .ixx ans _0.cxx
//
void CPP_TransientDerivated(const Handle(MS_MetaSchema)& aMeta,
			    const Handle(EDL_API)& api,
			    const Handle(MS_Class)& aClass,			    
			    const Handle(TColStd_HSequenceOfHAsciiString)& outfile,
			    const Handle(TColStd_HSequenceOfHAsciiString)& inclist,
			    const Handle(TColStd_HSequenceOfHAsciiString)& supplement)
{
  Standard_Integer                        i;
  Handle(TCollection_HAsciiString)        aFileName = new TCollection_HAsciiString;
  Handle(TCollection_HAsciiString)        result    = new TCollection_HAsciiString;
  Handle(MS_StdClass)                     theClass  = Handle(MS_StdClass)::DownCast(aClass);

  // we do this only on standard classes (not on inst classes)
  //
  if (theClass.IsNull()) return;

  api->AddVariable(VClass,aClass->FullName()->ToCString());
  //api->AddVariable(VClassComment,aClass->Comment()->ToCString());

  api->AddVariable(VSuffix,"hxx");
  
  for (i = 1; i <= inclist->Length(); i++) {
    api->AddVariable(VIClass,inclist->Value(i)->ToCString());
    api->Apply(VoutClass,"Include");
    result->AssignCat(api->GetVariableValue(VoutClass));
  }

  if (theClass->GetMyCreator().IsNull()) {
    // include the hxx of me
    //
    api->AddVariable(VIClass,aClass->FullName()->ToCString());
    api->Apply(VoutClass,"Include");
    result->AssignCat(api->GetVariableValue(VoutClass));
    
    api->AddVariable(VoutClass,result->ToCString());

    aFileName->AssignCat(api->GetVariableValue(VFullPath));
    aFileName->AssignCat(aClass->FullName());
    aFileName->AssignCat(".jxx");
  
    CPP_WriteFile(api,aFileName,VoutClass);
    result->Clear();
    outfile->Append(aFileName);
  }

  CPP_ClassTypeMgt(aMeta,api,aClass,VTypeMgt);
  
  aFileName = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
  aFileName->AssignCat(aClass->FullName());

  if (theClass->GetMyCreator().IsNull()) {
    aFileName->AssignCat(".ixx");
  }
  else {
    aFileName->AssignCat("_0.cxx");
  }

  // Supplement
  //
  if (theClass->GetMyCreator().IsNull()) {
    result->Clear();
  }

  for (i = 1; i <= supplement->Length(); i++) {
    result->AssignCat(supplement->Value(i));
  }
  
  api->AddVariable(VSupplement,result->ToCString());
  
  // Methods
  //
  result->Clear();
  
  api->AddVariable(VIClass,MS::GetTransientRootName()->ToCString());
  api->Apply(VMethods,"DownCast");    
  result->AssignCat(api->GetVariableValue(VMethods));
  
  api->Apply(VMethods,"DynamicType");
  result->AssignCat(api->GetVariableValue(VMethods));
  
  api->AddVariable(VIClass,aClass->GetInheritsNames()->Value(1)->ToCString());
  api->Apply(VMethods,"IsKind");
  result->AssignCat(api->GetVariableValue(VMethods));
  
  api->Apply(VMethods,"FullEmptyHandleDestructorTemplate");
  result->AssignCat(api->GetVariableValue(VMethods));

  if (!theClass->GetMyCreator().IsNull()) {
    CPP_GenericDefine(aMeta,api,theClass->GetMyCreator(),VTICDefines,VTICUndefines,Standard_True);
    result->AssignCat(api->GetVariableValue(VTICDefines));
    api->AddVariable(VSuffix,"gxx");
    if (theClass->GetMother().IsNull()) {
      api->AddVariable(VIClass,theClass->GetMyCreator()->GenClass()->ToCString());
    }
    else {
      api->AddVariable(VIClass,theClass->GetMother()->ToCString());
    }
    api->Apply(VMethods,"IncludeNoSafe");
    result->AssignCat(api->GetVariableValue(VMethods));
  }

  if (theClass->GetMyCreator().IsNull()) {
    api->AddVariable(VSuffix,"jxx");
  }
  else {
    api->AddVariable(VSuffix,"hxx");
  }

  api->AddVariable(VMethods,result->ToCString());
  api->Apply(VoutClass,"TransientIxx");
  
  CPP_WriteFile(api,aFileName,VoutClass); 
  
  outfile->Append(aFileName);
}


// Extraction of a transient class (inst or std)
void CPP_TransientClass(const Handle(MS_MetaSchema)& aMeta,
						const Handle(EDL_API)& api,
						const Handle(MS_Class)& aClass,
						const Handle(TColStd_HSequenceOfHAsciiString)& outfile)
{
	Handle(MS_StdClass) theClass = Handle(MS_StdClass)::DownCast(aClass);

	if (!theClass.IsNull())
	{
		Handle(MS_HSequenceOfMemberMet)         methods    = theClass->GetMethods();
		Handle(TCollection_HAsciiString)        publics    = new TCollection_HAsciiString;
		Handle(TCollection_HAsciiString)        cppMets    = new TCollection_HAsciiString;
		Handle(TCollection_HAsciiString)        apiMets    = new TCollection_HAsciiString;

		Standard_Integer                        i;

		api->AddVariable(VClass, theClass->FullName()->ToCString());
		api->AddVariable(VClassComment, theClass->Comment()->ToCString());

		api->AddVariable("%UseHandle", "yes");
		api->AddVariable("%CppConTemplate", "CppHandleConstructor");
		api->AddVariable("%Abstract", "");
		if (aClass->Deferred())
		{
			api->AddVariable("%Abstract", "abstract");
		}
		
		publics->Clear();
		publics->AssignCat(": OC");
		publics->AssignCat(theClass->GetInheritsNames()->Value(1)->ToCString());
		api->AddVariable(VInherits, publics->ToCString());

		Handle(TCollection_HAsciiString) hdr = new TCollection_HAsciiString;
		if (theClass->GetInherits()->Value(1)->Package()->Name()->IsDifferent(theClass->Package()->Name()))
		{
			hdr->AssignCat("../");
			hdr->AssignCat(theClass->GetInherits()->Value(1)->Package()->Name()->ToCString());
			hdr->AssignCat("/");
		}
		hdr->AssignCat(theClass->GetInheritsNames()->Value(1)->ToCString());
		api->AddVariable("%Header", hdr->ToCString());
		api->Apply("%VTemp", "HeaderIncludeDef");
		api->AddVariable("%IncludeInherits", api->GetVariableValue("%VTemp")->ToCString());
		api->AddVariable("%IncludeApiInherits", "");
		api->AddVariable("%BaseClass", theClass->GetInheritsNames()->Value(1)->ToCString());
		api->Apply("%VTemp", "DummyCtorDef");
		api->AddVariable("%NativeWrapp", api->GetVariableValue("%VTemp")->ToCString());

		api->Apply("%VTemp", "CallBaseConstructorDef");
		api->AddVariable("%CallBaseCtor", api->GetVariableValue("%VTemp")->ToCString());

		publics->Clear();
		cppMets->Clear();
		apiMets->Clear();
		for (i = 1; i <= methods->Length(); i++)
		{
			Standard_Boolean isStatic = Standard_False;
			// if the class has no destructor we give it
			if (methods->Value(i)->IsDestructor())
			{
				// ignore it!
				continue;
			}
		
			//api->AddVariable("%CppMetTemplate", "CppMethod"); // paul : unique for now
			if (strcmp(theClass->FullName()->ToCString(), "MFT_FontManager") == 0)
			{
				api->AddVariable("%IsOverriden", "no");
			}
			api->AddVariable("%IsOverriden", "no");
			if (theClass->GetInherits()->Length() > 0)
			{
					Handle(TCollection_HAsciiString) apiInherit = new TCollection_HAsciiString;
				apiInherit->AssignCat("<Implements Name=\"");
				apiInherit->AssignCat(theClass->GetInheritsNames()->Value(1)->ToCString());
				apiInherit->AssignCat("\" />");
				api->AddVariable("%IncludeApiInherits", apiInherit->ToCString());
				Standard_Boolean isOverriden = Standard_False;

				Handle(MS_Class) tmpClass;
				tmpClass = theClass;
				while ((tmpClass->GetInherits()->Length() > 0) && (isOverriden == Standard_False))
				{
					for (int j=1; j <= tmpClass->GetInherits()->Value(1)->GetMethods()->Length(); j++)
					{
						Handle(TCollection_HAsciiString) a1 = new TCollection_HAsciiString;
						Handle(TCollection_HAsciiString) a2 = new TCollection_HAsciiString;
						a1->AssignCat(methods->Value(i)->FullName()->ToCString());
						a2->AssignCat(tmpClass->GetInherits()->Value(1)->GetMethods()->Value(j)->FullName()->ToCString());
						if (methods->Value(i)->IsSameSignature(tmpClass->GetInherits()->Value(1)->GetMethods()->Value(j)->FullName()))
						{
							isOverriden = Standard_True;
							if (tmpClass->GetInherits()->Value(1)->GetMethods()->Value(j)->IsKind(STANDARD_TYPE(MS_InstMet)))
							{
								Handle(MS_InstMet)	im = *((Handle(MS_InstMet)*)&tmpClass->GetInherits()->Value(1)->GetMethods()->Value(j));
								if (im->IsDeferred())
								{
									isOverriden = Standard_False;
								}
								else
								{
									if (im->IsStatic())
									{
										isStatic = Standard_True;
										isOverriden = Standard_False;
									}
									else
									{
										isStatic = Standard_False;
									}
								}
							}
							if (isOverriden)
							{
								break;
							}
						}
					}
					if (isOverriden)
					{
						api->AddVariable("%IsOverriden", "yes");
					}
					tmpClass = tmpClass->GetInherits()->Value(1);
				}
			}
			
			api->AddVariable("%IsAbstract", "no");
			CPP_BuildMethod(aMeta, api, methods->Value(i), methods->Value(i)->Name());

			api->Apply(VMethod, "MethodTemplateDec");
			api->Apply("%CppMethod", "CppMethodTemplateDec");
			api->Apply("%ApiMethod", "ApiMethodTemplateDec");
			if (!methods->Value(i)->Private() && !methods->Value(i)->IsProtected())
			{
				if (strcmp(api->GetVariableValue("%IsAbstract")->ToCString(), "yes") != 0)
				{
					publics->AssignCat(api->GetVariableValue(VMethod));
					cppMets->AssignCat(api->GetVariableValue("%CppMethod"));
					apiMets->AssignCat(api->GetVariableValue("%ApiMethod"));
				}
			}
		}

		// add the destructor
		api->Apply("%VTemp", "DestructorHandleHeader");
		publics->AssignCat(api->GetVariableValue("%VTemp")->ToCString());

		api->AddVariable(VTICPublicmets, publics->ToCString());
		api->AddVariable("%CppMethods", cppMets->ToCString());
		api->AddVariable("%ApiMethods", apiMets->ToCString());
		publics->Clear();
		cppMets->Clear();
		apiMets->Clear();
		Handle(TColStd_HSequenceOfHAsciiString) List = new TColStd_HSequenceOfHAsciiString;
		Handle(TColStd_HSequenceOfHAsciiString) incp = new TColStd_HSequenceOfHAsciiString;
		CPP_UsedTypes(aMeta, theClass, List, incp);

		api->AddVariable(VSuffix, "h");
		for (i = 1; i <= List->Length(); i++)
		{
			if (aMeta->IsDefined(List->Value(i)))
			{
				cppMets->AssignCat(List->Value(i)->ToCString());
				if (aMeta->GetType(List->Value(i))->IsKind(STANDARD_TYPE(MS_Enum)))
				{
					if (!List->Value(i)->IsSameString(theClass->FullName()))
					{

						Handle(TCollection_HAsciiString) iEnum = new TCollection_HAsciiString;
						Handle(MS_Enum) enm =*((Handle(MS_Enum)*)&aMeta->GetType(List->Value(i)));
						if (enm->Package()->Name()->IsDifferent(aClass->Package()->Name()))
						{
							iEnum->AssignCat("../");
							iEnum->AssignCat(enm->Package()->Name()->ToCString());
							iEnum->AssignCat("/");
						}
						iEnum->AssignCat(List->Value(i)->ToCString());
						api->AddVariable("%Header", iEnum->ToCString());
						api->Apply("%VTemp", "HeaderIncludeDef");
						publics->AssignCat(api->GetVariableValue("%VTemp")->ToCString());
					}
				}
				else if (aMeta->GetType(List->Value(i))->IsKind(STANDARD_TYPE(MS_Class)))
				{
					if (!List->Value(i)->IsSameString(theClass->FullName()) &&
						!List->Value(i)->IsSameString(theClass->GetInheritsNames()->Value(1)))
					{
						Handle(TCollection_HAsciiString) iClass = new TCollection_HAsciiString;
						Handle(MS_Class) cls =*((Handle(MS_Class)*)&aMeta->GetType(List->Value(i)));
						if (cls->Package()->Name()->IsDifferent(aClass->Package()->Name()))
						{
							iClass->AssignCat("../");
							iClass->AssignCat(cls->Package()->Name()->ToCString());
							iClass->AssignCat("/");
						}
						iClass->AssignCat(List->Value(i)->ToCString());
						api->AddVariable("%Header", iClass->ToCString());
						api->Apply("%VTemp", "HeaderIncludeDef");
						publics->AssignCat(api->GetVariableValue("%VTemp")->ToCString());
						/*	Handle(TCollection_HAsciiString) apiInherit = new TCollection_HAsciiString;
				apiInherit->AssignCat("<Implements Name=\"");
				apiInherit->AssignCat(theClass->GetInheritsNames()->Value(1)->ToCString());
				apiInherit->AssignCat("\" />");
				api->AddVariable("%IncludeApiInherits", apiInherit->ToCString());*/
					}
				}
			}
		}
		api->AddVariable("%IncludeHeaders", publics->ToCString());

		publics->Clear();
		cppMets->Clear();

		api->AddVariable(VSuffix, "h");
		for (i = 1; i <= incp->Length(); i++)
		{
			if (aMeta->GetType(incp->Value(i))->IsKind(STANDARD_TYPE(MS_Error)))
			{
					continue;
			}
			if (!incp->Value(i)->IsSameString(theClass->FullName()))
			{
				Handle(TCollection_HAsciiString) iClass = new TCollection_HAsciiString;
				Handle(MS_Class) cls =*((Handle(MS_Class)*)&aMeta->GetType(incp->Value(i)));
				if (strcmp(cls->Package()->Name()->ToCString(), "TCollection_MapNode") == 0)
				{
					iClass->AssignCat(cls->Package()->Name()->ToCString());
					iClass->AssignCat(aClass->Package()->Name()->ToCString());
					iClass->Clear();
				}
				if (cls->Package()->Name()->IsDifferent(aClass->Package()->Name()))
				{
					iClass->AssignCat("../");
					iClass->AssignCat(cls->Package()->Name()->ToCString());
					iClass->AssignCat("/");
				}
				iClass->AssignCat(incp->Value(i)->ToCString());
				api->AddVariable(VIClass, incp->Value(i)->ToCString());
				api->Apply(VTICIncludes, "ShortDec");
				api->AddVariable(VIClass, iClass->ToCString());
				api->Apply("%TCppIncludes", "CppShortDec");
				publics->AssignCat(api->GetVariableValue(VTICIncludes));
				cppMets->AssignCat(api->GetVariableValue("%TCppIncludes"));
			}
		}
		api->AddVariable(VTICIncludes, publics->ToCString());
		api->AddVariable("%CppIncludes", cppMets->ToCString());

		Handle(TCollection_HAsciiString) aDir = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
		aDir->AssignCat("\\");
		aDir->AssignCat(aClass->Package()->Name()->ToCString());
		aDir->AssignCat("\\");
		CreateDirectory(aDir->ToCString(), NULL);

		Handle(TCollection_HAsciiString) aFile = new TCollection_HAsciiString(aDir->ToCString());
		aFile->AssignCat(theClass->FullName());
		aFile->AssignCat(".h");
		api->Apply(VoutClass, "TransientClass");
		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);

		api->Apply("%VTemp", "CtorFromNativeHandle");
		api->AddVariable("%CtorFromNative", api->GetVariableValue("%VTemp")->ToCString());
		aFile->Clear();
		aFile->AssignCat(aDir->ToCString());
		aFile->AssignCat(theClass->FullName());
		aFile->AssignCat(".cpp");
		api->Apply(VoutClass, "CppExtraction");
		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);

		//  new xml stuff
		aFile->Clear();
		aFile->AssignCat(aDir->ToCString());
		aFile->AssignCat(theClass->FullName());
		aFile->AssignCat(".api_base");
		api->Apply(VoutClass, "APITransient");
		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);

		//CPP_TransientDerivated(aMeta,api,aClass,outfile,incp,Supplement);
	}
	else
	{
		ErrorMsg << "CPPExt " << "CPP_TransientClass - the class is NULL..." << endm;
		Standard_NoSuchObject::Raise();
	}
}

