#include "AISDiameterDimension.h"
#include <AIS_DiameterDimension.hxx>


DECL_EXPORT void* AIS_DiameterDimension_Ctor1C945158(
	void* aShape,
	double aVal,
	void* aText)
{
		const TopoDS_Shape &  _aShape =*(const TopoDS_Shape *)aShape;
		const TCollection_ExtendedString &  _aText =*(const TCollection_ExtendedString *)aText;
	return new Handle_AIS_DiameterDimension(new AIS_DiameterDimension(			
_aShape,			
aVal,			
_aText));
}
DECL_EXPORT void* AIS_DiameterDimension_Ctor54910EE4(
	void* aShape,
	double aVal,
	void* aText,
	void* aPosition,
	int aSymbolPrs,
	bool aDiamSymbol,
	double anArrowSize)
{
		const TopoDS_Shape &  _aShape =*(const TopoDS_Shape *)aShape;
		const TCollection_ExtendedString &  _aText =*(const TCollection_ExtendedString *)aText;
		const gp_Pnt &  _aPosition =*(const gp_Pnt *)aPosition;
		const DsgPrs_ArrowSide _aSymbolPrs =(const DsgPrs_ArrowSide )aSymbolPrs;
	return new Handle_AIS_DiameterDimension(new AIS_DiameterDimension(			
_aShape,			
aVal,			
_aText,			
_aPosition,			
_aSymbolPrs,			
aDiamSymbol,			
anArrowSize));
}
DECL_EXPORT int AIS_DiameterDimension_KindOfDimension(void* instance)
{
	AIS_DiameterDimension* result = (AIS_DiameterDimension*)(((Handle_AIS_DiameterDimension*)instance)->Access());
	return (int)	result->KindOfDimension();
}

DECL_EXPORT bool AIS_DiameterDimension_IsMovable(void* instance)
{
	AIS_DiameterDimension* result = (AIS_DiameterDimension*)(((Handle_AIS_DiameterDimension*)instance)->Access());
	return 	result->IsMovable();
}

DECL_EXPORT void AIS_DiameterDimension_SetDiamSymbol(void* instance, bool value)
{
	AIS_DiameterDimension* result = (AIS_DiameterDimension*)(((Handle_AIS_DiameterDimension*)instance)->Access());
		result->SetDiamSymbol(value);
}

DECL_EXPORT bool AIS_DiameterDimension_DiamSymbol(void* instance)
{
	AIS_DiameterDimension* result = (AIS_DiameterDimension*)(((Handle_AIS_DiameterDimension*)instance)->Access());
	return 	result->DiamSymbol();
}

DECL_EXPORT void AISDiameterDimension_Dtor(void* instance)
{
	delete (Handle_AIS_DiameterDimension*)instance;
}
