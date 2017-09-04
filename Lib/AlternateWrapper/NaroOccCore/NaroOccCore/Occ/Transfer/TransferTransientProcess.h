#ifndef Transfer_TransientProcess_H
#define Transfer_TransientProcess_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Transfer_TransientProcess_CtorE8219145(
	int nb);
extern "C" DECL_EXPORT void* Transfer_TransientProcess_Context(void* instance);
extern "C" DECL_EXPORT bool Transfer_TransientProcess_HasGraph(void* instance);
extern "C" DECL_EXPORT void TransferTransientProcess_Dtor(void* instance);

#endif
