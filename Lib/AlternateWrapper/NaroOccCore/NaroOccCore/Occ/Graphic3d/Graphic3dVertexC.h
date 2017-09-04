#ifndef Graphic3d_VertexC_H
#define Graphic3d_VertexC_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_VertexC_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_VertexC_Ctor54B79BE2(
	double AX,
	double AY,
	double AZ,
	void* AColor);
extern "C" DECL_EXPORT void* Graphic3d_VertexC_Ctor1204A009(
	void* APoint,
	void* AColor);
extern "C" DECL_EXPORT void Graphic3d_VertexC_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_VertexC_Color(void* instance);
extern "C" DECL_EXPORT void Graphic3dVertexC_Dtor(void* instance);

#endif
