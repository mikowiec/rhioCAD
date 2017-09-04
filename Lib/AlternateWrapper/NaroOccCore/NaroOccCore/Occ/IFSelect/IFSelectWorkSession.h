#ifndef IFSelect_WorkSession_H
#define IFSelect_WorkSession_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IFSelect_WorkSession_Ctor();
extern "C" DECL_EXPORT int IFSelect_WorkSession_ReadFile9381D4D(
	void* instance,
	char* filename);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_StartingEntityE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT int IFSelect_WorkSession_StartingNumberF411CB01(
	void* instance,
	void* ent);
extern "C" DECL_EXPORT int IFSelect_WorkSession_NumberFromLabel800FADE1(
	void* instance,
	char* val,
	int afternum);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_EntityLabelF411CB01(
	void* instance,
	void* ent);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_EntityNameF411CB01(
	void* instance,
	void* ent);
extern "C" DECL_EXPORT int IFSelect_WorkSession_CategoryNumberF411CB01(
	void* instance,
	void* ent);
extern "C" DECL_EXPORT Standard_CString IFSelect_WorkSession_CategoryNameF411CB01(
	void* instance,
	void* ent);
extern "C" DECL_EXPORT Standard_CString IFSelect_WorkSession_ValidityNameF411CB01(
	void* instance,
	void* ent);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ClearDataE8219145(
	void* instance,
	int mode);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_ComputeGraph461FC46A(
	void* instance,
	bool enforce);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_ComputeCheck461FC46A(
	void* instance,
	bool enforce);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_ItemE8219145(
	void* instance,
	int id);
extern "C" DECL_EXPORT int IFSelect_WorkSession_ItemIdentF411CB01(
	void* instance,
	void* item);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_NamedItem9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_NamedItemB439B3D5(
	void* instance,
	void* name);
extern "C" DECL_EXPORT int IFSelect_WorkSession_NameIdent9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_HasNameF411CB01(
	void* instance,
	void* item);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_NameF411CB01(
	void* instance,
	void* item);
extern "C" DECL_EXPORT int IFSelect_WorkSession_AddItemA46DC5B5(
	void* instance,
	void* item,
	bool active);
extern "C" DECL_EXPORT int IFSelect_WorkSession_AddNamedItem5A688646(
	void* instance,
	char* name,
	void* item,
	bool active);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_SetActiveA46DC5B5(
	void* instance,
	void* item,
	bool mode);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_RemoveNamedItem9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_RemoveName9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_RemoveItemF411CB01(
	void* instance,
	void* item);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ClearItems(void* instance);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_ItemLabelE8219145(
	void* instance,
	int id);
extern "C" DECL_EXPORT int IFSelect_WorkSession_NextIdentForLabelC8778026(
	void* instance,
	char* label,
	int id,
	int mode);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_NewParamFromStatic8A1B7C71(
	void* instance,
	char* statname,
	char* name);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_TextParamE8219145(
	void* instance,
	int id);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_TextValueB439B3D5(
	void* instance,
	void* par);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_NewTextParam9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_SetTextValueC5444B6E(
	void* instance,
	void* par,
	char* val);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_ResetItemSelectionF411CB01(
	void* instance,
	void* item);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ClearShareOut461FC46A(
	void* instance,
	bool onlydisp);
extern "C" DECL_EXPORT int IFSelect_WorkSession_NbFinalModifiers461FC46A(
	void* instance,
	bool formodel);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_ChangeModifierRank282F7253(
	void* instance,
	bool formodel,
	int before,
	int after);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ClearFinalModifiers(void* instance);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_DefaultFileRoot(void* instance);
extern "C" DECL_EXPORT Standard_CString IFSelect_WorkSession_GiveFileRoot9381D4D(
	void* instance,
	char* file);
extern "C" DECL_EXPORT Standard_CString IFSelect_WorkSession_GiveFileComplete9381D4D(
	void* instance,
	char* file);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ClearFile(void* instance);
extern "C" DECL_EXPORT void IFSelect_WorkSession_EvaluateFile(void* instance);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_FileNameE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT void IFSelect_WorkSession_BeginSentFiles461FC46A(
	void* instance,
	bool record);
extern "C" DECL_EXPORT void* IFSelect_WorkSession_SentListE8219145(
	void* instance,
	int count);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_SetRemaining9B05F970(
	void* instance,
	int mode);
extern "C" DECL_EXPORT int IFSelect_WorkSession_SendAllDE32234A(
	void* instance,
	char* filename,
	bool computegraph);
extern "C" DECL_EXPORT int IFSelect_WorkSession_WriteFile9381D4D(
	void* instance,
	char* filename);
extern "C" DECL_EXPORT int IFSelect_WorkSession_QueryCheckStatusF411CB01(
	void* instance,
	void* ent);
extern "C" DECL_EXPORT int IFSelect_WorkSession_QueryParentAB457C73(
	void* instance,
	void* entdad,
	void* entson);
extern "C" DECL_EXPORT void IFSelect_WorkSession_TraceStatics5107F6FE(
	void* instance,
	int use,
	int mode);
extern "C" DECL_EXPORT void IFSelect_WorkSession_DumpShare(void* instance);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ListItems9381D4D(
	void* instance,
	char* label);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ListFinalModifiers461FC46A(
	void* instance,
	bool formodel);
extern "C" DECL_EXPORT void IFSelect_WorkSession_TraceDumpModelE8219145(
	void* instance,
	int mode);
extern "C" DECL_EXPORT void IFSelect_WorkSession_TraceDumpEntity73E03EE2(
	void* instance,
	void* ent,
	int level);
extern "C" DECL_EXPORT void IFSelect_WorkSession_EvaluateCompleteE8219145(
	void* instance,
	int mode);
extern "C" DECL_EXPORT void IFSelect_WorkSession_ListEntities84559BB6(
	void* instance,
	void* iter,
	int mode);
extern "C" DECL_EXPORT void IFSelect_WorkSession_SetErrorHandle(void* instance, bool value);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_ErrorHandle(void* instance);
extern "C" DECL_EXPORT void IFSelect_WorkSession_SetModeStat(void* instance, bool value);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_GetModeStat(void* instance);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_HasModel(void* instance);
extern "C" DECL_EXPORT void IFSelect_WorkSession_SetLoadedFile(void* instance, char* value);
extern "C" DECL_EXPORT Standard_CString IFSelect_WorkSession_LoadedFile(void* instance);
extern "C" DECL_EXPORT int IFSelect_WorkSession_NbStartingEntities(void* instance);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_IsLoaded(void* instance);
extern "C" DECL_EXPORT int IFSelect_WorkSession_MaxIdent(void* instance);
extern "C" DECL_EXPORT int IFSelect_WorkSession_NbFiles(void* instance);
extern "C" DECL_EXPORT bool IFSelect_WorkSession_SendSplit(void* instance);
extern "C" DECL_EXPORT int IFSelect_WorkSession_MaxSendingCount(void* instance);
extern "C" DECL_EXPORT void IFSelectWorkSession_Dtor(void* instance);

#endif
