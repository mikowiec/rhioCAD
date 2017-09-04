// File generated by CPPExt (CPP file)
//

#include "TDataStd_TreeNode.h"
#include "../Converter.h"
#include "TDataStd_ChildNodeIterator.h"
#include "../TDF/TDF_Label.h"
#include "../Standard/Standard_GUID.h"
#include "../TDF/TDF_AttributeDelta.h"
#include "../TDF/TDF_Attribute.h"
#include "../TDF/TDF_RelocationTable.h"
#include "../TDF/TDF_DataSet.h"


using namespace OCNaroWrappers;

OCTDataStd_TreeNode::OCTDataStd_TreeNode(Handle(TDataStd_TreeNode)* nativeHandle) : OCTDF_Attribute((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TDataStd_TreeNode(*nativeHandle);
}

 System::Boolean OCTDataStd_TreeNode::Find(OCNaroWrappers::OCTDF_Label^ L, OCNaroWrappers::OCTDataStd_TreeNode^ T)
{
  return OCConverter::StandardBooleanToBoolean(TDataStd_TreeNode::Find(*((TDF_Label*)L->Handle), *((Handle_TDataStd_TreeNode*)T->Handle)));
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::Set(OCNaroWrappers::OCTDF_Label^ L)
{
  Handle(TDataStd_TreeNode) tmp = TDataStd_TreeNode::Set(*((TDF_Label*)L->Handle));
  return gcnew OCTDataStd_TreeNode(&tmp);
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::Set(OCNaroWrappers::OCTDF_Label^ L, OCNaroWrappers::OCStandard_GUID^ ExplicitTreeID)
{
  Handle(TDataStd_TreeNode) tmp = TDataStd_TreeNode::Set(*((TDF_Label*)L->Handle), *((Standard_GUID*)ExplicitTreeID->Handle));
  return gcnew OCTDataStd_TreeNode(&tmp);
}

OCStandard_GUID^ OCTDataStd_TreeNode::GetDefaultTreeID()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = TDataStd_TreeNode::GetDefaultTreeID();
  return gcnew OCStandard_GUID(tmp);
}

OCTDataStd_TreeNode::OCTDataStd_TreeNode() : OCTDF_Attribute((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TDataStd_TreeNode(new TDataStd_TreeNode());
}

 System::Boolean OCTDataStd_TreeNode::Append(OCNaroWrappers::OCTDataStd_TreeNode^ Child)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->Append(*((Handle_TDataStd_TreeNode*)Child->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::Prepend(OCNaroWrappers::OCTDataStd_TreeNode^ Child)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->Prepend(*((Handle_TDataStd_TreeNode*)Child->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::InsertBefore(OCNaroWrappers::OCTDataStd_TreeNode^ Node)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->InsertBefore(*((Handle_TDataStd_TreeNode*)Node->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::InsertAfter(OCNaroWrappers::OCTDataStd_TreeNode^ Node)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->InsertAfter(*((Handle_TDataStd_TreeNode*)Node->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::Remove()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->Remove());
}

 Standard_Integer OCTDataStd_TreeNode::Depth()
{
  return (*((Handle_TDataStd_TreeNode*)nativeHandle))->Depth();
}

 Standard_Integer OCTDataStd_TreeNode::NbChildren(System::Boolean allLevels)
{
  return (*((Handle_TDataStd_TreeNode*)nativeHandle))->NbChildren(OCConverter::BooleanToStandardBoolean(allLevels));
}

 System::Boolean OCTDataStd_TreeNode::IsAscendant(OCNaroWrappers::OCTDataStd_TreeNode^ of)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->IsAscendant(*((Handle_TDataStd_TreeNode*)of->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::IsDescendant(OCNaroWrappers::OCTDataStd_TreeNode^ of)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->IsDescendant(*((Handle_TDataStd_TreeNode*)of->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::IsRoot()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->IsRoot());
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::Root()
{
  Handle(TDataStd_TreeNode) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->Root();
  return gcnew OCTDataStd_TreeNode(&tmp);
}

 System::Boolean OCTDataStd_TreeNode::IsFather(OCNaroWrappers::OCTDataStd_TreeNode^ of)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->IsFather(*((Handle_TDataStd_TreeNode*)of->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::IsChild(OCNaroWrappers::OCTDataStd_TreeNode^ of)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->IsChild(*((Handle_TDataStd_TreeNode*)of->Handle)));
}

 System::Boolean OCTDataStd_TreeNode::HasFather()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->HasFather());
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::Father()
{
  Handle(TDataStd_TreeNode) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->Father();
  return gcnew OCTDataStd_TreeNode(&tmp);
}

 System::Boolean OCTDataStd_TreeNode::HasNext()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->HasNext());
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::Next()
{
  Handle(TDataStd_TreeNode) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->Next();
  return gcnew OCTDataStd_TreeNode(&tmp);
}

 System::Boolean OCTDataStd_TreeNode::HasPrevious()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->HasPrevious());
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::Previous()
{
  Handle(TDataStd_TreeNode) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->Previous();
  return gcnew OCTDataStd_TreeNode(&tmp);
}

 System::Boolean OCTDataStd_TreeNode::HasFirst()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->HasFirst());
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::First()
{
  Handle(TDataStd_TreeNode) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->First();
  return gcnew OCTDataStd_TreeNode(&tmp);
}

 System::Boolean OCTDataStd_TreeNode::HasLast()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->HasLast());
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::Last()
{
  Handle(TDataStd_TreeNode) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->Last();
  return gcnew OCTDataStd_TreeNode(&tmp);
}

OCTDataStd_TreeNode^ OCTDataStd_TreeNode::FindLast()
{
  Handle(TDataStd_TreeNode) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->FindLast();
  return gcnew OCTDataStd_TreeNode(&tmp);
}

 void OCTDataStd_TreeNode::SetTreeID(OCNaroWrappers::OCStandard_GUID^ explicitID)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->SetTreeID(*((Standard_GUID*)explicitID->Handle));
}

 void OCTDataStd_TreeNode::SetFather(OCNaroWrappers::OCTDataStd_TreeNode^ F)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->SetFather(*((Handle_TDataStd_TreeNode*)F->Handle));
}

 void OCTDataStd_TreeNode::SetNext(OCNaroWrappers::OCTDataStd_TreeNode^ F)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->SetNext(*((Handle_TDataStd_TreeNode*)F->Handle));
}

 void OCTDataStd_TreeNode::SetPrevious(OCNaroWrappers::OCTDataStd_TreeNode^ F)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->SetPrevious(*((Handle_TDataStd_TreeNode*)F->Handle));
}

 void OCTDataStd_TreeNode::SetFirst(OCNaroWrappers::OCTDataStd_TreeNode^ F)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->SetFirst(*((Handle_TDataStd_TreeNode*)F->Handle));
}

 void OCTDataStd_TreeNode::SetLast(OCNaroWrappers::OCTDataStd_TreeNode^ F)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->SetLast(*((Handle_TDataStd_TreeNode*)F->Handle));
}

 void OCTDataStd_TreeNode::AfterAddition()
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->AfterAddition();
}

 void OCTDataStd_TreeNode::BeforeForget()
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->BeforeForget();
}

 void OCTDataStd_TreeNode::AfterResume()
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->AfterResume();
}

 System::Boolean OCTDataStd_TreeNode::BeforeUndo(OCNaroWrappers::OCTDF_AttributeDelta^ anAttDelta, System::Boolean forceIt)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->BeforeUndo(*((Handle_TDF_AttributeDelta*)anAttDelta->Handle), OCConverter::BooleanToStandardBoolean(forceIt)));
}

 System::Boolean OCTDataStd_TreeNode::AfterUndo(OCNaroWrappers::OCTDF_AttributeDelta^ anAttDelta, System::Boolean forceIt)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_TreeNode*)nativeHandle))->AfterUndo(*((Handle_TDF_AttributeDelta*)anAttDelta->Handle), OCConverter::BooleanToStandardBoolean(forceIt)));
}

