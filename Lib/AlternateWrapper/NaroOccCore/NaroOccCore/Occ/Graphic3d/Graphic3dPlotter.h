#ifndef Graphic3d_Plotter_H
#define Graphic3d_Plotter_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT bool Graphic3d_Plotter_BeginPlot8A4E6B67(
	void* instance,
	void* aProjector);
extern "C" DECL_EXPORT void Graphic3d_Plotter_EndPlot(void* instance);
extern "C" DECL_EXPORT void Graphic3dPlotter_Dtor(void* instance);

#endif
