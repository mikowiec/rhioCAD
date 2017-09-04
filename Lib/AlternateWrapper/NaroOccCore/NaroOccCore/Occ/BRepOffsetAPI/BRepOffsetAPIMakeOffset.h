#ifndef BRepOffsetAPI_MakeOffset_H
#define BRepOffsetAPI_MakeOffset_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepOffsetAPI_MakeOffset_Ctor();
extern "C" DECL_EXPORT void* BRepOffsetAPI_MakeOffset_CtorA6167785(
	void* Spine,
	int Join);
extern "C" DECL_EXPORT void* BRepOffsetAPI_MakeOffset_Ctor38E1F2B(
	void* Spine,
	int Join);
extern "C" DECL_EXPORT void BRepOffsetAPI_MakeOffset_InitA6167785(
	void* instance,
	void* Spine,
	int Join);
extern "C" DECL_EXPORT void BRepOffsetAPI_MakeOffset_InitAC370FAD(
	void* instance,
	int Join);
extern "C" DECL_EXPORT void BRepOffsetAPI_MakeOffset_AddWire368EDFE5(
	void* instance,
	void* Spine);
extern "C" DECL_EXPORT void BRepOffsetAPI_MakeOffset_Perform9F0E714F(
	void* instance,
	double Offset,
	double Alt);
extern "C" DECL_EXPORT void BRepOffsetAPI_MakeOffset_Build(void* instance);
extern "C" DECL_EXPORT void BRepOffsetAPIMakeOffset_Dtor(void* instance);

#endif
