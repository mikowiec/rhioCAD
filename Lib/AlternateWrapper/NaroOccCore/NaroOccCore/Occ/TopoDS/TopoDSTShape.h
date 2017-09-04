#ifndef TopoDS_TShape_H
#define TopoDS_TShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT bool TopoDS_TShape_Free(void* instance);
extern "C" DECL_EXPORT void TopoDS_TShape_Free461FC46A(
	void* instance,
	bool F);
extern "C" DECL_EXPORT bool TopoDS_TShape_Modified(void* instance);
extern "C" DECL_EXPORT void TopoDS_TShape_Modified461FC46A(
	void* instance,
	bool M);
extern "C" DECL_EXPORT bool TopoDS_TShape_Checked(void* instance);
extern "C" DECL_EXPORT void TopoDS_TShape_Checked461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_TShape_Orientable(void* instance);
extern "C" DECL_EXPORT void TopoDS_TShape_Orientable461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_TShape_Closed(void* instance);
extern "C" DECL_EXPORT void TopoDS_TShape_Closed461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_TShape_Infinite(void* instance);
extern "C" DECL_EXPORT void TopoDS_TShape_Infinite461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_TShape_Convex(void* instance);
extern "C" DECL_EXPORT void TopoDS_TShape_Convex461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT void TopoDSTShape_Dtor(void* instance);

#endif
