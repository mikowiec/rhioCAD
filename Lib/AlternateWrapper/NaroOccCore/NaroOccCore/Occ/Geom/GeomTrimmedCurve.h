#ifndef Geom_TrimmedCurve_H
#define Geom_TrimmedCurve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_TrimmedCurve_Ctor39C18CEB(
	void* C,
	double U1,
	double U2,
	bool Sense);
extern "C" DECL_EXPORT void Geom_TrimmedCurve_Reverse(void* instance);
extern "C" DECL_EXPORT double Geom_TrimmedCurve_ReversedParameterD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void Geom_TrimmedCurve_SetTrim947352B1(
	void* instance,
	double U1,
	double U2,
	bool Sense);
extern "C" DECL_EXPORT bool Geom_TrimmedCurve_IsCNE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void Geom_TrimmedCurve_D053A5A2C1(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void Geom_TrimmedCurve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1);
extern "C" DECL_EXPORT void Geom_TrimmedCurve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void Geom_TrimmedCurve_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* Geom_TrimmedCurve_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT void Geom_TrimmedCurve_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT double Geom_TrimmedCurve_TransformedParameter9B95D054(
	void* instance,
	double U,
	void* T);
extern "C" DECL_EXPORT double Geom_TrimmedCurve_ParametricTransformation72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* Geom_TrimmedCurve_BasisCurve(void* instance);
extern "C" DECL_EXPORT int Geom_TrimmedCurve_Continuity(void* instance);
extern "C" DECL_EXPORT void* Geom_TrimmedCurve_EndPoint(void* instance);
extern "C" DECL_EXPORT double Geom_TrimmedCurve_FirstParameter(void* instance);
extern "C" DECL_EXPORT bool Geom_TrimmedCurve_IsClosed(void* instance);
extern "C" DECL_EXPORT bool Geom_TrimmedCurve_IsPeriodic(void* instance);
extern "C" DECL_EXPORT double Geom_TrimmedCurve_Period(void* instance);
extern "C" DECL_EXPORT double Geom_TrimmedCurve_LastParameter(void* instance);
extern "C" DECL_EXPORT void* Geom_TrimmedCurve_StartPoint(void* instance);
extern "C" DECL_EXPORT void* Geom_TrimmedCurve_Copy(void* instance);
extern "C" DECL_EXPORT void GeomTrimmedCurve_Dtor(void* instance);

#endif
