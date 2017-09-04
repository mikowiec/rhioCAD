#include "BRepBuilder.h"
#include <BRep_Builder.hxx>


DECL_EXPORT void BRep_Builder_MakeFaceAEC70AC1(
	void* instance,
	void* F)
{
		 TopoDS_Face &  _F =*( TopoDS_Face *)F;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeFace(			
_F);
}
DECL_EXPORT void BRep_Builder_MakeFace7EEC8D91(
	void* instance,
	void* F,
	void* S,
	double Tol)
{
		 TopoDS_Face &  _F =*( TopoDS_Face *)F;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeFace(			
_F,			
_S,			
Tol);
}
DECL_EXPORT void BRep_Builder_MakeFaceBAA765A3(
	void* instance,
	void* F,
	void* S,
	void* L,
	double Tol)
{
		 TopoDS_Face &  _F =*( TopoDS_Face *)F;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeFace(			
_F,			
_S,			
_L,			
Tol);
}
DECL_EXPORT void BRep_Builder_MakeFaceE5A9949B(
	void* instance,
	void* F,
	void* T)
{
		 TopoDS_Face &  _F =*( TopoDS_Face *)F;
		const Handle_Poly_Triangulation&  _T =*(const Handle_Poly_Triangulation *)T;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeFace(			
_F,			
_T);
}
DECL_EXPORT void BRep_Builder_UpdateFaceBAA765A3(
	void* instance,
	void* F,
	void* S,
	void* L,
	double Tol)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateFace(			
_F,			
_S,			
_L,			
Tol);
}
DECL_EXPORT void BRep_Builder_UpdateFaceE5A9949B(
	void* instance,
	void* F,
	void* T)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const Handle_Poly_Triangulation&  _T =*(const Handle_Poly_Triangulation *)T;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateFace(			
_F,			
_T);
}
DECL_EXPORT void BRep_Builder_UpdateFace5D6B238E(
	void* instance,
	void* F,
	double Tol)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateFace(			
_F,			
Tol);
}
DECL_EXPORT void BRep_Builder_NaturalRestriction4945DBAD(
	void* instance,
	void* F,
	bool N)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->NaturalRestriction(			
_F,			
N);
}
DECL_EXPORT void BRep_Builder_MakeEdge24263856(
	void* instance,
	void* E)
{
		 TopoDS_Edge &  _E =*( TopoDS_Edge *)E;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeEdge(			
_E);
}
DECL_EXPORT void BRep_Builder_MakeEdgeE5AE3CE7(
	void* instance,
	void* E,
	void* C,
	double Tol)
{
		 TopoDS_Edge &  _E =*( TopoDS_Edge *)E;
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeEdge(			
_E,			
_C,			
Tol);
}
DECL_EXPORT void BRep_Builder_MakeEdge686D1199(
	void* instance,
	void* E,
	void* C,
	void* L,
	double Tol)
{
		 TopoDS_Edge &  _E =*( TopoDS_Edge *)E;
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeEdge(			
_E,			
_C,			
_L,			
Tol);
}
DECL_EXPORT void BRep_Builder_ContinuityD6A3B177(
	void* instance,
	void* E,
	void* F1,
	void* F2,
	int C)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F1 =*(const TopoDS_Face *)F1;
		const TopoDS_Face &  _F2 =*(const TopoDS_Face *)F2;
		const GeomAbs_Shape _C =(const GeomAbs_Shape )C;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Continuity(			
_E,			
_F1,			
_F2,			
_C);
}
DECL_EXPORT void BRep_Builder_ContinuityBD255723(
	void* instance,
	void* E,
	void* S1,
	void* S2,
	void* L1,
	void* L2,
	int C)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S1 =*(const Handle_Geom_Surface *)S1;
		const Handle_Geom_Surface&  _S2 =*(const Handle_Geom_Surface *)S2;
		const TopLoc_Location &  _L1 =*(const TopLoc_Location *)L1;
		const TopLoc_Location &  _L2 =*(const TopLoc_Location *)L2;
		const GeomAbs_Shape _C =(const GeomAbs_Shape )C;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Continuity(			
_E,			
_S1,			
_S2,			
_L1,			
_L2,			
_C);
}
DECL_EXPORT void BRep_Builder_SameParameter7F8C607A(
	void* instance,
	void* E,
	bool S)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->SameParameter(			
_E,			
S);
}
DECL_EXPORT void BRep_Builder_SameRange7F8C607A(
	void* instance,
	void* E,
	bool S)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->SameRange(			
_E,			
S);
}
DECL_EXPORT void BRep_Builder_Degenerated7F8C607A(
	void* instance,
	void* E,
	bool D)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Degenerated(			
_E,			
D);
}
DECL_EXPORT void BRep_Builder_Range7522FA9B(
	void* instance,
	void* E,
	double First,
	double Last,
	bool Only3d)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Range(			
_E,			
First,			
Last,			
Only3d);
}
DECL_EXPORT void BRep_Builder_Range367873C2(
	void* instance,
	void* E,
	void* S,
	void* L,
	double First,
	double Last)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Range(			
_E,			
_S,			
_L,			
First,			
Last);
}
DECL_EXPORT void BRep_Builder_RangeF1087A9D(
	void* instance,
	void* E,
	void* F,
	double First,
	double Last)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Range(			
_E,			
_F,			
First,			
Last);
}
DECL_EXPORT void BRep_Builder_Transfert4DFF7017(
	void* instance,
	void* Ein,
	void* Eout)
{
		const TopoDS_Edge &  _Ein =*(const TopoDS_Edge *)Ein;
		const TopoDS_Edge &  _Eout =*(const TopoDS_Edge *)Eout;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Transfert(			
_Ein,			
_Eout);
}
DECL_EXPORT void BRep_Builder_MakeVertex3EF07F6A(
	void* instance,
	void* V)
{
		 TopoDS_Vertex &  _V =*( TopoDS_Vertex *)V;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeVertex(			
_V);
}
DECL_EXPORT void BRep_Builder_MakeVertex3B977AAF(
	void* instance,
	void* V,
	void* P,
	double Tol)
{
		 TopoDS_Vertex &  _V =*( TopoDS_Vertex *)V;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->MakeVertex(			
_V,			
_P,			
Tol);
}
DECL_EXPORT void BRep_Builder_UpdateVertex3B977AAF(
	void* instance,
	void* V,
	void* P,
	double Tol)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateVertex(			
_V,			
_P,			
Tol);
}
DECL_EXPORT void BRep_Builder_UpdateVertex4056A7EF(
	void* instance,
	void* V,
	double P,
	void* E,
	double Tol)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateVertex(			
_V,			
P,			
_E,			
Tol);
}
DECL_EXPORT void BRep_Builder_UpdateVertex7CBB7775(
	void* instance,
	void* V,
	double P,
	void* E,
	void* F,
	double Tol)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateVertex(			
_V,			
P,			
_E,			
_F,			
Tol);
}
DECL_EXPORT void BRep_Builder_UpdateVertex2BB581FE(
	void* instance,
	void* V,
	double P,
	void* E,
	void* S,
	void* L,
	double Tol)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateVertex(			
_V,			
P,			
_E,			
_S,			
_L,			
Tol);
}
DECL_EXPORT void BRep_Builder_UpdateVertex7A0EDB4B(
	void* instance,
	void* Ve,
	double U,
	double V,
	void* F,
	double Tol)
{
		const TopoDS_Vertex &  _Ve =*(const TopoDS_Vertex *)Ve;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateVertex(			
_Ve,			
U,			
V,			
_F,			
Tol);
}
DECL_EXPORT void BRep_Builder_UpdateVertex729B627B(
	void* instance,
	void* V,
	double Tol)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->UpdateVertex(			
_V,			
Tol);
}
DECL_EXPORT void BRep_Builder_Transfert41DFC03D(
	void* instance,
	void* Ein,
	void* Eout,
	void* Vin,
	void* Vout)
{
		const TopoDS_Edge &  _Ein =*(const TopoDS_Edge *)Ein;
		const TopoDS_Edge &  _Eout =*(const TopoDS_Edge *)Eout;
		const TopoDS_Vertex &  _Vin =*(const TopoDS_Vertex *)Vin;
		const TopoDS_Vertex &  _Vout =*(const TopoDS_Vertex *)Vout;
	BRep_Builder* result = (BRep_Builder*)instance;
 	result->Transfert(			
_Ein,			
_Eout,			
_Vin,			
_Vout);
}
DECL_EXPORT void BRepBuilder_Dtor(void* instance)
{
	delete (BRep_Builder*)instance;
}
