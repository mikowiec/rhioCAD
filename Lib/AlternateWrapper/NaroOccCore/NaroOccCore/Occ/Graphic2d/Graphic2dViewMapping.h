#ifndef Graphic2d_ViewMapping_H
#define Graphic2d_ViewMapping_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic2d_ViewMapping_Ctor();
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_SetViewMapping9282A951(
	void* instance,
	double aXCenter,
	double aYCenter,
	double aSize);
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_SetCenter9F0E714F(
	void* instance,
	double aXCenter,
	double aYCenter);
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_SetViewMappingDefault(void* instance);
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_ViewMappingReset(void* instance);
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_ViewMapping9282A951(
	void* instance,
	double* XCenter,
	double* YCenter,
	double* Size);
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_Center9F0E714F(
	void* instance,
	double* XCenter,
	double* YCenter);
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_ViewMappingDefault9282A951(
	void* instance,
	double* XCenter,
	double* YCenter,
	double* Size);
extern "C" DECL_EXPORT void Graphic2d_ViewMapping_SetSize(void* instance, double value);
extern "C" DECL_EXPORT double Graphic2d_ViewMapping_Zoom(void* instance);
extern "C" DECL_EXPORT void Graphic2dViewMapping_Dtor(void* instance);

#endif
