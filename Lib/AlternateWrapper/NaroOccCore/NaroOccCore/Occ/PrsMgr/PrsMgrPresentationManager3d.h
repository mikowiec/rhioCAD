#ifndef PrsMgr_PresentationManager3d_H
#define PrsMgr_PresentationManager3d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* PrsMgr_PresentationManager3d_Ctor6B9CC1AA(
	void* aStructureManager);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_ColorB83441D9(
	void* instance,
	void* aPresentableObject,
	int aColor,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_BoundBox6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_BeginDraw(void* instance);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_EndDrawAD710B01(
	void* instance,
	void* aView,
	bool DoubleBuffer);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_ConnectDA51193F(
	void* instance,
	void* aPresentableObject,
	void* anOtherObject,
	int aMode,
	int anOtherMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_Transform17D81909(
	void* instance,
	void* aPresentableObject,
	void* aTransformation,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_PlaceDCA8B26(
	void* instance,
	void* aPresentableObject,
	double X,
	double Y,
	double Z,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_Multiply17D81909(
	void* instance,
	void* aPresentableObject,
	void* aTransformation,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_MoveDCA8B26(
	void* instance,
	void* aPresentableObject,
	double X,
	double Y,
	double Z,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_SetShadingAspect4A55E6F9(
	void* instance,
	void* aPresentableObject,
	int aColor,
	int aMaterial,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager3d_SetShadingAspect2BCEAF8F(
	void* instance,
	void* aPresentableObject,
	void* aShadingAspect,
	int aMode);
extern "C" DECL_EXPORT void* PrsMgr_PresentationManager3d_CastPresentation6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT bool PrsMgr_PresentationManager3d_Is3D(void* instance);
extern "C" DECL_EXPORT void* PrsMgr_PresentationManager3d_StructureManager(void* instance);
extern "C" DECL_EXPORT void PrsMgrPresentationManager3d_Dtor(void* instance);

#endif
