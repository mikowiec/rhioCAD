#ifndef Geom_Plane_H
#define Geom_Plane_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_Plane_Ctor1B3CAD05(
	void* A3);
extern "C" DECL_EXPORT void* Geom_Plane_Ctor9914D2AD(
	void* Pl);
extern "C" DECL_EXPORT void* Geom_Plane_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT void* Geom_Plane_CtorC2777E0C(
	double A,
	double B,
	double C,
	double D);
extern "C" DECL_EXPORT void Geom_Plane_UReverse(void* instance);
extern "C" DECL_EXPORT double Geom_Plane_UReversedParameterD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void Geom_Plane_VReverse(void* instance);
extern "C" DECL_EXPORT double Geom_Plane_VReversedParameterD82819F3(
	void* instance,
	double V);
extern "C" DECL_EXPORT void Geom_Plane_TransformParametersFD94EFCC(
	void* instance,
	double* U,
	double* V,
	void* T);
extern "C" DECL_EXPORT void* Geom_Plane_ParametricTransformation72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_Plane_BoundsC2777E0C(
	void* instance,
	double* U1,
	double* U2,
	double* V1,
	double* V2);
extern "C" DECL_EXPORT void Geom_Plane_CoefficientsC2777E0C(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D);
extern "C" DECL_EXPORT void* Geom_Plane_UIsoD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void* Geom_Plane_VIsoD82819F3(
	void* instance,
	double V);
extern "C" DECL_EXPORT void Geom_Plane_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P);
extern "C" DECL_EXPORT void Geom_Plane_D14153CD1A(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V);
extern "C" DECL_EXPORT void Geom_Plane_D2E9F600EF(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V,
	void* D2U,
	void* D2V,
	void* D2UV);
extern "C" DECL_EXPORT void Geom_Plane_D3B100120D(
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
extern "C" DECL_EXPORT void* Geom_Plane_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv);
extern "C" DECL_EXPORT void Geom_Plane_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_Plane_SetPln(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Plane_Pln(void* instance);
extern "C" DECL_EXPORT bool Geom_Plane_IsUClosed(void* instance);
extern "C" DECL_EXPORT bool Geom_Plane_IsVClosed(void* instance);
extern "C" DECL_EXPORT bool Geom_Plane_IsUPeriodic(void* instance);
extern "C" DECL_EXPORT bool Geom_Plane_IsVPeriodic(void* instance);
extern "C" DECL_EXPORT void* Geom_Plane_Copy(void* instance);
extern "C" DECL_EXPORT void GeomPlane_Dtor(void* instance);

#endif
