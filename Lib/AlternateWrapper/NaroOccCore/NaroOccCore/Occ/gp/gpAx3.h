#ifndef gp_Ax3_H
#define gp_Ax3_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Ax3_Ctor();
extern "C" DECL_EXPORT void* gp_Ax3_Ctor7895386A(
	void* A);
extern "C" DECL_EXPORT void* gp_Ax3_CtorF36E9D55(
	void* P,
	void* N,
	void* Vx);
extern "C" DECL_EXPORT void* gp_Ax3_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT void gp_Ax3_XReverse(void* instance);
extern "C" DECL_EXPORT void gp_Ax3_YReverse(void* instance);
extern "C" DECL_EXPORT void gp_Ax3_ZReverse(void* instance);
extern "C" DECL_EXPORT double gp_Ax3_Angle1B3CAD05(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool gp_Ax3_IsCoplanar32BF0691(
	void* instance,
	void* Other,
	double LinearTolerance,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Ax3_IsCoplanar5FECE277(
	void* instance,
	void* A1,
	double LinearTolerance,
	double AngularTolerance);
extern "C" DECL_EXPORT void gp_Ax3_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Ax3_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Ax3_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Ax3_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Ax3_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Ax3_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Ax3_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Ax3_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Ax3_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Ax3_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Ax3_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Ax3_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Ax3_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Ax3_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Ax3_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Ax3_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Ax3_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax3_Axis(void* instance);
extern "C" DECL_EXPORT void* gp_Ax3_Ax2(void* instance);
extern "C" DECL_EXPORT void gp_Ax3_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax3_Direction(void* instance);
extern "C" DECL_EXPORT void gp_Ax3_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax3_Location(void* instance);
extern "C" DECL_EXPORT void gp_Ax3_SetXDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax3_XDirection(void* instance);
extern "C" DECL_EXPORT void gp_Ax3_SetYDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax3_YDirection(void* instance);
extern "C" DECL_EXPORT bool gp_Ax3_Direct(void* instance);
extern "C" DECL_EXPORT void gpAx3_Dtor(void* instance);

#endif
