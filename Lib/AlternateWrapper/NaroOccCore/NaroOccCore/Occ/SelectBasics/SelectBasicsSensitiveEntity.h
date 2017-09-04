#ifndef SelectBasics_SensitiveEntity_H
#define SelectBasics_SensitiveEntity_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void SelectBasics_SensitiveEntity_SetB2ADB135(
	void* instance,
	void* TheOwnerId);
extern "C" DECL_EXPORT void* SelectBasics_SensitiveEntity_OwnerId(void* instance);
extern "C" DECL_EXPORT double SelectBasics_SensitiveEntity_Depth(void* instance);
extern "C" DECL_EXPORT void SelectBasics_SensitiveEntity_SetSensitivityFactor(void* instance, double value);
extern "C" DECL_EXPORT double SelectBasics_SensitiveEntity_SensitivityFactor(void* instance);
extern "C" DECL_EXPORT void SelectBasicsSensitiveEntity_Dtor(void* instance);

#endif
