#include "Prs3dBasicAspect.h"
#include <Prs3d_BasicAspect.hxx>


DECL_EXPORT void Prs3dBasicAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_BasicAspect*)instance;
}
