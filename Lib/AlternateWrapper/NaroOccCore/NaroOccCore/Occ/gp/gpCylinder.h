#ifndef gp_Cylinder_H
#define gp_Cylinder_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Cylinder_Ctor();
extern "C" DECL_EXPORT void* gp_Cylinder_Ctor5C6D1CB8(
	void* A3,
	double Radius);
extern "C" DECL_EXPORT void gp_Cylinder_UReverse(void* instance);
extern "C" DECL_EXPORT void gp_Cylinder_VReverse(void* instance);
extern "C" DECL_EXPORT void gp_Cylinder_CoefficientsCFCEAB36(
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
extern "C" DECL_EXPORT void gp_Cylinder_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Cylinder_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Cylinder_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Cylinder_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Cylinder_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Cylinder_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Cylinder_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Cylinder_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Cylinder_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Cylinder_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Cylinder_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Cylinder_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Cylinder_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Cylinder_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Cylinder_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Cylinder_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT bool gp_Cylinder_Direct(void* instance);
extern "C" DECL_EXPORT void gp_Cylinder_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Cylinder_Axis(void* instance);
extern "C" DECL_EXPORT void gp_Cylinder_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Cylinder_Location(void* instance);
extern "C" DECL_EXPORT void gp_Cylinder_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Cylinder_Position(void* instance);
extern "C" DECL_EXPORT void gp_Cylinder_SetRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Cylinder_Radius(void* instance);
extern "C" DECL_EXPORT void* gp_Cylinder_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Cylinder_YAxis(void* instance);
extern "C" DECL_EXPORT void gpCylinder_Dtor(void* instance);

#endif
