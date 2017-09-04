#include "gpCone.h"
#include <gp_Cone.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax3.hxx>
#include <gp_Cone.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Cone_Ctor()
{
	return new gp_Cone();
}
DECL_EXPORT void* gp_Cone_Ctor32BF0691(
	void* A3,
	double Ang,
	double Radius)
{
		const gp_Ax3 &  _A3 =*(const gp_Ax3 *)A3;
	return new gp_Cone(			
_A3,			
Ang,			
Radius);
}
DECL_EXPORT void gp_Cone_UReverse(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
 	result->UReverse();
}
DECL_EXPORT void gp_Cone_VReverse(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
 	result->VReverse();
}
DECL_EXPORT void gp_Cone_CoefficientsCFCEAB36(
	void* instance,
	double* A1,
	double* A2,
	double* A3,
	double* B1,
	double* B2,
	double* B3,
	double* C1,
	double* C2,
	double* C3,
	double* D)
{
	gp_Cone* result = (gp_Cone*)instance;
 	result->Coefficients(			
*A1,			
*A2,			
*A3,			
*B1,			
*B2,			
*B3,			
*C1,			
*C2,			
*C3,			
*D);
}
DECL_EXPORT void gp_Cone_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Cone_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Cone_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Cone_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Cone_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Cone_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Cone_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Cone_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Cone_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Cone_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Cone_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Cone_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Cone_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Cone_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Cone_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Cone* result = (gp_Cone*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Cone_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Cone* result = (gp_Cone*)instance;
	return new gp_Cone( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Cone_SetRadius(void* instance, double value)
{
	gp_Cone* result = (gp_Cone*)instance;
		result->SetRadius(value);
}

DECL_EXPORT void* gp_Cone_Apex(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	new gp_Pnt(	result->Apex());
}

DECL_EXPORT bool gp_Cone_Direct(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	result->Direct();
}

DECL_EXPORT void gp_Cone_SetAxis(void* instance, void* value)
{
	gp_Cone* result = (gp_Cone*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Cone_Axis(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void gp_Cone_SetLocation(void* instance, void* value)
{
	gp_Cone* result = (gp_Cone*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Cone_Location(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Cone_SetPosition(void* instance, void* value)
{
	gp_Cone* result = (gp_Cone*)instance;
		result->SetPosition(*(const gp_Ax3 *)value);
}

DECL_EXPORT void* gp_Cone_Position(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	new gp_Ax3(	result->Position());
}

DECL_EXPORT double gp_Cone_RefRadius(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	result->RefRadius();
}

DECL_EXPORT void gp_Cone_SetSemiAngle(void* instance, double value)
{
	gp_Cone* result = (gp_Cone*)instance;
		result->SetSemiAngle(value);
}

DECL_EXPORT double gp_Cone_SemiAngle(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	result->SemiAngle();
}

DECL_EXPORT void* gp_Cone_XAxis(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Cone_YAxis(void* instance)
{
	gp_Cone* result = (gp_Cone*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpCone_Dtor(void* instance)
{
	delete (gp_Cone*)instance;
}
