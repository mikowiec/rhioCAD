#ifndef HLRAlgo_Coincidence_H
#define HLRAlgo_Coincidence_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* HLRAlgo_Coincidence_Ctor();
extern "C" DECL_EXPORT void HLRAlgo_Coincidence_Set2D69F5FCCD(
	void* instance,
	int FE,
	double Param);
extern "C" DECL_EXPORT void HLRAlgo_Coincidence_Value2D69F5FCCD(
	void* instance,
	int* FE,
	double* Param);
extern "C" DECL_EXPORT void HLRAlgoCoincidence_Dtor(void* instance);

#endif
