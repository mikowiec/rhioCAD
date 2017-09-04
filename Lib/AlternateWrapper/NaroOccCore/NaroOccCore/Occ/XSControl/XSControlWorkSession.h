#ifndef XSControl_WorkSession_H
#define XSControl_WorkSession_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* XSControl_WorkSession_Ctor();
extern "C" DECL_EXPORT void XSControl_WorkSession_ClearDataE8219145(
	void* instance,
	int mode);
extern "C" DECL_EXPORT bool XSControl_WorkSession_SelectNorm8A1B7C71(
	void* instance,
	char* normname,
	char* profile);
extern "C" DECL_EXPORT bool XSControl_WorkSession_SelectProfile9381D4D(
	void* instance,
	char* profile);
extern "C" DECL_EXPORT void XSControl_WorkSession_AdaptNorm(void* instance);
extern "C" DECL_EXPORT Standard_CString XSControl_WorkSession_SelectedNorm461FC46A(
	void* instance,
	bool rsc);
extern "C" DECL_EXPORT void XSControl_WorkSession_ClearContext(void* instance);
extern "C" DECL_EXPORT void XSControl_WorkSession_InitTransferReaderE8219145(
	void* instance,
	int mode);
extern "C" DECL_EXPORT void* XSControl_WorkSession_MapReader(void* instance);
extern "C" DECL_EXPORT bool XSControl_WorkSession_SetMapReader38FF314(
	void* instance,
	void* TP);
extern "C" DECL_EXPORT void* XSControl_WorkSession_Result73E03EE2(
	void* instance,
	void* ent,
	int mode);
extern "C" DECL_EXPORT int XSControl_WorkSession_TransferReadOneF411CB01(
	void* instance,
	void* ents);
extern "C" DECL_EXPORT int XSControl_WorkSession_TransferWriteShape5E7DD5C8(
	void* instance,
	void* shape,
	bool compgraph);
extern "C" DECL_EXPORT void XSControl_WorkSession_ClearBinders(void* instance);
extern "C" DECL_EXPORT void* XSControl_WorkSession_Context(void* instance);
extern "C" DECL_EXPORT void XSControl_WorkSession_SetAllContext(void* instance, void* value);
extern "C" DECL_EXPORT int XSControl_WorkSession_TransferReadRoots(void* instance);
extern "C" DECL_EXPORT void XSControl_WorkSession_SetModeWriteShape(void* instance, int value);
extern "C" DECL_EXPORT int XSControl_WorkSession_ModeWriteShape(void* instance);
extern "C" DECL_EXPORT void XSControlWorkSession_Dtor(void* instance);

#endif
