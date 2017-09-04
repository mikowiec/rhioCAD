#include "XSControlReader.h"
#include <XSControl_Reader.hxx>

#include <Standard_Transient.hxx>
#include <TopoDS_Shape.hxx>
#include <XSControl_WorkSession.hxx>

DECL_EXPORT void* XSControl_Reader_Ctor()
{
	return new XSControl_Reader();
}
DECL_EXPORT void* XSControl_Reader_Ctor9381D4D(
	char* norm)
{
	return new XSControl_Reader(			
norm);
}
DECL_EXPORT void* XSControl_Reader_CtorC53309E3(
	void* WS,
	bool scratch)
{
		const Handle_XSControl_WorkSession&  _WS =*(const Handle_XSControl_WorkSession *)WS;
	return new XSControl_Reader(			
_WS,			
scratch);
}
DECL_EXPORT bool XSControl_Reader_SetNorm9381D4D(
	void* instance,
	char* norm)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return  	result->SetNorm(			
norm);
}
DECL_EXPORT void XSControl_Reader_SetWSC53309E3(
	void* instance,
	void* WS,
	bool scratch)
{
		const Handle_XSControl_WorkSession&  _WS =*(const Handle_XSControl_WorkSession *)WS;
	XSControl_Reader* result = (XSControl_Reader*)instance;
 	result->SetWS(			
_WS,			
scratch);
}
DECL_EXPORT void* XSControl_Reader_WS(void* instance)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return new Handle_XSControl_WorkSession( 	result->WS());
}
DECL_EXPORT int XSControl_Reader_ReadFile9381D4D(
	void* instance,
	char* filename)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return  	result->ReadFile(			
filename);
}
DECL_EXPORT void* XSControl_Reader_RootForTransferE8219145(
	void* instance,
	int num)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return new Handle_Standard_Transient( 	result->RootForTransfer(			
num));
}
DECL_EXPORT bool XSControl_Reader_TransferOneRootE8219145(
	void* instance,
	int num)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return  	result->TransferOneRoot(			
num);
}
DECL_EXPORT bool XSControl_Reader_TransferOneE8219145(
	void* instance,
	int num)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return  	result->TransferOne(			
num);
}
DECL_EXPORT bool XSControl_Reader_TransferEntityF411CB01(
	void* instance,
	void* start)
{
		const Handle_Standard_Transient&  _start =*(const Handle_Standard_Transient *)start;
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return  	result->TransferEntity(			
_start);
}
DECL_EXPORT void XSControl_Reader_ClearShapes(void* instance)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
 	result->ClearShapes();
}
DECL_EXPORT void* XSControl_Reader_ShapeE8219145(
	void* instance,
	int num)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return new TopoDS_Shape( 	result->Shape(			
num));
}
DECL_EXPORT void XSControl_Reader_PrintCheckLoad57E14BA(
	void* instance,
	bool failsonly,
	int mode)
{
		const IFSelect_PrintCount _mode =(const IFSelect_PrintCount )mode;
	XSControl_Reader* result = (XSControl_Reader*)instance;
 	result->PrintCheckLoad(			
failsonly,			
_mode);
}
DECL_EXPORT void XSControl_Reader_PrintCheckTransfer57E14BA(
	void* instance,
	bool failsonly,
	int mode)
{
		const IFSelect_PrintCount _mode =(const IFSelect_PrintCount )mode;
	XSControl_Reader* result = (XSControl_Reader*)instance;
 	result->PrintCheckTransfer(			
failsonly,			
_mode);
}
DECL_EXPORT void XSControl_Reader_PrintStatsTransfer5107F6FE(
	void* instance,
	int what,
	int mode)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
 	result->PrintStatsTransfer(			
what,			
mode);
}
DECL_EXPORT int XSControl_Reader_NbRootsForTransfer(void* instance)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return 	result->NbRootsForTransfer();
}

DECL_EXPORT int XSControl_Reader_TransferRoots(void* instance)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return 	result->TransferRoots();
}

DECL_EXPORT int XSControl_Reader_NbShapes(void* instance)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return 	result->NbShapes();
}

DECL_EXPORT void* XSControl_Reader_OneShape(void* instance)
{
	XSControl_Reader* result = (XSControl_Reader*)instance;
	return 	new TopoDS_Shape(	result->OneShape());
}

DECL_EXPORT void XSControlReader_Dtor(void* instance)
{
	delete (XSControl_Reader*)instance;
}
