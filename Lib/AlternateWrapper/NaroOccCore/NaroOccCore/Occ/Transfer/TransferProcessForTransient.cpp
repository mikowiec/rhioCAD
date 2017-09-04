#include "TransferProcessForTransient.h"
#include <Transfer_ProcessForTransient.hxx>

#include <Message_ProgressIndicator.hxx>
#include <Standard_Transient.hxx>

DECL_EXPORT void* Transfer_ProcessForTransient_CtorE8219145(
	int nb)
{
	return new Handle_Transfer_ProcessForTransient(new Transfer_ProcessForTransient(			
nb));
}
DECL_EXPORT void Transfer_ProcessForTransient_Clear(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT void Transfer_ProcessForTransient_Clean(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->Clean();
}
DECL_EXPORT void Transfer_ProcessForTransient_ResizeE8219145(
	void* instance,
	int nb)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->Resize(			
nb);
}
DECL_EXPORT bool Transfer_ProcessForTransient_IsBoundF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->IsBound(			
_start);
}
DECL_EXPORT bool Transfer_ProcessForTransient_IsAlreadyUsedF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->IsAlreadyUsed(			
_start);
}
DECL_EXPORT bool Transfer_ProcessForTransient_UnbindF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->Unbind(			
_start);
}
DECL_EXPORT void Transfer_ProcessForTransient_SendFailF8E53BFD(
	void* instance,
	void* start,
	void* amsg)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Message_Msg &  _amsg =*(const Message_Msg *)amsg;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->SendFail(			
_start,			
_amsg);
}
DECL_EXPORT void Transfer_ProcessForTransient_SendWarningF8E53BFD(
	void* instance,
	void* start,
	void* amsg)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Message_Msg &  _amsg =*(const Message_Msg *)amsg;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->SendWarning(			
_start,			
_amsg);
}
DECL_EXPORT void Transfer_ProcessForTransient_SendMsgF8E53BFD(
	void* instance,
	void* start,
	void* amsg)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Message_Msg &  _amsg =*(const Message_Msg *)amsg;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->SendMsg(			
_start,			
_amsg);
}
DECL_EXPORT void Transfer_ProcessForTransient_AddFailDBC2D08D(
	void* instance,
	void* start,
	char* mess,
	char* orig)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->AddFail(			
_start,			
mess,			
orig);
}
DECL_EXPORT void Transfer_ProcessForTransient_AddErrorDBC2D08D(
	void* instance,
	void* start,
	char* mess,
	char* orig)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->AddError(			
_start,			
mess,			
orig);
}
DECL_EXPORT void Transfer_ProcessForTransient_AddFailF8E53BFD(
	void* instance,
	void* start,
	void* amsg)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Message_Msg &  _amsg =*(const Message_Msg *)amsg;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->AddFail(			
_start,			
_amsg);
}
DECL_EXPORT void Transfer_ProcessForTransient_AddWarningDBC2D08D(
	void* instance,
	void* start,
	char* mess,
	char* orig)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->AddWarning(			
_start,			
mess,			
orig);
}
DECL_EXPORT void Transfer_ProcessForTransient_AddWarningF8E53BFD(
	void* instance,
	void* start,
	void* amsg)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Message_Msg &  _amsg =*(const Message_Msg *)amsg;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->AddWarning(			
_start,			
_amsg);
}
DECL_EXPORT void Transfer_ProcessForTransient_Mend929AF976(
	void* instance,
	void* start,
	char* pref)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->Mend(			
_start,			
pref);
}
DECL_EXPORT void Transfer_ProcessForTransient_BindTransientAB457C73(
	void* instance,
	void* start,
	void* res)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Handle_Standard_Transient&  _res =*(const Handle_Standard_Transient *)res;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->BindTransient(			
_start,			
_res);
}
DECL_EXPORT void* Transfer_ProcessForTransient_FindTransientF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return new Handle_Standard_Transient( 	result->FindTransient(			
_start));
}
DECL_EXPORT void Transfer_ProcessForTransient_BindMultipleF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->BindMultiple(			
_start);
}
DECL_EXPORT void Transfer_ProcessForTransient_AddMultipleAB457C73(
	void* instance,
	void* start,
	void* res)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Handle_Standard_Transient&  _res =*(const Handle_Standard_Transient *)res;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->AddMultiple(			
_start,			
_res);
}
DECL_EXPORT bool Transfer_ProcessForTransient_FindTypedTransient2A525E75(
	void* instance,
	void* start,
	void* atype,
	void* val)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
		const Handle_Standard_Type&  _atype =*(const Handle_Standard_Type *)atype;
		 Handle_Standard_Transient&  _val =*( Handle_Standard_Transient *)val;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->FindTypedTransient(			
_start,			
_atype,			
_val);
}
DECL_EXPORT void* Transfer_ProcessForTransient_MappedE8219145(
	void* instance,
	int num)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return new Handle_Standard_Transient( 	result->Mapped(			
num));
}
DECL_EXPORT int Transfer_ProcessForTransient_MapIndexF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->MapIndex(			
_start);
}
DECL_EXPORT void Transfer_ProcessForTransient_SetRootF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->SetRoot(			
_start);
}
DECL_EXPORT void* Transfer_ProcessForTransient_RootE8219145(
	void* instance,
	int num)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return new Handle_Standard_Transient( 	result->Root(			
num));
}
DECL_EXPORT int Transfer_ProcessForTransient_RootIndexF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->RootIndex(			
_start);
}
DECL_EXPORT void Transfer_ProcessForTransient_ResetNestingLevel(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->ResetNestingLevel();
}
DECL_EXPORT bool Transfer_ProcessForTransient_RecognizeF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->Recognize(			
_start);
}
DECL_EXPORT bool Transfer_ProcessForTransient_TransferF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->Transfer(			
_start);
}
DECL_EXPORT bool Transfer_ProcessForTransient_IsLoopingE8219145(
	void* instance,
	int alevel)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->IsLooping(			
alevel);
}
DECL_EXPORT bool Transfer_ProcessForTransient_IsCheckListEmpty145DF9DF(
	void* instance,
	void* start,
	int level,
	bool erronly)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->IsCheckListEmpty(			
_start,			
level,			
erronly);
}
DECL_EXPORT void Transfer_ProcessForTransient_RemoveResult145DF9DF(
	void* instance,
	void* start,
	int level,
	bool compute)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
 	result->RemoveResult(			
_start,			
level,			
compute);
}
DECL_EXPORT int Transfer_ProcessForTransient_CheckNumF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return  	result->CheckNum(			
_start);
}
DECL_EXPORT void Transfer_ProcessForTransient_SetTraceLevel(void* instance, int value)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
		result->SetTraceLevel(value);
}

