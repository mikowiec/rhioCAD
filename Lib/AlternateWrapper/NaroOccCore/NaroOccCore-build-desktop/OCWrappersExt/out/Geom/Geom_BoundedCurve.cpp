// File generated by CPPExt (CPP file)
//

#include "Geom_BoundedCurve.h"
#include "../Converter.h"
#include "../gp/gp_Pnt.h"


using namespace OCNaroWrappers;

OCGeom_BoundedCurve::OCGeom_BoundedCurve(Handle(Geom_BoundedCurve)* nativeHandle) : OCGeom_Curve((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Geom_BoundedCurve(*nativeHandle);
}


