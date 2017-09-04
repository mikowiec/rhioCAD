#include "gpAx3.h"
#include <gp_Ax3.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax2.hxx>
#include <gp_Ax3.hxx>
#include <gp_Dir.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Ax3_Ctor()
{
	return new gp_Ax3();
}
DECL_EXPORT void* gp_Ax3_Ctor7895386A(
	void* A)
{
		const gp_Ax2 &  _A =*(const gp_Ax2 *)A;
	return new gp_Ax3(			
_A);
}
DECL_EXPORT void* gp_Ax3_CtorF36E9D55(
	void* P,
	void* N,
	void* Vx)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _N =*(const gp_Dir *)N;
		const gp_Dir &  _Vx =*(const gp_Dir *)Vx;
	return new gp_Ax3(			
_P,			
_N,			
_Vx);
}
DECL_EXPORT void* gp_Ax3_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new gp_Ax3(			
_P,			
_V);
}
DECL_EXPORT void gp_Ax3_XReverse(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->XReverse();
}
DECL_EXPORT void gp_Ax3_YReverse(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->YReverse();
}
DECL_EXPORT void gp_Ax3_ZReverse(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->ZReverse();
}
DECL_EXPORT double gp_Ax3_Angle1B3CAD05(
	void* instance,
	void* Other)
{
		const gp_Ax3 &  _Other =*(const gp_Ax3 *)Other;
	gp_Ax3* result = (gp_Ax3*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT bool gp_Ax3_IsCoplanar32BF0691(
	void* instance,
	void* Other,
	double LinearTolerance,
	double AngularTolerance)
{
		const gp_Ax3 &  _Other =*(const gp_Ax3 *)Other;
	gp_Ax3* result = (gp_Ax3*)instance;
	return  	result->IsCoplanar(			
_Other,			
LinearTolerance,			
AngularTolerance);
}
DECL_EXPORT bool gp_Ax3_IsCoplanar5FECE277(
	void* instance,
	void* A1,
	double LinearTolerance,
	double AngularTolerance)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax3* result = (gp_Ax3*)instance;
	return  	result->IsCoplanar(			
_A1,			
LinearTolerance,			
AngularTolerance);
}
DECL_EXPORT void gp_Ax3_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Ax3_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Ax3_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Ax3_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Ax3_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Ax3_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Ax3_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Ax3_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Ax3_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Ax3_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Ax3_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Ax3_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Ax3_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Ax3_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Ax3_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Ax3* result = (gp_Ax3*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Ax3_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Ax3* result = (gp_Ax3*)instance;
	return new gp_Ax3( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Ax3_SetAxis(void* instance, void* value)
{
	gp_Ax3* result = (gp_Ax3*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Ax3_Axis(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void* gp_Ax3_Ax2(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
	return 	new gp_Ax2(	result->Ax2());
}

DECL_EXPORT void gp_Ax3_SetDirection(void* instance, void* value)
{
	gp_Ax3* result = (gp_Ax3*)instance;
		result->SetDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* gp_Ax3_Direction(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void gp_Ax3_SetLocation(void* instance, void* value)
{
	gp_Ax3* result = (gp_Ax3*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Ax3_Location(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Ax3_SetXDirection(void* instance, void* value)
{
	gp_Ax3* result = (gp_Ax3*)instance;
		result->SetXDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* gp_Ax3_XDirection(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
	return 	new gp_Dir(	result->XDirection());
}

DECL_EXPORT void gp_Ax3_SetYDirection(void* instance, void* value)
{
	gp_Ax3* result = (gp_Ax3*)instance;
		result->SetYDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* gp_Ax3_YDirection(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
	return 	new gp_Dir(	result->YDirection());
}

DECL_EXPORT bool gp_Ax3_Direct(void* instance)
{
	gp_Ax3* result = (gp_Ax3*)instance;
	return 	result->Direct();
}

DECL_EXPORT void gpAx3_Dtor(void* instance)
{
	delete (gp_Ax3*)instance;
}
