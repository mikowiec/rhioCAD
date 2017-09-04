#ifndef BRepPrimAPI_MakeCone_H
#define BRepPrimAPI_MakeCone_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCone_Ctor9282A951(
	double R1,
	double R2,
	double H);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCone_CtorC2777E0C(
	double R1,
	double R2,
	double H,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCone_CtorF0200AF(
	void* Axes,
	double R1,
	double R2,
	double H);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCone_Ctor77315A3D(
	void* Axes,
	double R1,
	double R2,
	double H,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeCone_OneAxis(void* instance);
extern "C" DECL_EXPORT void BRepPrimAPIMakeCone_Dtor(void* instance);

#endif
