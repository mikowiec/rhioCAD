// File generated by CPPExt (CPP file)
//

#include "StepAP214_HArray1OfPersonAndOrganizationItem.h"
#include "../Converter.h"
#include "StepAP214_PersonAndOrganizationItem.h"
#include "StepAP214_Array1OfPersonAndOrganizationItem.h"


using namespace OCNaroWrappers;

OCStepAP214_HArray1OfPersonAndOrganizationItem::OCStepAP214_HArray1OfPersonAndOrganizationItem(Handle(StepAP214_HArray1OfPersonAndOrganizationItem)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepAP214_HArray1OfPersonAndOrganizationItem(*nativeHandle);
}

OCStepAP214_HArray1OfPersonAndOrganizationItem::OCStepAP214_HArray1OfPersonAndOrganizationItem(Standard_Integer Low, Standard_Integer Up) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepAP214_HArray1OfPersonAndOrganizationItem(new StepAP214_HArray1OfPersonAndOrganizationItem(Low, Up));
}

OCStepAP214_HArray1OfPersonAndOrganizationItem::OCStepAP214_HArray1OfPersonAndOrganizationItem(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCStepAP214_PersonAndOrganizationItem^ V) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepAP214_HArray1OfPersonAndOrganizationItem(new StepAP214_HArray1OfPersonAndOrganizationItem(Low, Up, *((StepAP214_PersonAndOrganizationItem*)V->Handle)));
}

 void OCStepAP214_HArray1OfPersonAndOrganizationItem::Init(OCNaroWrappers::OCStepAP214_PersonAndOrganizationItem^ V)
{
  (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->Init(*((StepAP214_PersonAndOrganizationItem*)V->Handle));
}

 Standard_Integer OCStepAP214_HArray1OfPersonAndOrganizationItem::Length()
{
  return (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->Length();
}

 Standard_Integer OCStepAP214_HArray1OfPersonAndOrganizationItem::Lower()
{
  return (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->Lower();
}

 Standard_Integer OCStepAP214_HArray1OfPersonAndOrganizationItem::Upper()
{
  return (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->Upper();
}

 void OCStepAP214_HArray1OfPersonAndOrganizationItem::SetValue(Standard_Integer Index, OCNaroWrappers::OCStepAP214_PersonAndOrganizationItem^ Value)
{
  (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->SetValue(Index, *((StepAP214_PersonAndOrganizationItem*)Value->Handle));
}

OCStepAP214_PersonAndOrganizationItem^ OCStepAP214_HArray1OfPersonAndOrganizationItem::Value(Standard_Integer Index)
{
  StepAP214_PersonAndOrganizationItem* tmp = new StepAP214_PersonAndOrganizationItem();
  *tmp = (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->Value(Index);
  return gcnew OCStepAP214_PersonAndOrganizationItem(tmp);
}

OCStepAP214_PersonAndOrganizationItem^ OCStepAP214_HArray1OfPersonAndOrganizationItem::ChangeValue(Standard_Integer Index)
{
  StepAP214_PersonAndOrganizationItem* tmp = new StepAP214_PersonAndOrganizationItem();
  *tmp = (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->ChangeValue(Index);
  return gcnew OCStepAP214_PersonAndOrganizationItem(tmp);
}

OCStepAP214_Array1OfPersonAndOrganizationItem^ OCStepAP214_HArray1OfPersonAndOrganizationItem::Array1()
{
  StepAP214_Array1OfPersonAndOrganizationItem* tmp = new StepAP214_Array1OfPersonAndOrganizationItem(0, 0);
  *tmp = (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->Array1();
  return gcnew OCStepAP214_Array1OfPersonAndOrganizationItem(tmp);
}

OCStepAP214_Array1OfPersonAndOrganizationItem^ OCStepAP214_HArray1OfPersonAndOrganizationItem::ChangeArray1()
{
  StepAP214_Array1OfPersonAndOrganizationItem* tmp = new StepAP214_Array1OfPersonAndOrganizationItem(0, 0);
  *tmp = (*((Handle_StepAP214_HArray1OfPersonAndOrganizationItem*)nativeHandle))->ChangeArray1();
  return gcnew OCStepAP214_Array1OfPersonAndOrganizationItem(tmp);
}

