// File generated by CPPExt (CPP file)
//

#include "TNaming_DataMapIteratorOfDataMapOfShapeShapesSet.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "TNaming_ShapesSet.h"
#include "../TopTools/TopTools_ShapeMapHasher.h"
#include "TNaming_DataMapOfShapeShapesSet.h"
#include "TNaming_DataMapNodeOfDataMapOfShapeShapesSet.h"


using namespace OCNaroWrappers;

OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet::OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet(TNaming_DataMapIteratorOfDataMapOfShapeShapesSet* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet::OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TNaming_DataMapIteratorOfDataMapOfShapeShapesSet();
}

OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet::OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet(OCNaroWrappers::OCTNaming_DataMapOfShapeShapesSet^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TNaming_DataMapIteratorOfDataMapOfShapeShapesSet(*((TNaming_DataMapOfShapeShapesSet*)aMap->Handle));
}

 void OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet::Initialize(OCNaroWrappers::OCTNaming_DataMapOfShapeShapesSet^ aMap)
{
  ((TNaming_DataMapIteratorOfDataMapOfShapeShapesSet*)nativeHandle)->Initialize(*((TNaming_DataMapOfShapeShapesSet*)aMap->Handle));
}

OCTopoDS_Shape^ OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet::Key()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((TNaming_DataMapIteratorOfDataMapOfShapeShapesSet*)nativeHandle)->Key();
  return gcnew OCTopoDS_Shape(tmp);
}

OCTNaming_ShapesSet^ OCTNaming_DataMapIteratorOfDataMapOfShapeShapesSet::Value()
{
  TNaming_ShapesSet* tmp = new TNaming_ShapesSet();
  *tmp = ((TNaming_DataMapIteratorOfDataMapOfShapeShapesSet*)nativeHandle)->Value();
  return gcnew OCTNaming_ShapesSet(tmp);
}


