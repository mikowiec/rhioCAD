#include "StepShapeLoop.h"
#include <StepShape_Loop.hxx>


DECL_EXPORT void* StepShape_Loop_Ctor()
{
	return new StepShape_Loop();
}
DECL_EXPORT void StepShapeLoop_Dtor(void* instance)
{
	delete (StepShape_Loop*)instance;
}
