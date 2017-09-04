// File generated by CPPExt (Transient)
//
#ifndef _BRep_CurveRepresentation_OCWrappers_HeaderFile
#define _BRep_CurveRepresentation_OCWrappers_HeaderFile

// include the wrapped class
#include <BRep_CurveRepresentation.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "../TopLoc/TopLoc_Location.h"
#include "../GeomAbs/GeomAbs_Shape.h"


namespace OCNaroWrappers
{

ref class OCTopLoc_Location;
ref class OCGeom_Surface;
ref class OCPoly_Triangulation;
ref class OCGeom_Curve;
ref class OCGeom2d_Curve;
ref class OCPoly_Polygon3D;
ref class OCPoly_Polygon2D;
ref class OCPoly_PolygonOnTriangulation;


//! Root class for the curve representations. Contains <br>
//!          a location. <br>
public ref class OCBRep_CurveRepresentation : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCBRep_CurveRepresentation(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRep_CurveRepresentation(Handle(BRep_CurveRepresentation)* nativeHandle);

// Methods PUBLIC


OCBRep_CurveRepresentation(OCNaroWrappers::OCTopLoc_Location^ L);

//! A 3D curve representation. <br>
virtual /*instead*/  System::Boolean IsCurve3D() ;

//! A curve in the parametric space of a surface. <br>
virtual /*instead*/  System::Boolean IsCurveOnSurface() ;

//! A continuity between two surfaces. <br>
virtual /*instead*/  System::Boolean IsRegularity() ;

//! A curve with two parametric   curves  on the  same <br>
//!          surface. <br>
virtual /*instead*/  System::Boolean IsCurveOnClosedSurface() ;

//! Is it a curve in the parametric space  of <S> with <br>
//!          location <L>. <br>
virtual /*instead*/  System::Boolean IsCurveOnSurface(OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopLoc_Location^ L) ;

//! Is it  a  regularity between  <S1> and   <S2> with <br>
//!          location <L1> and <L2>. <br>
virtual /*instead*/  System::Boolean IsRegularity(OCNaroWrappers::OCGeom_Surface^ S1, OCNaroWrappers::OCGeom_Surface^ S2, OCNaroWrappers::OCTopLoc_Location^ L1, OCNaroWrappers::OCTopLoc_Location^ L2) ;

//! A 3D polygon representation. <br>
virtual /*instead*/  System::Boolean IsPolygon3D() ;

//! A representation by an array of nodes on a <br>
//!          triangulation. <br>
virtual /*instead*/  System::Boolean IsPolygonOnTriangulation() ;

//! Is it a polygon in the definition of <T> with <br>
//!          location <L>. <br>
virtual /*instead*/  System::Boolean IsPolygonOnTriangulation(OCNaroWrappers::OCPoly_Triangulation^ T, OCNaroWrappers::OCTopLoc_Location^ L) ;

//! A representation by two arrays of nodes on a <br>
//!          triangulation. <br>
virtual /*instead*/  System::Boolean IsPolygonOnClosedTriangulation() ;

//! A polygon in the parametric space of a surface. <br>
virtual /*instead*/  System::Boolean IsPolygonOnSurface() ;

//! Is it a polygon in the parametric space  of <S> with <br>
//!          location <L>. <br>
virtual /*instead*/  System::Boolean IsPolygonOnSurface(OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopLoc_Location^ L) ;

//! Two   2D polygon  representations  in the  parametric <br>
//!          space of a surface. <br>
virtual /*instead*/  System::Boolean IsPolygonOnClosedSurface() ;


 /*instead*/  OCTopLoc_Location^ Location() ;


 /*instead*/  void Location(OCNaroWrappers::OCTopLoc_Location^ L) ;


virtual /*instead*/  OCGeom_Curve^ Curve3D() ;


virtual /*instead*/  void Curve3D(OCNaroWrappers::OCGeom_Curve^ C) ;


virtual /*instead*/  OCGeom_Surface^ Surface() ;


virtual /*instead*/  OCGeom2d_Curve^ PCurve() ;


virtual /*instead*/  void PCurve(OCNaroWrappers::OCGeom2d_Curve^ C) ;


virtual /*instead*/  OCGeom2d_Curve^ PCurve2() ;


virtual /*instead*/  void PCurve2(OCNaroWrappers::OCGeom2d_Curve^ C) ;


virtual /*instead*/  OCPoly_Polygon3D^ Polygon3D() ;


virtual /*instead*/  void Polygon3D(OCNaroWrappers::OCPoly_Polygon3D^ P) ;


virtual /*instead*/  OCPoly_Polygon2D^ Polygon() ;


virtual /*instead*/  void Polygon(OCNaroWrappers::OCPoly_Polygon2D^ P) ;


virtual /*instead*/  OCPoly_Polygon2D^ Polygon2() ;


virtual /*instead*/  void Polygon2(OCNaroWrappers::OCPoly_Polygon2D^ P) ;


virtual /*instead*/  OCPoly_Triangulation^ Triangulation() ;


virtual /*instead*/  OCPoly_PolygonOnTriangulation^ PolygonOnTriangulation() ;


virtual /*instead*/  void PolygonOnTriangulation(OCNaroWrappers::OCPoly_PolygonOnTriangulation^ P) ;


virtual /*instead*/  OCPoly_PolygonOnTriangulation^ PolygonOnTriangulation2() ;


virtual /*instead*/  void PolygonOnTriangulation2(OCNaroWrappers::OCPoly_PolygonOnTriangulation^ P2) ;


virtual /*instead*/  OCGeom_Surface^ Surface2() ;


virtual /*instead*/  OCTopLoc_Location^ Location2() ;


virtual /*instead*/  OCGeomAbs_Shape Continuity() ;


virtual /*instead*/  void Continuity(OCGeomAbs_Shape C) ;

~OCBRep_CurveRepresentation()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
