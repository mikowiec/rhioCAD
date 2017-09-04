#ifndef STEPControl_Writer_H
#define STEPControl_Writer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* STEPControl_Writer_Ctor();
extern "C" DECL_EXPORT void* STEPControl_Writer_CtorC53309E3(
	void* WS,
	bool scratch);
extern "C" DECL_EXPORT void STEPControl_Writer_UnsetTolerance(void* instance);
extern "C" DECL_EXPORT void STEPControl_Writer_SetWSC53309E3(
	void* instance,
	void* WS,
	bool scratch);
extern "C" DECL_EXPORT void* STEPControl_Writer_WS(void* instance);
extern "C" DECL_EXPORT int STEPControl_Writer_Transfer9FBB318E(
	void* instance,
	void* sh,
	int mode,
	bool compgraph);
extern "C" DECL_EXPORT int STEPControl_Writer_Write9381D4D(
	void* instance,
	char* filename);
extern "C" DECL_EXPORT void STEPControl_Writer_PrintStatsTransfer5107F6FE(
	void* instance,
	int what,
	int mode);
extern "C" DECL_EXPORT void STEPControl_Writer_SetTolerance(void* instance, double value);
extern "C" DECL_EXPORT void STEPControlWriter_Dtor(void* instance);

#endif
