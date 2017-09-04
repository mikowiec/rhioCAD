#include "BRepFilletAPILocalOperation.h"
#include <BRepFilletAPI_LocalOperation.hxx>


DECL_EXPORT void BRepFilletAPILocalOperation_Dtor(void* instance)
{
	delete (BRepFilletAPI_LocalOperation*)instance;
}
