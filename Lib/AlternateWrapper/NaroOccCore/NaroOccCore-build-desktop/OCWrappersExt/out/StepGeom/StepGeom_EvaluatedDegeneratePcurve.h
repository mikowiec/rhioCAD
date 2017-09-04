// File generated by CPPExt (MPV)
//
#ifndef _StepGeom_EvaluatedDegeneratePcurve_OCWrappers_HeaderFile
#define _StepGeom_EvaluatedDegeneratePcurve_OCWrappers_HeaderFile

// include native header
#include <StepGeom_EvaluatedDegeneratePcurve.hxx>
#include "../Converter.h"

#include "StepGeom_DegeneratePcurve.h"

#include "StepGeom_CartesianPoint.h"
#include "StepGeom_DegeneratePcurve.h"


namespace OCNaroWrappers
{

ref class OCTCollection_HAsciiString;
ref class OCStepGeom_Surface;
ref class OCStepRepr_DefinitionalRepresentation;
ref class OCStepGeom_CartesianPoint;



public ref class OCStepGeom_EvaluatedDegeneratePcurve  : public OCStepGeom_DegeneratePcurve {

protected:
  // dummy constructor;
  OCStepGeom_EvaluatedDegeneratePcurve(OCDummy^) : OCStepGeom_DegeneratePcurve((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepGeom_EvaluatedDegeneratePcurve(StepGeom_EvaluatedDegeneratePcurve* nativeHandle);

// Methods PUBLIC

//! Returns a EvaluatedDegeneratePcurve <br>
OCStepGeom_EvaluatedDegeneratePcurve();


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Surface^ aBasisSurface, OCNaroWrappers::OCStepRepr_DefinitionalRepresentation^ aReferenceToCurve) override;


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Surface^ aBasisSurface, OCNaroWrappers::OCStepRepr_DefinitionalRepresentation^ aReferenceToCurve, OCNaroWrappers::OCStepGeom_CartesianPoint^ aEquivalentPoint) ;


 /*instead*/  void SetEquivalentPoint(OCNaroWrappers::OCStepGeom_CartesianPoint^ aEquivalentPoint) ;


 /*instead*/  OCStepGeom_CartesianPoint^ EquivalentPoint() ;

~OCStepGeom_EvaluatedDegeneratePcurve()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
