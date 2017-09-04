// File generated by CPPExt (CPP file)
//

#include "TDataStd_DataMapOfStringHArray1OfInteger.h"
#include "../Converter.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "../TColStd/TColStd_HArray1OfInteger.h"
#include "TDataStd_DataMapNodeOfDataMapOfStringHArray1OfInteger.h"
#include "TDataStd_DataMapIteratorOfDataMapOfStringHArray1OfInteger.h"


using namespace OCNaroWrappers;

OCTDataStd_DataMapOfStringHArray1OfInteger::OCTDataStd_DataMapOfStringHArray1OfInteger(TDataStd_DataMapOfStringHArray1OfInteger* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTDataStd_DataMapOfStringHArray1OfInteger::OCTDataStd_DataMapOfStringHArray1OfInteger(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new TDataStd_DataMapOfStringHArray1OfInteger(NbBuckets);
}

OCTDataStd_DataMapOfStringHArray1OfInteger^ OCTDataStd_DataMapOfStringHArray1OfInteger::Assign(OCNaroWrappers::OCTDataStd_DataMapOfStringHArray1OfInteger^ Other)
{
  TDataStd_DataMapOfStringHArray1OfInteger* tmp = new TDataStd_DataMapOfStringHArray1OfInteger(0);
  *tmp = ((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->Assign(*((TDataStd_DataMapOfStringHArray1OfInteger*)Other->Handle));
  return gcnew OCTDataStd_DataMapOfStringHArray1OfInteger(tmp);
}

 void OCTDataStd_DataMapOfStringHArray1OfInteger::ReSize(Standard_Integer NbBuckets)
{
  ((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->ReSize(NbBuckets);
}

 System::Boolean OCTDataStd_DataMapOfStringHArray1OfInteger::Bind(OCNaroWrappers::OCTCollection_ExtendedString^ K, OCNaroWrappers::OCTColStd_HArray1OfInteger^ I)
{
  return OCConverter::StandardBooleanToBoolean(((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->Bind(*((TCollection_ExtendedString*)K->Handle), *((Handle_TColStd_HArray1OfInteger*)I->Handle)));
}

 System::Boolean OCTDataStd_DataMapOfStringHArray1OfInteger::IsBound(OCNaroWrappers::OCTCollection_ExtendedString^ K)
{
  return OCConverter::StandardBooleanToBoolean(((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->IsBound(*((TCollection_ExtendedString*)K->Handle)));
}

 System::Boolean OCTDataStd_DataMapOfStringHArray1OfInteger::UnBind(OCNaroWrappers::OCTCollection_ExtendedString^ K)
{
  return OCConverter::StandardBooleanToBoolean(((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->UnBind(*((TCollection_ExtendedString*)K->Handle)));
}

OCTColStd_HArray1OfInteger^ OCTDataStd_DataMapOfStringHArray1OfInteger::Find(OCNaroWrappers::OCTCollection_ExtendedString^ K)
{
  Handle(TColStd_HArray1OfInteger) tmp = ((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->Find(*((TCollection_ExtendedString*)K->Handle));
  return gcnew OCTColStd_HArray1OfInteger(&tmp);
}

OCTColStd_HArray1OfInteger^ OCTDataStd_DataMapOfStringHArray1OfInteger::ChangeFind(OCNaroWrappers::OCTCollection_ExtendedString^ K)
{
  Handle(TColStd_HArray1OfInteger) tmp = ((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->ChangeFind(*((TCollection_ExtendedString*)K->Handle));
  return gcnew OCTColStd_HArray1OfInteger(&tmp);
}

 Standard_Address OCTDataStd_DataMapOfStringHArray1OfInteger::Find1(OCNaroWrappers::OCTCollection_ExtendedString^ K)
{
  return ((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->Find1(*((TCollection_ExtendedString*)K->Handle));
}

 Standard_Address OCTDataStd_DataMapOfStringHArray1OfInteger::ChangeFind1(OCNaroWrappers::OCTCollection_ExtendedString^ K)
{
  return ((TDataStd_DataMapOfStringHArray1OfInteger*)nativeHandle)->ChangeFind1(*((TCollection_ExtendedString*)K->Handle));
}


