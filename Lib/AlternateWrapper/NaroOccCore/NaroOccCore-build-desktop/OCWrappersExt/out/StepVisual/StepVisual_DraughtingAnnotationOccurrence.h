// File generated by CPPExt (Transient)
//
#ifndef _StepVisual_DraughtingAnnotationOccurrence_OCWrappers_HeaderFile
#define _StepVisual_DraughtingAnnotationOccurrence_OCWrappers_HeaderFile

// include the wrapped class
#include <StepVisual_DraughtingAnnotationOccurrence.hxx>
#include "../Converter.h"

#include "StepVisual_AnnotationOccurrence.h"



namespace OCNaroWrappers
{




public ref class OCStepVisual_DraughtingAnnotationOccurrence : OCStepVisual_AnnotationOccurrence {

protected:
  // dummy constructor;
  OCStepVisual_DraughtingAnnotationOccurrence(OCDummy^) : OCStepVisual_AnnotationOccurrence((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepVisual_DraughtingAnnotationOccurrence(Handle(StepVisual_DraughtingAnnotationOccurrence)* nativeHandle);

// Methods PUBLIC

//! Returns a DraughtingAnnotationOccurrence <br>
OCStepVisual_DraughtingAnnotationOccurrence();

~OCStepVisual_DraughtingAnnotationOccurrence()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
