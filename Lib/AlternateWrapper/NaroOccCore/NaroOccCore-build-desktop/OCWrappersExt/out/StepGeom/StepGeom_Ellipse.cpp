// File generated by CPPExt (CPP file)
//

#include "StepGeom_Ellipse.h"
#include "../Converter.h"
#include "../TCollection/TCollection_HAsciiString.h"
#include "StepGeom_Axis2Placement.h"


using namespace OCNaroWrappers;

OCStepGeom_Ellipse::OCStepGeom_Ellipse(StepGeom_Ellipse* nativeHandle) : OCStepGeom_Conic((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepGeom_Ellipse::OCStepGeom_Ellipse() : OCStepGeom_Conic((OCDummy^)nullptr)

{
  nativeHandle = new StepGeom_Ellipse();
}

 void OCStepGeom_Ellipse::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Axis2Placement^ aPosition)
{
  ((StepGeom_Ellipse*)nativeHandle)->Init(*((Handle_TCollection_HAsciiString*)aName->Handle), *((StepGeom_Axis2Placement*)aPosition->Handle));
}

 void OCStepGeom_Ellipse::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Axis2Placement^ aPosition, Standard_Real aSemiAxis1, Standard_Real aSemiAxis2)
{
  ((StepGeom_Ellipse*)nativeHandle)->Init(*((Handle_TCollection_HAsciiString*)aName->Handle), *((StepGeom_Axis2Placement*)aPosition->Handle), aSemiAxis1, aSemiAxis2);
}

 void OCStepGeom_Ellipse::SetSemiAxis1(Standard_Real aSemiAxis1)
{
  ((StepGeom_Ellipse*)nativeHandle)->SetSemiAxis1(aSemiAxis1);
}

 Standard_Real OCStepGeom_Ellipse::SemiAxis1()
{
  return ((StepGeom_Ellipse*)nativeHandle)->SemiAxis1();
}

 void OCStepGeom_Ellipse::SetSemiAxis2(Standard_Real aSemiAxis2)
{
  ((StepGeom_Ellipse*)nativeHandle)->SetSemiAxis2(aSemiAxis2);
}

 Standard_Real OCStepGeom_Ellipse::SemiAxis2()
{
  return ((StepGeom_Ellipse*)nativeHandle)->SemiAxis2();
}


