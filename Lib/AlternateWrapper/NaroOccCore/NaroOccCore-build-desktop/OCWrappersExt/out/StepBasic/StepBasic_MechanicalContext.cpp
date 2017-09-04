// File generated by CPPExt (CPP file)
//

#include "StepBasic_MechanicalContext.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepBasic_MechanicalContext::OCStepBasic_MechanicalContext(Handle(StepBasic_MechanicalContext)* nativeHandle) : OCStepBasic_ProductContext((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepBasic_MechanicalContext(*nativeHandle);
}

OCStepBasic_MechanicalContext::OCStepBasic_MechanicalContext() : OCStepBasic_ProductContext((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepBasic_MechanicalContext(new StepBasic_MechanicalContext());
}


