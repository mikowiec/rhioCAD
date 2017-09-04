#ifndef Graphic3d_Vector_H
#define Graphic3d_Vector_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_Vector_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_Vector_Ctor9282A951(
	double AX,
	double AY,
	double AZ);
extern "C" DECL_EXPORT void* Graphic3d_Vector_Ctor29D8F78D(
	void* APoint1,
	void* APoint2);
extern "C" DECL_EXPORT void Graphic3d_Vector_Normalize(void* instance);
extern "C" DECL_EXPORT void Graphic3d_Vector_SetCoord9282A951(
	void* instance,
	double Xnew,
	double Ynew,
	double Znew);
extern "C" DECL_EXPORT void Graphic3d_Vector_Coord9282A951(
	void* instance,
	double* AX,
	double* AY,
	double* AZ);
extern "C" DECL_EXPORT bool Graphic3d_Vector_IsParallelE005972F(
	void* AV1,
	void* AV2);
extern "C" DECL_EXPORT double Graphic3d_Vector_NormeOf9282A951(
	double AX,
	double AY,
	double AZ);
extern "C" DECL_EXPORT double Graphic3d_Vector_NormeOf8053F351(
	void* AVector);
extern "C" DECL_EXPORT void Graphic3d_Vector_SetXCoord(void* instance, double value);
extern "C" DECL_EXPORT void Graphic3d_Vector_SetYCoord(void* instance, double value);
extern "C" DECL_EXPORT void Graphic3d_Vector_SetZCoord(void* instance, double value);
extern "C" DECL_EXPORT bool Graphic3d_Vector_IsNormalized(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_Vector_LengthZero(void* instance);
extern "C" DECL_EXPORT double Graphic3d_Vector_X(void* instance);
extern "C" DECL_EXPORT double Graphic3d_Vector_Y(void* instance);
extern "C" DECL_EXPORT double Graphic3d_Vector_Z(void* instance);
extern "C" DECL_EXPORT void Graphic3dVector_Dtor(void* instance);

#endif
