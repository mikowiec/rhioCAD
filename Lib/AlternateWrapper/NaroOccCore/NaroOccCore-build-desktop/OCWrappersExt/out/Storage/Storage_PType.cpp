// File generated by CPPExt (CPP file)
//

#include "Storage_PType.h"
#include "../Converter.h"
#include "../TCollection/TCollection_AsciiString.h"
#include "Storage_IndexedDataMapNodeOfPType.h"


using namespace OCNaroWrappers;

OCStorage_PType::OCStorage_PType(Storage_PType* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStorage_PType::OCStorage_PType(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new Storage_PType(NbBuckets);
}

OCStorage_PType^ OCStorage_PType::Assign(OCNaroWrappers::OCStorage_PType^ Other)
{
  Storage_PType* tmp = new Storage_PType(0);
  *tmp = ((Storage_PType*)nativeHandle)->Assign(*((Storage_PType*)Other->Handle));
  return gcnew OCStorage_PType(tmp);
}

 void OCStorage_PType::ReSize(Standard_Integer NbBuckets)
{
  ((Storage_PType*)nativeHandle)->ReSize(NbBuckets);
}

 Standard_Integer OCStorage_PType::Add(OCNaroWrappers::OCTCollection_AsciiString^ K, Standard_Integer I)
{
  return ((Storage_PType*)nativeHandle)->Add(*((TCollection_AsciiString*)K->Handle), I);
}

 void OCStorage_PType::Substitute(Standard_Integer I, OCNaroWrappers::OCTCollection_AsciiString^ K, Standard_Integer T)
{
  ((Storage_PType*)nativeHandle)->Substitute(I, *((TCollection_AsciiString*)K->Handle), T);
}

 void OCStorage_PType::RemoveLast()
{
  ((Storage_PType*)nativeHandle)->RemoveLast();
}

 System::Boolean OCStorage_PType::Contains(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return OCConverter::StandardBooleanToBoolean(((Storage_PType*)nativeHandle)->Contains(*((TCollection_AsciiString*)K->Handle)));
}

OCTCollection_AsciiString^ OCStorage_PType::FindKey(Standard_Integer I)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = ((Storage_PType*)nativeHandle)->FindKey(I);
  return gcnew OCTCollection_AsciiString(tmp);
}

 Standard_Integer OCStorage_PType::FindFromIndex(Standard_Integer I)
{
  return ((Storage_PType*)nativeHandle)->FindFromIndex(I);
}

 Standard_Integer OCStorage_PType::ChangeFromIndex(Standard_Integer I)
{
  return ((Storage_PType*)nativeHandle)->ChangeFromIndex(I);
}

 Standard_Integer OCStorage_PType::FindIndex(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return ((Storage_PType*)nativeHandle)->FindIndex(*((TCollection_AsciiString*)K->Handle));
}

 Standard_Integer OCStorage_PType::FindFromKey(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return ((Storage_PType*)nativeHandle)->FindFromKey(*((TCollection_AsciiString*)K->Handle));
}

 Standard_Integer OCStorage_PType::ChangeFromKey(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return ((Storage_PType*)nativeHandle)->ChangeFromKey(*((TCollection_AsciiString*)K->Handle));
}

 Standard_Address OCStorage_PType::FindFromKey1(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return ((Storage_PType*)nativeHandle)->FindFromKey1(*((TCollection_AsciiString*)K->Handle));
}

 Standard_Address OCStorage_PType::ChangeFromKey1(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return ((Storage_PType*)nativeHandle)->ChangeFromKey1(*((TCollection_AsciiString*)K->Handle));
}


