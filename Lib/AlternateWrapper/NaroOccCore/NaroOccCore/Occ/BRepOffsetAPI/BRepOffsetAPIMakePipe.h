#ifndef BRepOffsetAPI_MakePipe_H
#define BRepOffsetAPI_MakePipe_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepOffsetAPI_MakePipe_Ctor6D9C9186(
	void* Spine,
	void* Profile);
extern "C" DECL_EXPORT void BRepOffsetAPI_MakePipe_Build(void* instance);
extern "C" DECL_EXPORT void* BRepOffsetAPI_MakePipe_Generated877A736F(
	void* instance,
	void* SSpine,
	void* SProfile);
extern "C" DECL_EXPORT void* BRepOffsetAPI_MakePipe_FirstShape(void* instance);
extern "C" DECL_EXPORT void* BRepOffsetAPI_MakePipe_LastShape(void* instance);
extern "C" DECL_EXPORT void BRepOffsetAPIMakePipe_Dtor(void* instance);

#endif
