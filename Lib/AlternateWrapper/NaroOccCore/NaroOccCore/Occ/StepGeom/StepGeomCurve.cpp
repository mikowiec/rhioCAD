#include "StepGeomCurve.h"
#include <StepGeom_Curve.hxx>


DECL_EXPORT void* StepGeom_Curve_Ctor()
{
	return new StepGeom_Curve();
}
DECL_EXPORT void StepGeomCurve_Dtor(void* instance)
{
	delete (StepGeom_Curve*)instance;
}
