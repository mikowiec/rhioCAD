#ifndef gp_Pnt2d_H
#define gp_Pnt2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Pnt2d_Ctor();
extern "C" DECL_EXPORT void* gp_Pnt2d_CtorE051EF89(
	void* Coord);
extern "C" DECL_EXPORT void* gp_Pnt2d_Ctor9F0E714F(
	double Xp,
	double Yp);
extern "C" DECL_EXPORT void gp_Pnt2d_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT void gp_Pnt2d_SetCoord9F0E714F(
	void* instance,
	double Xp,
	double Yp);
extern "C" DECL_EXPORT double gp_Pnt2d_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_Pnt2d_Coord9F0E714F(
	void* instance,
	double* Xp,
	double* Yp);
extern "C" DECL_EXPORT void* gp_Pnt2d_Coord(void* instance);
extern "C" DECL_EXPORT bool gp_Pnt2d_IsEqualE3062737(
	void* instance,
	void* Other,
	double LinearTolerance);
extern "C" DECL_EXPORT double gp_Pnt2d_Distance6203658C(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Pnt2d_SquareDistance6203658C(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Pnt2d_Mirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Pnt2d_Mirrored6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Pnt2d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Pnt2d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Pnt2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void* gp_Pnt2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Pnt2d_ScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Pnt2d_ScaledE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Pnt2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Pnt2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Pnt2d_Translate5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Pnt2d_Translated5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Pnt2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Pnt2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Pnt2d_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_Pnt2d_X(void* instance);
extern "C" DECL_EXPORT void gp_Pnt2d_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_Pnt2d_Y(void* instance);
extern "C" DECL_EXPORT void gp_Pnt2d_SetXY(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Pnt2d_XY(void* instance);
extern "C" DECL_EXPORT void* gp_Pnt2d_ChangeCoord(void* instance);
extern "C" DECL_EXPORT void gpPnt2d_Dtor(void* instance);

#endif
