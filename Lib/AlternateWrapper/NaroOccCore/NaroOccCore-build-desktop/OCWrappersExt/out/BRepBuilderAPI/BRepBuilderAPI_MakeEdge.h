// File generated by CPPExt (MPV)
//
#ifndef _BRepBuilderAPI_MakeEdge_OCWrappers_HeaderFile
#define _BRepBuilderAPI_MakeEdge_OCWrappers_HeaderFile

// include native header
#include <BRepBuilderAPI_MakeEdge.hxx>
#include "../Converter.h"

#include "BRepBuilderAPI_MakeShape.h"

#include "../BRepLib/BRepLib_MakeEdge.h"
#include "BRepBuilderAPI_MakeShape.h"
#include "BRepBuilderAPI_EdgeError.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Vertex;
ref class OCgp_Pnt;
ref class OCgp_Lin;
ref class OCgp_Circ;
ref class OCgp_Elips;
ref class OCgp_Hypr;
ref class OCgp_Parab;
ref class OCGeom_Curve;
ref class OCGeom2d_Curve;
ref class OCGeom_Surface;
ref class OCTopoDS_Edge;


//! Provides methods to build edges. <br>
//! <br>
//!          The   methods have  the  following   syntax, where <br>
//!          TheCurve is one of Lin, Circ, ... <br>
//! <br>
//!          Create(C : TheCurve) <br>
//! <br>
//!            Makes an edge on  the whole curve.  Add vertices <br>
//!            on finite curves. <br>
//! <br>
//!          Create(C : TheCurve; p1,p2 : Real) <br>
//! <br>
//!            Make an edge  on the curve between parameters p1 <br>
//!            and p2. if p2 < p1 the edge will be REVERSED. If <br>
//!            p1  or p2 is infinite the  curve will be open in <br>
//!            that  direction. Vertices are created for finite <br>
//!            values of p1 and p2. <br>
//! <br>
//!          Create(C : TheCurve; P1, P2 : Pnt from gp) <br>
//! <br>
//!            Make an edge on the curve  between the points P1 <br>
//!            and P2. The  points are projected on   the curve <br>
//!            and the   previous method is  used. An  error is <br>
//!            raised if the points are not on the curve. <br>
//! <br>
//!          Create(C : TheCurve; V1, V2 : Vertex from TopoDS) <br>
//! <br>
//!            Make an edge  on the curve  between the vertices <br>
//!            V1 and V2. Same as the  previous but no vertices <br>
//!            are created. If a vertex is  Null the curve will <br>
//!            be open in this direction. <br>
public ref class OCBRepBuilderAPI_MakeEdge  : public OCBRepBuilderAPI_MakeShape {

protected:
  // dummy constructor;
  OCBRepBuilderAPI_MakeEdge(OCDummy^) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepBuilderAPI_MakeEdge(BRepBuilderAPI_MakeEdge* nativeHandle);

// Methods PUBLIC


OCBRepBuilderAPI_MakeEdge();


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Lin^ L);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Lin^ L, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Lin^ L, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Lin^ L, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Circ^ L);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Circ^ L, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Circ^ L, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Circ^ L, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Elips^ L);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Elips^ L, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Elips^ L, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Elips^ L, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Hypr^ L);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Hypr^ L, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Hypr^ L, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Hypr^ L, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Parab^ L);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Parab^ L, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Parab^ L, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCgp_Parab^ L, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom_Curve^ L);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom_Curve^ L, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom_Curve^ L, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom_Curve^ L, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom_Curve^ L, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom_Curve^ L, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom2d_Curve^ L, OCNaroWrappers::OCGeom_Surface^ S);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom2d_Curve^ L, OCNaroWrappers::OCGeom_Surface^ S, Standard_Real p1, Standard_Real p2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom2d_Curve^ L, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom2d_Curve^ L, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2);


OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom2d_Curve^ L, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2, Standard_Real p1, Standard_Real p2);

