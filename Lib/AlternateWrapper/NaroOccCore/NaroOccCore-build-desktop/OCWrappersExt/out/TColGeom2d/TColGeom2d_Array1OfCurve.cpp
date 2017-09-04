// File generated by CPPExt (CPP file)
//

#include "TColGeom2d_Array1OfCurve.h"
#include "../Converter.h"
#include "../Geom2d/Geom2d_Curve.h"


using namespace OCNaroWrappers;

OCTColGeom2d_Array1OfCurve::OCTColGeom2d_Array1OfCurve(TColGeom2d_Array1OfCurve* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTColGeom2d_Array1OfCurve::OCTColGeom2d_Array1OfCurve(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new TColGeom2d_Array1OfCurve(Low, Up);
}

OCTColGeom2d_Array1OfCurve::OCTColGeom2d_Array1OfCurve(OCNaroWrappers::OCGeom2d_Curve^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new TColGeom2d_Array1OfCurve(*((Handle_Geom2d_Curve*)Item->Handle), Low, Up);
}

 void OCTColGeom2d_Array1OfCurve::Init(OCNaroWrappers::OCGeom2d_Curve^ V)
{
  ((TColGeom2d_Array1OfCurve*)nativeHandle)->Init(*((Handle_Geom2d_Curve*)V->Handle));
}

 System::Boolean OCTColGeom2d_Array1OfCurve::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((TColGeom2d_Array1OfCurve*)nativeHandle)->IsAllocated());
}

OCTColGeom2d_Array1OfCurve^ OCTColGeom2d_Array1OfCurve::Assign(OCNaroWrappers::OCTColGeom2d_Array1OfCurve^ Other)
{
  TColGeom2d_Array1OfCurve* tmp = new TColGeom2d_Array1OfCurve(0, 0);
  *tmp = ((TColGeom2d_Array1OfCurve*)nativeHandle)->Assign(*((TColGeom2d_Array1OfCurve*)Other->Handle));
  return gcnew OCTColGeom2d_Array1OfCurve(tmp);
}

 Standard_Integer OCTColGeom2d_Array1OfCurve::Length()
{
  return ((TColGeom2d_Array1OfCurve*)nativeHandle)->Length();
}

 Standard_Integer OCTColGeom2d_Array1OfCurve::Lower()
{
  return ((TColGeom2d_Array1OfCurve*)nativeHandle)->Lower();
}

 Standard_Integer OCTColGeom2d_Array1OfCurve::Upper()
{
  return ((TColGeom2d_Array1OfCurve*)nativeHandle)->Upper();
}

 void OCTColGeom2d_Array1OfCurve::SetValue(Standard_Integer Index, OCNaroWrappers::OCGeom2d_Curve^ Value)
{
  ((TColGeom2d_Array1OfCurve*)nativeHandle)->SetValue(Index, *((Handle_Geom2d_Curve*)Value->Handle));
}

OCGeom2d_Curve^ OCTColGeom2d_Array1OfCurve::Value(Standard_Integer Index)
{
  Handle(Geom2d_Curve) tmp = ((TColGeom2d_Array1OfCurve*)nativeHandle)->Value(Index);
  return gcnew OCGeom2d_Curve(&tmp);
}

OCGeom2d_Curve^ OCTColGeom2d_Array1OfCurve::ChangeValue(Standard_Integer Index)
{
  Handle(Geom2d_Curve) tmp = ((TColGeom2d_Array1OfCurve*)nativeHandle)->ChangeValue(Index);
  return gcnew OCGeom2d_Curve(&tmp);
}


