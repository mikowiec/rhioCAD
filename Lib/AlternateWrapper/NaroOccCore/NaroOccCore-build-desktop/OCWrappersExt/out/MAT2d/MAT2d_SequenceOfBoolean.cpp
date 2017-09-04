// File generated by CPPExt (CPP file)
//

#include "MAT2d_SequenceOfBoolean.h"
#include "../Converter.h"
#include "MAT2d_SequenceNodeOfSequenceOfBoolean.h"


using namespace OCNaroWrappers;

OCMAT2d_SequenceOfBoolean::OCMAT2d_SequenceOfBoolean(MAT2d_SequenceOfBoolean* nativeHandle) : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCMAT2d_SequenceOfBoolean::OCMAT2d_SequenceOfBoolean() : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  nativeHandle = new MAT2d_SequenceOfBoolean();
}

OCMAT2d_SequenceOfBoolean^ OCMAT2d_SequenceOfBoolean::Assign(OCNaroWrappers::OCMAT2d_SequenceOfBoolean^ Other)
{
  MAT2d_SequenceOfBoolean* tmp = new MAT2d_SequenceOfBoolean();
  *tmp = ((MAT2d_SequenceOfBoolean*)nativeHandle)->Assign(*((MAT2d_SequenceOfBoolean*)Other->Handle));
  return gcnew OCMAT2d_SequenceOfBoolean(tmp);
}

 void OCMAT2d_SequenceOfBoolean::Append(System::Boolean T)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->Append(OCConverter::BooleanToStandardBoolean(T));
}

 void OCMAT2d_SequenceOfBoolean::Append(OCNaroWrappers::OCMAT2d_SequenceOfBoolean^ S)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->Append(*((MAT2d_SequenceOfBoolean*)S->Handle));
}

 void OCMAT2d_SequenceOfBoolean::Prepend(System::Boolean T)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->Prepend(OCConverter::BooleanToStandardBoolean(T));
}

 void OCMAT2d_SequenceOfBoolean::Prepend(OCNaroWrappers::OCMAT2d_SequenceOfBoolean^ S)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->Prepend(*((MAT2d_SequenceOfBoolean*)S->Handle));
}

 void OCMAT2d_SequenceOfBoolean::InsertBefore(Standard_Integer Index, System::Boolean T)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->InsertBefore(Index, OCConverter::BooleanToStandardBoolean(T));
}

 void OCMAT2d_SequenceOfBoolean::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCMAT2d_SequenceOfBoolean^ S)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->InsertBefore(Index, *((MAT2d_SequenceOfBoolean*)S->Handle));
}

 void OCMAT2d_SequenceOfBoolean::InsertAfter(Standard_Integer Index, System::Boolean T)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->InsertAfter(Index, OCConverter::BooleanToStandardBoolean(T));
}

 void OCMAT2d_SequenceOfBoolean::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCMAT2d_SequenceOfBoolean^ S)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->InsertAfter(Index, *((MAT2d_SequenceOfBoolean*)S->Handle));
}

 System::Boolean OCMAT2d_SequenceOfBoolean::First()
{
  return OCConverter::StandardBooleanToBoolean(((MAT2d_SequenceOfBoolean*)nativeHandle)->First());
}

 System::Boolean OCMAT2d_SequenceOfBoolean::Last()
{
  return OCConverter::StandardBooleanToBoolean(((MAT2d_SequenceOfBoolean*)nativeHandle)->Last());
}

 void OCMAT2d_SequenceOfBoolean::Split(Standard_Integer Index, OCNaroWrappers::OCMAT2d_SequenceOfBoolean^ Sub)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->Split(Index, *((MAT2d_SequenceOfBoolean*)Sub->Handle));
}

 System::Boolean OCMAT2d_SequenceOfBoolean::Value(Standard_Integer Index)
{
  return OCConverter::StandardBooleanToBoolean(((MAT2d_SequenceOfBoolean*)nativeHandle)->Value(Index));
}

 void OCMAT2d_SequenceOfBoolean::SetValue(Standard_Integer Index, System::Boolean I)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->SetValue(Index, OCConverter::BooleanToStandardBoolean(I));
}

 System::Boolean OCMAT2d_SequenceOfBoolean::ChangeValue(Standard_Integer Index)
{
  return OCConverter::StandardBooleanToBoolean(((MAT2d_SequenceOfBoolean*)nativeHandle)->ChangeValue(Index));
}

 void OCMAT2d_SequenceOfBoolean::Remove(Standard_Integer Index)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->Remove(Index);
}

 void OCMAT2d_SequenceOfBoolean::Remove(Standard_Integer FromIndex, Standard_Integer ToIndex)
{
  ((MAT2d_SequenceOfBoolean*)nativeHandle)->Remove(FromIndex, ToIndex);
}


