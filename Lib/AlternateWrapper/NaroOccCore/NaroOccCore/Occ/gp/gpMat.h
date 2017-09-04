#ifndef gp_Mat_H
#define gp_Mat_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Mat_Ctor();
extern "C" DECL_EXPORT void* gp_Mat_CtorE32698D4(
	double a11,
	double a12,
	double a13,
	double a21,
	double a22,
	double a23,
	double a31,
	double a32,
	double a33);
extern "C" DECL_EXPORT void* gp_Mat_Ctor7DAAC47(
	void* Col1,
	void* Col2,
	void* Col3);
extern "C" DECL_EXPORT void gp_Mat_SetCol20231E6F(
	void* instance,
	int Col,
	void* Value);
extern "C" DECL_EXPORT void gp_Mat_SetCols7DAAC47(
	void* instance,
	void* Col1,
	void* Col2,
	void* Col3);
extern "C" DECL_EXPORT void gp_Mat_SetDiagonal9282A951(
	void* instance,
	double X1,
	double X2,
	double X3);
extern "C" DECL_EXPORT void gp_Mat_SetIdentity(void* instance);
extern "C" DECL_EXPORT void gp_Mat_SetRotationAC21764D(
	void* instance,
	void* Axis,
	double Ang);
extern "C" DECL_EXPORT void gp_Mat_SetRow20231E6F(
	void* instance,
	int Row,
	void* Value);
extern "C" DECL_EXPORT void gp_Mat_SetRows7DAAC47(
	void* instance,
	void* Row1,
	void* Row2,
	void* Row3);
extern "C" DECL_EXPORT void gp_Mat_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value);
extern "C" DECL_EXPORT void* gp_Mat_ColumnE8219145(
	void* instance,
	int Col);
extern "C" DECL_EXPORT void* gp_Mat_Diagonal(void* instance);
extern "C" DECL_EXPORT void* gp_Mat_RowE8219145(
	void* instance,
	int Row);
extern "C" DECL_EXPORT double gp_Mat_Value5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT double gp_Mat_ChangeValue5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT void gp_Mat_Add9EABCD40(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Mat_Added9EABCD40(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat_DivideD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_Mat_DividedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Mat_Invert(void* instance);
extern "C" DECL_EXPORT void* gp_Mat_Multiplied9EABCD40(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat_Multiply9EABCD40(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat_PreMultiply9EABCD40(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Mat_MultipliedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Mat_MultiplyD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Mat_PowerE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* gp_Mat_PoweredE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void gp_Mat_Subtract9EABCD40(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Mat_Subtracted9EABCD40(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat_Transpose(void* instance);
extern "C" DECL_EXPORT void gp_Mat_SetCross(void* instance, void* value);
extern "C" DECL_EXPORT void gp_Mat_SetDot(void* instance, void* value);
extern "C" DECL_EXPORT void gp_Mat_SetScale(void* instance, double value);
extern "C" DECL_EXPORT double gp_Mat_Determinant(void* instance);
extern "C" DECL_EXPORT bool gp_Mat_IsSingular(void* instance);
extern "C" DECL_EXPORT void* gp_Mat_Inverted(void* instance);
extern "C" DECL_EXPORT void* gp_Mat_Transposed(void* instance);
extern "C" DECL_EXPORT void gpMat_Dtor(void* instance);

#endif
