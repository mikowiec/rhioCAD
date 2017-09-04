#ifndef BRepAdaptor_Surface_H
#define BRepAdaptor_Surface_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Ctor();
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Ctor4945DBAD(
	void* F,
	bool R);
extern "C" DECL_EXPORT void BRepAdaptor_Surface_Initialize4945DBAD(
	void* instance,
	void* F,
	bool Restriction);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_NbUIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_NbVIntervals5ABD177E(
	void* instance,
	int S);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_UTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_VTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Value9F0E714F(
	void* instance,
	double U,
	double V);
extern "C" DECL_EXPORT void BRepAdaptor_Surface_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P);
extern "C" DECL_EXPORT void BRepAdaptor_Surface_D14153CD1A(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V);
extern "C" DECL_EXPORT void BRepAdaptor_Surface_D2E9F600EF(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V,
	void* D2U,
	void* D2V,
	void* D2UV);
extern "C" DECL_EXPORT void BRepAdaptor_Surface_D3B100120D(
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
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_UResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_VResolutionD82819F3(
	void* instance,
	double R3d);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Surface(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_ChangeSurface(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Trsf(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Face(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_Tolerance(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_FirstUParameter(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_LastUParameter(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_FirstVParameter(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_LastVParameter(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_UContinuity(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_VContinuity(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Surface_IsUClosed(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Surface_IsVClosed(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Surface_IsUPeriodic(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_UPeriod(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Surface_IsVPeriodic(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_VPeriod(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_GetType(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Plane(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Cylinder(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Cone(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Sphere(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Torus(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_UDegree(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_NbUPoles(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_VDegree(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_NbVPoles(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_NbUKnots(void* instance);
extern "C" DECL_EXPORT int BRepAdaptor_Surface_NbVKnots(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Surface_IsURational(void* instance);
extern "C" DECL_EXPORT bool BRepAdaptor_Surface_IsVRational(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_AxeOfRevolution(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_Direction(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_BasisCurve(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_Surface_BasisSurface(void* instance);
extern "C" DECL_EXPORT double BRepAdaptor_Surface_OffsetValue(void* instance);
extern "C" DECL_EXPORT void BRepAdaptorSurface_Dtor(void* instance);

#endif
