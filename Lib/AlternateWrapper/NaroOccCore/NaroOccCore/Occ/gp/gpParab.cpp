#include "gpParab.h"
#include <gp_Parab.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax2.hxx>
#include <gp_Parab.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Parab_Ctor()
{
	return new gp_Parab();
}
DECL_EXPORT void* gp_Parab_Ctor673FA07D(
	void* A2,
	double Focal)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new gp_Parab(			
_A2,			
Focal);
}
DECL_EXPORT void* gp_Parab_Ctor3B6CEA26(
	void* D,
	void* F)
{
		const gp_Ax1 &  _D =*(const gp_Ax1 *)D;
		const gp_Pnt &  _F =*(const gp_Pnt *)F;
	return new gp_Parab(			
_D,			
_F);
}
DECL_EXPORT void gp_Parab_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Parab_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Parab_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Parab_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Parab_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Parab_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Parab_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Parab_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Parab_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Parab_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Parab_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Parab_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Parab_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Parab_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Parab_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Parab* result = (gp_Parab*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Parab_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Parab* result = (gp_Parab*)instance;
	return new gp_Parab( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Parab_SetAxis(void* instance, void* value)
{
	gp_Parab* result = (gp_Parab*)instance;
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Parab_Axis(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void* gp_Parab_Directrix(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	new gp_Ax1(	result->Directrix());
}

DECL_EXPORT void gp_Parab_SetFocal(void* instance, double value)
{
	gp_Parab* result = (gp_Parab*)instance;
		result->SetFocal(value);
}

DECL_EXPORT double gp_Parab_Focal(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	result->Focal();
}

DECL_EXPORT void* gp_Parab_Focus(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	new gp_Pnt(	result->Focus());
}

DECL_EXPORT void gp_Parab_SetLocation(void* instance, void* value)
{
	gp_Parab* result = (gp_Parab*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Parab_Location(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT double gp_Parab_Parameter(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	result->Parameter();
}

DECL_EXPORT void gp_Parab_SetPosition(void* instance, void* value)
{
	gp_Parab* result = (gp_Parab*)instance;
		result->SetPosition(*(const gp_Ax2 *)value);
}

DECL_EXPORT void* gp_Parab_Position(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	new gp_Ax2(	result->Position());
}

DECL_EXPORT void* gp_Parab_XAxis(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* gp_Parab_YAxis(void* instance)
{
	gp_Parab* result = (gp_Parab*)instance;
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT void gpParab_Dtor(void* instance)
{
	delete (gp_Parab*)instance;
}
