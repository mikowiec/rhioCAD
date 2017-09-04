#include "gpMat2d.h"
#include <gp_Mat2d.hxx>

#include <gp_Mat2d.hxx>
#include <gp_XY.hxx>

DECL_EXPORT void* gp_Mat2d_Ctor()
{
	return new gp_Mat2d();
}
DECL_EXPORT void* gp_Mat2d_Ctor80A5E281(
	void* Col1,
	void* Col2)
{
		const gp_XY &  _Col1 =*(const gp_XY *)Col1;
		const gp_XY &  _Col2 =*(const gp_XY *)Col2;
	return new gp_Mat2d(			
_Col1,			
_Col2);
}
DECL_EXPORT void gp_Mat2d_SetCol1FC91E6F(
	void* instance,
	int Col,
	void* Value)
{
		const gp_XY &  _Value =*(const gp_XY *)Value;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->SetCol(			
Col,			
_Value);
}
DECL_EXPORT void gp_Mat2d_SetCols80A5E281(
	void* instance,
	void* Col1,
	void* Col2)
{
		const gp_XY &  _Col1 =*(const gp_XY *)Col1;
		const gp_XY &  _Col2 =*(const gp_XY *)Col2;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->SetCols(			
_Col1,			
_Col2);
}
DECL_EXPORT void gp_Mat2d_SetDiagonal9F0E714F(
	void* instance,
	double X1,
	double X2)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->SetDiagonal(			
X1,			
X2);
}
DECL_EXPORT void gp_Mat2d_SetIdentity(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->SetIdentity();
}
DECL_EXPORT void gp_Mat2d_SetRow1FC91E6F(
	void* instance,
	int Row,
	void* Value)
{
		const gp_XY &  _Value =*(const gp_XY *)Value;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->SetRow(			
Row,			
_Value);
}
DECL_EXPORT void gp_Mat2d_SetRows80A5E281(
	void* instance,
	void* Row1,
	void* Row2)
{
		const gp_XY &  _Row1 =*(const gp_XY *)Row1;
		const gp_XY &  _Row2 =*(const gp_XY *)Row2;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->SetRows(			
_Row1,			
_Row2);
}
DECL_EXPORT void gp_Mat2d_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->SetValue(			
Row,			
Col,			
Value);
}
DECL_EXPORT void* gp_Mat2d_ColumnE8219145(
	void* instance,
	int Col)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_XY( 	result->Column(			
Col));
}
DECL_EXPORT void* gp_Mat2d_Diagonal(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_XY( 	result->Diagonal());
}
DECL_EXPORT void* gp_Mat2d_RowE8219145(
	void* instance,
	int Row)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_XY( 	result->Row(			
Row));
}
DECL_EXPORT double gp_Mat2d_Value5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return  	result->Value(			
Row,			
Col);
}
DECL_EXPORT double gp_Mat2d_ChangeValue5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return  	result->ChangeValue(			
Row,			
Col);
}
DECL_EXPORT void gp_Mat2d_Add61A06211(
	void* instance,
	void* Other)
{
		const gp_Mat2d &  _Other =*(const gp_Mat2d *)Other;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void* gp_Mat2d_Added61A06211(
	void* instance,
	void* Other)
{
		const gp_Mat2d &  _Other =*(const gp_Mat2d *)Other;
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_Mat2d( 	result->Added(			
_Other));
}
DECL_EXPORT void gp_Mat2d_DivideD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Divide(			
Scalar);
}
DECL_EXPORT void* gp_Mat2d_DividedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_Mat2d( 	result->Divided(			
Scalar));
}
DECL_EXPORT void gp_Mat2d_Invert(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Invert();
}
DECL_EXPORT void* gp_Mat2d_Multiplied61A06211(
	void* instance,
	void* Other)
{
		const gp_Mat2d &  _Other =*(const gp_Mat2d *)Other;
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_Mat2d( 	result->Multiplied(			
_Other));
}
DECL_EXPORT void gp_Mat2d_Multiply61A06211(
	void* instance,
	void* Other)
{
		const gp_Mat2d &  _Other =*(const gp_Mat2d *)Other;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Multiply(			
_Other);
}
DECL_EXPORT void gp_Mat2d_PreMultiply61A06211(
	void* instance,
	void* Other)
{
		const gp_Mat2d &  _Other =*(const gp_Mat2d *)Other;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->PreMultiply(			
_Other);
}
DECL_EXPORT void* gp_Mat2d_MultipliedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_Mat2d( 	result->Multiplied(			
Scalar));
}
DECL_EXPORT void gp_Mat2d_MultiplyD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Multiply(			
Scalar);
}
DECL_EXPORT void gp_Mat2d_PowerE8219145(
	void* instance,
	int N)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Power(			
N);
}
DECL_EXPORT void* gp_Mat2d_PoweredE8219145(
	void* instance,
	int N)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_Mat2d( 	result->Powered(			
N));
}
DECL_EXPORT void gp_Mat2d_Subtract61A06211(
	void* instance,
	void* Other)
{
		const gp_Mat2d &  _Other =*(const gp_Mat2d *)Other;
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Subtract(			
_Other);
}
DECL_EXPORT void* gp_Mat2d_Subtracted61A06211(
	void* instance,
	void* Other)
{
		const gp_Mat2d &  _Other =*(const gp_Mat2d *)Other;
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return new gp_Mat2d( 	result->Subtracted(			
_Other));
}
DECL_EXPORT void gp_Mat2d_Transpose(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
 	result->Transpose();
}
DECL_EXPORT void gp_Mat2d_SetRotation(void* instance, double value)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
		result->SetRotation(value);
}

DECL_EXPORT void gp_Mat2d_SetScale(void* instance, double value)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
		result->SetScale(value);
}

DECL_EXPORT double gp_Mat2d_Determinant(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return 	result->Determinant();
}

DECL_EXPORT bool gp_Mat2d_IsSingular(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return 	result->IsSingular();
}

DECL_EXPORT void* gp_Mat2d_Inverted(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return 	new gp_Mat2d(	result->Inverted());
}

DECL_EXPORT void* gp_Mat2d_Transposed(void* instance)
{
	gp_Mat2d* result = (gp_Mat2d*)instance;
	return 	new gp_Mat2d(	result->Transposed());
}

DECL_EXPORT void gpMat2d_Dtor(void* instance)
{
	delete (gp_Mat2d*)instance;
}
