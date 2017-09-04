#ifndef AIS_Plane_H
#define AIS_Plane_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_Plane_Ctor774085EF(
	void* aComponent,
	bool aCurrentMode);
extern "C" DECL_EXPORT void* AIS_Plane_Ctor13B4A2BC(
	void* aComponent,
	void* aCenter,
	bool aCurrentMode);
extern "C" DECL_EXPORT void* AIS_Plane_Ctor57A70980(
	void* aComponent,
	void* aCenter,
	void* aPmin,
	void* aPmax,
	bool aCurrentMode);
extern "C" DECL_EXPORT void* AIS_Plane_Ctor8C5294A9(
	void* aComponent,
	int aPlaneType,
	bool aCurrentMode);
extern "C" DECL_EXPORT void AIS_Plane_SetSizeD82819F3(
	void* instance,
	double aValue);
extern "C" DECL_EXPORT void AIS_Plane_SetSize9F0E714F(
	void* instance,
	double Xval,
	double YVal);
extern "C" DECL_EXPORT void AIS_Plane_UnsetSize(void* instance);
extern "C" DECL_EXPORT bool AIS_Plane_Size9F0E714F(
	void* instance,
	double* X,
	double* Y);
extern "C" DECL_EXPORT bool AIS_Plane_PlaneAttributesC014B0(
	void* instance,
	void* aComponent,
	void* aCenter,
	void* aPmin,
	void* aPmax);
extern "C" DECL_EXPORT void AIS_Plane_SetPlaneAttributesC014B0(
	void* instance,
	void* aComponent,
	void* aCenter,
	void* aPmin,
	void* aPmax);
extern "C" DECL_EXPORT void AIS_Plane_SetAxis2PlacementA35F2F3B(
	void* instance,
	void* aComponent,
	int aPlaneType);
extern "C" DECL_EXPORT void* AIS_Plane_Axis2Placement(void* instance);
extern "C" DECL_EXPORT bool AIS_Plane_AcceptDisplayModeE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void AIS_Plane_ComputeSelection7C718F26(
	void* instance,
	void* aSelection,
	int aMode);
extern "C" DECL_EXPORT void AIS_Plane_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_Plane_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_Plane_UnsetColor(void* instance);
extern "C" DECL_EXPORT bool AIS_Plane_HasOwnSize(void* instance);
extern "C" DECL_EXPORT int AIS_Plane_Signature(void* instance);
extern "C" DECL_EXPORT int AIS_Plane_Type(void* instance);
extern "C" DECL_EXPORT void AIS_Plane_SetComponent(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Plane_Component(void* instance);
extern "C" DECL_EXPORT void AIS_Plane_SetCenter(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Plane_Center(void* instance);
extern "C" DECL_EXPORT int AIS_Plane_TypeOfPlane(void* instance);
extern "C" DECL_EXPORT bool AIS_Plane_IsXYZPlane(void* instance);
extern "C" DECL_EXPORT void AIS_Plane_SetCurrentMode(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_Plane_CurrentMode(void* instance);
extern "C" DECL_EXPORT void AIS_Plane_SetContext(void* instance, void* value);
extern "C" DECL_EXPORT void AISPlane_Dtor(void* instance);

#endif
