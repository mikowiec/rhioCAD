// File generated by CPPExt (CPP file)
//

#include "Transfer_ProcessForTransient.h"
#include "../Converter.h"
#include "../Message/Message_Messenger.h"
#include "../Standard/Standard_Transient.h"
#include "Transfer_Binder.h"
#include "Transfer_ActorOfProcessForTransient.h"
#include "../Message/Message_ProgressIndicator.h"
#include "../TColStd/TColStd_MapTransientHasher.h"
#include "../TColStd/TColStd_HSequenceOfTransient.h"
#include "Transfer_TransferMapOfProcessForTransient.h"
#include "Transfer_IndexedDataMapNodeOfTransferMapOfProcessForTransient.h"
#include "Transfer_IteratorOfProcessForTransient.h"
#include "../Message/Message_Msg.h"
#include "../Interface/Interface_Check.h"
#include "../Standard/Standard_Type.h"
#include "../Interface/Interface_CheckIterator.h"


using namespace OCNaroWrappers;

OCTransfer_ProcessForTransient::OCTransfer_ProcessForTransient(Handle(Transfer_ProcessForTransient)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Transfer_ProcessForTransient(*nativeHandle);
}

OCTransfer_ProcessForTransient::OCTransfer_ProcessForTransient(Standard_Integer nb) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Transfer_ProcessForTransient(new Transfer_ProcessForTransient(nb));
}

OCTransfer_ProcessForTransient::OCTransfer_ProcessForTransient(OCNaroWrappers::OCMessage_Messenger^ printer, Standard_Integer nb) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Transfer_ProcessForTransient(new Transfer_ProcessForTransient(*((Handle_Message_Messenger*)printer->Handle), nb));
}

 void OCTransfer_ProcessForTransient::Clear()
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Clear();
}

 void OCTransfer_ProcessForTransient::Clean()
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Clean();
}

 void OCTransfer_ProcessForTransient::Resize(Standard_Integer nb)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Resize(nb);
}

 void OCTransfer_ProcessForTransient::SetActor(OCNaroWrappers::OCTransfer_ActorOfProcessForTransient^ actor)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SetActor(*((Handle_Transfer_ActorOfProcessForTransient*)actor->Handle));
}

OCTransfer_ActorOfProcessForTransient^ OCTransfer_ProcessForTransient::Actor()
{
  Handle(Transfer_ActorOfProcessForTransient) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Actor();
  return gcnew OCTransfer_ActorOfProcessForTransient(&tmp);
}

OCTransfer_Binder^ OCTransfer_ProcessForTransient::Find(OCNaroWrappers::OCStandard_Transient^ start)
{
  Handle(Transfer_Binder) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Find(*((Handle_Standard_Transient*)start->Handle));
  return gcnew OCTransfer_Binder(&tmp);
}

 System::Boolean OCTransfer_ProcessForTransient::IsBound(OCNaroWrappers::OCStandard_Transient^ start)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->IsBound(*((Handle_Standard_Transient*)start->Handle)));
}

 System::Boolean OCTransfer_ProcessForTransient::IsAlreadyUsed(OCNaroWrappers::OCStandard_Transient^ start)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->IsAlreadyUsed(*((Handle_Standard_Transient*)start->Handle)));
}

 void OCTransfer_ProcessForTransient::Bind(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCTransfer_Binder^ binder)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Bind(*((Handle_Standard_Transient*)start->Handle), *((Handle_Transfer_Binder*)binder->Handle));
}

 void OCTransfer_ProcessForTransient::Rebind(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCTransfer_Binder^ binder)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Rebind(*((Handle_Standard_Transient*)start->Handle), *((Handle_Transfer_Binder*)binder->Handle));
}

 System::Boolean OCTransfer_ProcessForTransient::Unbind(OCNaroWrappers::OCStandard_Transient^ start)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Unbind(*((Handle_Standard_Transient*)start->Handle)));
}

OCTransfer_Binder^ OCTransfer_ProcessForTransient::FindElseBind(OCNaroWrappers::OCStandard_Transient^ start)
{
  Handle(Transfer_Binder) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->FindElseBind(*((Handle_Standard_Transient*)start->Handle));
  return gcnew OCTransfer_Binder(&tmp);
}

 void OCTransfer_ProcessForTransient::SetMessenger(OCNaroWrappers::OCMessage_Messenger^ messenger)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SetMessenger(*((Handle_Message_Messenger*)messenger->Handle));
}

