// File generated by CPPExt (CPP file)
//

#include "BRepFill_DataMapOfOrientedShapeListOfShape.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_ListOfShape.h"
#include "../TopTools/TopTools_OrientedShapeMapHasher.h"
#include "BRepFill_DataMapNodeOfDataMapOfOrientedShapeListOfShape.h"
#include "BRepFill_DataMapIteratorOfDataMapOfOrientedShapeListOfShape.h"


using namespace OCNaroWrappers;

OCBRepFill_DataMapOfOrientedShapeListOfShape::OCBRepFill_DataMapOfOrientedShapeListOfShape(BRepFill_DataMapOfOrientedShapeListOfShape* nativeHandle) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBRepFill_DataMapOfOrientedShapeListOfShape::OCBRepFill_DataMapOfOrientedShapeListOfShape(Standard_Integer NbBuckets) : OCTCollection_BasicMap((OCDummy^)nullptr)

{
  nativeHandle = new BRepFill_DataMapOfOrientedShapeListOfShape(NbBuckets);
}

OCBRepFill_DataMapOfOrientedShapeListOfShape^ OCBRepFill_DataMapOfOrientedShapeListOfShape::Assign(OCNaroWrappers::OCBRepFill_DataMapOfOrientedShapeListOfShape^ Other)
{
  BRepFill_DataMapOfOrientedShapeListOfShape* tmp = new BRepFill_DataMapOfOrientedShapeListOfShape(0);
  *tmp = ((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->Assign(*((BRepFill_DataMapOfOrientedShapeListOfShape*)Other->Handle));
  return gcnew OCBRepFill_DataMapOfOrientedShapeListOfShape(tmp);
}

 void OCBRepFill_DataMapOfOrientedShapeListOfShape::ReSize(Standard_Integer NbBuckets)
{
  ((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->ReSize(NbBuckets);
}

 System::Boolean OCBRepFill_DataMapOfOrientedShapeListOfShape::Bind(OCNaroWrappers::OCTopoDS_Shape^ K, OCNaroWrappers::OCTopTools_ListOfShape^ I)
{
  return OCConverter::StandardBooleanToBoolean(((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->Bind(*((TopoDS_Shape*)K->Handle), *((TopTools_ListOfShape*)I->Handle)));
}

 System::Boolean OCBRepFill_DataMapOfOrientedShapeListOfShape::IsBound(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return OCConverter::StandardBooleanToBoolean(((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->IsBound(*((TopoDS_Shape*)K->Handle)));
}

 System::Boolean OCBRepFill_DataMapOfOrientedShapeListOfShape::UnBind(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return OCConverter::StandardBooleanToBoolean(((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->UnBind(*((TopoDS_Shape*)K->Handle)));
}

OCTopTools_ListOfShape^ OCBRepFill_DataMapOfOrientedShapeListOfShape::Find(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  TopTools_ListOfShape* tmp = new TopTools_ListOfShape();
  *tmp = ((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->Find(*((TopoDS_Shape*)K->Handle));
  return gcnew OCTopTools_ListOfShape(tmp);
}

OCTopTools_ListOfShape^ OCBRepFill_DataMapOfOrientedShapeListOfShape::ChangeFind(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  TopTools_ListOfShape* tmp = new TopTools_ListOfShape();
  *tmp = ((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->ChangeFind(*((TopoDS_Shape*)K->Handle));
  return gcnew OCTopTools_ListOfShape(tmp);
}

 Standard_Address OCBRepFill_DataMapOfOrientedShapeListOfShape::Find1(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->Find1(*((TopoDS_Shape*)K->Handle));
}

 Standard_Address OCBRepFill_DataMapOfOrientedShapeListOfShape::ChangeFind1(OCNaroWrappers::OCTopoDS_Shape^ K)
{
  return ((BRepFill_DataMapOfOrientedShapeListOfShape*)nativeHandle)->ChangeFind1(*((TopoDS_Shape*)K->Handle));
}

