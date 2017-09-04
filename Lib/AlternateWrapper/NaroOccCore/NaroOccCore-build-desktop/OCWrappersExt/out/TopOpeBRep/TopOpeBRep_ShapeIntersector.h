// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRep_ShapeIntersector_OCWrappers_HeaderFile
#define _TopOpeBRep_ShapeIntersector_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRep_ShapeIntersector.hxx>
#include "../Converter.h"


#include "../TopoDS/TopoDS_Shape.h"
#include "../TopOpeBRepTool/TopOpeBRepTool_ShapeExplorer.h"
#include "TopOpeBRep_ShapeScanner.h"
#include "TopOpeBRep_FacesIntersector.h"
#include "TopOpeBRep_EdgesIntersector.h"
#include "TopOpeBRep_FaceEdgeIntersector.h"
#include "../TopoDS/TopoDS_Face.h"


namespace OCNaroWrappers
{

ref class OCTopOpeBRepTool_HBoxTool;
ref class OCTopoDS_Shape;
ref class OCTopoDS_Face;
ref class OCTopOpeBRep_FacesIntersector;
ref class OCTopOpeBRep_EdgesIntersector;
ref class OCTopOpeBRep_FaceEdgeIntersector;
ref class OCTopTools_ListOfShape;


//! Intersect two shapes. <br>
//! <br>
//!          A GeomShape is a  shape with a geometric domain, i.e. <br>
//!          a Face or an Edge. <br>
//! <br>
//!          The purpose   of  the  ShapeIntersector is   to  find <br>
//!          couples  of  intersecting   GeomShape  in  two Shapes <br>
//!          (which can   be  any kind of  topologies  : Compound, <br>
//!          Solid, Shell, etc... ) <br>
//! <br>
//!          It  is in charge  of  exploration  of the shapes  and <br>
//!          rejection. For this it is provided with two tools : <br>
//! <br>
//!            - ShapeExplorer from TopOpeBRepTool. <br>
//!            - ShapeScanner from TopOpeBRep which implements bounding boxes. <br>
public ref class OCTopOpeBRep_ShapeIntersector  {

protected:
  TopOpeBRep_ShapeIntersector* nativeHandle;
  OCTopOpeBRep_ShapeIntersector(OCDummy^) {};

public:
  property TopOpeBRep_ShapeIntersector* Handle
  {
    TopOpeBRep_ShapeIntersector* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopOpeBRep_ShapeIntersector(TopOpeBRep_ShapeIntersector* nativeHandle);

// Methods PUBLIC


OCTopOpeBRep_ShapeIntersector();

//! Initialize the intersection of shapes S1,S2. <br>
 /*instead*/  void InitIntersection(OCNaroWrappers::OCTopoDS_Shape^ S1, OCNaroWrappers::OCTopoDS_Shape^ S2) ;

//! Initialize the intersection of shapes S1,S2. <br>
 /*instead*/  void InitIntersection(OCNaroWrappers::OCTopoDS_Shape^ S1, OCNaroWrappers::OCTopoDS_Shape^ S2, OCNaroWrappers::OCTopoDS_Face^ F1, OCNaroWrappers::OCTopoDS_Face^ F2) ;

//! return  the shape  <Index> ( = 1 or 2) given to <br>
//!          InitIntersection(). <br>
//!          Index = 1 will return S1, Index = 2 will return S2. <br>
 /*instead*/  OCTopoDS_Shape^ Shape(Standard_Integer Index) ;

//! returns True if there are more intersection <br>
//!          between two the shapes. <br>
 /*instead*/  System::Boolean MoreIntersection() ;

//! search for the next intersection between the two shapes. <br>
 /*instead*/  void NextIntersection() ;

//! return the current intersection of two Faces. <br>
 /*instead*/  OCTopOpeBRep_FacesIntersector^ ChangeFacesIntersector() ;

//! return the current intersection of two Edges. <br>
 /*instead*/  OCTopOpeBRep_EdgesIntersector^ ChangeEdgesIntersector() ;

//! return the current intersection of a Face and an Edge. <br>
 /*instead*/  OCTopOpeBRep_FaceEdgeIntersector^ ChangeFaceEdgeIntersector() ;

//! return  geometric  shape <Index> ( = 1 or 2 )  of <br>
//!          current intersection. <br>
 /*instead*/  OCTopoDS_Shape^ CurrentGeomShape(Standard_Integer Index) ;

//! return  MAX of intersection tolerances with <br>
//!          which FacesIntersector from TopOpeBRep was working. <br>
 /*instead*/  void GetTolerances(Standard_Real& tol1, Standard_Real& tol2) ;


 /*instead*/  void DumpCurrent(Standard_Integer K) ;


 /*instead*/  Standard_Integer Index(Standard_Integer K) ;


 /*instead*/  void RejectedFaces(OCNaroWrappers::OCTopoDS_Shape^ anObj, OCNaroWrappers::OCTopoDS_Shape^ aReference, OCNaroWrappers::OCTopTools_ListOfShape^ aListOfShape) ;

~OCTopOpeBRep_ShapeIntersector()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
