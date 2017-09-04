#include "StepGeomPoint.h"
#include <StepGeom_Point.hxx>


DECL_EXPORT void* StepGeom_Point_Ctor()
{
	return new StepGeom_Point();
}
DECL_EXPORT void StepGeomPoint_Dtor(void* instance)
{
	delete (StepGeom_Point*)instance;
}
