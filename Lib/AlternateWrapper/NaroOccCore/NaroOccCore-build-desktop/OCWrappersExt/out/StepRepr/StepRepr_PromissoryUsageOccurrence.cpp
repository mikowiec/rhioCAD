// File generated by CPPExt (CPP file)
//

#include "StepRepr_PromissoryUsageOccurrence.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepRepr_PromissoryUsageOccurrence::OCStepRepr_PromissoryUsageOccurrence(Handle(StepRepr_PromissoryUsageOccurrence)* nativeHandle) : OCStepRepr_AssemblyComponentUsage((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepRepr_PromissoryUsageOccurrence(*nativeHandle);
}

OCStepRepr_PromissoryUsageOccurrence::OCStepRepr_PromissoryUsageOccurrence() : OCStepRepr_AssemblyComponentUsage((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepRepr_PromissoryUsageOccurrence(new StepRepr_PromissoryUsageOccurrence());
}


