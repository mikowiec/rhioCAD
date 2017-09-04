// File generated by CPPExt (MPV)
//
#ifndef _GC_MakeTrimmedCone_OCWrappers_HeaderFile
#define _GC_MakeTrimmedCone_OCWrappers_HeaderFile

// include native header
#include <GC_MakeTrimmedCone.hxx>
#include "../Converter.h"

#include "GC_Root.h"

#include "GC_Root.h"


namespace OCNaroWrappers
{

ref class OCGeom_RectangularTrimmedSurface;
ref class OCgp_Pnt;


//! Implements construction algorithms for a trimmed <br>
//! cone limited by two planes orthogonal to its axis. The <br>
//! result is a Geom_RectangularTrimmedSurface surface. <br>
//! A MakeTrimmedCone provides a framework for: <br>
//! -   defining the construction of the trimmed cone, <br>
//! -   implementing the construction algorithm, and <br>
//! -   consulting the results. In particular, the Value <br>
//!   function returns the constructed trimmed cone. <br>
public ref class OCGC_MakeTrimmedCone  : public OCGC_Root {

protected:
  // dummy constructor;
  OCGC_MakeTrimmedCone(OCDummy^) : OCGC_Root((OCDummy^)nullptr) {};

public:

// constructor from native
OCGC_MakeTrimmedCone(GC_MakeTrimmedCone* nativeHandle);

// Methods PUBLIC

//! Make a RectangularTrimmedSurface <TheCone> from Geom <br>
//!          It is trimmed by P3 and P4. <br>
//!          Its axis is <P1P2> and the radius of its base is <br>
//!          the distance between <P3> and <P1P2>. <br>
//!          The distance between <P4> and <P1P2> is the radius of <br>
//!          the section passing through <P4>. <br>
//!          An error iss raised if <P1>,<P2>,<P3>,<P4> are <br>
//!          colinear or if <P3P4> is perpendicular to <P1P2> or <br>
//!          <P3P4> is colinear to <P1P2>. <br>
OCGC_MakeTrimmedCone(OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2, OCNaroWrappers::OCgp_Pnt^ P3, OCNaroWrappers::OCgp_Pnt^ P4);

//! Make a RectangularTrimmedSurface from Geom <TheCone> <br>
//!           from a cone and trimmed by two points P1 and P2 and <br>
//!           the two radius <R1> and <R2> of the sections passing <br>
//!           through <P1> an <P2>. <br>
//! Warning <br>
//! If an error occurs (that is, when IsDone returns <br>
//! false), the Status function returns: <br>
//! -   gce_ConfusedPoints if points P1 and P2, or P3 and P4, are coincident; <br>
//! -   gce_NullAngle if: <br>
//!   -   the lines joining P1 to P2 and P3 to P4 are parallel, or <br>
//! -   R1 and R2 are equal (i.e. their difference is less than gp::Resolution()); <br>
//! -   gce_NullRadius if: <br>
//!   -   the line joining P1 to P2 is perpendicular to the line joining P3 to P4, or <br>
//!   -   the points P1, P2, P3 and P4 are collinear; <br>
//! -   gce_NegativeRadius if R1 or R2 is negative; or <br>
//! -   gce_NullAxis if points P1 and P2 are coincident (2nd syntax only). <br>
OCGC_MakeTrimmedCone(OCNaroWrappers::OCgp_Pnt^ P1, OCNaroWrappers::OCgp_Pnt^ P2, Standard_Real R1, Standard_Real R2);

//! Returns the constructed trimmed cone. <br>
//! StdFail_NotDone if no trimmed cone is constructed. <br>
 /*instead*/  OCGeom_RectangularTrimmedSurface^ Value() ;


 /*instead*/  OCGeom_RectangularTrimmedSurface^ Operator() ;

~OCGC_MakeTrimmedCone()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif