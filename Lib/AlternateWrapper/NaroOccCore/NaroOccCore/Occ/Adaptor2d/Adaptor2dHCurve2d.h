#ifndef Adaptor2d_HCurve2d_H
#define Adaptor2d_HCurve2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT int Adaptor2d_HCurve2d_NbIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_ValueD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void Adaptor2d_HCurve2d_D0F34E6A40(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void Adaptor2d_HCurve2d_D1EF1CEF4A(
	void* instance,
	double U,
	void* P,
	void* V);
extern "C" DECL_EXPORT void Adaptor2d_HCurve2d_D2DCE527F4(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void Adaptor2d_HCurve2d_D3A3CC6934(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT double Adaptor2d_HCurve2d_ResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT double Adaptor2d_HCurve2d_FirstParameter(void* instance);
extern "C" DECL_EXPORT double Adaptor2d_HCurve2d_LastParameter(void* instance);
extern "C" DECL_EXPORT int Adaptor2d_HCurve2d_Continuity(void* instance);
extern "C" DECL_EXPORT bool Adaptor2d_HCurve2d_IsClosed(void* instance);
extern "C" DECL_EXPORT bool Adaptor2d_HCurve2d_IsPeriodic(void* instance);
extern "C" DECL_EXPORT double Adaptor2d_HCurve2d_Period(void* instance);
extern "C" DECL_EXPORT int Adaptor2d_HCurve2d_GetType(void* instance);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_Line(void* instance);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_Circle(void* instance);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_Ellipse(void* instance);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_Hyperbola(void* instance);
extern "C" DECL_EXPORT void* Adaptor2d_HCurve2d_Parabola(void* instance);
extern "C" DECL_EXPORT int Adaptor2d_HCurve2d_Degree(void* instance);
extern "C" DECL_EXPORT bool Adaptor2d_HCurve2d_IsRational(void* instance);
extern "C" DECL_EXPORT int Adaptor2d_HCurve2d_NbPoles(void* instance);
extern "C" DECL_EXPORT int Adaptor2d_HCurve2d_NbKnots(void* instance);
extern "C" DECL_EXPORT void Adaptor2dHCurve2d_Dtor(void* instance);

#endif
