#include "GCRoot.h"
#include <GC_Root.hxx>


DECL_EXPORT bool GC_Root_IsDone(void* instance)
{
	GC_Root* result = (GC_Root*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int GC_Root_Status(void* instance)
{
	GC_Root* result = (GC_Root*)instance;
	return (int)	result->Status();
}

DECL_EXPORT void GCRoot_Dtor(void* instance)
{
	delete (GC_Root*)instance;
}
