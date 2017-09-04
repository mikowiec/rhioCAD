#ifndef GeomAPI_ProjectPointOnCurve_H
#define GeomAPI_ProjectPointOnCurve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_Ctor();
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_Ctor36F2535D(
	void* P,
	void* Curve);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_CtorFD13CCB9(
	void* P,
	void* Curve,
	double Umin,
	double Usup);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnCurve_Init36F2535D(
	void* instance,
	void* P,
	void* Curve);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnCurve_InitFD13CCB9(
	void* instance,
	void* P,
	void* Curve,
	double Umin,
	double Usup);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnCurve_InitED53F64D(
	void* instance,
	void* Curve,
	double Umin,
	double Usup);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnCurve_Perform9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_PointE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT double GeomAPI_ProjectPointOnCurve_ParameterE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnCurve_Parameter69F5FCCD(
	void* instance,
	int Index,
	double* U);
extern "C" DECL_EXPORT double GeomAPI_ProjectPointOnCurve_DistanceE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT int GeomAPI_ProjectPointOnCurve_NbPoints(void* instance);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_NearestPoint(void* instance);
extern "C" DECL_EXPORT double GeomAPI_ProjectPointOnCurve_LowerDistanceParameter(void* instance);
extern "C" DECL_EXPORT double GeomAPI_ProjectPointOnCurve_LowerDistance(void* instance);
extern "C" DECL_EXPORT void GeomAPIProjectPointOnCurve_Dtor(void* instance);

#endif
