// File generated by CPPExt (MPV)
//
#ifndef _StepShape_Torus_OCWrappers_HeaderFile
#define _StepShape_Torus_OCWrappers_HeaderFile

// include native header
#include <StepShape_Torus.hxx>
#include "../Converter.h"

#include "../StepGeom/StepGeom_GeometricRepresentationItem.h"

#include "../StepGeom/StepGeom_Axis1Placement.h"
#include "../StepGeom/StepGeom_GeometricRepresentationItem.h"


namespace OCNaroWrappers
{

ref class OCTCollection_HAsciiString;
ref class OCStepGeom_Axis1Placement;



public ref class OCStepShape_Torus  : public OCStepGeom_GeometricRepresentationItem {

protected:
  // dummy constructor;
  OCStepShape_Torus(OCDummy^) : OCStepGeom_GeometricRepresentationItem((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepShape_Torus(StepShape_Torus* nativeHandle);

// Methods PUBLIC

//! Returns a Torus <br>
OCStepShape_Torus();


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName) ;


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Axis1Placement^ aPosition, Standard_Real aMajorRadius, Standard_Real aMinorRadius) ;


 /*instead*/  void SetPosition(OCNaroWrappers::OCStepGeom_Axis1Placement^ aPosition) ;


 /*instead*/  OCStepGeom_Axis1Placement^ Position() ;


 /*instead*/  void SetMajorRadius(Standard_Real aMajorRadius) ;


 /*instead*/  Standard_Real MajorRadius() ;


 /*instead*/  void SetMinorRadius(Standard_Real aMinorRadius) ;


 /*instead*/  Standard_Real MinorRadius() ;

~OCStepShape_Torus()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
