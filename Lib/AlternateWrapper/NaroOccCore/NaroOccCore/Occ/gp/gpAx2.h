#ifndef gp_Ax2_H
#define gp_Ax2_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Ax2_Ctor();
extern "C" DECL_EXPORT void* gp_Ax2_CtorF36E9D55(
	void* P,
	void* N,
	void* Vx);
extern "C" DECL_EXPORT void* gp_Ax2_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT double gp_Ax2_Angle7895386A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool gp_Ax2_IsCoplanarB1A3BD2A(
	void* instance,
	void* Other,
	double LinearTolerance,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Ax2_IsCoplanar5FECE277(
	void* instance,
	void* A1,
	double LinearTolerance,
	double AngularTolerance);
extern "C" DECL_EXPORT void gp_Ax2_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Ax2_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Ax2_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Ax2_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Ax2_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Ax2_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Ax2_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Ax2_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Ax2_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Ax2_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Ax2_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Ax2_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Ax2_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Ax2_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Ax2_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Ax2_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Ax2_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax2_Axis(void* instance);
extern "C" DECL_EXPORT void gp_Ax2_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax2_Direction(void* instance);
extern "C" DECL_EXPORT void gp_Ax2_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax2_Location(void* instance);
extern "C" DECL_EXPORT void gp_Ax2_SetXDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax2_XDirection(void* instance);
extern "C" DECL_EXPORT void gp_Ax2_SetYDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax2_YDirection(void* instance);
extern "C" DECL_EXPORT void gpAx2_Dtor(void* instance);

#endif
