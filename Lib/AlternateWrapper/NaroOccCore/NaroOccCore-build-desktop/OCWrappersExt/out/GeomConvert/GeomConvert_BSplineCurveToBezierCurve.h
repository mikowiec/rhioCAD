// File generated by CPPExt (MPV)
//
#ifndef _GeomConvert_BSplineCurveToBezierCurve_OCWrappers_HeaderFile
#define _GeomConvert_BSplineCurveToBezierCurve_OCWrappers_HeaderFile

// include native header
#include <GeomConvert_BSplineCurveToBezierCurve.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCGeom_BSplineCurve;
ref class OCGeom_BezierCurve;
ref class OCTColGeom_Array1OfBezierCurve;
ref class OCTColStd_Array1OfReal;


//!An algorithm to convert a BSpline curve into a series <br>
//! of adjacent Bezier curves. <br>
//! A BSplineCurveToBezierCurve object provides a framework for: <br>
//! -   defining the BSpline curve to be converted <br>
//! -   implementing the construction algorithm, and <br>
//! -   consulting the results. <br>
//!  References : <br>
//!  Generating the Bezier points of B-spline curves and surfaces <br>
//!  (Wolfgang Bohm) CAD volume 13 number 6 november 1981 <br>
public ref class OCGeomConvert_BSplineCurveToBezierCurve  {

protected:
  GeomConvert_BSplineCurveToBezierCurve* nativeHandle;
  OCGeomConvert_BSplineCurveToBezierCurve(OCDummy^) {};

public:
  property GeomConvert_BSplineCurveToBezierCurve* Handle
  {
    GeomConvert_BSplineCurveToBezierCurve* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCGeomConvert_BSplineCurveToBezierCurve(GeomConvert_BSplineCurveToBezierCurve* nativeHandle);

// Methods PUBLIC

//! Computes all the data needed to convert the <br>
//! BSpline curve BasisCurve into a series of adjacent Bezier arcs. <br>
OCGeomConvert_BSplineCurveToBezierCurve(OCNaroWrappers::OCGeom_BSplineCurve^ BasisCurve);

//!  Computes all the data needed to convert <br>
//!  the portion of the BSpline curve BasisCurve <br>
//!   limited by the two parameter values U1 and U2 into a series of adjacent Bezier arcs. <br>
//!        The result consists of a series of BasisCurve arcs <br>
//! limited by points corresponding to knot values of the curve. <br>
//! Use the available interrogation functions to ascertain <br>
//! the number of computed Bezier arcs, and then to <br>
//! construct each individual Bezier curve (or all Bezier curves). <br>
//! Note: ParametricTolerance is not used. <br>
//!  Raises DomainError if U1 or U2 are out of the parametric bounds of the basis <br>
//!  curve [FirstParameter, LastParameter]. The Tolerance criterion <br>
//!  is ParametricTolerance. <br>
//!  Raised if Abs (U2 - U1) <= ParametricTolerance. <br>
OCGeomConvert_BSplineCurveToBezierCurve(OCNaroWrappers::OCGeom_BSplineCurve^ BasisCurve, Standard_Real U1, Standard_Real U2, Standard_Real ParametricTolerance);

//! Constructs and returns the Bezier curve of index <br>
//! Index to the table of adjacent Bezier arcs <br>
//! computed by this algorithm. <br>
//! This Bezier curve has the same orientation as the <br>
//! BSpline curve analyzed in this framework. <br>
//! Exceptions <br>
//! Standard_OutOfRange if Index is less than 1 or <br>
//! greater than the number of adjacent Bezier arcs <br>
//! computed by this algorithm. <br>
 /*instead*/  OCGeom_BezierCurve^ Arc(Standard_Integer Index) ;

//! Constructs all the Bezier curves whose data is <br>
//! computed by this algorithm and loads these curves into the Curves table. <br>
//! The Bezier curves have the same orientation as the <br>
//! BSpline curve analyzed in this framework. <br>
//! Exceptions <br>
//! Standard_DimensionError if the Curves array was <br>
//! not created with the following bounds: <br>
//! -   1 , and <br>
//! -   the number of adjacent Bezier arcs computed by <br>
//!   this algorithm (as given by the function NbArcs). <br>
 /*instead*/  void Arcs(OCNaroWrappers::OCTColGeom_Array1OfBezierCurve^ Curves) ;

//! This methode returns the bspline's knots associated to <br>
//!          the converted arcs <br>//! Raised  if the length  of Curves is not equal to <br>
//!  NbArcs +  1. <br>
 /*instead*/  void Knots(OCNaroWrappers::OCTColStd_Array1OfReal^ TKnots) ;


//!  Returns the number of BezierCurve arcs. <br>
//!  If at the creation time you have decomposed the basis curve <br>
//!  between the parametric values UFirst, ULast the number of <br>
//!  BezierCurve arcs depends on the number of knots included inside <br>
//!  the interval [UFirst, ULast]. <br>
//!  If you have decomposed the whole basis B-spline curve the number <br>
//!  of BezierCurve arcs NbArcs is equal to the number of knots less <br>
//!  one. <br>
 /*instead*/  Standard_Integer NbArcs() ;

~OCGeomConvert_BSplineCurveToBezierCurve()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
