// File generated by CPPExt (Transient)
//
#ifndef _WNT_Icon_OCWrappers_HeaderFile
#define _WNT_Icon_OCWrappers_HeaderFile

// include the wrapped class
#include <WNT_Icon.hxx>
#include "../Converter.h"

#include "WNT_Image.h"



namespace OCNaroWrappers
{

ref class OCWNT_ImageManager;
ref class OCWNT_IconBox;


//! Internal class for icon management <br>
public ref class OCWNT_Icon : OCWNT_Image {

protected:
  // dummy constructor;
  OCWNT_Icon(OCDummy^) : OCWNT_Image((OCDummy^)nullptr) {};

public:

// constructor from native
OCWNT_Icon(Handle(WNT_Icon)* nativeHandle);

// Methods PUBLIC

//! Creates a class. <br>
OCWNT_Icon(System::String^ aName, System::IntPtr aBitmap, Standard_Integer aHashCode);

//! Sets a name for icon. <br>
 /*instead*/  void SetName(System::String^ aName) ;

~OCWNT_Icon()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
