#include "gpXY.h"
#include <gp_XY.hxx>

#include <gp_XY.hxx>

DECL_EXPORT void* gp_XY_Ctor()
{
	return new gp_XY();
}
DECL_EXPORT void* gp_XY_Ctor9F0E714F(
	double X,
	double Y)
{
	return new gp_XY(			
X,			
Y);
}
DECL_EXPORT void gp_XY_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi)
{
	gp_XY* result = (gp_XY*)instance;
 	result->SetCoord(			
Index,			
Xi);
}
DECL_EXPORT void gp_XY_SetCoord9F0E714F(
	void* instance,
	double X,
	double Y)
{
	gp_XY* result = (gp_XY*)instance;
 	result->SetCoord(			
X,			
Y);
}
DECL_EXPORT double gp_XY_CoordE8219145(
	void* instance,
	int Index)
{
	gp_XY* result = (gp_XY*)instance;
	return  	result->Coord(			
Index);
}
DECL_EXPORT void gp_XY_Coord9F0E714F(
	void* instance,
	double* X,
	double* Y)
{
	gp_XY* result = (gp_XY*)instance;
 	result->Coord(			
*X,			
*Y);
}
DECL_EXPORT bool gp_XY_IsEqual8CB7F1D(
	void* instance,
	void* Other,
	double Tolerance)
{
		const gp_XY &  _Other =*(const gp_XY *)Other;
	gp_XY* result = (gp_XY*)instance;
	return  	result->IsEqual(			
_Other,			
Tolerance);
}
DECL_EXPORT void gp_XY_AddE051EF89(
	void* instance,
	void* Other)
{
		const gp_XY &  _Other =*(const gp_XY *)Other;
	gp_XY* result = (gp_XY*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void* gp_XY_AddedE051EF89(
	void* instance,
	void* Other)
{
		const gp_XY &  _Other =*(const gp_XY *)Other;
	gp_XY* result = (gp_XY*)instance;
	return new gp_XY( 	result->Added(			
_Other));
}
DECL_EXPORT double gp_XY_CrossedE051EF89(
	void* instance,
	void* Right)
{
		const gp_XY &  _Right =*(const gp_XY *)Right;
	gp_XY* result = (gp_XY*)instance;
	return  	result->Crossed(			
_Right);
}
DECL_EXPORT double gp_XY_CrossMagnitudeE051EF89(
	void* instance,
	void* Right)
{
		const gp_XY &  _Right =*(const gp_XY *)Right;
	gp_XY* result = (gp_XY*)instance;
	return  	result->CrossMagnitude(			
_Right);
}
DECL_EXPORT double gp_XY_CrossSquareMagnitudeE051EF89(
	void* instance,
	void* Right)
{
		const gp_XY &  _Right =*(const gp_XY *)Right;
	gp_XY* result = (gp_XY*)instance;
	return  	result->CrossSquareMagnitude(			
_Right);
}
DECL_EXPORT void gp_XY_DivideD82819F3(
	void* instance,
	double Scalar)
{
	gp_XY* result = (gp_XY*)instance;
 	result->Divide(			
Scalar);
}
DECL_EXPORT void* gp_XY_DividedD82819F3(
	void* instance,
	double Scalar)
{
	gp_XY* result = (gp_XY*)instance;
	return new gp_XY( 	result->Divided(			
Scalar));
}
DECL_EXPORT double gp_XY_DotE051EF89(
	void* instance,
	void* Other)
{
		const gp_XY &  _Other =*(const gp_XY *)Other;
	gp_XY* result = (gp_XY*)instance;
	return  	result->Dot(			
_Other);
}
DECL_EXPORT void gp_XY_MultiplyD82819F3(
	void* instance,
	double Scalar)
{
	gp_XY* result = (gp_XY*)instance;
 	result->Multiply(			
Scalar);
}
DECL_EXPORT void gp_XY_MultiplyE051EF89(
	void* instance,
	void* Other)
{
		const gp_XY &  _Other =*(const gp_XY *)Other;
	gp_XY* result = (gp_XY*)instance;
 	result->Multiply(			
_Other);
}
DECL_EXPORT void gp_XY_Multiply61A06211(
	void* instance,
	void* Matrix)
{
		const gp_Mat2d &  _Matrix =*(const gp_Mat2d *)Matrix;
	gp_XY* result = (gp_XY*)instance;
 	result->Multiply(			
_Matrix);
}
DECL_EXPORT void* gp_XY_MultipliedD82819F3(
	void* instance,
	double Scalar)
{
	gp_XY* result = (gp_XY*)instance;
	return new gp_XY( 	result->Multiplied(			
Scalar));
}
DECL_EXPORT void* gp_XY_MultipliedE051EF89(
	void* instance,
	void* Other)
{
		const gp_XY &  _Other =*(const gp_XY *)Other;
	gp_XY* result = (gp_XY*)instance;
	return new gp_XY( 	result->Multiplied(			
_Other));
}
DECL_EXPORT void* gp_XY_Multiplied61A06211(
	void* instance,
	void* Matrix)
{
		const gp_Mat2d &  _Matrix =*(const gp_Mat2d *)Matrix;
	gp_XY* result = (gp_XY*)instance;
	return new gp_XY( 	result->Multiplied(			
_Matrix));
}
DECL_EXPORT void gp_XY_Normalize(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
 	result->Normalize();
}
DECL_EXPORT void gp_XY_Reverse(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
 	result->Reverse();
}
DECL_EXPORT void gp_XY_SetLinearFormAF67E18B(
	void* instance,
	double A1,
	void* XY1,
	double A2,
	void* XY2)
{
		const gp_XY &  _XY1 =*(const gp_XY *)XY1;
		const gp_XY &  _XY2 =*(const gp_XY *)XY2;
	gp_XY* result = (gp_XY*)instance;
 	result->SetLinearForm(			
A1,			
_XY1,			
A2,			
_XY2);
}
DECL_EXPORT void gp_XY_SetLinearForm5D640BC7(
	void* instance,
	double A1,
	void* XY1,
	double A2,
	void* XY2,
	void* XY3)
{
		const gp_XY &  _XY1 =*(const gp_XY *)XY1;
		const gp_XY &  _XY2 =*(const gp_XY *)XY2;
		const gp_XY &  _XY3 =*(const gp_XY *)XY3;
	gp_XY* result = (gp_XY*)instance;
 	result->SetLinearForm(			
A1,			
_XY1,			
A2,			
_XY2,			
_XY3);
}
DECL_EXPORT void gp_XY_SetLinearFormDFE76FF8(
	void* instance,
	double A1,
	void* XY1,
	void* XY2)
{
		const gp_XY &  _XY1 =*(const gp_XY *)XY1;
		const gp_XY &  _XY2 =*(const gp_XY *)XY2;
	gp_XY* result = (gp_XY*)instance;
 	result->SetLinearForm(			
A1,			
_XY1,			
_XY2);
}
DECL_EXPORT void gp_XY_SetLinearForm80A5E281(
	void* instance,
	void* XY1,
	void* XY2)
{
		const gp_XY &  _XY1 =*(const gp_XY *)XY1;
		const gp_XY &  _XY2 =*(const gp_XY *)XY2;
	gp_XY* result = (gp_XY*)instance;
 	result->SetLinearForm(			
_XY1,			
_XY2);
}
DECL_EXPORT void gp_XY_SubtractE051EF89(
	void* instance,
	void* Right)
{
		const gp_XY &  _Right =*(const gp_XY *)Right;
	gp_XY* result = (gp_XY*)instance;
 	result->Subtract(			
_Right);
}
DECL_EXPORT void* gp_XY_SubtractedE051EF89(
	void* instance,
	void* Right)
{
		const gp_XY &  _Right =*(const gp_XY *)Right;
	gp_XY* result = (gp_XY*)instance;
	return new gp_XY( 	result->Subtracted(			
_Right));
}
DECL_EXPORT void gp_XY_SetX(void* instance, double value)
{
	gp_XY* result = (gp_XY*)instance;
		result->SetX(value);
}

DECL_EXPORT double gp_XY_X(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
	return 	result->X();
}

DECL_EXPORT void gp_XY_SetY(void* instance, double value)
{
	gp_XY* result = (gp_XY*)instance;
		result->SetY(value);
}

DECL_EXPORT double gp_XY_Y(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
	return 	result->Y();
}

DECL_EXPORT double gp_XY_Modulus(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
	return 	result->Modulus();
}

DECL_EXPORT double gp_XY_SquareModulus(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
	return 	result->SquareModulus();
}

DECL_EXPORT void* gp_XY_Normalized(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
	return 	new gp_XY(	result->Normalized());
}

DECL_EXPORT void* gp_XY_Reversed(void* instance)
{
	gp_XY* result = (gp_XY*)instance;
	return 	new gp_XY(	result->Reversed());
}

DECL_EXPORT void gpXY_Dtor(void* instance)
{
	delete (gp_XY*)instance;
}
