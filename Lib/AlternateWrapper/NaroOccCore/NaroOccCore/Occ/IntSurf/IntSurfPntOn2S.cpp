#include "IntSurfPntOn2S.h"
#include <IntSurf_PntOn2S.hxx>

#include <gp_Pnt.hxx>

DECL_EXPORT void* IntSurf_PntOn2S_Ctor()
{
	return new IntSurf_PntOn2S();
}
DECL_EXPORT void IntSurf_PntOn2S_SetValue9EAECD5B(
	void* instance,
	void* Pt)
{
		const gp_Pnt &  _Pt =*(const gp_Pnt *)Pt;
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->SetValue(			
_Pt);
}
DECL_EXPORT void IntSurf_PntOn2S_SetValue705FE798(
	void* instance,
	void* Pt,
	bool OnFirst,
	double U,
	double V)
{
		const gp_Pnt &  _Pt =*(const gp_Pnt *)Pt;
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->SetValue(			
_Pt,			
OnFirst,			
U,			
V);
}
DECL_EXPORT void IntSurf_PntOn2S_SetValueD969C62A(
	void* instance,
	void* Pt,
	double U1,
	double V1,
	double U2,
	double V2)
{
		const gp_Pnt &  _Pt =*(const gp_Pnt *)Pt;
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->SetValue(			
_Pt,			
U1,			
V1,			
U2,			
V2);
}
DECL_EXPORT void IntSurf_PntOn2S_SetValueDA23FEE7(
	void* instance,
	bool OnFirst,
	double U,
	double V)
{
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->SetValue(			
OnFirst,			
U,			
V);
}
DECL_EXPORT void IntSurf_PntOn2S_SetValueC2777E0C(
	void* instance,
	double U1,
	double V1,
	double U2,
	double V2)
{
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->SetValue(			
U1,			
V1,			
U2,			
V2);
}
DECL_EXPORT void* IntSurf_PntOn2S_Value(void* instance)
{
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
	return new gp_Pnt( 	result->Value());
}
DECL_EXPORT void IntSurf_PntOn2S_ParametersOnS19F0E714F(
	void* instance,
	double* U1,
	double* V1)
{
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->ParametersOnS1(			
*U1,			
*V1);
}
DECL_EXPORT void IntSurf_PntOn2S_ParametersOnS29F0E714F(
	void* instance,
	double* U2,
	double* V2)
{
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->ParametersOnS2(			
*U2,			
*V2);
}
DECL_EXPORT void IntSurf_PntOn2S_ParametersC2777E0C(
	void* instance,
	double* U1,
	double* V1,
	double* U2,
	double* V2)
{
	IntSurf_PntOn2S* result = (IntSurf_PntOn2S*)instance;
 	result->Parameters(			
*U1,			
*V1,			
*U2,			
*V2);
}
DECL_EXPORT void IntSurfPntOn2S_Dtor(void* instance)
{
	delete (IntSurf_PntOn2S*)instance;
}
