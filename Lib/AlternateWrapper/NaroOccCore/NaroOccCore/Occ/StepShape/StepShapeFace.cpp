#include "StepShapeFace.h"
#include <StepShape_Face.hxx>


DECL_EXPORT void* StepShape_Face_Ctor()
{
	return new StepShape_Face();
}
DECL_EXPORT int StepShape_Face_NbBounds(void* instance)
{
	StepShape_Face* result = (StepShape_Face*)instance;
	return 	result->NbBounds();
}

DECL_EXPORT void StepShapeFace_Dtor(void* instance)
{
	delete (StepShape_Face*)instance;
}
