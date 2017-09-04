#ifndef gp_Parab_H
#define gp_Parab_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Parab_Ctor();
extern "C" DECL_EXPORT void* gp_Parab_Ctor673FA07D(
	void* A2,
	double Focal);
extern "C" DECL_EXPORT void* gp_Parab_Ctor3B6CEA26(
	void* D,
	void* F);
extern "C" DECL_EXPORT void gp_Parab_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Parab_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Parab_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Parab_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Parab_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Parab_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Parab_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Parab_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Parab_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Parab_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Parab_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Parab_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Parab_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Parab_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Parab_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Parab_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void gp_Parab_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Parab_Axis(void* instance);
extern "C" DECL_EXPORT void* gp_Parab_Directrix(void* instance);
extern "C" DECL_EXPORT void gp_Parab_SetFocal(void* instance, double value);
extern "C" DECL_EXPORT double gp_Parab_Focal(void* instance);
extern "C" DECL_EXPORT void* gp_Parab_Focus(void* instance);
extern "C" DECL_EXPORT void gp_Parab_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Parab_Location(void* instance);
extern "C" DECL_EXPORT double gp_Parab_Parameter(void* instance);
extern "C" DECL_EXPORT void gp_Parab_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Parab_Position(void* instance);
extern "C" DECL_EXPORT void* gp_Parab_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Parab_YAxis(void* instance);
extern "C" DECL_EXPORT void gpParab_Dtor(void* instance);

#endif
