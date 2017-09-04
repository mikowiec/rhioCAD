#ifndef Aspect_Edge_H
#define Aspect_Edge_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_Edge_Ctor();
extern "C" DECL_EXPORT void* Aspect_Edge_Ctor7A0E4278(
	int AIndex1,
	int AIndex2,
	int AType);
extern "C" DECL_EXPORT int Aspect_Edge_FirstIndex(void* instance);
extern "C" DECL_EXPORT int Aspect_Edge_LastIndex(void* instance);
extern "C" DECL_EXPORT int Aspect_Edge_Type(void* instance);
extern "C" DECL_EXPORT void AspectEdge_Dtor(void* instance);

#endif
