#include "GeomAdaptorCurve.h"
#include <GeomAdaptor_Curve.hxx>

#include <Adaptor3d_HCurve.hxx>
#include <Geom_BezierCurve.hxx>
#include <Geom_Curve.hxx>
#include <gp_Circ.hxx>
#include <gp_Elips.hxx>
#include <gp_Hypr.hxx>
#include <gp_Lin.hxx>
#include <gp_Parab.hxx>
#include <gp_Pnt.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* GeomAdaptor_Curve_Ctor()
{
	return new GeomAdaptor_Curve();
}
DECL_EXPORT void* GeomAdaptor_Curve_CtorFF608AE4(
	void* C)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	return new GeomAdaptor_Curve(			
_C);
}
DECL_EXPORT void* GeomAdaptor_Curve_CtorED53F64D(
	void* C,
	double UFirst,
	double ULast)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	return new GeomAdaptor_Curve(			
_C,			
UFirst,			
ULast);
}
DECL_EXPORT void GeomAdaptor_Curve_LoadFF608AE4(
	void* instance,
	void* C)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
 	result->Load(			
_C);
}
DECL_EXPORT void GeomAdaptor_Curve_LoadED53F64D(
	void* instance,
	void* C,
	double UFirst,
	double ULast)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
 	result->Load(			
_C,			
UFirst,			
ULast);
}
DECL_EXPORT int GeomAdaptor_Curve_NbIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return  	result->NbIntervals(			
_S);
}
DECL_EXPORT void* GeomAdaptor_Curve_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return new Handle_Adaptor3d_HCurve( 	result->Trim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* GeomAdaptor_Curve_ValueD82819F3(
	void* instance,
	double U)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return new gp_Pnt( 	result->Value(			
U));
}
DECL_EXPORT void GeomAdaptor_Curve_D053A5A2C1(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void GeomAdaptor_Curve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V =*(gp_Vec *)V;
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
 	result->D1(			
U,			
_P,			
_V);
}
DECL_EXPORT void GeomAdaptor_Curve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void GeomAdaptor_Curve_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
		gp_Vec &  _V3 =*(gp_Vec *)V3;
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* GeomAdaptor_Curve_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT double GeomAdaptor_Curve_ResolutionD82819F3(
	void* instance,
	double R3d)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return  	result->Resolution(			
R3d);
}
DECL_EXPORT void* GeomAdaptor_Curve_Curve(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	new Handle_Geom_Curve(	result->Curve());
}

DECL_EXPORT double GeomAdaptor_Curve_FirstParameter(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->FirstParameter();
}

DECL_EXPORT double GeomAdaptor_Curve_LastParameter(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->LastParameter();
}

DECL_EXPORT int GeomAdaptor_Curve_Continuity(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return (int)	result->Continuity();
}

DECL_EXPORT bool GeomAdaptor_Curve_IsClosed(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->IsClosed();
}

DECL_EXPORT bool GeomAdaptor_Curve_IsPeriodic(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->IsPeriodic();
}

DECL_EXPORT double GeomAdaptor_Curve_Period(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->Period();
}

DECL_EXPORT int GeomAdaptor_Curve_GetType(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return (int)	result->GetType();
}

DECL_EXPORT void* GeomAdaptor_Curve_Line(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	new gp_Lin(	result->Line());
}

DECL_EXPORT void* GeomAdaptor_Curve_Circle(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	new gp_Circ(	result->Circle());
}

DECL_EXPORT void* GeomAdaptor_Curve_Ellipse(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	new gp_Elips(	result->Ellipse());
}

DECL_EXPORT void* GeomAdaptor_Curve_Hyperbola(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	new gp_Hypr(	result->Hyperbola());
}

DECL_EXPORT void* GeomAdaptor_Curve_Parabola(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	new gp_Parab(	result->Parabola());
}

DECL_EXPORT int GeomAdaptor_Curve_Degree(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->Degree();
}

DECL_EXPORT bool GeomAdaptor_Curve_IsRational(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->IsRational();
}

DECL_EXPORT int GeomAdaptor_Curve_NbPoles(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->NbPoles();
}

DECL_EXPORT int GeomAdaptor_Curve_NbKnots(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	result->NbKnots();
}

DECL_EXPORT void* GeomAdaptor_Curve_Bezier(void* instance)
{
	GeomAdaptor_Curve* result = (GeomAdaptor_Curve*)instance;
	return 	new Handle_Geom_BezierCurve(	result->Bezier());
}

DECL_EXPORT void GeomAdaptorCurve_Dtor(void* instance)
{
	delete (GeomAdaptor_Curve*)instance;
}
