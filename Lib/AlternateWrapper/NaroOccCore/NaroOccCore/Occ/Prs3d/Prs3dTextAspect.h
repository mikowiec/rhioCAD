#ifndef Prs3d_TextAspect_H
#define Prs3d_TextAspect_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs3d_TextAspect_Ctor();
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetFont(void* instance, char* value);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetHeightWidthRatio(void* instance, double value);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetSpace(void* instance, double value);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetHeight(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_TextAspect_Height(void* instance);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetAngle(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_TextAspect_Angle(void* instance);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetHorizontalJustification(void* instance, int value);
extern "C" DECL_EXPORT int Prs3d_TextAspect_HorizontalJustification(void* instance);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetVerticalJustification(void* instance, int value);
extern "C" DECL_EXPORT int Prs3d_TextAspect_VerticalJustification(void* instance);
extern "C" DECL_EXPORT void Prs3d_TextAspect_SetOrientation(void* instance, int value);
extern "C" DECL_EXPORT int Prs3d_TextAspect_Orientation(void* instance);
extern "C" DECL_EXPORT void* Prs3d_TextAspect_Aspect(void* instance);
extern "C" DECL_EXPORT void Prs3dTextAspect_Dtor(void* instance);

#endif