DECL_EXPORT int Transfer_ProcessForTransient_TraceLevel(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return 	result->TraceLevel();
}

DECL_EXPORT int Transfer_ProcessForTransient_NbMapped(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return 	result->NbMapped();
}

DECL_EXPORT void Transfer_ProcessForTransient_SetRootManagement(void* instance, bool value)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
		result->SetRootManagement(value);
}

DECL_EXPORT int Transfer_ProcessForTransient_NbRoots(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return 	result->NbRoots();
}

DECL_EXPORT int Transfer_ProcessForTransient_NestingLevel(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return 	result->NestingLevel();
}

DECL_EXPORT void Transfer_ProcessForTransient_SetErrorHandle(void* instance, bool value)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
		result->SetErrorHandle(value);
}

DECL_EXPORT bool Transfer_ProcessForTransient_ErrorHandle(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return 	result->ErrorHandle();
}

DECL_EXPORT void Transfer_ProcessForTransient_SetProgress(void* instance, void* value)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
		result->SetProgress(*(const Handle_Message_ProgressIndicator *)value);
}

DECL_EXPORT void* Transfer_ProcessForTransient_GetProgress(void* instance)
{
	Transfer_ProcessForTransient* result = (Transfer_ProcessForTransient*)(((Handle_Transfer_ProcessForTransient*)instance)->Access());
	return 	new Handle_Message_ProgressIndicator(	result->GetProgress());
}

DECL_EXPORT void TransferProcessForTransient_Dtor(void* instance)
{
	delete (Handle_Transfer_ProcessForTransient*)instance;
}
