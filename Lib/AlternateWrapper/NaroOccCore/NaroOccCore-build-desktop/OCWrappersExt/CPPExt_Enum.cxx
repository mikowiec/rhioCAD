#include <windows.h>

#include <MS.hxx>
#include <MS_MetaSchema.hxx>
#include <MS_Enum.hxx>
#include <MS_Package.hxx>

#include <EDL_API.hxx>

#include <TCollection_HAsciiString.hxx>
#include <TColStd_HSequenceOfHAsciiString.hxx>

#include <CPPExt_Define.hxx>

void CPP_Enum(const Handle(MS_MetaSchema)&,
			  const Handle(EDL_API)& api,
			  const Handle(MS_Enum)& anEnum,
			  const Handle(TColStd_HSequenceOfHAsciiString)& outfile)
{
	if (anEnum.IsNull())
		return;

	Handle(TColStd_HSequenceOfHAsciiString) enumValues = anEnum->Enums();
	Handle(TCollection_HAsciiString)        resultCpp = new TCollection_HAsciiString();
	Handle(TCollection_HAsciiString)        resultApi = new TCollection_HAsciiString();
	resultCpp->Clear();
	resultApi->Clear();
	Standard_Integer i;
	for(i = 1; i < enumValues->Length(); i++)
	{
		resultCpp->AssignCat(enumValues->Value(i));
		resultCpp->AssignCat(",\n");

		resultApi->AssignCat("<Field Name=\"");
		resultApi->AssignCat(enumValues->Value(i));
		resultApi->AssignCat("\" />\n");
	}
	// add last one...
	if (enumValues->Length() > 0)
	{
		resultCpp->AssignCat(enumValues->Value(i));
		resultApi->AssignCat("<Field Name=\"");
		resultApi->AssignCat(enumValues->Value(i));
		resultApi->AssignCat("\" />");
	}

	api->AddVariable("%EnumComment", anEnum->Comment()->ToCString());
	api->AddVariable(VClass, anEnum->FullName()->ToCString());
	api->AddVariable(VValues, resultCpp->ToCString());
	api->AddVariable("%ApiValues", resultApi->ToCString());
	api->Apply(VoutClass, "EnumHXX");
  
	Handle(TCollection_HAsciiString) aDir = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
	aDir->AssignCat("\\");
	aDir->AssignCat(anEnum->Package()->Name()->ToCString());
	aDir->AssignCat("\\");
	CreateDirectory(aDir->ToCString(), NULL);

	Handle(TCollection_HAsciiString) fileName = new TCollection_HAsciiString(aDir->ToCString());
	fileName->AssignCat(anEnum->FullName());
	fileName->AssignCat(".h");
	CPP_WriteFile(api, fileName, VoutClass);
	outfile->Append(fileName);

	fileName->Clear();
	fileName->AssignCat(aDir->ToCString());
	fileName->AssignCat(anEnum->FullName());
	fileName->AssignCat(".cpp");
	api->AddVariable("%Header", anEnum->FullName()->ToCString());
	api->Apply(VoutClass, "HeaderIncludeDef");
	CPP_WriteFile(api, fileName, VoutClass);
	outfile->Append(fileName);

	//  new xml stuff
	fileName->Clear();
	fileName->AssignCat(aDir->ToCString());
	fileName->AssignCat(anEnum->FullName());
	fileName->AssignCat(".api_base");
	api->Apply(VoutClass, "EnumAPI");
	CPP_WriteFile(api, fileName, VoutClass);
	outfile->Append(fileName);
}



