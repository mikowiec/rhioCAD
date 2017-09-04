#include "AISPoint.h"
#include <AIS_Point.hxx>

#include <Geom_Point.hxx>
#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* AIS_Point_Ctor121385BD(
	void* aComponent)
{
		const Handle_Geom_Point&  _aComponent =*(const Handle_Geom_Point *)aComponent;
	return new Handle_AIS_Point(new AIS_Point(			
_aComponent));
}
DECL_EXPORT bool AIS_Point_AcceptDisplayModeE8219145(
	void* instance,
	int aMode)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
	return  	result->AcceptDisplayMode(			
aMode);
}
DECL_EXPORT void AIS_Point_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Point_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Point_UnsetColor(void* instance)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT void AIS_Point_UnsetMarker(void* instance)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
 	result->UnsetMarker();
}
DECL_EXPORT int AIS_Point_Signature(void* instance)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
	return 	result->Signature();
}

DECL_EXPORT int AIS_Point_Type(void* instance)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT void AIS_Point_SetComponent(void* instance, void* value)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
		result->SetComponent(*(const Handle_Geom_Point *)value);
}

DECL_EXPORT void* AIS_Point_Component(void* instance)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
	return 	new Handle_Geom_Point(	result->Component());
}

DECL_EXPORT void AIS_Point_SetMarker(void* instance, int value)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
		result->SetMarker((const Aspect_TypeOfMarker)value);
}

DECL_EXPORT bool AIS_Point_HasMarker(void* instance)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
	return 	result->HasMarker();
}

DECL_EXPORT void* AIS_Point_Vertex(void* instance)
{
	AIS_Point* result = (AIS_Point*)(((Handle_AIS_Point*)instance)->Access());
	return 	new TopoDS_Vertex(	result->Vertex());
}

DECL_EXPORT void AISPoint_Dtor(void* instance)
{
	delete (Handle_AIS_Point*)instance;
}