OCMessage_Messenger^ OCTransfer_ProcessForTransient::Messenger()
{
  Handle(Message_Messenger) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Messenger();
  return gcnew OCMessage_Messenger(&tmp);
}

 void OCTransfer_ProcessForTransient::SetTraceLevel(Standard_Integer tracelev)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SetTraceLevel(tracelev);
}

 Standard_Integer OCTransfer_ProcessForTransient::TraceLevel()
{
  return (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->TraceLevel();
}

 void OCTransfer_ProcessForTransient::SendFail(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCMessage_Msg^ amsg)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SendFail(*((Handle_Standard_Transient*)start->Handle), *((Message_Msg*)amsg->Handle));
}

 void OCTransfer_ProcessForTransient::SendWarning(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCMessage_Msg^ amsg)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SendWarning(*((Handle_Standard_Transient*)start->Handle), *((Message_Msg*)amsg->Handle));
}

 void OCTransfer_ProcessForTransient::SendMsg(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCMessage_Msg^ amsg)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SendMsg(*((Handle_Standard_Transient*)start->Handle), *((Message_Msg*)amsg->Handle));
}

 void OCTransfer_ProcessForTransient::AddFail(OCNaroWrappers::OCStandard_Transient^ start, System::String^ mess, System::String^ orig)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->AddFail(*((Handle_Standard_Transient*)start->Handle), OCConverter::StringToStandardCString(mess), OCConverter::StringToStandardCString(orig));
}

 void OCTransfer_ProcessForTransient::AddError(OCNaroWrappers::OCStandard_Transient^ start, System::String^ mess, System::String^ orig)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->AddError(*((Handle_Standard_Transient*)start->Handle), OCConverter::StringToStandardCString(mess), OCConverter::StringToStandardCString(orig));
}

 void OCTransfer_ProcessForTransient::AddFail(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCMessage_Msg^ amsg)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->AddFail(*((Handle_Standard_Transient*)start->Handle), *((Message_Msg*)amsg->Handle));
}

 void OCTransfer_ProcessForTransient::AddWarning(OCNaroWrappers::OCStandard_Transient^ start, System::String^ mess, System::String^ orig)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->AddWarning(*((Handle_Standard_Transient*)start->Handle), OCConverter::StringToStandardCString(mess), OCConverter::StringToStandardCString(orig));
}

 void OCTransfer_ProcessForTransient::AddWarning(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCMessage_Msg^ amsg)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->AddWarning(*((Handle_Standard_Transient*)start->Handle), *((Message_Msg*)amsg->Handle));
}

 void OCTransfer_ProcessForTransient::Mend(OCNaroWrappers::OCStandard_Transient^ start, System::String^ pref)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Mend(*((Handle_Standard_Transient*)start->Handle), OCConverter::StringToStandardCString(pref));
}

OCInterface_Check^ OCTransfer_ProcessForTransient::Check(OCNaroWrappers::OCStandard_Transient^ start)
{
  Handle(Interface_Check) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Check(*((Handle_Standard_Transient*)start->Handle));
  return gcnew OCInterface_Check(&tmp);
}

 void OCTransfer_ProcessForTransient::BindTransient(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCStandard_Transient^ res)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->BindTransient(*((Handle_Standard_Transient*)start->Handle), *((Handle_Standard_Transient*)res->Handle));
}

