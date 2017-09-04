#ifndef BRepPrimAPI_MakeSphere_H
#define BRepPrimAPI_MakeSphere_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorD82819F3(
	double R);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor9F0E714F(
	double R,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor9282A951(
	double R,
	double angle1,
	double angle2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorC2777E0C(
	double R,
	double angle1,
	double angle2,
	double angle3);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorF0D1E3E6(
	void* Center,
	double R);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor9515F856(
	void* Center,
	double R,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor22BACD62(
	void* Center,
	double R,
	double angle1,
	double angle2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorD969C62A(
	void* Center,
	double R,
	double angle1,
	double angle2,
	double angle3);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor673FA07D(
	void* Axis,
	double R);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorB1A3BD2A(
	void* Axis,
	double R,
	double angle);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_CtorF0200AF(
	void* Axis,
	double R,
	double angle1,
	double angle2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_Ctor77315A3D(
	void* Axis,
	double R,
	double angle1,
	double angle2,
	double angle3);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeSphere_OneAxis(void* instance);
extern "C" DECL_EXPORT void BRepPrimAPIMakeSphere_Dtor(void* instance);

#endif
