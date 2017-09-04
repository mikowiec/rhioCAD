#ifndef AIS_Axis_H
#define AIS_Axis_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_Axis_Ctor7C3C08A3(
	void* aComponent);
extern "C" DECL_EXPORT void* AIS_Axis_CtorD1476D1E(
	void* aComponent,
	int anAxisType);
extern "C" DECL_EXPORT void* AIS_Axis_CtorA2B99193(
	void* anAxis);
extern "C" DECL_EXPORT void* AIS_Axis_Axis2Placement(void* instance);
extern "C" DECL_EXPORT void AIS_Axis_SetAxis2PlacementD1476D1E(
	void* instance,
	void* aComponent,
	int anAxisType);
extern "C" DECL_EXPORT bool AIS_Axis_AcceptDisplayModeE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void AIS_Axis_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_Axis_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_Axis_UnsetColor(void* instance);
extern "C" DECL_EXPORT void AIS_Axis_UnsetWidth(void* instance);
extern "C" DECL_EXPORT void AIS_Axis_SetComponent(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Axis_Component(void* instance);
extern "C" DECL_EXPORT void AIS_Axis_SetAxis1Placement(void* instance, void* value);
extern "C" DECL_EXPORT void AIS_Axis_SetTypeOfAxis(void* instance, int value);
extern "C" DECL_EXPORT int AIS_Axis_TypeOfAxis(void* instance);
extern "C" DECL_EXPORT bool AIS_Axis_IsXYZAxis(void* instance);
extern "C" DECL_EXPORT int AIS_Axis_Signature(void* instance);
extern "C" DECL_EXPORT int AIS_Axis_Type(void* instance);
extern "C" DECL_EXPORT void AIS_Axis_SetWidth(void* instance, double value);
extern "C" DECL_EXPORT void AISAxis_Dtor(void* instance);

#endif
