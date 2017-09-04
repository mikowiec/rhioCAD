#ifndef gp_Cone_H
#define gp_Cone_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Cone_Ctor();
extern "C" DECL_EXPORT void* gp_Cone_Ctor32BF0691(
	void* A3,
	double Ang,
	double Radius);
extern "C" DECL_EXPORT void gp_Cone_UReverse(void* instance);
extern "C" DECL_EXPORT void gp_Cone_VReverse(void* instance);
extern "C" DECL_EXPORT void gp_Cone_CoefficientsCFCEAB36(
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
extern "C" DECL_EXPORT void gp_Cone_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Cone_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Cone_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Cone_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Cone_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Cone_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Cone_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Cone_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Cone_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Cone_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Cone_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Cone_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Cone_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Cone_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Cone_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Cone_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Cone_SetRadius(void* instance, double value);
extern "C" DECL_EXPORT void* gp_Cone_Apex(void* instance);
extern "C" DECL_EXPORT bool gp_Cone_Direct(void* instance);
extern "C" DECL_EXPORT void gp_Cone_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Cone_Axis(void* instance);
extern "C" DECL_EXPORT void gp_Cone_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Cone_Location(void* instance);
extern "C" DECL_EXPORT void gp_Cone_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Cone_Position(void* instance);
extern "C" DECL_EXPORT double gp_Cone_RefRadius(void* instance);
extern "C" DECL_EXPORT void gp_Cone_SetSemiAngle(void* instance, double value);
extern "C" DECL_EXPORT double gp_Cone_SemiAngle(void* instance);
extern "C" DECL_EXPORT void* gp_Cone_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Cone_YAxis(void* instance);
extern "C" DECL_EXPORT void gpCone_Dtor(void* instance);

#endif
