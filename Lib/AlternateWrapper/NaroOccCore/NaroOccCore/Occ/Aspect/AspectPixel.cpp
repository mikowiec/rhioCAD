#include "AspectPixel.h"
#include <Aspect_Pixel.hxx>


DECL_EXPORT void AspectPixel_Dtor(void* instance)
{
	delete (Aspect_Pixel*)instance;
}
