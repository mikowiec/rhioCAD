#include "Graphic3dWNTGraphicDevice.h"
#include <Graphic3d_WNTGraphicDevice.hxx>

#include <Aspect_GraphicDriver.hxx>

DECL_EXPORT void* Graphic3d_WNTGraphicDevice_Ctor()
{
	return new Handle_Graphic3d_WNTGraphicDevice(new Graphic3d_WNTGraphicDevice());
}
DECL_EXPORT void* Graphic3d_WNTGraphicDevice_Ctor9381D4D(
	char* graphicLib)
{
	return new Handle_Graphic3d_WNTGraphicDevice(new Graphic3d_WNTGraphicDevice(			
graphicLib));
}
DECL_EXPORT void* Graphic3d_WNTGraphicDevice_GraphicDriver(void* instance)
{
	Graphic3d_WNTGraphicDevice* result = (Graphic3d_WNTGraphicDevice*)(((Handle_Graphic3d_WNTGraphicDevice*)instance)->Access());
	return 	new Handle_Aspect_GraphicDriver(	result->GraphicDriver());
}

DECL_EXPORT void Graphic3dWNTGraphicDevice_Dtor(void* instance)
{
	delete (Handle_Graphic3d_WNTGraphicDevice*)instance;
}
