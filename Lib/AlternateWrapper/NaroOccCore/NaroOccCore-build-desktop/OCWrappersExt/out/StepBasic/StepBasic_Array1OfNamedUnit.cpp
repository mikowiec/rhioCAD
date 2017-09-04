// File generated by CPPExt (CPP file)
//

#include "StepBasic_Array1OfNamedUnit.h"
#include "../Converter.h"
#include "StepBasic_NamedUnit.h"


using namespace OCNaroWrappers;

OCStepBasic_Array1OfNamedUnit::OCStepBasic_Array1OfNamedUnit(StepBasic_Array1OfNamedUnit* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCStepBasic_Array1OfNamedUnit::OCStepBasic_Array1OfNamedUnit(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new StepBasic_Array1OfNamedUnit(Low, Up);
}

OCStepBasic_Array1OfNamedUnit::OCStepBasic_Array1OfNamedUnit(OCNaroWrappers::OCStepBasic_NamedUnit^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new StepBasic_Array1OfNamedUnit(*((Handle_StepBasic_NamedUnit*)Item->Handle), Low, Up);
}

 void OCStepBasic_Array1OfNamedUnit::Init(OCNaroWrappers::OCStepBasic_NamedUnit^ V)
{
  ((StepBasic_Array1OfNamedUnit*)nativeHandle)->Init(*((Handle_StepBasic_NamedUnit*)V->Handle));
}

 System::Boolean OCStepBasic_Array1OfNamedUnit::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((StepBasic_Array1OfNamedUnit*)nativeHandle)->IsAllocated());
}

OCStepBasic_Array1OfNamedUnit^ OCStepBasic_Array1OfNamedUnit::Assign(OCNaroWrappers::OCStepBasic_Array1OfNamedUnit^ Other)
{
  StepBasic_Array1OfNamedUnit* tmp = new StepBasic_Array1OfNamedUnit(0, 0);
  *tmp = ((StepBasic_Array1OfNamedUnit*)nativeHandle)->Assign(*((StepBasic_Array1OfNamedUnit*)Other->Handle));
  return gcnew OCStepBasic_Array1OfNamedUnit(tmp);
}

 Standard_Integer OCStepBasic_Array1OfNamedUnit::Length()
{
  return ((StepBasic_Array1OfNamedUnit*)nativeHandle)->Length();
}

 Standard_Integer OCStepBasic_Array1OfNamedUnit::Lower()
{
  return ((StepBasic_Array1OfNamedUnit*)nativeHandle)->Lower();
}

 Standard_Integer OCStepBasic_Array1OfNamedUnit::Upper()
{
  return ((StepBasic_Array1OfNamedUnit*)nativeHandle)->Upper();
}

 void OCStepBasic_Array1OfNamedUnit::SetValue(Standard_Integer Index, OCNaroWrappers::OCStepBasic_NamedUnit^ Value)
{
  ((StepBasic_Array1OfNamedUnit*)nativeHandle)->SetValue(Index, *((Handle_StepBasic_NamedUnit*)Value->Handle));
}

OCStepBasic_NamedUnit^ OCStepBasic_Array1OfNamedUnit::Value(Standard_Integer Index)
{
  Handle(StepBasic_NamedUnit) tmp = ((StepBasic_Array1OfNamedUnit*)nativeHandle)->Value(Index);
  return gcnew OCStepBasic_NamedUnit(&tmp);
}

OCStepBasic_NamedUnit^ OCStepBasic_Array1OfNamedUnit::ChangeValue(Standard_Integer Index)
{
  Handle(StepBasic_NamedUnit) tmp = ((StepBasic_Array1OfNamedUnit*)nativeHandle)->ChangeValue(Index);
  return gcnew OCStepBasic_NamedUnit(&tmp);
}


