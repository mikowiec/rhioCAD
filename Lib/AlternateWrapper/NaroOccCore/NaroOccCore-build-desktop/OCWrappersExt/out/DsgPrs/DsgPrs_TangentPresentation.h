// File generated by CPPExt (MPV)
//
#ifndef _DsgPrs_TangentPresentation_OCWrappers_HeaderFile
#define _DsgPrs_TangentPresentation_OCWrappers_HeaderFile

// include native header
#include <DsgPrs_TangentPresentation.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCPrs3d_Presentation;
ref class OCPrs3d_Drawer;
ref class OCgp_Pnt;
ref class OCgp_Dir;


//! A framework to define display of tangents. <br>
public ref class OCDsgPrs_TangentPresentation  {

protected:
  DsgPrs_TangentPresentation* nativeHandle;
  OCDsgPrs_TangentPresentation(OCDummy^) {};

public:
  property DsgPrs_TangentPresentation* Handle
  {
    DsgPrs_TangentPresentation* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCDsgPrs_TangentPresentation(DsgPrs_TangentPresentation* nativeHandle);

// Methods PUBLIC

//! Adds the point OffsetPoint, the direction aDirection <br>
//! and the length aLength to the presentation object aPresentation. <br>
//! The display attributes of the tangent are defined by <br>
//! the attribute manager aDrawer. <br>
static /*instead*/  void Add(OCNaroWrappers::OCPrs3d_Presentation^ aPresentation, OCNaroWrappers::OCPrs3d_Drawer^ aDrawer, OCNaroWrappers::OCgp_Pnt^ OffsetPoint, OCNaroWrappers::OCgp_Dir^ aDirection, Standard_Real aLength) ;

~OCDsgPrs_TangentPresentation()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
