#ifndef TopoDS_Shape_H
#define TopoDS_Shape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopoDS_Shape_Ctor();
extern "C" DECL_EXPORT void TopoDS_Shape_Nullify(void* instance);
extern "C" DECL_EXPORT void* TopoDS_Shape_Location(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Location15DCA881(
	void* instance,
	void* Loc);
extern "C" DECL_EXPORT void* TopoDS_Shape_Located15DCA881(
	void* instance,
	void* Loc);
extern "C" DECL_EXPORT int TopoDS_Shape_Orientation(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Orientation69EAD1AB(
	void* instance,
	int Orient);
extern "C" DECL_EXPORT void* TopoDS_Shape_Oriented69EAD1AB(
	void* instance,
	int Or);
extern "C" DECL_EXPORT void* TopoDS_Shape_TShape(void* instance);
extern "C" DECL_EXPORT bool TopoDS_Shape_Free(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Free461FC46A(
	void* instance,
	bool F);
extern "C" DECL_EXPORT bool TopoDS_Shape_Modified(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Modified461FC46A(
	void* instance,
	bool M);
extern "C" DECL_EXPORT bool TopoDS_Shape_Checked(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Checked461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_Shape_Orientable(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Orientable461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_Shape_Closed(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Closed461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_Shape_Infinite(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Infinite461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT bool TopoDS_Shape_Convex(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Convex461FC46A(
	void* instance,
	bool C);
extern "C" DECL_EXPORT void TopoDS_Shape_Move15DCA881(
	void* instance,
	void* position);
extern "C" DECL_EXPORT void* TopoDS_Shape_Moved15DCA881(
	void* instance,
	void* position);
extern "C" DECL_EXPORT void TopoDS_Shape_Reverse(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Complement(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_Compose69EAD1AB(
	void* instance,
	int Orient);
extern "C" DECL_EXPORT void* TopoDS_Shape_Composed69EAD1AB(
	void* instance,
	int Orient);
extern "C" DECL_EXPORT bool TopoDS_Shape_IsPartner9EBAC0C0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TopoDS_Shape_IsSame9EBAC0C0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TopoDS_Shape_IsEqual9EBAC0C0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TopoDS_Shape_IsNotEqual9EBAC0C0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT int TopoDS_Shape_HashCodeE8219145(
	void* instance,
	int Upper);
extern "C" DECL_EXPORT void TopoDS_Shape_EmptyCopy(void* instance);
extern "C" DECL_EXPORT void TopoDS_Shape_TShape3F0FF109(
	void* instance,
	void* T);
extern "C" DECL_EXPORT bool TopoDS_Shape_IsNull(void* instance);
extern "C" DECL_EXPORT int TopoDS_Shape_ShapeType(void* instance);
extern "C" DECL_EXPORT void* TopoDS_Shape_Reversed(void* instance);
extern "C" DECL_EXPORT void* TopoDS_Shape_Complemented(void* instance);
extern "C" DECL_EXPORT void* TopoDS_Shape_EmptyCopied(void* instance);
extern "C" DECL_EXPORT void TopoDSShape_Dtor(void* instance);

#endif
