// File generated by CPPExt (MPV)
//
#ifndef _gp_Hypr_OCWrappers_HeaderFile
#define _gp_Hypr_OCWrappers_HeaderFile

// include native header
#include <gp_Hypr.hxx>
#include "../Converter.h"


#include "gp_Ax2.h"
#include "../Standard/Standard_Storable.h"
#include "gp_Ax1.h"
#include "gp_Pnt.h"


namespace OCNaroWrappers
{

ref class OCgp_Ax2;
ref class OCgp_Ax1;
ref class OCgp_Pnt;
ref class OCgp_Trsf;
ref class OCgp_Vec;


//! Describes a branch of a hyperbola in 3D space. <br>
//! A hyperbola is defined by its major and minor radii and <br>
//! positioned in space with a coordinate system (a gp_Ax2 <br>
//! object) of which: <br>
//! -   the origin is the center of the hyperbola, <br>
//! -   the "X Direction" defines the major axis of the <br>
//!   hyperbola, and <br>
//! - the "Y Direction" defines the minor axis of the hyperbola. <br>
//! The origin, "X Direction" and "Y Direction" of this <br>
//! coordinate system together define the plane of the <br>
//! hyperbola. This coordinate system is the "local <br>
//! coordinate system" of the hyperbola. In this coordinate <br>
//! system, the equation of the hyperbola is: <br>
//! X*X/(MajorRadius**2)-Y*Y/(MinorRadius**2) = 1.0 <br>
//! The branch of the hyperbola described is the one located <br>
//! on the positive side of the major axis. <br>
//! The "main Direction" of the local coordinate system is a <br>
//! normal vector to the plane of the hyperbola. This vector <br>
//! gives an implicit orientation to the hyperbola. We refer to <br>
//! the "main Axis" of the local coordinate system as the <br>
//! "Axis" of the hyperbola. <br>
//! The following schema shows the plane of the hyperbola, <br>
//! and in it, the respective positions of the three branches of <br>
//! hyperbolas constructed with the functions OtherBranch, <br>
//! ConjugateBranch1, and ConjugateBranch2: <br>
public ref class OCgp_Hypr  {

protected:
  gp_Hypr* nativeHandle;
  OCgp_Hypr(OCDummy^) {};

public:
  property gp_Hypr* Handle
  {
    gp_Hypr* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCgp_Hypr(gp_Hypr* nativeHandle);

// Methods PUBLIC

//! Creates of an indefinite hyperbola. <br>
OCgp_Hypr();

//! Creates a hyperbola with radii MajorRadius and <br>
//!   MinorRadius, positioned in the space by the <br>
//!   coordinate system A2 such that: <br>
//!   -   the origin of A2 is the center of the hyperbola, <br>
//!   -   the "X Direction" of A2 defines the major axis of <br>
//!    the hyperbola, that is, the major radius <br>
//!    MajorRadius is measured along this axis, and <br>
//!   -   the "Y Direction" of A2 defines the minor axis of <br>
//!    the hyperbola, that is, the minor radius <br>
//!    MinorRadius is measured along this axis. <br>
//! Note: This class does not prevent the creation of a <br>
//! hyperbola where: <br>
//! -   MajorAxis is equal to MinorAxis, or <br>
//! -   MajorAxis is less than MinorAxis. <br>
//! Exceptions <br>
//! Standard_ConstructionError if MajorAxis or MinorAxis is negative. <br>
//!     Raises ConstructionError if MajorRadius < 0.0 or MinorRadius < 0.0 <br>//! Raised if MajorRadius < 0.0 or MinorRadius < 0.0 <br>
OCgp_Hypr(OCNaroWrappers::OCgp_Ax2^ A2, Standard_Real MajorRadius, Standard_Real MinorRadius);

//! Modifies this hyperbola, by redefining its local coordinate <br>
//! system so that: <br>
//! -   its origin and "main Direction" become those of the <br>
//!   axis A1 (the "X Direction" and "Y Direction" are then <br>
//!   recomputed in the same way as for any gp_Ax2). <br>
//! Raises ConstructionError if the direction of A1 is parallel to the direction of <br>
//!  the "XAxis" of the hyperbola. <br>
 /*instead*/  void SetAxis(OCNaroWrappers::OCgp_Ax1^ A1) ;

//! Modifies this hyperbola, by redefining its local coordinate <br>
//! system so that its origin becomes P. <br>
 /*instead*/  void SetLocation(OCNaroWrappers::OCgp_Pnt^ P) ;


//! Modifies the major  radius of this hyperbola. <br>
//! Exceptions <br>
//! Standard_ConstructionError if MajorRadius is negative. <br>
 /*instead*/  void SetMajorRadius(Standard_Real MajorRadius) ;


//! Modifies the minor  radius of this hyperbola. <br>
//! Exceptions <br>
//! Standard_ConstructionError if MinorRadius is negative. <br>
 /*instead*/  void SetMinorRadius(Standard_Real MinorRadius) ;

//! Modifies this hyperbola, by redefining its local coordinate <br>
//! system so that it becomes A2. <br>
 /*instead*/  void SetPosition(OCNaroWrappers::OCgp_Ax2^ A2) ;


//!  In the local coordinate system of the hyperbola the equation of <br>
//!  the hyperbola is (X*X)/(A*A) - (Y*Y)/(B*B) = 1.0 and the <br>
//!  equation of the first asymptote is Y = (B/A)*X <br>
//!  where A is the major radius and B is the minor radius. Raises ConstructionError if MajorRadius = 0.0 <br>
 /*instead*/  OCgp_Ax1^ Asymptote1() ;


//!  In the local coordinate system of the hyperbola the equation of <br>
//!  the hyperbola is (X*X)/(A*A) - (Y*Y)/(B*B) = 1.0 and the <br>
//!  equation of the first asymptote is Y = -(B/A)*X. <br>
//!  where A is the major radius and B is the minor radius. Raises ConstructionError if MajorRadius = 0.0 <br>
 /*instead*/  OCgp_Ax1^ Asymptote2() ;

//! Returns the axis passing through the center, <br>
//! and normal to the plane of this hyperbola. <br>
 /*instead*/  OCgp_Ax1^ Axis() ;


//!  Computes the branch of hyperbola which is on the positive side of the <br>
//!  "YAxis" of <me>. <br>
 /*instead*/  OCgp_Hypr^ ConjugateBranch1() ;


//!  Computes the branch of hyperbola which is on the negative side of the <br>
//!  "YAxis" of <me>. <br>
 /*instead*/  OCgp_Hypr^ ConjugateBranch2() ;


//!  This directrix is the line normal to the XAxis of the hyperbola <br>
//!  in the local plane (Z = 0) at a distance d = MajorRadius / e <br>
//!  from the center of the hyperbola, where e is the eccentricity of <br>
//!  the hyperbola. <br>
//!  This line is parallel to the "YAxis". The intersection point <br>
//!  between the directrix1 and the "XAxis" is the "Location" point <br>
//!  of the directrix1. This point is on the positive side of the <br>
//!  "XAxis". <br>
 /*instead*/  OCgp_Ax1^ Directrix1() ;


//!  This line is obtained by the symmetrical transformation <br>
//!  of "Directrix1" with respect to the "YAxis" of the hyperbola. <br>
 /*instead*/  OCgp_Ax1^ Directrix2() ;


//!  Returns the excentricity of the hyperbola (e > 1). <br>
//!  If f is the distance between the location of the hyperbola <br>
//!  and the Focus1 then the eccentricity e = f / MajorRadius. Raises DomainError if MajorRadius = 0.0 <br>
 /*instead*/  Standard_Real Eccentricity() ;


//!  Computes the focal distance. It is the distance between the <br>
//!  the two focus of the hyperbola. <br>
 /*instead*/  Standard_Real Focal() ;


//!  Returns the first focus of the hyperbola. This focus is on the <br>
//!  positive side of the "XAxis" of the hyperbola. <br>
 /*instead*/  OCgp_Pnt^ Focus1() ;


//!  Returns the second focus of the hyperbola. This focus is on the <br>
//!  negative side of the "XAxis" of the hyperbola. <br>
 /*instead*/  OCgp_Pnt^ Focus2() ;


//!  Returns  the location point of the hyperbola. It is the <br>
//!  intersection point between the "XAxis" and the "YAxis". <br>
 /*instead*/  OCgp_Pnt^ Location() ;


//!  Returns the major radius of the hyperbola. It is the radius <br>
//!  on the "XAxis" of the hyperbola. <br>
 /*instead*/  Standard_Real MajorRadius() ;


//!  Returns the minor radius of the hyperbola. It is the radius <br>
//!  on the "YAxis" of the hyperbola. <br>
 /*instead*/  Standard_Real MinorRadius() ;


//!  Returns the branch of hyperbola obtained by doing the <br>
//!  symmetrical transformation of <me> with respect to the <br>
//!  "YAxis"  of <me>. <br>
 /*instead*/  OCgp_Hypr^ OtherBranch() ;


//!  Returns p = (e * e - 1) * MajorRadius where e is the <br>
//!  eccentricity of the hyperbola. <br>
//! Raises DomainError if MajorRadius = 0.0 <br>
 /*instead*/  Standard_Real Parameter() ;

//! Returns the coordinate system of the hyperbola. <br>
 /*instead*/  OCgp_Ax2^ Position() ;

//! Computes an axis, whose <br>
//! -   the origin is the center of this hyperbola, and <br>
//! -   the unit vector is the "X Direction" <br>
//!   of the local coordinate system of this hyperbola. <br>
//! These axes are, the major axis (the "X <br>
//! Axis") and  of this hyperboReturns the "XAxis" of the hyperbola. <br>
 /*instead*/  OCgp_Ax1^ XAxis() ;

//!      Computes an axis, whose <br>
//! -   the origin is the center of this hyperbola, and <br>
//! -   the unit vector is the "Y Direction" <br>
//!   of the local coordinate system of this hyperbola. <br>
//! These axes are the minor axis (the "Y Axis") of this hyperbola <br>
 /*instead*/  OCgp_Ax1^ YAxis() ;


 /*instead*/  void Mirror(OCNaroWrappers::OCgp_Pnt^ P) ;


//!  Performs the symmetrical transformation of an hyperbola with <br>
//!  respect  to the point P which is the center of the symmetry. <br>
 /*instead*/  OCgp_Hypr^ Mirrored(OCNaroWrappers::OCgp_Pnt^ P) ;


 /*instead*/  void Mirror(OCNaroWrappers::OCgp_Ax1^ A1) ;


//!  Performs the symmetrical transformation of an hyperbola with <br>
//!  respect to an axis placement which is the axis of the symmetry. <br>
 /*instead*/  OCgp_Hypr^ Mirrored(OCNaroWrappers::OCgp_Ax1^ A1) ;


 /*instead*/  void Mirror(OCNaroWrappers::OCgp_Ax2^ A2) ;


//!  Performs the symmetrical transformation of an hyperbola with <br>
//!  respect to a plane. The axis placement A2 locates the plane <br>
//!  of the symmetry (Location, XDirection, YDirection). <br>
 /*instead*/  OCgp_Hypr^ Mirrored(OCNaroWrappers::OCgp_Ax2^ A2) ;


 /*instead*/  void Rotate(OCNaroWrappers::OCgp_Ax1^ A1, Standard_Real Ang) ;


//!  Rotates an hyperbola. A1 is the axis of the rotation. <br>
//!  Ang is the angular value of the rotation in radians. <br>
 /*instead*/  OCgp_Hypr^ Rotated(OCNaroWrappers::OCgp_Ax1^ A1, Standard_Real Ang) ;


 /*instead*/  void Scale(OCNaroWrappers::OCgp_Pnt^ P, Standard_Real S) ;


//!  Scales an hyperbola. S is the scaling value. <br>
 /*instead*/  OCgp_Hypr^ Scaled(OCNaroWrappers::OCgp_Pnt^ P, Standard_Real S) ;


 /*instead*/  void Transform(OCNaroWrappers::OCgp_Trsf^ T) ;


//!  Transforms an hyperbola with the transformation T from <br>
//!  class Trsf. <br>
 /*instead*/  OCgp_Hypr^ Transformed(OCNaroWrappers::OCgp_Trsf^ T) ;


 /*instead*/  void Translate(OCNaroWrappers::OCgp_Vec^ V) ;


//!  Translates an hyperbola in the direction of the vector V. <br>
//!  The magnitude of the translation is the vector's magnitude. <br>
 /*instead*/  OCgp_Hypr^ Translated(OCNaroWrappers::OCgp_Vec^ V) ;


 /*instead*/  void Translate(OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2) ;


//!  Translates an hyperbola from the point P1 to the point P2. <br>
 /*instead*/  OCgp_Hypr^ Translated(OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2) ;

~OCgp_Hypr()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
