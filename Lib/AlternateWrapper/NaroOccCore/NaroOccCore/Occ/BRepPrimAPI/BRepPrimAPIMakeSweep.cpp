#include "BRepPrimAPIMakeSweep.h"
#include <BRepPrimAPI_MakeSweep.hxx>


DECL_EXPORT void BRepPrimAPIMakeSweep_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeSweep*)instance;
}
