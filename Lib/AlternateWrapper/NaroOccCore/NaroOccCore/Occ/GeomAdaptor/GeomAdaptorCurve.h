#ifndef GeomAdaptor_Curve_H
#define GeomAdaptor_Curve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Ctor();
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_CtorFF608AE4(
	void* C);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_CtorED53F64D(
	void* C,
	double UFirst,
	double ULast);
extern "C" DECL_EXPORT void GeomAdaptor_Curve_LoadFF608AE4(
	void* instance,
	void* C);
extern "C" DECL_EXPORT void GeomAdaptor_Curve_LoadED53F64D(
	void* instance,
	void* C,
	double UFirst,
	double ULast);
extern "C" DECL_EXPORT int GeomAdaptor_Curve_NbIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_ValueD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void GeomAdaptor_Curve_D053A5A2C1(
	void* instance,
	double U,
	void* P);
extern "C" DECL_EXPORT void GeomAdaptor_Curve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V);
extern "C" DECL_EXPORT void GeomAdaptor_Curve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2);
extern "C" DECL_EXPORT void GeomAdaptor_Curve_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT double GeomAdaptor_Curve_ResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Curve(void* instance);
extern "C" DECL_EXPORT double GeomAdaptor_Curve_FirstParameter(void* instance);
extern "C" DECL_EXPORT double GeomAdaptor_Curve_LastParameter(void* instance);
extern "C" DECL_EXPORT int GeomAdaptor_Curve_Continuity(void* instance);
extern "C" DECL_EXPORT bool GeomAdaptor_Curve_IsClosed(void* instance);
extern "C" DECL_EXPORT bool GeomAdaptor_Curve_IsPeriodic(void* instance);
extern "C" DECL_EXPORT double GeomAdaptor_Curve_Period(void* instance);
extern "C" DECL_EXPORT int GeomAdaptor_Curve_GetType(void* instance);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Line(void* instance);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Circle(void* instance);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Ellipse(void* instance);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Hyperbola(void* instance);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Parabola(void* instance);
extern "C" DECL_EXPORT int GeomAdaptor_Curve_Degree(void* instance);
extern "C" DECL_EXPORT bool GeomAdaptor_Curve_IsRational(void* instance);
extern "C" DECL_EXPORT int GeomAdaptor_Curve_NbPoles(void* instance);
extern "C" DECL_EXPORT int GeomAdaptor_Curve_NbKnots(void* instance);
extern "C" DECL_EXPORT void* GeomAdaptor_Curve_Bezier(void* instance);
extern "C" DECL_EXPORT void GeomAdaptorCurve_Dtor(void* instance);

#endif
