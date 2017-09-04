// File generated by CPPExt (CPP file)
//

#include "StepBasic_CertificationType.h"
#include "../Converter.h"
#include "../TCollection/TCollection_HAsciiString.h"


using namespace OCNaroWrappers;

OCStepBasic_CertificationType::OCStepBasic_CertificationType(Handle(StepBasic_CertificationType)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepBasic_CertificationType(*nativeHandle);
}

OCStepBasic_CertificationType::OCStepBasic_CertificationType() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepBasic_CertificationType(new StepBasic_CertificationType());
}

 void OCStepBasic_CertificationType::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aDescription)
{
  (*((Handle_StepBasic_CertificationType*)nativeHandle))->Init(*((Handle_TCollection_HAsciiString*)aDescription->Handle));
}

OCTCollection_HAsciiString^ OCStepBasic_CertificationType::Description()
{
  Handle(TCollection_HAsciiString) tmp = (*((Handle_StepBasic_CertificationType*)nativeHandle))->Description();
  return gcnew OCTCollection_HAsciiString(&tmp);
}

 void OCStepBasic_CertificationType::SetDescription(OCNaroWrappers::OCTCollection_HAsciiString^ Description)
{
  (*((Handle_StepBasic_CertificationType*)nativeHandle))->SetDescription(*((Handle_TCollection_HAsciiString*)Description->Handle));
}


