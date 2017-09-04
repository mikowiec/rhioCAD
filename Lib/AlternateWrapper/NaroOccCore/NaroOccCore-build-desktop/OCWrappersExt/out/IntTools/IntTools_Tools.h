// File generated by CPPExt (MPV)
//
#ifndef _IntTools_Tools_OCWrappers_HeaderFile
#define _IntTools_Tools_OCWrappers_HeaderFile

// include native header
#include <IntTools_Tools.hxx>
#include "../Converter.h"


#include "../TopAbs/TopAbs_State.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Vertex;
ref class OCTopoDS_Wire;
ref class OCTopoDS_Face;
ref class OCgp_Pnt2d;
ref class OCTopoDS_Edge;
ref class OCIntTools_CommonPrt;
ref class OCgp_Pnt;
ref class OCIntTools_Curve;
ref class OCIntTools_SequenceOfCurves;
ref class OCgp_Dir;
ref class OCGeom_Curve;



//!  The class contains handy static functions <br>
//!  dealing with the geometry and topology. <br>
public ref class OCIntTools_Tools  {

protected:
  IntTools_Tools* nativeHandle;
  OCIntTools_Tools(OCDummy^) {};

public:
  property IntTools_Tools* Handle
  {
    IntTools_Tools* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCIntTools_Tools(IntTools_Tools* nativeHandle);

// Methods PUBLIC


//! Computes distance between vertex V1 and vertex V2, <br>
//! if the distance is less than sum of vertex tolerances <br>
//! returns zero, <br>
//! otherwise returns negative value <br>
static /*instead*/  Standard_Integer ComputeVV(OCNaroWrappers::OCTopoDS_Vertex^ V1, OCNaroWrappers::OCTopoDS_Vertex^ V2) ;


//! Returns True if wire aW contains edges <br>
//! with INTERNAL orientation <br>
static /*instead*/  System::Boolean HasInternalEdge(OCNaroWrappers::OCTopoDS_Wire^ aW) ;


//! Build a face based on surface of given face aF <br>
//! and bounded by wire aW <br>
static /*instead*/  void MakeFaceFromWireAndFace(OCNaroWrappers::OCTopoDS_Wire^ aW, OCNaroWrappers::OCTopoDS_Face^ aF, OCNaroWrappers::OCTopoDS_Face^ aFNew) ;


//! <br>
static /*instead*/  OCTopAbs_State ClassifyPointByFace(OCNaroWrappers::OCTopoDS_Face^ aF, OCNaroWrappers::OCgp_Pnt2d^ P) ;


//! Computes square distance between a point on the edge E <br>
//! corresponded to parameter t and vertices of edge E. <br>
//! Returns True if this distance is less than square <br>
//! tolerance of vertex, otherwise returns false. <br>
static /*instead*/  System::Boolean IsVertex(OCNaroWrappers::OCTopoDS_Edge^ E, Standard_Real t) ;


//! Returns True if square distance between vertex V <br>
//! and a point on the edge E corresponded to parameter t <br>
//! is less than square tolerance of V <br>
static /*instead*/  System::Boolean IsVertex(OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopoDS_Vertex^ V, Standard_Real t) ;


//! Returns True if IsVertx for middle parameter of fist range <br>
//! and first edge returns True <br>
//! and if IsVertex for middle parameter of second range and <br>
//! second range returns True, <br>
//! otherwise returns False <br>
static /*instead*/  System::Boolean IsVertex(OCNaroWrappers::OCIntTools_CommonPrt^ aCmnPrt) ;


//! Gets boundary of parameters of E1 and E2. <br>
//! Computes 3d points on each corresponded to average parameters. <br>
//! Returns True if distance between computed points is less than <br>
//! sum of edge tolerance, otherwise returns False. <br>
static /*instead*/  System::Boolean IsMiddlePointsEqual(OCNaroWrappers::OCTopoDS_Edge^ E1, OCNaroWrappers::OCTopoDS_Edge^ E2) ;


//! Returns True if the distance between point aP and <br>
//! vertex aV is less or equal to sum of aTolPV and <br>
//! vertex tolerance, otherwise returns False <br>
static /*instead*/  System::Boolean IsVertex(OCNaroWrappers::OCgp_Pnt^ aP, Standard_Real aTolPV, OCNaroWrappers::OCTopoDS_Vertex^ aV) ;


//! Returns some value between aFirst and aLast <br>
static /*instead*/  Standard_Real IntermediatePoint(Standard_Real aFirst, Standard_Real aLast) ;


//! Split aC by average parameter if aC is closed in 3D. <br>
//! Returns positive value if splitting has been done, <br>
//! otherwise returns zero. <br>
static /*instead*/  Standard_Integer SplitCurve(OCNaroWrappers::OCIntTools_Curve^ aC, OCNaroWrappers::OCIntTools_SequenceOfCurves^ aS) ;


//! Puts curves from aSIn to aSOut except those curves that <br>
//! are coincide with first curve from aSIn. <br>
static /*instead*/  void RejectLines(OCNaroWrappers::OCIntTools_SequenceOfCurves^ aSIn, OCNaroWrappers::OCIntTools_SequenceOfCurves^ aSOut) ;


//! Returns True if D1 and D2 coinside <br>
//! <br>
static /*instead*/  System::Boolean IsDirsCoinside(OCNaroWrappers::OCgp_Dir^ D1, OCNaroWrappers::OCgp_Dir^ D2) ;


//! Returns True if D1 and D2 coinside with given tolerance <br>
//! <br>
static /*instead*/  System::Boolean IsDirsCoinside(OCNaroWrappers::OCgp_Dir^ D1, OCNaroWrappers::OCgp_Dir^ D2, Standard_Real aTol) ;


//! Returns True if aC is BoundedCurve from Geom and <br>
//! the distance between first point <br>
//! of the curve aC and last point <br>
//! is less than 1.e-12 <br>
static /*instead*/  System::Boolean IsClosed(OCNaroWrappers::OCGeom_Curve^ aC) ;


//! Returns adaptive tolerance for given aTolBase <br>
//! if aC is trimmed curve and basis curve is parabola, <br>
//! otherwise returns value of aTolBase <br>
static /*instead*/  Standard_Real CurveTolerance(OCNaroWrappers::OCGeom_Curve^ aC, Standard_Real aTolBase) ;

~OCIntTools_Tools()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif