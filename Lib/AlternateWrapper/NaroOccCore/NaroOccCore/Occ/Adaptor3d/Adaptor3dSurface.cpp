#include "Adaptor3dSurface.h"
#include <Adaptor3d_Surface.hxx>

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

DECL_EXPORT void Adaptor3d_Surface_Delete(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
 	result->Delete();
}
DECL_EXPORT int Adaptor3d_Surface_NbUIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return  	result->NbUIntervals(			
_S);
}
DECL_EXPORT int Adaptor3d_Surface_NbVIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return  	result->NbVIntervals(			
_S);
}
DECL_EXPORT void* Adaptor3d_Surface_UTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return new Handle_Adaptor3d_HSurface( 	result->UTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* Adaptor3d_Surface_VTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return new Handle_Adaptor3d_HSurface( 	result->VTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* Adaptor3d_Surface_Value9F0E714F(
	void* instance,
	double U,
	double V)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return new gp_Pnt( 	result->Value(			
U,			
V));
}
DECL_EXPORT void Adaptor3d_Surface_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
 	result->D0(			
U,			
V,			
_P);
}
DECL_EXPORT void Adaptor3d_Surface_D14153CD1A(
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
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
 	result->D1(			
U,			
V,			
_P,			
_D1U,			
_D1V);
}
DECL_EXPORT void Adaptor3d_Surface_D2E9F600EF(
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
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
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
DECL_EXPORT void Adaptor3d_Surface_D3B100120D(
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
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
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
DECL_EXPORT void* Adaptor3d_Surface_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return new gp_Vec( 	result->DN(			
U,			
V,			
Nu,			
Nv));
}
DECL_EXPORT double Adaptor3d_Surface_UResolutionD82819F3(
	void* instance,
	double R3d)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return  	result->UResolution(			
R3d);
}
DECL_EXPORT double Adaptor3d_Surface_VResolutionD82819F3(
	void* instance,
	double R3d)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return  	result->VResolution(			
R3d);
}
DECL_EXPORT double Adaptor3d_Surface_FirstUParameter(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->FirstUParameter();
}

DECL_EXPORT double Adaptor3d_Surface_LastUParameter(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->LastUParameter();
}

DECL_EXPORT double Adaptor3d_Surface_FirstVParameter(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->FirstVParameter();
}

DECL_EXPORT double Adaptor3d_Surface_LastVParameter(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->LastVParameter();
}

DECL_EXPORT int Adaptor3d_Surface_UContinuity(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return (int)	result->UContinuity();
}

DECL_EXPORT int Adaptor3d_Surface_VContinuity(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return (int)	result->VContinuity();
}

DECL_EXPORT bool Adaptor3d_Surface_IsUClosed(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->IsUClosed();
}

DECL_EXPORT bool Adaptor3d_Surface_IsVClosed(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->IsVClosed();
}

DECL_EXPORT bool Adaptor3d_Surface_IsUPeriodic(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->IsUPeriodic();
}

DECL_EXPORT double Adaptor3d_Surface_UPeriod(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->UPeriod();
}

DECL_EXPORT bool Adaptor3d_Surface_IsVPeriodic(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->IsVPeriodic();
}

DECL_EXPORT double Adaptor3d_Surface_VPeriod(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->VPeriod();
}

DECL_EXPORT int Adaptor3d_Surface_GetType(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return (int)	result->GetType();
}

DECL_EXPORT void* Adaptor3d_Surface_Plane(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new gp_Pln(	result->Plane());
}

DECL_EXPORT void* Adaptor3d_Surface_Cylinder(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new gp_Cylinder(	result->Cylinder());
}

DECL_EXPORT void* Adaptor3d_Surface_Cone(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new gp_Cone(	result->Cone());
}

DECL_EXPORT void* Adaptor3d_Surface_Sphere(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new gp_Sphere(	result->Sphere());
}

DECL_EXPORT void* Adaptor3d_Surface_Torus(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new gp_Torus(	result->Torus());
}

DECL_EXPORT int Adaptor3d_Surface_UDegree(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->UDegree();
}

DECL_EXPORT int Adaptor3d_Surface_NbUPoles(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->NbUPoles();
}

DECL_EXPORT int Adaptor3d_Surface_VDegree(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->VDegree();
}

DECL_EXPORT int Adaptor3d_Surface_NbVPoles(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->NbVPoles();
}

DECL_EXPORT int Adaptor3d_Surface_NbUKnots(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->NbUKnots();
}

DECL_EXPORT int Adaptor3d_Surface_NbVKnots(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->NbVKnots();
}

DECL_EXPORT bool Adaptor3d_Surface_IsURational(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->IsURational();
}

DECL_EXPORT bool Adaptor3d_Surface_IsVRational(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->IsVRational();
}

DECL_EXPORT void* Adaptor3d_Surface_AxeOfRevolution(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new gp_Ax1(	result->AxeOfRevolution());
}

DECL_EXPORT void* Adaptor3d_Surface_Direction(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void* Adaptor3d_Surface_BasisCurve(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new Handle_Adaptor3d_HCurve(	result->BasisCurve());
}

DECL_EXPORT void* Adaptor3d_Surface_BasisSurface(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	new Handle_Adaptor3d_HSurface(	result->BasisSurface());
}

DECL_EXPORT double Adaptor3d_Surface_OffsetValue(void* instance)
{
	Adaptor3d_Surface* result = (Adaptor3d_Surface*)instance;
	return 	result->OffsetValue();
}

DECL_EXPORT void Adaptor3dSurface_Dtor(void* instance)
{
	delete (Adaptor3d_Surface*)instance;
}
