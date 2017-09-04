#ifndef Graphic3d_VertexN_H
#define Graphic3d_VertexN_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_VertexN_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_VertexN_Ctor51E06B8D(
	double AX,
	double AY,
	double AZ,
	double ANX,
	double ANY,
	double ANZ,
	bool FlagNormalise);
extern "C" DECL_EXPORT void* Graphic3d_VertexN_CtorD1B20338(
	void* APoint,
	void* AVector,
	bool FlagNormalise);
extern "C" DECL_EXPORT void Graphic3d_VertexN_SetNormal1B801FD4(
	void* instance,
	double NXnew,
	double NYnew,
	double NZnew,
	bool FlagNormalise);
extern "C" DECL_EXPORT void Graphic3d_VertexN_Normal9282A951(
	void* instance,
	double* ANX,
	double* ANY,
	double* ANZ);
extern "C" DECL_EXPORT void Graphic3dVertexN_Dtor(void* instance);

#endif
