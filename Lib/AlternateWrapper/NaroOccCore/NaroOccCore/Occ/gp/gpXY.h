#ifndef gp_XY_H
#define gp_XY_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_XY_Ctor();
extern "C" DECL_EXPORT void* gp_XY_Ctor9F0E714F(
	double X,
	double Y);
extern "C" DECL_EXPORT void gp_XY_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT void gp_XY_SetCoord9F0E714F(
	void* instance,
	double X,
	double Y);
extern "C" DECL_EXPORT double gp_XY_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_XY_Coord9F0E714F(
	void* instance,
	double* X,
	double* Y);
extern "C" DECL_EXPORT bool gp_XY_IsEqual8CB7F1D(
	void* instance,
	void* Other,
	double Tolerance);
extern "C" DECL_EXPORT void gp_XY_AddE051EF89(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_XY_AddedE051EF89(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_XY_CrossedE051EF89(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_XY_CrossMagnitudeE051EF89(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_XY_CrossSquareMagnitudeE051EF89(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_XY_DivideD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_XY_DividedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT double gp_XY_DotE051EF89(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_XY_MultiplyD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_XY_MultiplyE051EF89(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_XY_Multiply61A06211(
	void* instance,
	void* Matrix);
extern "C" DECL_EXPORT void* gp_XY_MultipliedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_XY_MultipliedE051EF89(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_XY_Multiplied61A06211(
	void* instance,
	void* Matrix);
extern "C" DECL_EXPORT void gp_XY_Normalize(void* instance);
extern "C" DECL_EXPORT void gp_XY_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_XY_SetLinearFormAF67E18B(
	void* instance,
	double A1,
	void* XY1,
	double A2,
	void* XY2);
extern "C" DECL_EXPORT void gp_XY_SetLinearForm5D640BC7(
	void* instance,
	double A1,
	void* XY1,
	double A2,
	void* XY2,
	void* XY3);
extern "C" DECL_EXPORT void gp_XY_SetLinearFormDFE76FF8(
	void* instance,
	double A1,
	void* XY1,
	void* XY2);
extern "C" DECL_EXPORT void gp_XY_SetLinearForm80A5E281(
	void* instance,
	void* XY1,
	void* XY2);
extern "C" DECL_EXPORT void gp_XY_SubtractE051EF89(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void* gp_XY_SubtractedE051EF89(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_XY_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_XY_X(void* instance);
extern "C" DECL_EXPORT void gp_XY_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_XY_Y(void* instance);
extern "C" DECL_EXPORT double gp_XY_Modulus(void* instance);
extern "C" DECL_EXPORT double gp_XY_SquareModulus(void* instance);
extern "C" DECL_EXPORT void* gp_XY_Normalized(void* instance);
extern "C" DECL_EXPORT void* gp_XY_Reversed(void* instance);
extern "C" DECL_EXPORT void gpXY_Dtor(void* instance);

#endif
