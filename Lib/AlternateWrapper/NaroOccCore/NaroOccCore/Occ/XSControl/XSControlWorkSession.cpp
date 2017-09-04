#include "XSControlWorkSession.h"
#include <XSControl_WorkSession.hxx>

#include <Dico_DictionaryOfTransient.hxx>
#include <Standard_Transient.hxx>
#include <Transfer_TransientProcess.hxx>

DECL_EXPORT void* XSControl_WorkSession_Ctor()
{
	return new Handle_XSControl_WorkSession(new XSControl_WorkSession());
}
DECL_EXPORT void XSControl_WorkSession_ClearDataE8219145(
	void* instance,
	int mode)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
 	result->ClearData(			
mode);
}
DECL_EXPORT bool XSControl_WorkSession_SelectNorm8A1B7C71(
	void* instance,
	char* normname,
	char* profile)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return  	result->SelectNorm(			
normname,			
profile);
}
DECL_EXPORT bool XSControl_WorkSession_SelectProfile9381D4D(
	void* instance,
	char* profile)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return  	result->SelectProfile(			
profile);
}
DECL_EXPORT void XSControl_WorkSession_AdaptNorm(void* instance)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
 	result->AdaptNorm();
}
DECL_EXPORT Standard_CString XSControl_WorkSession_SelectedNorm461FC46A(
	void* instance,
	bool rsc)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return  	result->SelectedNorm(			
rsc);
}
DECL_EXPORT void XSControl_WorkSession_ClearContext(void* instance)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
 	result->ClearContext();
}
DECL_EXPORT void XSControl_WorkSession_InitTransferReaderE8219145(
	void* instance,
	int mode)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
 	result->InitTransferReader(			
mode);
}
DECL_EXPORT void* XSControl_WorkSession_MapReader(void* instance)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return new Handle_Transfer_TransientProcess( 	result->MapReader());
}
DECL_EXPORT bool XSControl_WorkSession_SetMapReader38FF314(
	void* instance,
	void* TP)
{
		const Handle_Transfer_TransientProcess&  _TP =*(const Handle_Transfer_TransientProcess *)TP;
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return  	result->SetMapReader(			
_TP);
}
DECL_EXPORT void* XSControl_WorkSession_Result73E03EE2(
	void* instance,
	void* ent,
	int mode)
{
		const Handle_Standard_Transient&  _ent =*(const Handle_Standard_Transient *)ent;
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return new Handle_Standard_Transient( 	result->Result(			
_ent,			
mode));
}
DECL_EXPORT int XSControl_WorkSession_TransferReadOneF411CB01(
	void* instance,
	void* ents)
{
		const Handle_Standard_Transient&  _ents =*(const Handle_Standard_Transient *)ents;
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return  	result->TransferReadOne(			
_ents);
}
DECL_EXPORT int XSControl_WorkSession_TransferWriteShape5E7DD5C8(
	void* instance,
	void* shape,
	bool compgraph)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return  	result->TransferWriteShape(			
_shape,			
compgraph);
}
DECL_EXPORT void XSControl_WorkSession_ClearBinders(void* instance)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
 	result->ClearBinders();
}
DECL_EXPORT void* XSControl_WorkSession_Context(void* instance)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return 	new Handle_Dico_DictionaryOfTransient(	result->Context());
}

DECL_EXPORT void XSControl_WorkSession_SetAllContext(void* instance, void* value)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
		result->SetAllContext(*(const Handle_Dico_DictionaryOfTransient *)value);
}

DECL_EXPORT int XSControl_WorkSession_TransferReadRoots(void* instance)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return 	result->TransferReadRoots();
}

DECL_EXPORT void XSControl_WorkSession_SetModeWriteShape(void* instance, int value)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
		result->SetModeWriteShape(value);
}

DECL_EXPORT int XSControl_WorkSession_ModeWriteShape(void* instance)
{
	XSControl_WorkSession* result = (XSControl_WorkSession*)(((Handle_XSControl_WorkSession*)instance)->Access());
	return 	result->ModeWriteShape();
}

DECL_EXPORT void XSControlWorkSession_Dtor(void* instance)
{
	delete (Handle_XSControl_WorkSession*)instance;
}
