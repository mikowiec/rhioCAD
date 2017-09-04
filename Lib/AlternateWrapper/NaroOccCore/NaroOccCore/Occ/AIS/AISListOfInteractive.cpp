#include "AISListOfInteractive.h"
#include <AIS_ListOfInteractive.hxx>

#include <AIS_InteractiveObject.hxx>

DECL_EXPORT void* AIS_ListOfInteractive_Ctor()
{
	return new AIS_ListOfInteractive();
}
DECL_EXPORT void AIS_ListOfInteractive_Assign235DE22E(
	void* instance,
	void* Other)
{
		const AIS_ListOfInteractive &  _Other =*(const AIS_ListOfInteractive *)Other;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Assign(			
_Other);
}
DECL_EXPORT void AIS_ListOfInteractive_Prepend5DD8A2CA(
	void* instance,
	void* I)
{
		const Handle_AIS_InteractiveObject&  _I =*(const Handle_AIS_InteractiveObject *)I;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Prepend(			
_I);
}
DECL_EXPORT void AIS_ListOfInteractive_Prepend3A5B8247(
	void* instance,
	void* I,
	void* theIt)
{
		const Handle_AIS_InteractiveObject&  _I =*(const Handle_AIS_InteractiveObject *)I;
		AIS_ListIteratorOfListOfInteractive &  _theIt =*(AIS_ListIteratorOfListOfInteractive *)theIt;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Prepend(			
_I,			
_theIt);
}
DECL_EXPORT void AIS_ListOfInteractive_Prepend235DE22E(
	void* instance,
	void* Other)
{
		AIS_ListOfInteractive &  _Other =*(AIS_ListOfInteractive *)Other;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Prepend(			
_Other);
}
DECL_EXPORT void AIS_ListOfInteractive_Append5DD8A2CA(
	void* instance,
	void* I)
{
		const Handle_AIS_InteractiveObject&  _I =*(const Handle_AIS_InteractiveObject *)I;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Append(			
_I);
}
DECL_EXPORT void AIS_ListOfInteractive_Append3A5B8247(
	void* instance,
	void* I,
	void* theIt)
{
		const Handle_AIS_InteractiveObject&  _I =*(const Handle_AIS_InteractiveObject *)I;
		AIS_ListIteratorOfListOfInteractive &  _theIt =*(AIS_ListIteratorOfListOfInteractive *)theIt;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Append(			
_I,			
_theIt);
}
DECL_EXPORT void AIS_ListOfInteractive_Append235DE22E(
	void* instance,
	void* Other)
{
		AIS_ListOfInteractive &  _Other =*(AIS_ListOfInteractive *)Other;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Append(			
_Other);
}
DECL_EXPORT void AIS_ListOfInteractive_RemoveFirst(void* instance)
{
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->RemoveFirst();
}
DECL_EXPORT void AIS_ListOfInteractive_RemoveC3A8FDC6(
	void* instance,
	void* It)
{
		AIS_ListIteratorOfListOfInteractive &  _It =*(AIS_ListIteratorOfListOfInteractive *)It;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->Remove(			
_It);
}
DECL_EXPORT void AIS_ListOfInteractive_InsertBefore3A5B8247(
	void* instance,
	void* I,
	void* It)
{
		const Handle_AIS_InteractiveObject&  _I =*(const Handle_AIS_InteractiveObject *)I;
		AIS_ListIteratorOfListOfInteractive &  _It =*(AIS_ListIteratorOfListOfInteractive *)It;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->InsertBefore(			
_I,			
_It);
}
DECL_EXPORT void AIS_ListOfInteractive_InsertBeforeED3785BE(
	void* instance,
	void* Other,
	void* It)
{
		AIS_ListOfInteractive &  _Other =*(AIS_ListOfInteractive *)Other;
		AIS_ListIteratorOfListOfInteractive &  _It =*(AIS_ListIteratorOfListOfInteractive *)It;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->InsertBefore(			
_Other,			
_It);
}
DECL_EXPORT void AIS_ListOfInteractive_InsertAfter3A5B8247(
	void* instance,
	void* I,
	void* It)
{
		const Handle_AIS_InteractiveObject&  _I =*(const Handle_AIS_InteractiveObject *)I;
		AIS_ListIteratorOfListOfInteractive &  _It =*(AIS_ListIteratorOfListOfInteractive *)It;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->InsertAfter(			
_I,			
_It);
}
DECL_EXPORT void AIS_ListOfInteractive_InsertAfterED3785BE(
	void* instance,
	void* Other,
	void* It)
{
		AIS_ListOfInteractive &  _Other =*(AIS_ListOfInteractive *)Other;
		AIS_ListIteratorOfListOfInteractive &  _It =*(AIS_ListIteratorOfListOfInteractive *)It;
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
 	result->InsertAfter(			
_Other,			
_It);
}
DECL_EXPORT int AIS_ListOfInteractive_Extent(void* instance)
{
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
	return 	result->Extent();
}

DECL_EXPORT bool AIS_ListOfInteractive_IsEmpty(void* instance)
{
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT void* AIS_ListOfInteractive_First(void* instance)
{
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
	return 	new Handle_AIS_InteractiveObject(	result->First());
}

DECL_EXPORT void* AIS_ListOfInteractive_Last(void* instance)
{
	AIS_ListOfInteractive* result = (AIS_ListOfInteractive*)instance;
	return 	new Handle_AIS_InteractiveObject(	result->Last());
}

DECL_EXPORT void AISListOfInteractive_Dtor(void* instance)
{
	delete (AIS_ListOfInteractive*)instance;
}
