// File generated by CPPExt (CPP file)
//

#include "StepGeom_OuterBoundaryCurve.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepGeom_OuterBoundaryCurve::OCStepGeom_OuterBoundaryCurve(StepGeom_OuterBoundaryCurve* nativeHandle) : OCStepGeom_BoundaryCurve((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepGeom_OuterBoundaryCurve::OCStepGeom_OuterBoundaryCurve() : OCStepGeom_BoundaryCurve((OCDummy^)nullptr)

{
  nativeHandle = new StepGeom_OuterBoundaryCurve();
}


