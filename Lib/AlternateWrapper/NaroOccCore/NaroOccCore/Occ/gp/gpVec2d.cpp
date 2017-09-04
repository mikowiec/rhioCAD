#include "gpVec2d.h"
#include <gp_Vec2d.hxx>

#include <gp_Vec2d.hxx>
#include <gp_XY.hxx>

DECL_EXPORT void* gp_Vec2d_Ctor()
{
	return new gp_Vec2d();
}
DECL_EXPORT void* gp_Vec2d_Ctor92BBA68E(
	void* V)
{
		const gp_Dir2d &  _V =*(const gp_Dir2d *)V;
	return new gp_Vec2d(			
_V);
}
DECL_EXPORT void* gp_Vec2d_CtorE051EF89(
	void* Coord)
{
		const gp_XY &  _Coord =*(const gp_XY *)Coord;
	return new gp_Vec2d(			
_Coord);
}
DECL_EXPORT void* gp_Vec2d_Ctor9F0E714F(
	double Xv,
	double Yv)
{
	return new gp_Vec2d(			
Xv,			
Yv);
}
DECL_EXPORT void* gp_Vec2d_Ctor5F54ADE3(
	void* P1,
	void* P2)
{
		const gp_Pnt2d &  _P1 =*(const gp_Pnt2d *)P1;
		const gp_Pnt2d &  _P2 =*(const gp_Pnt2d *)P2;
	return new gp_Vec2d(			
_P1,			
_P2);
}
DECL_EXPORT void gp_Vec2d_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT void gp_Vec2d_SetCoord9F0E714F(
	void* instance,
	double Xv,
	double Yv)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->SetCoord(			
Xv,			
Yv);
}
DECL_EXPORT double gp_Vec2d_CoordE8219145(
	void* instance,
	int Index)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_Vec2d_Coord9F0E714F(
	void* instance,
	double* Xv,
	double* Yv)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Coord(			
*Xv,			
*Yv);
}
DECL_EXPORT bool gp_Vec2d_IsEqual1F89D6DF(
	void* instance,
	void* Other,
	double LinearTolerance,
	double AngularTolerance)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->IsEqual(			
_Other,			
LinearTolerance,			
AngularTolerance);
}
DECL_EXPORT bool gp_Vec2d_IsNormalC1B831C6(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->IsNormal(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Vec2d_IsOppositeC1B831C6(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->IsOpposite(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Vec2d_IsParallelC1B831C6(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->IsParallel(			
_Other,			
AngularTolerance);
}
DECL_EXPORT double gp_Vec2d_Angle5E4E66E7(
	void* instance,
	void* Other)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT void gp_Vec2d_Add5E4E66E7(
	void* instance,
	void* Other)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void* gp_Vec2d_Added5E4E66E7(
	void* instance,
	void* Other)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Added(			
_Other));
}
DECL_EXPORT double gp_Vec2d_Crossed5E4E66E7(
	void* instance,
	void* Right)
{
		const gp_Vec2d &  _Right =*(const gp_Vec2d *)Right;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->Crossed(			
_Right);
}
DECL_EXPORT double gp_Vec2d_CrossMagnitude5E4E66E7(
	void* instance,
	void* Right)
{
		const gp_Vec2d &  _Right =*(const gp_Vec2d *)Right;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->CrossMagnitude(			
_Right);
}
DECL_EXPORT double gp_Vec2d_CrossSquareMagnitude5E4E66E7(
	void* instance,
	void* Right)
{
		const gp_Vec2d &  _Right =*(const gp_Vec2d *)Right;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->CrossSquareMagnitude(			
_Right);
}
DECL_EXPORT void gp_Vec2d_DivideD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Divide(			
Scalar);
}
DECL_EXPORT void* gp_Vec2d_DividedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Divided(			
Scalar));
}
DECL_EXPORT double gp_Vec2d_Dot5E4E66E7(
	void* instance,
	void* Other)
{
		const gp_Vec2d &  _Other =*(const gp_Vec2d *)Other;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return  	result->Dot(			
_Other);
}
DECL_EXPORT void gp_Vec2d_MultiplyD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Multiply(			
Scalar);
}
DECL_EXPORT void* gp_Vec2d_MultipliedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Multiplied(			
Scalar));
}
DECL_EXPORT void gp_Vec2d_Normalize(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Normalize();
}
DECL_EXPORT void gp_Vec2d_Reverse(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Vec2d_Subtract5E4E66E7(
	void* instance,
	void* Right)
{
		const gp_Vec2d &  _Right =*(const gp_Vec2d *)Right;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Subtract(			
_Right);
}
DECL_EXPORT void* gp_Vec2d_Subtracted5E4E66E7(
	void* instance,
	void* Right)
{
		const gp_Vec2d &  _Right =*(const gp_Vec2d *)Right;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Subtracted(			
_Right));
}
DECL_EXPORT void gp_Vec2d_SetLinearForm98ABEE74(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	void* V3)
{
		const gp_Vec2d &  _V1 =*(const gp_Vec2d *)V1;
		const gp_Vec2d &  _V2 =*(const gp_Vec2d *)V2;
		const gp_Vec2d &  _V3 =*(const gp_Vec2d *)V3;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
A2,			
_V2,			
_V3);
}
DECL_EXPORT void gp_Vec2d_SetLinearForm39A7F68A(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2)
{
		const gp_Vec2d &  _V1 =*(const gp_Vec2d *)V1;
		const gp_Vec2d &  _V2 =*(const gp_Vec2d *)V2;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
A2,			
_V2);
}
DECL_EXPORT void gp_Vec2d_SetLinearForm7874D091(
	void* instance,
	double A1,
	void* V1,
	void* V2)
{
		const gp_Vec2d &  _V1 =*(const gp_Vec2d *)V1;
		const gp_Vec2d &  _V2 =*(const gp_Vec2d *)V2;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
_V2);
}
DECL_EXPORT void gp_Vec2d_SetLinearFormE2FF8249(
	void* instance,
	void* Left,
	void* Right)
{
		const gp_Vec2d &  _Left =*(const gp_Vec2d *)Left;
		const gp_Vec2d &  _Right =*(const gp_Vec2d *)Right;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->SetLinearForm(			
_Left,			
_Right);
}
DECL_EXPORT void gp_Vec2d_Mirror5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Mirror(			
_V);
}
DECL_EXPORT void* gp_Vec2d_Mirrored5E4E66E7(
	void* instance,
	void* V)
{
		const gp_Vec2d &  _V =*(const gp_Vec2d *)V;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Mirrored(			
_V));
}
DECL_EXPORT void gp_Vec2d_Mirror90E1386A(
	void* instance,
	void* A1)
{
		const gp_Ax2d &  _A1 =*(const gp_Ax2d *)A1;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Vec2d_Mirrored90E1386A(
	void* instance,
	void* A1)
{
		const gp_Ax2d &  _A1 =*(const gp_Ax2d *)A1;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Vec2d_RotateD82819F3(
	void* instance,
	double Ang)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Rotate(			
Ang);
}
DECL_EXPORT void* gp_Vec2d_RotatedD82819F3(
	void* instance,
	double Ang)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Rotated(			
Ang));
}
DECL_EXPORT void gp_Vec2d_ScaleD82819F3(
	void* instance,
	double S)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Scale(			
S);
}
DECL_EXPORT void* gp_Vec2d_ScaledD82819F3(
	void* instance,
	double S)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Scaled(			
S));
}
DECL_EXPORT void gp_Vec2d_Transform27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Vec2d* result = (gp_Vec2d*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Vec2d_Transformed27621DCB(
	void* instance,
	void* T)
{
		const gp_Trsf2d &  _T =*(const gp_Trsf2d *)T;
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return new gp_Vec2d( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Vec2d_SetX(void* instance, double value)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_Vec2d_X(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_Vec2d_SetY(void* instance, double value)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_Vec2d_Y(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return 	result->Y();
}

DECL_EXPORT void gp_Vec2d_SetXY(void* instance, void* value)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
		result->SetXY(*(const gp_XY *)value);
}

DECL_EXPORT void* gp_Vec2d_XY(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return 	new gp_XY(	result->XY());
}

DECL_EXPORT double gp_Vec2d_Magnitude(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return 	result->Magnitude();
}

DECL_EXPORT double gp_Vec2d_SquareMagnitude(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return 	result->SquareMagnitude();
}

DECL_EXPORT void* gp_Vec2d_Normalized(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return 	new gp_Vec2d(	result->Normalized());
}

DECL_EXPORT void* gp_Vec2d_Reversed(void* instance)
{
	gp_Vec2d* result = (gp_Vec2d*)instance;
	return 	new gp_Vec2d(	result->Reversed());
}

DECL_EXPORT void gpVec2d_Dtor(void* instance)
{
	delete (gp_Vec2d*)instance;
}
