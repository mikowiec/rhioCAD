#ifndef gp_Pln_H
#define gp_Pln_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* gp_Pln_Ctor();
extern "C" DECL_EXPORT void* gp_Pln_Ctor1B3CAD05(
	void* A3);
extern "C" DECL_EXPORT void* gp_Pln_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT void* gp_Pln_CtorC2777E0C(
	double A,
	double B,
	double C,
	double D);
extern "C" DECL_EXPORT void gp_Pln_CoefficientsC2777E0C(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D);
extern "C" DECL_EXPORT void gp_Pln_UReverse(void* instance);
extern "C" DECL_EXPORT void gp_Pln_VReverse(void* instance);
extern "C" DECL_EXPORT double gp_Pln_Distance9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Pln_Distance9917D291(
	void* instance,
	void* L);
extern "C" DECL_EXPORT double gp_Pln_Distance9914D2AD(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT double gp_Pln_SquareDistance9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT double gp_Pln_SquareDistance9917D291(
	void* instance,
	void* L);
extern "C" DECL_EXPORT double gp_Pln_SquareDistance9914D2AD(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool gp_Pln_ContainsF0D1E3E6(
	void* instance,
	void* P,
	double LinearTolerance);
extern "C" DECL_EXPORT bool gp_Pln_Contains13A123E9(
	void* instance,
	void* L,
	double LinearTolerance,
	double AngularTolerance);
extern "C" DECL_EXPORT void gp_Pln_Mirror9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* gp_Pln_Mirrored9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void gp_Pln_Mirror608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void* gp_Pln_Mirrored608B963B(
	void* instance,
	void* A1);
extern "C" DECL_EXPORT void gp_Pln_Mirror7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void* gp_Pln_Mirrored7895386A(
	void* instance,
	void* A2);
extern "C" DECL_EXPORT void gp_Pln_Rotate827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void* gp_Pln_Rotated827CB19A(
	void* instance,
	void* A1,
	double Ang);
extern "C" DECL_EXPORT void gp_Pln_ScaleF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void* gp_Pln_ScaledF0D1E3E6(
	void* instance,
	void* P,
	double S);
extern "C" DECL_EXPORT void gp_Pln_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* gp_Pln_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void gp_Pln_Translate9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* gp_Pln_Translated9BD9CFFE(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void gp_Pln_Translate5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT void* gp_Pln_Translated5C63477E(
	void* instance,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT bool gp_Pln_Direct(void* instance);
extern "C" DECL_EXPORT void gp_Pln_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Pln_Axis(void* instance);
extern "C" DECL_EXPORT void gp_Pln_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Pln_Location(void* instance);
extern "C" DECL_EXPORT void gp_Pln_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* gp_Pln_Position(void* instance);
extern "C" DECL_EXPORT void* gp_Pln_XAxis(void* instance);
extern "C" DECL_EXPORT void* gp_Pln_YAxis(void* instance);
extern "C" DECL_EXPORT void gpPln_Dtor(void* instance);

#endif
