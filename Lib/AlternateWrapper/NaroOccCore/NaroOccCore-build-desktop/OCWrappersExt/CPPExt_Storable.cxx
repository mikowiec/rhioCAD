// CLE
//    
// 10/1995
//
#include <stdio.h>
#include <windows.h>

#include <MS.hxx>

#include <EDL_API.hxx>

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
#include <MS_HSequenceOfField.hxx>
#include <MS_HSequenceOfGenType.hxx>
#include <MS_HSequenceOfClass.hxx>
#include <MS_HArray1OfParam.hxx>

#include <TColStd_HSequenceOfHAsciiString.hxx>
#include <TColStd_HSequenceOfInteger.hxx>

#include <TCollection_HAsciiString.hxx>

#include <Standard_NoSuchObject.hxx>

#include <CPPExt_Define.hxx>
#include <WOKTools_Messages.hxx>

// WARNING: DB Dependent functions
//
void CPP_BuildVArrayDeclarationOBJY(const Handle(MS_MetaSchema)&,const Handle(EDL_API)&,const Handle(MS_StdClass)&,const Handle(TCollection_HAsciiString)&);
void CPP_BuildVArrayFieldOBJY(const Handle(MS_MetaSchema)&,const Handle(EDL_API)&,const Handle(MS_StdClass)&,const Handle(TCollection_HAsciiString)&);

void CPP_BuildVArrayDeclarationCSFDB(const Handle(MS_MetaSchema)&,const Handle(EDL_API)&,const Handle(MS_StdClass)&,const Handle(TCollection_HAsciiString)&);
void CPP_BuildVArrayFieldCSFDB(const Handle(MS_MetaSchema)&,const Handle(EDL_API)&,const Handle(MS_StdClass)&,const Handle(TCollection_HAsciiString)&);

void CPP_BuildVArrayDeclarationOBJS(const Handle(MS_MetaSchema)&,const Handle(EDL_API)&,const Handle(MS_StdClass)&,const Handle(TCollection_HAsciiString)&);
void CPP_BuildVArrayFieldOBJS(const Handle(MS_MetaSchema)&,const Handle(EDL_API)&,const Handle(MS_StdClass)&,const Handle(TCollection_HAsciiString)&);

Handle(TCollection_HAsciiString) CPP_BuildFieldOBJY(const Handle(MS_MetaSchema)& aMeta,
						    const Handle(MS_Field)& aField);
// create a VArray dependent declaration for DBC instance
//
void CPP_BuildVArrayDeclaration(const Handle(MS_MetaSchema)& aMeta, 
			      const Handle(EDL_API)& api, 
			      const Handle(MS_StdClass)& aClass,
			      const Handle(TCollection_HAsciiString)& Result)
{
  if (!strcmp(api->GetVariableValue("%CPPEXTDBMS")->ToCString(),"OBJY")) {
    CPP_BuildVArrayDeclarationOBJY(aMeta,api,aClass,Result);
  }
  else if (!strcmp(api->GetVariableValue("%CPPEXTDBMS")->ToCString(),"OBJS")) {
    CPP_BuildVArrayDeclarationOBJS(aMeta,api,aClass,Result);
  }
  else if (!strcmp(api->GetVariableValue("%CPPEXTDBMS")->ToCString(),"CSFDB")) {
    CPP_BuildVArrayDeclarationCSFDB(aMeta,api,aClass,Result);
  }
}

// create a VArray dependent field for DBC instance
//
void CPP_BuildVArrayField(const Handle(MS_MetaSchema)& aMeta, 
			      const Handle(EDL_API)& api, 
			      const Handle(MS_StdClass)& aClass,
			      const Handle(TCollection_HAsciiString)& Result)
{
  if (!strcmp(api->GetVariableValue("%CPPEXTDBMS")->ToCString(),"OBJY")) {
    CPP_BuildVArrayFieldOBJY(aMeta,api,aClass,Result);    
  }
  else if (!strcmp(api->GetVariableValue("%CPPEXTDBMS")->ToCString(),"OBJS")) {
    CPP_BuildVArrayFieldOBJS(aMeta,api,aClass,Result);    
  }
  else if (!strcmp(api->GetVariableValue("%CPPEXTDBMS")->ToCString(),"CSFDB")) {
    CPP_BuildVArrayFieldCSFDB(aMeta,api,aClass,Result);    
  }
}