OCStandard_Transient^ OCTransfer_ProcessForTransient::FindTransient(OCNaroWrappers::OCStandard_Transient^ start)
{
  Handle(Standard_Transient) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->FindTransient(*((Handle_Standard_Transient*)start->Handle));
  return gcnew OCStandard_Transient(&tmp);
}

 void OCTransfer_ProcessForTransient::BindMultiple(OCNaroWrappers::OCStandard_Transient^ start)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->BindMultiple(*((Handle_Standard_Transient*)start->Handle));
}

 void OCTransfer_ProcessForTransient::AddMultiple(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCStandard_Transient^ res)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->AddMultiple(*((Handle_Standard_Transient*)start->Handle), *((Handle_Standard_Transient*)res->Handle));
}

 System::Boolean OCTransfer_ProcessForTransient::FindTypedTransient(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCStandard_Type^ atype, OCNaroWrappers::OCStandard_Transient^ val)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->FindTypedTransient(*((Handle_Standard_Transient*)start->Handle), *((Handle_Standard_Type*)atype->Handle), *((Handle_Standard_Transient*)val->Handle)));
}

 System::Boolean OCTransfer_ProcessForTransient::GetTypedTransient(OCNaroWrappers::OCTransfer_Binder^ binder, OCNaroWrappers::OCStandard_Type^ atype, OCNaroWrappers::OCStandard_Transient^ val)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->GetTypedTransient(*((Handle_Transfer_Binder*)binder->Handle), *((Handle_Standard_Type*)atype->Handle), *((Handle_Standard_Transient*)val->Handle)));
}

 Standard_Integer OCTransfer_ProcessForTransient::NbMapped()
{
  return (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->NbMapped();
}

OCStandard_Transient^ OCTransfer_ProcessForTransient::Mapped(Standard_Integer num)
{
  Handle(Standard_Transient) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Mapped(num);
  return gcnew OCStandard_Transient(&tmp);
}

 Standard_Integer OCTransfer_ProcessForTransient::MapIndex(OCNaroWrappers::OCStandard_Transient^ start)
{
  return (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->MapIndex(*((Handle_Standard_Transient*)start->Handle));
}

OCTransfer_Binder^ OCTransfer_ProcessForTransient::MapItem(Standard_Integer num)
{
  Handle(Transfer_Binder) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->MapItem(num);
  return gcnew OCTransfer_Binder(&tmp);
}

 void OCTransfer_ProcessForTransient::SetRoot(OCNaroWrappers::OCStandard_Transient^ start)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SetRoot(*((Handle_Standard_Transient*)start->Handle));
}

 void OCTransfer_ProcessForTransient::SetRootManagement(System::Boolean stat)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SetRootManagement(OCConverter::BooleanToStandardBoolean(stat));
}

 Standard_Integer OCTransfer_ProcessForTransient::NbRoots()
{
  return (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->NbRoots();
}

OCStandard_Transient^ OCTransfer_ProcessForTransient::Root(Standard_Integer num)
{
  Handle(Standard_Transient) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Root(num);
  return gcnew OCStandard_Transient(&tmp);
}

OCTransfer_Binder^ OCTransfer_ProcessForTransient::RootItem(Standard_Integer num)
{
  Handle(Transfer_Binder) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->RootItem(num);
  return gcnew OCTransfer_Binder(&tmp);
}

 Standard_Integer OCTransfer_ProcessForTransient::RootIndex(OCNaroWrappers::OCStandard_Transient^ start)
{
  return (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->RootIndex(*((Handle_Standard_Transient*)start->Handle));
}

 Standard_Integer OCTransfer_ProcessForTransient::NestingLevel()
{
  return (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->NestingLevel();
}

 void OCTransfer_ProcessForTransient::ResetNestingLevel()
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->ResetNestingLevel();
}

 System::Boolean OCTransfer_ProcessForTransient::Recognize(OCNaroWrappers::OCStandard_Transient^ start)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Recognize(*((Handle_Standard_Transient*)start->Handle)));
}

OCTransfer_Binder^ OCTransfer_ProcessForTransient::Transferring(OCNaroWrappers::OCStandard_Transient^ start)
{
  Handle(Transfer_Binder) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Transferring(*((Handle_Standard_Transient*)start->Handle));
  return gcnew OCTransfer_Binder(&tmp);
}

 System::Boolean OCTransfer_ProcessForTransient::Transfer(OCNaroWrappers::OCStandard_Transient^ start)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->Transfer(*((Handle_Standard_Transient*)start->Handle)));
}

 void OCTransfer_ProcessForTransient::SetErrorHandle(System::Boolean err)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SetErrorHandle(OCConverter::BooleanToStandardBoolean(err));
}

 System::Boolean OCTransfer_ProcessForTransient::ErrorHandle()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->ErrorHandle());
}

 void OCTransfer_ProcessForTransient::StartTrace(OCNaroWrappers::OCTransfer_Binder^ binder, OCNaroWrappers::OCStandard_Transient^ start, Standard_Integer level, Standard_Integer mode)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->StartTrace(*((Handle_Transfer_Binder*)binder->Handle), *((Handle_Standard_Transient*)start->Handle), level, mode);
}

 void OCTransfer_ProcessForTransient::PrintTrace(OCNaroWrappers::OCStandard_Transient^ start, OCNaroWrappers::OCMessage_Messenger^ S)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->PrintTrace(*((Handle_Standard_Transient*)start->Handle), *((Handle_Message_Messenger*)S->Handle));
}

 System::Boolean OCTransfer_ProcessForTransient::IsLooping(Standard_Integer alevel)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->IsLooping(alevel));
}

