#ifndef Graphic3d_MaterialAspect_H
#define Graphic3d_MaterialAspect_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_MaterialAspect_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_MaterialAspect_CtorE047B55B(
	int AName);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_IncreaseShineD82819F3(
	void* instance,
	double ADelta);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetMaterialType34A704C6(
	void* instance,
	int AType);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetMaterialName9381D4D(
	void* instance,
	char* AName);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_Reset(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_MaterialAspect_ReflectionModeC74D89AD(
	void* instance,
	int AType);
extern "C" DECL_EXPORT bool Graphic3d_MaterialAspect_MaterialType34A704C6(
	void* instance,
	int AType);
extern "C" DECL_EXPORT bool Graphic3d_MaterialAspect_IsDifferentC0044920(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool Graphic3d_MaterialAspect_IsEqualC0044920(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT Standard_CString Graphic3d_MaterialAspect_MaterialNameE8219145(
	int aRank);
extern "C" DECL_EXPORT Standard_CString Graphic3d_MaterialAspect_MaterialName(void* instance);
extern "C" DECL_EXPORT int Graphic3d_MaterialAspect_MaterialTypeE8219145(
	int aRank);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetReflectionModeOn(void* instance, int value);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetReflectionModeOff(void* instance, int value);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_MaterialAspect_Color(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetAmbientColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_MaterialAspect_AmbientColor(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetDiffuseColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_MaterialAspect_DiffuseColor(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetSpecularColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_MaterialAspect_SpecularColor(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetEmissiveColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_MaterialAspect_EmissiveColor(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetAmbient(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_MaterialAspect_Ambient(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetDiffuse(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_MaterialAspect_Diffuse(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetSpecular(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_MaterialAspect_Specular(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetTransparency(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_MaterialAspect_Transparency(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetEmissive(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_MaterialAspect_Emissive(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetShininess(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_MaterialAspect_Shininess(void* instance);
extern "C" DECL_EXPORT void Graphic3d_MaterialAspect_SetEnvReflexion(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_MaterialAspect_EnvReflexion(void* instance);
extern "C" DECL_EXPORT int Graphic3d_MaterialAspect_Name(void* instance);
extern "C" DECL_EXPORT int Graphic3d_MaterialAspect_NumberOfMaterials();
extern "C" DECL_EXPORT void Graphic3dMaterialAspect_Dtor(void* instance);

#endif
