// File generated by CPPExt (CPP file)
//

#include "AppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d.h"
#include "../Converter.h"
#include "../TColgp/TColgp_HArray1OfPnt2d.h"
#include "AppBlend_SequenceOfArray1OfPnt2d.h"


using namespace OCNaroWrappers;

OCAppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d::OCAppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d(Handle(AppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_AppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d(*nativeHandle);
}

OCAppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d::OCAppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d(OCNaroWrappers::OCTColgp_HArray1OfPnt2d^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d(new AppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d(*((Handle_TColgp_HArray1OfPnt2d*)I->Handle), n, p));
}

OCTColgp_HArray1OfPnt2d^ OCAppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d::Value()
{
  Handle(TColgp_HArray1OfPnt2d) tmp = (*((Handle_AppBlend_SequenceNodeOfSequenceOfArray1OfPnt2d*)nativeHandle))->Value();
  return gcnew OCTColgp_HArray1OfPnt2d(&tmp);
}