OCTransfer_IteratorOfProcessForTransient^ OCTransfer_ProcessForTransient::RootResult(System::Boolean withstart)
{
  Transfer_IteratorOfProcessForTransient* tmp = new Transfer_IteratorOfProcessForTransient(0);
  *tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->RootResult(OCConverter::BooleanToStandardBoolean(withstart));
  return gcnew OCTransfer_IteratorOfProcessForTransient(tmp);
}

OCTransfer_IteratorOfProcessForTransient^ OCTransfer_ProcessForTransient::CompleteResult(System::Boolean withstart)
{
  Transfer_IteratorOfProcessForTransient* tmp = new Transfer_IteratorOfProcessForTransient(0);
  *tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->CompleteResult(OCConverter::BooleanToStandardBoolean(withstart));
  return gcnew OCTransfer_IteratorOfProcessForTransient(tmp);
}

OCTransfer_IteratorOfProcessForTransient^ OCTransfer_ProcessForTransient::AbnormalResult()
{
  Transfer_IteratorOfProcessForTransient* tmp = new Transfer_IteratorOfProcessForTransient(0);
  *tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->AbnormalResult();
  return gcnew OCTransfer_IteratorOfProcessForTransient(tmp);
}

OCInterface_CheckIterator^ OCTransfer_ProcessForTransient::CheckList(System::Boolean erronly)
{
  Interface_CheckIterator* tmp = new Interface_CheckIterator();
  *tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->CheckList(OCConverter::BooleanToStandardBoolean(erronly));
  return gcnew OCInterface_CheckIterator(tmp);
}

OCTransfer_IteratorOfProcessForTransient^ OCTransfer_ProcessForTransient::ResultOne(OCNaroWrappers::OCStandard_Transient^ start, Standard_Integer level, System::Boolean withstart)
{
  Transfer_IteratorOfProcessForTransient* tmp = new Transfer_IteratorOfProcessForTransient(0);
  *tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->ResultOne(*((Handle_Standard_Transient*)start->Handle), level, OCConverter::BooleanToStandardBoolean(withstart));
  return gcnew OCTransfer_IteratorOfProcessForTransient(tmp);
}

OCInterface_CheckIterator^ OCTransfer_ProcessForTransient::CheckListOne(OCNaroWrappers::OCStandard_Transient^ start, Standard_Integer level, System::Boolean erronly)
{
  Interface_CheckIterator* tmp = new Interface_CheckIterator();
  *tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->CheckListOne(*((Handle_Standard_Transient*)start->Handle), level, OCConverter::BooleanToStandardBoolean(erronly));
  return gcnew OCInterface_CheckIterator(tmp);
}

 System::Boolean OCTransfer_ProcessForTransient::IsCheckListEmpty(OCNaroWrappers::OCStandard_Transient^ start, Standard_Integer level, System::Boolean erronly)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Transfer_ProcessForTransient*)nativeHandle))->IsCheckListEmpty(*((Handle_Standard_Transient*)start->Handle), level, OCConverter::BooleanToStandardBoolean(erronly)));
}

 void OCTransfer_ProcessForTransient::RemoveResult(OCNaroWrappers::OCStandard_Transient^ start, Standard_Integer level, System::Boolean compute)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->RemoveResult(*((Handle_Standard_Transient*)start->Handle), level, OCConverter::BooleanToStandardBoolean(compute));
}

 Standard_Integer OCTransfer_ProcessForTransient::CheckNum(OCNaroWrappers::OCStandard_Transient^ start)
{
  return (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->CheckNum(*((Handle_Standard_Transient*)start->Handle));
}

 void OCTransfer_ProcessForTransient::SetProgress(OCNaroWrappers::OCMessage_ProgressIndicator^ theProgress)
{
  (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->SetProgress(*((Handle_Message_ProgressIndicator*)theProgress->Handle));
}

OCMessage_ProgressIndicator^ OCTransfer_ProcessForTransient::GetProgress()
{
  Handle(Message_ProgressIndicator) tmp = (*((Handle_Transfer_ProcessForTransient*)nativeHandle))->GetProgress();
  return gcnew OCMessage_ProgressIndicator(&tmp);
}

