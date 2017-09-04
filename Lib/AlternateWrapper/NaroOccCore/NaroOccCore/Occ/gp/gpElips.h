#ifndef gp_Elips_H
#define gp_Elips_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Elips_Ctor();
extern "C" DECL_EXPORT void* gp_Elips_CtorB1A3BD2A(
	void* A2,
	double MajorRadius,
	double MinorRadius);
extern "C" DECL_EXPORT void gp_Elips_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Elips_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Elips_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Elips_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Elips_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Elips_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Elips_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Elips_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Elips_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Elips_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Elips_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Elips_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Elips_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Elips_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Elips_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Elips_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double gp_Elips_Area(void* instance);
extern "C" DECL_EXPORT void gp_Elips_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Elips_Axis(void* instance);
extern "C" DECL_EXPORT void* gp_Elips_Directrix1(void* instance);
extern "C" DECL_EXPORT void* gp_Elips_Directrix2(void* instance);
extern "C" DECL_EXPORT double gp_Elips_Eccentricity(void* instance);
extern "C" DECL_EXPORT double gp_Elips_Focal(void* instance);
extern "C" DECL_EXPORT void* gp_Elips_Focus1(void* instance);
extern "C" DECL_EXPORT void* gp_Elips_Focus2(void* instance);
extern "C" DECL_EXPORT void gp_Elips_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Elips_Location(void* instance);
extern "C" DECL_EXPORT void gp_Elips_SetMajorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Elips_MajorRadius(void* instance);
extern "C" DECL_EXPORT void gp_Elips_SetMinorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Elips_MinorRadius(void* instance);
extern "C" DECL_EXPORT double gp_Elips_Parameter(void* instance);
extern "C" DECL_EXPORT void gp_Elips_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Elips_Position(void* instance);
extern "C" DECL_EXPORT void* gp_Elips_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Elips_YAxis(void* instance);
extern "C" DECL_EXPORT void gpElips_Dtor(void* instance);

#endif
