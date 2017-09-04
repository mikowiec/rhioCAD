// File generated by CPPExt (CPP file)
//

#include "LProp_SequenceOfCIType.h"
#include "../Converter.h"
#include "LProp_SequenceNodeOfSequenceOfCIType.h"


using namespace OCNaroWrappers;

OCLProp_SequenceOfCIType::OCLProp_SequenceOfCIType(LProp_SequenceOfCIType* nativeHandle) : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCLProp_SequenceOfCIType::OCLProp_SequenceOfCIType() : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  nativeHandle = new LProp_SequenceOfCIType();
}

OCLProp_SequenceOfCIType^ OCLProp_SequenceOfCIType::Assign(OCNaroWrappers::OCLProp_SequenceOfCIType^ Other)
{
  LProp_SequenceOfCIType* tmp = new LProp_SequenceOfCIType();
  *tmp = ((LProp_SequenceOfCIType*)nativeHandle)->Assign(*((LProp_SequenceOfCIType*)Other->Handle));
  return gcnew OCLProp_SequenceOfCIType(tmp);
}

 void OCLProp_SequenceOfCIType::Append(OCLProp_CIType T)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->Append((LProp_CIType)T);
}

 void OCLProp_SequenceOfCIType::Append(OCNaroWrappers::OCLProp_SequenceOfCIType^ S)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->Append(*((LProp_SequenceOfCIType*)S->Handle));
}

 void OCLProp_SequenceOfCIType::Prepend(OCLProp_CIType T)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->Prepend((LProp_CIType)T);
}

 void OCLProp_SequenceOfCIType::Prepend(OCNaroWrappers::OCLProp_SequenceOfCIType^ S)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->Prepend(*((LProp_SequenceOfCIType*)S->Handle));
}

 void OCLProp_SequenceOfCIType::InsertBefore(Standard_Integer Index, OCLProp_CIType T)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->InsertBefore(Index, (LProp_CIType)T);
}

 void OCLProp_SequenceOfCIType::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCLProp_SequenceOfCIType^ S)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->InsertBefore(Index, *((LProp_SequenceOfCIType*)S->Handle));
}

 void OCLProp_SequenceOfCIType::InsertAfter(Standard_Integer Index, OCLProp_CIType T)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->InsertAfter(Index, (LProp_CIType)T);
}

 void OCLProp_SequenceOfCIType::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCLProp_SequenceOfCIType^ S)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->InsertAfter(Index, *((LProp_SequenceOfCIType*)S->Handle));
}

 OCLProp_CIType OCLProp_SequenceOfCIType::First()
{
  return (OCLProp_CIType)(((LProp_SequenceOfCIType*)nativeHandle)->First());
}

 OCLProp_CIType OCLProp_SequenceOfCIType::Last()
{
  return (OCLProp_CIType)(((LProp_SequenceOfCIType*)nativeHandle)->Last());
}

 void OCLProp_SequenceOfCIType::Split(Standard_Integer Index, OCNaroWrappers::OCLProp_SequenceOfCIType^ Sub)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->Split(Index, *((LProp_SequenceOfCIType*)Sub->Handle));
}

 OCLProp_CIType OCLProp_SequenceOfCIType::Value(Standard_Integer Index)
{
  return (OCLProp_CIType)(((LProp_SequenceOfCIType*)nativeHandle)->Value(Index));
}

 void OCLProp_SequenceOfCIType::SetValue(Standard_Integer Index, OCLProp_CIType I)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->SetValue(Index, (LProp_CIType)I);
}

 OCLProp_CIType OCLProp_SequenceOfCIType::ChangeValue(Standard_Integer Index)
{
  return (OCLProp_CIType)(((LProp_SequenceOfCIType*)nativeHandle)->ChangeValue(Index));
}

 void OCLProp_SequenceOfCIType::Remove(Standard_Integer Index)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->Remove(Index);
}

 void OCLProp_SequenceOfCIType::Remove(Standard_Integer FromIndex, Standard_Integer ToIndex)
{
  ((LProp_SequenceOfCIType*)nativeHandle)->Remove(FromIndex, ToIndex);
}


