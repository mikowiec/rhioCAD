#include "gpAx2d.h"
#include <gp_Ax2d.hxx>

#include <gp_Ax2d.hxx>
#include <gp_Dir2d.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT void* gp_Ax2d_Ctor()
{
	return new gp_Ax2d();
}
DECL_EXPORT void* gp_Ax2d_Ctor2E9C6BD1(
	void* P,
	void* V)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
		const gp_Dir2d &  _V =*(const gp_Dir2d *)V;
	return new gp_Ax2d(			
_P,			
_V);
}
DECL_EXPORT bool gp_Ax2d_IsCoaxial4745308(
	void* instance,
	void* Other,
	double AngularTolerance,
	double LinearTolerance)
{
		const gp_Ax2d &  _Other =*(const gp_Ax2d *)Other;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return  	result->IsCoaxial(			
_Other,			
AngularTolerance,			
LinearTolerance);
}
DECL_EXPORT bool gp_Ax2d_IsNormalF4E58768(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Ax2d &  _Other =*(const gp_Ax2d *)Other;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return  	result->IsNormal(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Ax2d_IsOppositeF4E58768(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Ax2d &  _Other =*(const gp_Ax2d *)Other;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return  	result->IsOpposite(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Ax2d_IsParallelF4E58768(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Ax2d &  _Other =*(const gp_Ax2d *)Other;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return  	result->IsParallel(			
_Other,			
AngularTolerance);
}
DECL_EXPORT double gp_Ax2d_Angle90E1386A(
	void* instance,
	void* Other)
{
		const gp_Ax2d &  _Other =*(const gp_Ax2d *)Other;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT void gp_Ax2d_Reverse(void* instance)
{
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Ax2d_Mirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Ax2d_Mirrored6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return new gp_Ax2d( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Ax2d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Ax2d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return new gp_Ax2d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Ax2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Rotate(			
_P,			
Ang);
}
DECL_EXPORT void* gp_Ax2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return new gp_Ax2d( 	result->Rotated(			
_P,			
Ang));
}
DECL_EXPORT void gp_Ax2d_ScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Ax2d_ScaledE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return new gp_Ax2d( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Ax2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Ax2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return new gp_Ax2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Ax2d_Translate5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Ax2d_Translated5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return new gp_Ax2d( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Ax2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Ax2d* result = (gp_Ax2d*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Ax2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return new gp_Ax2d( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Ax2d_SetLocation(void* instance, void* value)
{
	gp_Ax2d* result = (gp_Ax2d*)instance;
		result->SetLocation(*(const gp_Pnt2d *)value);
}

DECL_EXPORT void* gp_Ax2d_Location(void* instance)
{
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return 	new gp_Pnt2d(	result->Location());
}

DECL_EXPORT void gp_Ax2d_SetDirection(void* instance, void* value)
{
	gp_Ax2d* result = (gp_Ax2d*)instance;
		result->SetDirection(*(const gp_Dir2d *)value);
}

DECL_EXPORT void* gp_Ax2d_Direction(void* instance)
{
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return 	new gp_Dir2d(	result->Direction());
}

DECL_EXPORT void* gp_Ax2d_Reversed(void* instance)
{
	gp_Ax2d* result = (gp_Ax2d*)instance;
	return 	new gp_Ax2d(	result->Reversed());
}

DECL_EXPORT void gpAx2d_Dtor(void* instance)
{
	delete (gp_Ax2d*)instance;
}
