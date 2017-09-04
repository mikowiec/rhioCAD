// File generated by CPPExt (MPV)
//
#ifndef _Image_PixelFieldOfDColorImage_OCWrappers_HeaderFile
#define _Image_PixelFieldOfDColorImage_OCWrappers_HeaderFile

// include native header
#include <Image_PixelFieldOfDColorImage.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCAspect_ColorPixel;



public ref class OCImage_PixelFieldOfDColorImage  {

protected:
  Image_PixelFieldOfDColorImage* nativeHandle;
  OCImage_PixelFieldOfDColorImage(OCDummy^) {};

public:
  property Image_PixelFieldOfDColorImage* Handle
  {
    Image_PixelFieldOfDColorImage* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCImage_PixelFieldOfDColorImage(Image_PixelFieldOfDColorImage* nativeHandle);

// Methods PUBLIC


OCImage_PixelFieldOfDColorImage(Standard_Integer Width, Standard_Integer Height);


OCImage_PixelFieldOfDColorImage(Standard_Integer Width, Standard_Integer Height, OCNaroWrappers::OCAspect_ColorPixel^ V);


 /*instead*/  Standard_Integer Width() ;


 /*instead*/  Standard_Integer Height() ;


 /*instead*/  Standard_Integer UpperX() ;


 /*instead*/  Standard_Integer UpperY() ;


 /*instead*/  void SetValue(Standard_Integer X, Standard_Integer Y, OCNaroWrappers::OCAspect_ColorPixel^ Value) ;


 /*instead*/  OCAspect_ColorPixel^ Value(Standard_Integer X, Standard_Integer Y) ;


 /*instead*/  OCAspect_ColorPixel^ ChangeValue(Standard_Integer X, Standard_Integer Y) ;

~OCImage_PixelFieldOfDColorImage()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
