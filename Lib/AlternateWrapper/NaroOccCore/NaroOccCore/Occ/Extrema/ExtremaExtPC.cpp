#include "ExtremaExtPC.h"
#include <Extrema_ExtPC.hxx>


DECL_EXPORT void* Extrema_ExtPC_Ctor()
{
	return new Extrema_ExtPC();
}
DECL_EXPORT void* Extrema_ExtPC_CtorCF4A20E8(
	void* P,
	void* C,
	double Uinf,
	double Usup,
	double TolF)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Adaptor3d_Curve &  _C =*(const Adaptor3d_Curve *)C;
	return new Extrema_ExtPC(			
_P,			
_C,			
Uinf,			
Usup,			
TolF);
}
DECL_EXPORT void* Extrema_ExtPC_CtorB2B0ECF0(
	void* P,
	void* C,
	double TolF)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const Adaptor3d_Curve &  _C =*(const Adaptor3d_Curve *)C;
	return new Extrema_ExtPC(			
_P,			
_C,			
TolF);
}
DECL_EXPORT void Extrema_ExtPC_InitializeFE87C4E9(
	void* instance,
	void* C,
	double Uinf,
	double Usup,
	double TolF)
{
		const Adaptor3d_Curve &  _C =*(const Adaptor3d_Curve *)C;
	Extrema_ExtPC* result = (Extrema_ExtPC*)instance;
 	result->Initialize(			
_C,			
Uinf,			
Usup,			
TolF);
}
DECL_EXPORT double Extrema_ExtPC_SquareDistanceE8219145(
	void* instance,
	int N)
{
	Extrema_ExtPC* result = (Extrema_ExtPC*)instance;
	return  	result->SquareDistance(			
N);
}
DECL_EXPORT void Extrema_ExtPC_TrimmedSquareDistancesB51F241F(
	void* instance,
	double* dist1,
	double* dist2,
	void* P1,
	void* P2)
{
		 gp_Pnt &  _P1 =*( gp_Pnt *)P1;
		 gp_Pnt &  _P2 =*( gp_Pnt *)P2;
	Extrema_ExtPC* result = (Extrema_ExtPC*)instance;
 	result->TrimmedSquareDistances(			
*dist1,			
*dist2,			
_P1,			
_P2);
}
DECL_EXPORT bool Extrema_ExtPC_IsDone(void* instance)
{
	Extrema_ExtPC* result = (Extrema_ExtPC*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int Extrema_ExtPC_NbExt(void* instance)
{
	Extrema_ExtPC* result = (Extrema_ExtPC*)instance;
	return 	result->NbExt();
}

DECL_EXPORT void ExtremaExtPC_Dtor(void* instance)
{
	delete (Extrema_ExtPC*)instance;
}
