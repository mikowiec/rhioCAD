#ifndef gp_XYZ_H
#define gp_XYZ_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_XYZ_Ctor();
extern "C" DECL_EXPORT void* gp_XYZ_Ctor9282A951(
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void gp_XYZ_SetCoord9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void gp_XYZ_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT double gp_XYZ_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_XYZ_Coord9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT bool gp_XYZ_IsEqualAC21764D(
	void* instance,
	void* Other,
	double Tolerance);
extern "C" DECL_EXPORT void gp_XYZ_Add8EE42329(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_XYZ_Added8EE42329(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_XYZ_Cross8EE42329(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void* gp_XYZ_Crossed8EE42329(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_XYZ_CrossMagnitude8EE42329(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_XYZ_CrossSquareMagnitude8EE42329(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_XYZ_CrossCross610ADE9D(
	void* instance,
	void* Coord1,
	void* Coord2);
extern "C" DECL_EXPORT void* gp_XYZ_CrossCrossed610ADE9D(
	void* instance,
	void* Coord1,
	void* Coord2);
extern "C" DECL_EXPORT void gp_XYZ_DivideD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_XYZ_DividedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT double gp_XYZ_Dot8EE42329(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_XYZ_DotCross610ADE9D(
	void* instance,
	void* Coord1,
	void* Coord2);
extern "C" DECL_EXPORT void gp_XYZ_MultiplyD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void gp_XYZ_Multiply8EE42329(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_XYZ_Multiply9EABCD40(
	void* instance,
	void* Matrix);
extern "C" DECL_EXPORT void* gp_XYZ_MultipliedD82819F3(
	void* instance,
	double Scalar);
extern "C" DECL_EXPORT void* gp_XYZ_Multiplied8EE42329(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_XYZ_Multiplied9EABCD40(
	void* instance,
	void* Matrix);
extern "C" DECL_EXPORT void gp_XYZ_Normalize(void* instance);
extern "C" DECL_EXPORT void gp_XYZ_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_XYZ_Subtract8EE42329(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void* gp_XYZ_Subtracted8EE42329(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT void gp_XYZ_SetLinearFormF220B60(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2,
	double A3,
	void* XYZ3,
	void* XYZ4);
extern "C" DECL_EXPORT void gp_XYZ_SetLinearFormF4A81B86(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2,
	double A3,
	void* XYZ3);
extern "C" DECL_EXPORT void gp_XYZ_SetLinearFormD61C07A0(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2,
	void* XYZ3);
extern "C" DECL_EXPORT void gp_XYZ_SetLinearForm6062D8AE(
	void* instance,
	double A1,
	void* XYZ1,
	double A2,
	void* XYZ2);
extern "C" DECL_EXPORT void gp_XYZ_SetLinearForm628B7A49(
	void* instance,
	double A1,
	void* XYZ1,
	void* XYZ2);
extern "C" DECL_EXPORT void gp_XYZ_SetLinearForm610ADE9D(
	void* instance,
	void* XYZ1,
	void* XYZ2);
extern "C" DECL_EXPORT void gp_XYZ_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_XYZ_X(void* instance);
extern "C" DECL_EXPORT void gp_XYZ_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_XYZ_Y(void* instance);
extern "C" DECL_EXPORT void gp_XYZ_SetZ(void* instance, double value);
extern "C" DECL_EXPORT double gp_XYZ_Z(void* instance);
extern "C" DECL_EXPORT double gp_XYZ_Modulus(void* instance);
extern "C" DECL_EXPORT double gp_XYZ_SquareModulus(void* instance);
extern "C" DECL_EXPORT void* gp_XYZ_Normalized(void* instance);
extern "C" DECL_EXPORT void* gp_XYZ_Reversed(void* instance);
extern "C" DECL_EXPORT void gpXYZ_Dtor(void* instance);

#endif
