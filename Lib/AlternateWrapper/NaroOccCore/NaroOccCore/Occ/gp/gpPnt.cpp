#include "gpPnt.h"
#include <gp_Pnt.hxx>

#include <gp_Pnt.hxx>
#include <gp_XYZ.hxx>

DECL_EXPORT void* gp_Pnt_Ctor()
{
	return new gp_Pnt();
}
DECL_EXPORT void* gp_Pnt_Ctor8EE42329(
	void* Coord)
{
		const gp_XYZ &  _Coord =*(const gp_XYZ *)Coord;
	return new gp_Pnt(			
_Coord);
}
DECL_EXPORT void* gp_Pnt_Ctor9282A951(
	double Xp,
	double Yp,
	double Zp)
{
	return new gp_Pnt(			
Xp,			
Yp,			
Zp);
}
DECL_EXPORT void gp_Pnt_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT void gp_Pnt_SetCoord9282A951(
	void* instance,
	double Xp,
	double Yp,
	double Zp)
{
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->SetCoord(			
Xp,			
Yp,			
Zp);
}
DECL_EXPORT double gp_Pnt_CoordE8219145(
	void* instance,
	int Index)
{
	gp_Pnt* result = (gp_Pnt*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_Pnt_Coord9282A951(
	void* instance,
	double* Xp,
	double* Yp,
	double* Zp)
{
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Coord(			
*Xp,			
*Yp,			
*Zp);
}
DECL_EXPORT void* gp_Pnt_Coord(void* instance)
{
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_XYZ( 	result->Coord());
}
DECL_EXPORT void gp_Pnt_BaryCenterED1E08EC(
	void* instance,
	double Alpha,
	void* P,
	double Beta)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->BaryCenter(			
Alpha,			
_P,			
Beta);
}
DECL_EXPORT bool gp_Pnt_IsEqualF0D1E3E6(
	void* instance,
	void* Other,
	double LinearTolerance)
{
		const gp_Pnt &  _Other =*(const gp_Pnt *)Other;
	gp_Pnt* result = (gp_Pnt*)instance;
	return  	result->IsEqual(			
_Other,			
LinearTolerance);
}
DECL_EXPORT double gp_Pnt_Distance9EAECD5B(
	void* instance,
	void* Other)
{
		const gp_Pnt &  _Other =*(const gp_Pnt *)Other;
	gp_Pnt* result = (gp_Pnt*)instance;
	return  	result->Distance(			
_Other);
}
DECL_EXPORT double gp_Pnt_SquareDistance9EAECD5B(
	void* instance,
	void* Other)
{
		const gp_Pnt &  _Other =*(const gp_Pnt *)Other;
	gp_Pnt* result = (gp_Pnt*)instance;
	return  	result->SquareDistance(			
_Other);
}
DECL_EXPORT void gp_Pnt_Mirror9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Mirror(			
_P);
}
DECL_EXPORT void* gp_Pnt_Mirrored9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Mirrored(			
_P));
}
DECL_EXPORT void gp_Pnt_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Pnt_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Pnt_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Pnt_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Pnt_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Pnt_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Pnt_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Scale(			
_P,			
S);
}
DECL_EXPORT void* gp_Pnt_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Scaled(			
_P,			
S));
}
DECL_EXPORT void gp_Pnt_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Pnt_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Pnt_Translate9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Translate(			
_V);
}
DECL_EXPORT void* gp_Pnt_Translated9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Translated(			
_V));
}
DECL_EXPORT void gp_Pnt_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Pnt* result = (gp_Pnt*)instance;
 	result->Translate(			
_P1,			
_P2);
}
DECL_EXPORT void* gp_Pnt_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	gp_Pnt* result = (gp_Pnt*)instance;
	return new gp_Pnt( 	result->Translated(			
_P1,			
_P2));
}
DECL_EXPORT void gp_Pnt_SetX(void* instance, double value)
{
	gp_Pnt* result = (gp_Pnt*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_Pnt_X(void* instance)
{
	gp_Pnt* result = (gp_Pnt*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_Pnt_SetY(void* instance, double value)
{
	gp_Pnt* result = (gp_Pnt*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_Pnt_Y(void* instance)
{
	gp_Pnt* result = (gp_Pnt*)instance;
	return 	result->Y();
}

DECL_EXPORT void gp_Pnt_SetZ(void* instance, double value)
{
	gp_Pnt* result = (gp_Pnt*)instance;
		result->SetZ(value);
}

DECL_EXPORT double gp_Pnt_Z(void* instance)
{
	gp_Pnt* result = (gp_Pnt*)instance;
	return 	result->Z();
}

DECL_EXPORT void gp_Pnt_SetXYZ(void* instance, void* value)
{
	gp_Pnt* result = (gp_Pnt*)instance;
		result->SetXYZ(*(const gp_XYZ *)value);
}

DECL_EXPORT void* gp_Pnt_XYZ(void* instance)
{
	gp_Pnt* result = (gp_Pnt*)instance;
	return 	new gp_XYZ(	result->XYZ());
}

DECL_EXPORT void* gp_Pnt_ChangeCoord(void* instance)
{
	gp_Pnt* result = (gp_Pnt*)instance;
	return 	new gp_XYZ(	result->ChangeCoord());
}

DECL_EXPORT void gpPnt_Dtor(void* instance)
{
	delete (gp_Pnt*)instance;
}
