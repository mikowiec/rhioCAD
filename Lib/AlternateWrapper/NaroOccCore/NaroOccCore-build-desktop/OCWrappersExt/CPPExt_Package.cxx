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
#include <MS_HSequenceOfParam.hxx>
#include <MS_HSequenceOfField.hxx>
#include <MS_HSequenceOfGenType.hxx>
#include <TColStd_HSequenceOfHAsciiString.hxx>
#include <TColStd_HSequenceOfInteger.hxx>

#include <TCollection_HAsciiString.hxx>

#include <Standard_NoSuchObject.hxx>

#include <CPPExt_Define.hxx>
#include <WOKTools_Messages.hxx>

// Extraction of a transient .ixx .jxx and _0.cxx
//   the supplement variable is used for non inline methods generated 
//   by the extractor like destructor (added to .ixx ans _0.cxx
//
void CPP_PackageDerivated(const Handle(MS_MetaSchema)& ,
			    const Handle(EDL_API)& api,
			    const Handle(MS_Package)& aPackage,			    
			    const Handle(TColStd_HSequenceOfHAsciiString)& outfile,
			    const Handle(TColStd_HSequenceOfHAsciiString)& inclist,
			    const Handle(TColStd_HSequenceOfHAsciiString)& supplement)
{
  Standard_Integer                        i;
  Handle(TCollection_HAsciiString)        aFileName = new TCollection_HAsciiString;
  Handle(TCollection_HAsciiString)        result    = new TCollection_HAsciiString;

  api->AddVariable(VClass,aPackage->Name()->ToCString());
  //api->AddVariable(VClassComment,aPackage->Comment()->ToCString());
  api->AddVariable(VSuffix,"hxx");
  
  for (i = 1; i <= inclist->Length(); i++) {
    api->AddVariable(VIClass,inclist->Value(i)->ToCString());
    api->Apply(VoutClass,"Include");
    result->AssignCat(api->GetVariableValue(VoutClass));
  }


  // include hxx of me
  //
  api->AddVariable(VIClass,aPackage->Name()->ToCString());
#ifdef WNT
  api->Apply(VoutClass,"IncludeNoSafe");
#else 
  api->Apply(VoutClass,"Include");
#endif
  result->AssignCat(api->GetVariableValue(VoutClass));
  
  api->AddVariable(VoutClass,result->ToCString());
  
  aFileName->AssignCat(api->GetVariableValue(VFullPath));
  aFileName->AssignCat(aPackage->Name());
  aFileName->AssignCat(".jxx");
  
  CPP_WriteFile(api,aFileName,VoutClass);

  outfile->Append(aFileName);

  aFileName = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
  aFileName->AssignCat(aPackage->Name());
  aFileName->AssignCat(".ixx");

  // Supplement
  //
  result->Clear();

  for (i = 1; i <= supplement->Length(); i++) {
    result->AssignCat(supplement->Value(i));
  }
  
  api->AddVariable(VSupplement,result->ToCString());
  
  // Methods
  //
  result->Clear();
  
  api->AddVariable(VSuffix,"jxx");

  api->AddVariable(VClass,aPackage->Name()->ToCString());

  api->Apply(VoutClass,"MPVIxx");

  CPP_WriteFile(api,aFileName,VoutClass); 
  

  outfile->Append(aFileName);
}


