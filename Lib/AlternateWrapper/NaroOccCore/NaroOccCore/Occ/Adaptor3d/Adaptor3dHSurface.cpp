#include "Adaptor3dHSurface.h"
#include <Adaptor3d_HSurface.hxx>

#include <Adaptor3d_HCurve.hxx>
#include <Adaptor3d_HSurface.hxx>
#include <gp_Ax1.hxx>
#include <gp_Cone.hxx>
#include <gp_Cylinder.hxx>
#include <gp_Dir.hxx>
#include <gp_Pln.hxx>
#include <gp_Pnt.hxx>
#include <gp_Sphere.hxx>
#include <gp_Torus.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT int Adaptor3d_HSurface_NbUIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return  	result->NbUIntervals(			
_S);
}
DECL_EXPORT int Adaptor3d_HSurface_NbVIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return  	result->NbVIntervals(			
_S);
}
DECL_EXPORT void* Adaptor3d_HSurface_UTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return new Handle_Adaptor3d_HSurface( 	result->UTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* Adaptor3d_HSurface_VTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return new Handle_Adaptor3d_HSurface( 	result->VTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* Adaptor3d_HSurface_Value9F0E714F(
	void* instance,
	double U,
	double V)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return new gp_Pnt( 	result->Value(			
U,			
V));
}
DECL_EXPORT void Adaptor3d_HSurface_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
 	result->D0(			
U,			
V,			
_P);
}
DECL_EXPORT void Adaptor3d_HSurface_D14153CD1A(
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
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
 	result->D1(			
U,			
V,			
_P,			
_D1U,			
_D1V);
}
DECL_EXPORT void Adaptor3d_HSurface_D2E9F600EF(
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
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
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
DECL_EXPORT void Adaptor3d_HSurface_D3B100120D(
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
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
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
DECL_EXPORT void* Adaptor3d_HSurface_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
V,			
Nu,			
Nv));
}
DECL_EXPORT double Adaptor3d_HSurface_UResolutionD82819F3(
	void* instance,
	double R3d)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return  	result->UResolution(			
R3d);
}
DECL_EXPORT double Adaptor3d_HSurface_VResolutionD82819F3(
	void* instance,
	double R3d)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return  	result->VResolution(			
R3d);
}
DECL_EXPORT double Adaptor3d_HSurface_FirstUParameter(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->FirstUParameter();
}

DECL_EXPORT double Adaptor3d_HSurface_LastUParameter(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->LastUParameter();
}

DECL_EXPORT double Adaptor3d_HSurface_FirstVParameter(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->FirstVParameter();
}

DECL_EXPORT double Adaptor3d_HSurface_LastVParameter(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->LastVParameter();
}

DECL_EXPORT int Adaptor3d_HSurface_UContinuity(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return (int)	result->UContinuity();
}

DECL_EXPORT int Adaptor3d_HSurface_VContinuity(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return (int)	result->VContinuity();
}

DECL_EXPORT bool Adaptor3d_HSurface_IsUClosed(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->IsUClosed();
}

DECL_EXPORT bool Adaptor3d_HSurface_IsVClosed(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->IsVClosed();
}

DECL_EXPORT bool Adaptor3d_HSurface_IsUPeriodic(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->IsUPeriodic();
}

DECL_EXPORT double Adaptor3d_HSurface_UPeriod(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->UPeriod();
}

DECL_EXPORT bool Adaptor3d_HSurface_IsVPeriodic(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->IsVPeriodic();
}

DECL_EXPORT double Adaptor3d_HSurface_VPeriod(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->VPeriod();
}

DECL_EXPORT int Adaptor3d_HSurface_GetType(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return (int)	result->GetType();
}

DECL_EXPORT void* Adaptor3d_HSurface_Plane(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new gp_Pln(	result->Plane());
}

DECL_EXPORT void* Adaptor3d_HSurface_Cylinder(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new gp_Cylinder(	result->Cylinder());
}

DECL_EXPORT void* Adaptor3d_HSurface_Cone(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new gp_Cone(	result->Cone());
}

DECL_EXPORT void* Adaptor3d_HSurface_Sphere(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new gp_Sphere(	result->Sphere());
}

DECL_EXPORT void* Adaptor3d_HSurface_Torus(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new gp_Torus(	result->Torus());
}

DECL_EXPORT int Adaptor3d_HSurface_UDegree(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->UDegree();
}

DECL_EXPORT int Adaptor3d_HSurface_NbUPoles(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->NbUPoles();
}

DECL_EXPORT int Adaptor3d_HSurface_VDegree(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->VDegree();
}

DECL_EXPORT int Adaptor3d_HSurface_NbVPoles(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->NbVPoles();
}

DECL_EXPORT int Adaptor3d_HSurface_NbUKnots(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->NbUKnots();
}

DECL_EXPORT int Adaptor3d_HSurface_NbVKnots(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->NbVKnots();
}

DECL_EXPORT bool Adaptor3d_HSurface_IsURational(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->IsURational();
}

DECL_EXPORT bool Adaptor3d_HSurface_IsVRational(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->IsVRational();
}

DECL_EXPORT void* Adaptor3d_HSurface_AxeOfRevolution(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new gp_Ax1(	result->AxeOfRevolution());
}

DECL_EXPORT void* Adaptor3d_HSurface_Direction(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void* Adaptor3d_HSurface_BasisCurve(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new Handle_Adaptor3d_HCurve(	result->BasisCurve());
}

DECL_EXPORT void* Adaptor3d_HSurface_BasisSurface(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	new Handle_Adaptor3d_HSurface(	result->BasisSurface());
}

DECL_EXPORT double Adaptor3d_HSurface_OffsetValue(void* instance)
{
	Adaptor3d_HSurface* result = (Adaptor3d_HSurface*)(((Handle_Adaptor3d_HSurface*)instance)->Access());
	return 	result->OffsetValue();
}

DECL_EXPORT void Adaptor3dHSurface_Dtor(void* instance)
{
	delete (Handle_Adaptor3d_HSurface*)instance;
}
