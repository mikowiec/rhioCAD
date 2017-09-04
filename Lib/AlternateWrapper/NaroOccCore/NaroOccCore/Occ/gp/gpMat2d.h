#ifndef gp_Mat2d_H
#define gp_Mat2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Mat2d_Ctor();
extern "C" DECL_EXPORT void* gp_Mat2d_Ctor80A5E281(
	void* Col1,
	void* Col2);
extern "C" DECL_EXPORT void gp_Mat2d_SetCol1FC91E6F(
	void* instance,
	int Col,
	void* Value);
extern "C" DECL_EXPORT void gp_Mat2d_SetCols80A5E281(
	void* instance,
	void* Col1,
	void* Col2);
extern "C" DECL_EXPORT void gp_Mat2d_SetDiagonal9F0E714F(
	void* instance,
	double X1,
	double X2);
extern "C" DECL_EXPORT void gp_Mat2d_SetIdentity(void* instance);
extern "C" DECL_EXPORT void gp_Mat2d_SetRow1FC91E6F(
	void* instance,
	int Row,
	void* Value);
extern "C" DECL_EXPORT void gp_Mat2d_SetRows80A5E281(
	void* instance,
	void* Row1,
	void* Row2);
extern "C" DECL_EXPORT void gp_Mat2d_SetValue83917674(
	void* instance,
	int Row,
	int Col,
	double Value);
extern "C" DECL_EXPORT void* gp_Mat2d_ColumnE8219145(
	void* instance,
	int Col);
extern "C" DECL_EXPORT void* gp_Mat2d_Diagonal(void* instance);
extern "C" DECL_EXPORT void* gp_Mat2d_RowE8219145(
	void* instance,
	int Row);
extern "C" DECL_EXPORT double gp_Mat2d_Value5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT double gp_Mat2d_ChangeValue5107F6FE(
	void* instance,
	int Row,
	int Col);
extern "C" DECL_EXPORT void gp_Mat2d_Add61A06211(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Mat2d_Added61A06211(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat2d_DivideD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_Mat2d_DividedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Mat2d_Invert(void* instance);
extern "C" DECL_EXPORT void* gp_Mat2d_Multiplied61A06211(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat2d_Multiply61A06211(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat2d_PreMultiply61A06211(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Mat2d_MultipliedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Mat2d_MultiplyD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Mat2d_PowerE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* gp_Mat2d_PoweredE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void gp_Mat2d_Subtract61A06211(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Mat2d_Subtracted61A06211(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Mat2d_Transpose(void* instance);
extern "C" DECL_EXPORT void gp_Mat2d_SetRotation(void* instance, double value);
extern "C" DECL_EXPORT void gp_Mat2d_SetScale(void* instance, double value);
extern "C" DECL_EXPORT double gp_Mat2d_Determinant(void* instance);
extern "C" DECL_EXPORT bool gp_Mat2d_IsSingular(void* instance);
extern "C" DECL_EXPORT void* gp_Mat2d_Inverted(void* instance);
extern "C" DECL_EXPORT void* gp_Mat2d_Transposed(void* instance);
extern "C" DECL_EXPORT void gpMat2d_Dtor(void* instance);

#endif
