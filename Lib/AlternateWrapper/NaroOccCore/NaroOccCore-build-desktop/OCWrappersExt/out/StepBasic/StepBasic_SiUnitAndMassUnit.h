// File generated by CPPExt (Transient)
//
#ifndef _StepBasic_SiUnitAndMassUnit_OCWrappers_HeaderFile
#define _StepBasic_SiUnitAndMassUnit_OCWrappers_HeaderFile

// include the wrapped class
#include <StepBasic_SiUnitAndMassUnit.hxx>
#include "../Converter.h"

#include "StepBasic_SiUnit.h"

#include "StepBasic_SiPrefix.h"
#include "StepBasic_SiUnitName.h"


namespace OCNaroWrappers
{

ref class OCStepBasic_MassUnit;
ref class OCStepBasic_DimensionalExponents;



public ref class OCStepBasic_SiUnitAndMassUnit : OCStepBasic_SiUnit {

protected:
  // dummy constructor;
  OCStepBasic_SiUnitAndMassUnit(OCDummy^) : OCStepBasic_SiUnit((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepBasic_SiUnitAndMassUnit(Handle(StepBasic_SiUnitAndMassUnit)* nativeHandle);

// Methods PUBLIC

//! Returns a SiUnitAndMassUnit <br>
OCStepBasic_SiUnitAndMassUnit();


virtual /*instead*/  void Init(OCNaroWrappers::OCStepBasic_DimensionalExponents^ aDimensions) override;


virtual /*instead*/  void Init(System::Boolean hasAprefix, OCStepBasic_SiPrefix aPrefix, OCStepBasic_SiUnitName aName) override;


 /*instead*/  void SetMassUnit(OCNaroWrappers::OCStepBasic_MassUnit^ aMassUnit) ;


 /*instead*/  OCStepBasic_MassUnit^ MassUnit() ;

~OCStepBasic_SiUnitAndMassUnit()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif