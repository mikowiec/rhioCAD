// File generated by CPPExt (Transient)
//
#ifndef _Geom_OffsetCurve_OCWrappers_HeaderFile
#define _Geom_OffsetCurve_OCWrappers_HeaderFile

// include the wrapped class
#include <Geom_OffsetCurve.hxx>
#include "../Converter.h"

#include "Geom_Curve.h"

#include "../gp/gp_Dir.h"
#include "../GeomAbs/GeomAbs_Shape.h"


namespace OCNaroWrappers
{

ref class OCGeom_Curve;
ref class OCgp_Dir;
ref class OCgp_Pnt;
ref class OCgp_Vec;
ref class OCgp_Trsf;
ref class OCGeom_Geometry;



//!  This class implements the basis services for an offset curve <br>
//!  in 3D space. The Offset curve in this package can be a self <br>
//!  intersecting curve even if the basis curve does not <br>
//!  self-intersect. The self intersecting portions are not deleted <br>
//!  at the construction time. <br>
//!  An offset curve is a curve at constant distance (Offset) from <br>
//!  a basis curve in a reference direction V. The offset curve <br>
//!  takes its parametrization from the basis curve. <br>
//!  The Offset curve is in the direction of of the normal N <br>
//!  defined with the cross product  V^T where the vector T <br>
//!  is given by the first derivative on the basis curve with <br>
//!  non zero length. <br>
//!  The distance offset may be positive or negative to indicate the <br>
//!  preferred side of the curve : <br>
//!  . distance offset >0 => the curve is in the direction of N <br>
//!  . distance offset >0 => the curve is in the direction of - N <br>
//! <br>
//!  On the Offset curve : <br>
//!  Value (U) = BasisCurve.Value(U) + (Offset * (T ^ V)) / ||T ^ V|| <br>
//! <br>
//!  At any point the Offset direction V must not be parallel to the <br>
//!  vector T and the vector T must not have null length else the <br>
//!  offset curve is not defined. So the offset curve has not the <br>
//!  same continuity as the basis curve. <br>
//! <br>
//!   Warnings : <br>
//! <br>
//!  In this package we suppose that the continuity of the offset <br>
//!  curve is one degree less than the continuity of the basis <br>
//!  curve and we don't check that at any point ||T^V|| != 0.0 <br>
//! <br>
//!  So to evaluate the curve it is better to check that the offset <br>
//!  curve is well defined at any point because an exception could <br>
//!  be raised. The check is not done in this package at the creation <br>
//!  of the offset curve because the control needs the use of an <br>
//!  algorithm which cannot be implemented in this package. <br>
//! <br>
//!  The OffsetCurve is closed if the first point and the last point <br>
//!  are the same (The distance between these two points is lower or <br>
//!  equal to the Resolution sea package gp) . The OffsetCurve can be <br>
//!  closed even if the basis curve is not closed. <br>
public ref class OCGeom_OffsetCurve : OCGeom_Curve {

protected:
  // dummy constructor;
  OCGeom_OffsetCurve(OCDummy^) : OCGeom_Curve((OCDummy^)nullptr) {};

public:

// constructor from native
OCGeom_OffsetCurve(Handle(Geom_OffsetCurve)* nativeHandle);

// Methods PUBLIC


//!  C is the basis curve, Offset is the distance between <me> and <br>
//!  the basis curve at any point. V defines the fixed reference <br>
//!  direction (offset direction). If P is a point on the basis <br>
//!  curve and T the first derivative with non zero length <br>
//!  at this point, the corresponding point on the offset curve is <br>
//!  in the direction of the vector-product N = V ^ T   where <br>
//!  N is a unitary vector. <br>
//!  Warnings : <br>
//!  In this package the entities are not shared. The OffsetCurve is <br>
//!  built with a copy of the curve C. So when C is modified the <br>
//!  OffsetCurve is not modified <br>
//!  Raised if the basis curve C is not at least C1. <br>
//!  Warnings : <br>
//!  No check is done to know if ||V^T|| != 0.0 at any point. <br>
OCGeom_OffsetCurve(OCNaroWrappers::OCGeom_Curve^ C, Standard_Real Offset, OCNaroWrappers::OCgp_Dir^ V);

//! Changes the orientation of this offset curve. <br>
//! As a result: <br>
//! - the basis curve is reversed, <br>
//! - the start point of the initial curve becomes the <br>
//!   end point of the reversed curve, <br>
//! - the end point of the initial curve becomes the <br>
//!   start point of the reversed curve, and <br>
//! - the first and last parameters are recomputed. <br>
 /*instead*/  void Reverse() ;

//! Computes the parameter on the reversed curve for <br>
//! the point of parameter U on this offset curve. <br>
 /*instead*/  Standard_Real ReversedParameter(Standard_Real U) ;

//!  Changes this offset curve by assigning C as the basis curve from which it is built. <br>
//! Exceptions <br>
//! Standard_ConstructionError if the curve C is not at least "C1" continuous. <br>
 /*instead*/  void SetBasisCurve(OCNaroWrappers::OCGeom_Curve^ C) ;

//! Changes this offset curve by assigning V as the <br>
//! reference vector used to compute the offset direction. <br>
 /*instead*/  void SetDirection(OCNaroWrappers::OCgp_Dir^ V) ;

//!  Changes this offset curve by assigning D as the offset value. <br>
 /*instead*/  void SetOffsetValue(Standard_Real D) ;

//! Returns the basis curve of this offset curve. <br>
//! Note: The basis curve can be an offset curve. <br>
 /*instead*/  OCGeom_Curve^ BasisCurve() ;

//! Returns the global continuity of this offset curve as a <br>
//! value of the GeomAbs_Shape enumeration. <br>
//! The degree of continuity of this offset curve is equal <br>
//! to the degree of continuity of the basis curve minus 1. <br>
//!  Continuity of the Offset curve : <br>
//!  C0 : only geometric continuity, <br>
//!  C1 : continuity of the first derivative all along the Curve, <br>
//!  C2 : continuity of the second derivative all along the Curve, <br>
//!  C3 : continuity of the third derivative all along the Curve, <br>
//!  G1 : tangency continuity all along the Curve, <br>
//!  G2 : curvature continuity all along the Curve, <br>
//!  CN : the order of continuity is infinite. <br>
//!  Warnings : <br>
//!  Returns the continuity of the basis curve - 1. <br>
//!  The offset curve must have a unique offset direction defined <br>
//!  at any point. <br>
 /*instead*/  OCGeomAbs_Shape Continuity() ;

//! Returns the reference vector of this offset curve. <br>//! Value and derivatives <br>
//!  Warnings : <br>
//!  The exception UndefinedValue or UndefinedDerivative is <br>
//!  raised if it is not possible to compute a unique offset <br>
//!  direction. <br>
//!  If T is the first derivative with not null length and <br>
//!  V the offset direction the relation ||T(U) ^ V|| != 0 <br>
//!  must be satisfied to evaluate the offset curve. <br>
//!  No check is done at the creation time and we suppose <br>
//!  in this package that the offset curve is well defined. <br>
 /*instead*/  OCgp_Dir^ Direction() ;

//!  Warning! this should not be called <br>
//!          if the basis curve is not at least C1. Nevertheless <br>
//!          if used on portion where the curve is C1, it is OK <br>
 /*instead*/  void D0(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P) ;

//!  Warning! this should not be called <br>
//!           if the continuity of the basis curve is not C2. <br>
//!           Nevertheless, it's OK to use it  on portion <br>
//!           where the curve is C2 <br>
 /*instead*/  void D1(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1) ;

//!  Warning! this should not be called <br>
//!           if the continuity of the basis curve is not C3. <br>
//!           Nevertheless, it's OK to use it  on portion <br>
//!           where the curve is C3 <br>
 /*instead*/  void D2(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2) ;


 /*instead*/  void D3(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2, OCNaroWrappers::OCgp_Vec^ V3) ;


//!  The returned vector gives the value of the derivative <br>
//!  for the order of derivation N. <br>
//!  The following functions compute the value and derivatives <br>
//!  on the offset curve and returns the derivatives on the <br>
//!  basis curve too. <br>
//!  The computation of the value and derivatives on the basis <br>
//!  curve are used to evaluate the offset curve <br>
//! <br>
//!  Warning: <br>
//!  The exception UndefinedValue or UndefinedDerivative is <br>
//!  raised if it is not possible to compute a unique offset <br>
//!  direction. <br>//! Raised if N < 1. <br>
//! <br>
 /*instead*/  OCgp_Vec^ DN(Standard_Real U, Standard_Integer N) ;

//!  Warning! this should not be called <br>
//!          if the basis curve is not at least C1. Nevertheless <br>
//!          if used on portion where the curve is C1, it is OK <br>
 /*instead*/  void Value(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Pnt^ Pbasis, OCNaroWrappers::OCgp_Vec^ V1basis) ;

//!  Warning! this should not be called <br>
//!           if the continuity of the basis curve is not C1. <br>
//!           Nevertheless, it's OK to use it  on portion <br>
//!           where the curve is C1 <br>
 /*instead*/  void D0(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Pnt^ Pbasis, OCNaroWrappers::OCgp_Vec^ V1basis) ;

//!  Warning! this should not be called <br>
//!           if the continuity of the basis curve is not C1. <br>
//!           Nevertheless, it's OK to use it  on portion <br>
//!           where the curve is C1 <br>
 /*instead*/  void D1(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Pnt^ Pbasis, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V1basis, OCNaroWrappers::OCgp_Vec^ V2basis) ;

//!  Warning!  this should not be called <br>
//!           if the continuity of the basis curve is not C3. <br>
//!           Nevertheless, it's OK to use it  on portion <br>
//!           where the curve is C3 <br>
 /*instead*/  void D2(Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Pnt^ Pbasis, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2, OCNaroWrappers::OCgp_Vec^ V1basis, OCNaroWrappers::OCgp_Vec^ V2basis, OCNaroWrappers::OCgp_Vec^ V3basis) ;


 /*instead*/  Standard_Real FirstParameter() ;

//! Returns the value of the first or last parameter of this <br>
//! offset curve. The first parameter corresponds to the <br>
//! start point of the curve. The last parameter <br>
//! corresponds to the end point. <br>
//! Note: the first and last parameters of this offset curve <br>
//! are also the ones of its basis curve. <br>
 /*instead*/  Standard_Real LastParameter() ;

//! Returns the offset value of this offset curve. <br>
 /*instead*/  Standard_Real Offset() ;

//! Returns True if the distance between the start point <br>
//!  and the end point of the curve is lower or equal to <br>
//!  Resolution from package gp. <br>
 /*instead*/  System::Boolean IsClosed() ;

//! Returns true if the degree of continuity of the basis <br>
//! curve of this offset curve is at least N + 1. <br>
//!  This method answer True if the continuity of the basis curve <br>
//!  is N + 1.  We suppose in this class that a normal direction <br>
//!  to the basis curve (used to compute the offset curve) is <br>
//!  defined at any point on the basis curve. <br>//! Raised if N < 0. <br>
 /*instead*/  System::Boolean IsCN(Standard_Integer N) ;

//! Returns true if this offset curve is periodic, i.e. if the <br>
//! basis curve of this offset curve is periodic. <br>
 /*instead*/  System::Boolean IsPeriodic() ;

//! Returns the period of this offset curve, i.e. the period <br>
//! of the basis curve of this offset curve. <br>
//! Exceptions <br>
//! Standard_NoSuchObject if the basis curve is not periodic. <br>
virtual /*instead*/  Standard_Real Period() override;

//! Applies the transformation T to this offset curve. <br>
//! Note: the basis curve is also modified. <br>
 /*instead*/  void Transform(OCNaroWrappers::OCgp_Trsf^ T) ;

//! Returns the  parameter on the  transformed  curve for <br>
//!       the transform of the point of parameter U on <me>. <br>
//!      me->Transformed(T)->Value(me->TransformedParameter(U,T)) <br>
//!          is the same point as <br>
//!          me->Value(U).Transformed(T) <br>
//!          This methods calls the basis curve method. <br>
virtual /*instead*/  Standard_Real TransformedParameter(Standard_Real U, OCNaroWrappers::OCgp_Trsf^ T) override;

//! Returns a  coefficient to compute the parameter on <br>
//!          the transformed  curve  for  the transform  of the <br>
//!          point on <me>. <br>
//! <br>
//!          Transformed(T)->Value(U * ParametricTransformation(T)) <br>
//!          is the same point as <br>
//!          Value(U).Transformed(T) <br>
//!          This methods calls the basis curve method. <br>
virtual /*instead*/  Standard_Real ParametricTransformation(OCNaroWrappers::OCgp_Trsf^ T) override;

//! Creates a new object which is a copy of this offset curve. <br>
 /*instead*/  OCGeom_Geometry^ Copy() ;

~OCGeom_OffsetCurve()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
