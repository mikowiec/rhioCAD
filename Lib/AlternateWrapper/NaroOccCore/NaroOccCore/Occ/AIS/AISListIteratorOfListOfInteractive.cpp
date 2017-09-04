#include "AISListIteratorOfListOfInteractive.h"
#include <AIS_ListIteratorOfListOfInteractive.hxx>

#include <AIS_InteractiveObject.hxx>

DECL_EXPORT void* AIS_ListIteratorOfListOfInteractive_Ctor()
{
	return new AIS_ListIteratorOfListOfInteractive();
}
DECL_EXPORT void* AIS_ListIteratorOfListOfInteractive_Ctor235DE22E(
	void* L)
{
		const AIS_ListOfInteractive &  _L =*(const AIS_ListOfInteractive *)L;
	return new AIS_ListIteratorOfListOfInteractive(			
_L);
}
DECL_EXPORT void AIS_ListIteratorOfListOfInteractive_Initialize235DE22E(
	void* instance,
	void* L)
{
		const AIS_ListOfInteractive &  _L =*(const AIS_ListOfInteractive *)L;
	AIS_ListIteratorOfListOfInteractive* result = (AIS_ListIteratorOfListOfInteractive*)instance;
 	result->Initialize(			
_L);
}
DECL_EXPORT void AIS_ListIteratorOfListOfInteractive_Next(void* instance)
{
	AIS_ListIteratorOfListOfInteractive* result = (AIS_ListIteratorOfListOfInteractive*)instance;
 	result->Next();
}
DECL_EXPORT bool AIS_ListIteratorOfListOfInteractive_More(void* instance)
{
	AIS_ListIteratorOfListOfInteractive* result = (AIS_ListIteratorOfListOfInteractive*)instance;
	return 	result->More();
}

DECL_EXPORT void* AIS_ListIteratorOfListOfInteractive_Value(void* instance)
{
	AIS_ListIteratorOfListOfInteractive* result = (AIS_ListIteratorOfListOfInteractive*)instance;
	return 	new Handle_AIS_InteractiveObject(	result->Value());
}

DECL_EXPORT void AISListIteratorOfListOfInteractive_Dtor(void* instance)
{
	delete (AIS_ListIteratorOfListOfInteractive*)instance;
}
