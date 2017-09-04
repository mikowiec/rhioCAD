#include "CDMMessageDriver.h"
#include <CDM_MessageDriver.hxx>


DECL_EXPORT void CDMMessageDriver_Dtor(void* instance)
{
	delete (Handle_CDM_MessageDriver*)instance;
}
