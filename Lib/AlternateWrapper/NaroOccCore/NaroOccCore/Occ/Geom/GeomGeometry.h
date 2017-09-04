#ifndef Geom_Geometry_H
#define Geom_Geometry_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Geom_Geometry_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void Geom_Geometry_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void Geom_Geometry_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void Geom_Geometry_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void Geom_Geometry_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void Geom_Geometry_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void Geom_Geometry_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* Geom_Geometry_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* Geom_Geometry_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* Geom_Geometry_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* Geom_Geometry_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* Geom_Geometry_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* Geom_Geometry_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* Geom_Geometry_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* Geom_Geometry_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void GeomGeometry_Dtor(void* instance);

#endif
