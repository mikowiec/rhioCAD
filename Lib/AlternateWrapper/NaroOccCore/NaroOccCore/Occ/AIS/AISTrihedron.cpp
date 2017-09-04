#include "AISTrihedron.h"
#include <AIS_Trihedron.hxx>

#include <AIS_Axis.hxx>
#include <AIS_Plane.hxx>
#include <AIS_Point.hxx>
#include <Geom_Axis2Placement.hxx>

DECL_EXPORT void* AIS_Trihedron_Ctor3B3DCDDA(
	void* aComponent)
{
		const Handle_Geom_Axis2Placement&  _aComponent =*(const Handle_Geom_Axis2Placement *)aComponent;
	return new Handle_AIS_Trihedron(new AIS_Trihedron(			
_aComponent));
}
DECL_EXPORT void AIS_Trihedron_UnsetSize(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
 	result->UnsetSize();
}
DECL_EXPORT bool AIS_Trihedron_AcceptDisplayModeE8219145(
	void* instance,
	int aMode)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return  	result->AcceptDisplayMode(			
aMode);
}
DECL_EXPORT void AIS_Trihedron_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Trihedron_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Trihedron_ExtremityPointsFABD0F95(
	void* instance,
	void* TheExtrem)
{
		 TColgp_Array1OfPnt &  _TheExtrem =*( TColgp_Array1OfPnt *)TheExtrem;
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
 	result->ExtremityPoints(			
_TheExtrem);
}
DECL_EXPORT void AIS_Trihedron_UnsetColor(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT void AIS_Trihedron_UnsetWidth(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
 	result->UnsetWidth();
}
DECL_EXPORT void AIS_Trihedron_SetComponent(void* instance, void* value)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
		result->SetComponent(*(const Handle_Geom_Axis2Placement *)value);
}

DECL_EXPORT void* AIS_Trihedron_Component(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_Geom_Axis2Placement(	result->Component());
}

DECL_EXPORT bool AIS_Trihedron_HasOwnSize(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	result->HasOwnSize();
}

DECL_EXPORT void AIS_Trihedron_SetSize(void* instance, double value)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
		result->SetSize(value);
}

DECL_EXPORT double AIS_Trihedron_Size(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	result->Size();
}

DECL_EXPORT void* AIS_Trihedron_XAxis(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_AIS_Axis(	result->XAxis());
}

DECL_EXPORT void* AIS_Trihedron_YAxis(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_AIS_Axis(	result->YAxis());
}

DECL_EXPORT void* AIS_Trihedron_Axis(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_AIS_Axis(	result->Axis());
}

DECL_EXPORT void* AIS_Trihedron_Position(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_AIS_Point(	result->Position());
}

DECL_EXPORT void* AIS_Trihedron_XYPlane(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_AIS_Plane(	result->XYPlane());
}

DECL_EXPORT void* AIS_Trihedron_XZPlane(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_AIS_Plane(	result->XZPlane());
}

DECL_EXPORT void* AIS_Trihedron_YZPlane(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	new Handle_AIS_Plane(	result->YZPlane());
}

DECL_EXPORT void AIS_Trihedron_SetContext(void* instance, void* value)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
		result->SetContext(*(const Handle_AIS_InteractiveContext *)value);
}

DECL_EXPORT void AIS_Trihedron_SetLocation(void* instance, void* value)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
		result->SetLocation(*(const TopLoc_Location *)value);
}

DECL_EXPORT int AIS_Trihedron_Signature(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	result->Signature();
}

DECL_EXPORT int AIS_Trihedron_Type(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT bool AIS_Trihedron_HasTextColor(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	result->HasTextColor();
}

DECL_EXPORT void AIS_Trihedron_SetTextColor(void* instance, int value)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
		result->SetTextColor((const Quantity_NameOfColor)value);
}

DECL_EXPORT int AIS_Trihedron_TextColor(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return (int)	result->TextColor();
}

DECL_EXPORT bool AIS_Trihedron_HasArrowColor(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return 	result->HasArrowColor();
}

DECL_EXPORT void AIS_Trihedron_SetArrowColor(void* instance, int value)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
		result->SetArrowColor((const Quantity_NameOfColor)value);
}

DECL_EXPORT int AIS_Trihedron_ArrowColor(void* instance)
{
	AIS_Trihedron* result = (AIS_Trihedron*)(((Handle_AIS_Trihedron*)instance)->Access());
	return (int)	result->ArrowColor();
}

DECL_EXPORT void AISTrihedron_Dtor(void* instance)
{
	delete (Handle_AIS_Trihedron*)instance;
}
