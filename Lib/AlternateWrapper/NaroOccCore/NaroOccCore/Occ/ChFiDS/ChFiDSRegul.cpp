#include "ChFiDSRegul.h"
#include <ChFiDS_Regul.hxx>


DECL_EXPORT void* ChFiDS_Regul_Ctor()
{
	return new ChFiDS_Regul();
}
DECL_EXPORT void ChFiDS_Regul_SetS1898DAFFC(
	void* instance,
	int IS1,
	bool IsFace)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
 	result->SetS1(			
IS1,			
IsFace);
}
DECL_EXPORT void ChFiDS_Regul_SetS2898DAFFC(
	void* instance,
	int IS2,
	bool IsFace)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
 	result->SetS2(			
IS2,			
IsFace);
}
DECL_EXPORT int ChFiDS_Regul_S1(void* instance)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
	return  	result->S1();
}
DECL_EXPORT int ChFiDS_Regul_S2(void* instance)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
	return  	result->S2();
}
DECL_EXPORT bool ChFiDS_Regul_IsSurface1(void* instance)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
	return 	result->IsSurface1();
}

DECL_EXPORT bool ChFiDS_Regul_IsSurface2(void* instance)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
	return 	result->IsSurface2();
}

DECL_EXPORT void ChFiDS_Regul_SetCurve(void* instance, int value)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
		result->SetCurve(value);
}

DECL_EXPORT int ChFiDS_Regul_Curve(void* instance)
{
	ChFiDS_Regul* result = (ChFiDS_Regul*)instance;
	return 	result->Curve();
}

DECL_EXPORT void ChFiDSRegul_Dtor(void* instance)
{
	delete (ChFiDS_Regul*)instance;
}
