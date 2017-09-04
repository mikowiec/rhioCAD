// File generated by CPPExt (CPP file)
//

#include "StepVisual_HArray1OfStyleContextSelect.h"
#include "../Converter.h"
#include "StepVisual_StyleContextSelect.h"
#include "StepVisual_Array1OfStyleContextSelect.h"


using namespace OCNaroWrappers;

OCStepVisual_HArray1OfStyleContextSelect::OCStepVisual_HArray1OfStyleContextSelect(Handle(StepVisual_HArray1OfStyleContextSelect)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepVisual_HArray1OfStyleContextSelect(*nativeHandle);
}

OCStepVisual_HArray1OfStyleContextSelect::OCStepVisual_HArray1OfStyleContextSelect(Standard_Integer Low, Standard_Integer Up) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepVisual_HArray1OfStyleContextSelect(new StepVisual_HArray1OfStyleContextSelect(Low, Up));
}

OCStepVisual_HArray1OfStyleContextSelect::OCStepVisual_HArray1OfStyleContextSelect(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCStepVisual_StyleContextSelect^ V) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepVisual_HArray1OfStyleContextSelect(new StepVisual_HArray1OfStyleContextSelect(Low, Up, *((StepVisual_StyleContextSelect*)V->Handle)));
}

 void OCStepVisual_HArray1OfStyleContextSelect::Init(OCNaroWrappers::OCStepVisual_StyleContextSelect^ V)
{
  (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->Init(*((StepVisual_StyleContextSelect*)V->Handle));
}

 Standard_Integer OCStepVisual_HArray1OfStyleContextSelect::Length()
{
  return (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->Length();
}

 Standard_Integer OCStepVisual_HArray1OfStyleContextSelect::Lower()
{
  return (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->Lower();
}

 Standard_Integer OCStepVisual_HArray1OfStyleContextSelect::Upper()
{
  return (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->Upper();
}

 void OCStepVisual_HArray1OfStyleContextSelect::SetValue(Standard_Integer Index, OCNaroWrappers::OCStepVisual_StyleContextSelect^ Value)
{
  (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->SetValue(Index, *((StepVisual_StyleContextSelect*)Value->Handle));
}

OCStepVisual_StyleContextSelect^ OCStepVisual_HArray1OfStyleContextSelect::Value(Standard_Integer Index)
{
  StepVisual_StyleContextSelect* tmp = new StepVisual_StyleContextSelect();
  *tmp = (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->Value(Index);
  return gcnew OCStepVisual_StyleContextSelect(tmp);
}

OCStepVisual_StyleContextSelect^ OCStepVisual_HArray1OfStyleContextSelect::ChangeValue(Standard_Integer Index)
{
  StepVisual_StyleContextSelect* tmp = new StepVisual_StyleContextSelect();
  *tmp = (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->ChangeValue(Index);
  return gcnew OCStepVisual_StyleContextSelect(tmp);
}

OCStepVisual_Array1OfStyleContextSelect^ OCStepVisual_HArray1OfStyleContextSelect::Array1()
{
  StepVisual_Array1OfStyleContextSelect* tmp = new StepVisual_Array1OfStyleContextSelect(0, 0);
  *tmp = (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->Array1();
  return gcnew OCStepVisual_Array1OfStyleContextSelect(tmp);
}

OCStepVisual_Array1OfStyleContextSelect^ OCStepVisual_HArray1OfStyleContextSelect::ChangeArray1()
{
  StepVisual_Array1OfStyleContextSelect* tmp = new StepVisual_Array1OfStyleContextSelect(0, 0);
  *tmp = (*((Handle_StepVisual_HArray1OfStyleContextSelect*)nativeHandle))->ChangeArray1();
  return gcnew OCStepVisual_Array1OfStyleContextSelect(tmp);
}


