// File generated by CPPExt (CPP file)
//

#include "IntTools_MapIteratorOfMapOfSurfaceSample.h"
#include "../Converter.h"
#include "IntTools_SurfaceRangeSample.h"
#include "IntTools_SurfaceRangeSampleMapHasher.h"
#include "IntTools_MapOfSurfaceSample.h"
#include "IntTools_StdMapNodeOfMapOfSurfaceSample.h"


using namespace OCNaroWrappers;

OCIntTools_MapIteratorOfMapOfSurfaceSample::OCIntTools_MapIteratorOfMapOfSurfaceSample(IntTools_MapIteratorOfMapOfSurfaceSample* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCIntTools_MapIteratorOfMapOfSurfaceSample::OCIntTools_MapIteratorOfMapOfSurfaceSample() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new IntTools_MapIteratorOfMapOfSurfaceSample();
}

OCIntTools_MapIteratorOfMapOfSurfaceSample::OCIntTools_MapIteratorOfMapOfSurfaceSample(OCNaroWrappers::OCIntTools_MapOfSurfaceSample^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new IntTools_MapIteratorOfMapOfSurfaceSample(*((IntTools_MapOfSurfaceSample*)aMap->Handle));
}

 void OCIntTools_MapIteratorOfMapOfSurfaceSample::Initialize(OCNaroWrappers::OCIntTools_MapOfSurfaceSample^ aMap)
{
  ((IntTools_MapIteratorOfMapOfSurfaceSample*)nativeHandle)->Initialize(*((IntTools_MapOfSurfaceSample*)aMap->Handle));
}

OCIntTools_SurfaceRangeSample^ OCIntTools_MapIteratorOfMapOfSurfaceSample::Key()
{
  IntTools_SurfaceRangeSample* tmp = new IntTools_SurfaceRangeSample();
  *tmp = ((IntTools_MapIteratorOfMapOfSurfaceSample*)nativeHandle)->Key();
  return gcnew OCIntTools_SurfaceRangeSample(tmp);
}

