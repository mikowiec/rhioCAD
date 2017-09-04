#ifndef Transfer_ProcessForTransient_H
#define Transfer_ProcessForTransient_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Transfer_ProcessForTransient_CtorE8219145(
	int nb);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_Clear(void* instance);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_Clean(void* instance);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_ResizeE8219145(
	void* instance,
	int nb);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_IsBoundF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_IsAlreadyUsedF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_UnbindF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SendFailF8E53BFD(
	void* instance,
	void* start,
	void* amsg);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SendWarningF8E53BFD(
	void* instance,
	void* start,
	void* amsg);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SendMsgF8E53BFD(
	void* instance,
	void* start,
	void* amsg);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_AddFailDBC2D08D(
	void* instance,
	void* start,
	char* mess,
	char* orig);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_AddErrorDBC2D08D(
	void* instance,
	void* start,
	char* mess,
	char* orig);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_AddFailF8E53BFD(
	void* instance,
	void* start,
	void* amsg);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_AddWarningDBC2D08D(
	void* instance,
	void* start,
	char* mess,
	char* orig);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_AddWarningF8E53BFD(
	void* instance,
	void* start,
	void* amsg);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_Mend929AF976(
	void* instance,
	void* start,
	char* pref);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_BindTransientAB457C73(
	void* instance,
	void* start,
	void* res);
extern "C" DECL_EXPORT void* Transfer_ProcessForTransient_FindTransientF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_BindMultipleF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_AddMultipleAB457C73(
	void* instance,
	void* start,
	void* res);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_FindTypedTransient2A525E75(
	void* instance,
	void* start,
	void* atype,
	void* val);
extern "C" DECL_EXPORT void* Transfer_ProcessForTransient_MappedE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT int Transfer_ProcessForTransient_MapIndexF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SetRootF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void* Transfer_ProcessForTransient_RootE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT int Transfer_ProcessForTransient_RootIndexF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_ResetNestingLevel(void* instance);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_RecognizeF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_TransferF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_IsLoopingE8219145(
	void* instance,
	int alevel);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_IsCheckListEmpty145DF9DF(
	void* instance,
	void* start,
	int level,
	bool erronly);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_RemoveResult145DF9DF(
	void* instance,
	void* start,
	int level,
	bool compute);
extern "C" DECL_EXPORT int Transfer_ProcessForTransient_CheckNumF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SetTraceLevel(void* instance, int value);
extern "C" DECL_EXPORT int Transfer_ProcessForTransient_TraceLevel(void* instance);
extern "C" DECL_EXPORT int Transfer_ProcessForTransient_NbMapped(void* instance);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SetRootManagement(void* instance, bool value);
extern "C" DECL_EXPORT int Transfer_ProcessForTransient_NbRoots(void* instance);
extern "C" DECL_EXPORT int Transfer_ProcessForTransient_NestingLevel(void* instance);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SetErrorHandle(void* instance, bool value);
extern "C" DECL_EXPORT bool Transfer_ProcessForTransient_ErrorHandle(void* instance);
extern "C" DECL_EXPORT void Transfer_ProcessForTransient_SetProgress(void* instance, void* value);
extern "C" DECL_EXPORT void* Transfer_ProcessForTransient_GetProgress(void* instance);
extern "C" DECL_EXPORT void TransferProcessForTransient_Dtor(void* instance);

#endif
