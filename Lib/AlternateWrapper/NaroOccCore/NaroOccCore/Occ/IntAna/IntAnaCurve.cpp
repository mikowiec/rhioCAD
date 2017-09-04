#include "IntAnaCurve.h"
#include <IntAna_Curve.hxx>

#include <gp_Pnt.hxx>

DECL_EXPORT void* IntAna_Curve_Ctor()
{
	return new IntAna_Curve();
}
DECL_EXPORT void IntAna_Curve_SetCylinderQuadValuesA2ABD1B0(
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
	bool ZIsPositive)
{
		const gp_Cylinder &  _Cylinder =*(const gp_Cylinder *)Cylinder;
	IntAna_Curve* result = (IntAna_Curve*)instance;
 	result->SetCylinderQuadValues(			
_Cylinder,			
Qxx,			
Qyy,			
Qzz,			
Qxy,			
Qxz,			
Qyz,			
Qx,			
Qy,			
Qz,			
Q1,			
Tol,			
DomInf,			
DomSup,			
TwoZForATheta,			
ZIsPositive);
}
DECL_EXPORT void IntAna_Curve_SetConeQuadValuesEF30360(
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
	bool ZIsPositive)
{
		const gp_Cone &  _Cone =*(const gp_Cone *)Cone;
	IntAna_Curve* result = (IntAna_Curve*)instance;
 	result->SetConeQuadValues(			
_Cone,			
Qxx,			
Qyy,			
Qzz,			
Qxy,			
Qxz,			
Qyz,			
Qx,			
Qy,			
Qz,			
Q1,			
Tol,			
DomInf,			
DomSup,			
TwoZForATheta,			
ZIsPositive);
}
DECL_EXPORT void IntAna_Curve_Domain9F0E714F(
	void* instance,
	double* Theta1,
	double* Theta2)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
 	result->Domain(			
*Theta1,			
*Theta2);
}
DECL_EXPORT void* IntAna_Curve_ValueD82819F3(
	void* instance,
	double Theta)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
	return new gp_Pnt( 	result->Value(			
Theta));
}
DECL_EXPORT bool IntAna_Curve_D1u1387A81(
	void* instance,
	double Theta,
	void* P,
	void* V)
{
		 gp_Pnt &  _P =*( gp_Pnt *)P;
		 gp_Vec &  _V =*( gp_Vec *)V;
	IntAna_Curve* result = (IntAna_Curve*)instance;
	return  	result->D1u(			
Theta,			
_P,			
_V);
}
DECL_EXPORT bool IntAna_Curve_FindParameterF0D1E3E6(
	void* instance,
	void* P,
	double* Para)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	IntAna_Curve* result = (IntAna_Curve*)instance;
	return  	result->FindParameter(			
_P,			
*Para);
}
DECL_EXPORT void IntAna_Curve_InternalUVValueE32698D4(
	void* instance,
	double Param,
	double* U,
	double* V,
	double* A,
	double* B,
	double* C,
	double* Co,
	double* Si,
	double* Di)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
 	result->InternalUVValue(			
Param,			
*U,			
*V,			
*A,			
*B,			
*C,			
*Co,			
*Si,			
*Di);
}
DECL_EXPORT void IntAna_Curve_SetDomain9F0E714F(
	void* instance,
	double Theta1,
	double Theta2)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
 	result->SetDomain(			
Theta1,			
Theta2);
}
DECL_EXPORT bool IntAna_Curve_IsOpen(void* instance)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
	return 	result->IsOpen();
}

DECL_EXPORT bool IntAna_Curve_IsConstant(void* instance)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
	return 	result->IsConstant();
}

DECL_EXPORT void IntAna_Curve_SetIsFirstOpen(void* instance, bool value)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
		result->SetIsFirstOpen(value);
}

DECL_EXPORT bool IntAna_Curve_IsFirstOpen(void* instance)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
	return 	result->IsFirstOpen();
}

DECL_EXPORT void IntAna_Curve_SetIsLastOpen(void* instance, bool value)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
		result->SetIsLastOpen(value);
}

DECL_EXPORT bool IntAna_Curve_IsLastOpen(void* instance)
{
	IntAna_Curve* result = (IntAna_Curve*)instance;
	return 	result->IsLastOpen();
}

DECL_EXPORT void IntAnaCurve_Dtor(void* instance)
{
	delete (IntAna_Curve*)instance;
}
