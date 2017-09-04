#ifndef BRepPrimAPI_MakeBox_H
#define BRepPrimAPI_MakeBox_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_Ctor9282A951(
	double dx,
	double dy,
	double dz);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_Ctor22BACD62(
	void* P,
	double dx,
	double dy,
	double dz);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_Ctor5C63477E(
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_CtorF0200AF(
	void* Axes,
	double dx,
	double dy,
	double dz);
extern "C" DECL_EXPORT void BRepPrimAPI_MakeBox_Build(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_Shell(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_Solid(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_BottomFace(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_BackFace(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_FrontFace(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_LeftFace(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_RightFace(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeBox_TopFace(void* instance);
extern "C" DECL_EXPORT void BRepPrimAPIMakeBox_Dtor(void* instance);

#endif
