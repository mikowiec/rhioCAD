// File generated by CPPExt (CPP file)
//

#include "Xw_PixMap.h"
#include "../Converter.h"
#include "Xw_Window.h"
#include "../Aspect/Aspect_Window.h"


using namespace OCNaroWrappers;

OCXw_PixMap::OCXw_PixMap(Handle(Xw_PixMap)* nativeHandle) : OCAspect_PixMap((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Xw_PixMap(*nativeHandle);
}

OCXw_PixMap::OCXw_PixMap(OCNaroWrappers::OCAspect_Window^ aWindow, Standard_Integer aWidth, Standard_Integer anHeight, Standard_Integer aDepth) : OCAspect_PixMap((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Xw_PixMap(new Xw_PixMap(*((Handle_Aspect_Window*)aWindow->Handle), aWidth, anHeight, aDepth));
}

 void OCXw_PixMap::Destroy()
{
  (*((Handle_Xw_PixMap*)nativeHandle))->Destroy();
}

 System::Boolean OCXw_PixMap::Dump(System::String^ aFilename, Standard_Real aGammaValue)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Xw_PixMap*)nativeHandle))->Dump(OCConverter::StringToStandardCString(aFilename), aGammaValue));
}

 System::IntPtr OCXw_PixMap::PixmapID()
{
  return System::IntPtr((*((Handle_Xw_PixMap*)nativeHandle))->PixmapID());
}

