// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "TopOpeBRepTool_C2DF.h"
#include "../TopTools/TopTools_OrientedShapeMapHasher.h"
#include "TopOpeBRepTool_DataMapOfOrientedShapeC2DF.h"
#include "TopOpeBRepTool_DataMapNodeOfDataMapOfOrientedShapeC2DF.h"


using namespace OCNaroWrappers;

OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF::OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF(TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF::OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF();
}

OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF::OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF(OCNaroWrappers::OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF(*((TopOpeBRepTool_DataMapOfOrientedShapeC2DF*)aMap->Handle));
}

 void OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF::Initialize(OCNaroWrappers::OCTopOpeBRepTool_DataMapOfOrientedShapeC2DF^ aMap)
{
  ((TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF*)nativeHandle)->Initialize(*((TopOpeBRepTool_DataMapOfOrientedShapeC2DF*)aMap->Handle));
}

OCTopoDS_Shape^ OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF::Key()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF*)nativeHandle)->Key();
  return gcnew OCTopoDS_Shape(tmp);
}

OCTopOpeBRepTool_C2DF^ OCTopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF::Value()
{
  TopOpeBRepTool_C2DF* tmp = new TopOpeBRepTool_C2DF();
  *tmp = ((TopOpeBRepTool_DataMapIteratorOfDataMapOfOrientedShapeC2DF*)nativeHandle)->Value();
  return gcnew OCTopOpeBRepTool_C2DF(tmp);
}


