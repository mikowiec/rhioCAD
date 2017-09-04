#ifndef gp_Lin_H
#define gp_Lin_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Lin_Ctor();
extern "C" DECL_EXPORT void* gp_Lin_Ctor608B963B(
	void* A1);
extern "C" DECL_EXPORT void* gp_Lin_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT void gp_Lin_Reverse(void* instance);
extern "C" DECL_EXPORT double gp_Lin_Angle9917D291(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool gp_Lin_ContainsF0D1E3E6(
	void* instance,
	void* P,
	double LinearTolerance);
extern "C" DECL_EXPORT double gp_Lin_Distance9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Lin_Distance9917D291(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Lin_SquareDistance9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Lin_SquareDistance9917D291(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* gp_Lin_Normal9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Lin_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Lin_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Lin_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Lin_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Lin_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Lin_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Lin_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Lin_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Lin_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Lin_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Lin_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Lin_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Lin_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Lin_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Lin_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Lin_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Lin_Reversed(void* instance);
extern "C" DECL_EXPORT void gp_Lin_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Lin_Direction(void* instance);
extern "C" DECL_EXPORT void gp_Lin_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Lin_Location(void* instance);
extern "C" DECL_EXPORT void gp_Lin_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Lin_Position(void* instance);
extern "C" DECL_EXPORT void gpLin_Dtor(void* instance);

#endif
