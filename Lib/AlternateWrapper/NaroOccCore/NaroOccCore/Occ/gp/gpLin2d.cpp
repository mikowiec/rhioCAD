#include "gpLin2d.h"
#include <gp_Lin2d.hxx>

#include <gp_Ax2d.hxx>
#include <gp_Dir2d.hxx>
#include <gp_Lin2d.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT void* gp_Lin2d_Ctor()
{
	return new gp_Lin2d();
}
DECL_EXPORT void* gp_Lin2d_Ctor90E1386A(
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	return new gp_Lin2d(			
_A);
}
DECL_EXPORT void* gp_Lin2d_Ctor2E9C6BD1(
	void* P,
	void* V)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
		const gp_Dir2d &  _V =*(const gp_Dir2d *)V;
	return new gp_Lin2d(			
_P,			
_V);
}
DECL_EXPORT void* gp_Lin2d_Ctor9282A951(
	double A,
	double B,
	double C)
{
	return new gp_Lin2d(			
A,			
B,			
C);
}
DECL_EXPORT void gp_Lin2d_Reverse(void* instance)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Lin2d_Coefficients9282A951(
	void* instance,
	double* A,
	double* B,
	double* C)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Coefficients(			
*A,			
*B,			
*C);
}
DECL_EXPORT double gp_Lin2d_Angle5D0C667A(
	void* instance,
	void* Other)
{
		const gp_Lin2d &  _Other =*(const gp_Lin2d *)Other;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT bool gp_Lin2d_ContainsE3062737(
	void* instance,
	void* P,
	double LinearTolerance)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return  	result->Contains(			
_P,			
LinearTolerance);
}
DECL_EXPORT double gp_Lin2d_Distance6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return  	result->Distance(			
_P);
}
DECL_EXPORT double gp_Lin2d_Distance5D0C667A(
	void* instance,
	void* Other)
{
		const gp_Lin2d &  _Other =*(const gp_Lin2d *)Other;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return  	result->Distance(			
_Other);
}
DECL_EXPORT double gp_Lin2d_SquareDistance6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return  	result->SquareDistance(			
_P);
}
DECL_EXPORT double gp_Lin2d_SquareDistance5D0C667A(
	void* instance,
	void* Other)
{
		const gp_Lin2d &  _Other =*(const gp_Lin2d *)Other;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return  	result->SquareDistance(			
_Other);
}
DECL_EXPORT void* gp_Lin2d_Normal6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Normal(			
_P));
}
DECL_EXPORT void gp_Lin2d_Mirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Lin2d_Mirrored6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Lin2d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Lin2d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Lin2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Rotate(			
_P,			
Ang);
}
DECL_EXPORT void* gp_Lin2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Rotated(			
_P,			
Ang));
}
DECL_EXPORT void gp_Lin2d_ScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Lin2d_ScaledE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Lin2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Lin2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Lin2d_Translate5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Lin2d_Translated5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Lin2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Lin2d* result = (gp_Lin2d*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Lin2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return new gp_Lin2d( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void* gp_Lin2d_Reversed(void* instance)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return 	new gp_Lin2d(	result->Reversed());
}

DECL_EXPORT void gp_Lin2d_SetDirection(void* instance, void* value)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
		result->SetDirection(*(const gp_Dir2d *)value);
}

DECL_EXPORT void* gp_Lin2d_Direction(void* instance)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return 	new gp_Dir2d(	result->Direction());
}

DECL_EXPORT void gp_Lin2d_SetLocation(void* instance, void* value)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
		result->SetLocation(*(const gp_Pnt2d *)value);
}

DECL_EXPORT void* gp_Lin2d_Location(void* instance)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return 	new gp_Pnt2d(	result->Location());
}

DECL_EXPORT void gp_Lin2d_SetPosition(void* instance, void* value)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
		result->SetPosition(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Lin2d_Position(void* instance)
{
	gp_Lin2d* result = (gp_Lin2d*)instance;
	return 	new gp_Ax2d(	result->Position());
}

DECL_EXPORT void gpLin2d_Dtor(void* instance)
{
	delete (gp_Lin2d*)instance;
}
