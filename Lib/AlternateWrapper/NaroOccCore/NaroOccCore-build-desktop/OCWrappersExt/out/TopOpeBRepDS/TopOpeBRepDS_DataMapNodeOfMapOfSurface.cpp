// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepDS_DataMapNodeOfMapOfSurface.h"
#include "../Converter.h"
#include "TopOpeBRepDS_SurfaceData.h"
#include "../TColStd/TColStd_MapIntegerHasher.h"
#include "TopOpeBRepDS_MapOfSurface.h"
#include "TopOpeBRepDS_DataMapIteratorOfMapOfSurface.h"


using namespace OCNaroWrappers;

OCTopOpeBRepDS_DataMapNodeOfMapOfSurface::OCTopOpeBRepDS_DataMapNodeOfMapOfSurface(Handle(TopOpeBRepDS_DataMapNodeOfMapOfSurface)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TopOpeBRepDS_DataMapNodeOfMapOfSurface(*nativeHandle);
}

OCTopOpeBRepDS_DataMapNodeOfMapOfSurface::OCTopOpeBRepDS_DataMapNodeOfMapOfSurface(Standard_Integer K, OCNaroWrappers::OCTopOpeBRepDS_SurfaceData^ I, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TopOpeBRepDS_DataMapNodeOfMapOfSurface(new TopOpeBRepDS_DataMapNodeOfMapOfSurface(K, *((TopOpeBRepDS_SurfaceData*)I->Handle), n));
}

 Standard_Integer OCTopOpeBRepDS_DataMapNodeOfMapOfSurface::Key()
{
  return (*((Handle_TopOpeBRepDS_DataMapNodeOfMapOfSurface*)nativeHandle))->Key();
}

OCTopOpeBRepDS_SurfaceData^ OCTopOpeBRepDS_DataMapNodeOfMapOfSurface::Value()
{
  TopOpeBRepDS_SurfaceData* tmp = new TopOpeBRepDS_SurfaceData();
  *tmp = (*((Handle_TopOpeBRepDS_DataMapNodeOfMapOfSurface*)nativeHandle))->Value();
  return gcnew OCTopOpeBRepDS_SurfaceData(tmp);
}


