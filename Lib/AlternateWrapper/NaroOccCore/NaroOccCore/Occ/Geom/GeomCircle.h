#ifndef Geom_Circle_H
#define Geom_Circle_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_Circle_Ctor727811A8(
	void* C);
extern "C" DECL_EXPORT void* Geom_Circle_Ctor673FA07D(
	void* A2,
	double Radius);
extern "C" DECL_EXPORT double Geom_Circle_ReversedParameterD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void Geom_Circle_D053A5A2C1(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void Geom_Circle_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1);
extern "C" DECL_EXPORT void Geom_Circle_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void Geom_Circle_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* Geom_Circle_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT void Geom_Circle_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_Circle_SetCirc(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Circle_Circ(void* instance);
extern "C" DECL_EXPORT void Geom_Circle_SetRadius(void* instance, double value);
extern "C" DECL_EXPORT double Geom_Circle_Radius(void* instance);
extern "C" DECL_EXPORT double Geom_Circle_Eccentricity(void* instance);
extern "C" DECL_EXPORT double Geom_Circle_FirstParameter(void* instance);
extern "C" DECL_EXPORT double Geom_Circle_LastParameter(void* instance);
extern "C" DECL_EXPORT bool Geom_Circle_IsClosed(void* instance);
extern "C" DECL_EXPORT bool Geom_Circle_IsPeriodic(void* instance);
extern "C" DECL_EXPORT void* Geom_Circle_Copy(void* instance);
extern "C" DECL_EXPORT void GeomCircle_Dtor(void* instance);

#endif
