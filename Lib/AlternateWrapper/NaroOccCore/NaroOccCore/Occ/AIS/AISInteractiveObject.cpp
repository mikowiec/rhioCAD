#include "AISInteractiveObject.h"
#include <AIS_InteractiveObject.hxx>

#include <AIS_Drawer.hxx>
#include <AIS_InteractiveContext.hxx>
#include <Geom_Transformation.hxx>
#include <Standard_Transient.hxx>

DECL_EXPORT void AIS_InteractiveObject_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_InteractiveObject_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void AIS_InteractiveObject_UnsetColor(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetColor();
}
DECL_EXPORT void AIS_InteractiveObject_UnsetWidth(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetWidth();
}
DECL_EXPORT bool AIS_InteractiveObject_AcceptDisplayModeE8219145(
	void* instance,
	int aMode)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return  	result->AcceptDisplayMode(			
aMode);
}
DECL_EXPORT void AIS_InteractiveObject_Redisplay461FC46A(
	void* instance,
	bool AllModes)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->Redisplay(			
AllModes);
}
DECL_EXPORT void AIS_InteractiveObject_ClearOwner(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->ClearOwner();
}
DECL_EXPORT void AIS_InteractiveObject_AddUserF411CB01(
	void* instance,
	void* aUser)
{
		const Handle_Standard_Transient&  _aUser =*(const Handle_Standard_Transient *)aUser;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->AddUser(			
_aUser);
}
DECL_EXPORT void AIS_InteractiveObject_ClearUsers(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->ClearUsers();
}
DECL_EXPORT void AIS_InteractiveObject_UnsetDisplayMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetDisplayMode();
}
DECL_EXPORT void AIS_InteractiveObject_UnsetSelectionMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetSelectionMode();
}
DECL_EXPORT void AIS_InteractiveObject_UnsetSelectionPriority(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetSelectionPriority();
}
DECL_EXPORT void AIS_InteractiveObject_UnsetHilightMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetHilightMode();
}
DECL_EXPORT int AIS_InteractiveObject_Color(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return  	result->Color();
}
DECL_EXPORT void AIS_InteractiveObject_Color8FD7F48(
	void* instance,
	void* aColor)
{
		 Quantity_Color &  _aColor =*( Quantity_Color *)aColor;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->Color(			
_aColor);
}
DECL_EXPORT int AIS_InteractiveObject_Material(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return  	result->Material();
}
DECL_EXPORT void AIS_InteractiveObject_SetMaterialE047B55B(
	void* instance,
	int aName)
{
		const Graphic3d_NameOfMaterial _aName =(const Graphic3d_NameOfMaterial )aName;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->SetMaterial(			
_aName);
}
DECL_EXPORT void AIS_InteractiveObject_SetMaterialC0044920(
	void* instance,
	void* aName)
{
		const Graphic3d_MaterialAspect &  _aName =*(const Graphic3d_MaterialAspect *)aName;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->SetMaterial(			
_aName);
}
DECL_EXPORT void AIS_InteractiveObject_UnsetMaterial(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetMaterial();
}
DECL_EXPORT void AIS_InteractiveObject_UnsetTransparency(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetTransparency();
}
DECL_EXPORT void AIS_InteractiveObject_UnsetAttributes(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetAttributes();
}
DECL_EXPORT void AIS_InteractiveObject_StateE8219145(
	void* instance,
	int theState)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->State(			
theState);
}
DECL_EXPORT int AIS_InteractiveObject_State(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return  	result->State();
}
DECL_EXPORT void AIS_InteractiveObject_SetDegenerateModelE6DFDFE0(
	void* instance,
	int aModel,
	double aRatio)
{
		const Aspect_TypeOfDegenerateModel _aModel =(const Aspect_TypeOfDegenerateModel )aModel;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->SetDegenerateModel(			
_aModel,			
aRatio);
}
DECL_EXPORT int AIS_InteractiveObject_DegenerateModelD82819F3(
	void* instance,
	double* aRatio)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return  	result->DegenerateModel(			
*aRatio);
}
DECL_EXPORT void AIS_InteractiveObject_SetTransformationA067E6E8(
	void* instance,
	void* aTranformation,
	bool postConcatenate,
	bool updateSelection)
{
		const Handle_Geom_Transformation&  _aTranformation =*(const Handle_Geom_Transformation *)aTranformation;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->SetTransformation(			
_aTranformation,			
postConcatenate,			
updateSelection);
}
DECL_EXPORT void AIS_InteractiveObject_UnsetTransformation(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->UnsetTransformation();
}
DECL_EXPORT void* AIS_InteractiveObject_Transformation(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return new Handle_Geom_Transformation( 	result->Transformation());
}
DECL_EXPORT void AIS_InteractiveObject_SetAspect93F6A493(
	void* instance,
	void* anAspect,
	bool globalChange)
{
		const Handle_Prs3d_BasicAspect&  _anAspect =*(const Handle_Prs3d_BasicAspect *)anAspect;
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
 	result->SetAspect(			
_anAspect,			
globalChange);
}
//DECL_EXPORT void AIS_InteractiveObject_SetPolygonOffsets306E0DFB(
//	void* instance,
//	int aMode,
//	double aFactor,
//	double aUnits)
//{
//	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
// 	result->SetPolygonOffsets(			
//aMode,			
//aFactor,			
//aUnits);
//}
//DECL_EXPORT void AIS_InteractiveObject_PolygonOffsets306E0DFB(
//	void* instance,
//	int aMode,
//	double aFactor,
//	double aUnits)
//{
//	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
// 	result->PolygonOffsets(			
//aMode,			
//aFactor,			
//aUnits);
//}
DECL_EXPORT int AIS_InteractiveObject_Type(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT int AIS_InteractiveObject_Signature(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->Signature();
}

DECL_EXPORT bool AIS_InteractiveObject_AcceptShapeDecomposition(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->AcceptShapeDecomposition();
}

DECL_EXPORT void AIS_InteractiveObject_SetCurrentFacingModel(void* instance, int value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetCurrentFacingModel((const Aspect_TypeOfFacingModel)value);
}

DECL_EXPORT int AIS_InteractiveObject_CurrentFacingModel(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return (int)	result->CurrentFacingModel();
}

DECL_EXPORT int AIS_InteractiveObject_DefaultDisplayMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->DefaultDisplayMode();
}

