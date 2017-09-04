#include "AspectGraphicDriver.h"
#include <Aspect_GraphicDriver.hxx>


DECL_EXPORT void AspectGraphicDriver_Dtor(void* instance)
{
	delete (Handle_Aspect_GraphicDriver*)instance;
}
