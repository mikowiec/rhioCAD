#ifndef SelectBasics_EntityOwner_H
#define SelectBasics_EntityOwner_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void SelectBasics_EntityOwner_SetE8219145(
	void* instance,
	int aPriority);
extern "C" DECL_EXPORT int SelectBasics_EntityOwner_Priority(void* instance);
extern "C" DECL_EXPORT void SelectBasicsEntityOwner_Dtor(void* instance);

#endif
