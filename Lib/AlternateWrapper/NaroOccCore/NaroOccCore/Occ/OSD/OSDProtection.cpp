#include "OSDProtection.h"
#include <OSD_Protection.hxx>


DECL_EXPORT void* OSD_Protection_Ctor()
{
	return new OSD_Protection();
}
DECL_EXPORT void* OSD_Protection_Ctor4B0D101E(
	int System,
	int User,
	int Group,
	int World)
{
		const OSD_SingleProtection _System =(const OSD_SingleProtection )System;
		const OSD_SingleProtection _User =(const OSD_SingleProtection )User;
		const OSD_SingleProtection _Group =(const OSD_SingleProtection )Group;
		const OSD_SingleProtection _World =(const OSD_SingleProtection )World;
	return new OSD_Protection(			
_System,			
_User,			
_Group,			
_World);
}
DECL_EXPORT void OSD_Protection_SetSystem(void* instance, int value)
{
	OSD_Protection* result = (OSD_Protection*)instance;
		result->SetSystem((const OSD_SingleProtection)value);
}

DECL_EXPORT int OSD_Protection_System(void* instance)
{
	OSD_Protection* result = (OSD_Protection*)instance;
	return (int)	result->System();
}

DECL_EXPORT void OSD_Protection_SetUser(void* instance, int value)
{
	OSD_Protection* result = (OSD_Protection*)instance;
		result->SetUser((const OSD_SingleProtection)value);
}

DECL_EXPORT int OSD_Protection_User(void* instance)
{
	OSD_Protection* result = (OSD_Protection*)instance;
	return (int)	result->User();
}

DECL_EXPORT void OSD_Protection_SetGroup(void* instance, int value)
{
	OSD_Protection* result = (OSD_Protection*)instance;
		result->SetGroup((const OSD_SingleProtection)value);
}

DECL_EXPORT int OSD_Protection_Group(void* instance)
{
	OSD_Protection* result = (OSD_Protection*)instance;
	return (int)	result->Group();
}

DECL_EXPORT void OSD_Protection_SetWorld(void* instance, int value)
{
	OSD_Protection* result = (OSD_Protection*)instance;
		result->SetWorld((const OSD_SingleProtection)value);
}

DECL_EXPORT int OSD_Protection_World(void* instance)
{
	OSD_Protection* result = (OSD_Protection*)instance;
	return (int)	result->World();
}

DECL_EXPORT void OSDProtection_Dtor(void* instance)
{
	delete (OSD_Protection*)instance;
}
