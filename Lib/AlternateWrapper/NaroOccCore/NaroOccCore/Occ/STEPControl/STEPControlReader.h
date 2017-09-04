#ifndef STEPControl_Reader_H
#define STEPControl_Reader_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* STEPControl_Reader_Ctor();
extern "C" DECL_EXPORT void* STEPControl_Reader_CtorC53309E3(
	void* WS,
	bool scratch);
extern "C" DECL_EXPORT bool STEPControl_Reader_TransferRootE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT int STEPControl_Reader_NbRootsForTransfer(void* instance);
extern "C" DECL_EXPORT void STEPControlReader_Dtor(void* instance);

#endif
