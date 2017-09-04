// File generated by CPPExt (CPP file)
//

#include "HatchGen_SequenceNodeOfPointsOnHatching.h"
#include "../Converter.h"
#include "HatchGen_PointOnHatching.h"
#include "HatchGen_PointsOnHatching.h"


using namespace OCNaroWrappers;

OCHatchGen_SequenceNodeOfPointsOnHatching::OCHatchGen_SequenceNodeOfPointsOnHatching(Handle(HatchGen_SequenceNodeOfPointsOnHatching)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_HatchGen_SequenceNodeOfPointsOnHatching(*nativeHandle);
}

OCHatchGen_SequenceNodeOfPointsOnHatching::OCHatchGen_SequenceNodeOfPointsOnHatching(OCNaroWrappers::OCHatchGen_PointOnHatching^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_HatchGen_SequenceNodeOfPointsOnHatching(new HatchGen_SequenceNodeOfPointsOnHatching(*((HatchGen_PointOnHatching*)I->Handle), n, p));
}

OCHatchGen_PointOnHatching^ OCHatchGen_SequenceNodeOfPointsOnHatching::Value()
{
  HatchGen_PointOnHatching* tmp = new HatchGen_PointOnHatching();
  *tmp = (*((Handle_HatchGen_SequenceNodeOfPointsOnHatching*)nativeHandle))->Value();
  return gcnew OCHatchGen_PointOnHatching(tmp);
}


