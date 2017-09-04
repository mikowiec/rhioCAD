#ifndef OSD_Printer_H
#define OSD_Printer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* OSD_Printer_Ctor66CFACD0(
	void* Name);
extern "C" DECL_EXPORT void OSD_Printer_SetName66CFACD0(
	void* instance,
	void* Name);
extern "C" DECL_EXPORT void OSD_Printer_Name66CFACD0(
	void* instance,
	void* Name);
extern "C" DECL_EXPORT void OSD_Printer_Reset(void* instance);
extern "C" DECL_EXPORT void OSD_Printer_Perror(void* instance);
extern "C" DECL_EXPORT bool OSD_Printer_Failed(void* instance);
extern "C" DECL_EXPORT int OSD_Printer_Error(void* instance);
extern "C" DECL_EXPORT void OSDPrinter_Dtor(void* instance);

#endif
