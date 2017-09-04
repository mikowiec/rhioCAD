#include "AISTexturedShape.h"
#include <AIS_TexturedShape.hxx>


DECL_EXPORT void* AIS_TexturedShape_Ctor9EBAC0C0(
	void* shap)
{
		const TopoDS_Shape &  _shap =*(const TopoDS_Shape *)shap;
	return new Handle_AIS_TexturedShape(new AIS_TexturedShape(			
_shap));
}
DECL_EXPORT void AIS_TexturedShape_SetTextureRepeatDA23FEE7(
	void* instance,
	bool RepeatYN,
	double URepeat,
	double VRepeat)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->SetTextureRepeat(			
RepeatYN,			
URepeat,			
VRepeat);
}
DECL_EXPORT void AIS_TexturedShape_SetTextureOriginDA23FEE7(
	void* instance,
	bool SetTextureOriginYN,
	double UOrigin,
	double VOrigin)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->SetTextureOrigin(			
SetTextureOriginYN,			
UOrigin,			
VOrigin);
}
DECL_EXPORT void AIS_TexturedShape_SetTextureScaleDA23FEE7(
	void* instance,
	bool SetTextureScaleYN,
	double ScaleU,
	double ScaleV)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->SetTextureScale(			
SetTextureScaleYN,			
ScaleU,			
ScaleV);
}
DECL_EXPORT void AIS_TexturedShape_SetTextureMapOn(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->SetTextureMapOn();
}
DECL_EXPORT void AIS_TexturedShape_SetTextureMapOff(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->SetTextureMapOff();
}
DECL_EXPORT void AIS_TexturedShape_EnableTextureModulate(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->EnableTextureModulate();
}
DECL_EXPORT void AIS_TexturedShape_DisableTextureModulate(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->DisableTextureModulate();
}
DECL_EXPORT void AIS_TexturedShape_UpdateAttributes(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
 	result->UpdateAttributes();
}
DECL_EXPORT bool AIS_TexturedShape_TextureRepeat(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return  	result->TextureRepeat();
}
DECL_EXPORT bool AIS_TexturedShape_TextureScale(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return  	result->TextureScale();
}
DECL_EXPORT bool AIS_TexturedShape_TextureOrigin(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return  	result->TextureOrigin();
}
DECL_EXPORT void AIS_TexturedShape_SetTextureFileName(void* instance, void* value)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
		result->SetTextureFileName(*(const TCollection_AsciiString *)value);
}

DECL_EXPORT bool AIS_TexturedShape_TextureMapState(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->TextureMapState();
}

DECL_EXPORT double AIS_TexturedShape_URepeat(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->URepeat();
}

DECL_EXPORT double AIS_TexturedShape_Deflection(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->Deflection();
}

DECL_EXPORT double AIS_TexturedShape_VRepeat(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->VRepeat();
}

DECL_EXPORT double AIS_TexturedShape_TextureUOrigin(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->TextureUOrigin();
}

DECL_EXPORT double AIS_TexturedShape_TextureVOrigin(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->TextureVOrigin();
}

DECL_EXPORT double AIS_TexturedShape_TextureScaleU(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->TextureScaleU();
}

DECL_EXPORT double AIS_TexturedShape_TextureScaleV(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->TextureScaleV();
}

DECL_EXPORT bool AIS_TexturedShape_TextureModulate(void* instance)
{
	AIS_TexturedShape* result = (AIS_TexturedShape*)(((Handle_AIS_TexturedShape*)instance)->Access());
	return 	result->TextureModulate();
}

DECL_EXPORT void AISTexturedShape_Dtor(void* instance)
{
	delete (Handle_AIS_TexturedShape*)instance;
}
