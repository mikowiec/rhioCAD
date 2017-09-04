// File generated by CPPExt (CPP file)
//

#include "Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC.h"
#include "../Converter.h"
#include "Extrema_POnCurv.h"
#include "Extrema_SequenceNodeOfSeqPCOfPCLocFOfLocEPCOfLocateExtPC.h"


using namespace OCNaroWrappers;

OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC(Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC* nativeHandle) : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC() : OCTCollection_BaseSequence((OCDummy^)nullptr)

{
  nativeHandle = new Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC();
}

OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC^ OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Assign(OCNaroWrappers::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC^ Other)
{
  Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC* tmp = new Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC();
  *tmp = ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Assign(*((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)Other->Handle));
  return gcnew OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC(tmp);
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Append(OCNaroWrappers::OCExtrema_POnCurv^ T)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Append(*((Extrema_POnCurv*)T->Handle));
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Append(OCNaroWrappers::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC^ S)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Append(*((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)S->Handle));
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Prepend(OCNaroWrappers::OCExtrema_POnCurv^ T)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Prepend(*((Extrema_POnCurv*)T->Handle));
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Prepend(OCNaroWrappers::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC^ S)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Prepend(*((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)S->Handle));
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCExtrema_POnCurv^ T)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->InsertBefore(Index, *((Extrema_POnCurv*)T->Handle));
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC^ S)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->InsertBefore(Index, *((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)S->Handle));
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCExtrema_POnCurv^ T)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->InsertAfter(Index, *((Extrema_POnCurv*)T->Handle));
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::InsertAfter(Standard_Integer Index, OCNaroWrappers::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC^ S)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->InsertAfter(Index, *((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)S->Handle));
}

OCExtrema_POnCurv^ OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::First()
{
  Extrema_POnCurv* tmp = new Extrema_POnCurv();
  *tmp = ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->First();
  return gcnew OCExtrema_POnCurv(tmp);
}

OCExtrema_POnCurv^ OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Last()
{
  Extrema_POnCurv* tmp = new Extrema_POnCurv();
  *tmp = ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Last();
  return gcnew OCExtrema_POnCurv(tmp);
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Split(Standard_Integer Index, OCNaroWrappers::OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC^ Sub)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Split(Index, *((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)Sub->Handle));
}

OCExtrema_POnCurv^ OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Value(Standard_Integer Index)
{
  Extrema_POnCurv* tmp = new Extrema_POnCurv();
  *tmp = ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Value(Index);
  return gcnew OCExtrema_POnCurv(tmp);
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::SetValue(Standard_Integer Index, OCNaroWrappers::OCExtrema_POnCurv^ I)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->SetValue(Index, *((Extrema_POnCurv*)I->Handle));
}

OCExtrema_POnCurv^ OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::ChangeValue(Standard_Integer Index)
{
  Extrema_POnCurv* tmp = new Extrema_POnCurv();
  *tmp = ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->ChangeValue(Index);
  return gcnew OCExtrema_POnCurv(tmp);
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Remove(Standard_Integer Index)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Remove(Index);
}

 void OCExtrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC::Remove(Standard_Integer FromIndex, Standard_Integer ToIndex)
{
  ((Extrema_SeqPCOfPCLocFOfLocEPCOfLocateExtPC*)nativeHandle)->Remove(FromIndex, ToIndex);
}


