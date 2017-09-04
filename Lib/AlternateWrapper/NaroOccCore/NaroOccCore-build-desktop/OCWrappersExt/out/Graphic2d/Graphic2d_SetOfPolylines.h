// File generated by CPPExt (Transient)
//
#ifndef _Graphic2d_SetOfPolylines_OCWrappers_HeaderFile
#define _Graphic2d_SetOfPolylines_OCWrappers_HeaderFile

// include the wrapped class
#include <Graphic2d_SetOfPolylines.hxx>
#include "../Converter.h"

#include "Graphic2d_Line.h"

#include "Graphic2d_SequenceOfPolyline.h"


namespace OCNaroWrappers
{

ref class OCGraphic2d_GraphicObject;
ref class OCGraphic2d_Drawer;


//! The primitive SetOfPolylines <br>
//!  Warning: This primitive must be use as possible for to insure <br>
//!	   that the sets is drawn correctly when the line type or <br>
//!	   line width attrib is not SOLID and 1 pixel for the set. <br>
//!         NOTE: than the method PickedIndex() permits to known <br>
//!              the last picked polyline and segment in the set. <br>
public ref class OCGraphic2d_SetOfPolylines : OCGraphic2d_Line {

protected:
  // dummy constructor;
  OCGraphic2d_SetOfPolylines(OCDummy^) : OCGraphic2d_Line((OCDummy^)nullptr) {};

public:

// constructor from native
OCGraphic2d_SetOfPolylines(Handle(Graphic2d_SetOfPolylines)* nativeHandle);

// Methods PUBLIC

//! Creates an empty set of polylines in the graphic <br>
//!         object <aGraphicObject>. <br>
OCGraphic2d_SetOfPolylines(OCNaroWrappers::OCGraphic2d_GraphicObject^ aGraphicObject);

//! Add a point in the current polyline of the set <br>
//!	    or creates a new one when <NewPolyline> flag is TRUE. <br>
 /*instead*/  void Add(Quantity_Length X, Quantity_Length Y, System::Boolean NewPolyline) ;

//! Add a segment in the set to one of polyline <br>
//!	    which has the last point identical to one of the segment <br>
//!	    or creates a new polyline in the sets with the 2 segment points. <br>
//!	    The first point is <X1>, <Y1>. <br>
//!	    The second point is <X2>, <Y2>. <br>
 /*instead*/  void Add(Quantity_Length X1, Quantity_Length Y1, Quantity_Length X2, Quantity_Length Y2) ;

//! Returns the number of polylines in the set. <br>
 /*instead*/  Standard_Integer Length() ;

//! Returns the number of points of the polylines <br>
//!    of rank <aPrank>. <br>
//!  Trigger: Raises OutOfRange if <aPrank> is <1 or >Length() <br>
 /*instead*/  Standard_Integer Length(Standard_Integer aPrank) ;

//! Returns the point of rank <aVrank> <br>
//!	    from the polyline of rank <aPrank>. <br>
//!  Trigger: Raises OutOfRange if <aPrank> is <1 or >Length() <br>
//!	 or if <aVrank> is <1 or >Length(<aPrank>) <br>
 /*instead*/  void Values(Standard_Integer aPrank, Standard_Integer aVrank, Quantity_Length& X, Quantity_Length& Y) ;


virtual /*instead*/  void Save(Aspect_FStream& aFStream) ;

~OCGraphic2d_SetOfPolylines()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
