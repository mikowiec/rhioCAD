#ifndef gp_Dir2d_H
#define gp_Dir2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Dir2d_Ctor();
extern "C" DECL_EXPORT void* gp_Dir2d_Ctor5E4E66E7(
	void* V);
extern "C" DECL_EXPORT void* gp_Dir2d_CtorE051EF89(
	void* Coord);
extern "C" DECL_EXPORT void* gp_Dir2d_Ctor9F0E714F(
	double Xv,
	double Yv);
extern "C" DECL_EXPORT void gp_Dir2d_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT void gp_Dir2d_SetCoord9F0E714F(
	void* instance,
	double Xv,
	double Yv);
extern "C" DECL_EXPORT double gp_Dir2d_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_Dir2d_Coord9F0E714F(
	void* instance,
	double* Xv,
	double* Yv);
extern "C" DECL_EXPORT bool gp_Dir2d_IsEqualD488E15(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Dir2d_IsNormalD488E15(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Dir2d_IsOppositeD488E15(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Dir2d_IsParallelD488E15(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT double gp_Dir2d_Angle92BBA68E(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Dir2d_Crossed92BBA68E(
	void* instance,
	void* Right);
extern "C" DECL_EXPORT double gp_Dir2d_Dot92BBA68E(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Dir2d_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Dir2d_Mirror92BBA68E(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Dir2d_Mirrored92BBA68E(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Dir2d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Dir2d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Dir2d_RotateD82819F3(
	void* instance,
	double Ang);
extern "C" DECL_EXPORT void* gp_Dir2d_RotatedD82819F3(
	void* instance,
	double Ang);
extern "C" DECL_EXPORT void gp_Dir2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Dir2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Dir2d_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_Dir2d_X(void* instance);
extern "C" DECL_EXPORT void gp_Dir2d_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_Dir2d_Y(void* instance);
extern "C" DECL_EXPORT void gp_Dir2d_SetXY(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Dir2d_XY(void* instance);
extern "C" DECL_EXPORT void* gp_Dir2d_Reversed(void* instance);
extern "C" DECL_EXPORT void gpDir2d_Dtor(void* instance);

#endif
