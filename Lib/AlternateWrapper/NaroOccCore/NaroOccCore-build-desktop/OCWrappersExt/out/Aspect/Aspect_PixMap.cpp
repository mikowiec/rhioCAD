// File generated by CPPExt (CPP file)
//

#include "Aspect_PixMap.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCAspect_PixMap::OCAspect_PixMap(Handle(Aspect_PixMap)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Aspect_PixMap(*nativeHandle);
}

OCAspect_PixMap::OCAspect_PixMap(Standard_Integer aWidth, Standard_Integer anHeight, Standard_Integer aDepth) : OCMMgt_TShared((OCDummy^)nullptr)

{}

 void OCAspect_PixMap::Size(Standard_Integer& aWidth, Standard_Integer& anHeight)
{
  (*((Handle_Aspect_PixMap*)nativeHandle))->Size(aWidth, anHeight);
}

 Standard_Integer OCAspect_PixMap::Depth()
{
  return (*((Handle_Aspect_PixMap*)nativeHandle))->Depth();
}


