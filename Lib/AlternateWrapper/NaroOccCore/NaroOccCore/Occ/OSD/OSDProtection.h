#ifndef OSD_Protection_H
#define OSD_Protection_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* OSD_Protection_Ctor();
extern "C" DECL_EXPORT void* OSD_Protection_Ctor4B0D101E(
	int System,
	int User,
	int Group,
	int World);
extern "C" DECL_EXPORT void OSD_Protection_SetSystem(void* instance, int value);
extern "C" DECL_EXPORT int OSD_Protection_System(void* instance);
extern "C" DECL_EXPORT void OSD_Protection_SetUser(void* instance, int value);
extern "C" DECL_EXPORT int OSD_Protection_User(void* instance);
extern "C" DECL_EXPORT void OSD_Protection_SetGroup(void* instance, int value);
extern "C" DECL_EXPORT int OSD_Protection_Group(void* instance);
extern "C" DECL_EXPORT void OSD_Protection_SetWorld(void* instance, int value);
extern "C" DECL_EXPORT int OSD_Protection_World(void* instance);
extern "C" DECL_EXPORT void OSDProtection_Dtor(void* instance);

#endif
