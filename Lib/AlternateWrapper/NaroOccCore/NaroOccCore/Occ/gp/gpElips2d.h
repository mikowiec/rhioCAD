#ifndef gp_Elips2d_H
#define gp_Elips2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Elips2d_Ctor();
extern "C" DECL_EXPORT void* gp_Elips2d_CtorEB7AC69(
	void* MajorAxis,
	double MajorRadius,
	double MinorRadius,
	bool Sense);
extern "C" DECL_EXPORT void* gp_Elips2d_Ctor2C61CEDF(
	void* A,
	double MajorRadius,
	double MinorRadius);
extern "C" DECL_EXPORT void gp_Elips2d_CoefficientsBC7A5786(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D,
	double* E,
	double* F);
extern "C" DECL_EXPORT void gp_Elips2d_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Elips2d_Mirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Elips2d_Mirrored6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Elips2d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Elips2d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Elips2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void* gp_Elips2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Elips2d_ScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Elips2d_ScaledE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Elips2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Elips2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Elips2d_Translate5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Elips2d_Translated5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Elips2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Elips2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double gp_Elips2d_Area(void* instance);
extern "C" DECL_EXPORT void* gp_Elips2d_Directrix1(void* instance);
extern "C" DECL_EXPORT void* gp_Elips2d_Directrix2(void* instance);
extern "C" DECL_EXPORT double gp_Elips2d_Eccentricity(void* instance);
extern "C" DECL_EXPORT double gp_Elips2d_Focal(void* instance);
extern "C" DECL_EXPORT void* gp_Elips2d_Focus1(void* instance);
extern "C" DECL_EXPORT void* gp_Elips2d_Focus2(void* instance);
extern "C" DECL_EXPORT void gp_Elips2d_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Elips2d_Location(void* instance);
extern "C" DECL_EXPORT void gp_Elips2d_SetMajorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Elips2d_MajorRadius(void* instance);
extern "C" DECL_EXPORT void gp_Elips2d_SetMinorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Elips2d_MinorRadius(void* instance);
extern "C" DECL_EXPORT double gp_Elips2d_Parameter(void* instance);
extern "C" DECL_EXPORT void gp_Elips2d_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Elips2d_Axis(void* instance);
extern "C" DECL_EXPORT void gp_Elips2d_SetXAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Elips2d_XAxis(void* instance);
extern "C" DECL_EXPORT void gp_Elips2d_SetYAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Elips2d_YAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Elips2d_Reversed(void* instance);
extern "C" DECL_EXPORT bool gp_Elips2d_IsDirect(void* instance);
extern "C" DECL_EXPORT void gpElips2d_Dtor(void* instance);

#endif
