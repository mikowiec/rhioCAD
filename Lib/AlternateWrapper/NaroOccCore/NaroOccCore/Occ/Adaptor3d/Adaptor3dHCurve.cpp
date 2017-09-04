#include "Adaptor3dHCurve.h"
#include <Adaptor3d_HCurve.hxx>

#include <Adaptor3d_HCurve.hxx>
#include <Geom_BezierCurve.hxx>
#include <gp_Circ.hxx>
#include <gp_Elips.hxx>
#include <gp_Hypr.hxx>
#include <gp_Lin.hxx>
#include <gp_Parab.hxx>
#include <gp_Pnt.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT int Adaptor3d_HCurve_NbIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return  	result->NbIntervals(			
_S);
}
DECL_EXPORT void* Adaptor3d_HCurve_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return new Handle_Adaptor3d_HCurve( 	result->Trim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* Adaptor3d_HCurve_ValueD82819F3(
	void* instance,
	double U)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return new gp_Pnt( 	result->Value(			
U));
}
DECL_EXPORT void Adaptor3d_HCurve_D053A5A2C1(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void Adaptor3d_HCurve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V =*(gp_Vec *)V;
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
 	result->D1(			
U,			
_P,			
_V);
}
DECL_EXPORT void Adaptor3d_HCurve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void Adaptor3d_HCurve_D356E36E6F(
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
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* Adaptor3d_HCurve_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT double Adaptor3d_HCurve_ResolutionD82819F3(
	void* instance,
	double R3d)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return  	result->Resolution(			
R3d);
}
DECL_EXPORT double Adaptor3d_HCurve_FirstParameter(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->FirstParameter();
}

DECL_EXPORT double Adaptor3d_HCurve_LastParameter(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->LastParameter();
}

DECL_EXPORT int Adaptor3d_HCurve_Continuity(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return (int)	result->Continuity();
}

DECL_EXPORT bool Adaptor3d_HCurve_IsClosed(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->IsClosed();
}

DECL_EXPORT bool Adaptor3d_HCurve_IsPeriodic(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->IsPeriodic();
}

DECL_EXPORT double Adaptor3d_HCurve_Period(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->Period();
}

DECL_EXPORT int Adaptor3d_HCurve_GetType(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return (int)	result->GetType();
}

DECL_EXPORT void* Adaptor3d_HCurve_Line(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	new gp_Lin(	result->Line());
}

DECL_EXPORT void* Adaptor3d_HCurve_Circle(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	new gp_Circ(	result->Circle());
}

DECL_EXPORT void* Adaptor3d_HCurve_Ellipse(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	new gp_Elips(	result->Ellipse());
}

DECL_EXPORT void* Adaptor3d_HCurve_Hyperbola(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	new gp_Hypr(	result->Hyperbola());
}

DECL_EXPORT void* Adaptor3d_HCurve_Parabola(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	new gp_Parab(	result->Parabola());
}

DECL_EXPORT int Adaptor3d_HCurve_Degree(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->Degree();
}

DECL_EXPORT bool Adaptor3d_HCurve_IsRational(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->IsRational();
}

DECL_EXPORT int Adaptor3d_HCurve_NbPoles(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->NbPoles();
}

DECL_EXPORT int Adaptor3d_HCurve_NbKnots(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	result->NbKnots();
}

DECL_EXPORT void* Adaptor3d_HCurve_Bezier(void* instance)
{
	Adaptor3d_HCurve* result = (Adaptor3d_HCurve*)(((Handle_Adaptor3d_HCurve*)instance)->Access());
	return 	new Handle_Geom_BezierCurve(	result->Bezier());
}

DECL_EXPORT void Adaptor3dHCurve_Dtor(void* instance)
{
	delete (Handle_Adaptor3d_HCurve*)instance;
}
