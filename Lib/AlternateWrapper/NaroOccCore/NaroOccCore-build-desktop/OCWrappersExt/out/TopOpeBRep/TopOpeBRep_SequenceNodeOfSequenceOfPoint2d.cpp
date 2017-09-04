// File generated by CPPExt (CPP file)
//

#include "TopOpeBRep_SequenceNodeOfSequenceOfPoint2d.h"
#include "../Converter.h"
#include "TopOpeBRep_Point2d.h"
#include "TopOpeBRep_SequenceOfPoint2d.h"


using namespace OCNaroWrappers;

OCTopOpeBRep_SequenceNodeOfSequenceOfPoint2d::OCTopOpeBRep_SequenceNodeOfSequenceOfPoint2d(Handle(TopOpeBRep_SequenceNodeOfSequenceOfPoint2d)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TopOpeBRep_SequenceNodeOfSequenceOfPoint2d(*nativeHandle);
}

OCTopOpeBRep_SequenceNodeOfSequenceOfPoint2d::OCTopOpeBRep_SequenceNodeOfSequenceOfPoint2d(OCNaroWrappers::OCTopOpeBRep_Point2d^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TopOpeBRep_SequenceNodeOfSequenceOfPoint2d(new TopOpeBRep_SequenceNodeOfSequenceOfPoint2d(*((TopOpeBRep_Point2d*)I->Handle), n, p));
}

OCTopOpeBRep_Point2d^ OCTopOpeBRep_SequenceNodeOfSequenceOfPoint2d::Value()
{
  TopOpeBRep_Point2d* tmp = new TopOpeBRep_Point2d();
  *tmp = (*((Handle_TopOpeBRep_SequenceNodeOfSequenceOfPoint2d*)nativeHandle))->Value();
  return gcnew OCTopOpeBRep_Point2d(tmp);
}

