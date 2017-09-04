// File generated by CPPExt (CPP file)
//

#include "IntTools_IndexedDataMapOfShapeAddress.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_ShapeMapHasher.h"
#include "IntTools_IndexedDataMapNodeOfIndexedDataMapOfShapeAddress.h"


using namespace OCNaroWrappers;

OCIntTools_IndexedDataMapOfShapeAddress::OCIntTools_IndexedDataMapOfShapeAddress(IntTools_IndexedDataMapOfShapeAddress* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCIntTools_IndexedDataMapOfShapeAddress::OCIntTools_IndexedDataMapOfShapeAddress(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new IntTools_IndexedDataMapOfShapeAddress(NbBuckets);
}

OCIntTools_IndexedDataMapOfShapeAddress^ OCIntTools_IndexedDataMapOfShapeAddress::Assign(OCNaroWrappers::OCIntTools_IndexedDataMapOfShapeAddress^ Other)
{
  IntTools_IndexedDataMapOfShapeAddress* tmp = new IntTools_IndexedDataMapOfShapeAddress(0);
  *tmp = ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->Assign(*((IntTools_IndexedDataMapOfShapeAddress*)Other->Handle));
  return gcnew OCIntTools_IndexedDataMapOfShapeAddress(tmp);
}

 void OCIntTools_IndexedDataMapOfShapeAddress::ReSize(Standard_Integer NbBuckets)
{
  ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->ReSize(NbBuckets);
}

 Standard_Integer OCIntTools_IndexedDataMapOfShapeAddress::Add(OCNaroWrappers::OCTopoDS_Shape^ K, Standard_Address I)
{
  return ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->Add(*((TopoDS_Shape*)K->Handle), I);
}

 void OCIntTools_IndexedDataMapOfShapeAddress::Substitute(Standard_Integer I, OCNaroWrappers::OCTopoDS_Shape^ K, Standard_Address T)
{
  ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->Substitute(I, *((TopoDS_Shape*)K->Handle), T);
}

 void OCIntTools_IndexedDataMapOfShapeAddress::RemoveLast()
{
  ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->RemoveLast();
}

 System::Boolean OCIntTools_IndexedDataMapOfShapeAddress::Contains(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return OCConverter::StandardBooleanToBoolean(((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->Contains(*((TopoDS_Shape*)K->Handle)));
}

OCTopoDS_Shape^ OCIntTools_IndexedDataMapOfShapeAddress::FindKey(Standard_Integer I)
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->FindKey(I);
  return gcnew OCTopoDS_Shape(tmp);
}

 Standard_Address OCIntTools_IndexedDataMapOfShapeAddress::FindFromIndex(Standard_Integer I)
{
  return ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->FindFromIndex(I);
}

 Standard_Address OCIntTools_IndexedDataMapOfShapeAddress::ChangeFromIndex(Standard_Integer I)
{
  return ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->ChangeFromIndex(I);
}

 Standard_Integer OCIntTools_IndexedDataMapOfShapeAddress::FindIndex(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->FindIndex(*((TopoDS_Shape*)K->Handle));
}

 Standard_Address OCIntTools_IndexedDataMapOfShapeAddress::FindFromKey(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->FindFromKey(*((TopoDS_Shape*)K->Handle));
}

 Standard_Address OCIntTools_IndexedDataMapOfShapeAddress::ChangeFromKey(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((IntTools_IndexedDataMapOfShapeAddress*)nativeHandle)->ChangeFromKey(*((TopoDS_Shape*)K->Handle));
}


