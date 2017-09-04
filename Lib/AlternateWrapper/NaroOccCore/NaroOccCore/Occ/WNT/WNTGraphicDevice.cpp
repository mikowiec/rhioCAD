#include "WNTGraphicDevice.h"
#include <WNT_GraphicDevice.hxx>

#include <Aspect_GraphicDriver.hxx>

DECL_EXPORT void* WNT_GraphicDevice_Ctor5C28B6AA(
	bool aColorCube,
	void* aDevContext)
{
	return new Handle_WNT_GraphicDevice(new WNT_GraphicDevice(			
aColorCube,			
aDevContext));
}
DECL_EXPORT void* WNT_GraphicDevice_CtorD4631C92(
	bool aColorCube,
	int aDevContext)
{
	return new Handle_WNT_GraphicDevice(new WNT_GraphicDevice(			
aColorCube,			
aDevContext));
}
DECL_EXPORT void WNT_GraphicDevice_DisplaySize5107F6FE(
	void* instance,
	int* aWidth,
	int* aHeight)
{
	WNT_GraphicDevice* result = (WNT_GraphicDevice*)(((Handle_WNT_GraphicDevice*)instance)->Access());
 	result->DisplaySize(			
*aWidth,			
*aHeight);
}
DECL_EXPORT void WNT_GraphicDevice_DisplaySize9F0E714F(
	void* instance,
	double* aWidth,
	double* aHeight)
{
	WNT_GraphicDevice* result = (WNT_GraphicDevice*)(((Handle_WNT_GraphicDevice*)instance)->Access());
 	result->DisplaySize(			
*aWidth,			
*aHeight);
}
DECL_EXPORT void* WNT_GraphicDevice_HPalette(void* instance)
{
	WNT_GraphicDevice* result = (WNT_GraphicDevice*)(((Handle_WNT_GraphicDevice*)instance)->Access());
	return 	result->HPalette();
}

DECL_EXPORT bool WNT_GraphicDevice_IsPaletteDevice(void* instance)
{
	WNT_GraphicDevice* result = (WNT_GraphicDevice*)(((Handle_WNT_GraphicDevice*)instance)->Access());
	return 	result->IsPaletteDevice();
}

DECL_EXPORT int WNT_GraphicDevice_NumColors(void* instance)
{
	WNT_GraphicDevice* result = (WNT_GraphicDevice*)(((Handle_WNT_GraphicDevice*)instance)->Access());
	return 	result->NumColors();
}

DECL_EXPORT void* WNT_GraphicDevice_GraphicDriver(void* instance)
{
	WNT_GraphicDevice* result = (WNT_GraphicDevice*)(((Handle_WNT_GraphicDevice*)instance)->Access());
	return 	new Handle_Aspect_GraphicDriver(	result->GraphicDriver());
}

DECL_EXPORT void WNTGraphicDevice_Dtor(void* instance)
{
	delete (Handle_WNT_GraphicDevice*)instance;
}
