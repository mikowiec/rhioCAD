// File generated by CPPExt (CPP file)
//

#include "TDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal.h"
#include "../Converter.h"
#include "../TColStd/TColStd_HArray1OfReal.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "TDataStd_DataMapOfStringHArray1OfReal.h"
#include "TDataStd_DataMapIteratorOfDataMapOfStringHArray1OfReal.h"


using namespace OCNaroWrappers;

OCTDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal::OCTDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal(Handle(TDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal(*nativeHandle);
}

OCTDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal::OCTDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal(OCNaroWrappers::OCTCollection_ExtendedString^ K, OCNaroWrappers::OCTColStd_HArray1OfReal^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal(new TDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal(*((TCollection_ExtendedString*)K->Handle), *((Handle_TColStd_HArray1OfReal*)I->Handle), n));
}

OCTCollection_ExtendedString^ OCTDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal::Key()
{
  TCollection_ExtendedString* tmp = new TCollection_ExtendedString();
  *tmp = (*((Handle_TDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal*)nativeHandle))->Key();
  return gcnew OCTCollection_ExtendedString(tmp);
}

OCTColStd_HArray1OfReal^ OCTDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal::Value()
{
  Handle(TColStd_HArray1OfReal) tmp = (*((Handle_TDataStd_DataMapNodeOfDataMapOfStringHArray1OfReal*)nativeHandle))->Value();
  return gcnew OCTColStd_HArray1OfReal(&tmp);
}

