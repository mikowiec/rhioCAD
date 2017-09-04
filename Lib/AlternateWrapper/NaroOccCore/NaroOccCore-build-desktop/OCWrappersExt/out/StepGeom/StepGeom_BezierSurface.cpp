// File generated by CPPExt (CPP file)
//

#include "StepGeom_BezierSurface.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepGeom_BezierSurface::OCStepGeom_BezierSurface(StepGeom_BezierSurface* nativeHandle) : OCStepGeom_BSplineSurface((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepGeom_BezierSurface::OCStepGeom_BezierSurface() : OCStepGeom_BSplineSurface((OCDummy^)nullptr)

{
  nativeHandle = new StepGeom_BezierSurface();
}