// Extraction of a transient class (inst or std)
//
void CPP_Package(const Handle(MS_MetaSchema)& aMeta,
		 const Handle(EDL_API)& api,
		 const Handle(MS_Package)& aPackage,
		 const Handle(TColStd_HSequenceOfHAsciiString)& outfile)
{
	if (!aPackage.IsNull())
	{
		Handle(MS_HSequenceOfExternMet)         methods    = aPackage->Methods();
		if (methods->Length() <= 0)
		{
			return;
		}

		Handle(TCollection_HAsciiString)        publics    = new TCollection_HAsciiString;
		Handle(TCollection_HAsciiString)        cppMets    = new TCollection_HAsciiString;
		Handle(TColStd_HSequenceOfHAsciiString) packClass  = aPackage->Classes();
		Handle(TCollection_HAsciiString)        apiMets    = new TCollection_HAsciiString;

		Standard_Integer                        i;

		Handle(TColStd_HSequenceOfHAsciiString) List = new TColStd_HSequenceOfHAsciiString;
		Handle(TColStd_HSequenceOfHAsciiString) incp = new TColStd_HSequenceOfHAsciiString;

		api->AddVariable(VClass, aPackage->FullName()->ToCString());
		api->AddVariable(VClassComment, aPackage->Comment()->ToCString());

		api->AddVariable(VTICIncludes,"");
		api->AddVariable(VInherits,"");
		api->AddVariable(VMethods,"");

		// extraction of the methods
		//
		publics->Clear();
		cppMets->Clear();
		apiMets->Clear();
		for (i = 1; i <= methods->Length(); i++)
		{
			api->AddVariable("%CallBaseClass", "");
			api->AddVariable("%CallBaseCtor", "");
			api->AddVariable("%DmyCtorParams", "");
			CPP_BuildMethod(aMeta, api, methods->Value(i), methods->Value(i)->Name());

			api->Apply(VMethod, "MethodTemplateDec");
			api->Apply("%CppMethod", "CppMethodTemplateDec");
			api->Apply("%ApiMethod", "ApiMethodTemplateDec");
			if (!methods->Value(i)->Private())
			{
				publics->AssignCat(api->GetVariableValue(VMethod));
				cppMets->AssignCat(api->GetVariableValue("%CppMethod"));
				apiMets->AssignCat(api->GetVariableValue("%ApiMethod"));
			}
		}
		api->AddVariable(VTICPublicmets,publics->ToCString());
		api->AddVariable("%CppMethods", cppMets->ToCString());
		api->AddVariable("%ApiMethods", apiMets->ToCString());
		publics->Clear();
		cppMets->Clear();
		apiMets->Clear();
		if (methods->Length() > 0)
		{
			MS::MethodUsedTypes(aMeta,methods->Value(i),List,incp);
		}


		api->AddVariable(VSuffix,"h");
		for (i = 1; i <= packClass->Length(); i++) {
		  Handle(TCollection_HAsciiString) name = MS::BuildFullName(aPackage->Name(), packClass->Value(i));
		  api->AddVariable(VIClass, name->ToCString());
		  api->Apply(VTICIncludes,"CppShortDec");
		  publics->AssignCat(api->GetVariableValue(VTICIncludes));
		}
		api->AddVariable(VTICIncludes,publics->ToCString());

		Handle(TCollection_HAsciiString) aDir = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
		aDir->AssignCat("\\");
		aDir->AssignCat(aPackage->Name()->ToCString());
		aDir->AssignCat("\\");
		CreateDirectory(aDir->ToCString(), NULL);
		Handle(TCollection_HAsciiString) aFile = new TCollection_HAsciiString(aDir->ToCString());
		aFile->AssignCat(aPackage->Name());
		aFile->AssignCat(".h");
		api->Apply(VoutClass,"Package");
		CPP_WriteFile(api,aFile,VoutClass);
		outfile->Append(aFile);

		aFile->Clear();
		aFile->AssignCat(aDir->ToCString());
		aFile->AssignCat(aPackage->FullName());
		aFile->AssignCat(".cpp");
		api->AddVariable("%CtorFromNative", "");
		api->AddVariable("%CppIncludes", "");
		api->Apply(VoutClass, "CppExtraction");
		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);
		//CPP_PackageDerivated(aMeta,api,aPackage,outfile,incp,Supplement);

		//  new xml stuff
		aFile->Clear();
		aFile->AssignCat(aDir->ToCString());
		aFile->AssignCat(aPackage->FullName());
		aFile->AssignCat(".api_base");
		api->Apply(VoutClass, "APIPackage");
		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);

		}
		else {
			ErrorMsg << "CPPExt" << "CPP_Package - the package is NULL..." << endm;
			Standard_NoSuchObject::Raise();
		}
}

