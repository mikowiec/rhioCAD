#ifndef IntTools_PntOn2Faces_H
#define IntTools_PntOn2Faces_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_PntOn2Faces_Ctor();
extern "C" DECL_EXPORT void* IntTools_PntOn2Faces_Ctor85669E67(
	void* aP1,
	void* aP2);
extern "C" DECL_EXPORT void IntTools_PntOn2Faces_SetValid(void* instance, bool value);
extern "C" DECL_EXPORT void IntTools_PntOn2Faces_SetP1(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_PntOn2Faces_P1(void* instance);
extern "C" DECL_EXPORT void IntTools_PntOn2Faces_SetP2(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_PntOn2Faces_P2(void* instance);
extern "C" DECL_EXPORT bool IntTools_PntOn2Faces_IsValid(void* instance);
extern "C" DECL_EXPORT void IntToolsPntOn2Faces_Dtor(void* instance);

#endif
