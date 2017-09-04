#ifndef BRepPrimAPI_MakeTorus_H
#define BRepPrimAPI_MakeTorus_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor9F0E714F(
	double R1,
	double R2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor9282A951(
	double R1,
	double R2,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorC2777E0C(
	double R1,
	double R2,
	double angle1,
	double angle2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor216AF150(
	double R1,
	double R2,
	double angle1,
	double angle2,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorB1A3BD2A(
	void* Axes,
	double R1,
	double R2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorF0200AF(
	void* Axes,
	double R1,
	double R2,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_Ctor77315A3D(
	void* Axes,
	double R1,
	double R2,
	double angle1,
	double angle2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_CtorDC3808AF(
	void* Axes,
	double R1,
	double R2,
	double angle1,
	double angle2,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeTorus_OneAxis(void* instance);
extern "C" DECL_EXPORT void BRepPrimAPIMakeTorus_Dtor(void* instance);

#endif
