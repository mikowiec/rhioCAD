#include "Adaptor2dHCurve2d.h"
#include <Adaptor2d_HCurve2d.hxx>

#include <Adaptor2d_HCurve2d.hxx>
#include <gp_Circ2d.hxx>
#include <gp_Elips2d.hxx>
#include <gp_Hypr2d.hxx>
#include <gp_Lin2d.hxx>
#include <gp_Parab2d.hxx>
#include <gp_Pnt2d.hxx>
#include <gp_Vec2d.hxx>

DECL_EXPORT int Adaptor2d_HCurve2d_NbIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return  	result->NbIntervals(			
_S);
}
DECL_EXPORT void* Adaptor2d_HCurve2d_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return new Handle_Adaptor2d_HCurve2d( 	result->Trim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* Adaptor2d_HCurve2d_ValueD82819F3(
	void* instance,
	double U)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return new gp_Pnt2d( 	result->Value(			
U));
}
DECL_EXPORT void Adaptor2d_HCurve2d_D0F34E6A40(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt2d &  _P =*(gp_Pnt2d *)P;
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void Adaptor2d_HCurve2d_D1EF1CEF4A(
	void* instance,
	double U,
	void* P,
	void* V)
{
		gp_Pnt2d &  _P =*(gp_Pnt2d *)P;
		gp_Vec2d &  _V =*(gp_Vec2d *)V;
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
 	result->D1(			
U,			
_P,			
_V);
}
DECL_EXPORT void Adaptor2d_HCurve2d_D2DCE527F4(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt2d &  _P =*(gp_Pnt2d *)P;
		gp_Vec2d &  _V1 =*(gp_Vec2d *)V1;
		gp_Vec2d &  _V2 =*(gp_Vec2d *)V2;
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void Adaptor2d_HCurve2d_D3A3CC6934(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3)
{
		gp_Pnt2d &  _P =*(gp_Pnt2d *)P;
		gp_Vec2d &  _V1 =*(gp_Vec2d *)V1;
		gp_Vec2d &  _V2 =*(gp_Vec2d *)V2;
		gp_Vec2d &  _V3 =*(gp_Vec2d *)V3;
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* Adaptor2d_HCurve2d_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return new gp_Vec2d( 	result->DN(			
U,			
N));
}
DECL_EXPORT double Adaptor2d_HCurve2d_ResolutionD82819F3(
	void* instance,
	double R3d)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return  	result->Resolution(			
R3d);
}
DECL_EXPORT double Adaptor2d_HCurve2d_FirstParameter(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->FirstParameter();
}

DECL_EXPORT double Adaptor2d_HCurve2d_LastParameter(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->LastParameter();
}

DECL_EXPORT int Adaptor2d_HCurve2d_Continuity(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return (int)	result->Continuity();
}

DECL_EXPORT bool Adaptor2d_HCurve2d_IsClosed(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->IsClosed();
}

DECL_EXPORT bool Adaptor2d_HCurve2d_IsPeriodic(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->IsPeriodic();
}

DECL_EXPORT double Adaptor2d_HCurve2d_Period(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->Period();
}

DECL_EXPORT int Adaptor2d_HCurve2d_GetType(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return (int)	result->GetType();
}

DECL_EXPORT void* Adaptor2d_HCurve2d_Line(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	new gp_Lin2d(	result->Line());
}

DECL_EXPORT void* Adaptor2d_HCurve2d_Circle(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	new gp_Circ2d(	result->Circle());
}

DECL_EXPORT void* Adaptor2d_HCurve2d_Ellipse(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	new gp_Elips2d(	result->Ellipse());
}

DECL_EXPORT void* Adaptor2d_HCurve2d_Hyperbola(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	new gp_Hypr2d(	result->Hyperbola());
}

DECL_EXPORT void* Adaptor2d_HCurve2d_Parabola(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	new gp_Parab2d(	result->Parabola());
}

DECL_EXPORT int Adaptor2d_HCurve2d_Degree(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->Degree();
}

DECL_EXPORT bool Adaptor2d_HCurve2d_IsRational(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->IsRational();
}

DECL_EXPORT int Adaptor2d_HCurve2d_NbPoles(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->NbPoles();
}

DECL_EXPORT int Adaptor2d_HCurve2d_NbKnots(void* instance)
{
	Adaptor2d_HCurve2d* result = (Adaptor2d_HCurve2d*)(((Handle_Adaptor2d_HCurve2d*)instance)->Access());
	return 	result->NbKnots();
}

DECL_EXPORT void Adaptor2dHCurve2d_Dtor(void* instance)
{
	delete (Handle_Adaptor2d_HCurve2d*)instance;
}
