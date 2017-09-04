#include "MDFASDriver.h"
#include <MDF_ASDriver.hxx>


DECL_EXPORT void MDF_ASDriver_WriteMessage6EE6EE89(
	void* instance,
	void* theMessage)
{
		const TCollection_ExtendedString &  _theMessage =*(const TCollection_ExtendedString *)theMessage;
	MDF_ASDriver* result = (MDF_ASDriver*)(((Handle_MDF_ASDriver*)instance)->Access());
 	result->WriteMessage(			
_theMessage);
}
DECL_EXPORT void MDFASDriver_Dtor(void* instance)
{
	delete (Handle_MDF_ASDriver*)instance;
}
