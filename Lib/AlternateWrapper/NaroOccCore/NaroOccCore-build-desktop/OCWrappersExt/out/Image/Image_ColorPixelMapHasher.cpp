// File generated by CPPExt (CPP file)
//

#include "Image_ColorPixelMapHasher.h"
#include "../Converter.h"
#include "../Aspect/Aspect_ColorPixel.h"


using namespace OCNaroWrappers;

OCImage_ColorPixelMapHasher::OCImage_ColorPixelMapHasher(Image_ColorPixelMapHasher* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 Standard_Integer OCImage_ColorPixelMapHasher::HashCode(OCNaroWrappers::OCAspect_ColorPixel^ K, Standard_Integer Upper)
{
  return Image_ColorPixelMapHasher::HashCode(*((Aspect_ColorPixel*)K->Handle), Upper);
}

 System::Boolean OCImage_ColorPixelMapHasher::IsEqual(OCNaroWrappers::OCAspect_ColorPixel^ K1, OCNaroWrappers::OCAspect_ColorPixel^ K2)
{
  return OCConverter::StandardBooleanToBoolean(Image_ColorPixelMapHasher::IsEqual(*((Aspect_ColorPixel*)K1->Handle), *((Aspect_ColorPixel*)K2->Handle)));
}


