#ifndef XSControl_Reader_H
#define XSControl_Reader_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* XSControl_Reader_Ctor();
extern "C" DECL_EXPORT void* XSControl_Reader_Ctor9381D4D(
	char* norm);
extern "C" DECL_EXPORT void* XSControl_Reader_CtorC53309E3(
	void* WS,
	bool scratch);
extern "C" DECL_EXPORT bool XSControl_Reader_SetNorm9381D4D(
	void* instance,
	char* norm);
extern "C" DECL_EXPORT void XSControl_Reader_SetWSC53309E3(
	void* instance,
	void* WS,
	bool scratch);
extern "C" DECL_EXPORT void* XSControl_Reader_WS(void* instance);
extern "C" DECL_EXPORT int XSControl_Reader_ReadFile9381D4D(
	void* instance,
	char* filename);
extern "C" DECL_EXPORT void* XSControl_Reader_RootForTransferE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT bool XSControl_Reader_TransferOneRootE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT bool XSControl_Reader_TransferOneE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT bool XSControl_Reader_TransferEntityF411CB01(
	void* instance,
	void* start);
extern "C" DECL_EXPORT void XSControl_Reader_ClearShapes(void* instance);
extern "C" DECL_EXPORT void* XSControl_Reader_ShapeE8219145(
	void* instance,
	int num);
extern "C" DECL_EXPORT void XSControl_Reader_PrintCheckLoad57E14BA(
	void* instance,
	bool failsonly,
	int mode);
extern "C" DECL_EXPORT void XSControl_Reader_PrintCheckTransfer57E14BA(
	void* instance,
	bool failsonly,
	int mode);
extern "C" DECL_EXPORT void XSControl_Reader_PrintStatsTransfer5107F6FE(
	void* instance,
	int what,
	int mode);
extern "C" DECL_EXPORT int XSControl_Reader_NbRootsForTransfer(void* instance);
extern "C" DECL_EXPORT int XSControl_Reader_TransferRoots(void* instance);
extern "C" DECL_EXPORT int XSControl_Reader_NbShapes(void* instance);
extern "C" DECL_EXPORT void* XSControl_Reader_OneShape(void* instance);
extern "C" DECL_EXPORT void XSControlReader_Dtor(void* instance);

#endif
