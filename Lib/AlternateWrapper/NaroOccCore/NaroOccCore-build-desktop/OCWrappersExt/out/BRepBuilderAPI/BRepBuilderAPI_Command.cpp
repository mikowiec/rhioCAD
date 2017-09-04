// File generated by CPPExt (CPP file)
//

#include "BRepBuilderAPI_Command.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCBRepBuilderAPI_Command::OCBRepBuilderAPI_Command(BRepBuilderAPI_Command* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 void OCBRepBuilderAPI_Command::Delete()
{
  ((BRepBuilderAPI_Command*)nativeHandle)->Delete();
}

OCBRepBuilderAPI_Command::OCBRepBuilderAPI_Command() 
{}

 System::Boolean OCBRepBuilderAPI_Command::IsDone()
{
  return OCConverter::StandardBooleanToBoolean(((BRepBuilderAPI_Command*)nativeHandle)->IsDone());
}

 void OCBRepBuilderAPI_Command::Check()
{
  ((BRepBuilderAPI_Command*)nativeHandle)->Check();
}