DECL_EXPORT void AIS_InteractiveObject_SetInfiniteState(void* instance, bool value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetInfiniteState(value);
}

DECL_EXPORT bool AIS_InteractiveObject_IsInfinite(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->IsInfinite();
}

DECL_EXPORT bool AIS_InteractiveObject_HasInteractiveContext(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasInteractiveContext();
}

DECL_EXPORT void* AIS_InteractiveObject_GetContext(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	new Handle_AIS_InteractiveContext(	result->GetContext());
}

DECL_EXPORT void AIS_InteractiveObject_SetContext(void* instance, void* value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetContext(*(const Handle_AIS_InteractiveContext *)value);
}

DECL_EXPORT bool AIS_InteractiveObject_HasOwner(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasOwner();
}

DECL_EXPORT void* AIS_InteractiveObject_GetOwner(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	new Handle_Standard_Transient(	result->GetOwner());
}

DECL_EXPORT void AIS_InteractiveObject_SetOwner(void* instance, void* value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetOwner(*(const Handle_Standard_Transient *)value);
}

DECL_EXPORT bool AIS_InteractiveObject_HasUsers(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasUsers();
}

DECL_EXPORT bool AIS_InteractiveObject_HasDisplayMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasDisplayMode();
}

DECL_EXPORT void AIS_InteractiveObject_SetDisplayMode(void* instance, int value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetDisplayMode(value);
}

DECL_EXPORT int AIS_InteractiveObject_DisplayMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->DisplayMode();
}

DECL_EXPORT bool AIS_InteractiveObject_HasSelectionMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasSelectionMode();
}

DECL_EXPORT void AIS_InteractiveObject_SetSelectionMode(void* instance, int value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetSelectionMode(value);
}

DECL_EXPORT int AIS_InteractiveObject_SelectionMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->SelectionMode();
}

DECL_EXPORT void AIS_InteractiveObject_SetSelectionPriority(void* instance, int value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetSelectionPriority(value);
}

DECL_EXPORT int AIS_InteractiveObject_SelectionPriority(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->SelectionPriority();
}

DECL_EXPORT bool AIS_InteractiveObject_HasSelectionPriority(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasSelectionPriority();
}

DECL_EXPORT bool AIS_InteractiveObject_HasHilightMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasHilightMode();
}

DECL_EXPORT void AIS_InteractiveObject_SetHilightMode(void* instance, int value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetHilightMode(value);
}

DECL_EXPORT int AIS_InteractiveObject_HilightMode(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HilightMode();
}

DECL_EXPORT bool AIS_InteractiveObject_HasColor(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasColor();
}

DECL_EXPORT bool AIS_InteractiveObject_HasWidth(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasWidth();
}

DECL_EXPORT void AIS_InteractiveObject_SetWidth(void* instance, double value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetWidth(value);
}

DECL_EXPORT double AIS_InteractiveObject_Width(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->Width();
}

DECL_EXPORT bool AIS_InteractiveObject_HasMaterial(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasMaterial();
}

DECL_EXPORT bool AIS_InteractiveObject_IsTransparent(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->IsTransparent();
}

DECL_EXPORT void AIS_InteractiveObject_SetTransparency(void* instance, double value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetTransparency(value);
}

DECL_EXPORT double AIS_InteractiveObject_Transparency(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->Transparency();
}

DECL_EXPORT void AIS_InteractiveObject_SetAttributes(void* instance, void* value)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
		result->SetAttributes(*(const Handle_AIS_Drawer *)value);
}

DECL_EXPORT void* AIS_InteractiveObject_Attributes(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	new Handle_AIS_Drawer(	result->Attributes());
}

DECL_EXPORT bool AIS_InteractiveObject_HasTransformation(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasTransformation();
}

DECL_EXPORT bool AIS_InteractiveObject_HasPresentation(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasPresentation();
}

DECL_EXPORT bool AIS_InteractiveObject_HasPolygonOffsets(void* instance)
{
	AIS_InteractiveObject* result = (AIS_InteractiveObject*)(((Handle_AIS_InteractiveObject*)instance)->Access());
	return 	result->HasPolygonOffsets();
}

DECL_EXPORT void AISInteractiveObject_Dtor(void* instance)
{
	delete (Handle_AIS_InteractiveObject*)instance;
}
