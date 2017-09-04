#ifndef gp_Vec2d_H
#define gp_Vec2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Vec2d_Ctor();
extern "C" DECL_EXPORT void* gp_Vec2d_Ctor92BBA68E(
	void* V);
extern "C" DECL_EXPORT void* gp_Vec2d_CtorE051EF89(
	void* Coord);
extern "C" DECL_EXPORT void* gp_Vec2d_Ctor9F0E714F(
	double Xv,
	double Yv);
extern "C" DECL_EXPORT void* gp_Vec2d_Ctor5F54ADE3(
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Vec2d_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT void gp_Vec2d_SetCoord9F0E714F(
	void* instance,
	double Xv,
	double Yv);
extern "C" DECL_EXPORT double gp_Vec2d_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_Vec2d_Coord9F0E714F(
	void* instance,
	double* Xv,
	double* Yv);
extern "C" DECL_EXPORT bool gp_Vec2d_IsEqual1F89D6DF(
	void* instance,
	void* Other,
	double LinearTolerance,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Vec2d_IsNormalC1B831C6(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Vec2d_IsOppositeC1B831C6(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Vec2d_IsParallelC1B831C6(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT double gp_Vec2d_Angle5E4E66E7(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Vec2d_Add5E4E66E7(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Vec2d_Added5E4E66E7(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Vec2d_Crossed5E4E66E7(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_Vec2d_CrossMagnitude5E4E66E7(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_Vec2d_CrossSquareMagnitude5E4E66E7(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_Vec2d_DivideD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_Vec2d_DividedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT double gp_Vec2d_Dot5E4E66E7(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Vec2d_MultiplyD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_Vec2d_MultipliedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_Vec2d_Normalize(void* instance);
extern "C" DECL_EXPORT void gp_Vec2d_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Vec2d_Subtract5E4E66E7(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void* gp_Vec2d_Subtracted5E4E66E7(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_Vec2d_SetLinearForm98ABEE74(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void gp_Vec2d_SetLinearForm39A7F68A(
	void* instance,
	double A1,
	void* V1,
	double A2,
	void* V2);
extern "C" DECL_EXPORT void gp_Vec2d_SetLinearForm7874D091(
	void* instance,
	double A1,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void gp_Vec2d_SetLinearFormE2FF8249(
	void* instance,
	void* Left,
	void* Right);
extern "C" DECL_EXPORT void gp_Vec2d_Mirror5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Vec2d_Mirrored5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Vec2d_Mirror90E1386A(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Vec2d_Mirrored90E1386A(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Vec2d_RotateD82819F3(
	void* instance,
	double Ang);
extern "C" DECL_EXPORT void* gp_Vec2d_RotatedD82819F3(
	void* instance,
	double Ang);
extern "C" DECL_EXPORT void gp_Vec2d_ScaleD82819F3(
	void* instance,
	double S);
extern "C" DECL_EXPORT void* gp_Vec2d_ScaledD82819F3(
	void* instance,
	double S);
extern "C" DECL_EXPORT void gp_Vec2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Vec2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Vec2d_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_Vec2d_X(void* instance);
extern "C" DECL_EXPORT void gp_Vec2d_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_Vec2d_Y(void* instance);
extern "C" DECL_EXPORT void gp_Vec2d_SetXY(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Vec2d_XY(void* instance);
extern "C" DECL_EXPORT double gp_Vec2d_Magnitude(void* instance);
extern "C" DECL_EXPORT double gp_Vec2d_SquareMagnitude(void* instance);
extern "C" DECL_EXPORT void* gp_Vec2d_Normalized(void* instance);
extern "C" DECL_EXPORT void* gp_Vec2d_Reversed(void* instance);
extern "C" DECL_EXPORT void gpVec2d_Dtor(void* instance);

#endif
