// File generated by CPPExt (CPP file)
//

#include "PrsMgr_Presentation.h"
#include "../Converter.h"
#include "PrsMgr_PresentationManager.h"


using namespace OCNaroWrappers;

OCPrsMgr_Presentation::OCPrsMgr_Presentation(Handle(PrsMgr_Presentation)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_PrsMgr_Presentation(*nativeHandle);
}

OCPrsMgr_PresentationManager^ OCPrsMgr_Presentation::PresentationManager()
{
  Handle(PrsMgr_PresentationManager) tmp = (*((Handle_PrsMgr_Presentation*)nativeHandle))->PresentationManager();
  return gcnew OCPrsMgr_PresentationManager(&tmp);
}

 void OCPrsMgr_Presentation::SetUpdateStatus(System::Boolean aStat)
{
  (*((Handle_PrsMgr_Presentation*)nativeHandle))->SetUpdateStatus(OCConverter::BooleanToStandardBoolean(aStat));
}

 System::Boolean OCPrsMgr_Presentation::MustBeUpdated()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_PrsMgr_Presentation*)nativeHandle))->MustBeUpdated());
}


