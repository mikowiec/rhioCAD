#include "GeomAPIProjectPointOnCurve.h"
#include <GeomAPI_ProjectPointOnCurve.hxx>

#include <gp_Pnt.hxx>

DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_Ctor()
{
	return new GeomAPI_ProjectPointOnCurve();
}
DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_Ctor36F2535D(
	void* P,
	void* Curve)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Curve&  _Curve =*(const Handle_Geom_Curve *)Curve;
	return new GeomAPI_ProjectPointOnCurve(			
_P,			
_Curve);
}
DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_CtorFD13CCB9(
	void* P,
	void* Curve,
	double Umin,
	double Usup)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Curve&  _Curve =*(const Handle_Geom_Curve *)Curve;
	return new GeomAPI_ProjectPointOnCurve(			
_P,			
_Curve,			
Umin,			
Usup);
}
DECL_EXPORT void GeomAPI_ProjectPointOnCurve_Init36F2535D(
	void* instance,
	void* P,
	void* Curve)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Curve&  _Curve =*(const Handle_Geom_Curve *)Curve;
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
 	result->Init(			
_P,			
_Curve);
}
DECL_EXPORT void GeomAPI_ProjectPointOnCurve_InitFD13CCB9(
	void* instance,
	void* P,
	void* Curve,
	double Umin,
	double Usup)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Handle_Geom_Curve&  _Curve =*(const Handle_Geom_Curve *)Curve;
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
 	result->Init(			
_P,			
_Curve,			
Umin,			
Usup);
}
DECL_EXPORT void GeomAPI_ProjectPointOnCurve_InitED53F64D(
	void* instance,
	void* Curve,
	double Umin,
	double Usup)
{
		const Handle_Geom_Curve&  _Curve =*(const Handle_Geom_Curve *)Curve;
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
 	result->Init(			
_Curve,			
Umin,			
Usup);
}
DECL_EXPORT void GeomAPI_ProjectPointOnCurve_Perform9EAECD5B(
	void* instance,
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
 	result->Perform(			
_P);
}
DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_PointE8219145(
	void* instance,
	int Index)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
	return new gp_Pnt( 	result->Point(			
Index));
}
DECL_EXPORT double GeomAPI_ProjectPointOnCurve_ParameterE8219145(
	void* instance,
	int Index)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
	return  	result->Parameter(			
Index);
}
DECL_EXPORT void GeomAPI_ProjectPointOnCurve_Parameter69F5FCCD(
	void* instance,
	int Index,
	double* U)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
 	result->Parameter(			
Index,			
*U);
}
DECL_EXPORT double GeomAPI_ProjectPointOnCurve_DistanceE8219145(
	void* instance,
	int Index)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
	return  	result->Distance(			
Index);
}
DECL_EXPORT int GeomAPI_ProjectPointOnCurve_NbPoints(void* instance)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
	return 	result->NbPoints();
}

DECL_EXPORT void* GeomAPI_ProjectPointOnCurve_NearestPoint(void* instance)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
	return 	new gp_Pnt(	result->NearestPoint());
}

DECL_EXPORT double GeomAPI_ProjectPointOnCurve_LowerDistanceParameter(void* instance)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
	return 	result->LowerDistanceParameter();
}

DECL_EXPORT double GeomAPI_ProjectPointOnCurve_LowerDistance(void* instance)
{
	GeomAPI_ProjectPointOnCurve* result = (GeomAPI_ProjectPointOnCurve*)instance;
	return 	result->LowerDistance();
}

DECL_EXPORT void GeomAPIProjectPointOnCurve_Dtor(void* instance)
{
	delete (GeomAPI_ProjectPointOnCurve*)instance;
}
