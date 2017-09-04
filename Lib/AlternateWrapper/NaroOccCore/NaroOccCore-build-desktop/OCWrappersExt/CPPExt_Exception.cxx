// CLE
//    
// 10/1995
//
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
void CPP_ExceptionDerivated(const Handle(MS_MetaSchema)& aMeta,
			    const Handle(EDL_API)& api,
			    const Handle(MS_Class)& aClass,			    
			    const Handle(TColStd_HSequenceOfHAsciiString)& outfile,
//			    const Handle(TColStd_HSequenceOfHAsciiString)& inclist,
			    const Handle(TColStd_HSequenceOfHAsciiString)& ,
			    const Handle(TColStd_HSequenceOfHAsciiString)& supplement)
{
  Standard_Integer                        i;
  Handle(TCollection_HAsciiString)        aFileName = new TCollection_HAsciiString;
  Handle(TCollection_HAsciiString)        result    = new TCollection_HAsciiString;

  api->AddVariable(VClass,aClass->FullName()->ToCString());
  api->AddVariable(VClassComment,aClass->Comment()->ToCString());

  api->Apply(VSupplement,"ExceptionMethod");
  
  supplement->Append(api->GetVariableValue(VSupplement));
  
  api->AddVariable(VClass,aClass->FullName()->ToCString());

  api->AddVariable(VSuffix,"hxx");
  
  CPP_ClassTypeMgt(aMeta,api,aClass,VTypeMgt);
  
  aFileName = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
  aFileName->AssignCat(aClass->FullName());

  aFileName->AssignCat("_0.cxx");

  // Supplement
  //
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

  api->AddVariable(VSuffix,"hxx");

  api->AddVariable(VMethods,result->ToCString());
  api->Apply(VoutClass,"TransientIxx");
  
  CPP_WriteFile(api,aFileName,VoutClass); 
  
  outfile->Append(aFileName);
}


// Extraction of a transient class (inst or std)
void CPP_ExceptionClass(const Handle(MS_MetaSchema)& aMeta,
						const Handle(EDL_API)& api,
						const Handle(MS_Class)& aClass,
						const Handle(TColStd_HSequenceOfHAsciiString)& outfile)
{
	Handle(MS_Error) theClass = Handle(MS_Error)::DownCast(aClass);

	if (!theClass.IsNull())
	{
		Handle(TColStd_HSequenceOfHAsciiString) Supplement = new TColStd_HSequenceOfHAsciiString;
		Handle(TColStd_HSequenceOfHAsciiString) FullList = new TColStd_HSequenceOfHAsciiString;

		api->AddVariable(VClass, aClass->FullName()->ToCString());
		api->AddVariable(VInherits, aClass->GetInheritsNames()->Value(1)->ToCString());

		api->Apply(VoutClass,"ExceptionHXX");

		// we write the .hxx of this class
		Handle(TCollection_HAsciiString) aFile = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));

		aFile->AssignCat(theClass->FullName());
		aFile->AssignCat(".h");

		CPP_WriteFile(api, aFile, VoutClass);
		outfile->Append(aFile);

		CPP_ExceptionDerivated(aMeta, api, aClass, outfile, FullList, Supplement);
	}
	else
	{
		ErrorMsg << "CPPExt " << "CPP_TransientClass - the class is NULL..." << endm;
		Standard_NoSuchObject::Raise();
	}
}

