#ifndef AIS_Trihedron_H
#define AIS_Trihedron_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_Trihedron_Ctor3B3DCDDA(
	void* aComponent);
extern "C" DECL_EXPORT void AIS_Trihedron_UnsetSize(void* instance);
extern "C" DECL_EXPORT bool AIS_Trihedron_AcceptDisplayModeE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void AIS_Trihedron_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_Trihedron_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_Trihedron_ExtremityPointsFABD0F95(
	void* instance,
	void* TheExtrem);
extern "C" DECL_EXPORT void AIS_Trihedron_UnsetColor(void* instance);
extern "C" DECL_EXPORT void AIS_Trihedron_UnsetWidth(void* instance);
extern "C" DECL_EXPORT void AIS_Trihedron_SetComponent(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Trihedron_Component(void* instance);
extern "C" DECL_EXPORT bool AIS_Trihedron_HasOwnSize(void* instance);
extern "C" DECL_EXPORT void AIS_Trihedron_SetSize(void* instance, double value);
extern "C" DECL_EXPORT double AIS_Trihedron_Size(void* instance);
extern "C" DECL_EXPORT void* AIS_Trihedron_XAxis(void* instance);
extern "C" DECL_EXPORT void* AIS_Trihedron_YAxis(void* instance);
extern "C" DECL_EXPORT void* AIS_Trihedron_Axis(void* instance);
extern "C" DECL_EXPORT void* AIS_Trihedron_Position(void* instance);
extern "C" DECL_EXPORT void* AIS_Trihedron_XYPlane(void* instance);
extern "C" DECL_EXPORT void* AIS_Trihedron_XZPlane(void* instance);
extern "C" DECL_EXPORT void* AIS_Trihedron_YZPlane(void* instance);
extern "C" DECL_EXPORT void AIS_Trihedron_SetContext(void* instance, void* value);
extern "C" DECL_EXPORT void AIS_Trihedron_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT int AIS_Trihedron_Signature(void* instance);
extern "C" DECL_EXPORT int AIS_Trihedron_Type(void* instance);
extern "C" DECL_EXPORT bool AIS_Trihedron_HasTextColor(void* instance);
extern "C" DECL_EXPORT void AIS_Trihedron_SetTextColor(void* instance, int value);
extern "C" DECL_EXPORT int AIS_Trihedron_TextColor(void* instance);
extern "C" DECL_EXPORT bool AIS_Trihedron_HasArrowColor(void* instance);
extern "C" DECL_EXPORT void AIS_Trihedron_SetArrowColor(void* instance, int value);
extern "C" DECL_EXPORT int AIS_Trihedron_ArrowColor(void* instance);
extern "C" DECL_EXPORT void AISTrihedron_Dtor(void* instance);

#endif
