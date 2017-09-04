// File generated by CPPExt (CPP file)
//

#include "TColStd_HSequenceOfExtendedString.h"
#include "../Converter.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "TColStd_SequenceOfExtendedString.h"


using namespace OCNaroWrappers;

OCTColStd_HSequenceOfExtendedString::OCTColStd_HSequenceOfExtendedString(Handle(TColStd_HSequenceOfExtendedString)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TColStd_HSequenceOfExtendedString(*nativeHandle);
}

OCTColStd_HSequenceOfExtendedString::OCTColStd_HSequenceOfExtendedString() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TColStd_HSequenceOfExtendedString(new TColStd_HSequenceOfExtendedString());
}

 System::Boolean OCTColStd_HSequenceOfExtendedString::IsEmpty()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->IsEmpty());
}

 Standard_Integer OCTColStd_HSequenceOfExtendedString::Length()
{
  return (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Length();
}

 void OCTColStd_HSequenceOfExtendedString::Clear()
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Clear();
}

 void OCTColStd_HSequenceOfExtendedString::Append(OCNaroWrappers::OCTCollection_ExtendedString^ anItem)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Append(*((TCollection_ExtendedString*)anItem->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::Append(OCNaroWrappers::OCTColStd_HSequenceOfExtendedString^ aSequence)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Append(*((Handle_TColStd_HSequenceOfExtendedString*)aSequence->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::Prepend(OCNaroWrappers::OCTCollection_ExtendedString^ anItem)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Prepend(*((TCollection_ExtendedString*)anItem->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::Prepend(OCNaroWrappers::OCTColStd_HSequenceOfExtendedString^ aSequence)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Prepend(*((Handle_TColStd_HSequenceOfExtendedString*)aSequence->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::Reverse()
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Reverse();
}

 void OCTColStd_HSequenceOfExtendedString::InsertBefore(Standard_Integer anIndex, OCNaroWrappers::OCTCollection_ExtendedString^ anItem)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->InsertBefore(anIndex, *((TCollection_ExtendedString*)anItem->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::InsertBefore(Standard_Integer anIndex, OCNaroWrappers::OCTColStd_HSequenceOfExtendedString^ aSequence)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->InsertBefore(anIndex, *((Handle_TColStd_HSequenceOfExtendedString*)aSequence->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::InsertAfter(Standard_Integer anIndex, OCNaroWrappers::OCTCollection_ExtendedString^ anItem)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->InsertAfter(anIndex, *((TCollection_ExtendedString*)anItem->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::InsertAfter(Standard_Integer anIndex, OCNaroWrappers::OCTColStd_HSequenceOfExtendedString^ aSequence)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->InsertAfter(anIndex, *((Handle_TColStd_HSequenceOfExtendedString*)aSequence->Handle));
}

 void OCTColStd_HSequenceOfExtendedString::Exchange(Standard_Integer anIndex, Standard_Integer anOtherIndex)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Exchange(anIndex, anOtherIndex);
}

OCTColStd_HSequenceOfExtendedString^ OCTColStd_HSequenceOfExtendedString::Split(Standard_Integer anIndex)
{
  Handle(TColStd_HSequenceOfExtendedString) tmp = (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Split(anIndex);
  return gcnew OCTColStd_HSequenceOfExtendedString(&tmp);
}

 void OCTColStd_HSequenceOfExtendedString::SetValue(Standard_Integer anIndex, OCNaroWrappers::OCTCollection_ExtendedString^ anItem)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->SetValue(anIndex, *((TCollection_ExtendedString*)anItem->Handle));
}

OCTCollection_ExtendedString^ OCTColStd_HSequenceOfExtendedString::Value(Standard_Integer anIndex)
{
  TCollection_ExtendedString* tmp = new TCollection_ExtendedString();
  *tmp = (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Value(anIndex);
  return gcnew OCTCollection_ExtendedString(tmp);
}

OCTCollection_ExtendedString^ OCTColStd_HSequenceOfExtendedString::ChangeValue(Standard_Integer anIndex)
{
  TCollection_ExtendedString* tmp = new TCollection_ExtendedString();
  *tmp = (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->ChangeValue(anIndex);
  return gcnew OCTCollection_ExtendedString(tmp);
}

 void OCTColStd_HSequenceOfExtendedString::Remove(Standard_Integer anIndex)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Remove(anIndex);
}

 void OCTColStd_HSequenceOfExtendedString::Remove(Standard_Integer fromIndex, Standard_Integer toIndex)
{
  (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Remove(fromIndex, toIndex);
}

OCTColStd_SequenceOfExtendedString^ OCTColStd_HSequenceOfExtendedString::Sequence()
{
  TColStd_SequenceOfExtendedString* tmp = new TColStd_SequenceOfExtendedString();
  *tmp = (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->Sequence();
  return gcnew OCTColStd_SequenceOfExtendedString(tmp);
}

OCTColStd_SequenceOfExtendedString^ OCTColStd_HSequenceOfExtendedString::ChangeSequence()
{
  TColStd_SequenceOfExtendedString* tmp = new TColStd_SequenceOfExtendedString();
  *tmp = (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->ChangeSequence();
  return gcnew OCTColStd_SequenceOfExtendedString(tmp);
}

OCTColStd_HSequenceOfExtendedString^ OCTColStd_HSequenceOfExtendedString::ShallowCopy()
{
  Handle(TColStd_HSequenceOfExtendedString) tmp = (*((Handle_TColStd_HSequenceOfExtendedString*)nativeHandle))->ShallowCopy();
  return gcnew OCTColStd_HSequenceOfExtendedString(&tmp);
}


