#include "gpCirc2d.h"
#include <gp_Circ2d.hxx>

#include <gp_Ax22d.hxx>
#include <gp_Ax2d.hxx>
#include <gp_Circ2d.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT void* gp_Circ2d_Ctor()
{
	return new gp_Circ2d();
}
DECL_EXPORT void* gp_Circ2d_Ctor462C7341(
	void* XAxis,
	double Radius,
	bool Sense)
{
		const gp_Ax2d &  _XAxis =*(const gp_Ax2d *)XAxis;
	return new gp_Circ2d(			
_XAxis,			
Radius,			
Sense);
}
DECL_EXPORT void* gp_Circ2d_Ctor443D47DE(
	void* Axis,
	double Radius)
{
		const gp_Ax22d &  _Axis =*(const gp_Ax22d *)Axis;
	return new gp_Circ2d(			
_Axis,			
Radius);
}
DECL_EXPORT void gp_Circ2d_CoefficientsBC7A5786(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D,
	double* E,
	double* F)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Coefficients(			
*A,			
*B,			
*C,			
*D,			
*E,			
*F);
}
DECL_EXPORT bool gp_Circ2d_ContainsE3062737(
	void* instance,
	void* P,
	double LinearTolerance)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return  	result->Contains(			
_P,			
LinearTolerance);
}
DECL_EXPORT double gp_Circ2d_Distance6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return  	result->Distance(			
_P);
}
DECL_EXPORT double gp_Circ2d_SquareDistance6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return  	result->SquareDistance(			
_P);
}
DECL_EXPORT void gp_Circ2d_Reverse(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Circ2d_Mirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Circ2d_Mirrored6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return new gp_Circ2d( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Circ2d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Circ2d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return new gp_Circ2d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Circ2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Rotate(			
_P,			
Ang);
}
DECL_EXPORT void* gp_Circ2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return new gp_Circ2d( 	result->Rotated(			
_P,			
Ang));
}
DECL_EXPORT void gp_Circ2d_ScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Circ2d_ScaledE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return new gp_Circ2d( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Circ2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Circ2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return new gp_Circ2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Circ2d_Translate5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Circ2d_Translated5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return new gp_Circ2d( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Circ2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Circ2d* result = (gp_Circ2d*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Circ2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return new gp_Circ2d( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT double gp_Circ2d_Area(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	result->Area();
}

DECL_EXPORT double gp_Circ2d_Length(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	result->Length();
}

DECL_EXPORT void gp_Circ2d_SetLocation(void* instance, void* value)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
		result->SetLocation(*(const gp_Pnt2d *)value);
}

DECL_EXPORT void* gp_Circ2d_Location(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	new gp_Pnt2d(	result->Location());
}

DECL_EXPORT void gp_Circ2d_SetRadius(void* instance, double value)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
		result->SetRadius(value);
}

DECL_EXPORT double gp_Circ2d_Radius(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	result->Radius();
}

DECL_EXPORT void gp_Circ2d_SetAxis(void* instance, void* value)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
		result->SetAxis(*(const gp_Ax22d *)value);
}

DECL_EXPORT void* gp_Circ2d_Axis(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	new gp_Ax22d(	result->Axis());
}

DECL_EXPORT void* gp_Circ2d_Position(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	new gp_Ax22d(	result->Position());
}

DECL_EXPORT void gp_Circ2d_SetXAxis(void* instance, void* value)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
		result->SetXAxis(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Circ2d_XAxis(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	new gp_Ax2d(	result->XAxis());
}

DECL_EXPORT void gp_Circ2d_SetYAxis(void* instance, void* value)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
		result->SetYAxis(*(const gp_Ax2d *)value);
}

DECL_EXPORT void* gp_Circ2d_YAxis(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	new gp_Ax2d(	result->YAxis());
}

DECL_EXPORT void* gp_Circ2d_Reversed(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	new gp_Circ2d(	result->Reversed());
}

DECL_EXPORT bool gp_Circ2d_IsDirect(void* instance)
{
	gp_Circ2d* result = (gp_Circ2d*)instance;
	return 	result->IsDirect();
}

DECL_EXPORT void gpCirc2d_Dtor(void* instance)
{
	delete (gp_Circ2d*)instance;
}
