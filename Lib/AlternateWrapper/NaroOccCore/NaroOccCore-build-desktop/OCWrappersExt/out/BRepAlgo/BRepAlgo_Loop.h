// File generated by CPPExt (MPV)
//
#ifndef _BRepAlgo_Loop_OCWrappers_HeaderFile
#define _BRepAlgo_Loop_OCWrappers_HeaderFile

// include native header
#include <BRepAlgo_Loop.hxx>
#include "../Converter.h"


#include "../TopoDS/TopoDS_Face.h"
#include "../TopTools/TopTools_ListOfShape.h"
#include "../TopTools/TopTools_DataMapOfShapeListOfShape.h"
#include "../TopTools/TopTools_DataMapOfShapeShape.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Face;
ref class OCTopoDS_Edge;
ref class OCTopTools_ListOfShape;
ref class OCTopTools_DataMapOfShapeShape;


//! Builds the loops from a set of edges on a face. <br>
public ref class OCBRepAlgo_Loop  {

protected:
  BRepAlgo_Loop* nativeHandle;
  OCBRepAlgo_Loop(OCDummy^) {};

public:
  property BRepAlgo_Loop* Handle
  {
    BRepAlgo_Loop* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBRepAlgo_Loop(BRepAlgo_Loop* nativeHandle);

// Methods PUBLIC


OCBRepAlgo_Loop();

//! Init with <F> the set of edges must have <br>
//!          pcurves on <F>. <br>
 /*instead*/  void Init(OCNaroWrappers::OCTopoDS_Face^ F) ;

//! Add E with <LV>. <E> will be copied and trim <br>
//!          by vertices in <LV>. <br>
 /*instead*/  void AddEdge(OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopTools_ListOfShape^ LV) ;

//! Add <E> as const edge, E can be in the result. <br>
 /*instead*/  void AddConstEdge(OCNaroWrappers::OCTopoDS_Edge^ E) ;

//! Add <LE> as a set of const edges. <br>
 /*instead*/  void AddConstEdges(OCNaroWrappers::OCTopTools_ListOfShape^ LE) ;

//! Make loops. <br>
 /*instead*/  void Perform() ;

//!  Cut the  edge <E>  in  several edges  <NE> on the <br>
//!          vertices<VonE>. <br>
 /*instead*/  void CutEdge(OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopTools_ListOfShape^ VonE, OCNaroWrappers::OCTopTools_ListOfShape^ NE) ;

//! Returns the list of wires performed. <br>
//!          can be an empty list. <br>
 /*instead*/  OCTopTools_ListOfShape^ NewWires() ;

//!  Build faces from the wires result. <br>
 /*instead*/  void WiresToFaces() ;

//! Returns the list of faces. <br>
//!  Warning: The method <WiresToFaces> as to be called before. <br>
//!          can be an empty list. <br>
 /*instead*/  OCTopTools_ListOfShape^ NewFaces() ;

//! Returns the list of new edges built from an edge <E> <br>
//!          it can be an empty list. <br>
 /*instead*/  OCTopTools_ListOfShape^ NewEdges(OCNaroWrappers::OCTopoDS_Edge^ E) ;

//! Returns the datamap of vertices with their substitutes. <br>
 /*instead*/  void GetVerticesForSubstitute(OCNaroWrappers::OCTopTools_DataMapOfShapeShape^ VerVerMap) ;


 /*instead*/  void VerticesForSubstitute(OCNaroWrappers::OCTopTools_DataMapOfShapeShape^ VerVerMap) ;

~OCBRepAlgo_Loop()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
