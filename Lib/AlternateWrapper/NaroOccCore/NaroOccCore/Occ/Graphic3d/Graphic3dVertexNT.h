#ifndef Graphic3d_VertexNT_H
#define Graphic3d_VertexNT_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_VertexNT_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_VertexNT_CtorC4E56621(
	double AX,
	double AY,
	double AZ,
	double ANX,
	double ANY,
	double ANZ,
	double ATX,
	double ATY,
	bool FlagNormalise);
extern "C" DECL_EXPORT void* Graphic3d_VertexNT_Ctor6C5E5BBA(
	void* APoint,
	void* AVector,
	double ATX,
	double ATY,
	bool FlagNormalise);
extern "C" DECL_EXPORT void Graphic3d_VertexNT_SetTextureCoordinate9F0E714F(
	void* instance,
	double ATX,
	double ATY);
extern "C" DECL_EXPORT void Graphic3d_VertexNT_TextureCoordinate9F0E714F(
	void* instance,
	double* ATX,
	double* ATY);
extern "C" DECL_EXPORT void Graphic3dVertexNT_Dtor(void* instance);

#endif
