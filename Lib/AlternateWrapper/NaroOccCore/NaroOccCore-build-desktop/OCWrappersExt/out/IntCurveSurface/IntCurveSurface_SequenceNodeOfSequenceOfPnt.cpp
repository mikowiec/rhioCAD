// File generated by CPPExt (CPP file)
//

#include "IntCurveSurface_SequenceNodeOfSequenceOfPnt.h"
#include "../Converter.h"
#include "IntCurveSurface_IntersectionPoint.h"
#include "IntCurveSurface_SequenceOfPnt.h"


using namespace OCNaroWrappers;

OCIntCurveSurface_SequenceNodeOfSequenceOfPnt::OCIntCurveSurface_SequenceNodeOfSequenceOfPnt(Handle(IntCurveSurface_SequenceNodeOfSequenceOfPnt)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_IntCurveSurface_SequenceNodeOfSequenceOfPnt(*nativeHandle);
}

OCIntCurveSurface_SequenceNodeOfSequenceOfPnt::OCIntCurveSurface_SequenceNodeOfSequenceOfPnt(OCNaroWrappers::OCIntCurveSurface_IntersectionPoint^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IntCurveSurface_SequenceNodeOfSequenceOfPnt(new IntCurveSurface_SequenceNodeOfSequenceOfPnt(*((IntCurveSurface_IntersectionPoint*)I->Handle), n, p));
}

OCIntCurveSurface_IntersectionPoint^ OCIntCurveSurface_SequenceNodeOfSequenceOfPnt::Value()
{
  IntCurveSurface_IntersectionPoint* tmp = new IntCurveSurface_IntersectionPoint();
  *tmp = (*((Handle_IntCurveSurface_SequenceNodeOfSequenceOfPnt*)nativeHandle))->Value();
  return gcnew OCIntCurveSurface_IntersectionPoint(tmp);
}


