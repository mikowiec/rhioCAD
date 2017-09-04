#include "gpCylinder.h"
#include <gp_Cylinder.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax3.hxx>
#include <gp_Cylinder.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Cylinder_Ctor()
{
	return new gp_Cylinder();
}
DECL_EXPORT void* gp_Cylinder_Ctor5C6D1CB8(
	void* A3,
	double Radius)
{
		const gp_Ax3 &  _A3 =*(const gp_Ax3 *)A3;
	return new gp_Cylinder(			
_A3,			
Radius);
}
DECL_EXPORT void gp_Cylinder_UReverse(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->UReverse();
}
DECL_EXPORT void gp_Cylinder_VReverse(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->VReverse();
}
DECL_EXPORT void gp_Cylinder_CoefficientsCFCEAB36(
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
	gp_Cylinder* result = (gp_Cylinder*)instance;
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
DECL_EXPORT void gp_Cylinder_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Cylinder_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Cylinder_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Cylinder_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Cylinder_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Cylinder_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Cylinder_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Cylinder_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Cylinder_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Cylinder_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Cylinder_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Cylinder_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Cylinder_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Cylinder_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Cylinder_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Cylinder* result = (gp_Cylinder*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Cylinder_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return new gp_Cylinder( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT bool gp_Cylinder_Direct(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return 	result->Direct();
}

DECL_EXPORT void gp_Cylinder_SetAxis(void* instance, void* value)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Cylinder_Axis(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void gp_Cylinder_SetLocation(void* instance, void* value)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Cylinder_Location(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Cylinder_SetPosition(void* instance, void* value)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
		result->SetPosition(*(const gp_Ax3 *)value);
}

DECL_EXPORT void* gp_Cylinder_Position(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return 	new gp_Ax3(	result->Position());
}

DECL_EXPORT void gp_Cylinder_SetRadius(void* instance, double value)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
		result->SetRadius(value);
}

DECL_EXPORT double gp_Cylinder_Radius(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return 	result->Radius();
}

DECL_EXPORT void* gp_Cylinder_XAxis(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Cylinder_YAxis(void* instance)
{
	gp_Cylinder* result = (gp_Cylinder*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpCylinder_Dtor(void* instance)
{
	delete (gp_Cylinder*)instance;
}
