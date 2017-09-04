#ifndef OSD_FileNode_H
#define OSD_FileNode_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void OSD_FileNode_PathF0BBCC0E(
	void* instance,
	void* Name);
extern "C" DECL_EXPORT void OSD_FileNode_SetPathF0BBCC0E(
	void* instance,
	void* Name);
extern "C" DECL_EXPORT void OSD_FileNode_Remove(void* instance);
extern "C" DECL_EXPORT void OSD_FileNode_MoveF0BBCC0E(
	void* instance,
	void* NewPath);
extern "C" DECL_EXPORT void OSD_FileNode_CopyF0BBCC0E(
	void* instance,
	void* ToPath);
extern "C" DECL_EXPORT void OSD_FileNode_Reset(void* instance);
extern "C" DECL_EXPORT void OSD_FileNode_Perror(void* instance);
extern "C" DECL_EXPORT bool OSD_FileNode_Exists(void* instance);
extern "C" DECL_EXPORT void OSD_FileNode_SetProtection(void* instance, void* value);
extern "C" DECL_EXPORT void* OSD_FileNode_Protection(void* instance);
extern "C" DECL_EXPORT void* OSD_FileNode_AccessMoment(void* instance);
extern "C" DECL_EXPORT void* OSD_FileNode_CreationMoment(void* instance);
extern "C" DECL_EXPORT int OSD_FileNode_UserId(void* instance);
extern "C" DECL_EXPORT int OSD_FileNode_GroupId(void* instance);
extern "C" DECL_EXPORT bool OSD_FileNode_Failed(void* instance);
extern "C" DECL_EXPORT int OSD_FileNode_Error(void* instance);
extern "C" DECL_EXPORT void OSDFileNode_Dtor(void* instance);

#endif
