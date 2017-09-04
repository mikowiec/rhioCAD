#include "Prs3dCompositeAspect.h"
#include <Prs3d_CompositeAspect.hxx>


DECL_EXPORT void Prs3dCompositeAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_CompositeAspect*)instance;
}
