// File generated by CPPExt (CPP file)
//

#include "TopTools_ListNodeOfListOfShape.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "TopTools_ListOfShape.h"
#include "TopTools_ListIteratorOfListOfShape.h"


using namespace OCNaroWrappers;

OCTopTools_ListNodeOfListOfShape::OCTopTools_ListNodeOfListOfShape(Handle(TopTools_ListNodeOfListOfShape)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TopTools_ListNodeOfListOfShape(*nativeHandle);
}

OCTopTools_ListNodeOfListOfShape::OCTopTools_ListNodeOfListOfShape(OCNaroWrappers::OCTopoDS_Shape^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TopTools_ListNodeOfListOfShape(new TopTools_ListNodeOfListOfShape(*((TopoDS_Shape*)I->Handle), n));
}

OCTopoDS_Shape^ OCTopTools_ListNodeOfListOfShape::Value()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = (*((Handle_TopTools_ListNodeOfListOfShape*)nativeHandle))->Value();
  return gcnew OCTopoDS_Shape(tmp);
}


