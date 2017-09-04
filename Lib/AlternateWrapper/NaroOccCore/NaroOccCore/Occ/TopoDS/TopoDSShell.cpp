#include "TopoDSShell.h"
#include <TopoDS_Shell.hxx>


DECL_EXPORT void* TopoDS_Shell_Ctor()
{
	return new TopoDS_Shell();
}
DECL_EXPORT void TopoDSShell_Dtor(void* instance)
{
	delete (TopoDS_Shell*)instance;
}
