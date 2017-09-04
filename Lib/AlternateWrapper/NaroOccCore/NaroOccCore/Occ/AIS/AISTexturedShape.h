#ifndef AIS_TexturedShape_H
#define AIS_TexturedShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_TexturedShape_Ctor9EBAC0C0(
	void* shap);
extern "C" DECL_EXPORT void AIS_TexturedShape_SetTextureRepeatDA23FEE7(
	void* instance,
	bool RepeatYN,
	double URepeat,
	double VRepeat);
extern "C" DECL_EXPORT void AIS_TexturedShape_SetTextureOriginDA23FEE7(
	void* instance,
	bool SetTextureOriginYN,
	double UOrigin,
	double VOrigin);
extern "C" DECL_EXPORT void AIS_TexturedShape_SetTextureScaleDA23FEE7(
	void* instance,
	bool SetTextureScaleYN,
	double ScaleU,
	double ScaleV);
extern "C" DECL_EXPORT void AIS_TexturedShape_SetTextureMapOn(void* instance);
extern "C" DECL_EXPORT void AIS_TexturedShape_SetTextureMapOff(void* instance);
extern "C" DECL_EXPORT void AIS_TexturedShape_EnableTextureModulate(void* instance);
extern "C" DECL_EXPORT void AIS_TexturedShape_DisableTextureModulate(void* instance);
extern "C" DECL_EXPORT void AIS_TexturedShape_UpdateAttributes(void* instance);
extern "C" DECL_EXPORT bool AIS_TexturedShape_TextureRepeat(void* instance);
extern "C" DECL_EXPORT bool AIS_TexturedShape_TextureScale(void* instance);
extern "C" DECL_EXPORT bool AIS_TexturedShape_TextureOrigin(void* instance);
extern "C" DECL_EXPORT void AIS_TexturedShape_SetTextureFileName(void* instance, void* value);
extern "C" DECL_EXPORT bool AIS_TexturedShape_TextureMapState(void* instance);
extern "C" DECL_EXPORT double AIS_TexturedShape_URepeat(void* instance);
extern "C" DECL_EXPORT double AIS_TexturedShape_Deflection(void* instance);
extern "C" DECL_EXPORT double AIS_TexturedShape_VRepeat(void* instance);
extern "C" DECL_EXPORT double AIS_TexturedShape_TextureUOrigin(void* instance);
extern "C" DECL_EXPORT double AIS_TexturedShape_TextureVOrigin(void* instance);
extern "C" DECL_EXPORT double AIS_TexturedShape_TextureScaleU(void* instance);
extern "C" DECL_EXPORT double AIS_TexturedShape_TextureScaleV(void* instance);
extern "C" DECL_EXPORT bool AIS_TexturedShape_TextureModulate(void* instance);
extern "C" DECL_EXPORT void AISTexturedShape_Dtor(void* instance);

#endif
