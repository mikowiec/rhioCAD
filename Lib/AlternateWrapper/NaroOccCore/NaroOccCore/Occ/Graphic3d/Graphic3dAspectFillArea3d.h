#ifndef Graphic3d_AspectFillArea3d_H
#define Graphic3d_AspectFillArea3d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_AspectFillArea3d_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_AspectFillArea3d_Ctor173C01E9(
	int Interior,
	void* InteriorColor,
	void* EdgeColor,
	int EdgeLineType,
	double EdgeWidth,
	void* FrontMaterial,
	void* BackMaterial);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_AllowBackFace(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDistinguishOn(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDistinguishOff(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetEdgeOn(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetEdgeOff(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SuppressBackFace(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetTextureMapOn(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetTextureMapOff(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDefaultDegenerateModelE6DFDFE0(
	int aModel,
	double aRatio);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDegenerateModelE6DFDFE0(
	void* instance,
	int aModel,
	double aRatio);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetPolygonOffsets306E0DFB(
	void* instance,
	int aMode,
	double aFactor,
	double aUnits);
extern "C" DECL_EXPORT int Graphic3d_AspectFillArea3d_DegenerateModelD82819F3(
	void* instance,
	double* aRatio);
extern "C" DECL_EXPORT int Graphic3d_AspectFillArea3d_DefaultDegenerateModelD82819F3(
	double* aRatio);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_PolygonOffsets306E0DFB(
	void* instance,
	int* aMode,
	double* aFactor,
	double* aUnits);
extern "C" DECL_EXPORT bool Graphic3d_AspectFillArea3d_BackFace(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_AspectFillArea3d_Distinguish(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_AspectFillArea3d_Edge(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetBackMaterial(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_AspectFillArea3d_BackMaterial(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectFillArea3d_SetFrontMaterial(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_AspectFillArea3d_FrontMaterial(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_AspectFillArea3d_TextureMapState(void* instance);
extern "C" DECL_EXPORT void Graphic3dAspectFillArea3d_Dtor(void* instance);

#endif
