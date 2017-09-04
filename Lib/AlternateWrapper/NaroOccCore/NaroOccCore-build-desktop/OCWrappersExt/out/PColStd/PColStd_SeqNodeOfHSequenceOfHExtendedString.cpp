// File generated by CPPExt (CPP file)
//

#include "PColStd_SeqNodeOfHSequenceOfHExtendedString.h"
#include "../Converter.h"
#include "../PCollection/PCollection_HExtendedString.h"
#include "PColStd_HSequenceOfHExtendedString.h"
#include "PColStd_SeqExplorerOfHSequenceOfHExtendedString.h"


using namespace OCNaroWrappers;

OCPColStd_SeqNodeOfHSequenceOfHExtendedString::OCPColStd_SeqNodeOfHSequenceOfHExtendedString(Handle(PColStd_SeqNodeOfHSequenceOfHExtendedString)* nativeHandle) : OCPMMgt_PManaged((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString(*nativeHandle);
}

OCPColStd_SeqNodeOfHSequenceOfHExtendedString::OCPColStd_SeqNodeOfHSequenceOfHExtendedString(OCNaroWrappers::OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ TheLast, OCNaroWrappers::OCPCollection_HExtendedString^ TheItem) : OCPMMgt_PManaged((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString(new PColStd_SeqNodeOfHSequenceOfHExtendedString(*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)TheLast->Handle), *((Handle_PCollection_HExtendedString*)TheItem->Handle)));
}

OCPColStd_SeqNodeOfHSequenceOfHExtendedString::OCPColStd_SeqNodeOfHSequenceOfHExtendedString(OCNaroWrappers::OCPCollection_HExtendedString^ TheItem, OCNaroWrappers::OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ TheFirst) : OCPMMgt_PManaged((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString(new PColStd_SeqNodeOfHSequenceOfHExtendedString(*((Handle_PCollection_HExtendedString*)TheItem->Handle), *((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)TheFirst->Handle)));
}

OCPColStd_SeqNodeOfHSequenceOfHExtendedString::OCPColStd_SeqNodeOfHSequenceOfHExtendedString(OCNaroWrappers::OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ ThePrevious, OCNaroWrappers::OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ TheNext, OCNaroWrappers::OCPCollection_HExtendedString^ TheItem) : OCPMMgt_PManaged((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString(new PColStd_SeqNodeOfHSequenceOfHExtendedString(*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)ThePrevious->Handle), *((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)TheNext->Handle), *((Handle_PCollection_HExtendedString*)TheItem->Handle)));
}

OCPCollection_HExtendedString^ OCPColStd_SeqNodeOfHSequenceOfHExtendedString::Value()
{
  Handle(PCollection_HExtendedString) tmp = (*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)nativeHandle))->Value();
  return gcnew OCPCollection_HExtendedString(&tmp);
}

OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ OCPColStd_SeqNodeOfHSequenceOfHExtendedString::Next()
{
  Handle(PColStd_SeqNodeOfHSequenceOfHExtendedString) tmp = (*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)nativeHandle))->Next();
  return gcnew OCPColStd_SeqNodeOfHSequenceOfHExtendedString(&tmp);
}

OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ OCPColStd_SeqNodeOfHSequenceOfHExtendedString::Previous()
{
  Handle(PColStd_SeqNodeOfHSequenceOfHExtendedString) tmp = (*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)nativeHandle))->Previous();
  return gcnew OCPColStd_SeqNodeOfHSequenceOfHExtendedString(&tmp);
}

 void OCPColStd_SeqNodeOfHSequenceOfHExtendedString::SetValue(OCNaroWrappers::OCPCollection_HExtendedString^ AnItem)
{
  (*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)nativeHandle))->SetValue(*((Handle_PCollection_HExtendedString*)AnItem->Handle));
}

 void OCPColStd_SeqNodeOfHSequenceOfHExtendedString::SetNext(OCNaroWrappers::OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ ANode)
{
  (*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)nativeHandle))->SetNext(*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)ANode->Handle));
}

 void OCPColStd_SeqNodeOfHSequenceOfHExtendedString::SetPrevious(OCNaroWrappers::OCPColStd_SeqNodeOfHSequenceOfHExtendedString^ ANode)
{
  (*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)nativeHandle))->SetPrevious(*((Handle_PColStd_SeqNodeOfHSequenceOfHExtendedString*)ANode->Handle));
}


