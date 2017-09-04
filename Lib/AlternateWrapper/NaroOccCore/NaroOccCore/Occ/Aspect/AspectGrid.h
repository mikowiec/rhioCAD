#ifndef Aspect_Grid_H
#define Aspect_Grid_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Aspect_Grid_RotateD82819F3(
	void* instance,
	double anAngle);
extern "C" DECL_EXPORT void Aspect_Grid_Translate9F0E714F(
	void* instance,
	double aDx,
	double aDy);
extern "C" DECL_EXPORT void Aspect_Grid_SetColorsCF0F9433(
	void* instance,
	void* aColor,
	void* aTenthColor);
extern "C" DECL_EXPORT void Aspect_Grid_HitC2777E0C(
	void* instance,
	double X,
	double Y,
	double* gridX,
	double* gridY);
extern "C" DECL_EXPORT void Aspect_Grid_Activate(void* instance);
extern "C" DECL_EXPORT void Aspect_Grid_Deactivate(void* instance);
extern "C" DECL_EXPORT void Aspect_Grid_ColorsCF0F9433(
	void* instance,
	void* aColor,
	void* aTenthColor);
extern "C" DECL_EXPORT void Aspect_Grid_Display(void* instance);
extern "C" DECL_EXPORT void Aspect_Grid_Erase(void* instance);
extern "C" DECL_EXPORT void Aspect_Grid_SetXOrigin(void* instance, double value);
extern "C" DECL_EXPORT double Aspect_Grid_XOrigin(void* instance);
extern "C" DECL_EXPORT void Aspect_Grid_SetYOrigin(void* instance, double value);
extern "C" DECL_EXPORT double Aspect_Grid_YOrigin(void* instance);
extern "C" DECL_EXPORT void Aspect_Grid_SetRotationAngle(void* instance, double value);
extern "C" DECL_EXPORT double Aspect_Grid_RotationAngle(void* instance);
extern "C" DECL_EXPORT bool Aspect_Grid_IsActive(void* instance);
extern "C" DECL_EXPORT void Aspect_Grid_SetDrawMode(void* instance, int value);
extern "C" DECL_EXPORT int Aspect_Grid_DrawMode(void* instance);
extern "C" DECL_EXPORT bool Aspect_Grid_IsDisplayed(void* instance);
extern "C" DECL_EXPORT void AspectGrid_Dtor(void* instance);

#endif
