#include "gpMat.h"
#include <gp_Mat.hxx>

#include <gp_Mat.hxx>
#include <gp_XYZ.hxx>

DECL_EXPORT void* gp_Mat_Ctor()
{
	return new gp_Mat();
}
DECL_EXPORT void* gp_Mat_CtorE32698D4(
	double a11,
	double a12,
	double a13,
	double a21,
	double a22,
	double a23,
	double a31,
	double a32,
	double a33)
{
	return new gp_Mat(			
a11,			
a12,			
a13,			
a21,			
a22,			
a23,			
a31,			
a32,			
a33);
}
DECL_EXPORT void* gp_Mat_Ctor7DAAC47(
	void* Col1,
	void* Col2,
	void* Col3)
{
		const gp_XYZ &  _Col1 =*(const gp_XYZ *)Col1;
		const gp_XYZ &  _Col2 =*(const gp_XYZ *)Col2;
		const gp_XYZ &  _Col3 =*(const gp_XYZ *)Col3;
	return new gp_Mat(			
_Col1,			
_Col2,			
_Col3);
}
DECL_EXPORT void gp_Mat_SetCol20231E6F(
	void* instance,
	int Col,
	void* Value)
{
		const gp_XYZ &  _Value =*(const gp_XYZ *)Value;
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetCol(			
Col,			
_Value);
}
DECL_EXPORT void gp_Mat_SetCols7DAAC47(
	void* instance,
	void* Col1,
	void* Col2,
	void* Col3)
{
		const gp_XYZ &  _Col1 =*(const gp_XYZ *)Col1;
		const gp_XYZ &  _Col2 =*(const gp_XYZ *)Col2;
		const gp_XYZ &  _Col3 =*(const gp_XYZ *)Col3;
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetCols(			
_Col1,			
_Col2,			
_Col3);
}
DECL_EXPORT void gp_Mat_SetDiagonal9282A951(
	void* instance,
	double X1,
	double X2,
	double X3)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetDiagonal(			
X1,			
X2,			
X3);
}
DECL_EXPORT void gp_Mat_SetIdentity(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetIdentity();
}
DECL_EXPORT void gp_Mat_SetRotationAC21764D(
	void* instance,
	void* Axis,
	double Ang)
{
		const gp_XYZ &  _Axis =*(const gp_XYZ *)Axis;
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetRotation(			
_Axis,			
Ang);
}
DECL_EXPORT void gp_Mat_SetRow20231E6F(
	void* instance,
	int Row,
	void* Value)
{
		const gp_XYZ &  _Value =*(const gp_XYZ *)Value;
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetRow(			
Row,			
_Value);
}
DECL_EXPORT void gp_Mat_SetRows7DAAC47(
	void* instance,
	void* Row1,
	void* Row2,
	void* Row3)
{
		const gp_XYZ &  _Row1 =*(const gp_XYZ *)Row1;
		const gp_XYZ &  _Row2 =*(const gp_XYZ *)Row2;
		const gp_XYZ &  _Row3 =*(const gp_XYZ *)Row3;
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetRows(			
_Row1,			
_Row2,			
_Row3);
}
DECL_EXPORT void gp_Mat_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->SetValue(			
Row,			
Col,			
Value);
}
DECL_EXPORT void* gp_Mat_ColumnE8219145(
	void* instance,
	int Col)
{
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_XYZ( 	result->Column(			
Col));
}
DECL_EXPORT void* gp_Mat_Diagonal(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_XYZ( 	result->Diagonal());
}
DECL_EXPORT void* gp_Mat_RowE8219145(
	void* instance,
	int Row)
{
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_XYZ( 	result->Row(			
Row));
}
DECL_EXPORT double gp_Mat_Value5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_Mat* result = (gp_Mat*)instance;
	return  	result->Value(			
Row,			
Col);
}
DECL_EXPORT double gp_Mat_ChangeValue5107F6FE(
	void* instance,
	int Row,
	int Col)
{
	gp_Mat* result = (gp_Mat*)instance;
	return  	result->ChangeValue(			
Row,			
Col);
}
DECL_EXPORT void gp_Mat_Add9EABCD40(
	void* instance,
	void* Other)
{
		const gp_Mat &  _Other =*(const gp_Mat *)Other;
	gp_Mat* result = (gp_Mat*)instance;
 	result->Add(			
_Other);
}
DECL_EXPORT void* gp_Mat_Added9EABCD40(
	void* instance,
	void* Other)
{
		const gp_Mat &  _Other =*(const gp_Mat *)Other;
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_Mat( 	result->Added(			
_Other));
}
DECL_EXPORT void gp_Mat_DivideD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->Divide(			
Scalar);
}
DECL_EXPORT void* gp_Mat_DividedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_Mat( 	result->Divided(			
Scalar));
}
DECL_EXPORT void gp_Mat_Invert(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->Invert();
}
DECL_EXPORT void* gp_Mat_Multiplied9EABCD40(
	void* instance,
	void* Other)
{
		const gp_Mat &  _Other =*(const gp_Mat *)Other;
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_Mat( 	result->Multiplied(			
_Other));
}
DECL_EXPORT void gp_Mat_Multiply9EABCD40(
	void* instance,
	void* Other)
{
		const gp_Mat &  _Other =*(const gp_Mat *)Other;
	gp_Mat* result = (gp_Mat*)instance;
 	result->Multiply(			
_Other);
}
DECL_EXPORT void gp_Mat_PreMultiply9EABCD40(
	void* instance,
	void* Other)
{
		const gp_Mat &  _Other =*(const gp_Mat *)Other;
	gp_Mat* result = (gp_Mat*)instance;
 	result->PreMultiply(			
_Other);
}
DECL_EXPORT void* gp_Mat_MultipliedD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_Mat( 	result->Multiplied(			
Scalar));
}
DECL_EXPORT void gp_Mat_MultiplyD82819F3(
	void* instance,
	double Scalar)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->Multiply(			
Scalar);
}
DECL_EXPORT void gp_Mat_PowerE8219145(
	void* instance,
	int N)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->Power(			
N);
}
DECL_EXPORT void* gp_Mat_PoweredE8219145(
	void* instance,
	int N)
{
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_Mat( 	result->Powered(			
N));
}
DECL_EXPORT void gp_Mat_Subtract9EABCD40(
	void* instance,
	void* Other)
{
		const gp_Mat &  _Other =*(const gp_Mat *)Other;
	gp_Mat* result = (gp_Mat*)instance;
 	result->Subtract(			
_Other);
}
DECL_EXPORT void* gp_Mat_Subtracted9EABCD40(
	void* instance,
	void* Other)
{
		const gp_Mat &  _Other =*(const gp_Mat *)Other;
	gp_Mat* result = (gp_Mat*)instance;
	return new gp_Mat( 	result->Subtracted(			
_Other));
}
DECL_EXPORT void gp_Mat_Transpose(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
 	result->Transpose();
}
DECL_EXPORT void gp_Mat_SetCross(void* instance, void* value)
{
	gp_Mat* result = (gp_Mat*)instance;
		result->SetCross(*(const gp_XYZ *)value);
}

DECL_EXPORT void gp_Mat_SetDot(void* instance, void* value)
{
	gp_Mat* result = (gp_Mat*)instance;
		result->SetDot(*(const gp_XYZ *)value);
}

DECL_EXPORT void gp_Mat_SetScale(void* instance, double value)
{
	gp_Mat* result = (gp_Mat*)instance;
		result->SetScale(value);
}

DECL_EXPORT double gp_Mat_Determinant(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
	return 	result->Determinant();
}

DECL_EXPORT bool gp_Mat_IsSingular(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
	return 	result->IsSingular();
}

DECL_EXPORT void* gp_Mat_Inverted(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
	return 	new gp_Mat(	result->Inverted());
}

DECL_EXPORT void* gp_Mat_Transposed(void* instance)
{
	gp_Mat* result = (gp_Mat*)instance;
	return 	new gp_Mat(	result->Transposed());
}

DECL_EXPORT void gpMat_Dtor(void* instance)
{
	delete (gp_Mat*)instance;
}
