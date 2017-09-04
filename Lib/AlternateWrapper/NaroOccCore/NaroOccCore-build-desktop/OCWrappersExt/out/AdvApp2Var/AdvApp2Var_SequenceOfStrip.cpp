// File generated by CPPExt (CPP file)
//

#include "AdvApp2Var_SequenceOfStrip.h"
#include "../Converter.h"
#include "AdvApp2Var_Strip.h"
#include "AdvApp2Var_SequenceNodeOfSequenceOfStrip.h"


using namespace OCNaroWrappers;

OCAdvApp2Var_SequenceOfStrip::OCAdvApp2Var_SequenceOfStrip(AdvApp2Var_SequenceOfStrip* nativeHandle) : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCAdvApp2Var_SequenceOfStrip::OCAdvApp2Var_SequenceOfStrip() : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  nativeHandle = new AdvApp2Var_SequenceOfStrip();
}

OCAdvApp2Var_SequenceOfStrip^ OCAdvApp2Var_SequenceOfStrip::Assign(OCNaroWrappers::OCAdvApp2Var_SequenceOfStrip^ Other)
{
  AdvApp2Var_SequenceOfStrip* tmp = new AdvApp2Var_SequenceOfStrip();
  *tmp = ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Assign(*((AdvApp2Var_SequenceOfStrip*)Other->Handle));
  return gcnew OCAdvApp2Var_SequenceOfStrip(tmp);
}

 void OCAdvApp2Var_SequenceOfStrip::Append(OCNaroWrappers::OCAdvApp2Var_Strip^ T)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Append(*((AdvApp2Var_Strip*)T->Handle));
}

 void OCAdvApp2Var_SequenceOfStrip::Append(OCNaroWrappers::OCAdvApp2Var_SequenceOfStrip^ S)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Append(*((AdvApp2Var_SequenceOfStrip*)S->Handle));
}

 void OCAdvApp2Var_SequenceOfStrip::Prepend(OCNaroWrappers::OCAdvApp2Var_Strip^ T)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Prepend(*((AdvApp2Var_Strip*)T->Handle));
}

 void OCAdvApp2Var_SequenceOfStrip::Prepend(OCNaroWrappers::OCAdvApp2Var_SequenceOfStrip^ S)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Prepend(*((AdvApp2Var_SequenceOfStrip*)S->Handle));
}

 void OCAdvApp2Var_SequenceOfStrip::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCAdvApp2Var_Strip^ T)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->InsertBefore(Index, *((AdvApp2Var_Strip*)T->Handle));
}

 void OCAdvApp2Var_SequenceOfStrip::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCAdvApp2Var_SequenceOfStrip^ S)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->InsertBefore(Index, *((AdvApp2Var_SequenceOfStrip*)S->Handle));
}

 void OCAdvApp2Var_SequenceOfStrip::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCAdvApp2Var_Strip^ T)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->InsertAfter(Index, *((AdvApp2Var_Strip*)T->Handle));
}

 void OCAdvApp2Var_SequenceOfStrip::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCAdvApp2Var_SequenceOfStrip^ S)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->InsertAfter(Index, *((AdvApp2Var_SequenceOfStrip*)S->Handle));
}

OCAdvApp2Var_Strip^ OCAdvApp2Var_SequenceOfStrip::First()
{
  AdvApp2Var_Strip* tmp = new AdvApp2Var_Strip();
  *tmp = ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->First();
  return gcnew OCAdvApp2Var_Strip(tmp);
}

OCAdvApp2Var_Strip^ OCAdvApp2Var_SequenceOfStrip::Last()
{
  AdvApp2Var_Strip* tmp = new AdvApp2Var_Strip();
  *tmp = ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Last();
  return gcnew OCAdvApp2Var_Strip(tmp);
}

 void OCAdvApp2Var_SequenceOfStrip::Split(Standard_Integer Index, OCNaroWrappers::OCAdvApp2Var_SequenceOfStrip^ Sub)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Split(Index, *((AdvApp2Var_SequenceOfStrip*)Sub->Handle));
}

OCAdvApp2Var_Strip^ OCAdvApp2Var_SequenceOfStrip::Value(Standard_Integer Index)
{
  AdvApp2Var_Strip* tmp = new AdvApp2Var_Strip();
  *tmp = ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Value(Index);
  return gcnew OCAdvApp2Var_Strip(tmp);
}

 void OCAdvApp2Var_SequenceOfStrip::SetValue(Standard_Integer Index, OCNaroWrappers::OCAdvApp2Var_Strip^ I)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->SetValue(Index, *((AdvApp2Var_Strip*)I->Handle));
}

OCAdvApp2Var_Strip^ OCAdvApp2Var_SequenceOfStrip::ChangeValue(Standard_Integer Index)
{
  AdvApp2Var_Strip* tmp = new AdvApp2Var_Strip();
  *tmp = ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->ChangeValue(Index);
  return gcnew OCAdvApp2Var_Strip(tmp);
}

 void OCAdvApp2Var_SequenceOfStrip::Remove(Standard_Integer Index)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Remove(Index);
}

 void OCAdvApp2Var_SequenceOfStrip::Remove(Standard_Integer FromIndex, Standard_Integer ToIndex)
{
  ((AdvApp2Var_SequenceOfStrip*)nativeHandle)->Remove(FromIndex, ToIndex);
}


