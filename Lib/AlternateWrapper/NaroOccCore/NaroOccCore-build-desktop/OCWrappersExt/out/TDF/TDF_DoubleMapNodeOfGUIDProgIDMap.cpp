// File generated by CPPExt (CPP file)
//

#include "TDF_DoubleMapNodeOfGUIDProgIDMap.h"
#include "../Converter.h"
#include "../Standard/Standard_GUID.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "TDF_GUIDProgIDMap.h"
#include "TDF_DoubleMapIteratorOfGUIDProgIDMap.h"


using namespace OCNaroWrappers;

OCTDF_DoubleMapNodeOfGUIDProgIDMap::OCTDF_DoubleMapNodeOfGUIDProgIDMap(Handle(TDF_DoubleMapNodeOfGUIDProgIDMap)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TDF_DoubleMapNodeOfGUIDProgIDMap(*nativeHandle);
}

OCTDF_DoubleMapNodeOfGUIDProgIDMap::OCTDF_DoubleMapNodeOfGUIDProgIDMap(OCNaroWrappers::OCStandard_GUID^ K1, OCNaroWrappers::OCTCollection_ExtendedString^ K2, TCollection_MapNodePtr n1, TCollection_MapNodePtr n2) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TDF_DoubleMapNodeOfGUIDProgIDMap(new TDF_DoubleMapNodeOfGUIDProgIDMap(*((Standard_GUID*)K1->Handle), *((TCollection_ExtendedString*)K2->Handle), n1, n2));
}

OCStandard_GUID^ OCTDF_DoubleMapNodeOfGUIDProgIDMap::Key1()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = (*((Handle_TDF_DoubleMapNodeOfGUIDProgIDMap*)nativeHandle))->Key1();
  return gcnew OCStandard_GUID(tmp);
}

OCTCollection_ExtendedString^ OCTDF_DoubleMapNodeOfGUIDProgIDMap::Key2()
{
  TCollection_ExtendedString* tmp = new TCollection_ExtendedString();
  *tmp = (*((Handle_TDF_DoubleMapNodeOfGUIDProgIDMap*)nativeHandle))->Key2();
  return gcnew OCTCollection_ExtendedString(tmp);
}

 TCollection_MapNodePtr& OCTDF_DoubleMapNodeOfGUIDProgIDMap::Next2()
{
  return (*((Handle_TDF_DoubleMapNodeOfGUIDProgIDMap*)nativeHandle))->Next2();
}

