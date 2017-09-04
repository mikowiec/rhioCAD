#include "StepGeomBoundedCurve.h"
#include <StepGeom_BoundedCurve.hxx>


DECL_EXPORT void* StepGeom_BoundedCurve_Ctor()
{
	return new StepGeom_BoundedCurve();
}
DECL_EXPORT void StepGeomBoundedCurve_Dtor(void* instance)
{
	delete (StepGeom_BoundedCurve*)instance;
}