// CSFDB extension for storable classes
//   only if %CPPEXTDBMS == "CSFDB"
//
void CPP_BuildStorableAccessFieldCSFDB(const Handle(MS_MetaSchema)& aMeta,
				       const Handle(EDL_API)& api,
				       const Handle(MS_Field)& field,
				       const Handle(TCollection_HAsciiString)& publics)
{
 Handle(MS_Type) thetype = aMeta->GetType(field->TYpe());

  if (field->Dimensions()->Length() > 0) {
    Standard_Integer                 i;
    Handle(TCollection_HAsciiString) sdim = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString) ddim = new TCollection_HAsciiString;
    Handle(TCollection_HAsciiString) vdim = new TCollection_HAsciiString;
    char                             num[30];
    
    
    api->AddVariable("%CSFDBType",CPP_BuildType(aMeta,field->TYpe())->ToCString());
    api->AddVariable("%Field",field->Name()->ToCString());
    
    for (i = 1; i <= field->Dimensions()->Length(); i++) {
      sdim->AssignCat("[");
      sprintf(num,"%d",i);
      sdim->AssignCat("i");
      sdim->AssignCat(num);
      sdim->AssignCat("]");
      
      if (i != 1) {
	vdim->AssignCat(",");
	ddim->AssignCat(",");
      }
      vdim->AssignCat("const Standard_Integer i");
      vdim->AssignCat(num);
      
      ddim->AssignCat("i");
      ddim->AssignCat(num);
    }
    api->AddVariable("%FDim",sdim->ToCString());
    api->AddVariable("%VarDim",vdim->ToCString());
    api->AddVariable("%Dimension",ddim->ToCString());
    api->Apply("%res","DefFuncFieldArray");
  }
  else {
    api->AddVariable("%CSFDBType",field->TYpe()->ToCString());
    api->AddVariable("%Field",field->Name()->ToCString());
    
    if (thetype->IsKind(STANDARD_TYPE(MS_StdClass))) {
      Handle(MS_StdClass) aclass = *((Handle(MS_StdClass)*)&thetype);
      
      if (aclass->IsPersistent()) {
	api->Apply("%res","DefFuncPField");
      }
      else {
	api->Apply("%res","DefFuncSField");
      }
    }
    else {
      api->Apply("%res","DefFuncPrField");
    }
  }

  publics->AssignCat(api->GetVariableValue("%res"));
}

// Extraction of a transient .ixx .jxx and _0.cxx
//   the supplement variable is used for non inline methods generated 
//   by the extractor like destructor (added to .ixx ans _0.cxx
//
void CPP_StorableDerivated(const Handle(MS_MetaSchema)& aMeta,
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
    // include hxx of me
    //
    api->AddVariable(VIClass,aClass->FullName()->ToCString());
#ifdef WNT
    api->Apply(VoutClass,"IncludeNoSafe");
#else 
    api->Apply(VoutClass,"Include");
#endif
    result->AssignCat(api->GetVariableValue(VoutClass));
    
    api->AddVariable(VoutClass,result->ToCString());

    aFileName->AssignCat(api->GetVariableValue(VFullPath));
    aFileName->AssignCat(aClass->FullName());
    aFileName->AssignCat(".jxx");
  
    CPP_WriteFile(api,aFileName,VoutClass);
    result->Clear();
    outfile->Append(aFileName);
  }
  
  aFileName = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
  aFileName->AssignCat(aClass->FullName());

  if (theClass->GetMyCreator().IsNull()) {
    aFileName->AssignCat(".ixx");
  }
  else {
    aFileName->AssignCat("_0.cxx");
  }

  if (theClass->GetMyCreator().IsNull()) {
    result->Clear();
  }

  // Type Management and supplement
  //  
  for (i = 1; i <= supplement->Length(); i++) {
    result->AssignCat(supplement->Value(i));
  }

  CPP_ClassTypeMgt(aMeta,api,aClass,VTypeMgt);

  result->AssignCat(api->GetVariableValue(VTypeMgt));
 
  api->AddVariable(VSupplement,result->ToCString());
  
  // Methods
  //
  result->Clear();
  
  if (!theClass->GetMyCreator().IsNull()) {
    CPP_GenericDefine(aMeta,api,theClass->GetMyCreator(),VTICDefines,VTICUndefines,Standard_False);
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

  api->AddVariable(VMethods,result->ToCString());

  if (theClass->GetMyCreator().IsNull()) {
    api->AddVariable(VSuffix,"jxx");
  }
  else {
    api->AddVariable(VSuffix,"hxx");
  }

  api->AddVariable(VClass,aClass->FullName()->ToCString());

  api->Apply(VoutClass,"StorableIxx");

  CPP_WriteFile(api,aFileName,VoutClass); 
  
  outfile->Append(aFileName);
}


