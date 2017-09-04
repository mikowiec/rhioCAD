#include "StepDataEDescr.h"
#include <StepData_EDescr.hxx>


DECL_EXPORT void StepDataEDescr_Dtor(void* instance)
{
	delete (Handle_StepData_EDescr*)instance;
}
