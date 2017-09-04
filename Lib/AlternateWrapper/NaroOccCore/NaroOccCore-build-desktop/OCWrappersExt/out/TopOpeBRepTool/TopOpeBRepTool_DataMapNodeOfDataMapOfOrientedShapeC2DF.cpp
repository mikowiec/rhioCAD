// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "TopOpeBRepTool_C2DF.h"
#include "../TopTools/TopTools_OrientedShapeMapHasher.h"
#include "TopOpeBRepTool_DataMapOfOrientedShapeC2DF.h"
#include "TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF.h"


using namespace OCNaroWrappers;

OCTopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF::OCTopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF(Handle(TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF(*nativeHandle);
}

OCTopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF::OCTopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF(OCNaroWrappers::OCTopoDS_Shape^ K, OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF(new TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF(*((TopoDS_Shape*)K->Handle), *((TopOpeBRepTool_C2DF*)I->Handle), n));
}

OCTopoDS_Shape^ OCTopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF::Key()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = (*((Handle_TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF*)nativeHandle))->Key();
  return gcnew OCTopoDS_Shape(tmp);
}

OCTopOpeBRepTool_C2DF^ OCTopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF::Value()
{
  TopOpeBRepTool_C2DF* tmp = new TopOpeBRepTool_C2DF();
  *tmp = (*((Handle_TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF*)nativeHandle))->Value();
  return gcnew OCTopOpeBRepTool_C2DF(tmp);
}


