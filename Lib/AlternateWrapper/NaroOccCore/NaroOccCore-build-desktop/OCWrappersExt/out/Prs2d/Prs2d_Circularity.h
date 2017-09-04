// File generated by CPPExt (Transient)
//
#ifndef _Prs2d_Circularity_OCWrappers_HeaderFile
#define _Prs2d_Circularity_OCWrappers_HeaderFile

// include the wrapped class
#include <Prs2d_Circularity.hxx>
#include "../Converter.h"

#include "Prs2d_Tolerance.h"



namespace OCNaroWrappers
{

ref class OCGraphic2d_GraphicObject;
ref class OCGraphic2d_Drawer;



public ref class OCPrs2d_Circularity : OCPrs2d_Tolerance {

protected:
  // dummy constructor;
  OCPrs2d_Circularity(OCDummy^) : OCPrs2d_Tolerance((OCDummy^)nullptr) {};

public:

// constructor from native
OCPrs2d_Circularity(Handle(Prs2d_Circularity)* nativeHandle);

// Methods PUBLIC

//! Creates a tolerance Circularity with the center at <aX>, <aY>; <br>
//!          length of this is <aLength>; <br>
//!          reference point is <aXPosition>, <aYPosition> <br>
OCPrs2d_Circularity(OCNaroWrappers::OCGraphic2d_GraphicObject^ aGO, Standard_Real aX, Standard_Real aY, Standard_Real aLength, Standard_Real anAngle);


virtual /*instead*/  void Save(Aspect_FStream& aFStream) ;

~OCPrs2d_Circularity()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
