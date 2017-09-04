// File generated by CPPExt (CPP file)
//

#include "BRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_MapOfShape.h"
#include "../TopTools/TopTools_ShapeMapHasher.h"
#include "BRepOffset_DataMapOfShapeMapOfShape.h"
#include "BRepOffset_DataMapNodeOfDataMapOfShapeMapOfShape.h"


using namespace OCNaroWrappers;

OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape::OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape(BRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape::OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new BRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape();
}

OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape::OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape(OCNaroWrappers::OCBRepOffset_DataMapOfShapeMapOfShape^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new BRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape(*((BRepOffset_DataMapOfShapeMapOfShape*)aMap->Handle));
}

 void OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape::Initialize(OCNaroWrappers::OCBRepOffset_DataMapOfShapeMapOfShape^ aMap)
{
  ((BRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape*)nativeHandle)->Initialize(*((BRepOffset_DataMapOfShapeMapOfShape*)aMap->Handle));
}

OCTopoDS_Shape^ OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape::Key()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((BRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape*)nativeHandle)->Key();
  return gcnew OCTopoDS_Shape(tmp);
}

OCTopTools_MapOfShape^ OCBRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape::Value()
{
  TopTools_MapOfShape* tmp = new TopTools_MapOfShape(0);
  *tmp = ((BRepOffset_DataMapIteratorOfDataMapOfShapeMapOfShape*)nativeHandle)->Value();
  return gcnew OCTopTools_MapOfShape(tmp);
}


