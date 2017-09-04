#ifndef TopTools_ShapeSet_H
#define TopTools_ShapeSet_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopTools_ShapeSet_Ctor();
extern "C" DECL_EXPORT void TopTools_ShapeSet_Delete(void* instance);
extern "C" DECL_EXPORT void TopTools_ShapeSet_Clear(void* instance);
extern "C" DECL_EXPORT int TopTools_ShapeSet_Add9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void* TopTools_ShapeSet_ShapeE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT int TopTools_ShapeSet_Index9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void TopTools_ShapeSet_AddGeometry9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void TopTools_ShapeSet_SetFormatNb(void* instance, int value);
extern "C" DECL_EXPORT int TopTools_ShapeSet_FormatNb(void* instance);
extern "C" DECL_EXPORT int TopTools_ShapeSet_NbShapes(void* instance);
extern "C" DECL_EXPORT void TopTools_ShapeSet_SetProgress(void* instance, void* value);
extern "C" DECL_EXPORT void* TopTools_ShapeSet_GetProgress(void* instance);
extern "C" DECL_EXPORT void TopToolsShapeSet_Dtor(void* instance);

#endif
