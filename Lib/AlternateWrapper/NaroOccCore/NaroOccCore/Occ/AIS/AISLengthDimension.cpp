#include "AISLengthDimension.h"
#include <AIS_LengthDimension.hxx>


DECL_EXPORT void* AIS_LengthDimension_CtorE30AADB(
	void* aFirstFace,
	void* aSecondFace,
	double aVal,
	void* aText)
{
		const TopoDS_Face &  _aFirstFace =*(const TopoDS_Face *)aFirstFace;
		const TopoDS_Face &  _aSecondFace =*(const TopoDS_Face *)aSecondFace;
		const TCollection_ExtendedString &  _aText =*(const TCollection_ExtendedString *)aText;
	return new Handle_AIS_LengthDimension(new AIS_LengthDimension(			
_aFirstFace,			
_aSecondFace,			
aVal,			
_aText));
}
DECL_EXPORT void* AIS_LengthDimension_Ctor5485084F(
	void* aFirstFace,
	void* aSecondFace,
	double aVal,
	void* aText,
	void* aPosition,
	int aSymbolPrs,
	double anArrowSize)
{
		const TopoDS_Face &  _aFirstFace =*(const TopoDS_Face *)aFirstFace;
		const TopoDS_Face &  _aSecondFace =*(const TopoDS_Face *)aSecondFace;
		const TCollection_ExtendedString &  _aText =*(const TCollection_ExtendedString *)aText;
		const gp_Pnt &  _aPosition =*(const gp_Pnt *)aPosition;
		const DsgPrs_ArrowSide _aSymbolPrs =(const DsgPrs_ArrowSide )aSymbolPrs;
	return new Handle_AIS_LengthDimension(new AIS_LengthDimension(			
_aFirstFace,			
_aSecondFace,			
aVal,			
_aText,			
_aPosition,			
_aSymbolPrs,			
anArrowSize));
}
DECL_EXPORT void* AIS_LengthDimension_CtorC2ADA788(
	void* Face,
	void* Edge,
	double Val,
	void* Text)
{
		const TopoDS_Face &  _Face =*(const TopoDS_Face *)Face;
		const TopoDS_Edge &  _Edge =*(const TopoDS_Edge *)Edge;
		const TCollection_ExtendedString &  _Text =*(const TCollection_ExtendedString *)Text;
	return new Handle_AIS_LengthDimension(new AIS_LengthDimension(			
_Face,			
_Edge,			
Val,			
_Text));
}
DECL_EXPORT void* AIS_LengthDimension_CtorFBAAB8FA(
	void* aFShape,
	void* aSShape,
	void* aPlane,
	double aVal,
	void* aText)
{
		const TopoDS_Shape &  _aFShape =*(const TopoDS_Shape *)aFShape;
		const TopoDS_Shape &  _aSShape =*(const TopoDS_Shape *)aSShape;
		const Handle_Geom_Plane&  _aPlane =*(const Handle_Geom_Plane *)aPlane;
		const TCollection_ExtendedString &  _aText =*(const TCollection_ExtendedString *)aText;
	return new Handle_AIS_LengthDimension(new AIS_LengthDimension(			
_aFShape,			
_aSShape,			
_aPlane,			
aVal,			
_aText));
}
DECL_EXPORT void* AIS_LengthDimension_CtorEA089509(
	void* aFShape,
	void* aSShape,
	void* aPlane,
	double aVal,
	void* aText,
	void* aPosition,
	int aSymbolPrs,
	int aTypeDist,
	double anArrowSize)
{
		const TopoDS_Shape &  _aFShape =*(const TopoDS_Shape *)aFShape;
		const TopoDS_Shape &  _aSShape =*(const TopoDS_Shape *)aSShape;
		const Handle_Geom_Plane&  _aPlane =*(const Handle_Geom_Plane *)aPlane;
		const TCollection_ExtendedString &  _aText =*(const TCollection_ExtendedString *)aText;
		const gp_Pnt &  _aPosition =*(const gp_Pnt *)aPosition;
		const DsgPrs_ArrowSide _aSymbolPrs =(const DsgPrs_ArrowSide )aSymbolPrs;
		const AIS_TypeOfDist _aTypeDist =(const AIS_TypeOfDist )aTypeDist;
	return new Handle_AIS_LengthDimension(new AIS_LengthDimension(			
_aFShape,			
_aSShape,			
_aPlane,			
aVal,			
_aText,			
_aPosition,			
_aSymbolPrs,			
_aTypeDist,			
anArrowSize));
}
DECL_EXPORT void AIS_LengthDimension_SetFirstShape(void* instance, void* value)
{
	AIS_LengthDimension* result = (AIS_LengthDimension*)(((Handle_AIS_LengthDimension*)instance)->Access());
		result->SetFirstShape(*(const TopoDS_Shape *)value);
}

DECL_EXPORT void AIS_LengthDimension_SetSecondShape(void* instance, void* value)
{
	AIS_LengthDimension* result = (AIS_LengthDimension*)(((Handle_AIS_LengthDimension*)instance)->Access());
		result->SetSecondShape(*(const TopoDS_Shape *)value);
}

DECL_EXPORT int AIS_LengthDimension_KindOfDimension(void* instance)
{
	AIS_LengthDimension* result = (AIS_LengthDimension*)(((Handle_AIS_LengthDimension*)instance)->Access());
	return (int)	result->KindOfDimension();
}

DECL_EXPORT bool AIS_LengthDimension_IsMovable(void* instance)
{
	AIS_LengthDimension* result = (AIS_LengthDimension*)(((Handle_AIS_LengthDimension*)instance)->Access());
	return 	result->IsMovable();
}

DECL_EXPORT void AIS_LengthDimension_SetTypeOfDist(void* instance, int value)
{
	AIS_LengthDimension* result = (AIS_LengthDimension*)(((Handle_AIS_LengthDimension*)instance)->Access());
		result->SetTypeOfDist((const AIS_TypeOfDist)value);
}

DECL_EXPORT int AIS_LengthDimension_TypeOfDist(void* instance)
{
	AIS_LengthDimension* result = (AIS_LengthDimension*)(((Handle_AIS_LengthDimension*)instance)->Access());
	return (int)	result->TypeOfDist();
}

DECL_EXPORT void AISLengthDimension_Dtor(void* instance)
{
	delete (Handle_AIS_LengthDimension*)instance;
}
