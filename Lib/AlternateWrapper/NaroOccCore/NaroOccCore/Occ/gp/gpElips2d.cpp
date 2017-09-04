#include "gpElips2d.h"
#include <gp_Elips2d.hxx>

#include <gp_Ax22d.hxx>
#include <gp_Ax2d.hxx>
#include <gp_Elips2d.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT void* gp_Elips2d_Ctor()
{
	return new gp_Elips2d();
}
DECL_EXPORT void* gp_Elips2d_CtorEB7AC69(
	void* MajorAxis,
	double MajorRadius,
	double MinorRadius,
	bool Sense)
{
		const gp_Ax2d &  _MajorAxis =*(const gp_Ax2d *)MajorAxis;
	return new gp_Elips2d(			
_MajorAxis,			
MajorRadius,			
MinorRadius,			
Sense);
}
DECL_EXPORT void* gp_Elips2d_Ctor2C61CEDF(
	void* A,
	double MajorRadius,
	double MinorRadius)
{
		const gp_Ax22d &  _A =*(const gp_Ax22d *)A;
	return new gp_Elips2d(			
_A,			
MajorRadius,			
MinorRadius);
}
DECL_EXPORT void gp_Elips2d_CoefficientsBC7A5786(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D,
	double* E,
	double* F)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Coefficients(			
*A,			
*B,			
*C,			
*D,			
*E,			
*F);
}
DECL_EXPORT void gp_Elips2d_Reverse(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Elips2d_Mirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Elips2d_Mirrored6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return new gp_Elips2d( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Elips2d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Elips2d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return new gp_Elips2d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Elips2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Rotate(			
_P,			
Ang);
}
DECL_EXPORT void* gp_Elips2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return new gp_Elips2d( 	result->Rotated(			
_P,			
Ang));
}
DECL_EXPORT void gp_Elips2d_ScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Elips2d_ScaledE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return new gp_Elips2d( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Elips2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Elips2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return new gp_Elips2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Elips2d_Translate5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Elips2d_Translated5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return new gp_Elips2d( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Elips2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Elips2d* result = (gp_Elips2d*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Elips2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return new gp_Elips2d( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT double gp_Elips2d_Area(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	result->Area();
}

DECL_EXPORT void* gp_Elips2d_Directrix1(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Ax2d(	result->Directrix1());
}

DECL_EXPORT void* gp_Elips2d_Directrix2(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Ax2d(	result->Directrix2());
}

DECL_EXPORT double gp_Elips2d_Eccentricity(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	result->Eccentricity();
}

DECL_EXPORT double gp_Elips2d_Focal(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	result->Focal();
}

DECL_EXPORT void* gp_Elips2d_Focus1(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Pnt2d(	result->Focus1());
}

DECL_EXPORT void* gp_Elips2d_Focus2(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Pnt2d(	result->Focus2());
}

DECL_EXPORT void gp_Elips2d_SetLocation(void* instance, void* value)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
		result->SetLocation(*(const gp_Pnt2d *)value);
}

DECL_EXPORT void* gp_Elips2d_Location(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Pnt2d(	result->Location());
}

DECL_EXPORT void gp_Elips2d_SetMajorRadius(void* instance, double value)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
		result->SetMajorRadius(value);
}

DECL_EXPORT double gp_Elips2d_MajorRadius(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	result->MajorRadius();
}

DECL_EXPORT void gp_Elips2d_SetMinorRadius(void* instance, double value)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
		result->SetMinorRadius(value);
}

DECL_EXPORT double gp_Elips2d_MinorRadius(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	result->MinorRadius();
}

DECL_EXPORT double gp_Elips2d_Parameter(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	result->Parameter();
}

DECL_EXPORT void gp_Elips2d_SetAxis(void* instance, void* value)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
		result->SetAxis(*(const gp_Ax22d *)value);
}

DECL_EXPORT void* gp_Elips2d_Axis(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Ax22d(	result->Axis());
}

DECL_EXPORT void gp_Elips2d_SetXAxis(void* instance, void* value)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
		result->SetXAxis(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Elips2d_XAxis(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Ax2d(	result->XAxis());
}

DECL_EXPORT void gp_Elips2d_SetYAxis(void* instance, void* value)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
		result->SetYAxis(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Elips2d_YAxis(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Ax2d(	result->YAxis());
}

DECL_EXPORT void* gp_Elips2d_Reversed(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	new gp_Elips2d(	result->Reversed());
}

DECL_EXPORT bool gp_Elips2d_IsDirect(void* instance)
{
	gp_Elips2d* result = (gp_Elips2d*)instance;
	return 	result->IsDirect();
}

DECL_EXPORT void gpElips2d_Dtor(void* instance)
{
	delete (gp_Elips2d*)instance;
}
