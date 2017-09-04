#ifndef SelectMgr_Selection_H
#define SelectMgr_Selection_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* SelectMgr_Selection_CtorE8219145(
	int IdMode);
extern "C" DECL_EXPORT void SelectMgr_Selection_Add608D2A9E(
	void* instance,
	void* aprimitive);
extern "C" DECL_EXPORT void SelectMgr_Selection_Clear(void* instance);
extern "C" DECL_EXPORT void SelectMgr_Selection_Init(void* instance);
extern "C" DECL_EXPORT void SelectMgr_Selection_Next(void* instance);
extern "C" DECL_EXPORT int SelectMgr_Selection_UpdateStatus(void* instance);
extern "C" DECL_EXPORT void SelectMgr_Selection_UpdateStatus6D7AC047(
	void* instance,
	int UpdateFlag);
extern "C" DECL_EXPORT bool SelectMgr_Selection_IsEmpty(void* instance);
extern "C" DECL_EXPORT int SelectMgr_Selection_Mode(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_Selection_More(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_Selection_Sensitive(void* instance);
extern "C" DECL_EXPORT void SelectMgrSelection_Dtor(void* instance);

#endif
