#ifndef gp_Pnt_H
#define gp_Pnt_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Pnt_Ctor();
extern "C" DECL_EXPORT void* gp_Pnt_Ctor8EE42329(
	void* Coord);
extern "C" DECL_EXPORT void* gp_Pnt_Ctor9282A951(
	double Xp,
	double Yp,
	double Zp);
extern "C" DECL_EXPORT void gp_Pnt_SetCoord69F5FCCD(
	void* instance,
	int Index,
	double Xi);
extern "C" DECL_EXPORT void gp_Pnt_SetCoord9282A951(
	void* instance,
	double Xp,
	double Yp,
	double Zp);
extern "C" DECL_EXPORT double gp_Pnt_CoordE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void gp_Pnt_Coord9282A951(
	void* instance,
	double* Xp,
	double* Yp,
	double* Zp);
extern "C" DECL_EXPORT void* gp_Pnt_Coord(void* instance);
extern "C" DECL_EXPORT void gp_Pnt_BaryCenterED1E08EC(
	void* instance,
	double Alpha,
	void* P,
	double Beta);
extern "C" DECL_EXPORT bool gp_Pnt_IsEqualF0D1E3E6(
	void* instance,
	void* Other,
	double LinearTolerance);
extern "C" DECL_EXPORT double gp_Pnt_Distance9EAECD5B(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Pnt_SquareDistance9EAECD5B(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Pnt_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Pnt_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Pnt_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Pnt_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Pnt_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Pnt_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Pnt_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Pnt_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Pnt_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Pnt_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Pnt_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Pnt_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Pnt_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Pnt_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Pnt_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Pnt_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Pnt_SetX(void* instance, double value);
extern "C" DECL_EXPORT double gp_Pnt_X(void* instance);
extern "C" DECL_EXPORT void gp_Pnt_SetY(void* instance, double value);
extern "C" DECL_EXPORT double gp_Pnt_Y(void* instance);
extern "C" DECL_EXPORT void gp_Pnt_SetZ(void* instance, double value);
extern "C" DECL_EXPORT double gp_Pnt_Z(void* instance);
extern "C" DECL_EXPORT void gp_Pnt_SetXYZ(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Pnt_XYZ(void* instance);
extern "C" DECL_EXPORT void* gp_Pnt_ChangeCoord(void* instance);
extern "C" DECL_EXPORT void gpPnt_Dtor(void* instance);

#endif
