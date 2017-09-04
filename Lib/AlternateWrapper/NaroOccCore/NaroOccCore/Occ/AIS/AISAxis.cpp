#include "AISAxis.h"
#include <AIS_Axis.hxx>

#include <Geom_Axis2Placement.hxx>
#include <Geom_Line.hxx>

DECL_EXPORT void* AIS_Axis_Ctor7C3C08A3(
	void* aComponent)
{
		const Handle_Geom_Line&  _aComponent =*(const Handle_Geom_Line *)aComponent;
	return new Handle_AIS_Axis(new AIS_Axis(			
_aComponent));
}
DECL_EXPORT void* AIS_Axis_CtorD1476D1E(
	void* aComponent,
	int anAxisType)
{
		const Handle_Geom_Axis2Placement&  _aComponent =*(const Handle_Geom_Axis2Placement *)aComponent;
		const AIS_TypeOfAxis _anAxisType =(const AIS_TypeOfAxis )anAxisType;
	return new Handle_AIS_Axis(new AIS_Axis(			
_aComponent,			
_anAxisType));
}
DECL_EXPORT void* AIS_Axis_CtorA2B99193(
	void* anAxis)
{
		const Handle_Geom_Axis1Placement&  _anAxis =*(const Handle_Geom_Axis1Placement *)anAxis;
	return new Handle_AIS_Axis(new AIS_Axis(			
_anAxis));
}
DECL_EXPORT void* AIS_Axis_Axis2Placement(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
	return new Handle_Geom_Axis2Placement( 	result->Axis2Placement());
}
DECL_EXPORT void AIS_Axis_SetAxis2PlacementD1476D1E(
	void* instance,
	void* aComponent,
	int anAxisType)
{
		const Handle_Geom_Axis2Placement&  _aComponent =*(const Handle_Geom_Axis2Placement *)aComponent;
		const AIS_TypeOfAxis _anAxisType =(const AIS_TypeOfAxis )anAxisType;
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
 	result->SetAxis2Placement(			
_aComponent,			
_anAxisType);
}
DECL_EXPORT bool AIS_Axis_AcceptDisplayModeE8219145(
	void* instance,
	int aMode)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
	return  	result->AcceptDisplayMode(			
aMode);
}
DECL_EXPORT void AIS_Axis_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Axis_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Axis_UnsetColor(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT void AIS_Axis_UnsetWidth(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
 	result->UnsetWidth();
}
DECL_EXPORT void AIS_Axis_SetComponent(void* instance, void* value)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
		result->SetComponent(*(const Handle_Geom_Line *)value);
}

DECL_EXPORT void* AIS_Axis_Component(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
	return 	new Handle_Geom_Line(	result->Component());
}

DECL_EXPORT void AIS_Axis_SetAxis1Placement(void* instance, void* value)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
		result->SetAxis1Placement(*(const Handle_Geom_Axis1Placement *)value);
}

DECL_EXPORT void AIS_Axis_SetTypeOfAxis(void* instance, int value)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
		result->SetTypeOfAxis((const AIS_TypeOfAxis)value);
}

DECL_EXPORT int AIS_Axis_TypeOfAxis(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
	return (int)	result->TypeOfAxis();
}

DECL_EXPORT bool AIS_Axis_IsXYZAxis(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
	return 	result->IsXYZAxis();
}

DECL_EXPORT int AIS_Axis_Signature(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
	return 	result->Signature();
}

DECL_EXPORT int AIS_Axis_Type(void* instance)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT void AIS_Axis_SetWidth(void* instance, double value)
{
	AIS_Axis* result = (AIS_Axis*)(((Handle_AIS_Axis*)instance)->Access());
		result->SetWidth(value);
}

DECL_EXPORT void AISAxis_Dtor(void* instance)
{
	delete (Handle_AIS_Axis*)instance;
}
