#include <windows.h>

#include <MS.hxx>

#include <EDL_API.hxx>

#include <MS_MetaSchema.hxx>
#include <MS_Alias.hxx>
#include <MS_Package.hxx>
#include <TCollection_HAsciiString.hxx>
#include <TColStd_HSequenceOfHAsciiString.hxx>
#include <MS_Class.hxx>

#include <CPPExt_Define.hxx>

void CPP_Alias(const Handle(MS_MetaSchema)& aMeta,
			   const Handle(EDL_API)& api,
			   const Handle(MS_Alias)& anAlias,
			   const Handle(TColStd_HSequenceOfHAsciiString)& outfile)
{
	if (anAlias.IsNull())
		return;

	Handle(TCollection_HAsciiString)	aFileName, realType;
	Handle(MS_Type)                     theType, tmpType;

	api->AddVariable(VClass, anAlias->FullName()->ToCString());

	realType = anAlias->Type();
	Handle(MS_Alias) alias = anAlias;

	while (aMeta->GetType(realType)->IsKind(STANDARD_TYPE(MS_Alias)))
	{
		tmpType = aMeta->GetType(realType);
		alias = *((Handle(MS_Alias)*)&tmpType);
		realType = alias->Type();
	}

	theType = aMeta->GetType(realType);

	if (theType->IsKind(STANDARD_TYPE(MS_Class)))
	{
		Handle(MS_Class) aclass = *((Handle(MS_Class)*)&theType);

		if (aclass->IsPersistent() || aclass->IsTransient())
		{
			Handle(TCollection_HAsciiString) str = new TCollection_HAsciiString("typedef ");

			str->AssignCat("Handle_");
			str->AssignCat(aclass->FullName());
			str->AssignCat(" Handle_");
			str->AssignCat(anAlias->FullName());
			str->AssignCat(";");

			api->AddVariable("%HandleTypedef", str->ToCString());
		}
		else
		{
			api->AddVariable("%HandleTypedef", "");
		}
	}
	else
	{
		api->AddVariable("%HandleTypedef","");
	}

	api->AddVariable(VInherits,realType->ToCString());
	api->Apply(VoutClass, "AliasHXX");

	Handle(TCollection_HAsciiString) aDir = new TCollection_HAsciiString(api->GetVariableValue(VFullPath));
	aDir->AssignCat("\\");
	aDir->AssignCat(anAlias->Package()->Name()->ToCString());
	aDir->AssignCat("\\");
	CreateDirectory(aDir->ToCString(), NULL);

	aFileName = new TCollection_HAsciiString(aDir->ToCString());
	aFileName->AssignCat(anAlias->FullName());
	aFileName->AssignCat(".h");
	CPP_WriteFile(api, aFileName, VoutClass); 
	outfile->Append(aFileName);

	aFileName->Clear();
	aFileName->AssignCat(aDir->ToCString());
	aFileName->AssignCat(anAlias->FullName());
	aFileName->AssignCat(".cpp");
	api->AddVariable("%Header", anAlias->FullName()->ToCString());
	api->Apply(VoutClass, "HeaderIncludeDef");
	CPP_WriteFile(api, aFileName, VoutClass);
	outfile->Append(aFileName);
}

