#include "gpLin.h"
#include <gp_Lin.hxx>

#include <gp_Ax1.hxx>
#include <gp_Dir.hxx>
#include <gp_Lin.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Lin_Ctor()
{
	return new gp_Lin();
}
DECL_EXPORT void* gp_Lin_Ctor608B963B(
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	return new gp_Lin(			
_A1);
}
DECL_EXPORT void* gp_Lin_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new gp_Lin(			
_P,			
_V);
}
DECL_EXPORT void gp_Lin_Reverse(void* instance)
{
	gp_Lin* result = (gp_Lin*)instance;
 	result->Reverse();
}
DECL_EXPORT double gp_Lin_Angle9917D291(
	void* instance,
	void* Other)
{
		const gp_Lin &  _Other =*(const gp_Lin *)Other;
	gp_Lin* result = (gp_Lin*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT bool gp_Lin_ContainsF0D1E3E6(
	void* instance,
	void* P,
	double LinearTolerance)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
	return  	result->Contains(			
_P,			
LinearTolerance);
}
DECL_EXPORT double gp_Lin_Distance9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
	return  	result->Distance(			
_P);
}
DECL_EXPORT double gp_Lin_Distance9917D291(
	void* instance,
	void* Other)
{
		const gp_Lin &  _Other =*(const gp_Lin *)Other;
	gp_Lin* result = (gp_Lin*)instance;
	return  	result->Distance(			
_Other);
}
DECL_EXPORT double gp_Lin_SquareDistance9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
	return  	result->SquareDistance(			
_P);
}
DECL_EXPORT double gp_Lin_SquareDistance9917D291(
	void* instance,
	void* Other)
{
		const gp_Lin &  _Other =*(const gp_Lin *)Other;
	gp_Lin* result = (gp_Lin*)instance;
	return  	result->SquareDistance(			
_Other);
}
DECL_EXPORT void* gp_Lin_Normal9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Normal(			
_P));
}
DECL_EXPORT void gp_Lin_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Lin_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Lin_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Lin_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Lin_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Lin_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Lin_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Lin_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Lin_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Lin_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Lin_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Lin_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Lin_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Lin_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Lin_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Lin* result = (gp_Lin*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Lin_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Lin* result = (gp_Lin*)instance;
	return new gp_Lin( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void* gp_Lin_Reversed(void* instance)
{
	gp_Lin* result = (gp_Lin*)instance;
	return 	new gp_Lin(	result->Reversed());
}

DECL_EXPORT void gp_Lin_SetDirection(void* instance, void* value)
{
	gp_Lin* result = (gp_Lin*)instance;
		result->SetDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* gp_Lin_Direction(void* instance)
{
	gp_Lin* result = (gp_Lin*)instance;
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void gp_Lin_SetLocation(void* instance, void* value)
{
	gp_Lin* result = (gp_Lin*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Lin_Location(void* instance)
{
	gp_Lin* result = (gp_Lin*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void gp_Lin_SetPosition(void* instance, void* value)
{
	gp_Lin* result = (gp_Lin*)instance;
		result->SetPosition(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* gp_Lin_Position(void* instance)
{
	gp_Lin* result = (gp_Lin*)instance;
	return 	new gp_Ax1(	result->Position());
}

DECL_EXPORT void gpLin_Dtor(void* instance)
{
	delete (gp_Lin*)instance;
}
