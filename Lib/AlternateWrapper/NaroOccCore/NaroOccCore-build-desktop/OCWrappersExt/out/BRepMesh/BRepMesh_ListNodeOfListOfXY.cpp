// File generated by CPPExt (CPP file)
//

#include "BRepMesh_ListNodeOfListOfXY.h"
#include "../Converter.h"
#include "../gp/gp_XY.h"
#include "BRepMesh_ListOfXY.h"
#include "BRepMesh_ListIteratorOfListOfXY.h"


using namespace OCNaroWrappers;

OCBRepMesh_ListNodeOfListOfXY::OCBRepMesh_ListNodeOfListOfXY(Handle(BRepMesh_ListNodeOfListOfXY)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_BRepMesh_ListNodeOfListOfXY(*nativeHandle);
}

OCBRepMesh_ListNodeOfListOfXY::OCBRepMesh_ListNodeOfListOfXY(OCNaroWrappers::OCgp_XY^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_BRepMesh_ListNodeOfListOfXY(new BRepMesh_ListNodeOfListOfXY(*((gp_XY*)I->Handle), n));
}

OCgp_XY^ OCBRepMesh_ListNodeOfListOfXY::Value()
{
  gp_XY* tmp = new gp_XY();
  *tmp = (*((Handle_BRepMesh_ListNodeOfListOfXY*)nativeHandle))->Value();
  return gcnew OCgp_XY(tmp);
}

