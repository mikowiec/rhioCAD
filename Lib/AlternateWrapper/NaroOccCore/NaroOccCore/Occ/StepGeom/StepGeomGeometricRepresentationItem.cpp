#include "StepGeomGeometricRepresentationItem.h"
#include <StepGeom_GeometricRepresentationItem.hxx>


DECL_EXPORT void* StepGeom_GeometricRepresentationItem_Ctor()
{
	return new StepGeom_GeometricRepresentationItem();
}
DECL_EXPORT void StepGeomGeometricRepresentationItem_Dtor(void* instance)
{
	delete (StepGeom_GeometricRepresentationItem*)instance;
}
