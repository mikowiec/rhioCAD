#include "AspectGraphicDevice.h"
#include <Aspect_GraphicDevice.hxx>


DECL_EXPORT void AspectGraphicDevice_Dtor(void* instance)
{
	delete (Handle_Aspect_GraphicDevice*)instance;
}
