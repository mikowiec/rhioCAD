#include "SelectMgrSelection.h"
#include <SelectMgr_Selection.hxx>

#include <SelectBasics_SensitiveEntity.hxx>

DECL_EXPORT void* SelectMgr_Selection_CtorE8219145(
	int IdMode)
{
	return new Handle_SelectMgr_Selection(new SelectMgr_Selection(			
IdMode));
}
DECL_EXPORT void SelectMgr_Selection_Add608D2A9E(
	void* instance,
	void* aprimitive)
{
		const Handle_SelectBasics_SensitiveEntity&  _aprimitive =*(const Handle_SelectBasics_SensitiveEntity *)aprimitive;
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
 	result->Add(			
_aprimitive);
}
DECL_EXPORT void SelectMgr_Selection_Clear(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT void SelectMgr_Selection_Init(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
 	result->Init();
}
DECL_EXPORT void SelectMgr_Selection_Next(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
 	result->Next();
}
DECL_EXPORT int SelectMgr_Selection_UpdateStatus(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
	return  	result->UpdateStatus();
}
DECL_EXPORT void SelectMgr_Selection_UpdateStatus6D7AC047(
	void* instance,
	int UpdateFlag)
{
		const SelectMgr_TypeOfUpdate _UpdateFlag =(const SelectMgr_TypeOfUpdate )UpdateFlag;
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
 	result->UpdateStatus(			
_UpdateFlag);
}
DECL_EXPORT bool SelectMgr_Selection_IsEmpty(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
	return 	result->IsEmpty();
}

DECL_EXPORT int SelectMgr_Selection_Mode(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
	return 	result->Mode();
}

DECL_EXPORT bool SelectMgr_Selection_More(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
	return 	result->More();
}

DECL_EXPORT void* SelectMgr_Selection_Sensitive(void* instance)
{
	SelectMgr_Selection* result = (SelectMgr_Selection*)(((Handle_SelectMgr_Selection*)instance)->Access());
	return 	new Handle_SelectBasics_SensitiveEntity(	result->Sensitive());
}

DECL_EXPORT void SelectMgrSelection_Dtor(void* instance)
{
	delete (Handle_SelectMgr_Selection*)instance;
}
