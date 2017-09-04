#include "GeomAdaptorSurface.h"
#include <GeomAdaptor_Surface.hxx>

#include <Adaptor3d_HCurve.hxx>
#include <Adaptor3d_HSurface.hxx>
#include <Geom_Surface.hxx>
#include <gp_Ax1.hxx>
#include <gp_Cone.hxx>
#include <gp_Cylinder.hxx>
#include <gp_Dir.hxx>
#include <gp_Pln.hxx>
#include <gp_Pnt.hxx>
#include <gp_Sphere.hxx>
#include <gp_Torus.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* GeomAdaptor_Surface_Ctor()
{
	return new GeomAdaptor_Surface();
}
DECL_EXPORT void* GeomAdaptor_Surface_Ctor9001466F(
	void* S)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	return new GeomAdaptor_Surface(			
_S);
}
DECL_EXPORT void* GeomAdaptor_Surface_CtorBCD666D6(
	void* S,
	double UFirst,
	double ULast,
	double VFirst,
	double VLast,
	double TolU,
	double TolV)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	return new GeomAdaptor_Surface(			
_S,			
UFirst,			
ULast,			
VFirst,			
VLast,			
TolU,			
TolV);
}
DECL_EXPORT void GeomAdaptor_Surface_Load9001466F(
	void* instance,
	void* S)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
 	result->Load(			
_S);
}
DECL_EXPORT void GeomAdaptor_Surface_LoadBCD666D6(
	void* instance,
	void* S,
	double UFirst,
	double ULast,
	double VFirst,
	double VLast,
	double TolU,
	double TolV)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
 	result->Load(			
_S,			
UFirst,			
ULast,			
VFirst,			
VLast,			
TolU,			
TolV);
}
DECL_EXPORT int GeomAdaptor_Surface_NbUIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return  	result->NbUIntervals(			
_S);
}
DECL_EXPORT int GeomAdaptor_Surface_NbVIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return  	result->NbVIntervals(			
_S);
}
DECL_EXPORT void* GeomAdaptor_Surface_UTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return new Handle_Adaptor3d_HSurface( 	result->UTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* GeomAdaptor_Surface_VTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return new Handle_Adaptor3d_HSurface( 	result->VTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* GeomAdaptor_Surface_Value9F0E714F(
	void* instance,
	double U,
	double V)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return new gp_Pnt( 	result->Value(			
U,			
V));
}
DECL_EXPORT void GeomAdaptor_Surface_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
 	result->D0(			
U,			
V,			
_P);
}
DECL_EXPORT void GeomAdaptor_Surface_D14153CD1A(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _D1U =*(gp_Vec *)D1U;
		gp_Vec &  _D1V =*(gp_Vec *)D1V;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
 	result->D1(			
U,			
V,			
_P,			
_D1U,			
_D1V);
}
DECL_EXPORT void GeomAdaptor_Surface_D2E9F600EF(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V,
	void* D2U,
	void* D2V,
	void* D2UV)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _D1U =*(gp_Vec *)D1U;
		gp_Vec &  _D1V =*(gp_Vec *)D1V;
		gp_Vec &  _D2U =*(gp_Vec *)D2U;
		gp_Vec &  _D2V =*(gp_Vec *)D2V;
		gp_Vec &  _D2UV =*(gp_Vec *)D2UV;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
 	result->D2(			
U,			
V,			
_P,			
_D1U,			
_D1V,			
_D2U,			
_D2V,			
_D2UV);
}
DECL_EXPORT void GeomAdaptor_Surface_D3B100120D(
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
	void* D3UVV)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _D1U =*(gp_Vec *)D1U;
		gp_Vec &  _D1V =*(gp_Vec *)D1V;
		gp_Vec &  _D2U =*(gp_Vec *)D2U;
		gp_Vec &  _D2V =*(gp_Vec *)D2V;
		gp_Vec &  _D2UV =*(gp_Vec *)D2UV;
		gp_Vec &  _D3U =*(gp_Vec *)D3U;
		gp_Vec &  _D3V =*(gp_Vec *)D3V;
		gp_Vec &  _D3UUV =*(gp_Vec *)D3UUV;
		gp_Vec &  _D3UVV =*(gp_Vec *)D3UVV;
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
 	result->D3(			
U,			
V,			
_P,			
_D1U,			
_D1V,			
_D2U,			
_D2V,			
_D2UV,			
_D3U,			
_D3V,			
_D3UUV,			
_D3UVV);
}
DECL_EXPORT void* GeomAdaptor_Surface_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return new gp_Vec( 	result->DN(			
U,			
V,			
Nu,			
Nv));
}
DECL_EXPORT double GeomAdaptor_Surface_UResolutionD82819F3(
	void* instance,
	double R3d)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return  	result->UResolution(			
R3d);
}
DECL_EXPORT double GeomAdaptor_Surface_VResolutionD82819F3(
	void* instance,
	double R3d)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return  	result->VResolution(			
R3d);
}
DECL_EXPORT void* GeomAdaptor_Surface_Surface(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new Handle_Geom_Surface(	result->Surface());
}

