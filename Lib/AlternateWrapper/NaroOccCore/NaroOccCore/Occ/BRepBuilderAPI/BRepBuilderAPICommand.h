#ifndef BRepBuilderAPI_Command_H
#define BRepBuilderAPI_Command_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void BRepBuilderAPI_Command_Delete(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_Command_Check(void* instance);
extern "C" DECL_EXPORT bool BRepBuilderAPI_Command_IsDone(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPICommand_Dtor(void* instance);

#endif
