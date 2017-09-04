#include "Graphic3dDataStructureManager.h"
#include <Graphic3d_DataStructureManager.hxx>


DECL_EXPORT void Graphic3dDataStructureManager_Dtor(void* instance)
{
	delete (Handle_Graphic3d_DataStructureManager*)instance;
}