DECL_EXPORT double GeomAdaptor_Surface_FirstUParameter(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->FirstUParameter();
}

DECL_EXPORT double GeomAdaptor_Surface_LastUParameter(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->LastUParameter();
}

DECL_EXPORT double GeomAdaptor_Surface_FirstVParameter(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->FirstVParameter();
}

DECL_EXPORT double GeomAdaptor_Surface_LastVParameter(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->LastVParameter();
}

DECL_EXPORT int GeomAdaptor_Surface_UContinuity(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return (int)	result->UContinuity();
}

DECL_EXPORT int GeomAdaptor_Surface_VContinuity(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return (int)	result->VContinuity();
}

DECL_EXPORT bool GeomAdaptor_Surface_IsUClosed(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->IsUClosed();
}

DECL_EXPORT bool GeomAdaptor_Surface_IsVClosed(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->IsVClosed();
}

DECL_EXPORT bool GeomAdaptor_Surface_IsUPeriodic(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->IsUPeriodic();
}

DECL_EXPORT double GeomAdaptor_Surface_UPeriod(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->UPeriod();
}

DECL_EXPORT bool GeomAdaptor_Surface_IsVPeriodic(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->IsVPeriodic();
}

DECL_EXPORT double GeomAdaptor_Surface_VPeriod(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->VPeriod();
}

DECL_EXPORT int GeomAdaptor_Surface_GetType(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return (int)	result->GetType();
}

DECL_EXPORT void* GeomAdaptor_Surface_Plane(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new gp_Pln(	result->Plane());
}

DECL_EXPORT void* GeomAdaptor_Surface_Cylinder(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new gp_Cylinder(	result->Cylinder());
}

DECL_EXPORT void* GeomAdaptor_Surface_Cone(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new gp_Cone(	result->Cone());
}

DECL_EXPORT void* GeomAdaptor_Surface_Sphere(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new gp_Sphere(	result->Sphere());
}

DECL_EXPORT void* GeomAdaptor_Surface_Torus(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new gp_Torus(	result->Torus());
}

DECL_EXPORT int GeomAdaptor_Surface_UDegree(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->UDegree();
}

DECL_EXPORT int GeomAdaptor_Surface_NbUPoles(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->NbUPoles();
}

DECL_EXPORT int GeomAdaptor_Surface_VDegree(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->VDegree();
}

DECL_EXPORT int GeomAdaptor_Surface_NbVPoles(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->NbVPoles();
}

DECL_EXPORT int GeomAdaptor_Surface_NbUKnots(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->NbUKnots();
}

DECL_EXPORT int GeomAdaptor_Surface_NbVKnots(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->NbVKnots();
}

DECL_EXPORT bool GeomAdaptor_Surface_IsURational(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->IsURational();
}

DECL_EXPORT bool GeomAdaptor_Surface_IsVRational(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->IsVRational();
}

DECL_EXPORT void* GeomAdaptor_Surface_AxeOfRevolution(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new gp_Ax1(	result->AxeOfRevolution());
}

DECL_EXPORT void* GeomAdaptor_Surface_Direction(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void* GeomAdaptor_Surface_BasisCurve(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new Handle_Adaptor3d_HCurve(	result->BasisCurve());
}

DECL_EXPORT void* GeomAdaptor_Surface_BasisSurface(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	new Handle_Adaptor3d_HSurface(	result->BasisSurface());
}

DECL_EXPORT double GeomAdaptor_Surface_OffsetValue(void* instance)
{
	GeomAdaptor_Surface* result = (GeomAdaptor_Surface*)instance;
	return 	result->OffsetValue();
}

DECL_EXPORT void GeomAdaptorSurface_Dtor(void* instance)
{
	delete (GeomAdaptor_Surface*)instance;
}
