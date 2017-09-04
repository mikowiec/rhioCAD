#include "IFSelectWorkSession.h"
#include <IFSelect_WorkSession.hxx>

#include <Interface_EntityIterator.hxx>
#include <Standard_Transient.hxx>
#include <TCollection_AsciiString.hxx>
#include <TCollection_HAsciiString.hxx>

DECL_EXPORT void* IFSelect_WorkSession_Ctor()
{
	return new Handle_IFSelect_WorkSession(new IFSelect_WorkSession());
}
DECL_EXPORT int IFSelect_WorkSession_ReadFile9381D4D(
	void* instance,
	char* filename)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->ReadFile(			
filename);
}
DECL_EXPORT void* IFSelect_WorkSession_StartingEntityE8219145(
	void* instance,
	int num)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_Standard_Transient( 	result->StartingEntity(			
num));
}
DECL_EXPORT int IFSelect_WorkSession_StartingNumberF411CB01(
	void* instance,
	void* ent)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->StartingNumber(			
_ent);
}
DECL_EXPORT int IFSelect_WorkSession_NumberFromLabel800FADE1(
	void* instance,
	char* val,
	int afternum)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->NumberFromLabel(			
val,			
afternum);
}
DECL_EXPORT void* IFSelect_WorkSession_EntityLabelF411CB01(
	void* instance,
	void* ent)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->EntityLabel(			
_ent));
}
DECL_EXPORT void* IFSelect_WorkSession_EntityNameF411CB01(
	void* instance,
	void* ent)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->EntityName(			
_ent));
}
DECL_EXPORT int IFSelect_WorkSession_CategoryNumberF411CB01(
	void* instance,
	void* ent)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->CategoryNumber(			
_ent);
}
DECL_EXPORT Standard_CString IFSelect_WorkSession_CategoryNameF411CB01(
	void* instance,
	void* ent)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->CategoryName(			
_ent);
}
DECL_EXPORT Standard_CString IFSelect_WorkSession_ValidityNameF411CB01(
	void* instance,
	void* ent)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->ValidityName(			
_ent);
}
DECL_EXPORT void IFSelect_WorkSession_ClearDataE8219145(
	void* instance,
	int mode)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ClearData(			
mode);
}
DECL_EXPORT bool IFSelect_WorkSession_ComputeGraph461FC46A(
	void* instance,
	bool enforce)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->ComputeGraph(			
enforce);
}
DECL_EXPORT bool IFSelect_WorkSession_ComputeCheck461FC46A(
	void* instance,
	bool enforce)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->ComputeCheck(			
enforce);
}
DECL_EXPORT void* IFSelect_WorkSession_ItemE8219145(
	void* instance,
	int id)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_Standard_Transient( 	result->Item(			
id));
}
DECL_EXPORT int IFSelect_WorkSession_ItemIdentF411CB01(
	void* instance,
	void* item)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->ItemIdent(			
_item);
}
DECL_EXPORT void* IFSelect_WorkSession_NamedItem9381D4D(
	void* instance,
	char* name)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_Standard_Transient( 	result->NamedItem(			
name));
}
DECL_EXPORT void* IFSelect_WorkSession_NamedItemB439B3D5(
	void* instance,
	void* name)
{
		const Handle_TCollection_HAsciiString&  _name =*(const Handle_TCollection_HAsciiString *)name;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_Standard_Transient( 	result->NamedItem(			
_name));
}
DECL_EXPORT int IFSelect_WorkSession_NameIdent9381D4D(
	void* instance,
	char* name)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->NameIdent(			
name);
}
DECL_EXPORT bool IFSelect_WorkSession_HasNameF411CB01(
	void* instance,
	void* item)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->HasName(			
_item);
}
DECL_EXPORT void* IFSelect_WorkSession_NameF411CB01(
	void* instance,
	void* item)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->Name(			
_item));
}
DECL_EXPORT int IFSelect_WorkSession_AddItemA46DC5B5(
	void* instance,
	void* item,
	bool active)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->AddItem(			
_item,			
active);
}
DECL_EXPORT int IFSelect_WorkSession_AddNamedItem5A688646(
	void* instance,
	char* name,
	void* item,
	bool active)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->AddNamedItem(			
name,			
_item,			
active);
}
DECL_EXPORT bool IFSelect_WorkSession_SetActiveA46DC5B5(
	void* instance,
	void* item,
	bool mode)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->SetActive(			
_item,			
mode);
}
DECL_EXPORT bool IFSelect_WorkSession_RemoveNamedItem9381D4D(
	void* instance,
	char* name)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->RemoveNamedItem(			
name);
}
DECL_EXPORT bool IFSelect_WorkSession_RemoveName9381D4D(
	void* instance,
	char* name)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->RemoveName(			
name);
}
DECL_EXPORT bool IFSelect_WorkSession_RemoveItemF411CB01(
	void* instance,
	void* item)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->RemoveItem(			
_item);
}
DECL_EXPORT void IFSelect_WorkSession_ClearItems(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ClearItems();
}
DECL_EXPORT void* IFSelect_WorkSession_ItemLabelE8219145(
	void* instance,
	int id)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->ItemLabel(			
id));
}
DECL_EXPORT int IFSelect_WorkSession_NextIdentForLabelC8778026(
	void* instance,
	char* label,
	int id,
	int mode)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->NextIdentForLabel(			
label,			
id,			
mode);
}
DECL_EXPORT void* IFSelect_WorkSession_NewParamFromStatic8A1B7C71(
	void* instance,
	char* statname,
	char* name)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_Standard_Transient( 	result->NewParamFromStatic(			
statname,			
name));
}
DECL_EXPORT void* IFSelect_WorkSession_TextParamE8219145(
	void* instance,
	int id)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->TextParam(			
id));
}
DECL_EXPORT void* IFSelect_WorkSession_TextValueB439B3D5(
	void* instance,
	void* par)
{
		const Handle_TCollection_HAsciiString&  _par =*(const Handle_TCollection_HAsciiString *)par;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new TCollection_AsciiString( 	result->TextValue(			
_par));
}
DECL_EXPORT void* IFSelect_WorkSession_NewTextParam9381D4D(
	void* instance,
	char* name)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->NewTextParam(			
name));
}
DECL_EXPORT bool IFSelect_WorkSession_SetTextValueC5444B6E(
	void* instance,
	void* par,
	char* val)
{
		const Handle_TCollection_HAsciiString&  _par =*(const Handle_TCollection_HAsciiString *)par;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->SetTextValue(			
_par,			
val);
}
DECL_EXPORT bool IFSelect_WorkSession_ResetItemSelectionF411CB01(
	void* instance,
	void* item)
{
		const Handle_Standard_Transient&  _item =*(const Handle_Standard_Transient *)item;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->ResetItemSelection(			
_item);
}
DECL_EXPORT void IFSelect_WorkSession_ClearShareOut461FC46A(
	void* instance,
	bool onlydisp)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ClearShareOut(			
onlydisp);
}
DECL_EXPORT int IFSelect_WorkSession_NbFinalModifiers461FC46A(
	void* instance,
	bool formodel)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->NbFinalModifiers(			
formodel);
}
DECL_EXPORT bool IFSelect_WorkSession_ChangeModifierRank282F7253(
	void* instance,
	bool formodel,
	int before,
	int after)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->ChangeModifierRank(			
formodel,			
before,			
after);
}
DECL_EXPORT void IFSelect_WorkSession_ClearFinalModifiers(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ClearFinalModifiers();
}
DECL_EXPORT void* IFSelect_WorkSession_DefaultFileRoot(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->DefaultFileRoot());
}
DECL_EXPORT Standard_CString IFSelect_WorkSession_GiveFileRoot9381D4D(
	void* instance,
	char* file)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->GiveFileRoot(			
file);
}
DECL_EXPORT Standard_CString IFSelect_WorkSession_GiveFileComplete9381D4D(
	void* instance,
	char* file)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->GiveFileComplete(			
file);
}
DECL_EXPORT void IFSelect_WorkSession_ClearFile(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ClearFile();
}
DECL_EXPORT void IFSelect_WorkSession_EvaluateFile(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->EvaluateFile();
}
DECL_EXPORT void* IFSelect_WorkSession_FileNameE8219145(
	void* instance,
	int num)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new TCollection_AsciiString( 	result->FileName(			
num));
}
DECL_EXPORT void IFSelect_WorkSession_BeginSentFiles461FC46A(
	void* instance,
	bool record)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->BeginSentFiles(			
record);
}
DECL_EXPORT void* IFSelect_WorkSession_SentListE8219145(
	void* instance,
	int count)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return new Interface_EntityIterator( 	result->SentList(			
count));
}
DECL_EXPORT bool IFSelect_WorkSession_SetRemaining9B05F970(
	void* instance,
	int mode)
{
		const IFSelect_RemainMode _mode =(const IFSelect_RemainMode )mode;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->SetRemaining(			
_mode);
}
DECL_EXPORT int IFSelect_WorkSession_SendAllDE32234A(
	void* instance,
	char* filename,
	bool computegraph)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->SendAll(			
filename,			
computegraph);
}
DECL_EXPORT int IFSelect_WorkSession_WriteFile9381D4D(
	void* instance,
	char* filename)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->WriteFile(			
filename);
}
DECL_EXPORT int IFSelect_WorkSession_QueryCheckStatusF411CB01(
	void* instance,
	void* ent)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->QueryCheckStatus(			
_ent);
}
DECL_EXPORT int IFSelect_WorkSession_QueryParentAB457C73(
	void* instance,
	void* entdad,
	void* entson)
{
		const Handle_Standard_Transient&  _entdad =*(const Handle_Standard_Transient *)entdad;
		const Handle_Standard_Transient&  _entson =*(const Handle_Standard_Transient *)entson;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return  	result->QueryParent(			
_entdad,			
_entson);
}
DECL_EXPORT void IFSelect_WorkSession_TraceStatics5107F6FE(
	void* instance,
	int use,
	int mode)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->TraceStatics(			
use,			
mode);
}
DECL_EXPORT void IFSelect_WorkSession_DumpShare(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->DumpShare();
}
DECL_EXPORT void IFSelect_WorkSession_ListItems9381D4D(
	void* instance,
	char* label)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ListItems(			
label);
}
DECL_EXPORT void IFSelect_WorkSession_ListFinalModifiers461FC46A(
	void* instance,
	bool formodel)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ListFinalModifiers(			
formodel);
}
DECL_EXPORT void IFSelect_WorkSession_TraceDumpModelE8219145(
	void* instance,
	int mode)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->TraceDumpModel(			
mode);
}
DECL_EXPORT void IFSelect_WorkSession_TraceDumpEntity73E03EE2(
	void* instance,
	void* ent,
	int level)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->TraceDumpEntity(			
_ent,			
level);
}
DECL_EXPORT void IFSelect_WorkSession_EvaluateCompleteE8219145(
	void* instance,
	int mode)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->EvaluateComplete(			
mode);
}
DECL_EXPORT void IFSelect_WorkSession_ListEntities84559BB6(
	void* instance,
	void* iter,
	int mode)
{
		const Interface_EntityIterator &  _iter =*(const Interface_EntityIterator *)iter;
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
 	result->ListEntities(			
_iter,			
mode);
}
DECL_EXPORT void IFSelect_WorkSession_SetErrorHandle(void* instance, bool value)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
		result->SetErrorHandle(value);
}

