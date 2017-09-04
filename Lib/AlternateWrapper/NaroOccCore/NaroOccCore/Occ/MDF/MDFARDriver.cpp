#include "MDFARDriver.h"
#include <MDF_ARDriver.hxx>


DECL_EXPORT void MDF_ARDriver_WriteMessage6EE6EE89(
	void* instance,
	void* theMessage)
{
		const TCollection_ExtendedString &  _theMessage =*(const TCollection_ExtendedString *)theMessage;
	MDF_ARDriver* result = (MDF_ARDriver*)(((Handle_MDF_ARDriver*)instance)->Access());
 	result->WriteMessage(			
_theMessage);
}
DECL_EXPORT void MDFARDriver_Dtor(void* instance)
{
	delete (Handle_MDF_ARDriver*)instance;
}
