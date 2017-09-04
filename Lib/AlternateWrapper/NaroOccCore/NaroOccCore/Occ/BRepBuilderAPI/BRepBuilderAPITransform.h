#ifndef BRepBuilderAPI_Transform_H
#define BRepBuilderAPI_Transform_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepBuilderAPI_Transform_Ctor72D78650(
	void* T);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Transform_CtorE2FB96F1(
	void* S,
	void* T,
	bool Copy);
extern "C" DECL_EXPORT void BRepBuilderAPI_Transform_Perform5E7DD5C8(
	void* instance,
	void* S,
	bool Copy);
extern "C" DECL_EXPORT void* BRepBuilderAPI_Transform_ModifiedShape9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void BRepBuilderAPITransform_Dtor(void* instance);

#endif