OCStandard_GUID^ OCTDataStd_TreeNode::ID()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->ID();
  return gcnew OCStandard_GUID(tmp);
}

 void OCTDataStd_TreeNode::Restore(OCNaroWrappers::OCTDF_Attribute^ with)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->Restore(*((Handle_TDF_Attribute*)with->Handle));
}

 void OCTDataStd_TreeNode::Paste(OCNaroWrappers::OCTDF_Attribute^ into, OCNaroWrappers::OCTDF_RelocationTable^ RT)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->Paste(*((Handle_TDF_Attribute*)into->Handle), *((Handle_TDF_RelocationTable*)RT->Handle));
}

OCTDF_Attribute^ OCTDataStd_TreeNode::NewEmpty()
{
  Handle(TDF_Attribute) tmp = (*((Handle_TDataStd_TreeNode*)nativeHandle))->NewEmpty();
  return gcnew OCTDF_Attribute(&tmp);
}

 void OCTDataStd_TreeNode::References(OCNaroWrappers::OCTDF_DataSet^ aDataSet)
{
  (*((Handle_TDataStd_TreeNode*)nativeHandle))->References(*((Handle_TDF_DataSet*)aDataSet->Handle));
}

 Standard_OStream& OCTDataStd_TreeNode::Dump(Standard_OStream& anOS)
{
  return (*((Handle_TDataStd_TreeNode*)nativeHandle))->Dump(anOS);
}


