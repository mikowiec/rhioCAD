// File generated by CPPExt (CPP file)
//

#include "OSD_Thread.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCOSD_Thread::OCOSD_Thread(OSD_Thread* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCOSD_Thread::OCOSD_Thread() 
{
  nativeHandle = new OSD_Thread();
}

OCOSD_Thread::OCOSD_Thread(OSD_ThreadFunction func) 
{
  nativeHandle = new OSD_Thread(func);
}

OCOSD_Thread::OCOSD_Thread(OCNaroWrappers::OCOSD_Thread^ other) 
{
  nativeHandle = new OSD_Thread(*((OSD_Thread*)other->Handle));
}

 void OCOSD_Thread::Assign(OCNaroWrappers::OCOSD_Thread^ other)
{
  ((OSD_Thread*)nativeHandle)->Assign(*((OSD_Thread*)other->Handle));
}

 void OCOSD_Thread::SetPriority(Standard_Integer thePriority)
{
  ((OSD_Thread*)nativeHandle)->SetPriority(thePriority);
}

 void OCOSD_Thread::SetFunction(OSD_ThreadFunction func)
{
  ((OSD_Thread*)nativeHandle)->SetFunction(func);
}

 System::Boolean OCOSD_Thread::Run(Standard_Address data, Standard_Integer WNTStackSize)
{
  return OCConverter::StandardBooleanToBoolean(((OSD_Thread*)nativeHandle)->Run(data, WNTStackSize));
}

 void OCOSD_Thread::Detach()
{
  ((OSD_Thread*)nativeHandle)->Detach();
}

 System::Boolean OCOSD_Thread::Wait()
{
  return OCConverter::StandardBooleanToBoolean(((OSD_Thread*)nativeHandle)->Wait());
}

 System::Boolean OCOSD_Thread::Wait(Standard_Address& result)
{
  return OCConverter::StandardBooleanToBoolean(((OSD_Thread*)nativeHandle)->Wait(result));
}

 System::Boolean OCOSD_Thread::Wait(Standard_Integer time, Standard_Address& result)
{
  return OCConverter::StandardBooleanToBoolean(((OSD_Thread*)nativeHandle)->Wait(time, result));
}

 Standard_ThreadId OCOSD_Thread::GetId()
{
  return ((OSD_Thread*)nativeHandle)->GetId();
}

 Standard_ThreadId OCOSD_Thread::Current()
{
  return OSD_Thread::Current();
}


