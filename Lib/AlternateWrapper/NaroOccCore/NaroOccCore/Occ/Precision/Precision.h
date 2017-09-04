#ifndef Precision_H
#define Precision_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT double Precision_Parametric9F0E714F(
	double P,
	double T);
extern "C" DECL_EXPORT double Precision_PConfusionD82819F3(
	double T);
extern "C" DECL_EXPORT double Precision_PIntersectionD82819F3(
	double T);
extern "C" DECL_EXPORT double Precision_PApproximationD82819F3(
	double T);
extern "C" DECL_EXPORT double Precision_ParametricD82819F3(
	double P);
extern "C" DECL_EXPORT double Precision_PConfusion();
extern "C" DECL_EXPORT double Precision_PIntersection();
extern "C" DECL_EXPORT double Precision_PApproximation();
extern "C" DECL_EXPORT bool Precision_IsInfiniteD82819F3(
	double R);
extern "C" DECL_EXPORT bool Precision_IsPositiveInfiniteD82819F3(
	double R);
extern "C" DECL_EXPORT bool Precision_IsNegativeInfiniteD82819F3(
	double R);
extern "C" DECL_EXPORT double Precision_Angular();
extern "C" DECL_EXPORT double Precision_Confusion();
extern "C" DECL_EXPORT double Precision_SquareConfusion();
extern "C" DECL_EXPORT double Precision_Intersection();
extern "C" DECL_EXPORT double Precision_Approximation();
extern "C" DECL_EXPORT double Precision_Infinite();
extern "C" DECL_EXPORT void Precision_Dtor(void* instance);

#endif
