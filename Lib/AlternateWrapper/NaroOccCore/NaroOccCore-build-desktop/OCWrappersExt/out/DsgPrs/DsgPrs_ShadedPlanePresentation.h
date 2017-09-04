// File generated by CPPExt (MPV)
//
#ifndef _DsgPrs_ShadedPlanePresentation_OCWrappers_HeaderFile
#define _DsgPrs_ShadedPlanePresentation_OCWrappers_HeaderFile

// include native header
#include <DsgPrs_ShadedPlanePresentation.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCPrs3d_Presentation;
ref class OCPrs3d_Drawer;
ref class OCgp_Pnt;


//! A framework to define display of shaded planes. <br>
public ref class OCDsgPrs_ShadedPlanePresentation  {

protected:
  DsgPrs_ShadedPlanePresentation* nativeHandle;
  OCDsgPrs_ShadedPlanePresentation(OCDummy^) {};

public:
  property DsgPrs_ShadedPlanePresentation* Handle
  {
    DsgPrs_ShadedPlanePresentation* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCDsgPrs_ShadedPlanePresentation(DsgPrs_ShadedPlanePresentation* nativeHandle);

// Methods PUBLIC

//! Adds the points aPt1, aPt2 and aPt3 to the <br>
//! presentation object, aPresentation. <br>
//! The display attributes of the shaded plane are <br>
//! defined by the attribute manager aDrawer. <br>
static /*instead*/  void Add(OCNaroWrappers::OCPrs3d_Presentation^ aPresentation, OCNaroWrappers::OCPrs3d_Drawer^ aDrawer, OCNaroWrappers::OCgp_Pnt^ aPt1, OCNaroWrappers::OCgp_Pnt^ aPt2, OCNaroWrappers::OCgp_Pnt^ aPt3) ;

~OCDsgPrs_ShadedPlanePresentation()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
