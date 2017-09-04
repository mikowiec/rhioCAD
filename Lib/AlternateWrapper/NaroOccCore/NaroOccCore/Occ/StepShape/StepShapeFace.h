#ifndef StepShape_Face_H
#define StepShape_Face_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* StepShape_Face_Ctor();
extern "C" DECL_EXPORT int StepShape_Face_NbBounds(void* instance);
extern "C" DECL_EXPORT void StepShapeFace_Dtor(void* instance);

#endif
