// File generated by CPPExt (CPP file)
//

#include "StepAP203_StartWork.h"
#include "../Converter.h"
#include "StepAP203_HArray1OfWorkItem.h"
#include "../StepBasic/StepBasic_Action.h"


using namespace OCNaroWrappers;

OCStepAP203_StartWork::OCStepAP203_StartWork(Handle(StepAP203_StartWork)* nativeHandle) : OCStepBasic_ActionAssignment((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepAP203_StartWork(*nativeHandle);
}

OCStepAP203_StartWork::OCStepAP203_StartWork() : OCStepBasic_ActionAssignment((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepAP203_StartWork(new StepAP203_StartWork());
}

 void OCStepAP203_StartWork::Init(OCNaroWrappers::OCStepBasic_Action^ aActionAssignment_AssignedAction, OCNaroWrappers::OCStepAP203_HArray1OfWorkItem^ aItems)
{
  (*((Handle_StepAP203_StartWork*)nativeHandle))->Init(*((Handle_StepBasic_Action*)aActionAssignment_AssignedAction->Handle), *((Handle_StepAP203_HArray1OfWorkItem*)aItems->Handle));
}

OCStepAP203_HArray1OfWorkItem^ OCStepAP203_StartWork::Items()
{
  Handle(StepAP203_HArray1OfWorkItem) tmp = (*((Handle_StepAP203_StartWork*)nativeHandle))->Items();
  return gcnew OCStepAP203_HArray1OfWorkItem(&tmp);
}

 void OCStepAP203_StartWork::SetItems(OCNaroWrappers::OCStepAP203_HArray1OfWorkItem^ Items)
{
  (*((Handle_StepAP203_StartWork*)nativeHandle))->SetItems(*((Handle_StepAP203_HArray1OfWorkItem*)Items->Handle));
}

