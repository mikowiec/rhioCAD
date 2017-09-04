#ifndef Prs3d_ShadingAspect_H
#define Prs3d_ShadingAspect_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs3d_ShadingAspect_Ctor();
extern "C" DECL_EXPORT void Prs3d_ShadingAspect_SetColor91B95C7E(
	void* instance,
	void* aColor,
	int aModel);
extern "C" DECL_EXPORT void Prs3d_ShadingAspect_SetColor6AB9C7E3(
	void* instance,
	int aColor,
	int aModel);
extern "C" DECL_EXPORT void Prs3d_ShadingAspect_SetMaterial4216C4F1(
	void* instance,
	void* aMaterial,
	int aModel);
extern "C" DECL_EXPORT void Prs3d_ShadingAspect_SetMaterialC75397AB(
	void* instance,
	int aMaterial,
	int aModel);
extern "C" DECL_EXPORT void Prs3d_ShadingAspect_SetTransparencyEE7B4701(
	void* instance,
	double aValue,
	int aModel);
extern "C" DECL_EXPORT void* Prs3d_ShadingAspect_ColorAE582B9F(
	void* instance,
	int aModel);
extern "C" DECL_EXPORT void* Prs3d_ShadingAspect_MaterialAE582B9F(
	void* instance,
	int aModel);
extern "C" DECL_EXPORT double Prs3d_ShadingAspect_TransparencyAE582B9F(
	void* instance,
	int aModel);
extern "C" DECL_EXPORT void Prs3d_ShadingAspect_SetAspect(void* instance, void* value);
extern "C" DECL_EXPORT void* Prs3d_ShadingAspect_Aspect(void* instance);
extern "C" DECL_EXPORT void Prs3dShadingAspect_Dtor(void* instance);

#endif
