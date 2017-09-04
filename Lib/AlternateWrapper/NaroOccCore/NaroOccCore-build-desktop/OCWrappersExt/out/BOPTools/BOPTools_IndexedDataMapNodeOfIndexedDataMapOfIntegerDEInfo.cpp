// File generated by CPPExt (CPP file)
//

#include "BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo.h"
#include "../Converter.h"
#include "BOPTools_DEInfo.h"
#include "../TColStd/TColStd_MapIntegerHasher.h"
#include "BOPTools_IndexedDataMapOfIntegerDEInfo.h"


using namespace OCNaroWrappers;

OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo::OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo(Handle(BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo(*nativeHandle);
}

OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo::OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo(Standard_Integer K1, Standard_Integer K2, OCNaroWrappers::OCBOPTools_DEInfo^ I, TCollection_MapNodePtr n1, TCollection_MapNodePtr n2) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo(new BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo(K1, K2, *((BOPTools_DEInfo*)I->Handle), n1, n2));
}

 Standard_Integer OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo::Key1()
{
  return (*((Handle_BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo*)nativeHandle))->Key1();
}

 Standard_Integer OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo::Key2()
{
  return (*((Handle_BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo*)nativeHandle))->Key2();
}

 TCollection_MapNodePtr& OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo::Next2()
{
  return (*((Handle_BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo*)nativeHandle))->Next2();
}

OCBOPTools_DEInfo^ OCBOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo::Value()
{
  BOPTools_DEInfo* tmp = new BOPTools_DEInfo();
  *tmp = (*((Handle_BOPTools_IndexedDataMapNodeOfIndexedDataMapOfIntegerDEInfo*)nativeHandle))->Value();
  return gcnew OCBOPTools_DEInfo(tmp);
}


