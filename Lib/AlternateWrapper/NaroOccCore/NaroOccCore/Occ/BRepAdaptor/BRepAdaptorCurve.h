#ifndef BRepAdaptor_Curve_H
#define BRepAdaptor_Curve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Ctor();
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Ctor24263856(
	void* E);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Ctor65EC701C(
	void* E,
	void* F);
extern "C" DECL_EXPORT void BRepAdaptor_Curve_Initialize24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void BRepAdaptor_Curve_Initialize65EC701C(
	void* instance,
	void* E,
	void* F);
extern "C" DECL_EXPORT int BRepAdaptor_Curve_NbIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Trim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_ValueD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_DN2935ABDE(
	void* instance,
	double U,
	int N);
extern "C" DECL_EXPORT double BRepAdaptor_Curve_ResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Trsf(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Curve_Is3DCurve(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Curve_IsCurveOnSurface(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Curve(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Edge(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Curve_Tolerance(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Curve_FirstParameter(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Curve_LastParameter(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Curve_Continuity(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Curve_IsClosed(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Curve_IsPeriodic(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Curve_Period(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Curve_GetType(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Line(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Circle(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Ellipse(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Hyperbola(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Parabola(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Curve_Degree(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Curve_IsRational(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Curve_NbPoles(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Curve_NbKnots(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Curve_Bezier(void* instance);
extern "C" DECL_EXPORT void BRepAdaptorCurve_Dtor(void* instance);

#endif
