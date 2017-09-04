#include "StepGeomSurface.h"
#include <StepGeom_Surface.hxx>


DECL_EXPORT void* StepGeom_Surface_Ctor()
{
	return new StepGeom_Surface();
}
DECL_EXPORT void StepGeomSurface_Dtor(void* instance)
{
	delete (StepGeom_Surface*)instance;
}
