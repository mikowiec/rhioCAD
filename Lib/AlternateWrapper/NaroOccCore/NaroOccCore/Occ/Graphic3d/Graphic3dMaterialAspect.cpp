#include "Graphic3dMaterialAspect.h"
#include <Graphic3d_MaterialAspect.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Graphic3d_MaterialAspect_Ctor()
{
	return new Graphic3d_MaterialAspect();
}
DECL_EXPORT void* Graphic3d_MaterialAspect_CtorE047B55B(
	int AName)
{
		const Graphic3d_NameOfMaterial _AName =(const Graphic3d_NameOfMaterial )AName;
	return new Graphic3d_MaterialAspect(			
_AName);
}
DECL_EXPORT void Graphic3d_MaterialAspect_IncreaseShineD82819F3(
	void* instance,
	double ADelta)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
 	result->IncreaseShine(			
ADelta);
}
DECL_EXPORT void Graphic3d_MaterialAspect_SetMaterialType34A704C6(
	void* instance,
	int AType)
{
		const Graphic3d_TypeOfMaterial _AType =(const Graphic3d_TypeOfMaterial )AType;
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
 	result->SetMaterialType(			
_AType);
}
DECL_EXPORT void Graphic3d_MaterialAspect_SetMaterialName9381D4D(
	void* instance,
	char* AName)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
 	result->SetMaterialName(			
AName);
}
DECL_EXPORT void Graphic3d_MaterialAspect_Reset(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
 	result->Reset();
}
DECL_EXPORT bool Graphic3d_MaterialAspect_ReflectionModeC74D89AD(
	void* instance,
	int AType)
{
		const Graphic3d_TypeOfReflection _AType =(const Graphic3d_TypeOfReflection )AType;
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return  	result->ReflectionMode(			
_AType);
}
DECL_EXPORT bool Graphic3d_MaterialAspect_MaterialType34A704C6(
	void* instance,
	int AType)
{
		const Graphic3d_TypeOfMaterial _AType =(const Graphic3d_TypeOfMaterial )AType;
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return  	result->MaterialType(			
_AType);
}
DECL_EXPORT bool Graphic3d_MaterialAspect_IsDifferentC0044920(
	void* instance,
	void* Other)
{
		const Graphic3d_MaterialAspect &  _Other =*(const Graphic3d_MaterialAspect *)Other;
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return  	result->IsDifferent(			
_Other);
}
DECL_EXPORT bool Graphic3d_MaterialAspect_IsEqualC0044920(
	void* instance,
	void* Other)
{
		const Graphic3d_MaterialAspect &  _Other =*(const Graphic3d_MaterialAspect *)Other;
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT Standard_CString Graphic3d_MaterialAspect_MaterialNameE8219145(
	int aRank)
{
	return  Graphic3d_MaterialAspect::MaterialName(			
aRank);
}
DECL_EXPORT Standard_CString Graphic3d_MaterialAspect_MaterialName(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return  	result->MaterialName();
}
DECL_EXPORT int Graphic3d_MaterialAspect_MaterialTypeE8219145(
	int aRank)
{
	return  Graphic3d_MaterialAspect::MaterialType(			
aRank);
}
DECL_EXPORT void Graphic3d_MaterialAspect_SetReflectionModeOn(void* instance, int value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetReflectionModeOn((const Graphic3d_TypeOfReflection)value);
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetReflectionModeOff(void* instance, int value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetReflectionModeOff((const Graphic3d_TypeOfReflection)value);
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetColor(void* instance, void* value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Graphic3d_MaterialAspect_Color(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	new Quantity_Color(	result->Color());
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetAmbientColor(void* instance, void* value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetAmbientColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Graphic3d_MaterialAspect_AmbientColor(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	new Quantity_Color(	result->AmbientColor());
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetDiffuseColor(void* instance, void* value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetDiffuseColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Graphic3d_MaterialAspect_DiffuseColor(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	new Quantity_Color(	result->DiffuseColor());
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetSpecularColor(void* instance, void* value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetSpecularColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Graphic3d_MaterialAspect_SpecularColor(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	new Quantity_Color(	result->SpecularColor());
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetEmissiveColor(void* instance, void* value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetEmissiveColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Graphic3d_MaterialAspect_EmissiveColor(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	new Quantity_Color(	result->EmissiveColor());
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetAmbient(void* instance, double value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetAmbient(value);
}

DECL_EXPORT double Graphic3d_MaterialAspect_Ambient(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	result->Ambient();
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetDiffuse(void* instance, double value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetDiffuse(value);
}

DECL_EXPORT double Graphic3d_MaterialAspect_Diffuse(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	result->Diffuse();
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetSpecular(void* instance, double value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetSpecular(value);
}

DECL_EXPORT double Graphic3d_MaterialAspect_Specular(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	result->Specular();
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetTransparency(void* instance, double value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetTransparency(value);
}

DECL_EXPORT double Graphic3d_MaterialAspect_Transparency(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	result->Transparency();
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetEmissive(void* instance, double value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetEmissive(value);
}

DECL_EXPORT double Graphic3d_MaterialAspect_Emissive(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	result->Emissive();
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetShininess(void* instance, double value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetShininess(value);
}

DECL_EXPORT double Graphic3d_MaterialAspect_Shininess(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	result->Shininess();
}

DECL_EXPORT void Graphic3d_MaterialAspect_SetEnvReflexion(void* instance, double value)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
		result->SetEnvReflexion(value);
}

DECL_EXPORT double Graphic3d_MaterialAspect_EnvReflexion(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return 	result->EnvReflexion();
}

DECL_EXPORT int Graphic3d_MaterialAspect_Name(void* instance)
{
	Graphic3d_MaterialAspect* result = (Graphic3d_MaterialAspect*)instance;
	return (int)	result->Name();
}

DECL_EXPORT int Graphic3d_MaterialAspect_NumberOfMaterials()
{
	return Graphic3d_MaterialAspect::NumberOfMaterials();
}

DECL_EXPORT void Graphic3dMaterialAspect_Dtor(void* instance)
{
	delete (Graphic3d_MaterialAspect*)instance;
}
