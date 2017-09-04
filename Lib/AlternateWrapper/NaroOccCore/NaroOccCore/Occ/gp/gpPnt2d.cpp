#include "gpPnt2d.h"
#include <gp_Pnt2d.hxx>

#include <gp_Pnt2d.hxx>
#include <gp_XY.hxx>

DECL_EXPORT void* gp_Pnt2d_Ctor()
{
	return new gp_Pnt2d();
}
DECL_EXPORT void* gp_Pnt2d_CtorE051EF89(
	void* Coord)
{
		const gp_XY &  _Coord =*(const gp_XY *)Coord;
	return new gp_Pnt2d(			
_Coord);
}
DECL_EXPORT void* gp_Pnt2d_Ctor9F0E714F(
	double Xp,
	double Yp)
{
	return new gp_Pnt2d(			
Xp,			
Yp);
}
DECL_EXPORT void gp_Pnt2d_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT void gp_Pnt2d_SetCoord9F0E714F(
	void* instance,
	double Xp,
	double Yp)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->SetCoord(			
Xp,			
Yp);
}
DECL_EXPORT double gp_Pnt2d_CoordE8219145(
	void* instance,
	int Index)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_Pnt2d_Coord9F0E714F(
	void* instance,
	double* Xp,
	double* Yp)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Coord(			
*Xp,			
*Yp);
}
DECL_EXPORT void* gp_Pnt2d_Coord(void* instance)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_XY( 	result->Coord());
}
DECL_EXPORT bool gp_Pnt2d_IsEqualE3062737(
	void* instance,
	void* Other,
	double LinearTolerance)
{
		const gp_Pnt2d &  _Other =*(const gp_Pnt2d *)Other;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return  	result->IsEqual(			
_Other,			
LinearTolerance);
}
DECL_EXPORT double gp_Pnt2d_Distance6203658C(
	void* instance,
	void* Other)
{
		const gp_Pnt2d &  _Other =*(const gp_Pnt2d *)Other;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return  	result->Distance(			
_Other);
}
DECL_EXPORT double gp_Pnt2d_SquareDistance6203658C(
	void* instance,
	void* Other)
{
		const gp_Pnt2d &  _Other =*(const gp_Pnt2d *)Other;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return  	result->SquareDistance(			
_Other);
}
DECL_EXPORT void gp_Pnt2d_Mirror6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Pnt2d_Mirrored6203658C(
	void* instance,
	void* P)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_Pnt2d( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Pnt2d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Pnt2d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_Pnt2d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Pnt2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Rotate(			
_P,			
Ang);
}
DECL_EXPORT void* gp_Pnt2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_Pnt2d( 	result->Rotated(			
_P,			
Ang));
}
DECL_EXPORT void gp_Pnt2d_ScaleE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Pnt2d_ScaledE3062737(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt2d &  _P =*(const gp_Pnt2d *)P;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_Pnt2d( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Pnt2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Pnt2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_Pnt2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Pnt2d_Translate5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Pnt2d_Translated5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_Pnt2d( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Pnt2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Pnt2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return new gp_Pnt2d( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Pnt2d_SetX(void* instance, double value)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_Pnt2d_X(void* instance)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_Pnt2d_SetY(void* instance, double value)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_Pnt2d_Y(void* instance)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return 	result->Y();
}

DECL_EXPORT void gp_Pnt2d_SetXY(void* instance, void* value)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
		result->SetXY(*(const gp_XY *)value);
}

DECL_EXPORT void* gp_Pnt2d_XY(void* instance)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return 	new gp_XY(	result->XY());
}

DECL_EXPORT void* gp_Pnt2d_ChangeCoord(void* instance)
{
	gp_Pnt2d* result = (gp_Pnt2d*)instance;
	return 	new gp_XY(	result->ChangeCoord());
}

DECL_EXPORT void gpPnt2d_Dtor(void* instance)
{
	delete (gp_Pnt2d*)instance;
}
