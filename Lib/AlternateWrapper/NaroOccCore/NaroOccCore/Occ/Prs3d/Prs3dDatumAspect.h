#ifndef Prs3d_DatumAspect_H
#define Prs3d_DatumAspect_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs3d_DatumAspect_Ctor();
extern "C" DECL_EXPORT void Prs3d_DatumAspect_SetAxisLength9282A951(
	void* instance,
	double L1,
	double L2,
	double L3);
extern "C" DECL_EXPORT void* Prs3d_DatumAspect_FirstAxisAspect(void* instance);
extern "C" DECL_EXPORT void* Prs3d_DatumAspect_SecondAxisAspect(void* instance);
extern "C" DECL_EXPORT void* Prs3d_DatumAspect_ThirdAxisAspect(void* instance);
extern "C" DECL_EXPORT void Prs3d_DatumAspect_SetDrawFirstAndSecondAxis(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_DatumAspect_DrawFirstAndSecondAxis(void* instance);
extern "C" DECL_EXPORT void Prs3d_DatumAspect_SetDrawThirdAxis(void* instance, bool value);
extern "C" DECL_EXPORT bool Prs3d_DatumAspect_DrawThirdAxis(void* instance);
extern "C" DECL_EXPORT double Prs3d_DatumAspect_FirstAxisLength(void* instance);
extern "C" DECL_EXPORT double Prs3d_DatumAspect_SecondAxisLength(void* instance);
extern "C" DECL_EXPORT double Prs3d_DatumAspect_ThirdAxisLength(void* instance);
extern "C" DECL_EXPORT void Prs3dDatumAspect_Dtor(void* instance);

#endif
