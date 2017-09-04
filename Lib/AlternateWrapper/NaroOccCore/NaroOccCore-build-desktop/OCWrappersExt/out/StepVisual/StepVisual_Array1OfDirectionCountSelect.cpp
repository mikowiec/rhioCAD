// File generated by CPPExt (CPP file)
//

#include "StepVisual_Array1OfDirectionCountSelect.h"
#include "../Converter.h"
#include "StepVisual_DirectionCountSelect.h"


using namespace OCNaroWrappers;

OCStepVisual_Array1OfDirectionCountSelect::OCStepVisual_Array1OfDirectionCountSelect(StepVisual_Array1OfDirectionCountSelect* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCStepVisual_Array1OfDirectionCountSelect::OCStepVisual_Array1OfDirectionCountSelect(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new StepVisual_Array1OfDirectionCountSelect(Low, Up);
}

OCStepVisual_Array1OfDirectionCountSelect::OCStepVisual_Array1OfDirectionCountSelect(OCNaroWrappers::OCStepVisual_DirectionCountSelect^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new StepVisual_Array1OfDirectionCountSelect(*((StepVisual_DirectionCountSelect*)Item->Handle), Low, Up);
}

 void OCStepVisual_Array1OfDirectionCountSelect::Init(OCNaroWrappers::OCStepVisual_DirectionCountSelect^ V)
{
  ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->Init(*((StepVisual_DirectionCountSelect*)V->Handle));
}

 System::Boolean OCStepVisual_Array1OfDirectionCountSelect::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->IsAllocated());
}

OCStepVisual_Array1OfDirectionCountSelect^ OCStepVisual_Array1OfDirectionCountSelect::Assign(OCNaroWrappers::OCStepVisual_Array1OfDirectionCountSelect^ Other)
{
  StepVisual_Array1OfDirectionCountSelect* tmp = new StepVisual_Array1OfDirectionCountSelect(0, 0);
  *tmp = ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->Assign(*((StepVisual_Array1OfDirectionCountSelect*)Other->Handle));
  return gcnew OCStepVisual_Array1OfDirectionCountSelect(tmp);
}

 Standard_Integer OCStepVisual_Array1OfDirectionCountSelect::Length()
{
  return ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->Length();
}

 Standard_Integer OCStepVisual_Array1OfDirectionCountSelect::Lower()
{
  return ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->Lower();
}

 Standard_Integer OCStepVisual_Array1OfDirectionCountSelect::Upper()
{
  return ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->Upper();
}

 void OCStepVisual_Array1OfDirectionCountSelect::SetValue(Standard_Integer Index, OCNaroWrappers::OCStepVisual_DirectionCountSelect^ Value)
{
  ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->SetValue(Index, *((StepVisual_DirectionCountSelect*)Value->Handle));
}

OCStepVisual_DirectionCountSelect^ OCStepVisual_Array1OfDirectionCountSelect::Value(Standard_Integer Index)
{
  StepVisual_DirectionCountSelect* tmp = new StepVisual_DirectionCountSelect();
  *tmp = ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->Value(Index);
  return gcnew OCStepVisual_DirectionCountSelect(tmp);
}

OCStepVisual_DirectionCountSelect^ OCStepVisual_Array1OfDirectionCountSelect::ChangeValue(Standard_Integer Index)
{
  StepVisual_DirectionCountSelect* tmp = new StepVisual_DirectionCountSelect();
  *tmp = ((StepVisual_Array1OfDirectionCountSelect*)nativeHandle)->ChangeValue(Index);
  return gcnew OCStepVisual_DirectionCountSelect(tmp);
}


