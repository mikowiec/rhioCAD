#ifndef gp_Circ2d_H
#define gp_Circ2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Circ2d_Ctor();
extern "C" DECL_EXPORT void* gp_Circ2d_Ctor462C7341(
	void* XAxis,
	double Radius,
	bool Sense);
extern "C" DECL_EXPORT void* gp_Circ2d_Ctor443D47DE(
	void* Axis,
	double Radius);
extern "C" DECL_EXPORT void gp_Circ2d_CoefficientsBC7A5786(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D,
	double* E,
	double* F);
extern "C" DECL_EXPORT bool gp_Circ2d_ContainsE3062737(
	void* instance,
	void* P,
	double LinearTolerance);
extern "C" DECL_EXPORT double gp_Circ2d_Distance6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Circ2d_SquareDistance6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Circ2d_Reverse(void* instance);
extern "C" DECL_EXPORT void gp_Circ2d_Mirror6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Circ2d_Mirrored6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Circ2d_Mirror90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void* gp_Circ2d_Mirrored90E1386A(
	void* instance,
	void* A);
extern "C" DECL_EXPORT void gp_Circ2d_RotateE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void* gp_Circ2d_RotatedE3062737(
	void* instance,
	void* P,
	double Ang);
extern "C" DECL_EXPORT void gp_Circ2d_ScaleE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Circ2d_ScaledE3062737(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Circ2d_Transform27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Circ2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Circ2d_Translate5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Circ2d_Translated5E4E66E7(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Circ2d_Translate5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Circ2d_Translated5F54ADE3(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT double gp_Circ2d_Area(void* instance);
extern "C" DECL_EXPORT double gp_Circ2d_Length(void* instance);
extern "C" DECL_EXPORT void gp_Circ2d_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Circ2d_Location(void* instance);
extern "C" DECL_EXPORT void gp_Circ2d_SetRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Circ2d_Radius(void* instance);
extern "C" DECL_EXPORT void gp_Circ2d_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Circ2d_Axis(void* instance);
extern "C" DECL_EXPORT void* gp_Circ2d_Position(void* instance);
extern "C" DECL_EXPORT void gp_Circ2d_SetXAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Circ2d_XAxis(void* instance);
extern "C" DECL_EXPORT void gp_Circ2d_SetYAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Circ2d_YAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Circ2d_Reversed(void* instance);
extern "C" DECL_EXPORT bool gp_Circ2d_IsDirect(void* instance);
extern "C" DECL_EXPORT void gpCirc2d_Dtor(void* instance);

#endif
