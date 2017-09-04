// File generated by CPPExt (Transient)
//
#ifndef _AIS_Chamf2dDimension_OCWrappers_HeaderFile
#define _AIS_Chamf2dDimension_OCWrappers_HeaderFile

// include the wrapped class
#include <AIS_Chamf2dDimension.hxx>
#include "../Converter.h"

#include "AIS_Relation.h"

#include "../gp/gp_Pnt.h"
#include "../gp/gp_Dir.h"
#include "../DsgPrs/DsgPrs_ArrowSide.h"
#include "AIS_KindOfDimension.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCGeom_Plane;
ref class OCTCollection_ExtendedString;
ref class OCgp_Pnt;
ref class OCPrsMgr_PresentationManager3d;
ref class OCPrs3d_Presentation;
ref class OCPrs3d_Projector;
ref class OCPrsMgr_PresentationManager2d;
ref class OCGraphic2d_GraphicObject;
ref class OCGeom_Transformation;
ref class OCSelectMgr_Selection;


//! A framework to define display of 2D chamfers. <br>
//! A chamfer is displayed with arrows and text. The text <br>
//! gives the length of the chamfer if it is a symmetrical <br>
//! chamfer, or the angle if it is not. <br>
public ref class OCAIS_Chamf2dDimension : OCAIS_Relation {

protected:
  // dummy constructor;
  OCAIS_Chamf2dDimension(OCDummy^) : OCAIS_Relation((OCDummy^)nullptr) {};

public:

// constructor from native
OCAIS_Chamf2dDimension(Handle(AIS_Chamf2dDimension)* nativeHandle);

// Methods PUBLIC

//! Constructs the display object for 2D chamfers. <br>
//! This object is defined by the face aFShape, the <br>
//! dimension aVal, the plane aPlane and the text aText. <br>
OCAIS_Chamf2dDimension(OCNaroWrappers::OCTopoDS_Shape^ aFShape, OCNaroWrappers::OCGeom_Plane^ aPlane, Standard_Real aVal, OCNaroWrappers::OCTCollection_ExtendedString^ aText);

//!  Constructs the display object for 2D chamfers. <br>
//! This object is defined by the face aFShape, the plane <br>
//! aPlane, the dimension aVal, the position aPosition, <br>
//! the type of arrow aSymbolPrs with the size <br>
//! anArrowSize, and the text aText. <br>
OCAIS_Chamf2dDimension(OCNaroWrappers::OCTopoDS_Shape^ aFShape, OCNaroWrappers::OCGeom_Plane^ aPlane, Standard_Real aVal, OCNaroWrappers::OCTCollection_ExtendedString^ aText, OCNaroWrappers::OCgp_Pnt^ aPosition, OCDsgPrs_ArrowSide aSymbolPrs, Standard_Real anArrowSize);

//! Indicates that we are concerned with a 2d length. <br>
virtual /*instead*/  OCAIS_KindOfDimension KindOfDimension() override;

//! Returns true if the 2d chamfer dimension is movable. <br>
virtual /*instead*/  System::Boolean IsMovable() override;

//! computes the presentation according to a point of view <br>
//!          given by <aProjector>. <br>
//!          To be Used when the associated degenerated Presentations <br>
//!          have been transformed by <aTrsf> which is not a Pure <br>
//!          Translation. The HLR Prs can't be deducted automatically <br>
//!          WARNING :<aTrsf> must be applied <br>
//!          to the object to display before computation  !!! <br>
virtual /*instead*/  void Compute(OCNaroWrappers::OCPrs3d_Projector^ aProjector, OCNaroWrappers::OCGeom_Transformation^ aTrsf, OCNaroWrappers::OCPrs3d_Presentation^ aPresentation) override;

~OCAIS_Chamf2dDimension()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
