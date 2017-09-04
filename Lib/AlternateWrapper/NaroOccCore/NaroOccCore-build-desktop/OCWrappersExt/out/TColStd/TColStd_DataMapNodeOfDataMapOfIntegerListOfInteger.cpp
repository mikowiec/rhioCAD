// File generated by CPPExt (CPP file)
//

#include "TColStd_DataMapNodeOfDataMapOfIntegerListOfInteger.h"
#include "../Converter.h"
#include "TColStd_ListOfInteger.h"
#include "TColStd_MapIntegerHasher.h"
#include "TColStd_DataMapOfIntegerListOfInteger.h"
#include "TColStd_DataMapIteratorOfDataMapOfIntegerListOfInteger.h"


using namespace OCNaroWrappers;

OCTColStd_DataMapNodeOfDataMapOfIntegerListOfInteger::OCTColStd_DataMapNodeOfDataMapOfIntegerListOfInteger(Handle(TColStd_DataMapNodeOfDataMapOfIntegerListOfInteger)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TColStd_DataMapNodeOfDataMapOfIntegerListOfInteger(*nativeHandle);
}

OCTColStd_DataMapNodeOfDataMapOfIntegerListOfInteger::OCTColStd_DataMapNodeOfDataMapOfIntegerListOfInteger(Standard_Integer K, OCNaroWrappers::OCTColStd_ListOfInteger^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TColStd_DataMapNodeOfDataMapOfIntegerListOfInteger(new TColStd_DataMapNodeOfDataMapOfIntegerListOfInteger(K, *((TColStd_ListOfInteger*)I->Handle), n));
}

 Standard_Integer OCTColStd_DataMapNodeOfDataMapOfIntegerListOfInteger::Key()
{
  return (*((Handle_TColStd_DataMapNodeOfDataMapOfIntegerListOfInteger*)nativeHandle))->Key();
}

OCTColStd_ListOfInteger^ OCTColStd_DataMapNodeOfDataMapOfIntegerListOfInteger::Value()
{
  TColStd_ListOfInteger* tmp = new TColStd_ListOfInteger();
  *tmp = (*((Handle_TColStd_DataMapNodeOfDataMapOfIntegerListOfInteger*)nativeHandle))->Value();
  return gcnew OCTColStd_ListOfInteger(tmp);
}


