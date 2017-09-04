#include "AISShape.h"
#include <AIS_Shape.hxx>

#include <Bnd_Box.hxx>
#include <TopoDS_Shape.hxx>

DECL_EXPORT void* AIS_Shape_Ctor9EBAC0C0(
	void* shap)
{
		const TopoDS_Shape &  _shap =*(const TopoDS_Shape *)shap;
	return new Handle_AIS_Shape(new AIS_Shape(			
_shap));
}
DECL_EXPORT void AIS_Shape_Set9EBAC0C0(
	void* instance,
	void* ashap)
{
		const TopoDS_Shape &  _ashap =*(const TopoDS_Shape *)ashap;
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->Set(			
_ashap);
}
DECL_EXPORT bool AIS_Shape_SetOwnDeviationCoefficient(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->SetOwnDeviationCoefficient();
}
DECL_EXPORT bool AIS_Shape_SetOwnHLRDeviationCoefficient(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->SetOwnHLRDeviationCoefficient();
}
DECL_EXPORT bool AIS_Shape_SetOwnDeviationAngle(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->SetOwnDeviationAngle();
}
DECL_EXPORT bool AIS_Shape_SetOwnHLRDeviationAngle(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->SetOwnHLRDeviationAngle();
}
DECL_EXPORT void AIS_Shape_SetOwnDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetOwnDeviationCoefficient(			
aCoefficient);
}
DECL_EXPORT void AIS_Shape_SetOwnHLRDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetOwnHLRDeviationCoefficient(			
aCoefficient);
}
DECL_EXPORT void AIS_Shape_SetOwnDeviationAngleD82819F3(
	void* instance,
	double anAngle)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetOwnDeviationAngle(			
anAngle);
}
DECL_EXPORT void AIS_Shape_SetOwnHLRDeviationAngleD82819F3(
	void* instance,
	double anAngle)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetOwnHLRDeviationAngle(			
anAngle);
}
DECL_EXPORT bool AIS_Shape_OwnDeviationCoefficient9F0E714F(
	void* instance,
	double* aCoefficient,
	double* aPreviousCoefficient)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->OwnDeviationCoefficient(			
*aCoefficient,			
*aPreviousCoefficient);
}
DECL_EXPORT bool AIS_Shape_OwnHLRDeviationCoefficient9F0E714F(
	void* instance,
	double* aCoefficient,
	double* aPreviousCoefficient)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->OwnHLRDeviationCoefficient(			
*aCoefficient,			
*aPreviousCoefficient);
}
DECL_EXPORT bool AIS_Shape_OwnDeviationAngle9F0E714F(
	void* instance,
	double* anAngle,
	double* aPreviousAngle)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->OwnDeviationAngle(			
*anAngle,			
*aPreviousAngle);
}
DECL_EXPORT bool AIS_Shape_OwnHLRDeviationAngle9F0E714F(
	void* instance,
	double* anAngle,
	double* aPreviousAngle)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->OwnHLRDeviationAngle(			
*anAngle,			
*aPreviousAngle);
}
DECL_EXPORT void AIS_Shape_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Shape_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_Shape_UnsetColor(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT void AIS_Shape_UnsetWidth(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->UnsetWidth();
}
DECL_EXPORT void AIS_Shape_SetMaterialE047B55B(
	void* instance,
	int aName)
{
		const Graphic3d_NameOfMaterial _aName =(const Graphic3d_NameOfMaterial )aName;
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetMaterial(			
_aName);
}
DECL_EXPORT void AIS_Shape_SetMaterialC0044920(
	void* instance,
	void* aName)
{
		const Graphic3d_MaterialAspect &  _aName =*(const Graphic3d_MaterialAspect *)aName;
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->SetMaterial(			
_aName);
}
DECL_EXPORT void AIS_Shape_UnsetMaterial(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->UnsetMaterial();
}
DECL_EXPORT void AIS_Shape_UnsetTransparency(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->UnsetTransparency();
}
DECL_EXPORT int AIS_Shape_Color(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->Color();
}
DECL_EXPORT void AIS_Shape_Color8FD7F48(
	void* instance,
	void* aColor)
{
		 Quantity_Color &  _aColor =*( Quantity_Color *)aColor;
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
 	result->Color(			
_aColor);
}
DECL_EXPORT int AIS_Shape_Material(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return  	result->Material();
}
DECL_EXPORT int AIS_Shape_SelectionTypeE8219145(
	int aDecompositionMode)
{
	return  AIS_Shape::SelectionType(			
aDecompositionMode);
}
DECL_EXPORT int AIS_Shape_SelectionModeC6FD32C4(
	int aShapeType)
{
		const TopAbs_ShapeEnum _aShapeType =(const TopAbs_ShapeEnum )aShapeType;
	return  AIS_Shape::SelectionMode(			
_aShapeType);
}
DECL_EXPORT double AIS_Shape_GetDeflectionC3E71CA1(
	void* aShape,
	void* aDrawer)
{
		const TopoDS_Shape &  _aShape =*(const TopoDS_Shape *)aShape;
		const Handle_Prs3d_Drawer&  _aDrawer =*(const Handle_Prs3d_Drawer *)aDrawer;
	return  AIS_Shape::GetDeflection(			
_aShape,			
_aDrawer);
}
DECL_EXPORT int AIS_Shape_Signature(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return 	result->Signature();
}

DECL_EXPORT int AIS_Shape_Type(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT bool AIS_Shape_AcceptShapeDecomposition(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return 	result->AcceptShapeDecomposition();
}

DECL_EXPORT void* AIS_Shape_Shape(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return 	new TopoDS_Shape(	result->Shape());
}

DECL_EXPORT void AIS_Shape_SetAngleAndDeviation(void* instance, double value)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
		result->SetAngleAndDeviation(value);
}

DECL_EXPORT double AIS_Shape_UserAngle(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return 	result->UserAngle();
}

DECL_EXPORT void AIS_Shape_SetHLRAngleAndDeviation(void* instance, double value)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
		result->SetHLRAngleAndDeviation(value);
}

DECL_EXPORT void AIS_Shape_SetWidth(void* instance, double value)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
		result->SetWidth(value);
}

DECL_EXPORT void* AIS_Shape_BoundingBox(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return 	new Bnd_Box(	result->BoundingBox());
}

DECL_EXPORT void AIS_Shape_SetTransparency(void* instance, double value)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
		result->SetTransparency(value);
}

DECL_EXPORT double AIS_Shape_Transparency(void* instance)
{
	AIS_Shape* result = (AIS_Shape*)(((Handle_AIS_Shape*)instance)->Access());
	return 	result->Transparency();
}

DECL_EXPORT void AISShape_Dtor(void* instance)
{
	delete (Handle_AIS_Shape*)instance;
}
