// File generated by CPPExt (Transient)
//
#ifndef _StepBasic_ConversionBasedUnitAndSolidAngleUnit_OCWrappers_HeaderFile
#define _StepBasic_ConversionBasedUnitAndSolidAngleUnit_OCWrappers_HeaderFile

// include the wrapped class
#include <StepBasic_ConversionBasedUnitAndSolidAngleUnit.hxx>
#include "../Converter.h"

#include "StepBasic_ConversionBasedUnit.h"



namespace OCNaroWrappers
{

ref class OCStepBasic_SolidAngleUnit;
ref class OCStepBasic_DimensionalExponents;
ref class OCTCollection_HAsciiString;
ref class OCStepBasic_MeasureWithUnit;



public ref class OCStepBasic_ConversionBasedUnitAndSolidAngleUnit : OCStepBasic_ConversionBasedUnit {

protected:
  // dummy constructor;
  OCStepBasic_ConversionBasedUnitAndSolidAngleUnit(OCDummy^) : OCStepBasic_ConversionBasedUnit((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepBasic_ConversionBasedUnitAndSolidAngleUnit(Handle(StepBasic_ConversionBasedUnitAndSolidAngleUnit)* nativeHandle);

// Methods PUBLIC

//! Returns a ConversionBasedUnitAndSolidAngleUnit <br>
OCStepBasic_ConversionBasedUnitAndSolidAngleUnit();


virtual /*instead*/  void Init(OCNaroWrappers::OCStepBasic_DimensionalExponents^ aDimensions) override;


virtual /*instead*/  void Init(OCNaroWrappers::OCStepBasic_DimensionalExponents^ aDimensions, OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepBasic_MeasureWithUnit^ aConversionFactor) override;


 /*instead*/  void SetSolidAngleUnit(OCNaroWrappers::OCStepBasic_SolidAngleUnit^ aSolidAngleUnit) ;


 /*instead*/  OCStepBasic_SolidAngleUnit^ SolidAngleUnit() ;

~OCStepBasic_ConversionBasedUnitAndSolidAngleUnit()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
