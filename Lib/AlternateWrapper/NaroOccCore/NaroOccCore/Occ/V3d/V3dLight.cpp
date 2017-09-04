#include "V3dLight.h"
#include <V3d_Light.hxx>


DECL_EXPORT int V3d_Light_Type(void* instance)
{
	V3d_Light* result = (V3d_Light*)(((Handle_V3d_Light*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT bool V3d_Light_Headlight(void* instance)
{
	V3d_Light* result = (V3d_Light*)(((Handle_V3d_Light*)instance)->Access());
	return 	result->Headlight();
}

DECL_EXPORT bool V3d_Light_IsDisplayed(void* instance)
{
	V3d_Light* result = (V3d_Light*)(((Handle_V3d_Light*)instance)->Access());
	return 	result->IsDisplayed();
}

DECL_EXPORT void V3dLight_Dtor(void* instance)
{
	delete (Handle_V3d_Light*)instance;
}
