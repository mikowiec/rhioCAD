// File generated by CPPExt (CPP file)
//

#include "IntTools_DataMapOfCurveSampleBox.h"
#include "../Converter.h"
#include "IntTools_CurveRangeSample.h"
#include "../Bnd/Bnd_Box.h"
#include "IntTools_CurveRangeSampleMapHasher.h"
#include "IntTools_DataMapNodeOfDataMapOfCurveSampleBox.h"
#include "IntTools_DataMapIteratorOfDataMapOfCurveSampleBox.h"


using namespace OCNaroWrappers;

OCIntTools_DataMapOfCurveSampleBox::OCIntTools_DataMapOfCurveSampleBox(IntTools_DataMapOfCurveSampleBox* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCIntTools_DataMapOfCurveSampleBox::OCIntTools_DataMapOfCurveSampleBox(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new IntTools_DataMapOfCurveSampleBox(NbBuckets);
}

OCIntTools_DataMapOfCurveSampleBox^ OCIntTools_DataMapOfCurveSampleBox::Assign(OCNaroWrappers::OCIntTools_DataMapOfCurveSampleBox^ Other)
{
  IntTools_DataMapOfCurveSampleBox* tmp = new IntTools_DataMapOfCurveSampleBox(0);
  *tmp = ((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->Assign(*((IntTools_DataMapOfCurveSampleBox*)Other->Handle));
  return gcnew OCIntTools_DataMapOfCurveSampleBox(tmp);
}

 void OCIntTools_DataMapOfCurveSampleBox::ReSize(Standard_Integer NbBuckets)
{
  ((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->ReSize(NbBuckets);
}

 System::Boolean OCIntTools_DataMapOfCurveSampleBox::Bind(OCNaroWrappers::OCIntTools_CurveRangeSample^ K, OCNaroWrappers::OCBnd_Box^ I)
{
  return OCConverter::StandardBooleanToBoolean(((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->Bind(*((IntTools_CurveRangeSample*)K->Handle), *((Bnd_Box*)I->Handle)));
}

 System::Boolean OCIntTools_DataMapOfCurveSampleBox::IsBound(OCNaroWrappers::OCIntTools_CurveRangeSample^ K)
{
  return OCConverter::StandardBooleanToBoolean(((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->IsBound(*((IntTools_CurveRangeSample*)K->Handle)));
}

 System::Boolean OCIntTools_DataMapOfCurveSampleBox::UnBind(OCNaroWrappers::OCIntTools_CurveRangeSample^ K)
{
  return OCConverter::StandardBooleanToBoolean(((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->UnBind(*((IntTools_CurveRangeSample*)K->Handle)));
}

OCBnd_Box^ OCIntTools_DataMapOfCurveSampleBox::Find(OCNaroWrappers::OCIntTools_CurveRangeSample^ K)
{
  Bnd_Box* tmp = new Bnd_Box();
  *tmp = ((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->Find(*((IntTools_CurveRangeSample*)K->Handle));
  return gcnew OCBnd_Box(tmp);
}

OCBnd_Box^ OCIntTools_DataMapOfCurveSampleBox::ChangeFind(OCNaroWrappers::OCIntTools_CurveRangeSample^ K)
{
  Bnd_Box* tmp = new Bnd_Box();
  *tmp = ((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->ChangeFind(*((IntTools_CurveRangeSample*)K->Handle));
  return gcnew OCBnd_Box(tmp);
}

 Standard_Address OCIntTools_DataMapOfCurveSampleBox::Find1(OCNaroWrappers::OCIntTools_CurveRangeSample^ K)
{
  return ((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->Find1(*((IntTools_CurveRangeSample*)K->Handle));
}

 Standard_Address OCIntTools_DataMapOfCurveSampleBox::ChangeFind1(OCNaroWrappers::OCIntTools_CurveRangeSample^ K)
{
  return ((IntTools_DataMapOfCurveSampleBox*)nativeHandle)->ChangeFind1(*((IntTools_CurveRangeSample*)K->Handle));
}


