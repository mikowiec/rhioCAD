#include "gpCirc.h"
#include <gp_Circ.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax2.hxx>
#include <gp_Circ.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Circ_Ctor()
{
	return new gp_Circ();
}
DECL_EXPORT void* gp_Circ_Ctor673FA07D(
	void* A2,
	double Radius)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new gp_Circ(			
_A2,			
Radius);
}
DECL_EXPORT double gp_Circ_Distance9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Circ* result = (gp_Circ*)instance;
	return  	result->Distance(			
_P);
}
DECL_EXPORT double gp_Circ_SquareDistance9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Circ* result = (gp_Circ*)instance;
	return  	result->SquareDistance(			
_P);
}
DECL_EXPORT bool gp_Circ_ContainsF0D1E3E6(
	void* instance,
	void* P,
	double LinearTolerance)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Circ* result = (gp_Circ*)instance;
	return  	result->Contains(			
_P,			
LinearTolerance);
}
DECL_EXPORT void gp_Circ_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Circ_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Circ_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Circ_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Circ_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Circ_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Circ_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Circ_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Circ_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Circ_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Circ_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Circ_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Circ_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Circ_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Circ_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Circ* result = (gp_Circ*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Circ_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Circ* result = (gp_Circ*)instance;
	return new gp_Circ( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT double gp_Circ_Area(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	result->Area();
}

DECL_EXPORT void gp_Circ_SetAxis(void* instance, void* value)
{
	gp_Circ* result = (gp_Circ*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Circ_Axis(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT double gp_Circ_Length(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	result->Length();
}

DECL_EXPORT void gp_Circ_SetLocation(void* instance, void* value)
{
	gp_Circ* result = (gp_Circ*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Circ_Location(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Circ_SetPosition(void* instance, void* value)
{
	gp_Circ* result = (gp_Circ*)instance;
		result->SetPosition(*(const gp_Ax2 *)value);
}

DECL_EXPORT void* gp_Circ_Position(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	new gp_Ax2(	result->Position());
}

DECL_EXPORT void gp_Circ_SetRadius(void* instance, double value)
{
	gp_Circ* result = (gp_Circ*)instance;
		result->SetRadius(value);
}

DECL_EXPORT double gp_Circ_Radius(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	result->Radius();
}

DECL_EXPORT void* gp_Circ_XAxis(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Circ_YAxis(void* instance)
{
	gp_Circ* result = (gp_Circ*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpCirc_Dtor(void* instance)
{
	delete (gp_Circ*)instance;
}
