#ifndef BRepPrimAPI_MakeCylinder_H
#define BRepPrimAPI_MakeCylinder_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCylinder_Ctor9F0E714F(
	double R,
	double H);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCylinder_Ctor9282A951(
	double R,
	double H,
	double Angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCylinder_CtorB1A3BD2A(
	void* Axes,
	double R,
	double H);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCylinder_CtorF0200AF(
	void* Axes,
	double R,
	double H,
	double Angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCylinder_OneAxis(void* instance);
extern "C" DECL_EXPORT void BRepPrimAPIMakeCylinder_Dtor(void* instance);

#endif
