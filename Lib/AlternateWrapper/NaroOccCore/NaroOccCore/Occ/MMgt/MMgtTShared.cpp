#include "MMgtTShared.h"
#include <MMgt_TShared.hxx>


DECL_EXPORT void MMgt_TShared_Delete(void* instance)
{
	MMgt_TShared* result = (MMgt_TShared*)(((Handle_MMgt_TShared*)instance)->Access());
 	result->Delete();
}
DECL_EXPORT void MMgtTShared_Dtor(void* instance)
{
	delete (Handle_MMgt_TShared*)instance;
}
