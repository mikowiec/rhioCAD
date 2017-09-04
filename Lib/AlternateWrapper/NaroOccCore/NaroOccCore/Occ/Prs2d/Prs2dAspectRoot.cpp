#include "Prs2dAspectRoot.h"
#include <Prs2d_AspectRoot.hxx>


DECL_EXPORT int Prs2d_AspectRoot_GetAspectName(void* instance)
{
	Prs2d_AspectRoot* result = (Prs2d_AspectRoot*)(((Handle_Prs2d_AspectRoot*)instance)->Access());
	return (int)	result->GetAspectName();
}

DECL_EXPORT void Prs2dAspectRoot_Dtor(void* instance)
{
	delete (Handle_Prs2d_AspectRoot*)instance;
}
