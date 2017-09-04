#ifndef ElSLib_H
#define ElSLib_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* ElSLib_ValueF8AFA8C9(
	double U,
	double V,
	void* Pl);
extern "C" DECL_EXPORT void* ElSLib_Value2E3DA8BC(
	double U,
	double V,
	void* C);
extern "C" DECL_EXPORT void* ElSLib_Value9C94886B(
	double U,
	double V,
	void* C);
extern "C" DECL_EXPORT void* ElSLib_ValueA6EAF455(
	double U,
	double V,
	void* S);
extern "C" DECL_EXPORT void* ElSLib_Value4E3B815B(
	double U,
	double V,
	void* T);
extern "C" DECL_EXPORT void* ElSLib_PlaneValueCFBE1681(
	double U,
	double V,
	void* Pos);
extern "C" DECL_EXPORT void* ElSLib_CylinderValueBACDEA69(
	double U,
	double V,
	void* Pos,
	double Radius);
extern "C" DECL_EXPORT void* ElSLib_ConeValue5CAF831A(
	double U,
	double V,
	void* Pos,
	double Radius,
	double SAngle);
extern "C" DECL_EXPORT void* ElSLib_SphereValueBACDEA69(
	double U,
	double V,
	void* Pos,
	double Radius);
extern "C" DECL_EXPORT void* ElSLib_TorusValue5CAF831A(
	double U,
	double V,
	void* Pos,
	double MajorRadius,
	double MinorRadius);
extern "C" DECL_EXPORT void ElSLib_Parameters26ED892A(
	void* Pl,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_Parameters93A5F71D(
	void* C,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_Parameters128A564F(
	void* C,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_Parameters70B953D6(
	void* S,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_Parameters820B077D(
	void* T,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_PlaneParametersC11F2078(
	void* Pos,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_CylinderParameters2262D7A7(
	void* Pos,
	double Radius,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_ConeParametersE2117665(
	void* Pos,
	double Radius,
	double SAngle,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_SphereParameters2262D7A7(
	void* Pos,
	double Radius,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void ElSLib_TorusParametersE2117665(
	void* Pos,
	double MajorRadius,
	double MinorRadius,
	void* P,
	double* U,
	double* V);
extern "C" DECL_EXPORT void* ElSLib_PlaneUIso5C6D1CB8(
	void* Pos,
	double U);
extern "C" DECL_EXPORT void* ElSLib_CylinderUIso32BF0691(
	void* Pos,
	double Radius,
	double U);
extern "C" DECL_EXPORT void* ElSLib_ConeUIso649F02B6(
	void* Pos,
	double Radius,
	double SAngle,
	double U);
extern "C" DECL_EXPORT void* ElSLib_SphereUIso32BF0691(
	void* Pos,
	double Radius,
	double U);
extern "C" DECL_EXPORT void* ElSLib_TorusUIso649F02B6(
	void* Pos,
	double MajorRadius,
	double MinorRadius,
	double U);
extern "C" DECL_EXPORT void* ElSLib_PlaneVIso5C6D1CB8(
	void* Pos,
	double V);
extern "C" DECL_EXPORT void* ElSLib_CylinderVIso32BF0691(
	void* Pos,
	double Radius,
	double V);
extern "C" DECL_EXPORT void* ElSLib_ConeVIso649F02B6(
	void* Pos,
	double Radius,
	double SAngle,
	double V);
extern "C" DECL_EXPORT void* ElSLib_SphereVIso32BF0691(
	void* Pos,
	double Radius,
	double V);
extern "C" DECL_EXPORT void* ElSLib_TorusVIso649F02B6(
	void* Pos,
	double MajorRadius,
	double MinorRadius,
	double V);
extern "C" DECL_EXPORT void ElSLib_Dtor(void* instance);

#endif
