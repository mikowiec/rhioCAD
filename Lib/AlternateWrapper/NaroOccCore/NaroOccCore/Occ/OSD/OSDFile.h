#ifndef OSD_File_H
#define OSD_File_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* OSD_File_Ctor();
extern "C" DECL_EXPORT void* OSD_File_CtorF0BBCC0E(
	void* Name);
extern "C" DECL_EXPORT void OSD_File_Build5E99AF11(
	void* instance,
	int Mode,
	void* Protect);
extern "C" DECL_EXPORT void OSD_File_Open5E99AF11(
	void* instance,
	int Mode,
	void* Protect);
extern "C" DECL_EXPORT void OSD_File_Append5E99AF11(
	void* instance,
	int Mode,
	void* Protect);
extern "C" DECL_EXPORT void OSD_File_ReadLine10E3C1BB(
	void* instance,
	void* Buffer,
	int NByte,
	int* NbyteRead);
extern "C" DECL_EXPORT void OSD_File_Seek1868D864(
	void* instance,
	int Offset,
	int Whence);
extern "C" DECL_EXPORT void OSD_File_Close(void* instance);
extern "C" DECL_EXPORT void OSD_File_UnLock(void* instance);
extern "C" DECL_EXPORT void OSD_File_Print21D3F920(
	void* instance,
	void* WhichPrinter);
extern "C" DECL_EXPORT bool OSD_File_ReadLastLine10E3C1BB(
	void* instance,
	void* aLine,
	int aDelay,
	int aNbTries);
extern "C" DECL_EXPORT bool OSD_File_IsAtEnd(void* instance);
extern "C" DECL_EXPORT int OSD_File_KindOfFile(void* instance);
extern "C" DECL_EXPORT void* OSD_File_BuildTemporary();
extern "C" DECL_EXPORT void OSD_File_SetLock(void* instance, int value);
extern "C" DECL_EXPORT int OSD_File_GetLock(void* instance);
extern "C" DECL_EXPORT bool OSD_File_IsLocked(void* instance);
extern "C" DECL_EXPORT int OSD_File_Size(void* instance);
extern "C" DECL_EXPORT bool OSD_File_IsOpen(void* instance);
extern "C" DECL_EXPORT bool OSD_File_IsReadable(void* instance);
extern "C" DECL_EXPORT bool OSD_File_IsWriteable(void* instance);
extern "C" DECL_EXPORT bool OSD_File_IsExecutable(void* instance);
extern "C" DECL_EXPORT bool OSD_File_Edit(void* instance);
extern "C" DECL_EXPORT void OSDFile_Dtor(void* instance);

#endif
