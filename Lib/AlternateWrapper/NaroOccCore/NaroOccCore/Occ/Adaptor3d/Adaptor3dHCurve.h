#ifndef Adaptor3d_HCurve_H
#define Adaptor3d_HCurve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT int Adaptor3d_HCurve_NbIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_ValueD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void Adaptor3d_HCurve_D053A5A2C1(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void Adaptor3d_HCurve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V);
extern "C" DECL_EXPORT void Adaptor3d_HCurve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void Adaptor3d_HCurve_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT double Adaptor3d_HCurve_ResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT double Adaptor3d_HCurve_FirstParameter(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HCurve_LastParameter(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HCurve_Continuity(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HCurve_IsClosed(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HCurve_IsPeriodic(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HCurve_Period(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HCurve_GetType(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_Line(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_Circle(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_Ellipse(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_Hyperbola(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_Parabola(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HCurve_Degree(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HCurve_IsRational(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HCurve_NbPoles(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HCurve_NbKnots(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HCurve_Bezier(void* instance);
extern "C" DECL_EXPORT void Adaptor3dHCurve_Dtor(void* instance);

#endif
