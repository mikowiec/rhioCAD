#ifndef AIS_ListIteratorOfListOfInteractive_H
#define AIS_ListIteratorOfListOfInteractive_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_ListIteratorOfListOfInteractive_Ctor();
extern "C" DECL_EXPORT void* AIS_ListIteratorOfListOfInteractive_Ctor235DE22E(
	void* L);
extern "C" DECL_EXPORT void AIS_ListIteratorOfListOfInteractive_Initialize235DE22E(
	void* instance,
	void* L);
extern "C" DECL_EXPORT void AIS_ListIteratorOfListOfInteractive_Next(void* instance);
extern "C" DECL_EXPORT bool AIS_ListIteratorOfListOfInteractive_More(void* instance);
extern "C" DECL_EXPORT void* AIS_ListIteratorOfListOfInteractive_Value(void* instance);
extern "C" DECL_EXPORT void AISListIteratorOfListOfInteractive_Dtor(void* instance);

#endif
