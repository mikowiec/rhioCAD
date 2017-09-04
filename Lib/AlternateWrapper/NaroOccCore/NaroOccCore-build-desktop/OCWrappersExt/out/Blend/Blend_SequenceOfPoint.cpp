// File generated by CPPExt (CPP file)
//

#include "Blend_SequenceOfPoint.h"
#include "../Converter.h"
#include "Blend_Point.h"
#include "Blend_SequenceNodeOfSequenceOfPoint.h"


using namespace OCNaroWrappers;

OCBlend_SequenceOfPoint::OCBlend_SequenceOfPoint(Blend_SequenceOfPoint* nativeHandle) : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBlend_SequenceOfPoint::OCBlend_SequenceOfPoint() : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  nativeHandle = new Blend_SequenceOfPoint();
}

OCBlend_SequenceOfPoint^ OCBlend_SequenceOfPoint::Assign(OCNaroWrappers::OCBlend_SequenceOfPoint^ Other)
{
  Blend_SequenceOfPoint* tmp = new Blend_SequenceOfPoint();
  *tmp = ((Blend_SequenceOfPoint*)nativeHandle)->Assign(*((Blend_SequenceOfPoint*)Other->Handle));
  return gcnew OCBlend_SequenceOfPoint(tmp);
}

 void OCBlend_SequenceOfPoint::Append(OCNaroWrappers::OCBlend_Point^ T)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->Append(*((Blend_Point*)T->Handle));
}

 void OCBlend_SequenceOfPoint::Append(OCNaroWrappers::OCBlend_SequenceOfPoint^ S)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->Append(*((Blend_SequenceOfPoint*)S->Handle));
}

 void OCBlend_SequenceOfPoint::Prepend(OCNaroWrappers::OCBlend_Point^ T)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->Prepend(*((Blend_Point*)T->Handle));
}

 void OCBlend_SequenceOfPoint::Prepend(OCNaroWrappers::OCBlend_SequenceOfPoint^ S)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->Prepend(*((Blend_SequenceOfPoint*)S->Handle));
}

 void OCBlend_SequenceOfPoint::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCBlend_Point^ T)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->InsertBefore(Index, *((Blend_Point*)T->Handle));
}

 void OCBlend_SequenceOfPoint::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCBlend_SequenceOfPoint^ S)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->InsertBefore(Index, *((Blend_SequenceOfPoint*)S->Handle));
}

 void OCBlend_SequenceOfPoint::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCBlend_Point^ T)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->InsertAfter(Index, *((Blend_Point*)T->Handle));
}

 void OCBlend_SequenceOfPoint::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCBlend_SequenceOfPoint^ S)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->InsertAfter(Index, *((Blend_SequenceOfPoint*)S->Handle));
}

OCBlend_Point^ OCBlend_SequenceOfPoint::First()
{
  Blend_Point* tmp = new Blend_Point();
  *tmp = ((Blend_SequenceOfPoint*)nativeHandle)->First();
  return gcnew OCBlend_Point(tmp);
}

OCBlend_Point^ OCBlend_SequenceOfPoint::Last()
{
  Blend_Point* tmp = new Blend_Point();
  *tmp = ((Blend_SequenceOfPoint*)nativeHandle)->Last();
  return gcnew OCBlend_Point(tmp);
}

 void OCBlend_SequenceOfPoint::Split(Standard_Integer Index, OCNaroWrappers::OCBlend_SequenceOfPoint^ Sub)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->Split(Index, *((Blend_SequenceOfPoint*)Sub->Handle));
}

OCBlend_Point^ OCBlend_SequenceOfPoint::Value(Standard_Integer Index)
{
  Blend_Point* tmp = new Blend_Point();
  *tmp = ((Blend_SequenceOfPoint*)nativeHandle)->Value(Index);
  return gcnew OCBlend_Point(tmp);
}

 void OCBlend_SequenceOfPoint::SetValue(Standard_Integer Index, OCNaroWrappers::OCBlend_Point^ I)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->SetValue(Index, *((Blend_Point*)I->Handle));
}

OCBlend_Point^ OCBlend_SequenceOfPoint::ChangeValue(Standard_Integer Index)
{
  Blend_Point* tmp = new Blend_Point();
  *tmp = ((Blend_SequenceOfPoint*)nativeHandle)->ChangeValue(Index);
  return gcnew OCBlend_Point(tmp);
}

 void OCBlend_SequenceOfPoint::Remove(Standard_Integer Index)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->Remove(Index);
}

 void OCBlend_SequenceOfPoint::Remove(Standard_Integer FromIndex, Standard_Integer ToIndex)
{
  ((Blend_SequenceOfPoint*)nativeHandle)->Remove(FromIndex, ToIndex);
}


