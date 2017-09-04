// File generated by CPPExt (CPP file)
//

#include "MAT_DataMapNodeOfDataMapOfIntegerNode.h"
#include "../Converter.h"
#include "MAT_Node.h"
#include "../TColStd/TColStd_MapIntegerHasher.h"
#include "MAT_DataMapOfIntegerNode.h"
#include "MAT_DataMapIteratorOfDataMapOfIntegerNode.h"


using namespace OCNaroWrappers;

OCMAT_DataMapNodeOfDataMapOfIntegerNode::OCMAT_DataMapNodeOfDataMapOfIntegerNode(Handle(MAT_DataMapNodeOfDataMapOfIntegerNode)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_MAT_DataMapNodeOfDataMapOfIntegerNode(*nativeHandle);
}

OCMAT_DataMapNodeOfDataMapOfIntegerNode::OCMAT_DataMapNodeOfDataMapOfIntegerNode(Standard_Integer K, OCNaroWrappers::OCMAT_Node^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_MAT_DataMapNodeOfDataMapOfIntegerNode(new MAT_DataMapNodeOfDataMapOfIntegerNode(K, *((Handle_MAT_Node*)I->Handle), n));
}

 Standard_Integer OCMAT_DataMapNodeOfDataMapOfIntegerNode::Key()
{
  return (*((Handle_MAT_DataMapNodeOfDataMapOfIntegerNode*)nativeHandle))->Key();
}

OCMAT_Node^ OCMAT_DataMapNodeOfDataMapOfIntegerNode::Value()
{
  Handle(MAT_Node) tmp = (*((Handle_MAT_DataMapNodeOfDataMapOfIntegerNode*)nativeHandle))->Value();
  return gcnew OCMAT_Node(&tmp);
}


