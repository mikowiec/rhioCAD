// File generated by CPPExt (CPP file)
//

#include "TDataStd_Relation.h"
#include "../Converter.h"
#include "../Standard/Standard_GUID.h"
#include "../TDF/TDF_Label.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "../TDF/TDF_AttributeList.h"
#include "../TDF/TDF_Attribute.h"
#include "../TDF/TDF_RelocationTable.h"


using namespace OCNaroWrappers;

OCTDataStd_Relation::OCTDataStd_Relation(Handle(TDataStd_Relation)* nativeHandle) : OCTDF_Attribute((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TDataStd_Relation(*nativeHandle);
}

OCStandard_GUID^ OCTDataStd_Relation::GetID()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = TDataStd_Relation::GetID();
  return gcnew OCStandard_GUID(tmp);
}

OCTDataStd_Relation^ OCTDataStd_Relation::Set(OCNaroWrappers::OCTDF_Label^ label)
{
  Handle(TDataStd_Relation) tmp = TDataStd_Relation::Set(*((TDF_Label*)label->Handle));
  return gcnew OCTDataStd_Relation(&tmp);
}

OCTDataStd_Relation::OCTDataStd_Relation() : OCTDF_Attribute((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TDataStd_Relation(new TDataStd_Relation());
}

OCTCollection_ExtendedString^ OCTDataStd_Relation::Name()
{
  TCollection_ExtendedString* tmp = new TCollection_ExtendedString();
  *tmp = (*((Handle_TDataStd_Relation*)nativeHandle))->Name();
  return gcnew OCTCollection_ExtendedString(tmp);
}

 void OCTDataStd_Relation::SetRelation(OCNaroWrappers::OCTCollection_ExtendedString^ E)
{
  (*((Handle_TDataStd_Relation*)nativeHandle))->SetRelation(*((TCollection_ExtendedString*)E->Handle));
}

OCTCollection_ExtendedString^ OCTDataStd_Relation::GetRelation()
{
  TCollection_ExtendedString* tmp = new TCollection_ExtendedString();
  *tmp = (*((Handle_TDataStd_Relation*)nativeHandle))->GetRelation();
  return gcnew OCTCollection_ExtendedString(tmp);
}

OCTDF_AttributeList^ OCTDataStd_Relation::GetVariables()
{
  TDF_AttributeList* tmp = new TDF_AttributeList();
  *tmp = (*((Handle_TDataStd_Relation*)nativeHandle))->GetVariables();
  return gcnew OCTDF_AttributeList(tmp);
}

OCStandard_GUID^ OCTDataStd_Relation::ID()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = (*((Handle_TDataStd_Relation*)nativeHandle))->ID();
  return gcnew OCStandard_GUID(tmp);
}

 void OCTDataStd_Relation::Restore(OCNaroWrappers::OCTDF_Attribute^ With)
{
  (*((Handle_TDataStd_Relation*)nativeHandle))->Restore(*((Handle_TDF_Attribute*)With->Handle));
}

OCTDF_Attribute^ OCTDataStd_Relation::NewEmpty()
{
  Handle(TDF_Attribute) tmp = (*((Handle_TDataStd_Relation*)nativeHandle))->NewEmpty();
  return gcnew OCTDF_Attribute(&tmp);
}

 void OCTDataStd_Relation::Paste(OCNaroWrappers::OCTDF_Attribute^ Into, OCNaroWrappers::OCTDF_RelocationTable^ RT)
{
  (*((Handle_TDataStd_Relation*)nativeHandle))->Paste(*((Handle_TDF_Attribute*)Into->Handle), *((Handle_TDF_RelocationTable*)RT->Handle));
}

 Standard_OStream& OCTDataStd_Relation::Dump(Standard_OStream& anOS)
{
  return (*((Handle_TDataStd_Relation*)nativeHandle))->Dump(anOS);
}


