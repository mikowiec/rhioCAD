// File generated by CPPExt (CPP file)
//

#include "TDF_MapIteratorOfLabelMap.h"
#include "../Converter.h"
#include "TDF_Label.h"
#include "TDF_LabelMapHasher.h"
#include "TDF_LabelMap.h"
#include "TDF_StdMapNodeOfLabelMap.h"


using namespace OCNaroWrappers;

OCTDF_MapIteratorOfLabelMap::OCTDF_MapIteratorOfLabelMap(TDF_MapIteratorOfLabelMap* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTDF_MapIteratorOfLabelMap::OCTDF_MapIteratorOfLabelMap() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TDF_MapIteratorOfLabelMap();
}

OCTDF_MapIteratorOfLabelMap::OCTDF_MapIteratorOfLabelMap(OCNaroWrappers::OCTDF_LabelMap^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TDF_MapIteratorOfLabelMap(*((TDF_LabelMap*)aMap->Handle));
}

 void OCTDF_MapIteratorOfLabelMap::Initialize(OCNaroWrappers::OCTDF_LabelMap^ aMap)
{
  ((TDF_MapIteratorOfLabelMap*)nativeHandle)->Initialize(*((TDF_LabelMap*)aMap->Handle));
}

OCTDF_Label^ OCTDF_MapIteratorOfLabelMap::Key()
{
  TDF_Label* tmp = new TDF_Label();
  *tmp = ((TDF_MapIteratorOfLabelMap*)nativeHandle)->Key();
  return gcnew OCTDF_Label(tmp);
}


