#ifndef Adaptor3d_HSurface_H
#define Adaptor3d_HSurface_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT int Adaptor3d_HSurface_NbUIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_NbVIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_UTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_VTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_Value9F0E714F(
	void* instance,
	double U,
	double V);
extern "C" DECL_EXPORT void Adaptor3d_HSurface_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P);
extern "C" DECL_EXPORT void Adaptor3d_HSurface_D14153CD1A(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V);
extern "C" DECL_EXPORT void Adaptor3d_HSurface_D2E9F600EF(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V,
	void* D2U,
	void* D2V,
	void* D2UV);
extern "C" DECL_EXPORT void Adaptor3d_HSurface_D3B100120D(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V,
	void* D2U,
	void* D2V,
	void* D2UV,
	void* D3U,
	void* D3V,
	void* D3UUV,
	void* D3UVV);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_UResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_VResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_FirstUParameter(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_LastUParameter(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_FirstVParameter(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_LastVParameter(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_UContinuity(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_VContinuity(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HSurface_IsUClosed(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HSurface_IsVClosed(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HSurface_IsUPeriodic(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_UPeriod(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HSurface_IsVPeriodic(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_VPeriod(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_GetType(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_Plane(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_Cylinder(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_Cone(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_Sphere(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_Torus(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_UDegree(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_NbUPoles(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_VDegree(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_NbVPoles(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_NbUKnots(void* instance);
extern "C" DECL_EXPORT int Adaptor3d_HSurface_NbVKnots(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HSurface_IsURational(void* instance);
extern "C" DECL_EXPORT bool Adaptor3d_HSurface_IsVRational(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_AxeOfRevolution(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_Direction(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_BasisCurve(void* instance);
extern "C" DECL_EXPORT void* Adaptor3d_HSurface_BasisSurface(void* instance);
extern "C" DECL_EXPORT double Adaptor3d_HSurface_OffsetValue(void* instance);
extern "C" DECL_EXPORT void Adaptor3dHSurface_Dtor(void* instance);

#endif
