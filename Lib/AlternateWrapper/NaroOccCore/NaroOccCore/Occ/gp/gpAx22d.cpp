#include "gpAx22d.h"
#include <gp_Ax22d.hxx>

#include <gp_Ax22d.hxx>
#include <gp_Ax2d.hxx>
#include <gp_Dir2d.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT void* gp_Ax22d_Ctor()
{
	return new gp_Ax22d();
}
DECL_EXPORT void* gp_Ax22d_CtorE3FB4CCB(
	void* P,
	void* Vx,
	void* Vy)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
		const gp_Dir2d &  _Vx =*(const gp_Dir2d *)Vx;
		const gp_Dir2d &  _Vy =*(const gp_Dir2d *)Vy;
	return new gp_Ax22d(			
_P,			
_Vx,			
_Vy);
}
DECL_EXPORT void* gp_Ax22d_CtorE18CA5E9(
	void* P,
	void* V,
	bool Sense)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
		const gp_Dir2d &  _V =*(const gp_Dir2d *)V;
	return new gp_Ax22d(			
_P,			
_V,			
Sense);
}
DECL_EXPORT void* gp_Ax22d_Ctor2C652E28(
	void* A,
	bool Sense)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	return new gp_Ax22d(			
_A,			
Sense);
}
DECL_EXPORT void gp_Ax22d_Mirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax22d* result = (gp_Ax22d*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Ax22d_Mirrored6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return new gp_Ax22d( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Ax22d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Ax22d* result = (gp_Ax22d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Ax22d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return new gp_Ax22d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Ax22d_RotateE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax22d* result = (gp_Ax22d*)instance;
 	result->Rotate(			
_P,			
Ang);
}
DECL_EXPORT void* gp_Ax22d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return new gp_Ax22d( 	result->Rotated(			
_P,			
Ang));
}
DECL_EXPORT void gp_Ax22d_ScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax22d* result = (gp_Ax22d*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Ax22d_ScaledE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return new gp_Ax22d( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Ax22d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Ax22d* result = (gp_Ax22d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Ax22d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return new gp_Ax22d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Ax22d_Translate5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Ax22d* result = (gp_Ax22d*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Ax22d_Translated5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return new gp_Ax22d( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Ax22d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Ax22d* result = (gp_Ax22d*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Ax22d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return new gp_Ax22d( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Ax22d_SetAxis(void* instance, void* value)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
		result->SetAxis(*(const gp_Ax22d *)value);
}

DECL_EXPORT void gp_Ax22d_SetXAxis(void* instance, void* value)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
		result->SetXAxis(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Ax22d_XAxis(void* instance)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return 	new gp_Ax2d(	result->XAxis());
}

DECL_EXPORT void gp_Ax22d_SetYAxis(void* instance, void* value)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
		result->SetYAxis(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Ax22d_YAxis(void* instance)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return 	new gp_Ax2d(	result->YAxis());
}

DECL_EXPORT void gp_Ax22d_SetLocation(void* instance, void* value)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
		result->SetLocation(*(const gp_Pnt2d *)value);
}

DECL_EXPORT void* gp_Ax22d_Location(void* instance)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return 	new gp_Pnt2d(	result->Location());
}

DECL_EXPORT void gp_Ax22d_SetXDirection(void* instance, void* value)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
		result->SetXDirection(*(const gp_Dir2d *)value);
}

DECL_EXPORT void* gp_Ax22d_XDirection(void* instance)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return 	new gp_Dir2d(	result->XDirection());
}

DECL_EXPORT void gp_Ax22d_SetYDirection(void* instance, void* value)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
		result->SetYDirection(*(const gp_Dir2d *)value);
}

DECL_EXPORT void* gp_Ax22d_YDirection(void* instance)
{
	gp_Ax22d* result = (gp_Ax22d*)instance;
	return 	new gp_Dir2d(	result->YDirection());
}

DECL_EXPORT void gpAx22d_Dtor(void* instance)
{
	delete (gp_Ax22d*)instance;
}
