#ifndef gp_Sphere_H
#define gp_Sphere_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Sphere_Ctor();
extern "C" DECL_EXPORT void* gp_Sphere_Ctor5C6D1CB8(
	void* A3,
	double Radius);
extern "C" DECL_EXPORT void gp_Sphere_CoefficientsCFCEAB36(
	void* instance,
	double* A1,
	double* A2,
	double* A3,
	double* B1,
	double* B2,
	double* B3,
	double* C1,
	double* C2,
	double* C3,
	double* D);
extern "C" DECL_EXPORT void gp_Sphere_UReverse(void* instance);
extern "C" DECL_EXPORT void gp_Sphere_VReverse(void* instance);
extern "C" DECL_EXPORT void gp_Sphere_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Sphere_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Sphere_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Sphere_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Sphere_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Sphere_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Sphere_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Sphere_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Sphere_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Sphere_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Sphere_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Sphere_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Sphere_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Sphere_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Sphere_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Sphere_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double gp_Sphere_Area(void* instance);
extern "C" DECL_EXPORT bool gp_Sphere_Direct(void* instance);
extern "C" DECL_EXPORT void gp_Sphere_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Sphere_Location(void* instance);
extern "C" DECL_EXPORT void gp_Sphere_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Sphere_Position(void* instance);
extern "C" DECL_EXPORT void gp_Sphere_SetRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Sphere_Radius(void* instance);
extern "C" DECL_EXPORT double gp_Sphere_Volume(void* instance);
extern "C" DECL_EXPORT void* gp_Sphere_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Sphere_YAxis(void* instance);
extern "C" DECL_EXPORT void gpSphere_Dtor(void* instance);

#endif
