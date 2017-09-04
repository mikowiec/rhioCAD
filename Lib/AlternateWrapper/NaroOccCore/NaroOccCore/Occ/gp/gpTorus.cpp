#include "gpTorus.h"
#include <gp_Torus.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax3.hxx>
#include <gp_Pnt.hxx>
#include <gp_Torus.hxx>

DECL_EXPORT void* gp_Torus_Ctor()
{
	return new gp_Torus();
}
DECL_EXPORT void* gp_Torus_Ctor32BF0691(
	void* A3,
	double MajorRadius,
	double MinorRadius)
{
		const gp_Ax3 &  _A3 =*(const gp_Ax3 *)A3;
	return new gp_Torus(			
_A3,			
MajorRadius,			
MinorRadius);
}
DECL_EXPORT void gp_Torus_UReverse(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
 	result->UReverse();
}
DECL_EXPORT void gp_Torus_VReverse(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
 	result->VReverse();
}
DECL_EXPORT void gp_Torus_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Torus_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Torus_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Torus_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Torus_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Torus_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Torus_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Torus_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Torus_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Torus_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Torus_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Torus_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Torus_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Torus_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Torus_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Torus* result = (gp_Torus*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Torus_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Torus* result = (gp_Torus*)instance;
	return new gp_Torus( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT double gp_Torus_Area(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	result->Area();
}

DECL_EXPORT bool gp_Torus_Direct(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	result->Direct();
}

DECL_EXPORT void gp_Torus_SetAxis(void* instance, void* value)
{
	gp_Torus* result = (gp_Torus*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Torus_Axis(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void gp_Torus_SetLocation(void* instance, void* value)
{
	gp_Torus* result = (gp_Torus*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Torus_Location(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Torus_SetPosition(void* instance, void* value)
{
	gp_Torus* result = (gp_Torus*)instance;
		result->SetPosition(*(const gp_Ax3 *)value);
}

DECL_EXPORT void* gp_Torus_Position(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	new gp_Ax3(	result->Position());
}

DECL_EXPORT void gp_Torus_SetMajorRadius(void* instance, double value)
{
	gp_Torus* result = (gp_Torus*)instance;
		result->SetMajorRadius(value);
}

DECL_EXPORT double gp_Torus_MajorRadius(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	result->MajorRadius();
}

DECL_EXPORT void gp_Torus_SetMinorRadius(void* instance, double value)
{
	gp_Torus* result = (gp_Torus*)instance;
		result->SetMinorRadius(value);
}

DECL_EXPORT double gp_Torus_MinorRadius(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	result->MinorRadius();
}

DECL_EXPORT double gp_Torus_Volume(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	result->Volume();
}

DECL_EXPORT void* gp_Torus_XAxis(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Torus_YAxis(void* instance)
{
	gp_Torus* result = (gp_Torus*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpTorus_Dtor(void* instance)
{
	delete (gp_Torus*)instance;
}
