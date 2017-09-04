#include "gpSphere.h"
#include <gp_Sphere.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax3.hxx>
#include <gp_Pnt.hxx>
#include <gp_Sphere.hxx>

DECL_EXPORT void* gp_Sphere_Ctor()
{
	return new gp_Sphere();
}
DECL_EXPORT void* gp_Sphere_Ctor5C6D1CB8(
	void* A3,
	double Radius)
{
		const gp_Ax3 &  _A3 =*(const gp_Ax3 *)A3;
	return new gp_Sphere(			
_A3,			
Radius);
}
DECL_EXPORT void gp_Sphere_CoefficientsCFCEAB36(
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
	gp_Sphere* result = (gp_Sphere*)instance;
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
DECL_EXPORT void gp_Sphere_UReverse(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->UReverse();
}
DECL_EXPORT void gp_Sphere_VReverse(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->VReverse();
}
DECL_EXPORT void gp_Sphere_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Sphere_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Sphere_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Sphere_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Sphere_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Sphere_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Sphere_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Sphere_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Sphere_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Sphere_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Sphere_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Sphere_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Sphere_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Sphere_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Sphere_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Sphere* result = (gp_Sphere*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Sphere_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Sphere* result = (gp_Sphere*)instance;
	return new gp_Sphere( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT double gp_Sphere_Area(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	result->Area();
}

DECL_EXPORT bool gp_Sphere_Direct(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	result->Direct();
}

DECL_EXPORT void gp_Sphere_SetLocation(void* instance, void* value)
{
	gp_Sphere* result = (gp_Sphere*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Sphere_Location(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Sphere_SetPosition(void* instance, void* value)
{
	gp_Sphere* result = (gp_Sphere*)instance;
		result->SetPosition(*(const gp_Ax3 *)value);
}

DECL_EXPORT void* gp_Sphere_Position(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	new gp_Ax3(	result->Position());
}

DECL_EXPORT void gp_Sphere_SetRadius(void* instance, double value)
{
	gp_Sphere* result = (gp_Sphere*)instance;
		result->SetRadius(value);
}

DECL_EXPORT double gp_Sphere_Radius(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	result->Radius();
}

DECL_EXPORT double gp_Sphere_Volume(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	result->Volume();
}

DECL_EXPORT void* gp_Sphere_XAxis(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Sphere_YAxis(void* instance)
{
	gp_Sphere* result = (gp_Sphere*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpSphere_Dtor(void* instance)
{
	delete (gp_Sphere*)instance;
}
