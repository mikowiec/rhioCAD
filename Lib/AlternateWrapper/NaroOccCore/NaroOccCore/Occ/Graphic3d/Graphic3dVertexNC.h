#ifndef Graphic3d_VertexNC_H
#define Graphic3d_VertexNC_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_VertexNC_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_VertexNC_CtorF45E0172(
	double AX,
	double AY,
	double AZ,
	double ANX,
	double ANY,
	double ANZ,
	void* AColor,
	bool FlagNormalise);
extern "C" DECL_EXPORT void* Graphic3d_VertexNC_Ctor523C1B5F(
	void* APoint,
	void* AVector,
	void* AColor,
	bool FlagNormalise);
extern "C" DECL_EXPORT void Graphic3d_VertexNC_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Graphic3d_VertexNC_Color(void* instance);
extern "C" DECL_EXPORT void Graphic3dVertexNC_Dtor(void* instance);

#endif
