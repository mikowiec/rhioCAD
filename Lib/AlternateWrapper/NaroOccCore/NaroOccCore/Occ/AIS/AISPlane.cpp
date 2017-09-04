#include "AISPlane.h"
#include <AIS_Plane.hxx>

#include <Geom_Axis2Placement.hxx>
#include <Geom_Plane.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* AIS_Plane_Ctor774085EF(
	void* aComponent,
	bool aCurrentMode)
{
		const Handle_Geom_Plane&  _aComponent =*(const Handle_Geom_Plane *)aComponent;
	return new Handle_AIS_Plane(new AIS_Plane(			
_aComponent,			
aCurrentMode));
}
DECL_EXPORT void* AIS_Plane_Ctor13B4A2BC(
	void* aComponent,
	void* aCenter,
	bool aCurrentMode)
{
		const Handle_Geom_Plane&  _aComponent =*(const Handle_Geom_Plane *)aComponent;
		const gp_Pnt &  _aCenter =*(const gp_Pnt *)aCenter;
	return new Handle_AIS_Plane(new AIS_Plane(			
_aComponent,			
_aCenter,			
aCurrentMode));
}
DECL_EXPORT void* AIS_Plane_Ctor57A70980(
	void* aComponent,
	void* aCenter,
	void* aPmin,
	void* aPmax,
	bool aCurrentMode)
{
		const Handle_Geom_Plane&  _aComponent =*(const Handle_Geom_Plane *)aComponent;
		const gp_Pnt &  _aCenter =*(const gp_Pnt *)aCenter;
		const gp_Pnt &  _aPmin =*(const gp_Pnt *)aPmin;
		const gp_Pnt &  _aPmax =*(const gp_Pnt *)aPmax;
	return new Handle_AIS_Plane(new AIS_Plane(			
_aComponent,			
_aCenter,			
_aPmin,			
_aPmax,			
aCurrentMode));
}
DECL_EXPORT void* AIS_Plane_Ctor8C5294A9(
	void* aComponent,
	int aPlaneType,
	bool aCurrentMode)
{
		const Handle_Geom_Axis2Placement&  _aComponent =*(const Handle_Geom_Axis2Placement *)aComponent;
		const AIS_TypeOfPlane _aPlaneType =(const AIS_TypeOfPlane )aPlaneType;
	return new Handle_AIS_Plane(new AIS_Plane(			
_aComponent,			
_aPlaneType,			
aCurrentMode));
}
DECL_EXPORT void AIS_Plane_SetSizeD82819F3(
	void* instance,
	double aValue)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->SetSize(			
aValue);
}
DECL_EXPORT void AIS_Plane_SetSize9F0E714F(
	void* instance,
	double Xval,
	double YVal)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->SetSize(			
Xval,			
YVal);
}
DECL_EXPORT void AIS_Plane_UnsetSize(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->UnsetSize();
}
DECL_EXPORT bool AIS_Plane_Size9F0E714F(
	void* instance,
	double* X,
	double* Y)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return  	result->Size(			
*X,			
*Y);
}
DECL_EXPORT bool AIS_Plane_PlaneAttributesC014B0(
	void* instance,
	void* aComponent,
	void* aCenter,
	void* aPmin,
	void* aPmax)
{
		 Handle_Geom_Plane&  _aComponent =*( Handle_Geom_Plane *)aComponent;
		 gp_Pnt &  _aCenter =*( gp_Pnt *)aCenter;
		 gp_Pnt &  _aPmin =*( gp_Pnt *)aPmin;
		 gp_Pnt &  _aPmax =*( gp_Pnt *)aPmax;
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return  	result->PlaneAttributes(			
_aComponent,			
_aCenter,			
_aPmin,			
_aPmax);
}
DECL_EXPORT void AIS_Plane_SetPlaneAttributesC014B0(
	void* instance,
	void* aComponent,
	void* aCenter,
	void* aPmin,
	void* aPmax)
{
		const Handle_Geom_Plane&  _aComponent =*(const Handle_Geom_Plane *)aComponent;
		const gp_Pnt &  _aCenter =*(const gp_Pnt *)aCenter;
		const gp_Pnt &  _aPmin =*(const gp_Pnt *)aPmin;
		const gp_Pnt &  _aPmax =*(const gp_Pnt *)aPmax;
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->SetPlaneAttributes(			
_aComponent,			
_aCenter,			
_aPmin,			
_aPmax);
}
DECL_EXPORT void AIS_Plane_SetAxis2PlacementA35F2F3B(
	void* instance,
	void* aComponent,
	int aPlaneType)
{
		const Handle_Geom_Axis2Placement&  _aComponent =*(const Handle_Geom_Axis2Placement *)aComponent;
		const AIS_TypeOfPlane _aPlaneType =(const AIS_TypeOfPlane )aPlaneType;
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->SetAxis2Placement(			
_aComponent,			
_aPlaneType);
}
DECL_EXPORT void* AIS_Plane_Axis2Placement(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return new Handle_Geom_Axis2Placement( 	result->Axis2Placement());
}
DECL_EXPORT bool AIS_Plane_AcceptDisplayModeE8219145(
	void* instance,
	int aMode)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return  	result->AcceptDisplayMode(			
aMode);
}
DECL_EXPORT void AIS_Plane_ComputeSelection7C718F26(
	void* instance,
	void* aSelection,
	int aMode)
{
		const Handle_SelectMgr_Selection&  _aSelection =*(const Handle_SelectMgr_Selection *)aSelection;
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->ComputeSelection(			
_aSelection,			
aMode);
}
DECL_EXPORT void AIS_Plane_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Plane_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Plane_UnsetColor(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT bool AIS_Plane_HasOwnSize(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return 	result->HasOwnSize();
}

DECL_EXPORT int AIS_Plane_Signature(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return 	result->Signature();
}

DECL_EXPORT int AIS_Plane_Type(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT void AIS_Plane_SetComponent(void* instance, void* value)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
		result->SetComponent(*(const Handle_Geom_Plane *)value);
}

DECL_EXPORT void* AIS_Plane_Component(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return 	new Handle_Geom_Plane(	result->Component());
}

DECL_EXPORT void AIS_Plane_SetCenter(void* instance, void* value)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
		result->SetCenter(*(const gp_Pnt *)value);
}

DECL_EXPORT void* AIS_Plane_Center(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return 	new gp_Pnt(	result->Center());
}

DECL_EXPORT int AIS_Plane_TypeOfPlane(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return (int)	result->TypeOfPlane();
}

DECL_EXPORT bool AIS_Plane_IsXYZPlane(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return 	result->IsXYZPlane();
}

DECL_EXPORT void AIS_Plane_SetCurrentMode(void* instance, bool value)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
		result->SetCurrentMode(value);
}

DECL_EXPORT bool AIS_Plane_CurrentMode(void* instance)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
	return 	result->CurrentMode();
}

DECL_EXPORT void AIS_Plane_SetContext(void* instance, void* value)
{
	AIS_Plane* result = (AIS_Plane*)(((Handle_AIS_Plane*)instance)->Access());
		result->SetContext(*(const Handle_AIS_InteractiveContext *)value);
}

DECL_EXPORT void AISPlane_Dtor(void* instance)
{
	delete (Handle_AIS_Plane*)instance;
}
