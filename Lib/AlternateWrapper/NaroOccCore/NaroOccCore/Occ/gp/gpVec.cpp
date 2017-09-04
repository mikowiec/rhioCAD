#include "gpVec.h"
#include <gp_Vec.hxx>

#include <gp_Vec.hxx>
#include <gp_XYZ.hxx>

DECL_EXPORT void* gp_Vec_Ctor()
{
	return new gp_Vec();
}
DECL_EXPORT void* gp_Vec_CtorCEC711A5(
	void* V)
{
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new gp_Vec(			
_V);
}
DECL_EXPORT void* gp_Vec_Ctor8EE42329(
	void* Coord)
{
		const gp_XYZ &  _Coord =*(const gp_XYZ *)Coord;
	return new gp_Vec(			
_Coord);
}
DECL_EXPORT void* gp_Vec_Ctor9282A951(
	double Xv,
	double Yv,
	double Zv)
{
	return new gp_Vec(			
Xv,			
Yv,			
Zv);
}
DECL_EXPORT void* gp_Vec_Ctor5C63477E(
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new gp_Vec(			
_P1,			
_P2);
}
DECL_EXPORT void gp_Vec_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT void gp_Vec_SetCoord9282A951(
	void* instance,
	double Xv,
	double Yv,
	double Zv)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetCoord(			
Xv,			
Yv,			
Zv);
}
DECL_EXPORT double gp_Vec_CoordE8219145(
	void* instance,
	int Index)
{
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_Vec_Coord9282A951(
	void* instance,
	double* Xv,
	double* Yv,
	double* Zv)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->Coord(			
*Xv,			
*Yv,			
*Zv);
}
DECL_EXPORT bool gp_Vec_IsEqualB72DB00(
	void* instance,
	void* Other,
	double LinearTolerance,
	double AngularTolerance)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->IsEqual(			
_Other,			
LinearTolerance,			
AngularTolerance);
}
DECL_EXPORT bool gp_Vec_IsNormal45D40C1(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->IsNormal(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Vec_IsOpposite45D40C1(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->IsOpposite(			
_Other,			
AngularTolerance);
}
DECL_EXPORT bool gp_Vec_IsParallel45D40C1(
	void* instance,
	void* Other,
	double AngularTolerance)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->IsParallel(			
_Other,			
AngularTolerance);
}
DECL_EXPORT double gp_Vec_Angle9BD9CFFE(
	void* instance,
	void* Other)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->Angle(			
_Other);
}
DECL_EXPORT double gp_Vec_AngleWithRefD5A0F1EC(
	void* instance,
	void* Other,
	void* VRef)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
		const gp_Vec &  _VRef =*(const gp_Vec *)VRef;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->AngleWithRef(			
_Other,			
_VRef);
}
DECL_EXPORT void gp_Vec_Add9BD9CFFE(
	void* instance,
	void* Other)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void* gp_Vec_Added9BD9CFFE(
	void* instance,
	void* Other)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Added(			
_Other));
}
DECL_EXPORT void gp_Vec_Subtract9BD9CFFE(
	void* instance,
	void* Right)
{
		const gp_Vec &  _Right =*(const gp_Vec *)Right;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Subtract(			
_Right);
}
DECL_EXPORT void* gp_Vec_Subtracted9BD9CFFE(
	void* instance,
	void* Right)
{
		const gp_Vec &  _Right =*(const gp_Vec *)Right;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Subtracted(			
_Right));
}
DECL_EXPORT void gp_Vec_MultiplyD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->Multiply(			
Scalar);
}
DECL_EXPORT void* gp_Vec_MultipliedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Multiplied(			
Scalar));
}
DECL_EXPORT void gp_Vec_DivideD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->Divide(			
Scalar);
}
DECL_EXPORT void* gp_Vec_DividedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Divided(			
Scalar));
}
DECL_EXPORT void gp_Vec_Cross9BD9CFFE(
	void* instance,
	void* Right)
{
		const gp_Vec &  _Right =*(const gp_Vec *)Right;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Cross(			
_Right);
}
DECL_EXPORT void* gp_Vec_Crossed9BD9CFFE(
	void* instance,
	void* Right)
{
		const gp_Vec &  _Right =*(const gp_Vec *)Right;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Crossed(			
_Right));
}
DECL_EXPORT double gp_Vec_CrossMagnitude9BD9CFFE(
	void* instance,
	void* Right)
{
		const gp_Vec &  _Right =*(const gp_Vec *)Right;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->CrossMagnitude(			
_Right);
}
DECL_EXPORT double gp_Vec_CrossSquareMagnitude9BD9CFFE(
	void* instance,
	void* Right)
{
		const gp_Vec &  _Right =*(const gp_Vec *)Right;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->CrossSquareMagnitude(			
_Right);
}
DECL_EXPORT void gp_Vec_CrossCrossD5A0F1EC(
	void* instance,
	void* V1,
	void* V2)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
	gp_Vec* result = (gp_Vec*)instance;
 	result->CrossCross(			
_V1,			
_V2);
}
DECL_EXPORT void* gp_Vec_CrossCrossedD5A0F1EC(
	void* instance,
	void* V1,
	void* V2)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->CrossCrossed(			
_V1,			
_V2));
}
DECL_EXPORT double gp_Vec_Dot9BD9CFFE(
	void* instance,
	void* Other)
{
		const gp_Vec &  _Other =*(const gp_Vec *)Other;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->Dot(			
_Other);
}
DECL_EXPORT double gp_Vec_DotCrossD5A0F1EC(
	void* instance,
	void* V1,
	void* V2)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
	gp_Vec* result = (gp_Vec*)instance;
	return  	result->DotCross(			
_V1,			
_V2);
}
DECL_EXPORT void gp_Vec_Normalize(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->Normalize();
}
DECL_EXPORT void gp_Vec_Reverse(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_Vec_SetLinearFormC27F2330(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	double A3,
	void* V3,
	void* V4)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
		const gp_Vec &  _V3 =*(const gp_Vec *)V3;
		const gp_Vec &  _V4 =*(const gp_Vec *)V4;
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
A2,			
_V2,			
A3,			
_V3,			
_V4);
}
DECL_EXPORT void gp_Vec_SetLinearForm9A51AB42(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	double A3,
	void* V3)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
		const gp_Vec &  _V3 =*(const gp_Vec *)V3;
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
A2,			
_V2,			
A3,			
_V3);
}
DECL_EXPORT void gp_Vec_SetLinearForm5C2CAE24(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	void* V3)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
		const gp_Vec &  _V3 =*(const gp_Vec *)V3;
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
A2,			
_V2,			
_V3);
}
DECL_EXPORT void gp_Vec_SetLinearFormF12FD193(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
A2,			
_V2);
}
DECL_EXPORT void gp_Vec_SetLinearForm8045255A(
	void* instance,
	double A1,
	void* V1,
	void* V2)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetLinearForm(			
A1,			
_V1,			
_V2);
}
DECL_EXPORT void gp_Vec_SetLinearFormD5A0F1EC(
	void* instance,
	void* V1,
	void* V2)
{
		const gp_Vec &  _V1 =*(const gp_Vec *)V1;
		const gp_Vec &  _V2 =*(const gp_Vec *)V2;
	gp_Vec* result = (gp_Vec*)instance;
 	result->SetLinearForm(			
_V1,			
_V2);
}
DECL_EXPORT void gp_Vec_Mirror9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Mirror(			
_V);
}
DECL_EXPORT void* gp_Vec_Mirrored9BD9CFFE(
	void* instance,
	void* V)
{
		const gp_Vec &  _V =*(const gp_Vec *)V;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Mirrored(			
_V));
}
DECL_EXPORT void gp_Vec_Mirror608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Mirror(			
_A1);
}
DECL_EXPORT void* gp_Vec_Mirrored608B963B(
	void* instance,
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Mirrored(			
_A1));
}
DECL_EXPORT void gp_Vec_Mirror7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Mirror(			
_A2);
}
DECL_EXPORT void* gp_Vec_Mirrored7895386A(
	void* instance,
	void* A2)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Mirrored(			
_A2));
}
DECL_EXPORT void gp_Vec_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Rotate(			
_A1,			
Ang);
}
DECL_EXPORT void* gp_Vec_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Rotated(			
_A1,			
Ang));
}
DECL_EXPORT void gp_Vec_ScaleD82819F3(
	void* instance,
	double S)
{
	gp_Vec* result = (gp_Vec*)instance;
 	result->Scale(			
S);
}
DECL_EXPORT void* gp_Vec_ScaledD82819F3(
	void* instance,
	double S)
{
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Scaled(			
S));
}
DECL_EXPORT void gp_Vec_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Vec* result = (gp_Vec*)instance;
 	result->Transform(			
_T);
}
DECL_EXPORT void* gp_Vec_Transformed72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	gp_Vec* result = (gp_Vec*)instance;
	return new gp_Vec( 	result->Transformed(			
_T));
}
DECL_EXPORT void gp_Vec_SetX(void* instance, double value)
{
	gp_Vec* result = (gp_Vec*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_Vec_X(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_Vec_SetY(void* instance, double value)
{
	gp_Vec* result = (gp_Vec*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_Vec_Y(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	result->Y();
}

DECL_EXPORT void gp_Vec_SetZ(void* instance, double value)
{
	gp_Vec* result = (gp_Vec*)instance;
		result->SetZ(value);
}

DECL_EXPORT double gp_Vec_Z(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	result->Z();
}

DECL_EXPORT void gp_Vec_SetXYZ(void* instance, void* value)
{
	gp_Vec* result = (gp_Vec*)instance;
		result->SetXYZ(*(const gp_XYZ *)value);
}

DECL_EXPORT void* gp_Vec_XYZ(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	new gp_XYZ(	result->XYZ());
}

DECL_EXPORT double gp_Vec_Magnitude(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	result->Magnitude();
}

DECL_EXPORT double gp_Vec_SquareMagnitude(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	result->SquareMagnitude();
}

DECL_EXPORT void* gp_Vec_Normalized(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	new gp_Vec(	result->Normalized());
}

DECL_EXPORT void* gp_Vec_Reversed(void* instance)
{
	gp_Vec* result = (gp_Vec*)instance;
	return 	new gp_Vec(	result->Reversed());
}

DECL_EXPORT void gpVec_Dtor(void* instance)
{
	delete (gp_Vec*)instance;
}
