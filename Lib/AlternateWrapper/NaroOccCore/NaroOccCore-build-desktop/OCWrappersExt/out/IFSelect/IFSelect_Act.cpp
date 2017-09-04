// File generated by CPPExt (CPP file)
//

#include "IFSelect_Act.h"
#include "../Converter.h"
#include "IFSelect_SessionPilot.h"


using namespace OCNaroWrappers;

OCIFSelect_Act::OCIFSelect_Act(Handle(IFSelect_Act)* nativeHandle) : OCIFSelect_Activator((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_IFSelect_Act(*nativeHandle);
}

OCIFSelect_Act::OCIFSelect_Act(System::String^ name, System::String^ help, IFSelect_ActFunc func) : OCIFSelect_Activator((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IFSelect_Act(new IFSelect_Act(OCConverter::StringToStandardCString(name), OCConverter::StringToStandardCString(help), func));
}

 OCIFSelect_ReturnStatus OCIFSelect_Act::Do(Standard_Integer number, OCNaroWrappers::OCIFSelect_SessionPilot^ pilot)
{
  return (OCIFSelect_ReturnStatus)((*((Handle_IFSelect_Act*)nativeHandle))->Do(number, *((Handle_IFSelect_SessionPilot*)pilot->Handle)));
}

 System::String^ OCIFSelect_Act::Help(Standard_Integer number)
{
  return OCConverter::StandardCStringToString((*((Handle_IFSelect_Act*)nativeHandle))->Help(number));
}

 void OCIFSelect_Act::SetGroup(System::String^ group, System::String^ file)
{
  IFSelect_Act::SetGroup(OCConverter::StringToStandardCString(group), OCConverter::StringToStandardCString(file));
}

 void OCIFSelect_Act::AddFunc(System::String^ name, System::String^ help, IFSelect_ActFunc func)
{
  IFSelect_Act::AddFunc(OCConverter::StringToStandardCString(name), OCConverter::StringToStandardCString(help), func);
}

 void OCIFSelect_Act::AddFSet(System::String^ name, System::String^ help, IFSelect_ActFunc func)
{
  IFSelect_Act::AddFSet(OCConverter::StringToStandardCString(name), OCConverter::StringToStandardCString(help), func);
}


