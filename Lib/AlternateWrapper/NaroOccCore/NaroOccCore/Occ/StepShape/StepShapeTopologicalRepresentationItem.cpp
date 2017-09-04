#include "StepShapeTopologicalRepresentationItem.h"
#include <StepShape_TopologicalRepresentationItem.hxx>


DECL_EXPORT void* StepShape_TopologicalRepresentationItem_Ctor()
{
	return new StepShape_TopologicalRepresentationItem();
}
DECL_EXPORT void StepShapeTopologicalRepresentationItem_Dtor(void* instance)
{
	delete (StepShape_TopologicalRepresentationItem*)instance;
}
