// File generated by CPPExt (CPP file)
//

#include "StepVisual_AnnotationTextOccurrence.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepVisual_AnnotationTextOccurrence::OCStepVisual_AnnotationTextOccurrence(Handle(StepVisual_AnnotationTextOccurrence)* nativeHandle) : OCStepVisual_AnnotationOccurrence((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepVisual_AnnotationTextOccurrence(*nativeHandle);
}

OCStepVisual_AnnotationTextOccurrence::OCStepVisual_AnnotationTextOccurrence() : OCStepVisual_AnnotationOccurrence((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepVisual_AnnotationTextOccurrence(new StepVisual_AnnotationTextOccurrence());
}


