// File generated by CPPExt (CPP file)
//

#include "IFSelect_EditForm.h"
#include "../Converter.h"
#include "IFSelect_Editor.h"
#include "../Standard/Standard_Transient.h"
#include "../Interface/Interface_InterfaceModel.h"
#include "../TColStd/TColStd_SequenceOfInteger.h"
#include "IFSelect_ListEditor.h"
#include "../TCollection/TCollection_HAsciiString.h"
#include "../TColStd/TColStd_HSequenceOfHAsciiString.h"
#include "../Message/Message_Messenger.h"


using namespace OCNaroWrappers;

OCIFSelect_EditForm::OCIFSelect_EditForm(Handle(IFSelect_EditForm)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_IFSelect_EditForm(*nativeHandle);
}

OCIFSelect_EditForm::OCIFSelect_EditForm(OCNaroWrappers::OCIFSelect_Editor^ editor, System::Boolean readonly, System::Boolean undoable, System::String^ label) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IFSelect_EditForm(new IFSelect_EditForm(*((Handle_IFSelect_Editor*)editor->Handle), OCConverter::BooleanToStandardBoolean(readonly), OCConverter::BooleanToStandardBoolean(undoable), OCConverter::StringToStandardCString(label)));
}

OCIFSelect_EditForm::OCIFSelect_EditForm(OCNaroWrappers::OCIFSelect_Editor^ editor, OCNaroWrappers::OCTColStd_SequenceOfInteger^ nums, System::Boolean readonly, System::Boolean undoable, System::String^ label) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IFSelect_EditForm(new IFSelect_EditForm(*((Handle_IFSelect_Editor*)editor->Handle), *((TColStd_SequenceOfInteger*)nums->Handle), OCConverter::BooleanToStandardBoolean(readonly), OCConverter::BooleanToStandardBoolean(undoable), OCConverter::StringToStandardCString(label)));
}

 System::Boolean OCIFSelect_EditForm::EditKeepStatus()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->EditKeepStatus());
}

 System::String^ OCIFSelect_EditForm::Label()
{
  return OCConverter::StandardCStringToString((*((Handle_IFSelect_EditForm*)nativeHandle))->Label());
}

 System::Boolean OCIFSelect_EditForm::IsLoaded()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->IsLoaded());
}

 void OCIFSelect_EditForm::ClearData()
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->ClearData();
}

 void OCIFSelect_EditForm::SetData(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->SetData(*((Handle_Standard_Transient*)ent->Handle), *((Handle_Interface_InterfaceModel*)model->Handle));
}

 void OCIFSelect_EditForm::SetEntity(OCNaroWrappers::OCStandard_Transient^ ent)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->SetEntity(*((Handle_Standard_Transient*)ent->Handle));
}

 void OCIFSelect_EditForm::SetModel(OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->SetModel(*((Handle_Interface_InterfaceModel*)model->Handle));
}

OCStandard_Transient^ OCIFSelect_EditForm::Entity()
{
  Handle(Standard_Transient) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->Entity();
  return gcnew OCStandard_Transient(&tmp);
}

OCInterface_InterfaceModel^ OCIFSelect_EditForm::Model()
{
  Handle(Interface_InterfaceModel) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->Model();
  return gcnew OCInterface_InterfaceModel(&tmp);
}

OCIFSelect_Editor^ OCIFSelect_EditForm::Editor()
{
  Handle(IFSelect_Editor) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->Editor();
  return gcnew OCIFSelect_Editor(&tmp);
}

 System::Boolean OCIFSelect_EditForm::IsComplete()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->IsComplete());
}

 Standard_Integer OCIFSelect_EditForm::NbValues(System::Boolean editable)
{
  return (*((Handle_IFSelect_EditForm*)nativeHandle))->NbValues(OCConverter::BooleanToStandardBoolean(editable));
}

 Standard_Integer OCIFSelect_EditForm::NumberFromRank(Standard_Integer rank)
{
  return (*((Handle_IFSelect_EditForm*)nativeHandle))->NumberFromRank(rank);
}

 Standard_Integer OCIFSelect_EditForm::RankFromNumber(Standard_Integer number)
{
  return (*((Handle_IFSelect_EditForm*)nativeHandle))->RankFromNumber(number);
}

 Standard_Integer OCIFSelect_EditForm::NameNumber(System::String^ name)
{
  return (*((Handle_IFSelect_EditForm*)nativeHandle))->NameNumber(OCConverter::StringToStandardCString(name));
}

 Standard_Integer OCIFSelect_EditForm::NameRank(System::String^ name)
{
  return (*((Handle_IFSelect_EditForm*)nativeHandle))->NameRank(OCConverter::StringToStandardCString(name));
}

 void OCIFSelect_EditForm::LoadDefault()
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->LoadDefault();
}

 System::Boolean OCIFSelect_EditForm::LoadData(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->LoadData(*((Handle_Standard_Transient*)ent->Handle), *((Handle_Interface_InterfaceModel*)model->Handle)));
}

 System::Boolean OCIFSelect_EditForm::LoadEntity(OCNaroWrappers::OCStandard_Transient^ ent)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->LoadEntity(*((Handle_Standard_Transient*)ent->Handle)));
}

 System::Boolean OCIFSelect_EditForm::LoadModel(OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->LoadModel(*((Handle_Interface_InterfaceModel*)model->Handle)));
}

 System::Boolean OCIFSelect_EditForm::LoadData()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->LoadData());
}

