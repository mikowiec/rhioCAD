// File generated by CPPExt (Transient)
//
#ifndef _Graphic2d_PolylineMarker_OCWrappers_HeaderFile
#define _Graphic2d_PolylineMarker_OCWrappers_HeaderFile

// include the wrapped class
#include <Graphic2d_PolylineMarker.hxx>
#include "../Converter.h"

#include "Graphic2d_VectorialMarker.h"

#include "../TShort/TShort_Array1OfShortReal.h"


namespace OCNaroWrappers
{

ref class OCGraphic2d_GraphicObject;
ref class OCGraphic2d_Array1OfVertex;
ref class OCTColStd_Array1OfReal;
ref class OCGraphic2d_Drawer;


//! The primitive PolylineMarker <br>
//!	    Every marker takes a reference point as an argument in <br>
//!	    its constructor. CircleMarker and EllipsMarker take <br>
//!	    another point as the center and PolylineMarker takes the <br>
//!	    first point of its list as its origin. <br>
//!	    The coordinates of the centre or origin point are offsets <br>
//!	    with respect to the reference point. <br>
public ref class OCGraphic2d_PolylineMarker : OCGraphic2d_VectorialMarker {

protected:
  // dummy constructor;
  OCGraphic2d_PolylineMarker(OCDummy^) : OCGraphic2d_VectorialMarker((OCDummy^)nullptr) {};

public:

// constructor from native
OCGraphic2d_PolylineMarker(Handle(Graphic2d_PolylineMarker)* nativeHandle);

// Methods PUBLIC

//! Creates a polyline marker. <br>
//!	    The reference point is <aXPosition>, <aYPosition> <br>
//!  Warning: Raises an error if the length of the polyline <br>
//!	    is less than 2 points. <br>
OCGraphic2d_PolylineMarker(OCNaroWrappers::OCGraphic2d_GraphicObject^ aGraphicObject, Quantity_Length aXPosition, Quantity_Length aYPosition, OCNaroWrappers::OCGraphic2d_Array1OfVertex^ aListVertex);

//! Creates a polyline marker. <br>
//!	    The reference point is <aXPosition>, <aYPosition> <br>
//!  Warning: Raises an error if the length of the polyline <br>
//!	    is less than 2 points or if length of <aListX> <br>
//!	    is not equal to length of <aListY>. <br>
OCGraphic2d_PolylineMarker(OCNaroWrappers::OCGraphic2d_GraphicObject^ aGraphicObject, Quantity_Length aXPosition, Quantity_Length aYPosition, OCNaroWrappers::OCTColStd_Array1OfReal^ aListX, OCNaroWrappers::OCTColStd_Array1OfReal^ aListY);

//! Returns the number of points of <br>
//!          the polyline marker <br>
 /*instead*/  Standard_Integer Length() ;

//! Returns the point of rank <aRank> <br>
//!          from the polyline marker <br>
 /*instead*/  void Values(Standard_Integer aRank, Quantity_Length& X, Quantity_Length& Y) ;


virtual /*instead*/  void Save(Aspect_FStream& aFStream) ;


static /*instead*/  void Retrieve(Aspect_IFStream& anIFStream, OCNaroWrappers::OCGraphic2d_GraphicObject^ aGraphicObject) ;

~OCGraphic2d_PolylineMarker()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
