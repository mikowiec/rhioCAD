// File generated by CPPExt (MPV)
//
#ifndef _StepShape_AngularLocation_OCWrappers_HeaderFile
#define _StepShape_AngularLocation_OCWrappers_HeaderFile

// include native header
#include <StepShape_AngularLocation.hxx>
#include "../Converter.h"

#include "StepShape_DimensionalLocation.h"

#include "StepShape_AngleRelator.h"
#include "StepShape_DimensionalLocation.h"


namespace OCNaroWrappers
{

ref class OCTCollection_HAsciiString;
ref class OCStepRepr_ShapeAspect;


//! Representation of STEP entity AngularLocation <br>
public ref class OCStepShape_AngularLocation  : public OCStepShape_DimensionalLocation {

protected:
  // dummy constructor;
  OCStepShape_AngularLocation(OCDummy^) : OCStepShape_DimensionalLocation((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepShape_AngularLocation(StepShape_AngularLocation* nativeHandle);

// Methods PUBLIC

//! Empty constructor <br>
OCStepShape_AngularLocation();

//! Initialize all fields (own and inherited) <br>
 /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aShapeAspectRelationship_Name, System::Boolean hasShapeAspectRelationship_Description, OCNaroWrappers::OCTCollection_HAsciiString^ aShapeAspectRelationship_Description, OCNaroWrappers::OCStepRepr_ShapeAspect^ aShapeAspectRelationship_RelatingShapeAspect, OCNaroWrappers::OCStepRepr_ShapeAspect^ aShapeAspectRelationship_RelatedShapeAspect, OCStepShape_AngleRelator aAngleSelection) ;

//! Returns field AngleSelection <br>
 /*instead*/  OCStepShape_AngleRelator AngleSelection() ;

//! Set field AngleSelection <br>
 /*instead*/  void SetAngleSelection(OCStepShape_AngleRelator AngleSelection) ;

~OCStepShape_AngularLocation()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
