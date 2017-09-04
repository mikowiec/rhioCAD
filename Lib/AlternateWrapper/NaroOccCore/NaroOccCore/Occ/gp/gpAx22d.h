#ifndef gp_Ax22d_H
#define gp_Ax22d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Ax22d_Ctor();
extern "C" DECL_EXPORT void* gp_Ax22d_CtorE3FB4CCB(
	void* P,
	void* Vx,
	void* Vy);
extern "C" DECL_EXPORT void* gp_Ax22d_CtorE18CA5E9(
	void* P,
	void* V,
	bool Sense);
extern "C" DECL_EXPORT void* gp_Ax22d_Ctor2C652E28(
	void* A,
	bool Sense);
extern "C" DECL_EXPORT void gp_Ax22d_Mirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Ax22d_Mirrored6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Ax22d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Ax22d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Ax22d_RotateE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void* gp_Ax22d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Ax22d_ScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Ax22d_ScaledE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Ax22d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Ax22d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Ax22d_Translate5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Ax22d_Translated5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Ax22d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Ax22d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Ax22d_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void gp_Ax22d_SetXAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax22d_XAxis(void* instance);
extern "C" DECL_EXPORT void gp_Ax22d_SetYAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax22d_YAxis(void* instance);
extern "C" DECL_EXPORT void gp_Ax22d_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax22d_Location(void* instance);
extern "C" DECL_EXPORT void gp_Ax22d_SetXDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax22d_XDirection(void* instance);
extern "C" DECL_EXPORT void gp_Ax22d_SetYDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Ax22d_YDirection(void* instance);
extern "C" DECL_EXPORT void gpAx22d_Dtor(void* instance);

#endif
