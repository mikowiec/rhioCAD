// File generated by CPPExt (CPP file)
//

#include "IntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds.h"
#include "../Converter.h"
#include "IntPatch_TheSegmentOfTheSOnBounds.h"
#include "IntPatch_SequenceOfSegmentOfTheSOnBounds.h"


using namespace OCNaroWrappers;

OCIntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds::OCIntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds(Handle(IntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_IntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds(*nativeHandle);
}

OCIntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds::OCIntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds(OCNaroWrappers::OCIntPatch_TheSegmentOfTheSOnBounds^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds(new IntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds(*((IntPatch_TheSegmentOfTheSOnBounds*)I->Handle), n, p));
}

OCIntPatch_TheSegmentOfTheSOnBounds^ OCIntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds::Value()
{
  IntPatch_TheSegmentOfTheSOnBounds* tmp = new IntPatch_TheSegmentOfTheSOnBounds();
  *tmp = (*((Handle_IntPatch_SequenceNodeOfSequenceOfSegmentOfTheSOnBounds*)nativeHandle))->Value();
  return gcnew OCIntPatch_TheSegmentOfTheSOnBounds(tmp);
}

