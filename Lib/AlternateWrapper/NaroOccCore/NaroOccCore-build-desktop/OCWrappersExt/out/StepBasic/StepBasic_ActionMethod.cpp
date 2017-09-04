// File generated by CPPExt (CPP file)
//

#include "StepBasic_ActionMethod.h"
#include "../Converter.h"
#include "../TCollection/TCollection_HAsciiString.h"


using namespace OCNaroWrappers;

OCStepBasic_ActionMethod::OCStepBasic_ActionMethod(Handle(StepBasic_ActionMethod)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepBasic_ActionMethod(*nativeHandle);
}

OCStepBasic_ActionMethod::OCStepBasic_ActionMethod() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepBasic_ActionMethod(new StepBasic_ActionMethod());
}

 void OCStepBasic_ActionMethod::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, System::Boolean hasDescription, OCNaroWrappers::OCTCollection_HAsciiString^ aDescription, OCNaroWrappers::OCTCollection_HAsciiString^ aConsequence, OCNaroWrappers::OCTCollection_HAsciiString^ aPurpose)
{
  (*((Handle_StepBasic_ActionMethod*)nativeHandle))->Init(*((Handle_TCollection_HAsciiString*)aName->Handle), OCConverter::BooleanToStandardBoolean(hasDescription), *((Handle_TCollection_HAsciiString*)aDescription->Handle), *((Handle_TCollection_HAsciiString*)aConsequence->Handle), *((Handle_TCollection_HAsciiString*)aPurpose->Handle));
}

OCTCollection_HAsciiString^ OCStepBasic_ActionMethod::Name()
{
  Handle(TCollection_HAsciiString) tmp = (*((Handle_StepBasic_ActionMethod*)nativeHandle))->Name();
  return gcnew OCTCollection_HAsciiString(&tmp);
}

 void OCStepBasic_ActionMethod::SetName(OCNaroWrappers::OCTCollection_HAsciiString^ Name)
{
  (*((Handle_StepBasic_ActionMethod*)nativeHandle))->SetName(*((Handle_TCollection_HAsciiString*)Name->Handle));
}

OCTCollection_HAsciiString^ OCStepBasic_ActionMethod::Description()
{
  Handle(TCollection_HAsciiString) tmp = (*((Handle_StepBasic_ActionMethod*)nativeHandle))->Description();
  return gcnew OCTCollection_HAsciiString(&tmp);
}

 void OCStepBasic_ActionMethod::SetDescription(OCNaroWrappers::OCTCollection_HAsciiString^ Description)
{
  (*((Handle_StepBasic_ActionMethod*)nativeHandle))->SetDescription(*((Handle_TCollection_HAsciiString*)Description->Handle));
}

 System::Boolean OCStepBasic_ActionMethod::HasDescription()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_StepBasic_ActionMethod*)nativeHandle))->HasDescription());
}

OCTCollection_HAsciiString^ OCStepBasic_ActionMethod::Consequence()
{
  Handle(TCollection_HAsciiString) tmp = (*((Handle_StepBasic_ActionMethod*)nativeHandle))->Consequence();
  return gcnew OCTCollection_HAsciiString(&tmp);
}

 void OCStepBasic_ActionMethod::SetConsequence(OCNaroWrappers::OCTCollection_HAsciiString^ Consequence)
{
  (*((Handle_StepBasic_ActionMethod*)nativeHandle))->SetConsequence(*((Handle_TCollection_HAsciiString*)Consequence->Handle));
}

OCTCollection_HAsciiString^ OCStepBasic_ActionMethod::Purpose()
{
  Handle(TCollection_HAsciiString) tmp = (*((Handle_StepBasic_ActionMethod*)nativeHandle))->Purpose();
  return gcnew OCTCollection_HAsciiString(&tmp);
}

 void OCStepBasic_ActionMethod::SetPurpose(OCNaroWrappers::OCTCollection_HAsciiString^ Purpose)
{
  (*((Handle_StepBasic_ActionMethod*)nativeHandle))->SetPurpose(*((Handle_TCollection_HAsciiString*)Purpose->Handle));
}


