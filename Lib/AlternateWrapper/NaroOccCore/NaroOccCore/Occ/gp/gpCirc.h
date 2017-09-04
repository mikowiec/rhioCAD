#ifndef gp_Circ_H
#define gp_Circ_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Circ_Ctor();
extern "C" DECL_EXPORT void* gp_Circ_Ctor673FA07D(
	void* A2,
	double Radius);
extern "C" DECL_EXPORT double gp_Circ_Distance9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Circ_SquareDistance9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT bool gp_Circ_ContainsF0D1E3E6(
	void* instance,
	void* P,
	double LinearTolerance);
extern "C" DECL_EXPORT void gp_Circ_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Circ_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Circ_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Circ_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Circ_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Circ_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Circ_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Circ_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Circ_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Circ_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Circ_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Circ_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Circ_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Circ_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Circ_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Circ_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double gp_Circ_Area(void* instance);
extern "C" DECL_EXPORT void gp_Circ_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Circ_Axis(void* instance);
extern "C" DECL_EXPORT double gp_Circ_Length(void* instance);
extern "C" DECL_EXPORT void gp_Circ_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Circ_Location(void* instance);
extern "C" DECL_EXPORT void gp_Circ_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Circ_Position(void* instance);
extern "C" DECL_EXPORT void gp_Circ_SetRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Circ_Radius(void* instance);
extern "C" DECL_EXPORT void* gp_Circ_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Circ_YAxis(void* instance);
extern "C" DECL_EXPORT void gpCirc_Dtor(void* instance);

#endif
