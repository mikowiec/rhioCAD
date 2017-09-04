#include "gpParab2d.h"
#include <gp_Parab2d.hxx>

#include <gp_Ax22d.hxx>
#include <gp_Ax2d.hxx>
#include <gp_Parab2d.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT void* gp_Parab2d_Ctor()
{
	return new gp_Parab2d();
}
DECL_EXPORT void* gp_Parab2d_Ctor462C7341(
	void* MirrorAxis,
	double Focal,
	bool Sense)
{
		const gp_Ax2d &  _MirrorAxis =*(const gp_Ax2d *)MirrorAxis;
	return new gp_Parab2d(			
_MirrorAxis,			
Focal,			
Sense);
}
DECL_EXPORT void* gp_Parab2d_Ctor443D47DE(
	void* A,
	double Focal)
{
		const gp_Ax22d &  _A =*(const gp_Ax22d *)A;
	return new gp_Parab2d(			
_A,			
Focal);
}
DECL_EXPORT void* gp_Parab2d_CtorF2803558(
	void* D,
	void* F,
	bool Sense)
{
		const gp_Ax2d &  _D =*(const gp_Ax2d *)D;
		const gp_Pnt2d &  _F =*(const gp_Pnt2d *)F;
	return new gp_Parab2d(			
_D,			
_F,			
Sense);
}
DECL_EXPORT void* gp_Parab2d_Ctor3DE242E8(
	void* D,
	void* F)
{
		const gp_Ax22d &  _D =*(const gp_Ax22d *)D;
		const gp_Pnt2d &  _F =*(const gp_Pnt2d *)F;
	return new gp_Parab2d(			
_D,			
_F);
}
DECL_EXPORT void gp_Parab2d_CoefficientsBC7A5786(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D,
	double* E,
	double* F)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Coefficients(			
*A,			
*B,			
*C,			
*D,			
*E,			
*F);
}
DECL_EXPORT void gp_Parab2d_Reverse(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Parab2d_Mirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Parab2d_Mirrored6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return new gp_Parab2d( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Parab2d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Parab2d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return new gp_Parab2d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Parab2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Rotate(			
_P,			
Ang);
}
DECL_EXPORT void* gp_Parab2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return new gp_Parab2d( 	result->Rotated(			
_P,			
Ang));
}
DECL_EXPORT void gp_Parab2d_ScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Parab2d_ScaledE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return new gp_Parab2d( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Parab2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Parab2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return new gp_Parab2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Parab2d_Translate5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Parab2d_Translated5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return new gp_Parab2d( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Parab2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Parab2d* result = (gp_Parab2d*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Parab2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return new gp_Parab2d( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void* gp_Parab2d_Directrix(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	new gp_Ax2d(	result->Directrix());
}

DECL_EXPORT void gp_Parab2d_SetFocal(void* instance, double value)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
		result->SetFocal(value);
}

DECL_EXPORT double gp_Parab2d_Focal(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	result->Focal();
}

DECL_EXPORT void* gp_Parab2d_Focus(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	new gp_Pnt2d(	result->Focus());
}

DECL_EXPORT void gp_Parab2d_SetLocation(void* instance, void* value)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
		result->SetLocation(*(const gp_Pnt2d *)value);
}

DECL_EXPORT void* gp_Parab2d_Location(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	new gp_Pnt2d(	result->Location());
}

DECL_EXPORT void gp_Parab2d_SetMirrorAxis(void* instance, void* value)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
		result->SetMirrorAxis(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Parab2d_MirrorAxis(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	new gp_Ax2d(	result->MirrorAxis());
}

DECL_EXPORT void gp_Parab2d_SetAxis(void* instance, void* value)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
		result->SetAxis(*(const gp_Ax22d *)value);
}

DECL_EXPORT void* gp_Parab2d_Axis(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	new gp_Ax22d(	result->Axis());
}

DECL_EXPORT double gp_Parab2d_Parameter(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	result->Parameter();
}

DECL_EXPORT void* gp_Parab2d_Reversed(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	new gp_Parab2d(	result->Reversed());
}

DECL_EXPORT bool gp_Parab2d_IsDirect(void* instance)
{
	gp_Parab2d* result = (gp_Parab2d*)instance;
	return 	result->IsDirect();
}

DECL_EXPORT void gpParab2d_Dtor(void* instance)
{
	delete (gp_Parab2d*)instance;
}
