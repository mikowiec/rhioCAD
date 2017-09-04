// File generated by CPPExt (MPV)
//
#ifndef _StepGeom_SurfaceOfRevolution_OCWrappers_HeaderFile
#define _StepGeom_SurfaceOfRevolution_OCWrappers_HeaderFile

// include native header
#include <StepGeom_SurfaceOfRevolution.hxx>
#include "../Converter.h"

#include "StepGeom_SweptSurface.h"

#include "StepGeom_Axis1Placement.h"
#include "StepGeom_SweptSurface.h"


namespace OCNaroWrappers
{

ref class OCTCollection_HAsciiString;
ref class OCStepGeom_Curve;
ref class OCStepGeom_Axis1Placement;



public ref class OCStepGeom_SurfaceOfRevolution  : public OCStepGeom_SweptSurface {

protected:
  // dummy constructor;
  OCStepGeom_SurfaceOfRevolution(OCDummy^) : OCStepGeom_SweptSurface((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepGeom_SurfaceOfRevolution(StepGeom_SurfaceOfRevolution* nativeHandle);

// Methods PUBLIC

//! Returns a SurfaceOfRevolution <br>
OCStepGeom_SurfaceOfRevolution();


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Curve^ aSweptCurve) override;


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Curve^ aSweptCurve, OCNaroWrappers::OCStepGeom_Axis1Placement^ aAxisPosition) ;


 /*instead*/  void SetAxisPosition(OCNaroWrappers::OCStepGeom_Axis1Placement^ aAxisPosition) ;


 /*instead*/  OCStepGeom_Axis1Placement^ AxisPosition() ;

~OCStepGeom_SurfaceOfRevolution()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
