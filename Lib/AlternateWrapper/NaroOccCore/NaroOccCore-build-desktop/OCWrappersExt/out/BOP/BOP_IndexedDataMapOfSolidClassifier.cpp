// File generated by CPPExt (CPP file)
//

#include "BOP_IndexedDataMapOfSolidClassifier.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_ShapeMapHasher.h"
#include "BOP_IndexedDataMapNodeOfIndexedDataMapOfSolidClassifier.h"


using namespace OCNaroWrappers;

OCBOP_IndexedDataMapOfSolidClassifier::OCBOP_IndexedDataMapOfSolidClassifier(BOP_IndexedDataMapOfSolidClassifier* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBOP_IndexedDataMapOfSolidClassifier::OCBOP_IndexedDataMapOfSolidClassifier(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new BOP_IndexedDataMapOfSolidClassifier(NbBuckets);
}

OCBOP_IndexedDataMapOfSolidClassifier^ OCBOP_IndexedDataMapOfSolidClassifier::Assign(OCNaroWrappers::OCBOP_IndexedDataMapOfSolidClassifier^ Other)
{
  BOP_IndexedDataMapOfSolidClassifier* tmp = new BOP_IndexedDataMapOfSolidClassifier(0);
  *tmp = ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->Assign(*((BOP_IndexedDataMapOfSolidClassifier*)Other->Handle));
  return gcnew OCBOP_IndexedDataMapOfSolidClassifier(tmp);
}

 void OCBOP_IndexedDataMapOfSolidClassifier::ReSize(Standard_Integer NbBuckets)
{
  ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->ReSize(NbBuckets);
}

 Standard_Integer OCBOP_IndexedDataMapOfSolidClassifier::Add(OCNaroWrappers::OCTopoDS_Shape^ K, BOP_PSoClassif I)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->Add(*((TopoDS_Shape*)K->Handle), I);
}

 void OCBOP_IndexedDataMapOfSolidClassifier::Substitute(Standard_Integer I, OCNaroWrappers::OCTopoDS_Shape^ K, BOP_PSoClassif T)
{
  ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->Substitute(I, *((TopoDS_Shape*)K->Handle), T);
}

 void OCBOP_IndexedDataMapOfSolidClassifier::RemoveLast()
{
  ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->RemoveLast();
}

 System::Boolean OCBOP_IndexedDataMapOfSolidClassifier::Contains(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return OCConverter::StandardBooleanToBoolean(((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->Contains(*((TopoDS_Shape*)K->Handle)));
}

OCTopoDS_Shape^ OCBOP_IndexedDataMapOfSolidClassifier::FindKey(Standard_Integer I)
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->FindKey(I);
  return gcnew OCTopoDS_Shape(tmp);
}

 BOP_PSoClassif& OCBOP_IndexedDataMapOfSolidClassifier::FindFromIndex(Standard_Integer I)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->FindFromIndex(I);
}

 BOP_PSoClassif& OCBOP_IndexedDataMapOfSolidClassifier::ChangeFromIndex(Standard_Integer I)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->ChangeFromIndex(I);
}

 Standard_Integer OCBOP_IndexedDataMapOfSolidClassifier::FindIndex(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->FindIndex(*((TopoDS_Shape*)K->Handle));
}

 BOP_PSoClassif& OCBOP_IndexedDataMapOfSolidClassifier::FindFromKey(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->FindFromKey(*((TopoDS_Shape*)K->Handle));
}

 BOP_PSoClassif& OCBOP_IndexedDataMapOfSolidClassifier::ChangeFromKey(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->ChangeFromKey(*((TopoDS_Shape*)K->Handle));
}

 Standard_Address OCBOP_IndexedDataMapOfSolidClassifier::FindFromKey1(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->FindFromKey1(*((TopoDS_Shape*)K->Handle));
}

 Standard_Address OCBOP_IndexedDataMapOfSolidClassifier::ChangeFromKey1(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((BOP_IndexedDataMapOfSolidClassifier*)nativeHandle)->ChangeFromKey1(*((TopoDS_Shape*)K->Handle));
}


