// File generated by CPPExt (Transient)
//
#ifndef _StepBasic_LengthMeasureWithUnit_OCWrappers_HeaderFile
#define _StepBasic_LengthMeasureWithUnit_OCWrappers_HeaderFile

// include the wrapped class
#include <StepBasic_LengthMeasureWithUnit.hxx>
#include "../Converter.h"

#include "StepBasic_MeasureWithUnit.h"



namespace OCNaroWrappers
{




public ref class OCStepBasic_LengthMeasureWithUnit : OCStepBasic_MeasureWithUnit {

protected:
  // dummy constructor;
  OCStepBasic_LengthMeasureWithUnit(OCDummy^) : OCStepBasic_MeasureWithUnit((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepBasic_LengthMeasureWithUnit(Handle(StepBasic_LengthMeasureWithUnit)* nativeHandle);

// Methods PUBLIC

//! Returns a LengthMeasureWithUnit <br>
OCStepBasic_LengthMeasureWithUnit();

~OCStepBasic_LengthMeasureWithUnit()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
