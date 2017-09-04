#ifndef Prs2d_Drawer_H
#define Prs2d_Drawer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs2d_Drawer_Ctor();
extern "C" DECL_EXPORT void* Prs2d_Drawer_FindAspect3485EFC5(
	void* instance,
	int anAspectName);
extern "C" DECL_EXPORT void Prs2d_Drawer_SetAspectADBB773B(
	void* instance,
	void* anAspectRoot,
	int anAspectName);
extern "C" DECL_EXPORT void Prs2d_Drawer_SetMaxParameterValue(void* instance, double value);
extern "C" DECL_EXPORT double Prs2d_Drawer_MaxParameterValue(void* instance);
extern "C" DECL_EXPORT void Prs2dDrawer_Dtor(void* instance);

#endif
