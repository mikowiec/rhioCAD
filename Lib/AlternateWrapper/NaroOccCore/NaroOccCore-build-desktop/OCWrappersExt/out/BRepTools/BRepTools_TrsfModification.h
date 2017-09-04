// File generated by CPPExt (Transient)
//
#ifndef _BRepTools_TrsfModification_OCWrappers_HeaderFile
#define _BRepTools_TrsfModification_OCWrappers_HeaderFile

// include the wrapped class
#include <BRepTools_TrsfModification.hxx>
#include "../Converter.h"

#include "BRepTools_Modification.h"

#include "../gp/gp_Trsf.h"
#include "../GeomAbs/GeomAbs_Shape.h"


namespace OCNaroWrappers
{

ref class OCgp_Trsf;
ref class OCTopoDS_Face;
ref class OCGeom_Surface;
ref class OCTopLoc_Location;
ref class OCTopoDS_Edge;
ref class OCGeom_Curve;
ref class OCTopoDS_Vertex;
ref class OCgp_Pnt;
ref class OCGeom2d_Curve;


//! Describes a modification that uses a gp_Trsf to <br>
//! change the geometry of a shape. All functions return <br>
//! true and transform the geometry of the shape. <br>
public ref class OCBRepTools_TrsfModification : OCBRepTools_Modification {

protected:
  // dummy constructor;
  OCBRepTools_TrsfModification(OCDummy^) : OCBRepTools_Modification((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepTools_TrsfModification(Handle(BRepTools_TrsfModification)* nativeHandle);

// Methods PUBLIC


OCBRepTools_TrsfModification(OCNaroWrappers::OCgp_Trsf^ T);

//! Provides access to the gp_Trsf associated with this <br>
//! modification. The transformation can be changed. <br>
 /*instead*/  OCgp_Trsf^ Trsf() ;

//! Returns true if the face F has been modified. <br>
//! If the face has been modified: <br>
//! - S is the new geometry of the face, <br>
//! - L is its new location, and <br>
//! - Tol is the new tolerance. <br>
//! RevWires is set to true when the modification <br>
//! reverses the normal of the surface (the wires have to be reversed). <br>
//! RevFace is set to true if the orientation of the <br>
//! modified face changes in the shells which contain it. <br>
//! For this class, RevFace returns true if the gp_Trsf <br>
//! associated with this modification is negative. <br>
 /*instead*/  System::Boolean NewSurface(OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopLoc_Location^ L, Standard_Real& Tol, System::Boolean& RevWires, System::Boolean& RevFace) ;

//! Returns true if the edge E has been modified. <br>
//! If the edge has been modified: <br>
//! - C is the new geometric support of the edge, <br>
//! - L is the new location, and <br>
//! - Tol is the new tolerance. <br>
//!   If the edge has not been modified, this function <br>
//! returns false, and the values of C, L and Tol are not significant. <br>
 /*instead*/  System::Boolean NewCurve(OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCGeom_Curve^ C, OCNaroWrappers::OCTopLoc_Location^ L, Standard_Real& Tol) ;

//! Returns true if the vertex V has been modified. <br>
//! If the vertex has been modified: <br>
//! - P is the new geometry of the vertex, and <br>
//! - Tol is the new tolerance. <br>
//!   If the vertex has not been modified this function <br>
//! returns false, and the values of P and Tol are not significant. <br>
 /*instead*/  System::Boolean NewPoint(OCNaroWrappers::OCTopoDS_Vertex^ V, OCNaroWrappers::OCgp_Pnt^ P, Standard_Real& Tol) ;

//! Returns true if the edge E has a new curve on surface on the face F. <br>
//! If a new curve exists: <br>
//! - C is the new geometric support of the edge, <br>
//! - L is the new location, and <br>
//! - Tol the new tolerance. <br>
//!   If no new curve exists, this function returns false, and <br>
//! the values of C, L and Tol are not significant. <br>
 /*instead*/  System::Boolean NewCurve2d(OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCTopoDS_Edge^ NewE, OCNaroWrappers::OCTopoDS_Face^ NewF, OCNaroWrappers::OCGeom2d_Curve^ C, Standard_Real& Tol) ;

//! Returns true if the Vertex V has a new parameter on the edge E. <br>
//! If a new parameter exists: <br>
//! - P is the parameter, and <br>
//! - Tol is the new tolerance. <br>
//!   If no new parameter exists, this function returns false, <br>
//! and the values of P and Tol are not significant. <br>
 /*instead*/  System::Boolean NewParameter(OCNaroWrappers::OCTopoDS_Vertex^ V, OCNaroWrappers::OCTopoDS_Edge^ E, Standard_Real& P, Standard_Real& Tol) ;

//! Returns the  continuity of  <NewE> between <NewF1> <br>
//!          and <NewF2>. <br>
//! <br>
//!          <NewE> is the new  edge created from <E>.  <NewF1> <br>
//!          (resp. <NewF2>) is the new  face created from <F1> <br>
//!          (resp. <F2>). <br>
 /*instead*/  OCGeomAbs_Shape Continuity(OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopoDS_Face^ F1, OCNaroWrappers::OCTopoDS_Face^ F2, OCNaroWrappers::OCTopoDS_Edge^ NewE, OCNaroWrappers::OCTopoDS_Face^ NewF1, OCNaroWrappers::OCTopoDS_Face^ NewF2) ;

~OCBRepTools_TrsfModification()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
