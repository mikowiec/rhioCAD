#include "AISDrawer.h"
#include <AIS_Drawer.hxx>

#include <Prs3d_DatumAspect.hxx>
#include <Prs3d_LineAspect.hxx>
#include <Prs3d_PointAspect.hxx>
#include <Prs3d_ShadingAspect.hxx>
#include <Prs3d_TextAspect.hxx>

DECL_EXPORT void* AIS_Drawer_Ctor()
{
	return new Handle_AIS_Drawer(new AIS_Drawer());
}
DECL_EXPORT void AIS_Drawer_SetDeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetDeviationCoefficient();
}
DECL_EXPORT void AIS_Drawer_SetHLRDeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetHLRDeviationCoefficient();
}
DECL_EXPORT void AIS_Drawer_SetDeviationAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetDeviationAngle();
}
DECL_EXPORT void AIS_Drawer_SetHLRAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetHLRAngle();
}
DECL_EXPORT void AIS_Drawer_SetDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetDeviationCoefficient(			
aCoefficient);
}
DECL_EXPORT void AIS_Drawer_SetHLRDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetHLRDeviationCoefficient(			
aCoefficient);
}
DECL_EXPORT void AIS_Drawer_SetDeviationAngleD82819F3(
	void* instance,
	double anAngle)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetDeviationAngle(			
anAngle);
}
DECL_EXPORT void AIS_Drawer_SetHLRAngleD82819F3(
	void* instance,
	double anAngle)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->SetHLRAngle(			
anAngle);
}
DECL_EXPORT double AIS_Drawer_DeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return  	result->DeviationCoefficient();
}
DECL_EXPORT double AIS_Drawer_HLRDeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return  	result->HLRDeviationCoefficient();
}
DECL_EXPORT double AIS_Drawer_DeviationAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return  	result->DeviationAngle();
}
DECL_EXPORT double AIS_Drawer_HLRAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return  	result->HLRAngle();
}
DECL_EXPORT void AIS_Drawer_ClearLocalAttributes(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
 	result->ClearLocalAttributes();
}
DECL_EXPORT int AIS_Drawer_TypeOfDeflection(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return (int)	result->TypeOfDeflection();
}

DECL_EXPORT double AIS_Drawer_MaximalChordialDeviation(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->MaximalChordialDeviation();
}

DECL_EXPORT double AIS_Drawer_PreviousDeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->PreviousDeviationCoefficient();
}

DECL_EXPORT double AIS_Drawer_PreviousHLRDeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->PreviousHLRDeviationCoefficient();
}

DECL_EXPORT double AIS_Drawer_PreviousDeviationAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->PreviousDeviationAngle();
}

DECL_EXPORT double AIS_Drawer_PreviousHLRDeviationAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->PreviousHLRDeviationAngle();
}

DECL_EXPORT bool AIS_Drawer_IsOwnDeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsOwnDeviationCoefficient();
}

DECL_EXPORT bool AIS_Drawer_IsOwnHLRDeviationCoefficient(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsOwnHLRDeviationCoefficient();
}

DECL_EXPORT bool AIS_Drawer_IsOwnDeviationAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsOwnDeviationAngle();
}

DECL_EXPORT bool AIS_Drawer_IsOwnHLRDeviationAngle(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsOwnHLRDeviationAngle();
}

DECL_EXPORT int AIS_Drawer_Discretisation(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->Discretisation();
}

DECL_EXPORT double AIS_Drawer_MaximalParameterValue(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->MaximalParameterValue();
}

DECL_EXPORT bool AIS_Drawer_IsoOnPlane(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsoOnPlane();
}

DECL_EXPORT void* AIS_Drawer_FreeBoundaryAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->FreeBoundaryAspect());
}

DECL_EXPORT bool AIS_Drawer_FreeBoundaryDraw(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->FreeBoundaryDraw();
}

DECL_EXPORT void* AIS_Drawer_WireAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->WireAspect());
}

DECL_EXPORT bool AIS_Drawer_HasLineAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasLineAspect();
}

DECL_EXPORT bool AIS_Drawer_HasWireAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasWireAspect();
}

DECL_EXPORT bool AIS_Drawer_WireDraw(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->WireDraw();
}

DECL_EXPORT void* AIS_Drawer_UnFreeBoundaryAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->UnFreeBoundaryAspect());
}

DECL_EXPORT bool AIS_Drawer_UnFreeBoundaryDraw(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->UnFreeBoundaryDraw();
}

DECL_EXPORT bool AIS_Drawer_HasTextAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasTextAspect();
}

DECL_EXPORT void* AIS_Drawer_TextAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_TextAspect(	result->TextAspect());
}

DECL_EXPORT bool AIS_Drawer_LineArrowDraw(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->LineArrowDraw();
}

DECL_EXPORT void* AIS_Drawer_PointAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_PointAspect(	result->PointAspect());
}

DECL_EXPORT bool AIS_Drawer_HasPointAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasPointAspect();
}

DECL_EXPORT void* AIS_Drawer_ShadingAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_ShadingAspect(	result->ShadingAspect());
}

DECL_EXPORT bool AIS_Drawer_HasShadingAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasShadingAspect();
}

DECL_EXPORT bool AIS_Drawer_ShadingAspectGlobal(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->ShadingAspectGlobal();
}

DECL_EXPORT bool AIS_Drawer_DrawHiddenLine(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->DrawHiddenLine();
}

DECL_EXPORT void* AIS_Drawer_HiddenLineAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->HiddenLineAspect());
}

DECL_EXPORT void* AIS_Drawer_SeenLineAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->SeenLineAspect());
}

DECL_EXPORT bool AIS_Drawer_HasPlaneAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasPlaneAspect();
}

DECL_EXPORT void* AIS_Drawer_VectorAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->VectorAspect());
}

DECL_EXPORT void AIS_Drawer_SetFaceBoundaryDraw(void* instance, bool value)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
		result->SetFaceBoundaryDraw(value);
}

DECL_EXPORT bool AIS_Drawer_IsFaceBoundaryDraw(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsFaceBoundaryDraw();
}

DECL_EXPORT void AIS_Drawer_SetFaceBoundaryAspect(void* instance, void* value)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
		result->SetFaceBoundaryAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* AIS_Drawer_FaceBoundaryAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->FaceBoundaryAspect());
}

DECL_EXPORT bool AIS_Drawer_IsOwnFaceBoundaryDraw(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsOwnFaceBoundaryDraw();
}

DECL_EXPORT bool AIS_Drawer_IsOwnFaceBoundaryAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->IsOwnFaceBoundaryAspect();
}

DECL_EXPORT bool AIS_Drawer_HasDatumAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasDatumAspect();
}

DECL_EXPORT void* AIS_Drawer_DatumAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_DatumAspect(	result->DatumAspect());
}

DECL_EXPORT bool AIS_Drawer_HasLengthAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasLengthAspect();
}

DECL_EXPORT bool AIS_Drawer_HasAngleAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasAngleAspect();
}

DECL_EXPORT void* AIS_Drawer_SectionAspect(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->SectionAspect());
}

DECL_EXPORT bool AIS_Drawer_HasLink(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasLink();
}

DECL_EXPORT bool AIS_Drawer_WasLastLocal(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->WasLastLocal();
}

DECL_EXPORT bool AIS_Drawer_HasLocalAttributes(void* instance)
{
	AIS_Drawer* result = (AIS_Drawer*)(((Handle_AIS_Drawer*)instance)->Access());
	return 	result->HasLocalAttributes();
}

DECL_EXPORT void AISDrawer_Dtor(void* instance)
{
	delete (Handle_AIS_Drawer*)instance;
}
