#include "BRepBuilderAPIMakeWire.h"
#include <BRepBuilderAPI_MakeWire.hxx>

#include <TopoDS_Edge.hxx>
#include <TopoDS_Vertex.hxx>
#include <TopoDS_Wire.hxx>

DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor()
{
	return new BRepBuilderAPI_MakeWire();
}
DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return new BRepBuilderAPI_MakeWire(			
_E);
}
DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor4DFF7017(
	void* E1,
	void* E2)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
	return new BRepBuilderAPI_MakeWire(			
_E1,			
_E2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeWire_CtorFC90A78C(
	void* E1,
	void* E2,
	void* E3)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
		const TopoDS_Edge &  _E3 =*(const TopoDS_Edge *)E3;
	return new BRepBuilderAPI_MakeWire(			
_E1,			
_E2,			
_E3);
}
DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor4181D08D(
	void* E1,
	void* E2,
	void* E3,
	void* E4)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
		const TopoDS_Edge &  _E3 =*(const TopoDS_Edge *)E3;
		const TopoDS_Edge &  _E4 =*(const TopoDS_Edge *)E4;
	return new BRepBuilderAPI_MakeWire(			
_E1,			
_E2,			
_E3,			
_E4);
}
DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor368EDFE5(
	void* W)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	return new BRepBuilderAPI_MakeWire(			
_W);
}
DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor23F02239(
	void* W,
	void* E)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return new BRepBuilderAPI_MakeWire(			
_W,			
_E);
}
DECL_EXPORT void BRepBuilderAPI_MakeWire_Add24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
 	result->Add(			
_E);
}
DECL_EXPORT void BRepBuilderAPI_MakeWire_Add368EDFE5(
	void* instance,
	void* W)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
 	result->Add(			
_W);
}
DECL_EXPORT void BRepBuilderAPI_MakeWire_Add49A1D41A(
	void* instance,
	void* L)
{
		const TopTools_ListOfShape &  _L =*(const TopTools_ListOfShape *)L;
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
 	result->Add(			
_L);
}
DECL_EXPORT bool BRepBuilderAPI_MakeWire_IsDone(void* instance)
{
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int BRepBuilderAPI_MakeWire_Error(void* instance)
{
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
	return (int)	result->Error();
}

DECL_EXPORT void* BRepBuilderAPI_MakeWire_Wire(void* instance)
{
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
	return 	new TopoDS_Wire(	result->Wire());
}

DECL_EXPORT void* BRepBuilderAPI_MakeWire_Edge(void* instance)
{
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
	return 	new TopoDS_Edge(	result->Edge());
}

DECL_EXPORT void* BRepBuilderAPI_MakeWire_Vertex(void* instance)
{
	BRepBuilderAPI_MakeWire* result = (BRepBuilderAPI_MakeWire*)instance;
	return 	new TopoDS_Vertex(	result->Vertex());
}

DECL_EXPORT void BRepBuilderAPIMakeWire_Dtor(void* instance)
{
	delete (BRepBuilderAPI_MakeWire*)instance;
}
