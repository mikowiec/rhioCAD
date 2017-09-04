#ifndef Geom_Ellipse_H
#define Geom_Ellipse_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_Ellipse_CtorAA0BF3BF(
	void* E);
extern "C" DECL_EXPORT void* Geom_Ellipse_CtorB1A3BD2A(
	void* A2,
	double MajorRadius,
	double MinorRadius);
extern "C" DECL_EXPORT double Geom_Ellipse_ReversedParameterD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void Geom_Ellipse_D053A5A2C1(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void Geom_Ellipse_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1);
extern "C" DECL_EXPORT void Geom_Ellipse_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void Geom_Ellipse_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* Geom_Ellipse_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT void Geom_Ellipse_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_Ellipse_SetElips(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Ellipse_Elips(void* instance);
extern "C" DECL_EXPORT void* Geom_Ellipse_Directrix1(void* instance);
extern "C" DECL_EXPORT void* Geom_Ellipse_Directrix2(void* instance);
extern "C" DECL_EXPORT double Geom_Ellipse_Eccentricity(void* instance);
extern "C" DECL_EXPORT double Geom_Ellipse_Focal(void* instance);
extern "C" DECL_EXPORT void* Geom_Ellipse_Focus1(void* instance);
extern "C" DECL_EXPORT void* Geom_Ellipse_Focus2(void* instance);
extern "C" DECL_EXPORT void Geom_Ellipse_SetMajorRadius(void* instance, double value);
extern "C" DECL_EXPORT double Geom_Ellipse_MajorRadius(void* instance);
extern "C" DECL_EXPORT void Geom_Ellipse_SetMinorRadius(void* instance, double value);
extern "C" DECL_EXPORT double Geom_Ellipse_MinorRadius(void* instance);
extern "C" DECL_EXPORT double Geom_Ellipse_Parameter(void* instance);
extern "C" DECL_EXPORT double Geom_Ellipse_FirstParameter(void* instance);
extern "C" DECL_EXPORT double Geom_Ellipse_LastParameter(void* instance);
extern "C" DECL_EXPORT bool Geom_Ellipse_IsClosed(void* instance);
extern "C" DECL_EXPORT bool Geom_Ellipse_IsPeriodic(void* instance);
extern "C" DECL_EXPORT void* Geom_Ellipse_Copy(void* instance);
extern "C" DECL_EXPORT void GeomEllipse_Dtor(void* instance);

#endif
