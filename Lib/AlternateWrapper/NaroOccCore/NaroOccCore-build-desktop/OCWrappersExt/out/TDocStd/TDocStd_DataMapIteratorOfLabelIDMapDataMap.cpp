// File generated by CPPExt (CPP file)
//

#include "TDocStd_DataMapIteratorOfLabelIDMapDataMap.h"
#include "../Converter.h"
#include "../TDF/TDF_Label.h"
#include "../TDF/TDF_IDMap.h"
#include "../TDF/TDF_LabelMapHasher.h"
#include "TDocStd_LabelIDMapDataMap.h"
#include "TDocStd_DataMapNodeOfLabelIDMapDataMap.h"


using namespace OCNaroWrappers;

OCTDocStd_DataMapIteratorOfLabelIDMapDataMap::OCTDocStd_DataMapIteratorOfLabelIDMapDataMap(TDocStd_DataMapIteratorOfLabelIDMapDataMap* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTDocStd_DataMapIteratorOfLabelIDMapDataMap::OCTDocStd_DataMapIteratorOfLabelIDMapDataMap() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TDocStd_DataMapIteratorOfLabelIDMapDataMap();
}

OCTDocStd_DataMapIteratorOfLabelIDMapDataMap::OCTDocStd_DataMapIteratorOfLabelIDMapDataMap(OCNaroWrappers::OCTDocStd_LabelIDMapDataMap^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TDocStd_DataMapIteratorOfLabelIDMapDataMap(*((TDocStd_LabelIDMapDataMap*)aMap->Handle));
}

 void OCTDocStd_DataMapIteratorOfLabelIDMapDataMap::Initialize(OCNaroWrappers::OCTDocStd_LabelIDMapDataMap^ aMap)
{
  ((TDocStd_DataMapIteratorOfLabelIDMapDataMap*)nativeHandle)->Initialize(*((TDocStd_LabelIDMapDataMap*)aMap->Handle));
}

OCTDF_Label^ OCTDocStd_DataMapIteratorOfLabelIDMapDataMap::Key()
{
  TDF_Label* tmp = new TDF_Label();
  *tmp = ((TDocStd_DataMapIteratorOfLabelIDMapDataMap*)nativeHandle)->Key();
  return gcnew OCTDF_Label(tmp);
}

OCTDF_IDMap^ OCTDocStd_DataMapIteratorOfLabelIDMapDataMap::Value()
{
  TDF_IDMap* tmp = new TDF_IDMap(0);
  *tmp = ((TDocStd_DataMapIteratorOfLabelIDMapDataMap*)nativeHandle)->Value();
  return gcnew OCTDF_IDMap(tmp);
}