DECL_EXPORT bool IFSelect_WorkSession_ErrorHandle(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->ErrorHandle();
}

DECL_EXPORT void IFSelect_WorkSession_SetModeStat(void* instance, bool value)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
		result->SetModeStat(value);
}

DECL_EXPORT bool IFSelect_WorkSession_GetModeStat(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->GetModeStat();
}

DECL_EXPORT bool IFSelect_WorkSession_HasModel(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->HasModel();
}

DECL_EXPORT void IFSelect_WorkSession_SetLoadedFile(void* instance, char* value)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
		result->SetLoadedFile(value);
}

DECL_EXPORT Standard_CString IFSelect_WorkSession_LoadedFile(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->LoadedFile();
}

DECL_EXPORT int IFSelect_WorkSession_NbStartingEntities(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->NbStartingEntities();
}

DECL_EXPORT bool IFSelect_WorkSession_IsLoaded(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->IsLoaded();
}

DECL_EXPORT int IFSelect_WorkSession_MaxIdent(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->MaxIdent();
}

DECL_EXPORT int IFSelect_WorkSession_NbFiles(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->NbFiles();
}

DECL_EXPORT bool IFSelect_WorkSession_SendSplit(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->SendSplit();
}

DECL_EXPORT int IFSelect_WorkSession_MaxSendingCount(void* instance)
{
	IFSelect_WorkSession* result = (IFSelect_WorkSession*)(((Handle_IFSelect_WorkSession*)instance)->Access());
	return 	result->MaxSendingCount();
}

DECL_EXPORT void IFSelectWorkSession_Dtor(void* instance)
{
	delete (Handle_IFSelect_WorkSession*)instance;
}
