#include "gpDir2d.h"
#include <gp_Dir2d.hxx>

#include <gp_Dir2d.hxx>
#include <gp_XY.hxx>

DECL_EXPORT void* gp_Dir2d_Ctor()
{
	return new gp_Dir2d();
}
DECL_EXPORT void* gp_Dir2d_Ctor5E4E66E7(
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	return new gp_Dir2d(			
_V);
}
DECL_EXPORT void* gp_Dir2d_CtorE051EF89(
	void* Coord)
{
		const gp_XY &  _Coord =*(const gp_XY *)Coord;
	return new gp_Dir2d(			
_Coord);
}
DECL_EXPORT void* gp_Dir2d_Ctor9F0E714F(
	double Xv,
	double Yv)
{
	return new gp_Dir2d(			
Xv,			
Yv);
}
DECL_EXPORT void gp_Dir2d_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT void gp_Dir2d_SetCoord9F0E714F(
	void* instance,
	double Xv,
	double Yv)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->SetCoord(			
Xv,			
Yv);
}
DECL_EXPORT double gp_Dir2d_CoordE8219145(
	void* instance,
	int Index)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_Dir2d_Coord9F0E714F(
	void* instance,
	double* Xv,
	double* Yv)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->Coord(			
*Xv,			
*Yv);
}
DECL_EXPORT bool gp_Dir2d_IsEqualD488E15(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir2d &  _Other =*(const gp_Dir2d *)Other;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->IsEqual(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Dir2d_IsNormalD488E15(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir2d &  _Other =*(const gp_Dir2d *)Other;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->IsNormal(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Dir2d_IsOppositeD488E15(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir2d &  _Other =*(const gp_Dir2d *)Other;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->IsOpposite(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Dir2d_IsParallelD488E15(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Dir2d &  _Other =*(const gp_Dir2d *)Other;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->IsParallel(			
_Other,			
AngularTolerance);
}
DECL_EXPORT double gp_Dir2d_Angle92BBA68E(
	void* instance,
	void* Other)
{
		const gp_Dir2d &  _Other =*(const gp_Dir2d *)Other;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT double gp_Dir2d_Crossed92BBA68E(
	void* instance,
	void* Right)
{
		const gp_Dir2d &  _Right =*(const gp_Dir2d *)Right;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->Crossed(			
_Right);
}
DECL_EXPORT double gp_Dir2d_Dot92BBA68E(
	void* instance,
	void* Other)
{
		const gp_Dir2d &  _Other =*(const gp_Dir2d *)Other;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return  	result->Dot(			
_Other);
}
DECL_EXPORT void gp_Dir2d_Reverse(void* instance)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Dir2d_Mirror92BBA68E(
	void* instance,
	void* V)
{
		const gp_Dir2d &  _V =*(const gp_Dir2d *)V;
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->Mirror(			
_V);
}
DECL_EXPORT void* gp_Dir2d_Mirrored92BBA68E(
	void* instance,
	void* V)
{
		const gp_Dir2d &  _V =*(const gp_Dir2d *)V;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return new gp_Dir2d( 	result->Mirrored(			
_V));
}
DECL_EXPORT void gp_Dir2d_Mirror90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->Mirror(			
_A);
}
DECL_EXPORT void* gp_Dir2d_Mirrored90E1386A(
	void* instance,
	void* A)
{
		const gp_Ax2d &  _A =*(const gp_Ax2d *)A;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return new gp_Dir2d( 	result->Mirrored(			
_A));
}
DECL_EXPORT void gp_Dir2d_RotateD82819F3(
	void* instance,
	double Ang)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->Rotate(			
Ang);
}
DECL_EXPORT void* gp_Dir2d_RotatedD82819F3(
	void* instance,
	double Ang)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return new gp_Dir2d( 	result->Rotated(			
Ang));
}
DECL_EXPORT void gp_Dir2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Dir2d* result = (gp_Dir2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Dir2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return new gp_Dir2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Dir2d_SetX(void* instance, double value)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_Dir2d_X(void* instance)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_Dir2d_SetY(void* instance, double value)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_Dir2d_Y(void* instance)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return 	result->Y();
}

DECL_EXPORT void gp_Dir2d_SetXY(void* instance, void* value)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
		result->SetXY(*(const gp_XY *)value);
}

DECL_EXPORT void* gp_Dir2d_XY(void* instance)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return 	new gp_XY(	result->XY());
}

DECL_EXPORT void* gp_Dir2d_Reversed(void* instance)
{
	gp_Dir2d* result = (gp_Dir2d*)instance;
	return 	new gp_Dir2d(	result->Reversed());
}

DECL_EXPORT void gpDir2d_Dtor(void* instance)
{
	delete (gp_Dir2d*)instance;
}
