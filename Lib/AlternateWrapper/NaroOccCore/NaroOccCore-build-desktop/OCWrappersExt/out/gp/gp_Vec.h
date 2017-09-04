// File generated by CPPExt (MPV)
//
#ifndef _gp_Vec_OCWrappers_HeaderFile
#define _gp_Vec_OCWrappers_HeaderFile

// include native header
#include <gp_Vec.hxx>
#include "../Converter.h"


#include "gp_XYZ.h"
#include "../Standard/Standard_Storable.h"


namespace OCNaroWrappers
{

ref class OCgp_Dir;
ref class OCgp_XYZ;
ref class OCgp_Pnt;
ref class OCgp_Ax1;
ref class OCgp_Ax2;
ref class OCgp_Trsf;



//!  Defines a non-persistent vector in 3D space. <br>
public ref class OCgp_Vec  {

protected:
  gp_Vec* nativeHandle;
  OCgp_Vec(OCDummy^) {};

public:
  property gp_Vec* Handle
  {
    gp_Vec* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCgp_Vec(gp_Vec* nativeHandle);

// Methods PUBLIC

//! Creates a zero vector. <br>
OCgp_Vec();

//! Creates a unitary vector from a direction V. <br>
OCgp_Vec(OCNaroWrappers::OCgp_Dir^ V);

//! Creates a vector with a triplet of coordinates. <br>
OCgp_Vec(OCNaroWrappers::OCgp_XYZ^ Coord);

//! Creates a point with its three cartesian coordinates. <br>
OCgp_Vec(Standard_Real Xv, Standard_Real Yv, Standard_Real Zv);


//!  Creates a vector from two points. The length of the vector <br>
//!  is the distance between P1 and P2 <br>
OCgp_Vec(OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2);

//! Changes the coordinate of range Index <br>
//!  Index = 1 => X is modified <br>
//!  Index = 2 => Y is modified <br>
//!  Index = 3 => Z is modified <br>//! Raised if Index != {1, 2, 3}. <br>
 /*instead*/  void SetCoord(Standard_Integer Index, Standard_Real Xi) ;

//! For this vector, assigns <br>
//! -   the values Xv, Yv and Zv to its three coordinates. <br>
 /*instead*/  void SetCoord(Standard_Real Xv, Standard_Real Yv, Standard_Real Zv) ;

//! Assigns the given value to the X coordinate of this vector. <br>
 /*instead*/  void SetX(Standard_Real X) ;

//! Assigns the given value to the X coordinate of this vector. <br>
 /*instead*/  void SetY(Standard_Real Y) ;

//! Assigns the given value to the X coordinate of this vector. <br>
 /*instead*/  void SetZ(Standard_Real Z) ;

//! Assigns the three coordinates of Coord to this vector. <br>
 /*instead*/  void SetXYZ(OCNaroWrappers::OCgp_XYZ^ Coord) ;


//!  Returns the coordinate of range Index : <br>
//!  Index = 1 => X is returned <br>
//!  Index = 2 => Y is returned <br>
//!  Index = 3 => Z is returned <br>//! Raised if Index != {1, 2, 3}. <br>
 /*instead*/  Standard_Real Coord(Standard_Integer Index) ;

//! For this vector returns its three coordinates Xv, Yv, and Zvinline <br>
 /*instead*/  void Coord(Standard_Real& Xv, Standard_Real& Yv, Standard_Real& Zv) ;

//! For this vector, returns its X coordinate. <br>
 /*instead*/  Standard_Real X() ;

//! For this vector, returns its Y coordinate. <br>
 /*instead*/  Standard_Real Y() ;

//! For this vector, returns its Z  coordinate. <br>
 /*instead*/  Standard_Real Z() ;

//!    For this vector, returns <br>
//! -   its three coordinates as a number triple <br>
 /*instead*/  OCgp_XYZ^ XYZ() ;


//!  Returns True if the two vectors have the same magnitude value <br>
//!  and the same direction. The precision values are LinearTolerance <br>
//!  for the magnitude and AngularTolerance for the direction. <br>
 /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCgp_Vec^ Other, Standard_Real LinearTolerance, Standard_Real AngularTolerance) ;


//!  Returns True if abs(<me>.Angle(Other) - PI/2.) <= AngularTolerance <br>
//!   Raises VectorWithNullMagnitude if <me>.Magnitude() <= Resolution or <br>
//!  Other.Magnitude() <= Resolution from gp <br>
 /*instead*/  System::Boolean IsNormal(OCNaroWrappers::OCgp_Vec^ Other, Standard_Real AngularTolerance) ;


//!  Returns True if PI - <me>.Angle(Other) <= AngularTolerance <br>
//!  Raises VectorWithNullMagnitude if <me>.Magnitude() <= Resolution or <br>
//!  Other.Magnitude() <= Resolution from gp <br>
 /*instead*/  System::Boolean IsOpposite(OCNaroWrappers::OCgp_Vec^ Other, Standard_Real AngularTolerance) ;


//!  Returns True if Angle(<me>, Other) <= AngularTolerance or <br>
//!  PI - Angle(<me>, Other) <= AngularTolerance <br>
//!  This definition means that two parallel vectors cannot define <br>
//!  a plane but two vectors with opposite directions are considered <br>
//!  as parallel. Raises VectorWithNullMagnitude if <me>.Magnitude() <= Resolution or <br>
//!  Other.Magnitude() <= Resolution from gp <br>
 /*instead*/  System::Boolean IsParallel(OCNaroWrappers::OCgp_Vec^ Other, Standard_Real AngularTolerance) ;


//!  Computes the angular value between <me> and <Other> <br>
//!  Returns the angle value between 0 and PI in radian. <br>
//!    Raises VectorWithNullMagnitude if <me>.Magnitude() <= Resolution from gp or <br>
//!  Other.Magnitude() <= Resolution because the angular value is <br>
//!  indefinite if one of the vectors has a null magnitude. <br>
 /*instead*/  Standard_Real Angle(OCNaroWrappers::OCgp_Vec^ Other) ;

//! Computes the angle, in radians, between this vector and <br>
//! vector Other. The result is a value between -Pi and Pi. <br>
//! For this, VRef defines the positive sense of rotation: the <br>
//! angular value is positive, if the cross product this ^ Other <br>
//! has the same orientation as VRef relative to the plane <br>
//! defined by the vectors this and Other. Otherwise, the <br>
//! angular value is negative. <br>
//! Exceptions <br>
//! gp_VectorWithNullMagnitude if the magnitude of this <br>
//! vector, the vector Other, or the vector VRef is less than or <br>
//! equal to gp::Resolution(). <br>
//! Standard_DomainError if this vector, the vector Other, <br>
//! and the vector VRef are coplanar, unless this vector and <br>
//! the vector Other are parallel. <br>
 /*instead*/  Standard_Real AngleWithRef(OCNaroWrappers::OCgp_Vec^ Other, OCNaroWrappers::OCgp_Vec^ VRef) ;

//! Computes the magnitude of this vector. <br>
 /*instead*/  Standard_Real Magnitude() ;

//! Computes the square magnitude of this vector. <br>//! Adds two vectors <br>
 /*instead*/  Standard_Real SquareMagnitude() ;


 /*instead*/  void Add(OCNaroWrappers::OCgp_Vec^ Other) ;

//! Adds two vectors <br>//! Subtracts two vectors <br>
 /*instead*/  OCgp_Vec^ Added(OCNaroWrappers::OCgp_Vec^ Other) ;


 /*instead*/  void Subtract(OCNaroWrappers::OCgp_Vec^ Right) ;

//! Subtracts two vectors <br>//! Multiplies a vector by a scalar <br>
 /*instead*/  OCgp_Vec^ Subtracted(OCNaroWrappers::OCgp_Vec^ Right) ;


 /*instead*/  void Multiply(Standard_Real Scalar) ;

//! Multiplies a vector by a scalar <br>//! Divides a vector by a scalar <br>
 /*instead*/  OCgp_Vec^ Multiplied(Standard_Real Scalar) ;


 /*instead*/  void Divide(Standard_Real Scalar) ;

//! Divides a vector by a scalar <br>//! computes the cross product between two vectors <br>
 /*instead*/  OCgp_Vec^ Divided(Standard_Real Scalar) ;


 /*instead*/  void Cross(OCNaroWrappers::OCgp_Vec^ Right) ;

//! computes the cross product between two vectors <br>
 /*instead*/  OCgp_Vec^ Crossed(OCNaroWrappers::OCgp_Vec^ Right) ;


//!  Computes the magnitude of the cross <br>
//!  product between <me> and Right. <br>
//!  Returns || <me> ^ Right || <br>
 /*instead*/  Standard_Real CrossMagnitude(OCNaroWrappers::OCgp_Vec^ Right) ;


//!  Computes the square magnitude of <br>
//!  the cross product between <me> and Right. <br>
//!  Returns || <me> ^ Right ||**2 <br>//! Computes the triple vector product. <br>
//!  <me> ^ (V1 ^ V2) <br>
 /*instead*/  Standard_Real CrossSquareMagnitude(OCNaroWrappers::OCgp_Vec^ Right) ;


 /*instead*/  void CrossCross(OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2) ;

//! Computes the triple vector product. <br>
//!  <me> ^ (V1 ^ V2) <br>
 /*instead*/  OCgp_Vec^ CrossCrossed(OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2) ;

//! computes the scalar product <br>
 /*instead*/  Standard_Real Dot(OCNaroWrappers::OCgp_Vec^ Other) ;

//! Computes the triple scalar product <me> * (V1 ^ V2). <br>//! normalizes a vector <br>
//!  Raises an exception if the magnitude of the vector is <br>
//!  lower or equal to Resolution from gp. <br>
 /*instead*/  Standard_Real DotCross(OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2) ;


 /*instead*/  void Normalize() ;

//! normalizes a vector <br>
//!  Raises an exception if the magnitude of the vector is <br>
//!  lower or equal to Resolution from gp. <br>//! Reverses the direction of a vector <br>
 /*instead*/  OCgp_Vec^ Normalized() ;


 /*instead*/  void Reverse() ;

//! Reverses the direction of a vector <br>
 /*instead*/  OCgp_Vec^ Reversed() ;


//!  <me> is setted to the following linear form : <br>
//!  A1 * V1 + A2 * V2 + A3 * V3 + V4 <br>
 /*instead*/  void SetLinearForm(Standard_Real A1, OCNaroWrappers::OCgp_Vec^ V1, Standard_Real A2, OCNaroWrappers::OCgp_Vec^ V2, Standard_Real A3, OCNaroWrappers::OCgp_Vec^ V3, OCNaroWrappers::OCgp_Vec^ V4) ;


//!  <me> is setted to the following linear form : <br>
//!  A1 * V1 + A2 * V2 + A3 * V3 <br>
 /*instead*/  void SetLinearForm(Standard_Real A1, OCNaroWrappers::OCgp_Vec^ V1, Standard_Real A2, OCNaroWrappers::OCgp_Vec^ V2, Standard_Real A3, OCNaroWrappers::OCgp_Vec^ V3) ;


//!  <me> is setted to the following linear form : <br>
//!  A1 * V1 + A2 * V2 + V3 <br>
 /*instead*/  void SetLinearForm(Standard_Real A1, OCNaroWrappers::OCgp_Vec^ V1, Standard_Real A2, OCNaroWrappers::OCgp_Vec^ V2, OCNaroWrappers::OCgp_Vec^ V3) ;


//!  <me> is setted to the following linear form : <br>
//!  A1 * V1 + A2 * V2 <br>
 /*instead*/  void SetLinearForm(Standard_Real A1, OCNaroWrappers::OCgp_Vec^ V1, Standard_Real A2, OCNaroWrappers::OCgp_Vec^ V2) ;


//!  <me> is setted to the following linear form : A1 * V1 + V2 <br>
 /*instead*/  void SetLinearForm(Standard_Real A1, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2) ;


//!  <me> is setted to the following linear form : V1 + V2 <br>
 /*instead*/  void SetLinearForm(OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2) ;


 /*instead*/  void Mirror(OCNaroWrappers::OCgp_Vec^ V) ;


//!  Performs the symmetrical transformation of a vector <br>
//!  with respect to the vector V which is the center of <br>
//!  the  symmetry. <br>
 /*instead*/  OCgp_Vec^ Mirrored(OCNaroWrappers::OCgp_Vec^ V) ;


 /*instead*/  void Mirror(OCNaroWrappers::OCgp_Ax1^ A1) ;


//!  Performs the symmetrical transformation of a vector <br>
//!  with respect to an axis placement which is the axis <br>
//!  of the symmetry. <br>
 /*instead*/  OCgp_Vec^ Mirrored(OCNaroWrappers::OCgp_Ax1^ A1) ;


 /*instead*/  void Mirror(OCNaroWrappers::OCgp_Ax2^ A2) ;


//!  Performs the symmetrical transformation of a vector <br>
//!  with respect to a plane. The axis placement A2 locates <br>
//!  the plane of the symmetry : (Location, XDirection, YDirection). <br>
 /*instead*/  OCgp_Vec^ Mirrored(OCNaroWrappers::OCgp_Ax2^ A2) ;


 /*instead*/  void Rotate(OCNaroWrappers::OCgp_Ax1^ A1, Standard_Real Ang) ;


//!  Rotates a vector. A1 is the axis of the rotation. <br>
//!  Ang is the angular value of the rotation in radians. <br>
 /*instead*/  OCgp_Vec^ Rotated(OCNaroWrappers::OCgp_Ax1^ A1, Standard_Real Ang) ;


 /*instead*/  void Scale(Standard_Real S) ;

//! Scales a vector. S is the scaling value. <br>//! Transforms a vector with the transformation T. <br>
 /*instead*/  OCgp_Vec^ Scaled(Standard_Real S) ;


 /*instead*/  void Transform(OCNaroWrappers::OCgp_Trsf^ T) ;

//! Transforms a vector with the transformation T. <br>
 /*instead*/  OCgp_Vec^ Transformed(OCNaroWrappers::OCgp_Trsf^ T) ;

~OCgp_Vec()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
