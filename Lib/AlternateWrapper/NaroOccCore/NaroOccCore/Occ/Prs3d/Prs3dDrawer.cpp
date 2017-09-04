#include "Prs3dDrawer.h"
#include <Prs3d_Drawer.hxx>

#include <Prs3d_DatumAspect.hxx>
#include <Prs3d_IsoAspect.hxx>
#include <Prs3d_LineAspect.hxx>
#include <Prs3d_PointAspect.hxx>
#include <Prs3d_ShadingAspect.hxx>
#include <Prs3d_TextAspect.hxx>

DECL_EXPORT void* Prs3d_Drawer_Ctor()
{
	return new Handle_Prs3d_Drawer(new Prs3d_Drawer());
}
DECL_EXPORT void Prs3d_Drawer_EnableDrawHiddenLine(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
 	result->EnableDrawHiddenLine();
}
DECL_EXPORT void Prs3d_Drawer_DisableDrawHiddenLine(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
 	result->DisableDrawHiddenLine();
}
DECL_EXPORT void Prs3d_Drawer_SetTypeOfDeflection(void* instance, int value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetTypeOfDeflection((const Aspect_TypeOfDeflection)value);
}

DECL_EXPORT int Prs3d_Drawer_TypeOfDeflection(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return (int)	result->TypeOfDeflection();
}

DECL_EXPORT void Prs3d_Drawer_SetMaximalChordialDeviation(void* instance, double value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetMaximalChordialDeviation(value);
}

DECL_EXPORT double Prs3d_Drawer_MaximalChordialDeviation(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->MaximalChordialDeviation();
}

DECL_EXPORT void Prs3d_Drawer_SetDeviationCoefficient(void* instance, double value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetDeviationCoefficient(value);
}

DECL_EXPORT double Prs3d_Drawer_DeviationCoefficient(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->DeviationCoefficient();
}

DECL_EXPORT void Prs3d_Drawer_SetHLRDeviationCoefficient(void* instance, double value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetHLRDeviationCoefficient(value);
}

DECL_EXPORT double Prs3d_Drawer_HLRDeviationCoefficient(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->HLRDeviationCoefficient();
}

DECL_EXPORT void Prs3d_Drawer_SetHLRAngle(void* instance, double value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetHLRAngle(value);
}

DECL_EXPORT double Prs3d_Drawer_HLRAngle(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->HLRAngle();
}

DECL_EXPORT void Prs3d_Drawer_SetDeviationAngle(void* instance, double value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetDeviationAngle(value);
}

DECL_EXPORT double Prs3d_Drawer_DeviationAngle(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->DeviationAngle();
}

DECL_EXPORT void Prs3d_Drawer_SetDiscretisation(void* instance, int value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetDiscretisation(value);
}

DECL_EXPORT int Prs3d_Drawer_Discretisation(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->Discretisation();
}

DECL_EXPORT void Prs3d_Drawer_SetMaximalParameterValue(void* instance, double value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetMaximalParameterValue(value);
}

DECL_EXPORT double Prs3d_Drawer_MaximalParameterValue(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->MaximalParameterValue();
}

DECL_EXPORT void Prs3d_Drawer_SetIsoOnPlane(void* instance, bool value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetIsoOnPlane(value);
}

DECL_EXPORT bool Prs3d_Drawer_IsoOnPlane(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->IsoOnPlane();
}

DECL_EXPORT void Prs3d_Drawer_SetUIsoAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetUIsoAspect(*(const Handle_Prs3d_IsoAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_UIsoAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_IsoAspect(	result->UIsoAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetVIsoAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetVIsoAspect(*(const Handle_Prs3d_IsoAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_VIsoAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_IsoAspect(	result->VIsoAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetFreeBoundaryAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetFreeBoundaryAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_FreeBoundaryAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->FreeBoundaryAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetFreeBoundaryDraw(void* instance, bool value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetFreeBoundaryDraw(value);
}

DECL_EXPORT bool Prs3d_Drawer_FreeBoundaryDraw(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->FreeBoundaryDraw();
}

DECL_EXPORT void Prs3d_Drawer_SetWireAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetWireAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_WireAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->WireAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetWireDraw(void* instance, bool value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetWireDraw(value);
}

DECL_EXPORT bool Prs3d_Drawer_WireDraw(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->WireDraw();
}

DECL_EXPORT void Prs3d_Drawer_SetUnFreeBoundaryAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetUnFreeBoundaryAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_UnFreeBoundaryAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->UnFreeBoundaryAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetUnFreeBoundaryDraw(void* instance, bool value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetUnFreeBoundaryDraw(value);
}

DECL_EXPORT bool Prs3d_Drawer_UnFreeBoundaryDraw(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->UnFreeBoundaryDraw();
}

DECL_EXPORT void Prs3d_Drawer_SetLineAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetLineAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_LineAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->LineAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetTextAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetTextAspect(*(const Handle_Prs3d_TextAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_TextAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_TextAspect(	result->TextAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetLineArrowDraw(void* instance, bool value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetLineArrowDraw(value);
}

DECL_EXPORT bool Prs3d_Drawer_LineArrowDraw(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->LineArrowDraw();
}

DECL_EXPORT void Prs3d_Drawer_SetPointAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetPointAspect(*(const Handle_Prs3d_PointAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_PointAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_PointAspect(	result->PointAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetShadingAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetShadingAspect(*(const Handle_Prs3d_ShadingAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_ShadingAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_ShadingAspect(	result->ShadingAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetShadingAspectGlobal(void* instance, bool value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetShadingAspectGlobal(value);
}

DECL_EXPORT bool Prs3d_Drawer_ShadingAspectGlobal(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->ShadingAspectGlobal();
}

DECL_EXPORT bool Prs3d_Drawer_DrawHiddenLine(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->DrawHiddenLine();
}

DECL_EXPORT void Prs3d_Drawer_SetHiddenLineAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetHiddenLineAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_HiddenLineAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->HiddenLineAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetSeenLineAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetSeenLineAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_SeenLineAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->SeenLineAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetVectorAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetVectorAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_VectorAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->VectorAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetDatumAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetDatumAspect(*(const Handle_Prs3d_DatumAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_DatumAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_DatumAspect(	result->DatumAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetSectionAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetSectionAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_SectionAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->SectionAspect());
}

DECL_EXPORT void Prs3d_Drawer_SetFaceBoundaryDraw(void* instance, bool value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetFaceBoundaryDraw(value);
}

DECL_EXPORT bool Prs3d_Drawer_IsFaceBoundaryDraw(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	result->IsFaceBoundaryDraw();
}

DECL_EXPORT void Prs3d_Drawer_SetFaceBoundaryAspect(void* instance, void* value)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
		result->SetFaceBoundaryAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* Prs3d_Drawer_FaceBoundaryAspect(void* instance)
{
	Prs3d_Drawer* result = (Prs3d_Drawer*)(((Handle_Prs3d_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->FaceBoundaryAspect());
}

DECL_EXPORT void Prs3dDrawer_Dtor(void* instance)
{
	delete (Handle_Prs3d_Drawer*)instance;
}
