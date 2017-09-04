#ifndef gp_Parab2d_H
#define gp_Parab2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Parab2d_Ctor();
extern "C" DECL_EXPORT void* gp_Parab2d_Ctor462C7341(
	void* MirrorAxis,
	double Focal,
	bool Sense);
extern "C" DECL_EXPORT void* gp_Parab2d_Ctor443D47DE(
	void* A,
	double Focal);
extern "C" DECL_EXPORT void* gp_Parab2d_CtorF2803558(
	void* D,
	void* F,
	bool Sense);
extern "C" DECL_EXPORT void* gp_Parab2d_Ctor3DE242E8(
	void* D,
	void* F);
extern "C" DECL_EXPORT void gp_Parab2d_CoefficientsBC7A5786(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D,
	double* E,
	double* F);
extern "C" DECL_EXPORT void gp_Parab2d_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Parab2d_Mirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Parab2d_Mirrored6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Parab2d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Parab2d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Parab2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void* gp_Parab2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Parab2d_ScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Parab2d_ScaledE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Parab2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Parab2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Parab2d_Translate5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Parab2d_Translated5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Parab2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Parab2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Parab2d_Directrix(void* instance);
extern "C" DECL_EXPORT void gp_Parab2d_SetFocal(void* instance, double value);
extern "C" DECL_EXPORT double gp_Parab2d_Focal(void* instance);
extern "C" DECL_EXPORT void* gp_Parab2d_Focus(void* instance);
extern "C" DECL_EXPORT void gp_Parab2d_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Parab2d_Location(void* instance);
extern "C" DECL_EXPORT void gp_Parab2d_SetMirrorAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Parab2d_MirrorAxis(void* instance);
extern "C" DECL_EXPORT void gp_Parab2d_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Parab2d_Axis(void* instance);
extern "C" DECL_EXPORT double gp_Parab2d_Parameter(void* instance);
extern "C" DECL_EXPORT void* gp_Parab2d_Reversed(void* instance);
extern "C" DECL_EXPORT bool gp_Parab2d_IsDirect(void* instance);
extern "C" DECL_EXPORT void gpParab2d_Dtor(void* instance);

#endif
