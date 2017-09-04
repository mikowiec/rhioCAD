// File generated by CPPExt (CPP file)
//

#include "TColStd_SequenceOfBoolean.h"
#include "../Converter.h"
#include "TColStd_SequenceNodeOfSequenceOfBoolean.h"


using namespace OCNaroWrappers;

OCTColStd_SequenceOfBoolean::OCTColStd_SequenceOfBoolean(TColStd_SequenceOfBoolean* nativeHandle) : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTColStd_SequenceOfBoolean::OCTColStd_SequenceOfBoolean() : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  nativeHandle = new TColStd_SequenceOfBoolean();
}

OCTColStd_SequenceOfBoolean^ OCTColStd_SequenceOfBoolean::Assign(OCNaroWrappers::OCTColStd_SequenceOfBoolean^ Other)
{
  TColStd_SequenceOfBoolean* tmp = new TColStd_SequenceOfBoolean();
  *tmp = ((TColStd_SequenceOfBoolean*)nativeHandle)->Assign(*((TColStd_SequenceOfBoolean*)Other->Handle));
  return gcnew OCTColStd_SequenceOfBoolean(tmp);
}

 void OCTColStd_SequenceOfBoolean::Append(System::Boolean T)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->Append(OCConverter::BooleanToStandardBoolean(T));
}

 void OCTColStd_SequenceOfBoolean::Append(OCNaroWrappers::OCTColStd_SequenceOfBoolean^ S)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->Append(*((TColStd_SequenceOfBoolean*)S->Handle));
}

 void OCTColStd_SequenceOfBoolean::Prepend(System::Boolean T)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->Prepend(OCConverter::BooleanToStandardBoolean(T));
}

 void OCTColStd_SequenceOfBoolean::Prepend(OCNaroWrappers::OCTColStd_SequenceOfBoolean^ S)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->Prepend(*((TColStd_SequenceOfBoolean*)S->Handle));
}

 void OCTColStd_SequenceOfBoolean::InsertBefore(Standard_Integer Index, System::Boolean T)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->InsertBefore(Index, OCConverter::BooleanToStandardBoolean(T));
}

 void OCTColStd_SequenceOfBoolean::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCTColStd_SequenceOfBoolean^ S)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->InsertBefore(Index, *((TColStd_SequenceOfBoolean*)S->Handle));
}

 void OCTColStd_SequenceOfBoolean::InsertAfter(Standard_Integer Index, System::Boolean T)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->InsertAfter(Index, OCConverter::BooleanToStandardBoolean(T));
}

 void OCTColStd_SequenceOfBoolean::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCTColStd_SequenceOfBoolean^ S)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->InsertAfter(Index, *((TColStd_SequenceOfBoolean*)S->Handle));
}

 System::Boolean OCTColStd_SequenceOfBoolean::First()
{
  return OCConverter::StandardBooleanToBoolean(((TColStd_SequenceOfBoolean*)nativeHandle)->First());
}

 System::Boolean OCTColStd_SequenceOfBoolean::Last()
{
  return OCConverter::StandardBooleanToBoolean(((TColStd_SequenceOfBoolean*)nativeHandle)->Last());
}

 void OCTColStd_SequenceOfBoolean::Split(Standard_Integer Index, OCNaroWrappers::OCTColStd_SequenceOfBoolean^ Sub)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->Split(Index, *((TColStd_SequenceOfBoolean*)Sub->Handle));
}

 System::Boolean OCTColStd_SequenceOfBoolean::Value(Standard_Integer Index)
{
  return OCConverter::StandardBooleanToBoolean(((TColStd_SequenceOfBoolean*)nativeHandle)->Value(Index));
}

 void OCTColStd_SequenceOfBoolean::SetValue(Standard_Integer Index, System::Boolean I)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->SetValue(Index, OCConverter::BooleanToStandardBoolean(I));
}

 System::Boolean OCTColStd_SequenceOfBoolean::ChangeValue(Standard_Integer Index)
{
  return OCConverter::StandardBooleanToBoolean(((TColStd_SequenceOfBoolean*)nativeHandle)->ChangeValue(Index));
}

 void OCTColStd_SequenceOfBoolean::Remove(Standard_Integer Index)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->Remove(Index);
}

 void OCTColStd_SequenceOfBoolean::Remove(Standard_Integer FromIndex, Standard_Integer ToIndex)
{
  ((TColStd_SequenceOfBoolean*)nativeHandle)->Remove(FromIndex, ToIndex);
}

