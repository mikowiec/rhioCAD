#ifndef Graphic2d_Vertex_H
#define Graphic2d_Vertex_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic2d_Vertex_Ctor();
extern "C" DECL_EXPORT void* Graphic2d_Vertex_Ctor9F0E714F(
	double AX,
	double AY);
extern "C" DECL_EXPORT void Graphic2d_Vertex_SetCoord9F0E714F(
	void* instance,
	double Xnew,
	double Ynew);
extern "C" DECL_EXPORT void Graphic2d_Vertex_Coord9F0E714F(
	void* instance,
	double* AX,
	double* AY);
extern "C" DECL_EXPORT bool Graphic2d_Vertex_IsEqualC6E2F71C(
	void* instance,
	void* other);
extern "C" DECL_EXPORT double Graphic2d_Vertex_Distance693D9ECB(
	void* AV1,
	void* AV2);
extern "C" DECL_EXPORT void Graphic2d_Vertex_SetXCoord(void* instance, double value);
extern "C" DECL_EXPORT void Graphic2d_Vertex_SetYCoord(void* instance, double value);
extern "C" DECL_EXPORT double Graphic2d_Vertex_X(void* instance);
extern "C" DECL_EXPORT double Graphic2d_Vertex_Y(void* instance);
extern "C" DECL_EXPORT void Graphic2dVertex_Dtor(void* instance);

#endif
