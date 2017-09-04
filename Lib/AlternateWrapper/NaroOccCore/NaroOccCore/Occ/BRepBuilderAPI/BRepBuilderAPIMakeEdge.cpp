#include "BRepBuilderAPIMakeEdge.h"
#include <BRepBuilderAPI_MakeEdge.hxx>

#include <TopoDS_Edge.hxx>
#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor()
{
	return new BRepBuilderAPI_MakeEdge();
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor17F57B4B(
	void* V1,
	void* V2)
{
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_V1,			
_V2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor5C63477E(
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_P1,			
_P2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor9917D291(
	void* L)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor13A123E9(
	void* L,
	double p1,
	double p2)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
p1,			
p2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor89D07A8C(
	void* L,
	void* P1,
	void* P2)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_P1,			
_P2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor1D47CBD(
	void* L,
	void* V1,
	void* V2)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_V1,			
_V2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor727811A8(
	void* L)
{
		const gp_Circ &  _L =*(const gp_Circ *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorD1F21AD1(
	void* L,
	double p1,
	double p2)
{
		const gp_Circ &  _L =*(const gp_Circ *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
p1,			
p2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorF9002809(
	void* L,
	void* P1,
	void* P2)
{
		const gp_Circ &  _L =*(const gp_Circ *)L;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_P1,			
_P2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorE5C0731B(
	void* L,
	void* V1,
	void* V2)
{
		const gp_Circ &  _L =*(const gp_Circ *)L;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_V1,			
_V2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorAA0BF3BF(
	void* L)
{
		const gp_Elips &  _L =*(const gp_Elips *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorE07A45E0(
	void* L,
	double p1,
	double p2)
{
		const gp_Elips &  _L =*(const gp_Elips *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
p1,			
p2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorF09C8A36(
	void* L,
	void* P1,
	void* P2)
{
		const gp_Elips &  _L =*(const gp_Elips *)L;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_P1,			
_P2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor3CB9094F(
	void* L,
	void* V1,
	void* V2)
{
		const gp_Elips &  _L =*(const gp_Elips *)L;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_V1,			
_V2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorF96BFAD7(
	void* L)
{
		const gp_Hypr &  _L =*(const gp_Hypr *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor8CC08831(
	void* L,
	double p1,
	double p2)
{
		const gp_Hypr &  _L =*(const gp_Hypr *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
p1,			
p2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor23F161EC(
	void* L,
	void* P1,
	void* P2)
{
		const gp_Hypr &  _L =*(const gp_Hypr *)L;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_P1,			
_P2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor61331CF3(
	void* L,
	void* V1,
	void* V2)
{
		const gp_Hypr &  _L =*(const gp_Hypr *)L;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_V1,			
_V2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor4008A9E4(
	void* L)
{
		const gp_Parab &  _L =*(const gp_Parab *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor8DF7070E(
	void* L,
	double p1,
	double p2)
{
		const gp_Parab &  _L =*(const gp_Parab *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
p1,			
p2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorB18E1764(
	void* L,
	void* P1,
	void* P2)
{
		const gp_Parab &  _L =*(const gp_Parab *)L;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_P1,			
_P2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorFB0B4975(
	void* L,
	void* V1,
	void* V2)
{
		const gp_Parab &  _L =*(const gp_Parab *)L;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_V1,			
_V2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorFF608AE4(
	void* L)
{
		const Handle_Geom_Curve&  _L =*(const Handle_Geom_Curve *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorED53F64D(
	void* L,
	double p1,
	double p2)
{
		const Handle_Geom_Curve&  _L =*(const Handle_Geom_Curve *)L;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
p1,			
p2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor442B1D85(
	void* L,
	void* P1,
	void* P2)
{
		const Handle_Geom_Curve&  _L =*(const Handle_Geom_Curve *)L;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_P1,			
_P2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Ctor1D50351E(
	void* L,
	void* V1,
	void* V2)
{
		const Handle_Geom_Curve&  _L =*(const Handle_Geom_Curve *)L;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_V1,			
_V2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorAFABB219(
	void* L,
	void* P1,
	void* P2,
	double p1,
	double p2)
{
		const Handle_Geom_Curve&  _L =*(const Handle_Geom_Curve *)L;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_P1,			
_P2,			
p1,			
p2);
}
DECL_EXPORT void* BRepBuilderAPI_MakeEdge_CtorA7D86004(
	void* L,
	void* V1,
	void* V2,
	double p1,
	double p2)
{
		const Handle_Geom_Curve&  _L =*(const Handle_Geom_Curve *)L;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	return new BRepBuilderAPI_MakeEdge(			
_L,			
_V1,			
_V2,			
p1,			
p2);
}
DECL_EXPORT void BRepBuilderAPI_MakeEdge_InitFF608AE4(
	void* instance,
	void* C)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
 	result->Init(			
_C);
}
DECL_EXPORT void BRepBuilderAPI_MakeEdge_InitED53F64D(
	void* instance,
	void* C,
	double p1,
	double p2)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
 	result->Init(			
_C,			
p1,			
p2);
}
DECL_EXPORT void BRepBuilderAPI_MakeEdge_Init442B1D85(
	void* instance,
	void* C,
	void* P1,
	void* P2)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
 	result->Init(			
_C,			
_P1,			
_P2);
}
DECL_EXPORT void BRepBuilderAPI_MakeEdge_Init1D50351E(
	void* instance,
	void* C,
	void* V1,
	void* V2)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
 	result->Init(			
_C,			
_V1,			
_V2);
}
DECL_EXPORT void BRepBuilderAPI_MakeEdge_InitAFABB219(
	void* instance,
	void* C,
	void* P1,
	void* P2,
	double p1,
	double p2)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
 	result->Init(			
_C,			
_P1,			
_P2,			
p1,			
p2);
}
DECL_EXPORT void BRepBuilderAPI_MakeEdge_InitA7D86004(
	void* instance,
	void* C,
	void* V1,
	void* V2,
	double p1,
	double p2)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
		const TopoDS_Vertex &  _V1 =*(const TopoDS_Vertex *)V1;
		const TopoDS_Vertex &  _V2 =*(const TopoDS_Vertex *)V2;
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
 	result->Init(			
_C,			
_V1,			
_V2,			
p1,			
p2);
}
DECL_EXPORT bool BRepBuilderAPI_MakeEdge_IsDone(void* instance)
{
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int BRepBuilderAPI_MakeEdge_Error(void* instance)
{
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
	return (int)	result->Error();
}

DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Edge(void* instance)
{
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
	return 	new TopoDS_Edge(	result->Edge());
}

DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Vertex1(void* instance)
{
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
	return 	new TopoDS_Vertex(	result->Vertex1());
}

DECL_EXPORT void* BRepBuilderAPI_MakeEdge_Vertex2(void* instance)
{
	BRepBuilderAPI_MakeEdge* result = (BRepBuilderAPI_MakeEdge*)instance;
	return 	new TopoDS_Vertex(	result->Vertex2());
}

DECL_EXPORT void BRepBuilderAPIMakeEdge_Dtor(void* instance)
{
	delete (BRepBuilderAPI_MakeEdge*)instance;
}
