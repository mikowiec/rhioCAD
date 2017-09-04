#include "STEPControlWriter.h"
#include <STEPControl_Writer.hxx>

#include <XSControl_WorkSession.hxx>

DECL_EXPORT void* STEPControl_Writer_Ctor()
{
	return new STEPControl_Writer();
}
DECL_EXPORT void* STEPControl_Writer_CtorC53309E3(
	void* WS,
	bool scratch)
{
		const Handle_XSControl_WorkSession&  _WS =*(const Handle_XSControl_WorkSession *)WS;
	return new STEPControl_Writer(			
_WS,			
scratch);
}
DECL_EXPORT void STEPControl_Writer_UnsetTolerance(void* instance)
{
	STEPControl_Writer* result = (STEPControl_Writer*)instance;
 	result->UnsetTolerance();
}
DECL_EXPORT void STEPControl_Writer_SetWSC53309E3(
	void* instance,
	void* WS,
	bool scratch)
{
		const Handle_XSControl_WorkSession&  _WS =*(const Handle_XSControl_WorkSession *)WS;
	STEPControl_Writer* result = (STEPControl_Writer*)instance;
 	result->SetWS(			
_WS,			
scratch);
}
DECL_EXPORT void* STEPControl_Writer_WS(void* instance)
{
	STEPControl_Writer* result = (STEPControl_Writer*)instance;
	return new Handle_XSControl_WorkSession( 	result->WS());
}
DECL_EXPORT int STEPControl_Writer_Transfer9FBB318E(
	void* instance,
	void* sh,
	int mode,
	bool compgraph)
{
		const TopoDS_Shape &  _sh =*(const TopoDS_Shape *)sh;
		const STEPControl_StepModelType _mode =(const STEPControl_StepModelType )mode;
	STEPControl_Writer* result = (STEPControl_Writer*)instance;
	return  	result->Transfer(			
_sh,			
_mode,			
compgraph);
}
DECL_EXPORT int STEPControl_Writer_Write9381D4D(
	void* instance,
	char* filename)
{
	STEPControl_Writer* result = (STEPControl_Writer*)instance;
	return  	result->Write(			
filename);
}
DECL_EXPORT void STEPControl_Writer_PrintStatsTransfer5107F6FE(
	void* instance,
	int what,
	int mode)
{
	STEPControl_Writer* result = (STEPControl_Writer*)instance;
 	result->PrintStatsTransfer(			
what,			
mode);
}
DECL_EXPORT void STEPControl_Writer_SetTolerance(void* instance, double value)
{
	STEPControl_Writer* result = (STEPControl_Writer*)instance;
		result->SetTolerance(value);
}

DECL_EXPORT void STEPControlWriter_Dtor(void* instance)
{
	delete (STEPControl_Writer*)instance;
}
