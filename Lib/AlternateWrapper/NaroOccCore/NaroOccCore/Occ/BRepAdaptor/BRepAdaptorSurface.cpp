#include "BRepAdaptorSurface.h"
#include <BRepAdaptor_Surface.hxx>

#include <Adaptor3d_HCurve.hxx>
#include <Adaptor3d_HSurface.hxx>
#include <GeomAdaptor_Surface.hxx>
#include <gp_Ax1.hxx>
#include <gp_Cone.hxx>
#include <gp_Cylinder.hxx>
#include <gp_Dir.hxx>
#include <gp_Pln.hxx>
#include <gp_Pnt.hxx>
#include <gp_Sphere.hxx>
#include <gp_Torus.hxx>
#include <gp_Trsf.hxx>
#include <gp_Vec.hxx>
#include <TopoDS_Face.hxx>

DECL_EXPORT void* BRepAdaptor_Surface_Ctor()
{
	return new BRepAdaptor_Surface();
}
DECL_EXPORT void* BRepAdaptor_Surface_Ctor4945DBAD(
	void* F,
	bool R)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	return new BRepAdaptor_Surface(			
_F,			
R);
}
DECL_EXPORT void BRepAdaptor_Surface_Initialize4945DBAD(
	void* instance,
	void* F,
	bool Restriction)
{
		const TopoDS_Face &  _F =*(const TopoDS_Face *)F;
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
 	result->Initialize(			
_F,			
Restriction);
}
DECL_EXPORT int BRepAdaptor_Surface_NbUIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return  	result->NbUIntervals(			
_S);
}
DECL_EXPORT int BRepAdaptor_Surface_NbVIntervals5ABD177E(
	void* instance,
	int S)
{
		const GeomAbs_Shape _S =(const GeomAbs_Shape )S;
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return  	result->NbVIntervals(			
_S);
}
DECL_EXPORT void* BRepAdaptor_Surface_UTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return new Handle_Adaptor3d_HSurface( 	result->UTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* BRepAdaptor_Surface_VTrim9282A951(
	void* instance,
	double First,
	double Last,
	double Tol)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return new Handle_Adaptor3d_HSurface( 	result->VTrim(			
First,			
Last,			
Tol));
}
DECL_EXPORT void* BRepAdaptor_Surface_Value9F0E714F(
	void* instance,
	double U,
	double V)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return new gp_Pnt( 	result->Value(			
U,			
V));
}
DECL_EXPORT void BRepAdaptor_Surface_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
 	result->D0(			
U,			
V,			
_P);
}
DECL_EXPORT void BRepAdaptor_Surface_D14153CD1A(
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
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
 	result->D1(			
U,			
V,			
_P,			
_D1U,			
_D1V);
}
DECL_EXPORT void BRepAdaptor_Surface_D2E9F600EF(
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
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
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
DECL_EXPORT void BRepAdaptor_Surface_D3B100120D(
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
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
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
DECL_EXPORT void* BRepAdaptor_Surface_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return new gp_Vec( 	result->DN(			
U,			
V,			
Nu,			
Nv));
}
DECL_EXPORT double BRepAdaptor_Surface_UResolutionD82819F3(
	void* instance,
	double R3d)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return  	result->UResolution(			
R3d);
}
DECL_EXPORT double BRepAdaptor_Surface_VResolutionD82819F3(
	void* instance,
	double R3d)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return  	result->VResolution(			
R3d);
}
DECL_EXPORT void* BRepAdaptor_Surface_Surface(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new GeomAdaptor_Surface(	result->Surface());
}

DECL_EXPORT void* BRepAdaptor_Surface_ChangeSurface(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new GeomAdaptor_Surface(	result->ChangeSurface());
}

DECL_EXPORT void* BRepAdaptor_Surface_Trsf(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Trsf(	result->Trsf());
}

DECL_EXPORT void* BRepAdaptor_Surface_Face(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new TopoDS_Face(	result->Face());
}

DECL_EXPORT double BRepAdaptor_Surface_Tolerance(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->Tolerance();
}

DECL_EXPORT double BRepAdaptor_Surface_FirstUParameter(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->FirstUParameter();
}

DECL_EXPORT double BRepAdaptor_Surface_LastUParameter(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->LastUParameter();
}

DECL_EXPORT double BRepAdaptor_Surface_FirstVParameter(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->FirstVParameter();
}

DECL_EXPORT double BRepAdaptor_Surface_LastVParameter(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->LastVParameter();
}

DECL_EXPORT int BRepAdaptor_Surface_UContinuity(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return (int)	result->UContinuity();
}

DECL_EXPORT int BRepAdaptor_Surface_VContinuity(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return (int)	result->VContinuity();
}

DECL_EXPORT bool BRepAdaptor_Surface_IsUClosed(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->IsUClosed();
}

DECL_EXPORT bool BRepAdaptor_Surface_IsVClosed(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->IsVClosed();
}

DECL_EXPORT bool BRepAdaptor_Surface_IsUPeriodic(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->IsUPeriodic();
}

DECL_EXPORT double BRepAdaptor_Surface_UPeriod(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->UPeriod();
}

DECL_EXPORT bool BRepAdaptor_Surface_IsVPeriodic(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->IsVPeriodic();
}

DECL_EXPORT double BRepAdaptor_Surface_VPeriod(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->VPeriod();
}

DECL_EXPORT int BRepAdaptor_Surface_GetType(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return (int)	result->GetType();
}

DECL_EXPORT void* BRepAdaptor_Surface_Plane(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Pln(	result->Plane());
}

DECL_EXPORT void* BRepAdaptor_Surface_Cylinder(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Cylinder(	result->Cylinder());
}

DECL_EXPORT void* BRepAdaptor_Surface_Cone(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Cone(	result->Cone());
}

DECL_EXPORT void* BRepAdaptor_Surface_Sphere(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Sphere(	result->Sphere());
}

DECL_EXPORT void* BRepAdaptor_Surface_Torus(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Torus(	result->Torus());
}

DECL_EXPORT int BRepAdaptor_Surface_UDegree(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->UDegree();
}

DECL_EXPORT int BRepAdaptor_Surface_NbUPoles(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->NbUPoles();
}

DECL_EXPORT int BRepAdaptor_Surface_VDegree(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->VDegree();
}

DECL_EXPORT int BRepAdaptor_Surface_NbVPoles(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->NbVPoles();
}

DECL_EXPORT int BRepAdaptor_Surface_NbUKnots(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->NbUKnots();
}

DECL_EXPORT int BRepAdaptor_Surface_NbVKnots(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->NbVKnots();
}

DECL_EXPORT bool BRepAdaptor_Surface_IsURational(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->IsURational();
}

DECL_EXPORT bool BRepAdaptor_Surface_IsVRational(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->IsVRational();
}

DECL_EXPORT void* BRepAdaptor_Surface_AxeOfRevolution(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Ax1(	result->AxeOfRevolution());
}

DECL_EXPORT void* BRepAdaptor_Surface_Direction(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void* BRepAdaptor_Surface_BasisCurve(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new Handle_Adaptor3d_HCurve(	result->BasisCurve());
}

DECL_EXPORT void* BRepAdaptor_Surface_BasisSurface(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	new Handle_Adaptor3d_HSurface(	result->BasisSurface());
}

DECL_EXPORT double BRepAdaptor_Surface_OffsetValue(void* instance)
{
	BRepAdaptor_Surface* result = (BRepAdaptor_Surface*)instance;
	return 	result->OffsetValue();
}

DECL_EXPORT void BRepAdaptorSurface_Dtor(void* instance)
{
	delete (BRepAdaptor_Surface*)instance;
}
