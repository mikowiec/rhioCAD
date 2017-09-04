#ifndef AIS_Drawer_H
#define AIS_Drawer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_Drawer_Ctor();
extern "C" DECL_EXPORT void AIS_Drawer_SetDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT void AIS_Drawer_SetHLRDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT void AIS_Drawer_SetDeviationAngle(void* instance);
extern "C" DECL_EXPORT void AIS_Drawer_SetHLRAngle(void* instance);
extern "C" DECL_EXPORT void AIS_Drawer_SetDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient);
extern "C" DECL_EXPORT void AIS_Drawer_SetHLRDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient);
extern "C" DECL_EXPORT void AIS_Drawer_SetDeviationAngleD82819F3(
	void* instance,
	double anAngle);
extern "C" DECL_EXPORT void AIS_Drawer_SetHLRAngleD82819F3(
	void* instance,
	double anAngle);
extern "C" DECL_EXPORT double AIS_Drawer_DeviationCoefficient(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_HLRDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_DeviationAngle(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_HLRAngle(void* instance);
extern "C" DECL_EXPORT void AIS_Drawer_ClearLocalAttributes(void* instance);
extern "C" DECL_EXPORT int AIS_Drawer_TypeOfDeflection(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_MaximalChordialDeviation(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_PreviousDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_PreviousHLRDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_PreviousDeviationAngle(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_PreviousHLRDeviationAngle(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_IsOwnDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_IsOwnHLRDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_IsOwnDeviationAngle(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_IsOwnHLRDeviationAngle(void* instance);
extern "C" DECL_EXPORT int AIS_Drawer_Discretisation(void* instance);
extern "C" DECL_EXPORT double AIS_Drawer_MaximalParameterValue(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_IsoOnPlane(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_FreeBoundaryAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_FreeBoundaryDraw(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_WireAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasLineAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasWireAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_WireDraw(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_UnFreeBoundaryAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_UnFreeBoundaryDraw(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasTextAspect(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_TextAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_LineArrowDraw(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_PointAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasPointAspect(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_ShadingAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasShadingAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_ShadingAspectGlobal(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_DrawHiddenLine(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_HiddenLineAspect(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_SeenLineAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasPlaneAspect(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_VectorAspect(void* instance);
extern "C" DECL_EXPORT void AIS_Drawer_SetFaceBoundaryDraw(void* instance, bool value);
extern "C" DECL_EXPORT bool AIS_Drawer_IsFaceBoundaryDraw(void* instance);
extern "C" DECL_EXPORT void AIS_Drawer_SetFaceBoundaryAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* AIS_Drawer_FaceBoundaryAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_IsOwnFaceBoundaryDraw(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_IsOwnFaceBoundaryAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasDatumAspect(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_DatumAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasLengthAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasAngleAspect(void* instance);
extern "C" DECL_EXPORT void* AIS_Drawer_SectionAspect(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasLink(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_WasLastLocal(void* instance);
extern "C" DECL_EXPORT bool AIS_Drawer_HasLocalAttributes(void* instance);
extern "C" DECL_EXPORT void AISDrawer_Dtor(void* instance);

#endif
