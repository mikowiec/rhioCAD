// File generated by CPPExt (CPP file)
//

#include "BOPTools_ListOfCommonBlock.h"
#include "../Converter.h"
#include "BOPTools_ListIteratorOfListOfCommonBlock.h"
#include "BOPTools_CommonBlock.h"
#include "BOPTools_ListNodeOfListOfCommonBlock.h"


using namespace OCNaroWrappers;

OCBOPTools_ListOfCommonBlock::OCBOPTools_ListOfCommonBlock(BOPTools_ListOfCommonBlock* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCBOPTools_ListOfCommonBlock::OCBOPTools_ListOfCommonBlock() 
{
  nativeHandle = new BOPTools_ListOfCommonBlock();
}

 void OCBOPTools_ListOfCommonBlock::Assign(OCNaroWrappers::OCBOPTools_ListOfCommonBlock^ Other)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Assign(*((BOPTools_ListOfCommonBlock*)Other->Handle));
}

 Standard_Integer OCBOPTools_ListOfCommonBlock::Extent()
{
  return ((BOPTools_ListOfCommonBlock*)nativeHandle)->Extent();
}

 System::Boolean OCBOPTools_ListOfCommonBlock::IsEmpty()
{
  return OCConverter::StandardBooleanToBoolean(((BOPTools_ListOfCommonBlock*)nativeHandle)->IsEmpty());
}

 void OCBOPTools_ListOfCommonBlock::Prepend(OCNaroWrappers::OCBOPTools_CommonBlock^ I)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Prepend(*((BOPTools_CommonBlock*)I->Handle));
}

 void OCBOPTools_ListOfCommonBlock::Prepend(OCNaroWrappers::OCBOPTools_CommonBlock^ I, OCNaroWrappers::OCBOPTools_ListIteratorOfListOfCommonBlock^ theIt)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Prepend(*((BOPTools_CommonBlock*)I->Handle), *((BOPTools_ListIteratorOfListOfCommonBlock*)theIt->Handle));
}

 void OCBOPTools_ListOfCommonBlock::Prepend(OCNaroWrappers::OCBOPTools_ListOfCommonBlock^ Other)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Prepend(*((BOPTools_ListOfCommonBlock*)Other->Handle));
}

 void OCBOPTools_ListOfCommonBlock::Append(OCNaroWrappers::OCBOPTools_CommonBlock^ I)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Append(*((BOPTools_CommonBlock*)I->Handle));
}

 void OCBOPTools_ListOfCommonBlock::Append(OCNaroWrappers::OCBOPTools_CommonBlock^ I, OCNaroWrappers::OCBOPTools_ListIteratorOfListOfCommonBlock^ theIt)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Append(*((BOPTools_CommonBlock*)I->Handle), *((BOPTools_ListIteratorOfListOfCommonBlock*)theIt->Handle));
}

 void OCBOPTools_ListOfCommonBlock::Append(OCNaroWrappers::OCBOPTools_ListOfCommonBlock^ Other)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Append(*((BOPTools_ListOfCommonBlock*)Other->Handle));
}

OCBOPTools_CommonBlock^ OCBOPTools_ListOfCommonBlock::First()
{
  BOPTools_CommonBlock* tmp = new BOPTools_CommonBlock();
  *tmp = ((BOPTools_ListOfCommonBlock*)nativeHandle)->First();
  return gcnew OCBOPTools_CommonBlock(tmp);
}

OCBOPTools_CommonBlock^ OCBOPTools_ListOfCommonBlock::Last()
{
  BOPTools_CommonBlock* tmp = new BOPTools_CommonBlock();
  *tmp = ((BOPTools_ListOfCommonBlock*)nativeHandle)->Last();
  return gcnew OCBOPTools_CommonBlock(tmp);
}

 void OCBOPTools_ListOfCommonBlock::RemoveFirst()
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->RemoveFirst();
}

 void OCBOPTools_ListOfCommonBlock::Remove(OCNaroWrappers::OCBOPTools_ListIteratorOfListOfCommonBlock^ It)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->Remove(*((BOPTools_ListIteratorOfListOfCommonBlock*)It->Handle));
}

 void OCBOPTools_ListOfCommonBlock::InsertBefore(OCNaroWrappers::OCBOPTools_CommonBlock^ I, OCNaroWrappers::OCBOPTools_ListIteratorOfListOfCommonBlock^ It)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->InsertBefore(*((BOPTools_CommonBlock*)I->Handle), *((BOPTools_ListIteratorOfListOfCommonBlock*)It->Handle));
}

 void OCBOPTools_ListOfCommonBlock::InsertBefore(OCNaroWrappers::OCBOPTools_ListOfCommonBlock^ Other, OCNaroWrappers::OCBOPTools_ListIteratorOfListOfCommonBlock^ It)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->InsertBefore(*((BOPTools_ListOfCommonBlock*)Other->Handle), *((BOPTools_ListIteratorOfListOfCommonBlock*)It->Handle));
}

 void OCBOPTools_ListOfCommonBlock::InsertAfter(OCNaroWrappers::OCBOPTools_CommonBlock^ I, OCNaroWrappers::OCBOPTools_ListIteratorOfListOfCommonBlock^ It)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->InsertAfter(*((BOPTools_CommonBlock*)I->Handle), *((BOPTools_ListIteratorOfListOfCommonBlock*)It->Handle));
}

 void OCBOPTools_ListOfCommonBlock::InsertAfter(OCNaroWrappers::OCBOPTools_ListOfCommonBlock^ Other, OCNaroWrappers::OCBOPTools_ListIteratorOfListOfCommonBlock^ It)
{
  ((BOPTools_ListOfCommonBlock*)nativeHandle)->InsertAfter(*((BOPTools_ListOfCommonBlock*)Other->Handle), *((BOPTools_ListIteratorOfListOfCommonBlock*)It->Handle));
}


