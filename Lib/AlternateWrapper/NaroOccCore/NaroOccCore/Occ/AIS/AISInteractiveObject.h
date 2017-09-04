#ifndef AIS_InteractiveObject_H
#define AIS_InteractiveObject_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void AIS_InteractiveObject_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetColor(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetWidth(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_AcceptDisplayModeE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void AIS_InteractiveObject_Redisplay461FC46A(
	void* instance,
	bool AllModes);
extern "C" DECL_EXPORT void AIS_InteractiveObject_ClearOwner(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_AddUserF411CB01(
	void* instance,
	void* aUser);
extern "C" DECL_EXPORT void AIS_InteractiveObject_ClearUsers(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetDisplayMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetSelectionMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetSelectionPriority(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetHilightMode(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveObject_Color(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_Color8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT int AIS_InteractiveObject_Material(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetMaterialE047B55B(
	void* instance,
	int aName);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetMaterialC0044920(
	void* instance,
	void* aName);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetMaterial(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetTransparency(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetAttributes(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_StateE8219145(
	void* instance,
	int theState);
extern "C" DECL_EXPORT int AIS_InteractiveObject_State(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetDegenerateModelE6DFDFE0(
	void* instance,
	int aModel,
	double aRatio);
extern "C" DECL_EXPORT int AIS_InteractiveObject_DegenerateModelD82819F3(
	void* instance,
	double* aRatio);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetTransformationA067E6E8(
	void* instance,
	void* aTranformation,
	bool postConcatenate,
	bool updateSelection);
extern "C" DECL_EXPORT void AIS_InteractiveObject_UnsetTransformation(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveObject_Transformation(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetAspect93F6A493(
	void* instance,
	void* anAspect,
	bool globalChange);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetPolygonOffsets306E0DFB(
	void* instance,
	int aMode,
	double aFactor,
	double aUnits);
extern "C" DECL_EXPORT void AIS_InteractiveObject_PolygonOffsets306E0DFB(
	void* instance,
	int* aMode,
	double* aFactor,
	double* aUnits);
extern "C" DECL_EXPORT int AIS_InteractiveObject_Type(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveObject_Signature(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_AcceptShapeDecomposition(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetCurrentFacingModel(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveObject_CurrentFacingModel(void* instance);
extern "C" DECL_EXPORT int AIS_InteractiveObject_DefaultDisplayMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetInfiniteState(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_IsInfinite(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasInteractiveContext(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveObject_GetContext(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetContext(void* instance, void* value);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasOwner(void* instance);
extern "C" DECL_EXPORT void* AIS_InteractiveObject_GetOwner(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetOwner(void* instance, void* value);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasUsers(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasDisplayMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetDisplayMode(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveObject_DisplayMode(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasSelectionMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetSelectionMode(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveObject_SelectionMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetSelectionPriority(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveObject_SelectionPriority(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasSelectionPriority(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasHilightMode(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetHilightMode(void* instance, int value);
extern "C" DECL_EXPORT int AIS_InteractiveObject_HilightMode(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasColor(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasWidth(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetWidth(void* instance, double value);
extern "C" DECL_EXPORT double AIS_InteractiveObject_Width(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasMaterial(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_IsTransparent(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetTransparency(void* instance, double value);
extern "C" DECL_EXPORT double AIS_InteractiveObject_Transparency(void* instance);
extern "C" DECL_EXPORT void AIS_InteractiveObject_SetAttributes(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_InteractiveObject_Attributes(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasTransformation(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasPresentation(void* instance);
extern "C" DECL_EXPORT bool AIS_InteractiveObject_HasPolygonOffsets(void* instance);
extern "C" DECL_EXPORT void AISInteractiveObject_Dtor(void* instance);

#endif
