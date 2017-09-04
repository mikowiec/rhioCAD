#include "SelectBasicsSensitiveEntity.h"
#include <SelectBasics_SensitiveEntity.hxx>

#include <SelectBasics_EntityOwner.hxx>

DECL_EXPORT void SelectBasics_SensitiveEntity_SetB2ADB135(
	void* instance,
	void* TheOwnerId)
{
		const Handle_SelectBasics_EntityOwner&  _TheOwnerId =*(const Handle_SelectBasics_EntityOwner *)TheOwnerId;
	SelectBasics_SensitiveEntity* result = (SelectBasics_SensitiveEntity*)(((Handle_SelectBasics_SensitiveEntity*)instance)->Access());
 	result->Set(			
_TheOwnerId);
}
DECL_EXPORT void* SelectBasics_SensitiveEntity_OwnerId(void* instance)
{
	SelectBasics_SensitiveEntity* result = (SelectBasics_SensitiveEntity*)(((Handle_SelectBasics_SensitiveEntity*)instance)->Access());
	return 	new Handle_SelectBasics_EntityOwner(	result->OwnerId());
}

DECL_EXPORT double SelectBasics_SensitiveEntity_Depth(void* instance)
{
	SelectBasics_SensitiveEntity* result = (SelectBasics_SensitiveEntity*)(((Handle_SelectBasics_SensitiveEntity*)instance)->Access());
	return 	result->Depth();
}

DECL_EXPORT void SelectBasics_SensitiveEntity_SetSensitivityFactor(void* instance, double value)
{
	SelectBasics_SensitiveEntity* result = (SelectBasics_SensitiveEntity*)(((Handle_SelectBasics_SensitiveEntity*)instance)->Access());
		result->SetSensitivityFactor(value);
}

DECL_EXPORT double SelectBasics_SensitiveEntity_SensitivityFactor(void* instance)
{
	SelectBasics_SensitiveEntity* result = (SelectBasics_SensitiveEntity*)(((Handle_SelectBasics_SensitiveEntity*)instance)->Access());
	return 	result->SensitivityFactor();
}

DECL_EXPORT void SelectBasicsSensitiveEntity_Dtor(void* instance)
{
	delete (Handle_SelectBasics_SensitiveEntity*)instance;
}
