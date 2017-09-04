#include "Precision.h"
#include <Precision.hxx>


DECL_EXPORT double Precision_Parametric9F0E714F(
	double P,
	double T)
{
	return  Precision::Parametric(			
P,			
T);
}
DECL_EXPORT double Precision_PConfusionD82819F3(
	double T)
{
	return  Precision::PConfusion(			
T);
}
DECL_EXPORT double Precision_PIntersectionD82819F3(
	double T)
{
	return  Precision::PIntersection(			
T);
}
DECL_EXPORT double Precision_PApproximationD82819F3(
	double T)
{
	return  Precision::PApproximation(			
T);
}
DECL_EXPORT double Precision_ParametricD82819F3(
	double P)
{
	return  Precision::Parametric(			
P);
}
DECL_EXPORT double Precision_PConfusion()
{
	return  Precision::PConfusion();
}
DECL_EXPORT double Precision_PIntersection()
{
	return  Precision::PIntersection();
}
DECL_EXPORT double Precision_PApproximation()
{
	return  Precision::PApproximation();
}
DECL_EXPORT bool Precision_IsInfiniteD82819F3(
	double R)
{
	return  Precision::IsInfinite(			
R);
}
DECL_EXPORT bool Precision_IsPositiveInfiniteD82819F3(
	double R)
{
	return  Precision::IsPositiveInfinite(			
R);
}
DECL_EXPORT bool Precision_IsNegativeInfiniteD82819F3(
	double R)
{
	return  Precision::IsNegativeInfinite(			
R);
}
DECL_EXPORT double Precision_Angular()
{
	return Precision::Angular();
}

DECL_EXPORT double Precision_Confusion()
{
	return Precision::Confusion();
}

DECL_EXPORT double Precision_SquareConfusion()
{
	return Precision::SquareConfusion();
}

DECL_EXPORT double Precision_Intersection()
{
	return Precision::Intersection();
}

DECL_EXPORT double Precision_Approximation()
{
	return Precision::Approximation();
}

DECL_EXPORT double Precision_Infinite()
{
	return Precision::Infinite();
}

DECL_EXPORT void Precision_Dtor(void* instance)
{
	delete (Precision*)instance;
}
