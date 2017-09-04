#ifndef gp_Ax1_H
#define gp_Ax1_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Ax1_Ctor();
extern "C" DECL_EXPORT void* gp_Ax1_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT bool gp_Ax1_IsCoaxial5FECE277(
	void* instance,
	void* Other,
	double AngularTolerance,
	double LinearTolerance);
extern "C" DECL_EXPORT bool gp_Ax1_IsNormal827CB19A(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Ax1_IsOpposite827CB19A(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Ax1_IsParallel827CB19A(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT double gp_Ax1_Angle608B963B(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Ax1_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Ax1_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Ax1_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Ax1_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Ax1_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Ax1_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Ax1_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Ax1_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Ax1_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Ax1_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Ax1_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Ax1_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Ax1_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Ax1_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Ax1_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Ax1_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Ax1_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Ax1_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax1_Direction(void* instance);
extern "C" DECL_EXPORT void gp_Ax1_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax1_Location(void* instance);
extern "C" DECL_EXPORT void* gp_Ax1_Reversed(void* instance);
extern "C" DECL_EXPORT void gpAx1_Dtor(void* instance);

#endif
