#ifndef PrsMgr_PresentableObject_H
#define PrsMgr_PresentableObject_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void PrsMgr_PresentableObject_SetToUpdateE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentableObject_SetToUpdate(void* instance);
extern "C" DECL_EXPORT void PrsMgr_PresentableObject_ResetLocation(void* instance);
extern "C" DECL_EXPORT void PrsMgr_PresentableObject_UpdateLocation(void* instance);
extern "C" DECL_EXPORT void PrsMgr_PresentableObject_SetZLayerC5F895E9(
	void* instance,
	void* thePrsMgr,
	int theLayerId);
extern "C" DECL_EXPORT int PrsMgr_PresentableObject_GetZLayer56269ED1(
	void* instance,
	void* thePrsMgr);
extern "C" DECL_EXPORT int PrsMgr_PresentableObject_TypeOfPresentation3d(void* instance);
extern "C" DECL_EXPORT void* PrsMgr_PresentableObject_GetTransformPersistencePoint(void* instance);
extern "C" DECL_EXPORT void PrsMgr_PresentableObject_SetTypeOfPresentation(void* instance, int value);
extern "C" DECL_EXPORT bool PrsMgr_PresentableObject_HasLocation(void* instance);
extern "C" DECL_EXPORT void PrsMgr_PresentableObject_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* PrsMgr_PresentableObject_Location(void* instance);
extern "C" DECL_EXPORT void PrsMgrPresentableObject_Dtor(void* instance);

#endif
