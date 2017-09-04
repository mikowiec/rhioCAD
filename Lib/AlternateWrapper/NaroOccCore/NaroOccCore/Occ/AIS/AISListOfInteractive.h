#ifndef AIS_ListOfInteractive_H
#define AIS_ListOfInteractive_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* AIS_ListOfInteractive_Ctor();
extern "C" DECL_EXPORT void AIS_ListOfInteractive_Assign235DE22E(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_Prepend5DD8A2CA(
	void* instance,
	void* I);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_Prepend3A5B8247(
	void* instance,
	void* I,
	void* theIt);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_Prepend235DE22E(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_Append5DD8A2CA(
	void* instance,
	void* I);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_Append3A5B8247(
	void* instance,
	void* I,
	void* theIt);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_Append235DE22E(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_RemoveFirst(void* instance);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_RemoveC3A8FDC6(
	void* instance,
	void* It);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_InsertBefore3A5B8247(
	void* instance,
	void* I,
	void* It);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_InsertBeforeED3785BE(
	void* instance,
	void* Other,
	void* It);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_InsertAfter3A5B8247(
	void* instance,
	void* I,
	void* It);
extern "C" DECL_EXPORT void AIS_ListOfInteractive_InsertAfterED3785BE(
	void* instance,
	void* Other,
	void* It);
extern "C" DECL_EXPORT int AIS_ListOfInteractive_Extent(void* instance);
extern "C" DECL_EXPORT bool AIS_ListOfInteractive_IsEmpty(void* instance);
extern "C" DECL_EXPORT void* AIS_ListOfInteractive_First(void* instance);
extern "C" DECL_EXPORT void* AIS_ListOfInteractive_Last(void* instance);
extern "C" DECL_EXPORT void AISListOfInteractive_Dtor(void* instance);

#endif
