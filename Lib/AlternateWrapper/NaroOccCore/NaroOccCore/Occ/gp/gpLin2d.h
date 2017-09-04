#ifndef gp_Lin2d_H
#define gp_Lin2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Lin2d_Ctor();
extern "C" DECL_EXPORT void* gp_Lin2d_Ctor90E1386A(
	void* A);
extern "C" DECL_EXPORT void* gp_Lin2d_Ctor2E9C6BD1(
	void* P,
	void* V);
extern "C" DECL_EXPORT void* gp_Lin2d_Ctor9282A951(
	double A,
	double B,
	double C);
extern "C" DECL_EXPORT void gp_Lin2d_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Lin2d_Coefficients9282A951(
	void* instance,
	double* A,
	double* B,
	double* C);
extern "C" DECL_EXPORT double gp_Lin2d_Angle5D0C667A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool gp_Lin2d_ContainsE3062737(
	void* instance,
	void* P,
	double LinearTolerance);
extern "C" DECL_EXPORT double gp_Lin2d_Distance6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Lin2d_Distance5D0C667A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Lin2d_SquareDistance6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Lin2d_SquareDistance5D0C667A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Lin2d_Normal6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Lin2d_Mirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Lin2d_Mirrored6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Lin2d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Lin2d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Lin2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void* gp_Lin2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Lin2d_ScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Lin2d_ScaledE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Lin2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Lin2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Lin2d_Translate5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Lin2d_Translated5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Lin2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Lin2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Lin2d_Reversed(void* instance);
extern "C" DECL_EXPORT void gp_Lin2d_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Lin2d_Direction(void* instance);
extern "C" DECL_EXPORT void gp_Lin2d_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Lin2d_Location(void* instance);
extern "C" DECL_EXPORT void gp_Lin2d_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Lin2d_Position(void* instance);
extern "C" DECL_EXPORT void gpLin2d_Dtor(void* instance);

#endif
