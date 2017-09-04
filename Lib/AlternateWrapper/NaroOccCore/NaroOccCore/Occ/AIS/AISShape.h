#ifndef AIS_Shape_H
#define AIS_Shape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_Shape_Ctor9EBAC0C0(
	void* shap);
extern "C" DECL_EXPORT void AIS_Shape_Set9EBAC0C0(
	void* instance,
	void* ashap);
extern "C" DECL_EXPORT bool AIS_Shape_SetOwnDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT bool AIS_Shape_SetOwnHLRDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT bool AIS_Shape_SetOwnDeviationAngle(void* instance);
extern "C" DECL_EXPORT bool AIS_Shape_SetOwnHLRDeviationAngle(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_SetOwnDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient);
extern "C" DECL_EXPORT void AIS_Shape_SetOwnHLRDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient);
extern "C" DECL_EXPORT void AIS_Shape_SetOwnDeviationAngleD82819F3(
	void* instance,
	double anAngle);
extern "C" DECL_EXPORT void AIS_Shape_SetOwnHLRDeviationAngleD82819F3(
	void* instance,
	double anAngle);
extern "C" DECL_EXPORT bool AIS_Shape_OwnDeviationCoefficient9F0E714F(
	void* instance,
	double* aCoefficient,
	double* aPreviousCoefficient);
extern "C" DECL_EXPORT bool AIS_Shape_OwnHLRDeviationCoefficient9F0E714F(
	void* instance,
	double* aCoefficient,
	double* aPreviousCoefficient);
extern "C" DECL_EXPORT bool AIS_Shape_OwnDeviationAngle9F0E714F(
	void* instance,
	double* anAngle,
	double* aPreviousAngle);
extern "C" DECL_EXPORT bool AIS_Shape_OwnHLRDeviationAngle9F0E714F(
	void* instance,
	double* anAngle,
	double* aPreviousAngle);
extern "C" DECL_EXPORT void AIS_Shape_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void AIS_Shape_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void AIS_Shape_UnsetColor(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_UnsetWidth(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_SetMaterialE047B55B(
	void* instance,
	int aName);
extern "C" DECL_EXPORT void AIS_Shape_SetMaterialC0044920(
	void* instance,
	void* aName);
extern "C" DECL_EXPORT void AIS_Shape_UnsetMaterial(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_UnsetTransparency(void* instance);
extern "C" DECL_EXPORT int AIS_Shape_Color(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_Color8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT int AIS_Shape_Material(void* instance);
extern "C" DECL_EXPORT int AIS_Shape_SelectionTypeE8219145(
	int aDecompositionMode);
extern "C" DECL_EXPORT int AIS_Shape_SelectionModeC6FD32C4(
	int aShapeType);
extern "C" DECL_EXPORT double AIS_Shape_GetDeflectionC3E71CA1(
	void* aShape,
	void* aDrawer);
extern "C" DECL_EXPORT int AIS_Shape_Signature(void* instance);
extern "C" DECL_EXPORT int AIS_Shape_Type(void* instance);
extern "C" DECL_EXPORT bool AIS_Shape_AcceptShapeDecomposition(void* instance);
extern "C" DECL_EXPORT void* AIS_Shape_Shape(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_SetAngleAndDeviation(void* instance, double value);
extern "C" DECL_EXPORT double AIS_Shape_UserAngle(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_SetHLRAngleAndDeviation(void* instance, double value);
extern "C" DECL_EXPORT void AIS_Shape_SetWidth(void* instance, double value);
extern "C" DECL_EXPORT void* AIS_Shape_BoundingBox(void* instance);
extern "C" DECL_EXPORT void AIS_Shape_SetTransparency(void* instance, double value);
extern "C" DECL_EXPORT double AIS_Shape_Transparency(void* instance);
extern "C" DECL_EXPORT void AISShape_Dtor(void* instance);

#endif
