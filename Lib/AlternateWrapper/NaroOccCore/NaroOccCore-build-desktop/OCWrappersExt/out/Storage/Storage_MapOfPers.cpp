// File generated by CPPExt (CPP file)
//

#include "Storage_MapOfPers.h"
#include "../Converter.h"
#include "../TCollection/TCollection_AsciiString.h"
#include "Storage_Root.h"
#include "Storage_DataMapNodeOfMapOfPers.h"
#include "Storage_DataMapIteratorOfMapOfPers.h"


using namespace OCNaroWrappers;

OCStorage_MapOfPers::OCStorage_MapOfPers(Storage_MapOfPers* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStorage_MapOfPers::OCStorage_MapOfPers(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new Storage_MapOfPers(NbBuckets);
}

OCStorage_MapOfPers^ OCStorage_MapOfPers::Assign(OCNaroWrappers::OCStorage_MapOfPers^ Other)
{
  Storage_MapOfPers* tmp = new Storage_MapOfPers(0);
  *tmp = ((Storage_MapOfPers*)nativeHandle)->Assign(*((Storage_MapOfPers*)Other->Handle));
  return gcnew OCStorage_MapOfPers(tmp);
}

 void OCStorage_MapOfPers::ReSize(Standard_Integer NbBuckets)
{
  ((Storage_MapOfPers*)nativeHandle)->ReSize(NbBuckets);
}

 System::Boolean OCStorage_MapOfPers::Bind(OCNaroWrappers::OCTCollection_AsciiString^ K, OCNaroWrappers::OCStorage_Root^ I)
{
  return OCConverter::StandardBooleanToBoolean(((Storage_MapOfPers*)nativeHandle)->Bind(*((TCollection_AsciiString*)K->Handle), *((Handle_Storage_Root*)I->Handle)));
}

 System::Boolean OCStorage_MapOfPers::IsBound(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return OCConverter::StandardBooleanToBoolean(((Storage_MapOfPers*)nativeHandle)->IsBound(*((TCollection_AsciiString*)K->Handle)));
}

 System::Boolean OCStorage_MapOfPers::UnBind(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return OCConverter::StandardBooleanToBoolean(((Storage_MapOfPers*)nativeHandle)->UnBind(*((TCollection_AsciiString*)K->Handle)));
}

OCStorage_Root^ OCStorage_MapOfPers::Find(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  Handle(Storage_Root) tmp = ((Storage_MapOfPers*)nativeHandle)->Find(*((TCollection_AsciiString*)K->Handle));
  return gcnew OCStorage_Root(&tmp);
}

OCStorage_Root^ OCStorage_MapOfPers::ChangeFind(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  Handle(Storage_Root) tmp = ((Storage_MapOfPers*)nativeHandle)->ChangeFind(*((TCollection_AsciiString*)K->Handle));
  return gcnew OCStorage_Root(&tmp);
}

 Standard_Address OCStorage_MapOfPers::Find1(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return ((Storage_MapOfPers*)nativeHandle)->Find1(*((TCollection_AsciiString*)K->Handle));
}

 Standard_Address OCStorage_MapOfPers::ChangeFind1(OCNaroWrappers::OCTCollection_AsciiString^ K)
{
  return ((Storage_MapOfPers*)nativeHandle)->ChangeFind1(*((TCollection_AsciiString*)K->Handle));
}


