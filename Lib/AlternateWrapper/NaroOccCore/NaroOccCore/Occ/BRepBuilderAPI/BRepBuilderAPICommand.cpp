#include "BRepBuilderAPICommand.h"
#include <BRepBuilderAPI_Command.hxx>


DECL_EXPORT void BRepBuilderAPI_Command_Delete(void* instance)
{
	BRepBuilderAPI_Command* result = (BRepBuilderAPI_Command*)instance;
 	result->Delete();
}
DECL_EXPORT void BRepBuilderAPI_Command_Check(void* instance)
{
	BRepBuilderAPI_Command* result = (BRepBuilderAPI_Command*)instance;
 	result->Check();
}
DECL_EXPORT bool BRepBuilderAPI_Command_IsDone(void* instance)
{
	BRepBuilderAPI_Command* result = (BRepBuilderAPI_Command*)instance;
	return 	result->IsDone();
}

DECL_EXPORT void BRepBuilderAPICommand_Dtor(void* instance)
{
	delete (BRepBuilderAPI_Command*)instance;
}
