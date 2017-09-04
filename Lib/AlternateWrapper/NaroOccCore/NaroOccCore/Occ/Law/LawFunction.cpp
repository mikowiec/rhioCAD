#include "LawFunction.h"
#include <Law_Function.hxx>


DECL_EXPORT void LawFunction_Dtor(void* instance)
{
	delete (Handle_Law_Function*)instance;
}
