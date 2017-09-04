#ifndef Geom_CartesianPoint_H
#define Geom_CartesianPoint_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_CartesianPoint_Ctor9EAECD5B(
	void* P);
extern "C" DECL_EXPORT void* Geom_CartesianPoint_Ctor9282A951(
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void Geom_CartesianPoint_SetCoord9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void Geom_CartesianPoint_Coord9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void Geom_CartesianPoint_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_CartesianPoint_SetPnt(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_CartesianPoint_Pnt(void* instance);
extern "C" DECL_EXPORT void Geom_CartesianPoint_SetX(void* instance, double value);
extern "C" DECL_EXPORT double Geom_CartesianPoint_X(void* instance);
extern "C" DECL_EXPORT void Geom_CartesianPoint_SetY(void* instance, double value);
extern "C" DECL_EXPORT double Geom_CartesianPoint_Y(void* instance);
extern "C" DECL_EXPORT void Geom_CartesianPoint_SetZ(void* instance, double value);
extern "C" DECL_EXPORT double Geom_CartesianPoint_Z(void* instance);
extern "C" DECL_EXPORT void* Geom_CartesianPoint_Copy(void* instance);
extern "C" DECL_EXPORT void GeomCartesianPoint_Dtor(void* instance);

#endif
