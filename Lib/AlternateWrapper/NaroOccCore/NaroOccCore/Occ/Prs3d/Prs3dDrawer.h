#ifndef Prs3d_Drawer_H
#define Prs3d_Drawer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs3d_Drawer_Ctor();
extern "C" DECL_EXPORT void Prs3d_Drawer_EnableDrawHiddenLine(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_DisableDrawHiddenLine(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetTypeOfDeflection(void* instance, int value);
extern "C" DECL_EXPORT int Prs3d_Drawer_TypeOfDeflection(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetMaximalChordialDeviation(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_Drawer_MaximalChordialDeviation(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetDeviationCoefficient(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_Drawer_DeviationCoefficient(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetHLRDeviationCoefficient(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_Drawer_HLRDeviationCoefficient(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetHLRAngle(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_Drawer_HLRAngle(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetDeviationAngle(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_Drawer_DeviationAngle(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetDiscretisation(void* instance, int value);
extern "C" DECL_EXPORT int Prs3d_Drawer_Discretisation(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetMaximalParameterValue(void* instance, double value);
extern "C" DECL_EXPORT double Prs3d_Drawer_MaximalParameterValue(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetIsoOnPlane(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_Drawer_IsoOnPlane(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetUIsoAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_UIsoAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetVIsoAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_VIsoAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetFreeBoundaryAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_FreeBoundaryAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetFreeBoundaryDraw(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_Drawer_FreeBoundaryDraw(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetWireAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_WireAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetWireDraw(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_Drawer_WireDraw(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetUnFreeBoundaryAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_UnFreeBoundaryAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetUnFreeBoundaryDraw(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_Drawer_UnFreeBoundaryDraw(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetLineAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_LineAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetTextAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_TextAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetLineArrowDraw(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_Drawer_LineArrowDraw(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetPointAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_PointAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetShadingAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_ShadingAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetShadingAspectGlobal(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_Drawer_ShadingAspectGlobal(void* instance);
extern "C" DECL_EXPORT bool Prs3d_Drawer_DrawHiddenLine(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetHiddenLineAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_HiddenLineAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetSeenLineAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_SeenLineAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetVectorAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_VectorAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetDatumAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_DatumAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetSectionAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_SectionAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetFaceBoundaryDraw(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_Drawer_IsFaceBoundaryDraw(void* instance);
extern "C" DECL_EXPORT void Prs3d_Drawer_SetFaceBoundaryAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_Drawer_FaceBoundaryAspect(void* instance);
extern "C" DECL_EXPORT void Prs3dDrawer_Dtor(void* instance);

#endif
