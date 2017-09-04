// File generated by CPPExt (CPP file)
//

#include "AppParCurves_HArray1OfMultiCurve.h"
#include "../Converter.h"
#include "AppParCurves_MultiCurve.h"
#include "AppParCurves_Array1OfMultiCurve.h"


using namespace OCNaroWrappers;

OCAppParCurves_HArray1OfMultiCurve::OCAppParCurves_HArray1OfMultiCurve(Handle(AppParCurves_HArray1OfMultiCurve)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_AppParCurves_HArray1OfMultiCurve(*nativeHandle);
}

OCAppParCurves_HArray1OfMultiCurve::OCAppParCurves_HArray1OfMultiCurve(Standard_Integer Low, Standard_Integer Up) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AppParCurves_HArray1OfMultiCurve(new AppParCurves_HArray1OfMultiCurve(Low, Up));
}

OCAppParCurves_HArray1OfMultiCurve::OCAppParCurves_HArray1OfMultiCurve(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCAppParCurves_MultiCurve^ V) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AppParCurves_HArray1OfMultiCurve(new AppParCurves_HArray1OfMultiCurve(Low, Up, *((AppParCurves_MultiCurve*)V->Handle)));
}

 void OCAppParCurves_HArray1OfMultiCurve::Init(OCNaroWrappers::OCAppParCurves_MultiCurve^ V)
{
  (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->Init(*((AppParCurves_MultiCurve*)V->Handle));
}

 Standard_Integer OCAppParCurves_HArray1OfMultiCurve::Length()
{
  return (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->Length();
}

 Standard_Integer OCAppParCurves_HArray1OfMultiCurve::Lower()
{
  return (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->Lower();
}

 Standard_Integer OCAppParCurves_HArray1OfMultiCurve::Upper()
{
  return (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->Upper();
}

 void OCAppParCurves_HArray1OfMultiCurve::SetValue(Standard_Integer Index, OCNaroWrappers::OCAppParCurves_MultiCurve^ Value)
{
  (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->SetValue(Index, *((AppParCurves_MultiCurve*)Value->Handle));
}

OCAppParCurves_MultiCurve^ OCAppParCurves_HArray1OfMultiCurve::Value(Standard_Integer Index)
{
  AppParCurves_MultiCurve* tmp = new AppParCurves_MultiCurve();
  *tmp = (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->Value(Index);
  return gcnew OCAppParCurves_MultiCurve(tmp);
}

OCAppParCurves_MultiCurve^ OCAppParCurves_HArray1OfMultiCurve::ChangeValue(Standard_Integer Index)
{
  AppParCurves_MultiCurve* tmp = new AppParCurves_MultiCurve();
  *tmp = (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->ChangeValue(Index);
  return gcnew OCAppParCurves_MultiCurve(tmp);
}

OCAppParCurves_Array1OfMultiCurve^ OCAppParCurves_HArray1OfMultiCurve::Array1()
{
  AppParCurves_Array1OfMultiCurve* tmp = new AppParCurves_Array1OfMultiCurve(0, 0);
  *tmp = (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->Array1();
  return gcnew OCAppParCurves_Array1OfMultiCurve(tmp);
}

OCAppParCurves_Array1OfMultiCurve^ OCAppParCurves_HArray1OfMultiCurve::ChangeArray1()
{
  AppParCurves_Array1OfMultiCurve* tmp = new AppParCurves_Array1OfMultiCurve(0, 0);
  *tmp = (*((Handle_AppParCurves_HArray1OfMultiCurve*)nativeHandle))->ChangeArray1();
  return gcnew OCAppParCurves_Array1OfMultiCurve(tmp);
}


