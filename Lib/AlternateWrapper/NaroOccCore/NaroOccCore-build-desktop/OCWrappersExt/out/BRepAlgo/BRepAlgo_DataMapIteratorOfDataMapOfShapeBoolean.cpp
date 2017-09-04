// File generated by CPPExt (CPP file)
//

#include "BRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_ShapeMapHasher.h"
#include "BRepAlgo_DataMapOfShapeBoolean.h"
#include "BRepAlgo_DataMapNodeOfDataMapOfShapeBoolean.h"


using namespace OCNaroWrappers;

OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean::OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean(BRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean::OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new BRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean();
}

OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean::OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean(OCNaroWrappers::OCBRepAlgo_DataMapOfShapeBoolean^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new BRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean(*((BRepAlgo_DataMapOfShapeBoolean*)aMap->Handle));
}

 void OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean::Initialize(OCNaroWrappers::OCBRepAlgo_DataMapOfShapeBoolean^ aMap)
{
  ((BRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean*)nativeHandle)->Initialize(*((BRepAlgo_DataMapOfShapeBoolean*)aMap->Handle));
}

OCTopoDS_Shape^ OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean::Key()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((BRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean*)nativeHandle)->Key();
  return gcnew OCTopoDS_Shape(tmp);
}

 System::Boolean OCBRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean::Value()
{
  return OCConverter::StandardBooleanToBoolean(((BRepAlgo_DataMapIteratorOfDataMapOfShapeBoolean*)nativeHandle)->Value());
}


