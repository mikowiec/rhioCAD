#ifndef gp_Hypr_H
#define gp_Hypr_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Hypr_Ctor();
extern "C" DECL_EXPORT void* gp_Hypr_CtorB1A3BD2A(
	void* A2,
	double MajorRadius,
	double MinorRadius);
extern "C" DECL_EXPORT void gp_Hypr_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Hypr_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Hypr_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Hypr_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Hypr_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Hypr_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Hypr_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Hypr_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Hypr_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Hypr_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Hypr_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Hypr_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Hypr_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Hypr_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Hypr_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Hypr_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Hypr_Asymptote1(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_Asymptote2(void* instance);
extern "C" DECL_EXPORT void gp_Hypr_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Hypr_Axis(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_ConjugateBranch1(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_ConjugateBranch2(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_Directrix1(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_Directrix2(void* instance);
extern "C" DECL_EXPORT double gp_Hypr_Eccentricity(void* instance);
extern "C" DECL_EXPORT double gp_Hypr_Focal(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_Focus1(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_Focus2(void* instance);
extern "C" DECL_EXPORT void gp_Hypr_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Hypr_Location(void* instance);
extern "C" DECL_EXPORT void gp_Hypr_SetMajorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Hypr_MajorRadius(void* instance);
extern "C" DECL_EXPORT void gp_Hypr_SetMinorRadius(void* instance, double value);
extern "C" DECL_EXPORT double gp_Hypr_MinorRadius(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_OtherBranch(void* instance);
extern "C" DECL_EXPORT double gp_Hypr_Parameter(void* instance);
extern "C" DECL_EXPORT void gp_Hypr_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Hypr_Position(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Hypr_YAxis(void* instance);
extern "C" DECL_EXPORT void gpHypr_Dtor(void* instance);

#endif
