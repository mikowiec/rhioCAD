#include "gceRoot.h"
#include <gce_Root.hxx>


DECL_EXPORT bool gce_Root_IsDone(void* instance)
{
	gce_Root* result = (gce_Root*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int gce_Root_Status(void* instance)
{
	gce_Root* result = (gce_Root*)instance;
	return (int)	result->Status();
}

DECL_EXPORT void gceRoot_Dtor(void* instance)
{
	delete (gce_Root*)instance;
}
