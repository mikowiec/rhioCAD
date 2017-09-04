// File generated by CPPExt (MPV)
//
#ifndef _BRepExtrema_SolutionElem_OCWrappers_HeaderFile
#define _BRepExtrema_SolutionElem_OCWrappers_HeaderFile

// include native header
#include <BRepExtrema_SolutionElem.hxx>
#include "../Converter.h"


#include "../gp/gp_Pnt.h"
#include "BRepExtrema_SupportType.h"
#include "../TopoDS/TopoDS_Vertex.h"
#include "../TopoDS/TopoDS_Edge.h"
#include "../TopoDS/TopoDS_Face.h"


namespace OCNaroWrappers
{

ref class OCgp_Pnt;
ref class OCTopoDS_Vertex;
ref class OCTopoDS_Edge;
ref class OCTopoDS_Face;


//! This class is used to store information relative to the <br>
//! minimum distance between two shapes. <br>
public ref class OCBRepExtrema_SolutionElem  {

protected:
  BRepExtrema_SolutionElem* nativeHandle;
  OCBRepExtrema_SolutionElem(OCDummy^) {};

public:
  property BRepExtrema_SolutionElem* Handle
  {
    BRepExtrema_SolutionElem* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBRepExtrema_SolutionElem(BRepExtrema_SolutionElem* nativeHandle);

// Methods PUBLIC


OCBRepExtrema_SolutionElem();

//! initialisation of the fields <br>
//!  This creator is used when the solution of a distance is a Vertex. <br>
//!  The different initialized fields are: _ the distance d <br>
//!                                        _ the solution point <br>
//!                                        _ the type of solution <br>
//!                                        _ and the Vertex. <br>
OCBRepExtrema_SolutionElem(Standard_Real d, OCNaroWrappers::OCgp_Pnt^ Pt, OCBRepExtrema_SupportType SolType, OCNaroWrappers::OCTopoDS_Vertex^ vertex);

//! initialisation of  the fiels. <br>
//! This constructor is used when the  solution of distance is on <br>
//! an Edge. The different initialized fields are: <br>
//!            _ the distance d, <br>
//!            _ the solution point, <br>
//!            _ the type of solution, <br>
//!            _ the Edge, <br>
//!            _ and the parameter t to locate the solution. <br>
OCBRepExtrema_SolutionElem(Standard_Real d, OCNaroWrappers::OCgp_Pnt^ Pt, OCBRepExtrema_SupportType SolType, OCNaroWrappers::OCTopoDS_Edge^ edge, Standard_Real t);

//! initialisation of the fields <br>
//! This constructor is used when the  solution of distance is in <br>
//! a Face. The different initialized fields are: <br>
//!            _ the distance d, <br>
//!            _ the solution point, <br>
//!            _ the type of solution, <br>
//!            _ the Face, <br>
//!            _ and the parameter u et v to locate the solution. <br>
OCBRepExtrema_SolutionElem(Standard_Real d, OCNaroWrappers::OCgp_Pnt^ Pt, OCBRepExtrema_SupportType SolType, OCNaroWrappers::OCTopoDS_Face^ face, Standard_Real u, Standard_Real v);


//!  returns the value of the minimum distance. <br>
//! <br>
 /*instead*/  Standard_Real Dist() ;


//!  returns the solution point. <br>
//! <br>
 /*instead*/  OCgp_Pnt^ Point() ;


//!  returns the Support type : <br>
//!	    IsVertex => The solution is a vertex. <br>
//! 	    IsOnEdge => The solution belongs to an Edge. <br>
//! 	    IsInFace => The solution is inside a Face. <br>
 /*instead*/  OCBRepExtrema_SupportType SupportKind() ;


//!  returns the vertex if the solution is a Vertex. <br>
 /*instead*/  OCTopoDS_Vertex^ Vertex() ;


//!   returns the vertex if the solution is an Edge. <br>
 /*instead*/  OCTopoDS_Edge^ Edge() ;


//!  returns the vertex if the solution is an Face. <br>
 /*instead*/  OCTopoDS_Face^ Face() ;


//!  returns the parameter t if the solution is on Edge. <br>
 /*instead*/  void EdgeParameter(Standard_Real& par1) ;


//!  returns the parameters u et v if the solution is in a Face. <br>
 /*instead*/  void FaceParameter(Standard_Real& par1, Standard_Real& par2) ;

~OCBRepExtrema_SolutionElem()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
