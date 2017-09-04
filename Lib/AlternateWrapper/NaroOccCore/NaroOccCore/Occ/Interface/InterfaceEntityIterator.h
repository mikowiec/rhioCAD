#ifndef Interface_EntityIterator_H
#define Interface_EntityIterator_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Interface_EntityIterator_Ctor();
extern "C" DECL_EXPORT void Interface_EntityIterator_AddItemF411CB01(
	void* instance,
	void* anentity);
extern "C" DECL_EXPORT void Interface_EntityIterator_GetOneItemF411CB01(
	void* instance,
	void* anentity);
extern "C" DECL_EXPORT void Interface_EntityIterator_SelectTypeC4B77EEF(
	void* instance,
	void* atype,
	bool keep);
extern "C" DECL_EXPORT int Interface_EntityIterator_NbTypedE2B3EAC1(
	void* instance,
	void* type);
extern "C" DECL_EXPORT void* Interface_EntityIterator_TypedE2B3EAC1(
	void* instance,
	void* type);
extern "C" DECL_EXPORT void Interface_EntityIterator_Start(void* instance);
extern "C" DECL_EXPORT void Interface_EntityIterator_Next(void* instance);
extern "C" DECL_EXPORT void Interface_EntityIterator_Destroy(void* instance);
extern "C" DECL_EXPORT int Interface_EntityIterator_NbEntities(void* instance);
extern "C" DECL_EXPORT bool Interface_EntityIterator_More(void* instance);
extern "C" DECL_EXPORT void* Interface_EntityIterator_Value(void* instance);
extern "C" DECL_EXPORT void InterfaceEntityIterator_Dtor(void* instance);

#endif
