#include "BRepTool.h"
#include <BRep_Tool.hxx>

#include <Geom_Curve.hxx>
#include <Geom_Surface.hxx>
#include <gp_Pnt.hxx>
#include <gp_Pnt2d.hxx>
#include <Poly_Triangulation.hxx>

DECL_EXPORT bool BRep_Tool_IsClosed9EBAC0C0(
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return  BRep_Tool::IsClosed(			
_S);
}
DECL_EXPORT void* BRep_Tool_SurfaceCE8D63EE(
	void* F,
	void* L)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		 TopLoc_Location &  _L =*( TopLoc_Location *)L;
	return new Handle_Geom_Surface( BRep_Tool::Surface(			
_F,			
_L));
}
DECL_EXPORT void* BRep_Tool_SurfaceAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new Handle_Geom_Surface( BRep_Tool::Surface(			
_F));
}
DECL_EXPORT void* BRep_Tool_TriangulationCE8D63EE(
	void* F,
	void* L)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		 TopLoc_Location &  _L =*( TopLoc_Location *)L;
	return new Handle_Poly_Triangulation( BRep_Tool::Triangulation(			
_F,			
_L));
}
DECL_EXPORT double BRep_Tool_ToleranceAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return  BRep_Tool::Tolerance(			
_F);
}
DECL_EXPORT bool BRep_Tool_NaturalRestrictionAEC70AC1(
	void* F)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return  BRep_Tool::NaturalRestriction(			
_F);
}
DECL_EXPORT bool BRep_Tool_IsGeometric24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return  BRep_Tool::IsGeometric(			
_E);
}
DECL_EXPORT void* BRep_Tool_CurveC0F32C66(
	void* E,
	void* L,
	double* First,
	double* Last)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		 TopLoc_Location &  _L =*( TopLoc_Location *)L;
	return new Handle_Geom_Curve( BRep_Tool::Curve(			
_E,			
_L,			
*First,			
*Last));
}
DECL_EXPORT void* BRep_Tool_Curve218243EB(
	void* E,
	double* First,
	double* Last)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return new Handle_Geom_Curve( BRep_Tool::Curve(			
_E,			
*First,			
*Last));
}
DECL_EXPORT bool BRep_Tool_IsClosed65EC701C(
	void* E,
	void* F)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return  BRep_Tool::IsClosed(			
_E,			
_F);
}
DECL_EXPORT bool BRep_Tool_IsClosed492F2C78(
	void* E,
	void* S,
	void* L)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	return  BRep_Tool::IsClosed(			
_E,			
_S,			
_L);
}
DECL_EXPORT bool BRep_Tool_IsClosed3E433981(
	void* E,
	void* T)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Poly_Triangulation&  _T =*(const Handle_Poly_Triangulation *)T;
	return  BRep_Tool::IsClosed(			
_E,			
_T);
}
DECL_EXPORT double BRep_Tool_Tolerance24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return  BRep_Tool::Tolerance(			
_E);
}
DECL_EXPORT bool BRep_Tool_SameParameter24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return  BRep_Tool::SameParameter(			
_E);
}
DECL_EXPORT bool BRep_Tool_SameRange24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return  BRep_Tool::SameRange(			
_E);
}
DECL_EXPORT bool BRep_Tool_Degenerated24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return  BRep_Tool::Degenerated(			
_E);
}
DECL_EXPORT void BRep_Tool_Range218243EB(
	void* E,
	double* First,
	double* Last)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
 BRep_Tool::Range(			
_E,			
*First,			
*Last);
}
DECL_EXPORT void BRep_Tool_Range367873C2(
	void* E,
	void* S,
	void* L,
	double* First,
	double* Last)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
 BRep_Tool::Range(			
_E,			
_S,			
_L,			
*First,			
*Last);
}
DECL_EXPORT void BRep_Tool_RangeF1087A9D(
	void* E,
	void* F,
	double* First,
	double* Last)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
 BRep_Tool::Range(			
_E,			
_F,			
*First,			
*Last);
}
DECL_EXPORT void BRep_Tool_UVPointsCD33147E(
	void* E,
	void* S,
	void* L,
	void* PFirst,
	void* PLast)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
		 gp_Pnt2d &  _PFirst =*( gp_Pnt2d *)PFirst;
		 gp_Pnt2d &  _PLast =*( gp_Pnt2d *)PLast;
 BRep_Tool::UVPoints(			
_E,			
_S,			
_L,			
_PFirst,			
_PLast);
}
DECL_EXPORT void BRep_Tool_UVPoints6AA8D466(
	void* E,
	void* F,
	void* PFirst,
	void* PLast)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		 gp_Pnt2d &  _PFirst =*( gp_Pnt2d *)PFirst;
		 gp_Pnt2d &  _PLast =*( gp_Pnt2d *)PLast;
 BRep_Tool::UVPoints(			
_E,			
_F,			
_PFirst,			
_PLast);
}
DECL_EXPORT void BRep_Tool_SetUVPointsCD33147E(
	void* E,
	void* S,
	void* L,
	void* PFirst,
	void* PLast)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
		const gp_Pnt2d &  _PFirst =*(const gp_Pnt2d *)PFirst;
		const gp_Pnt2d &  _PLast =*(const gp_Pnt2d *)PLast;
 BRep_Tool::SetUVPoints(			
_E,			
_S,			
_L,			
_PFirst,			
_PLast);
}
DECL_EXPORT void BRep_Tool_SetUVPoints6AA8D466(
	void* E,
	void* F,
	void* PFirst,
	void* PLast)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
		const gp_Pnt2d &  _PFirst =*(const gp_Pnt2d *)PFirst;
		const gp_Pnt2d &  _PLast =*(const gp_Pnt2d *)PLast;
 BRep_Tool::SetUVPoints(			
_E,			
_F,			
_PFirst,			
_PLast);
}
DECL_EXPORT bool BRep_Tool_HasContinuityA211568F(
	void* E,
	void* F1,
	void* F2)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F1 =*(const TopoDS_Face *)F1;
		const TopoDS_Face &  _F2 =*(const TopoDS_Face *)F2;
	return  BRep_Tool::HasContinuity(			
_E,			
_F1,			
_F2);
}
DECL_EXPORT int BRep_Tool_ContinuityA211568F(
	void* E,
	void* F1,
	void* F2)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F1 =*(const TopoDS_Face *)F1;
		const TopoDS_Face &  _F2 =*(const TopoDS_Face *)F2;
	return  BRep_Tool::Continuity(			
_E,			
_F1,			
_F2);
}
DECL_EXPORT bool BRep_Tool_HasContinuityF876CD3E(
	void* E,
	void* S1,
	void* S2,
	void* L1,
	void* L2)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S1 =*(const Handle_Geom_Surface *)S1;
		const Handle_Geom_Surface&  _S2 =*(const Handle_Geom_Surface *)S2;
		const TopLoc_Location &  _L1 =*(const TopLoc_Location *)L1;
		const TopLoc_Location &  _L2 =*(const TopLoc_Location *)L2;
	return  BRep_Tool::HasContinuity(			
_E,			
_S1,			
_S2,			
_L1,			
_L2);
}
DECL_EXPORT int BRep_Tool_ContinuityF876CD3E(
	void* E,
	void* S1,
	void* S2,
	void* L1,
	void* L2)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S1 =*(const Handle_Geom_Surface *)S1;
		const Handle_Geom_Surface&  _S2 =*(const Handle_Geom_Surface *)S2;
		const TopLoc_Location &  _L1 =*(const TopLoc_Location *)L1;
		const TopLoc_Location &  _L2 =*(const TopLoc_Location *)L2;
	return  BRep_Tool::Continuity(			
_E,			
_S1,			
_S2,			
_L1,			
_L2);
}
DECL_EXPORT void* BRep_Tool_Pnt3EF07F6A(
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	return new gp_Pnt( BRep_Tool::Pnt(			
_V));
}
DECL_EXPORT double BRep_Tool_Tolerance3EF07F6A(
	void* V)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
	return  BRep_Tool::Tolerance(			
_V);
}
DECL_EXPORT double BRep_Tool_ParameterF133D096(
	void* V,
	void* E)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return  BRep_Tool::Parameter(			
_V,			
_E);
}
DECL_EXPORT double BRep_Tool_Parameter28AFE250(
	void* V,
	void* E,
	void* F)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return  BRep_Tool::Parameter(			
_V,			
_E,			
_F);
}
DECL_EXPORT double BRep_Tool_Parameter9ECB6476(
	void* V,
	void* E,
	void* S,
	void* L)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	return  BRep_Tool::Parameter(			
_V,			
_E,			
_S,			
_L);
}
DECL_EXPORT void* BRep_Tool_Parameters6DF2E67(
	void* V,
	void* F)
{
		const TopoDS_Vertex &  _V =*(const TopoDS_Vertex *)V;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new gp_Pnt2d( BRep_Tool::Parameters(			
_V,			
_F));
}
DECL_EXPORT void BRepTool_Dtor(void* instance)
{
	delete (BRep_Tool*)instance;
}
