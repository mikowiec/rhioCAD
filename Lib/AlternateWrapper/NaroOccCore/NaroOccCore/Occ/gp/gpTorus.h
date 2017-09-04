#ifndef gp_Torus_H
#define gp_Torus_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Torus_Ctor();
extern "C" DECL_EXPORT void* gp_Torus_Ctor32BF0691(
	void* A3,
	double MajorRadius,
	double MinorRadius);
extern "C" DECL_EXPORT void gp_Torus_UReverse(void* instance);
extern "C" DECL_EXPORT void gp_Torus_VReverse(void* instance);
extern "C" DECL_EXPORT void gp_Torus_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Torus_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Torus_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Torus_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Torus_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Torus_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Torus_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Torus_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Torus_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Torus_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Torus_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Torus_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Torus_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Torus_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Torus_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Torus_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double gp_Torus_Area(void* instance);
extern "C" DECL_EXPORT bool gp_Torus_Direct(void* instance);
extern "C" DECL_EXPORT void gp_Torus_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Torus_Axis(void* instance);
extern "C" DECL_EXPORT void gp_Torus_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Torus_Location(void* instance);
extern "C" DECL_EXPORT void gp_Torus_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Torus_Position(void* instance);
extern "C" DECL_EXPORT void gp_Torus_SetMajorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Torus_MajorRadius(void* instance);
extern "C" DECL_EXPORT void gp_Torus_SetMinorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Torus_MinorRadius(void* instance);
extern "C" DECL_EXPORT double gp_Torus_Volume(void* instance);
extern "C" DECL_EXPORT void* gp_Torus_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Torus_YAxis(void* instance);
extern "C" DECL_EXPORT void gpTorus_Dtor(void* instance);

#endif
