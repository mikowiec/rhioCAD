// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRep_FacesFiller_OCWrappers_HeaderFile
#define _TopOpeBRep_FacesFiller_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRep_FacesFiller.hxx>
#include "../Converter.h"


#include "../TopoDS/TopoDS_Face.h"
#include "../TopAbs/TopAbs_Orientation.h"
#include "../TopOpeBRepDS/TopOpeBRepDS_Transition.h"
#include "../TopTools/TopTools_ListOfShape.h"
#include "../TopTools/TopTools_DataMapOfShapeListOfShape.h"
#include "../TopOpeBRepDS/TopOpeBRepDS_ListOfInterference.h"
#include "TopOpeBRep_PointClassifier.h"
#include "../TopOpeBRepDS/TopOpeBRepDS_Kind.h"
#include "../TopAbs/TopAbs_State.h"


namespace OCNaroWrappers
{

ref class OCTopOpeBRepDS_HDataStructure;
ref class OCTopOpeBRep_FFDumper;
ref class OCTopoDS_Shape;
ref class OCTopOpeBRep_FacesIntersector;
ref class OCTopOpeBRep_PointClassifier;
ref class OCTopOpeBRep_LineInter;
ref class OCTopOpeBRep_VPointInter;
ref class OCTopOpeBRep_VPointInterClassifier;
ref class OCTopTools_ListOfShape;
ref class OCTopOpeBRep_VPointInterIterator;
ref class OCTopOpeBRepDS_Transition;
ref class OCTopOpeBRepDS_Interference;
ref class OCTopOpeBRepDS_ListIteratorOfListOfInterference;
ref class OCTopOpeBRepDS_Point;
ref class OCTopoDS_Face;
ref class OCgp_Pnt;
ref class OCTopOpeBRepDS_DataStructure;


//! Fills a DataStructure from TopOpeBRepDS with the result <br>
//! of Face/Face instersection described by FacesIntersector from TopOpeBRep. <br>
//! if the faces have same Domain, record it in the DS. <br>
//! else record lines and  points and attach list of interferences <br>
//! to the faces, the lines and the edges. <br>
public ref class OCTopOpeBRep_FacesFiller  {

protected:
  TopOpeBRep_FacesFiller* nativeHandle;
  OCTopOpeBRep_FacesFiller(OCDummy^) {};

public:
  property TopOpeBRep_FacesFiller* Handle
  {
    TopOpeBRep_FacesFiller* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopOpeBRep_FacesFiller(TopOpeBRep_FacesFiller* nativeHandle);

// Methods PUBLIC


OCTopOpeBRep_FacesFiller();

//! Stores in <DS> the intersections of <S1> and <S2>. <br>
 /*instead*/  void Insert(OCNaroWrappers::OCTopoDS_Shape^ F1, OCNaroWrappers::OCTopoDS_Shape^ F2, OCNaroWrappers::OCTopOpeBRep_FacesIntersector^ FACINT, OCNaroWrappers::OCTopOpeBRepDS_HDataStructure^ HDS) ;


 /*instead*/  void ProcessSectionEdges() ;


 /*instead*/  OCTopOpeBRep_PointClassifier^ ChangePointClassifier() ;

//! return field myPShapeClassifier. <br>
 /*instead*/  TopOpeBRepTool_PShapeClassifier PShapeClassifier() ;

//! set field myPShapeClassifier. <br>
 /*instead*/  void SetPShapeClassifier(TopOpeBRepTool_PShapeClassifier PSC) ;


 /*instead*/  void LoadLine(OCNaroWrappers::OCTopOpeBRep_LineInter^ L) ;


 /*instead*/  System::Boolean CheckLine(OCNaroWrappers::OCTopOpeBRep_LineInter^ L) ;

//! compute position of VPoints of lines <br>
 /*instead*/  void VP_Position(OCNaroWrappers::OCTopOpeBRep_FacesIntersector^ FACINT) ;

//! compute position of VPoints of line L <br>
 /*instead*/  void VP_Position(OCNaroWrappers::OCTopOpeBRep_LineInter^ L) ;

//! compute position of VPoints of non-restriction line L. <br>
 /*instead*/  void VP_PositionOnL(OCNaroWrappers::OCTopOpeBRep_LineInter^ L) ;

//! compute position of VPoints of restriction line L. <br>
 /*instead*/  void VP_PositionOnR(OCNaroWrappers::OCTopOpeBRep_LineInter^ L) ;

//! compute position of VP with current faces, <br>
//!          according to VP.ShapeIndex() . <br>
 /*instead*/  void VP_Position(OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP, OCNaroWrappers::OCTopOpeBRep_VPointInterClassifier^ VPC) ;

//! Process current intersection line (set by LoadLine) <br>
 /*instead*/  void ProcessLine() ;


 /*instead*/  void ResetDSC() ;

//! Process current restriction line, adding restriction edge <br>
//!          and computing face/edge interference. <br>
 /*instead*/  void ProcessRLine() ;

//!  VP processing for restriction  line  and line sharing <br>
//!           same domain with  section edges : <br>
//!            - if restriction : <br>
//!            Adds restriction edges as  section edges and compute <br>
//!           face/edge  interference. <br>
//!            - if  same domain : <br>
//!            If line share same domain  with section edges, compute <br>
//!           parts of line IN/IN the two faces, and compute curve/point <br>
//!           interference for VP boundaries. <br>
 /*instead*/  void FillLineVPonR() ;


 /*instead*/  void FillLine() ;

//! compute 3d curve, pcurves and face/curve interferences <br>
//!          for current NDSC. Add them to the DS. <br>
 /*instead*/  void AddShapesLine() ;

//! Get map <mapES > of restriction edges having parts IN one <br>
//!          of the 2 faces. <br>
 /*instead*/  void GetESL(OCNaroWrappers::OCTopTools_ListOfShape^ LES) ;

//! calling the followings ProcessVPIonR and ProcessVPonR. <br>
 /*instead*/  void ProcessVPR(OCNaroWrappers::OCTopOpeBRep_FacesFiller^ FF, OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP) ;

//! processing ProcessVPonR for VPI. <br>
 /*instead*/  void ProcessVPIonR(OCNaroWrappers::OCTopOpeBRep_VPointInterIterator^ VPI, OCNaroWrappers::OCTopOpeBRepDS_Transition^ trans1, OCNaroWrappers::OCTopoDS_Shape^ F1, Standard_Integer ShapeIndex) ;

//! adds <VP>'s   geometric   point (if not   stored)  and <br>
//!          computes (curve or edge)/(point or vertex) interference. <br>
 /*instead*/  void ProcessVPonR(OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP, OCNaroWrappers::OCTopOpeBRepDS_Transition^ trans1, OCNaroWrappers::OCTopoDS_Shape^ F1, Standard_Integer ShapeIndex) ;

//! VP processing on closing arc. <br>
 /*instead*/  void ProcessVPonclosingR(OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP, OCNaroWrappers::OCTopoDS_Shape^ F1, Standard_Integer ShapeIndex, OCNaroWrappers::OCTopOpeBRepDS_Transition^ transEdge, OCTopOpeBRepDS_Kind PVKind, Standard_Integer PVIndex, System::Boolean EPIfound, OCNaroWrappers::OCTopOpeBRepDS_Interference^ IEPI) ;

//! VP processing on degenerated arc. <br>
 /*instead*/  System::Boolean ProcessVPondgE(OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP, Standard_Integer ShapeIndex, OCTopOpeBRepDS_Kind& PVKind, Standard_Integer& PVIndex, System::Boolean& EPIfound, OCNaroWrappers::OCTopOpeBRepDS_Interference^ IEPI, System::Boolean& CPIfound, OCNaroWrappers::OCTopOpeBRepDS_Interference^ ICPI) ;

//! processing ProcessVPnotonR for VPI. <br>
 /*instead*/  void ProcessVPInotonR(OCNaroWrappers::OCTopOpeBRep_VPointInterIterator^ VPI) ;

//! adds <VP>'s  geometrical point to the DS (if not stored) <br>
//!          and computes curve point interference. <br>
 /*instead*/  void ProcessVPnotonR(OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP) ;


//! Get the geometry of a DS point <DSP>. <br>
//! Search for it with ScanInterfList (previous method). <br>
//! if found, set <G> to the geometry of the interference found. <br>
//! else, add the point <DSP> in the <DS> and set <G> to the <br>
//! value of the new geometry such created. <br>
//! returns the value of ScanInterfList(). <br>
 /*instead*/  System::Boolean GetGeometry(OCNaroWrappers::OCTopOpeBRepDS_ListIteratorOfListOfInterference^ IT, OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP, Standard_Integer& G, OCTopOpeBRepDS_Kind& K) ;


 /*instead*/  Standard_Integer MakeGeometry(OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP, Standard_Integer ShapeIndex, OCTopOpeBRepDS_Kind& K) ;


//! Add interference <I> to list myDSCIL. <br>
//! on a given line, at first call, add a new DS curve. <br>
 /*instead*/  void StoreCurveInterference(OCNaroWrappers::OCTopOpeBRepDS_Interference^ I) ;

//! search for G = geometry of Point which is identical to <DSP> <br>
//!          among the DS Points created in the CURRENT face/face <br>
//!          intersection ( current Insert() call). <br>
 /*instead*/  System::Boolean GetFFGeometry(OCNaroWrappers::OCTopOpeBRepDS_Point^ DSP, OCTopOpeBRepDS_Kind& K, Standard_Integer& G) ;

//! search for G = geometry of Point which is identical to <VP> <br>
//!          among the DS Points created in the CURRENT face/face <br>
//!          intersection ( current Insert() call). <br>
 /*instead*/  System::Boolean GetFFGeometry(OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP, OCTopOpeBRepDS_Kind& K, Standard_Integer& G) ;


 /*instead*/  OCTopOpeBRep_FacesIntersector^ ChangeFacesIntersector() ;


 /*instead*/  OCTopOpeBRepDS_HDataStructure^ HDataStructure() ;


 /*instead*/  OCTopOpeBRepDS_DataStructure^ ChangeDataStructure() ;


 /*instead*/  OCTopoDS_Face^ Face(Standard_Integer I) ;


 /*instead*/  OCTopOpeBRepDS_Transition^ FaceFaceTransition(OCNaroWrappers::OCTopOpeBRep_LineInter^ L, Standard_Integer I) ;


 /*instead*/  OCTopOpeBRepDS_Transition^ FaceFaceTransition(Standard_Integer I) ;


 /*instead*/  TopOpeBRep_PFacesIntersector PFacesIntersectorDummy() ;


 /*instead*/  TopOpeBRepDS_PDataStructure PDataStructureDummy() ;


 /*instead*/  TopOpeBRep_PLineInter PLineInterDummy() ;


 /*instead*/  void SetTraceIndex(Standard_Integer exF1, Standard_Integer exF2) ;


 /*instead*/  void GetTraceIndex(Standard_Integer& exF1, Standard_Integer& exF2) ;

//! Computes <pmin> and <pmax> the upper and lower bounds of <L> <br>
//!          enclosing all vpoints. <br>
static /*instead*/  void Lminmax(OCNaroWrappers::OCTopOpeBRep_LineInter^ L, Standard_Real& pmin, Standard_Real& pmax) ;

//! Returns <True> if <L> shares a same geometric domain with <br>
//!          at least one of the section edges of <ERL>. <br>
static /*instead*/  System::Boolean LSameDomainERL(OCNaroWrappers::OCTopOpeBRep_LineInter^ L, OCNaroWrappers::OCTopTools_ListOfShape^ ERL) ;

//! Computes the transition <T> of the VPoint <iVP> on the edge <br>
//!          of <SI12>. Returns <False> if the status is unknown. <br>
static /*instead*/  System::Boolean IsVPtransLok(OCNaroWrappers::OCTopOpeBRep_LineInter^ L, Standard_Integer iVP, Standard_Integer SI12, OCNaroWrappers::OCTopOpeBRepDS_Transition^ T) ;

//! Computes   transition   on line for  VP<iVP>   on edge <br>
//!          restriction of <SI>.  If <isINOUT>  :  returns <true> if <br>
//!          transition computed is IN/OUT else : returns <true> if <br>
//!          transition computed is OUT/IN. <br>
static /*instead*/  System::Boolean TransvpOK(OCNaroWrappers::OCTopOpeBRep_LineInter^ L, Standard_Integer iVP, Standard_Integer SI, System::Boolean isINOUT) ;

//! Returns parameter u of vp on the restriction edge. <br>
static /*instead*/  Standard_Real VPParamOnER(OCNaroWrappers::OCTopOpeBRep_VPointInter^ vp, OCNaroWrappers::OCTopOpeBRep_LineInter^ Lrest) ;


static /*instead*/  System::Boolean EqualpPonR(OCNaroWrappers::OCTopOpeBRep_LineInter^ Lrest, OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP1, OCNaroWrappers::OCTopOpeBRep_VPointInter^ VP2) ;


static /*instead*/  System::Boolean EqualpP(OCNaroWrappers::OCTopOpeBRep_LineInter^ L, Standard_Integer iVP1, Standard_Integer iVP2) ;

~OCTopOpeBRep_FacesFiller()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
