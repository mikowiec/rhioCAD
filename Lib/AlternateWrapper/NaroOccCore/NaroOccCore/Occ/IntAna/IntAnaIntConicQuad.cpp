#include "IntAnaIntConicQuad.h"
#include <IntAna_IntConicQuad.hxx>

#include <gp_Pnt.hxx>

DECL_EXPORT void* IntAna_IntConicQuad_Ctor()
{
	return new IntAna_IntConicQuad();
}
DECL_EXPORT void* IntAna_IntConicQuad_Ctor89334BAA(
	void* L,
	void* P,
	double Tolang)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	return new IntAna_IntConicQuad(			
_L,			
_P,			
Tolang);
}
DECL_EXPORT void* IntAna_IntConicQuad_Ctor8C72EA96(
	void* C,
	void* P,
	double Tolang,
	double Tol)
{
		const gp_Circ &  _C =*(const gp_Circ *)C;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	return new IntAna_IntConicQuad(			
_C,			
_P,			
Tolang,			
Tol);
}
DECL_EXPORT void* IntAna_IntConicQuad_Ctor9E3F6D56(
	void* E,
	void* P,
	double Tolang,
	double Tol)
{
		const gp_Elips &  _E =*(const gp_Elips *)E;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	return new IntAna_IntConicQuad(			
_E,			
_P,			
Tolang,			
Tol);
}
DECL_EXPORT void* IntAna_IntConicQuad_CtorFF3C8AFC(
	void* Pb,
	void* P,
	double Tolang)
{
		const gp_Parab &  _Pb =*(const gp_Parab *)Pb;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	return new IntAna_IntConicQuad(			
_Pb,			
_P,			
Tolang);
}
DECL_EXPORT void* IntAna_IntConicQuad_Ctor1B97E413(
	void* H,
	void* P,
	double Tolang)
{
		const gp_Hypr &  _H =*(const gp_Hypr *)H;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	return new IntAna_IntConicQuad(			
_H,			
_P,			
Tolang);
}
DECL_EXPORT void IntAna_IntConicQuad_Perform89334BAA(
	void* instance,
	void* L,
	void* P,
	double Tolang)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
 	result->Perform(			
_L,			
_P,			
Tolang);
}
DECL_EXPORT void IntAna_IntConicQuad_Perform8C72EA96(
	void* instance,
	void* C,
	void* P,
	double Tolang,
	double Tol)
{
		const gp_Circ &  _C =*(const gp_Circ *)C;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
 	result->Perform(			
_C,			
_P,			
Tolang,			
Tol);
}
DECL_EXPORT void IntAna_IntConicQuad_Perform9E3F6D56(
	void* instance,
	void* E,
	void* P,
	double Tolang,
	double Tol)
{
		const gp_Elips &  _E =*(const gp_Elips *)E;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
 	result->Perform(			
_E,			
_P,			
Tolang,			
Tol);
}
DECL_EXPORT void IntAna_IntConicQuad_PerformFF3C8AFC(
	void* instance,
	void* Pb,
	void* P,
	double Tolang)
{
		const gp_Parab &  _Pb =*(const gp_Parab *)Pb;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
 	result->Perform(			
_Pb,			
_P,			
Tolang);
}
DECL_EXPORT void IntAna_IntConicQuad_Perform1B97E413(
	void* instance,
	void* H,
	void* P,
	double Tolang)
{
		const gp_Hypr &  _H =*(const gp_Hypr *)H;
		const gp_Pln &  _P =*(const gp_Pln *)P;
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
 	result->Perform(			
_H,			
_P,			
Tolang);
}
DECL_EXPORT void* IntAna_IntConicQuad_PointE8219145(
	void* instance,
	int N)
{
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
	return new gp_Pnt( 	result->Point(			
N));
}
DECL_EXPORT double IntAna_IntConicQuad_ParamOnConicE8219145(
	void* instance,
	int N)
{
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
	return  	result->ParamOnConic(			
N);
}
DECL_EXPORT bool IntAna_IntConicQuad_IsDone(void* instance)
{
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
	return 	result->IsDone();
}

DECL_EXPORT bool IntAna_IntConicQuad_IsInQuadric(void* instance)
{
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
	return 	result->IsInQuadric();
}

DECL_EXPORT bool IntAna_IntConicQuad_IsParallel(void* instance)
{
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
	return 	result->IsParallel();
}

DECL_EXPORT int IntAna_IntConicQuad_NbPoints(void* instance)
{
	IntAna_IntConicQuad* result = (IntAna_IntConicQuad*)instance;
	return 	result->NbPoints();
}

DECL_EXPORT void IntAnaIntConicQuad_Dtor(void* instance)
{
	delete (IntAna_IntConicQuad*)instance;
}
