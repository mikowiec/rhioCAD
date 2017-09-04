// File generated by CPPExt (CPP file)
//

#include "StepRepr_HArray1OfMaterialPropertyRepresentation.h"
#include "../Converter.h"
#include "StepRepr_MaterialPropertyRepresentation.h"
#include "StepRepr_Array1OfMaterialPropertyRepresentation.h"


using namespace OCNaroWrappers;

OCStepRepr_HArray1OfMaterialPropertyRepresentation::OCStepRepr_HArray1OfMaterialPropertyRepresentation(Handle(StepRepr_HArray1OfMaterialPropertyRepresentation)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepRepr_HArray1OfMaterialPropertyRepresentation(*nativeHandle);
}

OCStepRepr_HArray1OfMaterialPropertyRepresentation::OCStepRepr_HArray1OfMaterialPropertyRepresentation(Standard_Integer Low, Standard_Integer Up) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepRepr_HArray1OfMaterialPropertyRepresentation(new StepRepr_HArray1OfMaterialPropertyRepresentation(Low, Up));
}

OCStepRepr_HArray1OfMaterialPropertyRepresentation::OCStepRepr_HArray1OfMaterialPropertyRepresentation(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCStepRepr_MaterialPropertyRepresentation^ V) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepRepr_HArray1OfMaterialPropertyRepresentation(new StepRepr_HArray1OfMaterialPropertyRepresentation(Low, Up, *((Handle_StepRepr_MaterialPropertyRepresentation*)V->Handle)));
}

 void OCStepRepr_HArray1OfMaterialPropertyRepresentation::Init(OCNaroWrappers::OCStepRepr_MaterialPropertyRepresentation^ V)
{
  (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->Init(*((Handle_StepRepr_MaterialPropertyRepresentation*)V->Handle));
}

 Standard_Integer OCStepRepr_HArray1OfMaterialPropertyRepresentation::Length()
{
  return (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->Length();
}

 Standard_Integer OCStepRepr_HArray1OfMaterialPropertyRepresentation::Lower()
{
  return (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->Lower();
}

 Standard_Integer OCStepRepr_HArray1OfMaterialPropertyRepresentation::Upper()
{
  return (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->Upper();
}

 void OCStepRepr_HArray1OfMaterialPropertyRepresentation::SetValue(Standard_Integer Index, OCNaroWrappers::OCStepRepr_MaterialPropertyRepresentation^ Value)
{
  (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->SetValue(Index, *((Handle_StepRepr_MaterialPropertyRepresentation*)Value->Handle));
}

OCStepRepr_MaterialPropertyRepresentation^ OCStepRepr_HArray1OfMaterialPropertyRepresentation::Value(Standard_Integer Index)
{
  Handle(StepRepr_MaterialPropertyRepresentation) tmp = (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->Value(Index);
  return gcnew OCStepRepr_MaterialPropertyRepresentation(&tmp);
}

OCStepRepr_MaterialPropertyRepresentation^ OCStepRepr_HArray1OfMaterialPropertyRepresentation::ChangeValue(Standard_Integer Index)
{
  Handle(StepRepr_MaterialPropertyRepresentation) tmp = (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->ChangeValue(Index);
  return gcnew OCStepRepr_MaterialPropertyRepresentation(&tmp);
}

OCStepRepr_Array1OfMaterialPropertyRepresentation^ OCStepRepr_HArray1OfMaterialPropertyRepresentation::Array1()
{
  StepRepr_Array1OfMaterialPropertyRepresentation* tmp = new StepRepr_Array1OfMaterialPropertyRepresentation(0, 0);
  *tmp = (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->Array1();
  return gcnew OCStepRepr_Array1OfMaterialPropertyRepresentation(tmp);
}

OCStepRepr_Array1OfMaterialPropertyRepresentation^ OCStepRepr_HArray1OfMaterialPropertyRepresentation::ChangeArray1()
{
  StepRepr_Array1OfMaterialPropertyRepresentation* tmp = new StepRepr_Array1OfMaterialPropertyRepresentation(0, 0);
  *tmp = (*((Handle_StepRepr_HArray1OfMaterialPropertyRepresentation*)nativeHandle))->ChangeArray1();
  return gcnew OCStepRepr_Array1OfMaterialPropertyRepresentation(tmp);
}


