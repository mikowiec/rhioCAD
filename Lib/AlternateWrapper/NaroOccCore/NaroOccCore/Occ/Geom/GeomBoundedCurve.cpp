#include "GeomBoundedCurve.h"
#include <Geom_BoundedCurve.hxx>


DECL_EXPORT void GeomBoundedCurve_Dtor(void* instance)
{
	delete (Handle_Geom_BoundedCurve*)instance;
}
