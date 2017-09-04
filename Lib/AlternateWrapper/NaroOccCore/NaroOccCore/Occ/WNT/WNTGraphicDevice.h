#ifndef WNT_GraphicDevice_H
#define WNT_GraphicDevice_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* WNT_GraphicDevice_Ctor5C28B6AA(
	bool aColorCube,
	void* aDevContext);
extern "C" DECL_EXPORT void* WNT_GraphicDevice_CtorD4631C92(
	bool aColorCube,
	int aDevContext);
extern "C" DECL_EXPORT void WNT_GraphicDevice_DisplaySize5107F6FE(
	void* instance,
	int* aWidth,
	int* aHeight);
extern "C" DECL_EXPORT void WNT_GraphicDevice_DisplaySize9F0E714F(
	void* instance,
	double* aWidth,
	double* aHeight);
extern "C" DECL_EXPORT void* WNT_GraphicDevice_HPalette(void* instance);
extern "C" DECL_EXPORT bool WNT_GraphicDevice_IsPaletteDevice(void* instance);
extern "C" DECL_EXPORT int WNT_GraphicDevice_NumColors(void* instance);
extern "C" DECL_EXPORT void* WNT_GraphicDevice_GraphicDriver(void* instance);
extern "C" DECL_EXPORT void WNTGraphicDevice_Dtor(void* instance);

#endif
