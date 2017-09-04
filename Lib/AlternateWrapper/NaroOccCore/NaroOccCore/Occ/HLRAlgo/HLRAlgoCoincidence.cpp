#include "HLRAlgoCoincidence.h"
#include <HLRAlgo_Coincidence.hxx>


DECL_EXPORT void* HLRAlgo_Coincidence_Ctor()
{
	return new HLRAlgo_Coincidence();
}
DECL_EXPORT void HLRAlgo_Coincidence_Set2D69F5FCCD(
	void* instance,
	int FE,
	double Param)
{
	HLRAlgo_Coincidence* result = (HLRAlgo_Coincidence*)instance;
 	result->Set2D(			
FE,			
Param);
}
DECL_EXPORT void HLRAlgo_Coincidence_Value2D69F5FCCD(
	void* instance,
	int* FE,
	double* Param)
{
	HLRAlgo_Coincidence* result = (HLRAlgo_Coincidence*)instance;
 	result->Value2D(			
*FE,			
*Param);
}
DECL_EXPORT void HLRAlgoCoincidence_Dtor(void* instance)
{
	delete (HLRAlgo_Coincidence*)instance;
}
