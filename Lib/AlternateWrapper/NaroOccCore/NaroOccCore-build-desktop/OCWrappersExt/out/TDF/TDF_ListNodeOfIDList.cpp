// File generated by CPPExt (CPP file)
//

#include "TDF_ListNodeOfIDList.h"
#include "../Converter.h"
#include "../Standard/Standard_GUID.h"
#include "TDF_IDList.h"
#include "TDF_ListIteratorOfIDList.h"


using namespace OCNaroWrappers;

OCTDF_ListNodeOfIDList::OCTDF_ListNodeOfIDList(Handle(TDF_ListNodeOfIDList)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TDF_ListNodeOfIDList(*nativeHandle);
}

OCTDF_ListNodeOfIDList::OCTDF_ListNodeOfIDList(OCNaroWrappers::OCStandard_GUID^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TDF_ListNodeOfIDList(new TDF_ListNodeOfIDList(*((Standard_GUID*)I->Handle), n));
}

OCStandard_GUID^ OCTDF_ListNodeOfIDList::Value()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = (*((Handle_TDF_ListNodeOfIDList*)nativeHandle))->Value();
  return gcnew OCStandard_GUID(tmp);
}


