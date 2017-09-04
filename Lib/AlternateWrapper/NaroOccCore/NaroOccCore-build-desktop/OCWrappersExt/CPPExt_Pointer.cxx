#include <windows.h>

#include <MS.hxx>

#include <EDL_API.hxx>

#include <MS_MetaSchema.hxx>
#include <MS_Pointer.hxx>
#include <MS_Package.hxx>
#include <TCollection_HAsciiString.hxx>
#include <TColStd_HSequenceOfHAsciiString.hxx>

#include <CPPExt_Define.hxx>

// Extraction of a transient class (inst or std)
//
//void CPP_Pointer(const Handle(MS_MetaSchema)& aMeta,
void CPP_Pointer(const Handle(MS_MetaSchema)& ,
				 const Handle(EDL_API)& api,
				 const Handle(MS_Pointer)& aPointer,
				 const Handle(TColStd_HSequenceOfHAsciiString)& outfile)
{
	if (aPointer.IsNull())
		return;

	Handle(TCollection_HAsciiString)	aFileName;

	// Hxx extraction
	api->AddVariable(VClass, aPointer->FullName()->ToCString());
	api->AddVariable(VInherits, aPointer->Type()->ToCString());
	api->Apply(VoutClass, "PointerHXX");

	Handle(TCollection_HAsciiString) aDir = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
	aDir->AssignCat("\\");
	aDir->AssignCat(aPointer->Package()->Name()->ToCString());
	aDir->AssignCat("\\");
	CreateDirectory(aDir->ToCString(), NULL);

	aFileName = new TCollection_HAsciiString(aDir->ToCString());
	aFileName->AssignCat(aPointer->FullName());
	aFileName->AssignCat(".h");
	CPP_WriteFile(api, aFileName, VoutClass); 
	outfile->Append(aFileName);

	aFileName->Clear();
	aFileName->AssignCat(aDir->ToCString());
	aFileName->AssignCat(aPointer->FullName());
	aFileName->AssignCat(".cpp");
	api->AddVariable("%Header", aPointer->FullName()->ToCString());
	api->Apply(VoutClass, "HeaderIncludeDef");
	CPP_WriteFile(api, aFileName, VoutClass);
	outfile->Append(aFileName);
}

