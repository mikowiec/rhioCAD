#ifndef AIS_Point_H
#define AIS_Point_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_Point_Ctor121385BD(
	void* aComponent);
extern "C" DECL_EXPORT bool AIS_Point_AcceptDisplayModeE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void AIS_Point_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_Point_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_Point_UnsetColor(void* instance);
extern "C" DECL_EXPORT void AIS_Point_UnsetMarker(void* instance);
extern "C" DECL_EXPORT int AIS_Point_Signature(void* instance);
extern "C" DECL_EXPORT int AIS_Point_Type(void* instance);
extern "C" DECL_EXPORT void AIS_Point_SetComponent(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Point_Component(void* instance);
extern "C" DECL_EXPORT void AIS_Point_SetMarker(void* instance, int value);
extern "C" DECL_EXPORT bool AIS_Point_HasMarker(void* instance);
extern "C" DECL_EXPORT void* AIS_Point_Vertex(void* instance);
extern "C" DECL_EXPORT void AISPoint_Dtor(void* instance);

#endif