// Extraction of a transient class (inst or std)
//
void CPP_StorableClass(const Handle(MS_MetaSchema)& aMeta,
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

		Standard_Integer                        i;
		Standard_Boolean						HasEmptyConst   = Standard_False,
												HasConstructor  = Standard_False;

		api->AddVariable(VClass, theClass->FullName()->ToCString());
		api->AddVariable(VClassComment, theClass->Comment()->ToCString());

		api->AddVariable(VInherits, "");
		api->AddVariable("%IncludeInherits", "");

		// do not call base ctor unless is necesarry
		api->AddVariable("%CallBaseCtor", "");

		api->AddVariable("%NativeWrapp", "public:");
		if (theClass->GetInheritsNames()->Length() > 0)
		{
			//if (!theClass->GetInheritsNames()->Value(1)->IsSameString(MS::GetStorableRootName()))
			if (theClass->IsPersistent() || theClass->IsTransient())
			{
				api->AddVariable("%CppConTemplate", "CppHandleConstructor");
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

			Handle(TCollection_HAsciiString) apiInherit = new TCollection_HAsciiString;

			apiInherit->AssignCat("<Implements Name=\"");
			apiInherit->AssignCat(theClass->GetInheritsNames()->Value(1)->ToCString());
			apiInherit->AssignCat("\" />");
			
			api->AddVariable("%IncludeApiInherits", apiInherit->ToCString());


			api->AddVariable("%BaseClass", theClass->GetInheritsNames()->Value(1)->ToCString());
			api->Apply("%VTemp", "DummyCtorDef");
			api->AddVariable("%NativeWrapp", api->GetVariableValue("%VTemp")->ToCString());

			api->Apply("%VTemp", "CallBaseConstructorDef");
			api->AddVariable("%CallBaseCtor", api->GetVariableValue("%VTemp")->ToCString());
		}
		else
		{
			api->Apply("%VTemp", "ManipulateByValueDef");
			api->AddVariable("%NativeWrapp", api->GetVariableValue("%VTemp")->ToCString());
		}

		// take care of the constructor
		api->Apply("%VTemp", "CtorFromNative");
		api->AddVariable("%CtorFromNative", api->GetVariableValue("%VTemp")->ToCString());

		publics->Clear();
		cppMets->Clear();
		// extraction of the methods
		for (i = 1; i <= methods->Length(); i++)
		{
			Standard_Boolean isStatic = Standard_False;
			// if the class has no destructor we give it
			if (methods->Value(i)->IsDestructor())
			{
				// ignore it
				continue;
			}
			// if the class has no empty constructor, we give it
			if (methods->Value(i)->IsKind(STANDARD_TYPE(MS_Construc)))
			{
				if (methods->Value(i)->Params().IsNull())
				{
					HasEmptyConst = Standard_True;
				}
				HasConstructor = Standard_True;
			}

			if (strcmp(theClass->FullName()->ToCString(), "StdSelect_ViewerSelector2d") == 0)
			{
				api->AddVariable("%IsOverriden", "no");
			}
			api->AddVariable("%IsOverriden", "no");
			if (theClass->GetInherits()->Length() > 0)
			{
				Standard_Boolean isOverriden = Standard_False;

				Handle(MS_Class) tmpClass;
				tmpClass = theClass;
				while ((tmpClass->GetInherits()->Length() > 0) && (isOverriden == Standard_False))
				{
					for (int j=1; j <= tmpClass->GetInherits()->Value(1)->GetMethods()->Length(); j++)
					{
						Handle(TCollection_HAsciiString) a1 = new TCollection_HAsciiString;
						Handle(TCollection_HAsciiString) a2 = new TCollection_HAsciiString;
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
						a1->AssignCat(methods->Value(i)->FullName()->ToCString());
						a2->AssignCat(tmpClass->GetInherits()->Value(1)->GetMethods()->Value(j)->FullName()->ToCString());
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
				}
			}
		}

		if (!HasEmptyConst && (aClass->GetFields()->Length() > 0))
		{
			api->AddVariable("%Class", aClass->FullName()->ToCString());
			api->AddVariable("%CLIArguments", " ");
			api->Apply(VMethod, "ConstructorHeader");
			api->AddVariable(VMBody, "");
			api->Apply(VMethod, "MethodTemplateDef");
			publics->AssignCat(api->GetVariableValue(VMethod));
		}
		
		// add the destructor
		if (theClass->IsPersistent() || theClass->IsTransient())
		{
			api->Apply("%VTemp", "DestructorHandleHeader");
		}
		else
		{
			api->Apply("%VTemp", "DestructorHeader");
		}
		publics->AssignCat(api->GetVariableValue("%VTemp")->ToCString());

		api->AddVariable(VTICPublicmets, publics->ToCString());
		api->AddVariable("%CppMethods", cppMets->ToCString());
		publics->Clear();
		cppMets->Clear();

		Handle(TColStd_HSequenceOfHAsciiString) List = new TColStd_HSequenceOfHAsciiString;
		Handle(TColStd_HSequenceOfHAsciiString) incp = new TColStd_HSequenceOfHAsciiString;
		CPP_UsedTypes(aMeta, theClass, List, incp);
		
		api->AddVariable(VSuffix, "h");
		for (i = 1; i <= List->Length(); i++)
		{
			if (aMeta->IsDefined(List->Value(i)))
			{
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
					if ((theClass->GetInheritsNames()->Length() > 0) &&
						List->Value(i)->IsSameString(theClass->GetInheritsNames()->Value(1)))
						continue;

					if (!List->Value(i)->IsSameString(theClass->FullName()))
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
					}
				}
			}
		}
		api->AddVariable("%IncludeHeaders", publics->ToCString());

		publics->Clear();

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
		api->AddVariable("%ApiIncludes", publics->ToCString());
		Handle(TCollection_HAsciiString) aDir = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
		aDir->AssignCat("\\");
		aDir->AssignCat(aClass->Package()->Name()->ToCString());
		aDir->AssignCat("\\");
		CreateDirectory(aDir->ToCString(), NULL);

		Handle(TCollection_HAsciiString) aFile = new TCollection_HAsciiString(aDir->ToCString());
		aFile->AssignCat(theClass->FullName());
		aFile->AssignCat(".h");
		api->Apply(VoutClass, "StorableClass");
		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);

		aFile->Clear();
		aFile->AssignCat(aDir->ToCString());
		aFile->AssignCat(theClass->FullName());
		aFile->AssignCat(".cpp");
		api->Apply(VoutClass, "CppExtraction");
		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);


		//CPP_StorableDerivated(aMeta,api,aClass,outfile,incp,Supplement);
	}
	else
	{
		ErrorMsg << "CPPExt " << "CPP_StorableClass - the class is NULL..." << endm;
		Standard_NoSuchObject::Raise();
	}
}

