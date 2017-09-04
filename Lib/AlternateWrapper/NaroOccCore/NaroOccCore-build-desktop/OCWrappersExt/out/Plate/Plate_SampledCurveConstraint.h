// File generated by CPPExt (MPV)
//
#ifndef _Plate_SampledCurveConstraint_OCWrappers_HeaderFile
#define _Plate_SampledCurveConstraint_OCWrappers_HeaderFile

// include native header
#include <Plate_SampledCurveConstraint.hxx>
#include "../Converter.h"


#include "Plate_LinearXYZConstraint.h"


namespace OCNaroWrappers
{

ref class OCPlate_SequenceOfPinpointConstraint;
ref class OCPlate_LinearXYZConstraint;


//! define m PinPointConstraint driven by m unknown <br>
//! <br>
//! <br>
//! <br>
//! <br>
public ref class OCPlate_SampledCurveConstraint  {

protected:
  Plate_SampledCurveConstraint* nativeHandle;
  OCPlate_SampledCurveConstraint(OCDummy^) {};

public:
  property Plate_SampledCurveConstraint* Handle
  {
    Plate_SampledCurveConstraint* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCPlate_SampledCurveConstraint(Plate_SampledCurveConstraint* nativeHandle);

// Methods PUBLIC


OCPlate_SampledCurveConstraint(OCNaroWrappers::OCPlate_SequenceOfPinpointConstraint^ SOPPC, Standard_Integer n);


 /*instead*/  OCPlate_LinearXYZConstraint^ LXYZC() ;

~OCPlate_SampledCurveConstraint()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