OCIFSelect_ListEditor^ OCIFSelect_EditForm::ListEditor(Standard_Integer num)
{
  Handle(IFSelect_ListEditor) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->ListEditor(num);
  return gcnew OCIFSelect_ListEditor(&tmp);
}

 void OCIFSelect_EditForm::LoadValue(Standard_Integer num, OCNaroWrappers::OCTCollection_HAsciiString^ val)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->LoadValue(num, *((Handle_TCollection_HAsciiString*)val->Handle));
}

 void OCIFSelect_EditForm::LoadList(Standard_Integer num, OCNaroWrappers::OCTColStd_HSequenceOfHAsciiString^ list)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->LoadList(num, *((Handle_TColStd_HSequenceOfHAsciiString*)list->Handle));
}

OCTCollection_HAsciiString^ OCIFSelect_EditForm::OriginalValue(Standard_Integer num)
{
  Handle(TCollection_HAsciiString) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->OriginalValue(num);
  return gcnew OCTCollection_HAsciiString(&tmp);
}

OCTColStd_HSequenceOfHAsciiString^ OCIFSelect_EditForm::OriginalList(Standard_Integer num)
{
  Handle(TColStd_HSequenceOfHAsciiString) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->OriginalList(num);
  return gcnew OCTColStd_HSequenceOfHAsciiString(&tmp);
}

OCTCollection_HAsciiString^ OCIFSelect_EditForm::EditedValue(Standard_Integer num)
{
  Handle(TCollection_HAsciiString) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->EditedValue(num);
  return gcnew OCTCollection_HAsciiString(&tmp);
}

OCTColStd_HSequenceOfHAsciiString^ OCIFSelect_EditForm::EditedList(Standard_Integer num)
{
  Handle(TColStd_HSequenceOfHAsciiString) tmp = (*((Handle_IFSelect_EditForm*)nativeHandle))->EditedList(num);
  return gcnew OCTColStd_HSequenceOfHAsciiString(&tmp);
}

 System::Boolean OCIFSelect_EditForm::IsModified(Standard_Integer num)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->IsModified(num));
}

 System::Boolean OCIFSelect_EditForm::IsTouched(Standard_Integer num)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->IsTouched(num));
}

 System::Boolean OCIFSelect_EditForm::Modify(Standard_Integer num, OCNaroWrappers::OCTCollection_HAsciiString^ newval, System::Boolean enforce)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->Modify(num, *((Handle_TCollection_HAsciiString*)newval->Handle), OCConverter::BooleanToStandardBoolean(enforce)));
}

 System::Boolean OCIFSelect_EditForm::ModifyList(Standard_Integer num, OCNaroWrappers::OCIFSelect_ListEditor^ edited, System::Boolean enforce)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->ModifyList(num, *((Handle_IFSelect_ListEditor*)edited->Handle), OCConverter::BooleanToStandardBoolean(enforce)));
}

 System::Boolean OCIFSelect_EditForm::ModifyListValue(Standard_Integer num, OCNaroWrappers::OCTColStd_HSequenceOfHAsciiString^ list, System::Boolean enforce)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->ModifyListValue(num, *((Handle_TColStd_HSequenceOfHAsciiString*)list->Handle), OCConverter::BooleanToStandardBoolean(enforce)));
}

 System::Boolean OCIFSelect_EditForm::Touch(Standard_Integer num, OCNaroWrappers::OCTCollection_HAsciiString^ newval)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->Touch(num, *((Handle_TCollection_HAsciiString*)newval->Handle)));
}

 System::Boolean OCIFSelect_EditForm::TouchList(Standard_Integer num, OCNaroWrappers::OCTColStd_HSequenceOfHAsciiString^ newlist)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->TouchList(num, *((Handle_TColStd_HSequenceOfHAsciiString*)newlist->Handle)));
}

 Standard_Integer OCIFSelect_EditForm::NbTouched()
{
  return (*((Handle_IFSelect_EditForm*)nativeHandle))->NbTouched();
}

 void OCIFSelect_EditForm::ClearEdit(Standard_Integer num)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->ClearEdit(num);
}

 void OCIFSelect_EditForm::PrintDefs(OCNaroWrappers::OCMessage_Messenger^ S)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->PrintDefs(*((Handle_Message_Messenger*)S->Handle));
}

 void OCIFSelect_EditForm::PrintValues(OCNaroWrappers::OCMessage_Messenger^ S, Standard_Integer what, System::Boolean names, System::Boolean alsolist)
{
  (*((Handle_IFSelect_EditForm*)nativeHandle))->PrintValues(*((Handle_Message_Messenger*)S->Handle), what, OCConverter::BooleanToStandardBoolean(names), OCConverter::BooleanToStandardBoolean(alsolist));
}

 System::Boolean OCIFSelect_EditForm::Apply()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->Apply());
}

 System::Boolean OCIFSelect_EditForm::Recognize()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->Recognize());
}

 System::Boolean OCIFSelect_EditForm::ApplyData(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->ApplyData(*((Handle_Standard_Transient*)ent->Handle), *((Handle_Interface_InterfaceModel*)model->Handle)));
}

 System::Boolean OCIFSelect_EditForm::Undo()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IFSelect_EditForm*)nativeHandle))->Undo());
}


