#ifndef gp_Ax2d_H
#define gp_Ax2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Ax2d_Ctor();
extern "C" DECL_EXPORT void* gp_Ax2d_Ctor2E9C6BD1(
	void* P,
	void* V);
extern "C" DECL_EXPORT bool gp_Ax2d_IsCoaxial4745308(
	void* instance,
	void* Other,
	double AngularTolerance,
	double LinearTolerance);
extern "C" DECL_EXPORT bool gp_Ax2d_IsNormalF4E58768(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Ax2d_IsOppositeF4E58768(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT bool gp_Ax2d_IsParallelF4E58768(
	void* instance,
	void* Other,
	double AngularTolerance);
extern "C" DECL_EXPORT double gp_Ax2d_Angle90E1386A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void gp_Ax2d_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Ax2d_Mirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Ax2d_Mirrored6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Ax2d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Ax2d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Ax2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void* gp_Ax2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Ax2d_ScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Ax2d_ScaledE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Ax2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Ax2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Ax2d_Translate5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Ax2d_Translated5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Ax2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Ax2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Ax2d_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax2d_Location(void* instance);
extern "C" DECL_EXPORT void gp_Ax2d_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax2d_Direction(void* instance);
extern "C" DECL_EXPORT void* gp_Ax2d_Reversed(void* instance);
extern "C" DECL_EXPORT void gpAx2d_Dtor(void* instance);

#endif
