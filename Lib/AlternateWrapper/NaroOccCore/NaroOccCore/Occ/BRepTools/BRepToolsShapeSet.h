#ifndef BRepTools_ShapeSet_H
#define BRepTools_ShapeSet_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepTools_ShapeSet_Ctor461FC46A(
	bool isWithTriangles);
extern "C" DECL_EXPORT void* BRepTools_ShapeSet_CtorC2019AEC(
	void* B,
	bool isWithTriangles);
extern "C" DECL_EXPORT void BRepTools_ShapeSet_Clear(void* instance);
extern "C" DECL_EXPORT void BRepTools_ShapeSet_AddGeometry9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void BRepTools_ShapeSet_AddShapes877A736F(
	void* instance,
	void* S1,
	void* S2);
extern "C" DECL_EXPORT void BRepTools_ShapeSet_Check6E774DE2(
	void* instance,
	int T,
	void* S);
extern "C" DECL_EXPORT void BRepToolsShapeSet_Dtor(void* instance);

#endif
