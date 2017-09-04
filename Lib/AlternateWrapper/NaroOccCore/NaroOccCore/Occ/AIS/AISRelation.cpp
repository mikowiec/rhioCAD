#include "AISRelation.h"
#include <AIS_Relation.hxx>

#include <Geom_Plane.hxx>
#include <gp_Pnt.hxx>
#include <TCollection_ExtendedString.hxx>
#include <TopoDS_Shape.hxx>

DECL_EXPORT void AIS_Relation_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Relation_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Relation_UnsetColor(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT void AIS_Relation_SetBndBoxBC7A5786(
	void* instance,
	double Xmin,
	double Ymin,
	double Zmin,
	double Xmax,
	double Ymax,
	double Zmax)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
 	result->SetBndBox(			
Xmin,			
Ymin,			
Zmin,			
Xmax,			
Ymax,			
Zmax);
}
DECL_EXPORT void AIS_Relation_UnsetBndBox(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
 	result->UnsetBndBox();
}
DECL_EXPORT bool AIS_Relation_AcceptDisplayModeE8219145(
	void* instance,
	int aMode)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return  	result->AcceptDisplayMode(			
aMode);
}
DECL_EXPORT int AIS_Relation_Type(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT int AIS_Relation_KindOfDimension(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return (int)	result->KindOfDimension();
}

DECL_EXPORT bool AIS_Relation_IsMovable(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	result->IsMovable();
}

DECL_EXPORT void AIS_Relation_SetFirstShape(void* instance, void* value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetFirstShape(*(const TopoDS_Shape *)value);
}

DECL_EXPORT void* AIS_Relation_FirstShape(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	new TopoDS_Shape(	result->FirstShape());
}

DECL_EXPORT void AIS_Relation_SetSecondShape(void* instance, void* value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetSecondShape(*(const TopoDS_Shape *)value);
}

DECL_EXPORT void* AIS_Relation_SecondShape(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	new TopoDS_Shape(	result->SecondShape());
}

DECL_EXPORT void AIS_Relation_SetPlane(void* instance, void* value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetPlane(*(const Handle_Geom_Plane *)value);
}

DECL_EXPORT void* AIS_Relation_Plane(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	new Handle_Geom_Plane(	result->Plane());
}

DECL_EXPORT void AIS_Relation_SetValue(void* instance, double value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetValue(value);
}

DECL_EXPORT double AIS_Relation_Value(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	result->Value();
}

DECL_EXPORT void AIS_Relation_SetPosition(void* instance, void* value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetPosition(*(const gp_Pnt *)value);
}

DECL_EXPORT void* AIS_Relation_Position(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	new gp_Pnt(	result->Position());
}

DECL_EXPORT void AIS_Relation_SetText(void* instance, void* value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetText(*(const TCollection_ExtendedString *)value);
}

DECL_EXPORT void* AIS_Relation_Text(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Text());
}

DECL_EXPORT void AIS_Relation_SetArrowSize(void* instance, double value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetArrowSize(value);
}

DECL_EXPORT double AIS_Relation_ArrowSize(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	result->ArrowSize();
}

DECL_EXPORT void AIS_Relation_SetSymbolPrs(void* instance, int value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetSymbolPrs((const DsgPrs_ArrowSide)value);
}

DECL_EXPORT int AIS_Relation_SymbolPrs(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return (int)	result->SymbolPrs();
}

DECL_EXPORT void AIS_Relation_SetExtShape(void* instance, int value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetExtShape(value);
}

DECL_EXPORT int AIS_Relation_ExtShape(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	result->ExtShape();
}

DECL_EXPORT void AIS_Relation_SetAutomaticPosition(void* instance, bool value)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
		result->SetAutomaticPosition(value);
}

DECL_EXPORT bool AIS_Relation_AutomaticPosition(void* instance)
{
	AIS_Relation* result = (AIS_Relation*)(((Handle_AIS_Relation*)instance)->Access());
	return 	result->AutomaticPosition();
}

DECL_EXPORT void AISRelation_Dtor(void* instance)
{
	delete (Handle_AIS_Relation*)instance;
}