//! The general method to directly create an edge is to give <br>
//! -      a 3D curve C as the support (geometric domain) of the edge, <br>
//! -      two vertices V1 and V2 to limit the curve (definition of the restriction of <br>
//!    the edge), and <br>
//! -      two real values p1 and p2 which are the parameters for the vertices V1 and V2 <br>
//!    on the curve. <br>
//! The curve may be defined as a 2d curve in the parametric space of a surface: a <br>
//! pcurve. The surface on which the edge is built is then kept at the level of the edge. <br>
//! The default tolerance will be associated with this edge. <br>
//! Rules applied to the arguments: <br>
//! For the curve: <br>
//! -      The curve must not be a 'null handle'. <br>
//! -      If the curve is a trimmed curve the basis curve is used. <br>
//! For the vertices: <br>
//! -      Vertices may be null shapes. When V1 or V2 is null the edge is open in the <br>
//!    corresponding direction and the parameter value p1 or p2 must be infinite <br>
//!    (remember that Precision::Infinite() defines an infinite value). <br>
//! -      The two vertices must be identical if they have the same 3D location. <br>
//!    Identical vertices are used in particular when the curve is closed. <br>
//! For the parameters: <br>
//! -      The parameters must be in the parametric range of the curve (or the basis <br>
//!    curve if the curve is trimmed). If this condition is not satisfied the edge is not <br>
//!    built, and the Error function will return BRepAPI_ParameterOutOfRange. <br>
//! -      Parameter values must not be equal. If this condition is not satisfied (i.e. <br>
//!    if | p1 - p2 | ) the edge is not built, and the Error function will return <br>
//!    BRepAPI_LineThroughIdenticPoints. <br>
//! Parameter values are expected to be given in increasing order: <br>
//!      C->FirstParameter() <br>
//! - If the parameter values are given in decreasing order the vertices are switched, <br>
//! i.e. the "first vertex" is on the point of parameter p2 and the "second vertex" is <br>
//! on the point of parameter p1. In such a case, to keep the original intent of the <br>
//! construction, the edge will be oriented "reversed". <br>
//! - On a periodic curve the parameter values p1 and p2 are adjusted by adding or <br>
//! subtracting the period to obtain p1 in the parametric range of the curve, and p2] <br>
//! such that [ p1 , where Period is the period of the curve. <br>
//! - A parameter value may be infinite. The edge is open in the corresponding <br>
//! direction. However the corresponding vertex must be a null shape. If this condition <br>
//! is not satisfied the edge is not built, and the Error function will return <br>
//! BRepAPI_PointWithInfiniteParameter. <br>
//! - The distance between the vertex and the point evaluated on the curve with the <br>
//! parameter, must be lower than the precision of the vertex. If this condition is not <br>
//! satisfied the edge is not built, and the Error function will return <br>
//! BRepAPI_DifferentsPointAndParameter. <br>
//!  Other edge constructions <br>
//! - The parameter values can be omitted, they will be computed by projecting the <br>
//! vertices on the curve. Note that projection is the only way to evaluate the <br>
//! parameter values of the vertices on the curve: vertices must be given on the curve, <br>
//! i.e. the distance from a vertex to the curve must be less than or equal to the <br>
//! precision of the vertex. If this condition is not satisfied the edge is not built, <br>
//! and the Error function will return BRepAPI_PointProjectionFailed. <br>
//! -      3D points can be given in place of vertices. Vertices will be created from the <br>
//!    points (with the default topological precision Precision::Confusion()). <br>
//! Note: <br>
//! -      Giving vertices is useful when creating a connected edge. <br>
//! -      If the parameter values correspond to the extremities of a closed curve, <br>
//!    points must be identical, or at least coincident. If this condition is not <br>
//!    satisfied the edge is not built, and the Error function will return <br>
//!   BRepAPI_DifferentPointsOnClosedCurve. <br>
//! -      The vertices or points can be omitted if the parameter values are given. The <br>
//!    points will be computed from the parameters on the curve. <br>
//! The vertices or points and the parameter values can be omitted. The first and last <br>
//!   parameters of the curve will then be used. <br>
OCBRepBuilderAPI_MakeEdge(OCNaroWrappers::OCGeom2d_Curve^ L, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2, Standard_Real p1, Standard_Real p2);


 /*instead*/  void Init(OCNaroWrappers::OCGeom_Curve^ C) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom_Curve^ C, Standard_Real p1, Standard_Real p2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom_Curve^ C, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom_Curve^ C, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom_Curve^ C, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2, Standard_Real p1, Standard_Real p2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom_Curve^ C, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2, Standard_Real p1, Standard_Real p2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom2d_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom2d_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S, Standard_Real p1, Standard_Real p2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom2d_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom2d_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2) ;


 /*instead*/  void Init(OCNaroWrappers::OCGeom2d_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2, Standard_Real p1, Standard_Real p2) ;

//! Defines or redefines the arguments for the construction of an edge. <br>
//! This function is currently used after the empty constructor BRepAPI_MakeEdge(). <br>
 /*instead*/  void Init(OCNaroWrappers::OCGeom2d_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2, Standard_Real p1, Standard_Real p2) ;

//! Returns true if the edge is built. <br>
virtual /*instead*/  System::Boolean IsDone() override;

//! Returns the construction status <br>
//! -   BRepBuilderAPI_EdgeDone if the edge is built, or <br>
//! -   another value of the BRepBuilderAPI_EdgeError <br>
//!   enumeration indicating the reason of construction failure. <br>
 /*instead*/  OCBRepBuilderAPI_EdgeError Error() ;


//! Returns the constructed edge. <br>
//! Exceptions StdFail_NotDone if the edge is not built. <br>
 /*instead*/  OCTopoDS_Edge^ Edge() ;

//! Returns the first vertex of the edge. May be Null. <br>
//! <br>
 /*instead*/  OCTopoDS_Vertex^ Vertex1() ;

//! Returns the second vertex of the edge. May be Null. <br>
//! <br>
//! Warning <br>
//! The returned vertex in each function corresponds respectively to <br>
//! -   the lowest, or <br>
//! -   the highest parameter on the curve along which the edge is built. <br>
//!  It does not correspond to the first or second vertex <br>
//! given at the time of the construction, if the edge is oriented reversed. <br>
//! Exceptions <br>
//! StdFail_NotDone if the edge is not built. <br>
 /*instead*/  OCTopoDS_Vertex^ Vertex2() ;

~OCBRepBuilderAPI_MakeEdge()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
