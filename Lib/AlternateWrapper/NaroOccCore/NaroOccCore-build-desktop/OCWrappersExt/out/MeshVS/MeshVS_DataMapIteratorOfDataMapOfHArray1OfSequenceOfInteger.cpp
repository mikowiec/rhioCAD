// File generated by CPPExt (CPP file)
//

#include "MeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger.h"
#include "../Converter.h"
#include "MeshVS_HArray1OfSequenceOfInteger.h"
#include "../TColStd/TColStd_MapIntegerHasher.h"
#include "MeshVS_DataMapOfHArray1OfSequenceOfInteger.h"
#include "MeshVS_DataMapNodeOfDataMapOfHArray1OfSequenceOfInteger.h"


using namespace OCNaroWrappers;

OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger::OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger(MeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger::OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new MeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger();
}

OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger::OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger(OCNaroWrappers::OCMeshVS_DataMapOfHArray1OfSequenceOfInteger^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new MeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger(*((MeshVS_DataMapOfHArray1OfSequenceOfInteger*)aMap->Handle));
}

 void OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger::Initialize(OCNaroWrappers::OCMeshVS_DataMapOfHArray1OfSequenceOfInteger^ aMap)
{
  ((MeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger*)nativeHandle)->Initialize(*((MeshVS_DataMapOfHArray1OfSequenceOfInteger*)aMap->Handle));
}

 Standard_Integer OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger::Key()
{
  return ((MeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger*)nativeHandle)->Key();
}

OCMeshVS_HArray1OfSequenceOfInteger^ OCMeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger::Value()
{
  Handle(MeshVS_HArray1OfSequenceOfInteger) tmp = ((MeshVS_DataMapIteratorOfDataMapOfHArray1OfSequenceOfInteger*)nativeHandle)->Value();
  return gcnew OCMeshVS_HArray1OfSequenceOfInteger(&tmp);
}


