// File generated by CPPExt (CPP file)
//

#include "TFunction_DataMapOfLabelListOfLabel.h"
#include "../Converter.h"
#include "../TDF/TDF_Label.h"
#include "../TDF/TDF_LabelList.h"
#include "../TDF/TDF_LabelMapHasher.h"
#include "TFunction_DataMapNodeOfDataMapOfLabelListOfLabel.h"
#include "TFunction_DataMapIteratorOfDataMapOfLabelListOfLabel.h"


using namespace OCNaroWrappers;

OCTFunction_DataMapOfLabelListOfLabel::OCTFunction_DataMapOfLabelListOfLabel(TFunction_DataMapOfLabelListOfLabel* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTFunction_DataMapOfLabelListOfLabel::OCTFunction_DataMapOfLabelListOfLabel(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new TFunction_DataMapOfLabelListOfLabel(NbBuckets);
}

OCTFunction_DataMapOfLabelListOfLabel^ OCTFunction_DataMapOfLabelListOfLabel::Assign(OCNaroWrappers::OCTFunction_DataMapOfLabelListOfLabel^ Other)
{
  TFunction_DataMapOfLabelListOfLabel* tmp = new TFunction_DataMapOfLabelListOfLabel(0);
  *tmp = ((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->Assign(*((TFunction_DataMapOfLabelListOfLabel*)Other->Handle));
  return gcnew OCTFunction_DataMapOfLabelListOfLabel(tmp);
}

 void OCTFunction_DataMapOfLabelListOfLabel::ReSize(Standard_Integer NbBuckets)
{
  ((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->ReSize(NbBuckets);
}

 System::Boolean OCTFunction_DataMapOfLabelListOfLabel::Bind(OCNaroWrappers::OCTDF_Label^ K, OCNaroWrappers::OCTDF_LabelList^ I)
{
  return OCConverter::StandardBooleanToBoolean(((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->Bind(*((TDF_Label*)K->Handle), *((TDF_LabelList*)I->Handle)));
}

 System::Boolean OCTFunction_DataMapOfLabelListOfLabel::IsBound(OCNaroWrappers::OCTDF_Label^ K)
{
  return OCConverter::StandardBooleanToBoolean(((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->IsBound(*((TDF_Label*)K->Handle)));
}

 System::Boolean OCTFunction_DataMapOfLabelListOfLabel::UnBind(OCNaroWrappers::OCTDF_Label^ K)
{
  return OCConverter::StandardBooleanToBoolean(((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->UnBind(*((TDF_Label*)K->Handle)));
}

OCTDF_LabelList^ OCTFunction_DataMapOfLabelListOfLabel::Find(OCNaroWrappers::OCTDF_Label^ K)
{
  TDF_LabelList* tmp = new TDF_LabelList();
  *tmp = ((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->Find(*((TDF_Label*)K->Handle));
  return gcnew OCTDF_LabelList(tmp);
}

OCTDF_LabelList^ OCTFunction_DataMapOfLabelListOfLabel::ChangeFind(OCNaroWrappers::OCTDF_Label^ K)
{
  TDF_LabelList* tmp = new TDF_LabelList();
  *tmp = ((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->ChangeFind(*((TDF_Label*)K->Handle));
  return gcnew OCTDF_LabelList(tmp);
}

 Standard_Address OCTFunction_DataMapOfLabelListOfLabel::Find1(OCNaroWrappers::OCTDF_Label^ K)
{
  return ((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->Find1(*((TDF_Label*)K->Handle));
}

 Standard_Address OCTFunction_DataMapOfLabelListOfLabel::ChangeFind1(OCNaroWrappers::OCTDF_Label^ K)
{
  return ((TFunction_DataMapOfLabelListOfLabel*)nativeHandle)->ChangeFind1(*((TDF_Label*)K->Handle));
}


