// File generated by CPPExt (Transient)
//
#ifndef _StepBasic_MassMeasureWithUnit_OCWrappers_HeaderFile
#define _StepBasic_MassMeasureWithUnit_OCWrappers_HeaderFile

// include the wrapped class
#include <StepBasic_MassMeasureWithUnit.hxx>
#include "../Converter.h"

#include "StepBasic_MeasureWithUnit.h"



namespace OCNaroWrappers
{




public ref class OCStepBasic_MassMeasureWithUnit : OCStepBasic_MeasureWithUnit {

protected:
  // dummy constructor;
  OCStepBasic_MassMeasureWithUnit(OCDummy^) : OCStepBasic_MeasureWithUnit((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepBasic_MassMeasureWithUnit(Handle(StepBasic_MassMeasureWithUnit)* nativeHandle);

// Methods PUBLIC

//! Returns a MassMeasureWithUnit <br>
OCStepBasic_MassMeasureWithUnit();

~OCStepBasic_MassMeasureWithUnit()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
