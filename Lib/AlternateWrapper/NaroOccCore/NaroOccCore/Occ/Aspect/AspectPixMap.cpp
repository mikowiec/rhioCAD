#include "AspectPixMap.h"
#include <Aspect_PixMap.hxx>


DECL_EXPORT void Aspect_PixMap_Size5107F6FE(
	void* instance,
	int* aWidth,
	int* anHeight)
{
	Aspect_PixMap* result = (Aspect_PixMap*)(((Handle_Aspect_PixMap*)instance)->Access());
 	result->Size(			
*aWidth,			
*anHeight);
}
DECL_EXPORT int Aspect_PixMap_Depth(void* instance)
{
	Aspect_PixMap* result = (Aspect_PixMap*)(((Handle_Aspect_PixMap*)instance)->Access());
	return 	result->Depth();
}

DECL_EXPORT void AspectPixMap_Dtor(void* instance)
{
	delete (Handle_Aspect_PixMap*)instance;
}
