// File generated by CPPExt (MPV)
//
#ifndef _GCE2d_MakeParabola_OCWrappers_HeaderFile
#define _GCE2d_MakeParabola_OCWrappers_HeaderFile

// include native header
#include <GCE2d_MakeParabola.hxx>
#include "../Converter.h"

#include "GCE2d_Root.h"

#include "GCE2d_Root.h"


namespace OCNaroWrappers
{

ref class OCGeom2d_Parabola;
ref class OCgp_Parab2d;
ref class OCgp_Ax22d;
ref class OCgp_Ax2d;
ref class OCgp_Pnt2d;


//!This class implements the following algorithms used to <br>
//!          create Parabola from Geom2d. <br>
//!          * Create an Parabola from two apex  and the center. <br>
//!  Defines the parabola in the parameterization range  : <br>
//!  ]-infinite,+infinite[ <br>
//!  The vertex of the parabola is the "Location" point of the <br>
//!  local coordinate system "XAxis" of the parabola. <br>
//!  The "XAxis" of the parabola is its axis of symmetry. <br>
//!  The "Xaxis" is oriented from the vertex of the parabola to the <br>
//!  Focus of the parabola. <br>
//!  The equation of the parabola in the local coordinate system is <br>
//!  Y**2 = (2*P) * X <br>
//!  P is the distance between the focus and the directrix of the <br>
//!  parabola called Parameter). <br>
//!  The focal length F = P/2 is the distance between the vertex <br>
//!  and the focus of the parabola. <br>
public ref class OCGCE2d_MakeParabola  : public OCGCE2d_Root {

protected:
  // dummy constructor;
  OCGCE2d_MakeParabola(OCDummy^) : OCGCE2d_Root((OCDummy^)nullptr) {};

public:

// constructor from native
OCGCE2d_MakeParabola(GCE2d_MakeParabola* nativeHandle);

// Methods PUBLIC

//! Creates a parabola from a non persistent one. <br>
OCGCE2d_MakeParabola(OCNaroWrappers::OCgp_Parab2d^ Prb);

//! Creates a parabola with its local coordinate system and it's focal <br>
//!  length "Focal". <br>
//!  The "Location" point of "Axis" is the vertex of the parabola <br>
//! Status is "NegativeFocusLength" if Focal < 0.0 <br>
OCGCE2d_MakeParabola(OCNaroWrappers::OCgp_Ax22d^ Axis, Standard_Real Focal);

//! Creates a parabola with its "MirrorAxis" and it's focal length "Focal". <br>
//!  MirrorAxis is the axis of symmetry of the curve, it is the <br>
//!  "XAxis". The "YAxis" is parallel to the directrix of the <br>
//!  parabola. The "Location" point of "MirrorAxis" is the vertex of the parabola <br>
//! Status is "NegativeFocusLength" if Focal < 0.0 <br>
OCGCE2d_MakeParabola(OCNaroWrappers::OCgp_Ax2d^ MirrorAxis, Standard_Real Focal, System::Boolean Sense);

//! Creates a parabola with the local coordinate system and the focus point. <br>
//!  The sense of parametrization is given by Sense. <br>
OCGCE2d_MakeParabola(OCNaroWrappers::OCgp_Ax22d^ D, OCNaroWrappers::OCgp_Pnt2d^ F);


//!  D is the directrix of the parabola and F the focus point. <br>
//!  The symmetry axis "XAxis" of the parabola is normal to the <br>
//!  directrix and pass through the focus point F, but its <br>
//!  "Location" point is the vertex of the parabola. <br>
//!  The "YAxis" of the parabola is parallel to D and its "Location" <br>
//!  point is the vertex of the parabola. <br>
OCGCE2d_MakeParabola(OCNaroWrappers::OCgp_Ax2d^ D, OCNaroWrappers::OCgp_Pnt2d^ F, System::Boolean Sense);

//! Make a parabola with focal point S1 and <br>
//!          center O <br>
//!          The branch of the parabola returned will have <S1> as <br>
//!          focal point <br>
//! The implicit orientation of the parabola is: <br>
//! -   the same one as the parabola Prb, <br>
//! -   the sense defined by the coordinate system Axis or the directrix D, <br>
//! -   the trigonometric sense if Sense is not given or is true, or <br>
//! -   the opposite sense if Sense is false. <br>
//! Warning <br>
//! The MakeParabola class does not prevent the <br>
//! construction of a parabola with a null focal distance. <br>
//! If an error occurs (that is, when IsDone returns <br>
//! false), the Status function returns: <br>
//! -   gce_NullFocusLength if Focal is less than 0.0, or <br>
//! -   gce_NullAxis if points S1 and O are coincident. <br>
OCGCE2d_MakeParabola(OCNaroWrappers::OCgp_Pnt2d^ S1, OCNaroWrappers::OCgp_Pnt2d^ O);

//! Returns the constructed parabola. <br>
//! Exceptions StdFail_NotDone if no parabola is constructed. <br>
 /*instead*/  OCGeom2d_Parabola^ Value() ;


 /*instead*/  OCGeom2d_Parabola^ Operator() ;

~OCGCE2d_MakeParabola()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
