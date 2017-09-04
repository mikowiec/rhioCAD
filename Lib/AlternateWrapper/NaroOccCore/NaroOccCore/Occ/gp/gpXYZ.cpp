#include "gpXYZ.h"
#include <gp_XYZ.hxx>

#include <gp_XYZ.hxx>

DECL_EXPORT void* gp_XYZ_Ctor()
{
	return new gp_XYZ();
}
DECL_EXPORT void* gp_XYZ_Ctor9282A951(
	double X,
	double Y,
	double Z)
{
	return new gp_XYZ(			
X,			
Y,			
Z);
}
DECL_EXPORT void gp_XYZ_SetCoord9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetCoord(			
X,			
Y,			
Z);
}
DECL_EXPORT void gp_XYZ_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT double gp_XYZ_CoordE8219145(
	void* instance,
	int Index)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_XYZ_Coord9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Coord(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT bool gp_XYZ_IsEqualAC21764D(
	void* instance,
	void* Other,
	double Tolerance)
{
		const gp_XYZ &  _Other =*(const gp_XYZ *)Other;
	gp_XYZ* result = (gp_XYZ*)instance;
	return  	result->IsEqual(			
_Other,			
Tolerance);
}
DECL_EXPORT void gp_XYZ_Add8EE42329(
	void* instance,
	void* Other)
{
		const gp_XYZ &  _Other =*(const gp_XYZ *)Other;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void* gp_XYZ_Added8EE42329(
	void* instance,
	void* Other)
{
		const gp_XYZ &  _Other =*(const gp_XYZ *)Other;
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->Added(			
_Other));
}
DECL_EXPORT void gp_XYZ_Cross8EE42329(
	void* instance,
	void* Right)
{
		const gp_XYZ &  _Right =*(const gp_XYZ *)Right;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Cross(			
_Right);
}
DECL_EXPORT void* gp_XYZ_Crossed8EE42329(
	void* instance,
	void* Right)
{
		const gp_XYZ &  _Right =*(const gp_XYZ *)Right;
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->Crossed(			
_Right));
}
DECL_EXPORT double gp_XYZ_CrossMagnitude8EE42329(
	void* instance,
	void* Right)
{
		const gp_XYZ &  _Right =*(const gp_XYZ *)Right;
	gp_XYZ* result = (gp_XYZ*)instance;
	return  	result->CrossMagnitude(			
_Right);
}
DECL_EXPORT double gp_XYZ_CrossSquareMagnitude8EE42329(
	void* instance,
	void* Right)
{
		const gp_XYZ &  _Right =*(const gp_XYZ *)Right;
	gp_XYZ* result = (gp_XYZ*)instance;
	return  	result->CrossSquareMagnitude(			
_Right);
}
DECL_EXPORT void gp_XYZ_CrossCross610ADE9D(
	void* instance,
	void* Coord1,
	void* Coord2)
{
		const gp_XYZ &  _Coord1 =*(const gp_XYZ *)Coord1;
		const gp_XYZ &  _Coord2 =*(const gp_XYZ *)Coord2;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->CrossCross(			
_Coord1,			
_Coord2);
}
DECL_EXPORT void* gp_XYZ_CrossCrossed610ADE9D(
	void* instance,
	void* Coord1,
	void* Coord2)
{
		const gp_XYZ &  _Coord1 =*(const gp_XYZ *)Coord1;
		const gp_XYZ &  _Coord2 =*(const gp_XYZ *)Coord2;
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->CrossCrossed(			
_Coord1,			
_Coord2));
}
DECL_EXPORT void gp_XYZ_DivideD82819F3(
	void* instance,
	double Scalar)
{
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Divide(			
Scalar);
}
DECL_EXPORT void* gp_XYZ_DividedD82819F3(
	void* instance,
	double Scalar)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->Divided(			
Scalar));
}
DECL_EXPORT double gp_XYZ_Dot8EE42329(
	void* instance,
	void* Other)
{
		const gp_XYZ &  _Other =*(const gp_XYZ *)Other;
	gp_XYZ* result = (gp_XYZ*)instance;
	return  	result->Dot(			
_Other);
}
DECL_EXPORT double gp_XYZ_DotCross610ADE9D(
	void* instance,
	void* Coord1,
	void* Coord2)
{
		const gp_XYZ &  _Coord1 =*(const gp_XYZ *)Coord1;
		const gp_XYZ &  _Coord2 =*(const gp_XYZ *)Coord2;
	gp_XYZ* result = (gp_XYZ*)instance;
	return  	result->DotCross(			
_Coord1,			
_Coord2);
}
DECL_EXPORT void gp_XYZ_MultiplyD82819F3(
	void* instance,
	double Scalar)
{
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Multiply(			
Scalar);
}
DECL_EXPORT void gp_XYZ_Multiply8EE42329(
	void* instance,
	void* Other)
{
		const gp_XYZ &  _Other =*(const gp_XYZ *)Other;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Multiply(			
_Other);
}
DECL_EXPORT void gp_XYZ_Multiply9EABCD40(
	void* instance,
	void* Matrix)
{
		const gp_Mat &  _Matrix =*(const gp_Mat *)Matrix;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Multiply(			
_Matrix);
}
DECL_EXPORT void* gp_XYZ_MultipliedD82819F3(
	void* instance,
	double Scalar)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->Multiplied(			
Scalar));
}
DECL_EXPORT void* gp_XYZ_Multiplied8EE42329(
	void* instance,
	void* Other)
{
		const gp_XYZ &  _Other =*(const gp_XYZ *)Other;
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->Multiplied(			
_Other));
}
DECL_EXPORT void* gp_XYZ_Multiplied9EABCD40(
	void* instance,
	void* Matrix)
{
		const gp_Mat &  _Matrix =*(const gp_Mat *)Matrix;
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->Multiplied(			
_Matrix));
}
DECL_EXPORT void gp_XYZ_Normalize(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Normalize();
}
DECL_EXPORT void gp_XYZ_Reverse(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_XYZ_Subtract8EE42329(
	void* instance,
	void* Right)
{
		const gp_XYZ &  _Right =*(const gp_XYZ *)Right;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->Subtract(			
_Right);
}
DECL_EXPORT void* gp_XYZ_Subtracted8EE42329(
	void* instance,
	void* Right)
{
		const gp_XYZ &  _Right =*(const gp_XYZ *)Right;
	gp_XYZ* result = (gp_XYZ*)instance;
	return new gp_XYZ( 	result->Subtracted(			
_Right));
}
DECL_EXPORT void gp_XYZ_SetLinearFormF220B60(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2,
	double A3,
	void* XYZ3,
	void* XYZ4)
{
		const gp_XYZ &  _XYZ1 =*(const gp_XYZ *)XYZ1;
		const gp_XYZ &  _XYZ2 =*(const gp_XYZ *)XYZ2;
		const gp_XYZ &  _XYZ3 =*(const gp_XYZ *)XYZ3;
		const gp_XYZ &  _XYZ4 =*(const gp_XYZ *)XYZ4;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetLinearForm(			
A1,			
_XYZ1,			
A2,			
_XYZ2,			
A3,			
_XYZ3,			
_XYZ4);
}
DECL_EXPORT void gp_XYZ_SetLinearFormF4A81B86(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2,
	double A3,
	void* XYZ3)
{
		const gp_XYZ &  _XYZ1 =*(const gp_XYZ *)XYZ1;
		const gp_XYZ &  _XYZ2 =*(const gp_XYZ *)XYZ2;
		const gp_XYZ &  _XYZ3 =*(const gp_XYZ *)XYZ3;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetLinearForm(			
A1,			
_XYZ1,			
A2,			
_XYZ2,			
A3,			
_XYZ3);
}
DECL_EXPORT void gp_XYZ_SetLinearFormD61C07A0(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2,
	void* XYZ3)
{
		const gp_XYZ &  _XYZ1 =*(const gp_XYZ *)XYZ1;
		const gp_XYZ &  _XYZ2 =*(const gp_XYZ *)XYZ2;
		const gp_XYZ &  _XYZ3 =*(const gp_XYZ *)XYZ3;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetLinearForm(			
A1,			
_XYZ1,			
A2,			
_XYZ2,			
_XYZ3);
}
DECL_EXPORT void gp_XYZ_SetLinearForm6062D8AE(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2)
{
		const gp_XYZ &  _XYZ1 =*(const gp_XYZ *)XYZ1;
		const gp_XYZ &  _XYZ2 =*(const gp_XYZ *)XYZ2;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetLinearForm(			
A1,			
_XYZ1,			
A2,			
_XYZ2);
}
DECL_EXPORT void gp_XYZ_SetLinearForm628B7A49(
	void* instance,
	double A1,
	void* XYZ1,
	void* XYZ2)
{
		const gp_XYZ &  _XYZ1 =*(const gp_XYZ *)XYZ1;
		const gp_XYZ &  _XYZ2 =*(const gp_XYZ *)XYZ2;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetLinearForm(			
A1,			
_XYZ1,			
_XYZ2);
}
DECL_EXPORT void gp_XYZ_SetLinearForm610ADE9D(
	void* instance,
	void* XYZ1,
	void* XYZ2)
{
		const gp_XYZ &  _XYZ1 =*(const gp_XYZ *)XYZ1;
		const gp_XYZ &  _XYZ2 =*(const gp_XYZ *)XYZ2;
	gp_XYZ* result = (gp_XYZ*)instance;
 	result->SetLinearForm(			
_XYZ1,			
_XYZ2);
}
DECL_EXPORT void gp_XYZ_SetX(void* instance, double value)
{
	gp_XYZ* result = (gp_XYZ*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_XYZ_X(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_XYZ_SetY(void* instance, double value)
{
	gp_XYZ* result = (gp_XYZ*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_XYZ_Y(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return 	result->Y();
}

DECL_EXPORT void gp_XYZ_SetZ(void* instance, double value)
{
	gp_XYZ* result = (gp_XYZ*)instance;
		result->SetZ(value);
}

DECL_EXPORT double gp_XYZ_Z(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return 	result->Z();
}

DECL_EXPORT double gp_XYZ_Modulus(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return 	result->Modulus();
}

DECL_EXPORT double gp_XYZ_SquareModulus(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return 	result->SquareModulus();
}

DECL_EXPORT void* gp_XYZ_Normalized(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return 	new gp_XYZ(	result->Normalized());
}

DECL_EXPORT void* gp_XYZ_Reversed(void* instance)
{
	gp_XYZ* result = (gp_XYZ*)instance;
	return 	new gp_XYZ(	result->Reversed());
}

DECL_EXPORT void gpXYZ_Dtor(void* instance)
{
	delete (gp_XYZ*)instance;
}
