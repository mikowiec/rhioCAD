// File generated by CPPExt (MPV)
//
#ifndef _Adaptor3d_IsoCurve_OCWrappers_HeaderFile
#define _Adaptor3d_IsoCurve_OCWrappers_HeaderFile

// include native header
#include <Adaptor3d_IsoCurve.hxx>
#include "../Converter.h"

#include "Adaptor3d_Curve.h"

#include "../GeomAbs/GeomAbs_IsoType.h"
#include "Adaptor3d_Curve.h"
#include "../GeomAbs/GeomAbs_Shape.h"
#include "../GeomAbs/GeomAbs_CurveType.h"


namespace OCNaroWrappers
{

ref class OCAdaptor3d_HSurface;
ref class OCTColStd_Array1OfReal;
ref class OCAdaptor3d_HCurve;
ref class OCgp_Pnt;
ref class OCgp_Vec;
ref class OCgp_Lin;
ref class OCgp_Circ;
ref class OCgp_Elips;
ref class OCgp_Hypr;
ref class OCgp_Parab;
ref class OCGeom_BezierCurve;
ref class OCGeom_BSplineCurve;


//! Defines an isoparametric curve on  a surface.  The <br>
//!          type  of isoparametric curve  (U  or V) is defined <br>
//!          with the   enumeration  IsoType from   GeomAbs  if <br>
//!          NoneIso is given an error is raised. <br>
public ref class OCAdaptor3d_IsoCurve  : public OCAdaptor3d_Curve {

protected:
  // dummy constructor;
  OCAdaptor3d_IsoCurve(OCDummy^) : OCAdaptor3d_Curve((OCDummy^)nullptr) {};

public:

// constructor from native
OCAdaptor3d_IsoCurve(Adaptor3d_IsoCurve* nativeHandle);

// Methods PUBLIC

//! The iso is set to NoneIso. <br>
OCAdaptor3d_IsoCurve();

//! The surface is loaded. The iso is set to NoneIso. <br>
OCAdaptor3d_IsoCurve(OCNaroWrappers::OCAdaptor3d_HSurface^ S);

//! Creates  an  IsoCurve curve.   Iso  defines the <br>
//!          type (isoU or  isoU) Param defines the value of <br>
//!          the iso. The bounds  of  the iso are the bounds <br>
//!          of the surface. <br>
OCAdaptor3d_IsoCurve(OCNaroWrappers::OCAdaptor3d_HSurface^ S, OCGeomAbs_IsoType Iso, Standard_Real Param);

//! Create an IsoCurve curve.  Iso defines the type <br>
//!          (isoU or isov).  Param defines the value of the <br>
//!          iso. WFirst,WLast define the bounds of the iso. <br>
OCAdaptor3d_IsoCurve(OCNaroWrappers::OCAdaptor3d_HSurface^ S, OCGeomAbs_IsoType Iso, Standard_Real Param, Standard_Real WFirst, Standard_Real WLast);

//! Changes  the surface.  The  iso  is  reset  to <br>
//!          NoneIso. <br>
 /*instead*/  void Load(OCNaroWrappers::OCAdaptor3d_HSurface^ S) ;

//! Changes the iso on the current surface. <br>
 /*instead*/  void Load(OCGeomAbs_IsoType Iso, Standard_Real Param) ;

//! Changes the iso on the current surface. <br>
 /*instead*/  void Load(OCGeomAbs_IsoType Iso, Standard_Real Param, Standard_Real WFirst, Standard_Real WLast) ;


 /*instead*/  OCAdaptor3d_HSurface^ Surface() ;


 /*instead*/  OCGeomAbs_IsoType Iso() ;


 /*instead*/  Standard_Real Parameter() ;


virtual /*instead*/  Standard_Real FirstParameter() override;


virtual /*instead*/  Standard_Real LastParameter() override;


virtual /*instead*/  OCGeomAbs_Shape Continuity() override;

//! Returns  the number  of  intervals for  continuity <br>
//!          <S>. May be one if Continuity(me) >= <S> <br>
virtual /*instead*/  Standard_Integer NbIntervals(OCGeomAbs_Shape S) override;

//! Stores in <T> the  parameters bounding the intervals <br>
//!          of continuity <S>. <br>
//! <br>
//!          The array must provide  enough room to  accomodate <br>
//!          for the parameters. i.e. T.Length() > NbIntervals() <br>
virtual /*instead*/  void Intervals(OCNaroWrappers::OCTColStd_Array1OfReal^ T, OCGeomAbs_Shape S) override;

//! Returns    a  curve equivalent   of  <me>  between <br>
//!          parameters <First>  and <Last>. <Tol>  is used  to <br>
//!          test for 3d points confusion. <br>//! If <First> >= <Last> <br>
virtual /*instead*/  OCAdaptor3d_HCurve^ Trim(Standard_Real First, Standard_Real Last, Standard_Real Tol) override;


virtual /*instead*/  System::Boolean IsClosed() override;


virtual /*instead*/  System::Boolean IsPeriodic() override;


virtual /*instead*/  Standard_Real Period() override;

//! Computes the point of parameter U on the curve. <br>
virtual /*instead*/  OCgp_Pnt^ Value(Standard_Real U) override;

//! Computes the point of parameter U on the curve. <br>
virtual /*instead*/  void D0(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P) override;

//! Computes the point of parameter U on the curve with its <br>
//!  first derivative. <br>//! Raised if the continuity of the current interval <br>
//!  is not C1. <br>
virtual /*instead*/  void D1(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V) override;


//!  Returns the point P of parameter U, the first and second <br>
//!  derivatives V1 and V2. <br>//! Raised if the continuity of the current interval <br>
//!  is not C2. <br>
virtual /*instead*/  void D2(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2) override;


//!  Returns the point P of parameter U, the first, the second <br>
//!  and the third derivative. <br>//! Raised if the continuity of the current interval <br>
//!  is not C3. <br>
virtual /*instead*/  void D3(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2, OCNaroWrappers::OCgp_Vec^ V3) override;


//!  The returned vector gives the value of the derivative for the <br>
//!  order of derivation N. <br>//! Raised if the continuity of the current interval <br>
//!  is not CN. <br>//! Raised if N < 1. <br>
virtual /*instead*/  OCgp_Vec^ DN(Standard_Real U, Standard_Integer N) override;

//!  Returns the parametric  resolution corresponding <br>
//!         to the real space resolution <R3d>. <br>
virtual /*instead*/  Standard_Real Resolution(Standard_Real R3d) override;

//! Returns  the  type of the   curve  in the  current <br>
//!          interval :   Line,   Circle,   Ellipse, Hyperbola, <br>
//!          Parabola, BezierCurve, BSplineCurve, OtherCurve. <br>
virtual /*instead*/  OCGeomAbs_CurveType GetType() override;


virtual /*instead*/  OCgp_Lin^ Line() override;


virtual /*instead*/  OCgp_Circ^ Circle() override;


virtual /*instead*/  OCgp_Elips^ Ellipse() override;


virtual /*instead*/  OCgp_Hypr^ Hyperbola() override;


virtual /*instead*/  OCgp_Parab^ Parabola() override;


virtual /*instead*/  Standard_Integer Degree() override;


virtual /*instead*/  System::Boolean IsRational() override;


virtual /*instead*/  Standard_Integer NbPoles() override;


virtual /*instead*/  Standard_Integer NbKnots() override;


virtual /*instead*/  OCGeom_BezierCurve^ Bezier() override;


virtual /*instead*/  OCGeom_BSplineCurve^ BSpline() override;

~OCAdaptor3d_IsoCurve()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
