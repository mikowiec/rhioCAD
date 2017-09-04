#include "AISLine.h"
#include <AIS_Line.hxx>

#include <Geom_Line.hxx>

DECL_EXPORT void* AIS_Line_Ctor7C3C08A3(
	void* aLine)
{
		const Handle_Geom_Line&  _aLine =*(const Handle_Geom_Line *)aLine;
	return new Handle_AIS_Line(new AIS_Line(			
_aLine));
}
DECL_EXPORT void* AIS_Line_Ctor2A4E6D38(
	void* aStartPoint,
	void* aEndPoint)
{
		const Handle_Geom_Point&  _aStartPoint =*(const Handle_Geom_Point *)aStartPoint;
		const Handle_Geom_Point&  _aEndPoint =*(const Handle_Geom_Point *)aEndPoint;
	return new Handle_AIS_Line(new AIS_Line(			
_aStartPoint,			
_aEndPoint));
}
DECL_EXPORT void AIS_Line_Points2A4E6D38(
	void* instance,
	void* PStart,
	void* PEnd)
{
		 Handle_Geom_Point&  _PStart =*( Handle_Geom_Point *)PStart;
		 Handle_Geom_Point&  _PEnd =*( Handle_Geom_Point *)PEnd;
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
 	result->Points(			
_PStart,			
_PEnd);
}
DECL_EXPORT void AIS_Line_SetPoints2A4E6D38(
	void* instance,
	void* P1,
	void* P2)
{
		const Handle_Geom_Point&  _P1 =*(const Handle_Geom_Point *)P1;
		const Handle_Geom_Point&  _P2 =*(const Handle_Geom_Point *)P2;
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
 	result->SetPoints(			
_P1,			
_P2);
}
DECL_EXPORT void AIS_Line_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Line_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Line_UnsetColor(void* instance)
{
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT void AIS_Line_UnsetWidth(void* instance)
{
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
 	result->UnsetWidth();
}
DECL_EXPORT int AIS_Line_Signature(void* instance)
{
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
	return 	result->Signature();
}

DECL_EXPORT int AIS_Line_Type(void* instance)
{
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT void AIS_Line_SetLine(void* instance, void* value)
{
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
		result->SetLine(*(const Handle_Geom_Line *)value);
}

DECL_EXPORT void* AIS_Line_Line(void* instance)
{
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
	return 	new Handle_Geom_Line(	result->Line());
}

DECL_EXPORT void AIS_Line_SetWidth(void* instance, double value)
{
	AIS_Line* result = (AIS_Line*)(((Handle_AIS_Line*)instance)->Access());
		result->SetWidth(value);
}

DECL_EXPORT void AISLine_Dtor(void* instance)
{
	delete (Handle_AIS_Line*)instance;
}
