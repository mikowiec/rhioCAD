#ifndef BOPTools_DSFiller_H
#define BOPTools_DSFiller_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOPTools_DSFiller_Ctor();
extern "C" DECL_EXPORT void BOPTools_DSFiller_SetShapes877A736F(
	void* instance,
	void* aS1,
	void* aS2);
extern "C" DECL_EXPORT void BOPTools_DSFiller_Perform(void* instance);
extern "C" DECL_EXPORT void BOPTools_DSFiller_InitFillersAndPools(void* instance);
extern "C" DECL_EXPORT void BOPTools_DSFiller_ToCompletePerform(void* instance);
extern "C" DECL_EXPORT int BOPTools_DSFiller_TreatCompound877A736F(
	void* theShape,
	void* theShapeResult);
extern "C" DECL_EXPORT void* BOPTools_DSFiller_Shape1(void* instance);
extern "C" DECL_EXPORT void* BOPTools_DSFiller_Shape2(void* instance);
extern "C" DECL_EXPORT bool BOPTools_DSFiller_IsNewFiller(void* instance);
extern "C" DECL_EXPORT void BOPTools_DSFiller_SetNewFiller(void* instance, bool value);
extern "C" DECL_EXPORT bool BOPTools_DSFiller_IsDone(void* instance);
extern "C" DECL_EXPORT void BOPToolsDSFiller_Dtor(void* instance);

#endif
