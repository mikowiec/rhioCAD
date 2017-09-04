// File generated by CPPExt (CPP file)
//

#include "StepGeom_Array1OfPcurveOrSurface.h"
#include "../Converter.h"
#include "StepGeom_PcurveOrSurface.h"


using namespace OCNaroWrappers;

OCStepGeom_Array1OfPcurveOrSurface::OCStepGeom_Array1OfPcurveOrSurface(StepGeom_Array1OfPcurveOrSurface* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCStepGeom_Array1OfPcurveOrSurface::OCStepGeom_Array1OfPcurveOrSurface(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new StepGeom_Array1OfPcurveOrSurface(Low, Up);
}

OCStepGeom_Array1OfPcurveOrSurface::OCStepGeom_Array1OfPcurveOrSurface(OCNaroWrappers::OCStepGeom_PcurveOrSurface^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new StepGeom_Array1OfPcurveOrSurface(*((StepGeom_PcurveOrSurface*)Item->Handle), Low, Up);
}

 void OCStepGeom_Array1OfPcurveOrSurface::Init(OCNaroWrappers::OCStepGeom_PcurveOrSurface^ V)
{
  ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->Init(*((StepGeom_PcurveOrSurface*)V->Handle));
}

 System::Boolean OCStepGeom_Array1OfPcurveOrSurface::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->IsAllocated());
}

OCStepGeom_Array1OfPcurveOrSurface^ OCStepGeom_Array1OfPcurveOrSurface::Assign(OCNaroWrappers::OCStepGeom_Array1OfPcurveOrSurface^ Other)
{
  StepGeom_Array1OfPcurveOrSurface* tmp = new StepGeom_Array1OfPcurveOrSurface(0, 0);
  *tmp = ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->Assign(*((StepGeom_Array1OfPcurveOrSurface*)Other->Handle));
  return gcnew OCStepGeom_Array1OfPcurveOrSurface(tmp);
}

 Standard_Integer OCStepGeom_Array1OfPcurveOrSurface::Length()
{
  return ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->Length();
}

 Standard_Integer OCStepGeom_Array1OfPcurveOrSurface::Lower()
{
  return ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->Lower();
}

 Standard_Integer OCStepGeom_Array1OfPcurveOrSurface::Upper()
{
  return ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->Upper();
}

 void OCStepGeom_Array1OfPcurveOrSurface::SetValue(Standard_Integer Index, OCNaroWrappers::OCStepGeom_PcurveOrSurface^ Value)
{
  ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->SetValue(Index, *((StepGeom_PcurveOrSurface*)Value->Handle));
}

OCStepGeom_PcurveOrSurface^ OCStepGeom_Array1OfPcurveOrSurface::Value(Standard_Integer Index)
{
  StepGeom_PcurveOrSurface* tmp = new StepGeom_PcurveOrSurface();
  *tmp = ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->Value(Index);
  return gcnew OCStepGeom_PcurveOrSurface(tmp);
}

OCStepGeom_PcurveOrSurface^ OCStepGeom_Array1OfPcurveOrSurface::ChangeValue(Standard_Integer Index)
{
  StepGeom_PcurveOrSurface* tmp = new StepGeom_PcurveOrSurface();
  *tmp = ((StepGeom_Array1OfPcurveOrSurface*)nativeHandle)->ChangeValue(Index);
  return gcnew OCStepGeom_PcurveOrSurface(tmp);
}


