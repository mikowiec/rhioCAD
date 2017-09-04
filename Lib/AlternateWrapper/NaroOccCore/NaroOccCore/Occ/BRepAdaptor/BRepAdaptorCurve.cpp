#include "BRepAdaptorCurve.h"
#include <BRepAdaptor_Curve.hxx>

#include <Adaptor3d_HCurve.hxx>
#include <Geom_BezierCurve.hxx>
#include <GeomAdaptor_Curve.hxx>
#include <gp_Circ.hxx>
#include <gp_Elips.hxx>
#include <gp_Hypr.hxx>
#include <gp_Lin.hxx>
#include <gp_Parab.hxx>
#include <gp_Pnt.hxx>
#include <gp_Trsf.hxx>
#include <gp_Vec.hxx>
#include <TopoDS_Edge.hxx>

DECL_EXPORT void* BRepAdaptor_Curve_Ctor()
{
	return new BRepAdaptor_Curve();
}
DECL_EXPORT void* BRepAdaptor_Curve_Ctor24263856(
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	return new BRepAdaptor_Curve(			
_E);
}
DECL_EXPORT void* BRepAdaptor_Curve_Ctor65EC701C(
	void* E,
	void* F)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new BRepAdaptor_Curve(			
_E,			
_F);
}
DECL_EXPORT void BRepAdaptor_Curve_Initialize24263856(
	void* instance,
	void* E)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
 	result->Initialize(			
_E);
}
DECL_EXPORT void BRepAdaptor_Curve_Initialize65EC701C(
	void* instance,
	void* E,
	void* F)
{
		const TopoDS_Edge &  _E =*(const TopoDS_Edge *)E;
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
 	result->Initialize(			
_E,			
_F);
}
DECL_EXPORT int BRepAdaptor_Curve_NbIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return  	result->NbIntervals(			
_S);
}
DECL_EXPORT void* BRepAdaptor_Curve_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return new Handle_Adaptor3d_HCurve( 	result->Trim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* BRepAdaptor_Curve_ValueD82819F3(
	void* instance,
	double U)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return new gp_Pnt( 	result->Value(			
U));
}
DECL_EXPORT void* BRepAdaptor_Curve_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT double BRepAdaptor_Curve_ResolutionD82819F3(
	void* instance,
	double R3d)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return  	result->Resolution(			
R3d);
}
DECL_EXPORT void* BRepAdaptor_Curve_Trsf(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new gp_Trsf(	result->Trsf());
}

DECL_EXPORT bool BRepAdaptor_Curve_Is3DCurve(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->Is3DCurve();
}

DECL_EXPORT bool BRepAdaptor_Curve_IsCurveOnSurface(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->IsCurveOnSurface();
}

DECL_EXPORT void* BRepAdaptor_Curve_Curve(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new GeomAdaptor_Curve(	result->Curve());
}

DECL_EXPORT void* BRepAdaptor_Curve_Edge(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new TopoDS_Edge(	result->Edge());
}

DECL_EXPORT double BRepAdaptor_Curve_Tolerance(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->Tolerance();
}

DECL_EXPORT double BRepAdaptor_Curve_FirstParameter(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->FirstParameter();
}

DECL_EXPORT double BRepAdaptor_Curve_LastParameter(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->LastParameter();
}

DECL_EXPORT int BRepAdaptor_Curve_Continuity(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return (int)	result->Continuity();
}

DECL_EXPORT bool BRepAdaptor_Curve_IsClosed(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->IsClosed();
}

DECL_EXPORT bool BRepAdaptor_Curve_IsPeriodic(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->IsPeriodic();
}

DECL_EXPORT double BRepAdaptor_Curve_Period(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->Period();
}

DECL_EXPORT int BRepAdaptor_Curve_GetType(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return (int)	result->GetType();
}

DECL_EXPORT void* BRepAdaptor_Curve_Line(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new gp_Lin(	result->Line());
}

DECL_EXPORT void* BRepAdaptor_Curve_Circle(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new gp_Circ(	result->Circle());
}

DECL_EXPORT void* BRepAdaptor_Curve_Ellipse(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new gp_Elips(	result->Ellipse());
}

DECL_EXPORT void* BRepAdaptor_Curve_Hyperbola(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new gp_Hypr(	result->Hyperbola());
}

DECL_EXPORT void* BRepAdaptor_Curve_Parabola(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new gp_Parab(	result->Parabola());
}

DECL_EXPORT int BRepAdaptor_Curve_Degree(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->Degree();
}

DECL_EXPORT bool BRepAdaptor_Curve_IsRational(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->IsRational();
}

DECL_EXPORT int BRepAdaptor_Curve_NbPoles(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->NbPoles();
}

DECL_EXPORT int BRepAdaptor_Curve_NbKnots(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	result->NbKnots();
}

DECL_EXPORT void* BRepAdaptor_Curve_Bezier(void* instance)
{
	BRepAdaptor_Curve* result = (BRepAdaptor_Curve*)instance;
	return 	new Handle_Geom_BezierCurve(	result->Bezier());
}

DECL_EXPORT void BRepAdaptorCurve_Dtor(void* instance)
{
	delete (BRepAdaptor_Curve*)instance;
}
