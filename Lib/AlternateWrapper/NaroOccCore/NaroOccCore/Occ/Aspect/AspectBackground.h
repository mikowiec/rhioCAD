#ifndef Aspect_Background_H
#define Aspect_Background_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_Background_Ctor();
extern "C" DECL_EXPORT void* Aspect_Background_Ctor8FD7F48(
	void* AColor);
extern "C" DECL_EXPORT void Aspect_Background_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Aspect_Background_Color(void* instance);
extern "C" DECL_EXPORT void AspectBackground_Dtor(void* instance);

#endif
