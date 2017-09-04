#include "GeomAPIProjectPointOnSurf.h"
#include <GeomAPI_ProjectPointOnSurf.hxx>

#include <gp_Pnt.hxx>

DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_Ctor()
{
	return new GeomAPI_ProjectPointOnSurf();
}
DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_Ctor491C84E1(
	void* P,
	void* Surface,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	return new GeomAPI_ProjectPointOnSurf(			
_P,			
_Surface,			
_Algo);
}
DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_Ctor72869244(
	void* P,
	void* Surface,
	double Tolerance,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	return new GeomAPI_ProjectPointOnSurf(			
_P,			
_Surface,			
Tolerance,			
_Algo);
}
DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_CtorBF455401(
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	double Tolerance,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	return new GeomAPI_ProjectPointOnSurf(			
_P,			
_Surface,			
Umin,			
Usup,			
Vmin,			
Vsup,			
Tolerance,			
_Algo);
}
DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_CtorCC109054(
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	return new GeomAPI_ProjectPointOnSurf(			
_P,			
_Surface,			
Umin,			
Usup,			
Vmin,			
Vsup,			
_Algo);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Init72869244(
	void* instance,
	void* P,
	void* Surface,
	double Tolerance,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Init(			
_P,			
_Surface,			
Tolerance,			
_Algo);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Init491C84E1(
	void* instance,
	void* P,
	void* Surface,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Init(			
_P,			
_Surface,			
_Algo);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_InitBF455401(
	void* instance,
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	double Tolerance,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Init(			
_P,			
_Surface,			
Umin,			
Usup,			
Vmin,			
Vsup,			
Tolerance,			
_Algo);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_InitCC109054(
	void* instance,
	void* P,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	int Algo)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Init(			
_P,			
_Surface,			
Umin,			
Usup,			
Vmin,			
Vsup,			
_Algo);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_InitC925CD84(
	void* instance,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	double Tolerance,
	int Algo)
{
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Init(			
_Surface,			
Umin,			
Usup,			
Vmin,			
Vsup,			
Tolerance,			
_Algo);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Init702736C(
	void* instance,
	void* Surface,
	double Umin,
	double Usup,
	double Vmin,
	double Vsup,
	int Algo)
{
		const Handle_Geom_Surface&  _Surface =*(const Handle_Geom_Surface *)Surface;
		const Extrema_ExtAlgo _Algo =(const Extrema_ExtAlgo )Algo;
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Init(			
_Surface,			
Umin,			
Usup,			
Vmin,			
Vsup,			
_Algo);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Perform9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Perform(			
_P);
}
DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_PointE8219145(
	void* instance,
	int Index)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
	return new gp_Pnt( 	result->Point(			
Index));
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_Parameters306E0DFB(
	void* instance,
	int Index,
	double* U,
	double* V)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->Parameters(			
Index,			
*U,			
*V);
}
DECL_EXPORT double GeomAPI_ProjectPointOnSurf_DistanceE8219145(
	void* instance,
	int Index)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
	return  	result->Distance(			
Index);
}
DECL_EXPORT void GeomAPI_ProjectPointOnSurf_LowerDistanceParameters9F0E714F(
	void* instance,
	double* U,
	double* V)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
 	result->LowerDistanceParameters(			
*U,			
*V);
}
DECL_EXPORT bool GeomAPI_ProjectPointOnSurf_IsDone(void* instance)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int GeomAPI_ProjectPointOnSurf_NbPoints(void* instance)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
	return 	result->NbPoints();
}

DECL_EXPORT void* GeomAPI_ProjectPointOnSurf_NearestPoint(void* instance)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
	return 	new gp_Pnt(	result->NearestPoint());
}

DECL_EXPORT double GeomAPI_ProjectPointOnSurf_LowerDistance(void* instance)
{
	GeomAPI_ProjectPointOnSurf* result = (GeomAPI_ProjectPointOnSurf*)instance;
	return 	result->LowerDistance();
}

DECL_EXPORT void GeomAPIProjectPointOnSurf_Dtor(void* instance)
{
	delete (GeomAPI_ProjectPointOnSurf*)instance;
}
