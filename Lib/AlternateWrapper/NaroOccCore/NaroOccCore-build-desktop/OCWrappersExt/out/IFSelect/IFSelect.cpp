// File generated by CPPExt (CPP file)
//

#include "IFSelect.h"
#include "../Converter.h"


using namespace OCNaroWrappers;



 System::Boolean OCIFSelect::SaveSession(OCNaroWrappers::OCIFSelect_WorkSession^ WS, System::String^ file)
{
  return OCConverter::StandardBooleanToBoolean(IFSelect::SaveSession(*((Handle_IFSelect_WorkSession*)WS->Handle), OCConverter::StringToStandardCString(file)));
}

 System::Boolean OCIFSelect::RestoreSession(OCNaroWrappers::OCIFSelect_WorkSession^ WS, System::String^ file)
{
  return OCConverter::StandardBooleanToBoolean(IFSelect::RestoreSession(*((Handle_IFSelect_WorkSession*)WS->Handle), OCConverter::StringToStandardCString(file)));
}


