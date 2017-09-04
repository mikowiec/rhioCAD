#ifndef GeomAPI_ProjectPointOnSurf_H
#define GeomAPI_ProjectPointOnSurf_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_Ctor();
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_Ctor491C84E1(
	void* P,
	void* Surface,
	int Algo);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_Ctor72869244(
	void* P,
	void* Surface,
	double Tolerance,
	int Algo);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_CtorBF455401(
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	double Tolerance,
	int Algo);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_CtorCC109054(
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	int Algo);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Init72869244(
	void* instance,
	void* P,
	void* Surface,
	double Tolerance,
	int Algo);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Init491C84E1(
	void* instance,
	void* P,
	void* Surface,
	int Algo);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_InitBF455401(
	void* instance,
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	double Tolerance,
	int Algo);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_InitCC109054(
	void* instance,
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	int Algo);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_InitC925CD84(
	void* instance,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	double Tolerance,
	int Algo);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Init702736C(
	void* instance,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	int Algo);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Perform9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_PointE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Parameters306E0DFB(
	void* instance,
	int Index,
	double* U,
	double* V);
extern "C" DECL_EXPORT double GeomAPI_ProjectPointOnSurf_DistanceE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void GeomAPI_ProjectPointOnSurf_LowerDistanceParameters9F0E714F(
	void* instance,
	double* U,
	double* V);
extern "C" DECL_EXPORT bool GeomAPI_ProjectPointOnSurf_IsDone(void* instance);
extern "C" DECL_EXPORT int GeomAPI_ProjectPointOnSurf_NbPoints(void* instance);
extern "C" DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_NearestPoint(void* instance);
extern "C" DECL_EXPORT double GeomAPI_ProjectPointOnSurf_LowerDistance(void* instance);
extern "C" DECL_EXPORT void GeomAPIProjectPointOnSurf_Dtor(void* instance);

#endif
