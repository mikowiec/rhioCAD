#ifndef IntAna_Curve_H
#define IntAna_Curve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntAna_Curve_Ctor();
extern "C" DECL_EXPORT void IntAna_Curve_SetCylinderQuadValuesA2ABD1B0(
	void* instance,
	void* Cylinder,
	double Qxx,
	double Qyy,
	double Qzz,
	double Qxy,
	double Qxz,
	double Qyz,
	double Qx,
	double Qy,
	double Qz,
	double Q1,
	double Tol,
	double DomInf,
	double DomSup,
	bool TwoZForATheta,
	bool ZIsPositive);
extern "C" DECL_EXPORT void IntAna_Curve_SetConeQuadValuesEF30360(
	void* instance,
	void* Cone,
	double Qxx,
	double Qyy,
	double Qzz,
	double Qxy,
	double Qxz,
	double Qyz,
	double Qx,
	double Qy,
	double Qz,
	double Q1,
	double Tol,
	double DomInf,
	double DomSup,
	bool TwoZForATheta,
	bool ZIsPositive);
extern "C" DECL_EXPORT void IntAna_Curve_Domain9F0E714F(
	void* instance,
	double* Theta1,
	double* Theta2);
extern "C" DECL_EXPORT void* IntAna_Curve_ValueD82819F3(
	void* instance,
	double Theta);
extern "C" DECL_EXPORT bool IntAna_Curve_D1u1387A81(
	void* instance,
	double Theta,
	void* P,
	void* V);
extern "C" DECL_EXPORT bool IntAna_Curve_FindParameterF0D1E3E6(
	void* instance,
	void* P,
	double* Para);
extern "C" DECL_EXPORT void IntAna_Curve_InternalUVValueE32698D4(
	void* instance,
	double Param,
	double* U,
	double* V,
	double* A,
	double* B,
	double* C,
	double* Co,
	double* Si,
	double* Di);
extern "C" DECL_EXPORT void IntAna_Curve_SetDomain9F0E714F(
	void* instance,
	double Theta1,
	double Theta2);
extern "C" DECL_EXPORT bool IntAna_Curve_IsOpen(void* instance);
extern "C" DECL_EXPORT bool IntAna_Curve_IsConstant(void* instance);
extern "C" DECL_EXPORT void IntAna_Curve_SetIsFirstOpen(void* instance, bool value);
extern "C" DECL_EXPORT bool IntAna_Curve_IsFirstOpen(void* instance);
extern "C" DECL_EXPORT void IntAna_Curve_SetIsLastOpen(void* instance, bool value);
extern "C" DECL_EXPORT bool IntAna_Curve_IsLastOpen(void* instance);
extern "C" DECL_EXPORT void IntAnaCurve_Dtor(void* instance);

#endif
