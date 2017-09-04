// File generated by CPPExt (CPP file)
//

#include "TPrsStd_PlaneDriver.h"
#include "../Converter.h"
#include "../TDF/TDF_Label.h"
#include "../AIS/AIS_InteractiveObject.h"


using namespace OCNaroWrappers;

OCTPrsStd_PlaneDriver::OCTPrsStd_PlaneDriver(Handle(TPrsStd_PlaneDriver)* nativeHandle) : OCTPrsStd_Driver((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TPrsStd_PlaneDriver(*nativeHandle);
}

OCTPrsStd_PlaneDriver::OCTPrsStd_PlaneDriver() : OCTPrsStd_Driver((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TPrsStd_PlaneDriver(new TPrsStd_PlaneDriver());
}

 System::Boolean OCTPrsStd_PlaneDriver::Update(OCNaroWrappers::OCTDF_Label^ aLabel, OCNaroWrappers::OCAIS_InteractiveObject^ anAISObject)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TPrsStd_PlaneDriver*)nativeHandle))->Update(*((TDF_Label*)aLabel->Handle), *((Handle_AIS_InteractiveObject*)anAISObject->Handle)));
}


