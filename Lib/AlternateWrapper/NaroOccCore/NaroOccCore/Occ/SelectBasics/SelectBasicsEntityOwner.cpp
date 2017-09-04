#include "SelectBasicsEntityOwner.h"
#include <SelectBasics_EntityOwner.hxx>


DECL_EXPORT void SelectBasics_EntityOwner_SetE8219145(
	void* instance,
	int aPriority)
{
	SelectBasics_EntityOwner* result = (SelectBasics_EntityOwner*)(((Handle_SelectBasics_EntityOwner*)instance)->Access());
 	result->Set(			
aPriority);
}
DECL_EXPORT int SelectBasics_EntityOwner_Priority(void* instance)
{
	SelectBasics_EntityOwner* result = (SelectBasics_EntityOwner*)(((Handle_SelectBasics_EntityOwner*)instance)->Access());
	return 	result->Priority();
}

DECL_EXPORT void SelectBasicsEntityOwner_Dtor(void* instance)
{
	delete (Handle_SelectBasics_EntityOwner*)instance;
}
