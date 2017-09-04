#ifndef BRepBuilderAPI_MakeWire_H
#define BRepBuilderAPI_MakeWire_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor();
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor24263856(
	void* E);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor4DFF7017(
	void* E1,
	void* E2);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_CtorFC90A78C(
	void* E1,
	void* E2,
	void* E3);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor4181D08D(
	void* E1,
	void* E2,
	void* E3,
	void* E4);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor368EDFE5(
	void* W);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Ctor23F02239(
	void* W,
	void* E);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeWire_Add24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeWire_Add368EDFE5(
	void* instance,
	void* W);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeWire_Add49A1D41A(
	void* instance,
	void* L);
extern "C" DECL_EXPORT bool BRepBuilderAPI_MakeWire_IsDone(void* instance);
extern "C" DECL_EXPORT int BRepBuilderAPI_MakeWire_Error(void* instance);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Wire(void* instance);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Edge(void* instance);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeWire_Vertex(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPIMakeWire_Dtor(void* instance);

#endif
