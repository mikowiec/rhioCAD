#include "TopExp.h"
#include <TopExp.hxx>

#include <TopoDS_Vertex.hxx>

DECL_EXPORT void TopExp_MapShapes9B2ADE8F(
	void* S,
	int T,
	void* M)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const TopAbs_ShapeEnum _T =(const TopAbs_ShapeEnum )T;
		TopTools_IndexedMapOfShape &  _M =*(TopTools_IndexedMapOfShape *)M;
 TopExp::MapShapes(			
_S,			
_T,			
_M);
}
DECL_EXPORT void TopExp_MapShapesBBDCAF89(
	void* S,
	void* M)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		TopTools_IndexedMapOfShape &  _M =*(TopTools_IndexedMapOfShape *)M;
 TopExp::MapShapes(			
_S,			
_M);
}
DECL_EXPORT void TopExp_MapShapesAndAncestors1E6131DC(
	void* S,
	int TS,
	int TA,
	void* M)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const TopAbs_ShapeEnum _TS =(const TopAbs_ShapeEnum )TS;
		const TopAbs_ShapeEnum _TA =(const TopAbs_ShapeEnum )TA;
		TopTools_IndexedDataMapOfShapeListOfShape &  _M =*(TopTools_IndexedDataMapOfShapeListOfShape *)M;
 TopExp::MapShapesAndAncestors(			
_S,			
_TS,			
_TA,			
_M);
}
DECL_EXPORT void* TopExp_FirstVertex7F8C607A(
	void* E,
	bool CumOri)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return new TopoDS_Vertex( TopExp::FirstVertex(			
_E,			
CumOri));
}
DECL_EXPORT void* TopExp_LastVertex7F8C607A(
	void* E,
	bool CumOri)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return new TopoDS_Vertex( TopExp::LastVertex(			
_E,			
CumOri));
}
DECL_EXPORT void TopExp_VerticesCB378621(
	void* E,
	void* Vfirst,
	void* Vlast,
	bool CumOri)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		TopoDS_Vertex &  _Vfirst =*(TopoDS_Vertex *)Vfirst;
		TopoDS_Vertex &  _Vlast =*(TopoDS_Vertex *)Vlast;
 TopExp::Vertices(			
_E,			
_Vfirst,			
_Vlast,			
CumOri);
}
DECL_EXPORT void TopExp_Vertices1DDDA71C(
	void* W,
	void* Vfirst,
	void* Vlast)
{
		const TopoDS_Wire &  _W =*(const TopoDS_Wire *)W;
		TopoDS_Vertex &  _Vfirst =*(TopoDS_Vertex *)Vfirst;
		TopoDS_Vertex &  _Vlast =*(TopoDS_Vertex *)Vlast;
 TopExp::Vertices(			
_W,			
_Vfirst,			
_Vlast);
}
DECL_EXPORT bool TopExp_CommonVertexE5EE178A(
	void* E1,
	void* E2,
	void* V)
{
		const TopoDS_Edge &  _E1 =*(const TopoDS_Edge *)E1;
		const TopoDS_Edge &  _E2 =*(const TopoDS_Edge *)E2;
		TopoDS_Vertex &  _V =*(TopoDS_Vertex *)V;
	return  TopExp::CommonVertex(			
_E1,			
_E2,			
_V);
}
DECL_EXPORT void TopExp_Dtor(void* instance)
{
	delete (TopExp*)instance;
}
