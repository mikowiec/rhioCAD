#ifndef Geom_Line_H
#define Geom_Line_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_Line_Ctor608B963B(
	void* A1);
extern "C" DECL_EXPORT void* Geom_Line_Ctor9917D291(
	void* L);
extern "C" DECL_EXPORT void* Geom_Line_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT void Geom_Line_Reverse(void* instance);
extern "C" DECL_EXPORT double Geom_Line_ReversedParameterD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT bool Geom_Line_IsCNE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void Geom_Line_D053A5A2C1(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void Geom_Line_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1);
extern "C" DECL_EXPORT void Geom_Line_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void Geom_Line_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* Geom_Line_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT void Geom_Line_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT double Geom_Line_TransformedParameter9B95D054(
	void* instance,
	double U,
	void* T);
extern "C" DECL_EXPORT double Geom_Line_ParametricTransformation72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_Line_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void Geom_Line_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void Geom_Line_SetLin(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Line_Lin(void* instance);
extern "C" DECL_EXPORT void Geom_Line_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Line_Position(void* instance);
extern "C" DECL_EXPORT double Geom_Line_FirstParameter(void* instance);
extern "C" DECL_EXPORT double Geom_Line_LastParameter(void* instance);
extern "C" DECL_EXPORT bool Geom_Line_IsClosed(void* instance);
extern "C" DECL_EXPORT bool Geom_Line_IsPeriodic(void* instance);
extern "C" DECL_EXPORT int Geom_Line_Continuity(void* instance);
extern "C" DECL_EXPORT void* Geom_Line_Copy(void* instance);
extern "C" DECL_EXPORT void GeomLine_Dtor(void* instance);

#endif
