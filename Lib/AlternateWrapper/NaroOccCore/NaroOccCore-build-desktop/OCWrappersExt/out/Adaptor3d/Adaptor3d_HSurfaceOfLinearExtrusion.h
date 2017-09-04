// File generated by CPPExt (Transient)
//
#ifndef _Adaptor3d_HSurfaceOfLinearExtrusion_OCWrappers_HeaderFile
#define _Adaptor3d_HSurfaceOfLinearExtrusion_OCWrappers_HeaderFile

// include the wrapped class
#include <Adaptor3d_HSurfaceOfLinearExtrusion.hxx>
#include "../Converter.h"

#include "Adaptor3d_HSurface.h"

#include "Adaptor3d_SurfaceOfLinearExtrusion.h"


namespace OCNaroWrappers
{

ref class OCAdaptor3d_SurfaceOfLinearExtrusion;
ref class OCAdaptor3d_Surface;



public ref class OCAdaptor3d_HSurfaceOfLinearExtrusion : OCAdaptor3d_HSurface {

protected:
  // dummy constructor;
  OCAdaptor3d_HSurfaceOfLinearExtrusion(OCDummy^) : OCAdaptor3d_HSurface((OCDummy^)nullptr) {};

public:

// constructor from native
OCAdaptor3d_HSurfaceOfLinearExtrusion(Handle(Adaptor3d_HSurfaceOfLinearExtrusion)* nativeHandle);

// Methods PUBLIC


OCAdaptor3d_HSurfaceOfLinearExtrusion();


OCAdaptor3d_HSurfaceOfLinearExtrusion(OCNaroWrappers::OCAdaptor3d_SurfaceOfLinearExtrusion^ S);


 /*instead*/  void Set(OCNaroWrappers::OCAdaptor3d_SurfaceOfLinearExtrusion^ S) ;


 /*instead*/  OCAdaptor3d_Surface^ Surface() ;


 /*instead*/  OCAdaptor3d_SurfaceOfLinearExtrusion^ ChangeSurface() ;

~OCAdaptor3d_HSurfaceOfLinearExtrusion()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
