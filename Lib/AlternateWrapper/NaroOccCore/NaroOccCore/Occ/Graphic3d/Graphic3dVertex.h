#ifndef Graphic3d_Vertex_H
#define Graphic3d_Vertex_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_Vertex_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_Vertex_CtorC6E2F35B(
	void* APoint);
extern "C" DECL_EXPORT void* Graphic3d_Vertex_Ctor9282A951(
	double AX,
	double AY,
	double AZ);
extern "C" DECL_EXPORT void Graphic3d_Vertex_SetCoord9282A951(
	void* instance,
	double Xnew,
	double Ynew,
	double Znew);
extern "C" DECL_EXPORT void Graphic3d_Vertex_Coord9282A951(
	void* instance,
	double* AX,
	double* AY,
	double* AZ);
extern "C" DECL_EXPORT double Graphic3d_Vertex_Distance29D8F78D(
	void* AV1,
	void* AV2);
extern "C" DECL_EXPORT void Graphic3d_Vertex_SetXCoord(void* instance, double value);
extern "C" DECL_EXPORT void Graphic3d_Vertex_SetYCoord(void* instance, double value);
extern "C" DECL_EXPORT void Graphic3d_Vertex_SetZCoord(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_Vertex_X(void* instance);
extern "C" DECL_EXPORT double Graphic3d_Vertex_Y(void* instance);
extern "C" DECL_EXPORT double Graphic3d_Vertex_Z(void* instance);
extern "C" DECL_EXPORT void Graphic3dVertex_Dtor(void* instance);

#endif
