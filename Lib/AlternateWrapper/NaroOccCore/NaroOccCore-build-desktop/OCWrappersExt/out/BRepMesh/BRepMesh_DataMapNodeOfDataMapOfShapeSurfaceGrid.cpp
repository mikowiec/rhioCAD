// File generated by CPPExt (CPP file)
//

#include "BRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid.h"
#include "../Converter.h"
#include "BRepMesh_SurfaceGrid.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_ShapeMapHasher.h"
#include "BRepMesh_DataMapOfShapeSurfaceGrid.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfShapeSurfaceGrid.h"


using namespace OCNaroWrappers;

OCBRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid::OCBRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid(Handle(BRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_BRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid(*nativeHandle);
}

OCBRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid::OCBRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid(OCNaroWrappers::OCTopoDS_Shape^ K, OCNaroWrappers::OCBRepMesh_SurfaceGrid^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_BRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid(new BRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid(*((TopoDS_Shape*)K->Handle), *((Handle_BRepMesh_SurfaceGrid*)I->Handle), n));
}

OCTopoDS_Shape^ OCBRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid::Key()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = (*((Handle_BRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid*)nativeHandle))->Key();
  return gcnew OCTopoDS_Shape(tmp);
}

OCBRepMesh_SurfaceGrid^ OCBRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid::Value()
{
  Handle(BRepMesh_SurfaceGrid) tmp = (*((Handle_BRepMesh_DataMapNodeOfDataMapOfShapeSurfaceGrid*)nativeHandle))->Value();
  return gcnew OCBRepMesh_SurfaceGrid(&tmp);
}


