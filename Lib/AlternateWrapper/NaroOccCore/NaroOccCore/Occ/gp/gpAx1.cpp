#include "gpAx1.h"
#include <gp_Ax1.hxx>

#include <gp_Ax1.hxx>
#include <gp_Dir.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* gp_Ax1_Ctor()
{
	return new gp_Ax1();
}
DECL_EXPORT void* gp_Ax1_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new gp_Ax1(			
_P,			
_V);
}
DECL_EXPORT bool gp_Ax1_IsCoaxial5FECE277(
	void* instance,
	void* Other,
	double AngularTolerance,
	double LinearTolerance)
{
		const gp_Ax1 &  _Other =*(const gp_Ax1 *)Other;
	gp_Ax1* result = (gp_Ax1*)instance;
	return  	result->IsCoaxial(			
_Other,			
AngularTolerance,			
LinearTolerance);
}
DECL_EXPORT bool gp_Ax1_IsNormal827CB19A(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Ax1 &  _Other =*(const gp_Ax1 *)Other;
	gp_Ax1* result = (gp_Ax1*)instance;
	return  	result->IsNormal(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Ax1_IsOpposite827CB19A(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Ax1 &  _Other =*(const gp_Ax1 *)Other;
	gp_Ax1* result = (gp_Ax1*)instance;
	return  	result->IsOpposite(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Ax1_IsParallel827CB19A(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Ax1 &  _Other =*(const gp_Ax1 *)Other;
	gp_Ax1* result = (gp_Ax1*)instance;
	return  	result->IsParallel(			
_Other,			
AngularTolerance);
}
DECL_EXPORT double gp_Ax1_Angle608B963B(
	void* instance,
	void* Other)
{
		const gp_Ax1 &  _Other =*(const gp_Ax1 *)Other;
	gp_Ax1* result = (gp_Ax1*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT void gp_Ax1_Reverse(void* instance)
{
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Ax1_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Ax1_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Ax1_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Ax1_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Ax1_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Ax1_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Ax1_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Ax1_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Ax1_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Ax1_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Ax1_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Ax1_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Ax1_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Ax1_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Ax1_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Ax1* result = (gp_Ax1*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Ax1_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Ax1* result = (gp_Ax1*)instance;
	return new gp_Ax1( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Ax1_SetDirection(void* instance, void* value)
{
	gp_Ax1* result = (gp_Ax1*)instance;
		result->SetDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* gp_Ax1_Direction(void* instance)
{
	gp_Ax1* result = (gp_Ax1*)instance;
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void gp_Ax1_SetLocation(void* instance, void* value)
{
	gp_Ax1* result = (gp_Ax1*)instance;
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* gp_Ax1_Location(void* instance)
{
	gp_Ax1* result = (gp_Ax1*)instance;
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void* gp_Ax1_Reversed(void* instance)
{
	gp_Ax1* result = (gp_Ax1*)instance;
	return 	new gp_Ax1(	result->Reversed());
}

DECL_EXPORT void gpAx1_Dtor(void* instance)
{
	delete (gp_Ax1*)instance;
}
