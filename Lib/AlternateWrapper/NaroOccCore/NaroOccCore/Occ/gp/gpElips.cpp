#include "gpElips.h"
#include <gp_Elips.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax2.hxx>
#include <gp_Elips.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Elips_Ctor()
{
	return new gp_Elips();
}
DECL_EXPORT void* gp_Elips_CtorB1A3BD2A(
	void* A2,
	double MajorRadius,
	double MinorRadius)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new gp_Elips(			
_A2,			
MajorRadius,			
MinorRadius);
}
DECL_EXPORT void gp_Elips_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Elips_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Elips_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Elips_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Elips_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Elips_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Elips_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Elips_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Elips_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Elips_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Elips_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Elips_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Elips_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Elips_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Elips_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Elips* result = (gp_Elips*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Elips_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Elips* result = (gp_Elips*)instance;
	return new gp_Elips( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT double gp_Elips_Area(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	result->Area();
}

DECL_EXPORT void gp_Elips_SetAxis(void* instance, void* value)
{
	gp_Elips* result = (gp_Elips*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Elips_Axis(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void* gp_Elips_Directrix1(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Ax1(	result->Directrix1());
}

DECL_EXPORT void* gp_Elips_Directrix2(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Ax1(	result->Directrix2());
}

DECL_EXPORT double gp_Elips_Eccentricity(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	result->Eccentricity();
}

DECL_EXPORT double gp_Elips_Focal(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	result->Focal();
}

DECL_EXPORT void* gp_Elips_Focus1(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Pnt(	result->Focus1());
}

DECL_EXPORT void* gp_Elips_Focus2(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Pnt(	result->Focus2());
}

DECL_EXPORT void gp_Elips_SetLocation(void* instance, void* value)
{
	gp_Elips* result = (gp_Elips*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Elips_Location(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Elips_SetMajorRadius(void* instance, double value)
{
	gp_Elips* result = (gp_Elips*)instance;
		result->SetMajorRadius(value);
}

DECL_EXPORT double gp_Elips_MajorRadius(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	result->MajorRadius();
}

DECL_EXPORT void gp_Elips_SetMinorRadius(void* instance, double value)
{
	gp_Elips* result = (gp_Elips*)instance;
		result->SetMinorRadius(value);
}

DECL_EXPORT double gp_Elips_MinorRadius(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	result->MinorRadius();
}

DECL_EXPORT double gp_Elips_Parameter(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	result->Parameter();
}

DECL_EXPORT void gp_Elips_SetPosition(void* instance, void* value)
{
	gp_Elips* result = (gp_Elips*)instance;
		result->SetPosition(*(const gp_Ax2 *)value);
}

DECL_EXPORT void* gp_Elips_Position(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Ax2(	result->Position());
}

DECL_EXPORT void* gp_Elips_XAxis(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Elips_YAxis(void* instance)
{
	gp_Elips* result = (gp_Elips*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpElips_Dtor(void* instance)
{
	delete (gp_Elips*)instance;
}
