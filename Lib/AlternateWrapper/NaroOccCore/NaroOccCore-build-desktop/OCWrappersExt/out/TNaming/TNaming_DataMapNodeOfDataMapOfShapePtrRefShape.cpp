// File generated by CPPExt (CPP file)
//

#include "TNaming_DataMapNodeOfDataMapOfShapePtrRefShape.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_ShapeMapHasher.h"
#include "TNaming_DataMapOfShapePtrRefShape.h"
#include "TNaming_DataMapIteratorOfDataMapOfShapePtrRefShape.h"


using namespace OCNaroWrappers;

OCTNaming_DataMapNodeOfDataMapOfShapePtrRefShape::OCTNaming_DataMapNodeOfDataMapOfShapePtrRefShape(Handle(TNaming_DataMapNodeOfDataMapOfShapePtrRefShape)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TNaming_DataMapNodeOfDataMapOfShapePtrRefShape(*nativeHandle);
}

OCTNaming_DataMapNodeOfDataMapOfShapePtrRefShape::OCTNaming_DataMapNodeOfDataMapOfShapePtrRefShape(OCNaroWrappers::OCTopoDS_Shape^ K, TNaming_PtrRefShape I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TNaming_DataMapNodeOfDataMapOfShapePtrRefShape(new TNaming_DataMapNodeOfDataMapOfShapePtrRefShape(*((TopoDS_Shape*)K->Handle), I, n));
}

OCTopoDS_Shape^ OCTNaming_DataMapNodeOfDataMapOfShapePtrRefShape::Key()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = (*((Handle_TNaming_DataMapNodeOfDataMapOfShapePtrRefShape*)nativeHandle))->Key();
  return gcnew OCTopoDS_Shape(tmp);
}

 TNaming_PtrRefShape& OCTNaming_DataMapNodeOfDataMapOfShapePtrRefShape::Value()
{
  return (*((Handle_TNaming_DataMapNodeOfDataMapOfShapePtrRefShape*)nativeHandle))->Value();
}


