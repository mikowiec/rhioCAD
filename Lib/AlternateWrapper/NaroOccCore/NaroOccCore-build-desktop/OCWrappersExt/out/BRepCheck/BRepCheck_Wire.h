// File generated by CPPExt (Transient)
//
#ifndef _BRepCheck_Wire_OCWrappers_HeaderFile
#define _BRepCheck_Wire_OCWrappers_HeaderFile

// include the wrapped class
#include <BRepCheck_Wire.hxx>
#include "../Converter.h"

#include "BRepCheck_Result.h"

#include "BRepCheck_Status.h"
#include "../TopTools/TopTools_IndexedDataMapOfShapeListOfShape.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Wire;
ref class OCTopoDS_Shape;
ref class OCTopoDS_Face;
ref class OCTopoDS_Edge;



public ref class OCBRepCheck_Wire : OCBRepCheck_Result {

protected:
  // dummy constructor;
  OCBRepCheck_Wire(OCDummy^) : OCBRepCheck_Result((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepCheck_Wire(Handle(BRepCheck_Wire)* nativeHandle);

// Methods PUBLIC


OCBRepCheck_Wire(OCNaroWrappers::OCTopoDS_Wire^ W);

//! if <ContextShape> is  a  face, consequently checks <br>
//!          SelfIntersect(),   Closed(),   Orientation()   and <br>
//!          Closed2d until faulty is found <br>
 /*instead*/  void InContext(OCNaroWrappers::OCTopoDS_Shape^ ContextShape) ;

//! checks that the  wire  is  not empty and "connex". <br>
//!          Called by constructor <br>
 /*instead*/  void Minimum() ;

//! Does nothing <br>
 /*instead*/  void Blind() ;

//! Checks if the  oriented  edges of the wire  give a <br>
//!          closed  wire.   If the  wire   is closed,  returns <br>
//!          BRepCheck_NoError.    Warning :  if the first  and <br>
//!          last  edge   are  infinite,   the  wire   will  be <br>
//!          considered as a closed one.  If <Update> is set to <br>
//!          Standard_True, registers the status in the list. <br>
//!          May return (and registers): <br>
//!          **BRepCheck_NotConnected,   if    wire    is   not <br>
//!          topologically closed <br>
//!          **BRepCheck_RedundantEdge, if an  edge  is in wire <br>
//!          more than 3 times  or  in  case of 2 occurences if <br>
//!          not with FORWARD and REVERSED orientation. <br>
//!          **BRepCheck_NoError <br>
 /*instead*/  OCBRepCheck_Status Closed(System::Boolean Update) ;

//! Checks if edges of the  wire give a wire closed in <br>
//!          2d space. <br>
//!          Returns BRepCheck_NoError,  or BRepCheck_NotClosed <br>
//!          If <Update> is set to Standard_True, registers the <br>
//!          status in the list. <br>
 /*instead*/  OCBRepCheck_Status Closed2d(OCNaroWrappers::OCTopoDS_Face^ F, System::Boolean Update) ;

//! Checks   if  the oriented edges   of  the wire are <br>
//!          correctly oriented.  An  internal call is made  to <br>
//!          the  method Closed.   If no face  exists, call the <br>
//!          method with   a  null  face  (TopoDS_face()).   If <br>
//!          <Update> is  set  to Standard_True,  registers the <br>
//!          status in the list. <br>
//!          May return (and registers): <br>
//!          BRepCheck_InvalidDegeneratedFlag, <br>
//!          BRepCheck_BadOrientationOfSubshape, <br>
//!          BRepCheck_NotClosed, <br>
//!          BRepCheck_NoError <br>
 /*instead*/  OCBRepCheck_Status Orientation(OCNaroWrappers::OCTopoDS_Face^ F, System::Boolean Update) ;

//! Checks if  the wire intersect   itself on the face <br>
//!          <F>.  <E1>  and <E2>   are the first  intersecting <br>
//!          edges  found.  <E2>  may  be a  null  edge when  a <br>
//!          self-intersecting edge is found.If <Update> is set <br>
//!          to Standard_True,   registers  the  status in  the <br>
//!          list. <br>
//!          May return (and register): <br>
//!          BRepCheck_EmptyWire, <br>
//!          BRepCheck_SelfIntersectingWire, <br>
//!          BRepCheck_NoCurveOnSurface, <br>
//!          BRepCheck_NoError <br>
 /*instead*/  OCBRepCheck_Status SelfIntersect(OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCTopoDS_Edge^ E1, OCNaroWrappers::OCTopoDS_Edge^ E2, System::Boolean Update) ;

//! report SelfIntersect() check would be (is) done <br>
 /*instead*/  System::Boolean GeometricControls() ;

//! set SelfIntersect() to be checked <br>
 /*instead*/  void GeometricControls(System::Boolean B) ;

~OCBRepCheck_Wire()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif