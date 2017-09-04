#include "ElSLib.h"
#include <ElSLib.hxx>

#include <gp_Circ.hxx>
#include <gp_Lin.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void* ElSLib_ValueF8AFA8C9(
	double U,
	double V,
	void* Pl)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
	return new gp_Pnt( ElSLib::Value(			
U,			
V,			
_Pl));
}
DECL_EXPORT void* ElSLib_Value2E3DA8BC(
	double U,
	double V,
	void* C)
{
		const gp_Cone &  _C =*(const gp_Cone *)C;
	return new gp_Pnt( ElSLib::Value(			
U,			
V,			
_C));
}
DECL_EXPORT void* ElSLib_Value9C94886B(
	double U,
	double V,
	void* C)
{
		const gp_Cylinder &  _C =*(const gp_Cylinder *)C;
	return new gp_Pnt( ElSLib::Value(			
U,			
V,			
_C));
}
DECL_EXPORT void* ElSLib_ValueA6EAF455(
	double U,
	double V,
	void* S)
{
		const gp_Sphere &  _S =*(const gp_Sphere *)S;
	return new gp_Pnt( ElSLib::Value(			
U,			
V,			
_S));
}
DECL_EXPORT void* ElSLib_Value4E3B815B(
	double U,
	double V,
	void* T)
{
		const gp_Torus &  _T =*(const gp_Torus *)T;
	return new gp_Pnt( ElSLib::Value(			
U,			
V,			
_T));
}
DECL_EXPORT void* ElSLib_PlaneValueCFBE1681(
	double U,
	double V,
	void* Pos)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Pnt( ElSLib::PlaneValue(			
U,			
V,			
_Pos));
}
DECL_EXPORT void* ElSLib_CylinderValueBACDEA69(
	double U,
	double V,
	void* Pos,
	double Radius)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Pnt( ElSLib::CylinderValue(			
U,			
V,			
_Pos,			
Radius));
}
DECL_EXPORT void* ElSLib_ConeValue5CAF831A(
	double U,
	double V,
	void* Pos,
	double Radius,
	double SAngle)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Pnt( ElSLib::ConeValue(			
U,			
V,			
_Pos,			
Radius,			
SAngle));
}
DECL_EXPORT void* ElSLib_SphereValueBACDEA69(
	double U,
	double V,
	void* Pos,
	double Radius)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Pnt( ElSLib::SphereValue(			
U,			
V,			
_Pos,			
Radius));
}
DECL_EXPORT void* ElSLib_TorusValue5CAF831A(
	double U,
	double V,
	void* Pos,
	double MajorRadius,
	double MinorRadius)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Pnt( ElSLib::TorusValue(			
U,			
V,			
_Pos,			
MajorRadius,			
MinorRadius));
}
DECL_EXPORT void ElSLib_Parameters26ED892A(
	void* Pl,
	void* P,
	double* U,
	double* V)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::Parameters(			
_Pl,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_Parameters93A5F71D(
	void* C,
	void* P,
	double* U,
	double* V)
{
		const gp_Cylinder &  _C =*(const gp_Cylinder *)C;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::Parameters(			
_C,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_Parameters128A564F(
	void* C,
	void* P,
	double* U,
	double* V)
{
		const gp_Cone &  _C =*(const gp_Cone *)C;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::Parameters(			
_C,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_Parameters70B953D6(
	void* S,
	void* P,
	double* U,
	double* V)
{
		const gp_Sphere &  _S =*(const gp_Sphere *)S;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::Parameters(			
_S,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_Parameters820B077D(
	void* T,
	void* P,
	double* U,
	double* V)
{
		const gp_Torus &  _T =*(const gp_Torus *)T;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::Parameters(			
_T,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_PlaneParametersC11F2078(
	void* Pos,
	void* P,
	double* U,
	double* V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::PlaneParameters(			
_Pos,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_CylinderParameters2262D7A7(
	void* Pos,
	double Radius,
	void* P,
	double* U,
	double* V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::CylinderParameters(			
_Pos,			
Radius,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_ConeParametersE2117665(
	void* Pos,
	double Radius,
	double SAngle,
	void* P,
	double* U,
	double* V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::ConeParameters(			
_Pos,			
Radius,			
SAngle,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_SphereParameters2262D7A7(
	void* Pos,
	double Radius,
	void* P,
	double* U,
	double* V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::SphereParameters(			
_Pos,			
Radius,			
_P,			
*U,			
*V);
}
DECL_EXPORT void ElSLib_TorusParametersE2117665(
	void* Pos,
	double MajorRadius,
	double MinorRadius,
	void* P,
	double* U,
	double* V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
 ElSLib::TorusParameters(			
_Pos,			
MajorRadius,			
MinorRadius,			
_P,			
*U,			
*V);
}
DECL_EXPORT void* ElSLib_PlaneUIso5C6D1CB8(
	void* Pos,
	double U)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Lin( ElSLib::PlaneUIso(			
_Pos,			
U));
}
DECL_EXPORT void* ElSLib_CylinderUIso32BF0691(
	void* Pos,
	double Radius,
	double U)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Lin( ElSLib::CylinderUIso(			
_Pos,			
Radius,			
U));
}
DECL_EXPORT void* ElSLib_ConeUIso649F02B6(
	void* Pos,
	double Radius,
	double SAngle,
	double U)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Lin( ElSLib::ConeUIso(			
_Pos,			
Radius,			
SAngle,			
U));
}
DECL_EXPORT void* ElSLib_SphereUIso32BF0691(
	void* Pos,
	double Radius,
	double U)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Circ( ElSLib::SphereUIso(			
_Pos,			
Radius,			
U));
}
DECL_EXPORT void* ElSLib_TorusUIso649F02B6(
	void* Pos,
	double MajorRadius,
	double MinorRadius,
	double U)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Circ( ElSLib::TorusUIso(			
_Pos,			
MajorRadius,			
MinorRadius,			
U));
}
DECL_EXPORT void* ElSLib_PlaneVIso5C6D1CB8(
	void* Pos,
	double V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Lin( ElSLib::PlaneVIso(			
_Pos,			
V));
}
DECL_EXPORT void* ElSLib_CylinderVIso32BF0691(
	void* Pos,
	double Radius,
	double V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Circ( ElSLib::CylinderVIso(			
_Pos,			
Radius,			
V));
}
DECL_EXPORT void* ElSLib_ConeVIso649F02B6(
	void* Pos,
	double Radius,
	double SAngle,
	double V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Circ( ElSLib::ConeVIso(			
_Pos,			
Radius,			
SAngle,			
V));
}
DECL_EXPORT void* ElSLib_SphereVIso32BF0691(
	void* Pos,
	double Radius,
	double V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Circ( ElSLib::SphereVIso(			
_Pos,			
Radius,			
V));
}
DECL_EXPORT void* ElSLib_TorusVIso649F02B6(
	void* Pos,
	double MajorRadius,
	double MinorRadius,
	double V)
{
		const gp_Ax3 &  _Pos =*(const gp_Ax3 *)Pos;
	return new gp_Circ( ElSLib::TorusVIso(			
_Pos,			
MajorRadius,			
MinorRadius,			
V));
}
DECL_EXPORT void ElSLib_Dtor(void* instance)
{
	delete (ElSLib*)instance;
}
