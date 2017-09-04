// File generated by CPPExt (Package)
//

#ifndef _BRepFill_OCWrappers_HeaderFile
#define _BRepFill_OCWrappers_HeaderFile

// Include the wrapped header
#include <BRepFill.hxx>

#include "BRepFill_Generator.h"
#include "BRepFill_SectionLaw.h"
#include "BRepFill_ShapeLaw.h"
#include "BRepFill_NSections.h"
#include "BRepFill_Draft.h"
#include "BRepFill_LocationLaw.h"
#include "BRepFill_DraftLaw.h"
#include "BRepFill_Edge3DLaw.h"
#include "BRepFill_EdgeOnSurfLaw.h"
#include "BRepFill_ACRLaw.h"
#include "BRepFill_Pipe.h"
#include "BRepFill_PipeShell.h"
#include "BRepFill_Evolved.h"
#include "BRepFill_Sweep.h"
#include "BRepFill_CompatibleWires.h"
#include "BRepFill_OffsetWire.h"
#include "BRepFill_OffsetAncestors.h"
#include "BRepFill_ListOfOffsetWire.h"
#include "BRepFill_ApproxSeewing.h"
#include "BRepFill_MultiLine.h"
#include "BRepFill_MultiLineTool.h"
#include "BRepFill_ComputeCLine.h"
#include "BRepFill_TrimSurfaceTool.h"
#include "BRepFill_TrimEdgeTool.h"
#include "BRepFill_SectionPlacement.h"
#include "BRepFill_Section.h"
#include "BRepFill_TrimShellCorner.h"
#include "BRepFill_SequenceOfSection.h"
#include "BRepFill_DataMapOfNodeDataMapOfShapeShape.h"
#include "BRepFill_DataMapOfNodeShape.h"
#include "BRepFill_DataMapOfShapeDataMapOfShapeListOfShape.h"
#include "BRepFill_DataMapOfShapeSequenceOfReal.h"
#include "BRepFill_DataMapOfShapeSequenceOfPnt.h"
#include "BRepFill_DataMapOfOrientedShapeListOfShape.h"
#include "BRepFill_IndexedDataMapOfOrientedShapeListOfShape.h"
#include "BRepFill_CurveConstraint.h"
#include "BRepFill_Filling.h"
#include "BRepFill_FaceAndOrder.h"
#include "BRepFill_EdgeFaceAndOrder.h"
#include "BRepFill_SequenceOfFaceAndOrder.h"
#include "BRepFill_SequenceOfEdgeFaceAndOrder.h"
#include "BRepFill_ListNodeOfListOfOffsetWire.h"
#include "BRepFill_ListIteratorOfListOfOffsetWire.h"
#include "BRepFill_MyLeastSquareOfComputeCLine.h"
#include "BRepFill_SequenceNodeOfSequenceOfSection.h"
#include "BRepFill_DataMapNodeOfDataMapOfNodeDataMapOfShapeShape.h"
#include "BRepFill_DataMapIteratorOfDataMapOfNodeDataMapOfShapeShape.h"
#include "BRepFill_DataMapNodeOfDataMapOfNodeShape.h"
#include "BRepFill_DataMapIteratorOfDataMapOfNodeShape.h"
#include "BRepFill_DataMapNodeOfDataMapOfShapeDataMapOfShapeListOfShape.h"
#include "BRepFill_DataMapIteratorOfDataMapOfShapeDataMapOfShapeListOfShape.h"
#include "BRepFill_DataMapNodeOfDataMapOfShapeSequenceOfReal.h"
#include "BRepFill_DataMapIteratorOfDataMapOfShapeSequenceOfReal.h"
#include "BRepFill_DataMapNodeOfDataMapOfShapeSequenceOfPnt.h"
#include "BRepFill_DataMapIteratorOfDataMapOfShapeSequenceOfPnt.h"
#include "BRepFill_DataMapNodeOfDataMapOfOrientedShapeListOfShape.h"
#include "BRepFill_DataMapIteratorOfDataMapOfOrientedShapeListOfShape.h"
#include "BRepFill_IndexedDataMapNodeOfIndexedDataMapOfOrientedShapeListOfShape.h"
#include "BRepFill_SequenceNodeOfSequenceOfFaceAndOrder.h"
#include "BRepFill_SequenceNodeOfSequenceOfEdgeFaceAndOrder.h"


namespace OCNaroWrappers
{

public ref class OCBRepFill abstract sealed
{

public:
// Methods


static /*instead*/  OCTopoDS_Face^ Face(OCNaroWrappers::OCTopoDS_Edge^ Edge1, OCNaroWrappers::OCTopoDS_Edge^ Edge2) ;


static /*instead*/  OCTopoDS_Shell^ Shell(OCNaroWrappers::OCTopoDS_Wire^ Wire1, OCNaroWrappers::OCTopoDS_Wire^ Wire2) ;

//! Computes  <AxeProf>  as Follow. <Location> is <br>
//!          the Position of the nearest vertex V  of <Profile> <br>
//!          to <Spine>.<XDirection> is confused with the tangent <br>
//!          to <Spine> at the projected point of V on the Spine. <br>
//!          <Direction> is normal to <Spine>. <br>
//!          <Spine> is a plane wire or a plane face. <br>
static /*instead*/  void Axe(OCNaroWrappers::OCTopoDS_Shape^ Spine, OCNaroWrappers::OCTopoDS_Wire^ Profile, OCNaroWrappers::OCgp_Ax3^ AxeProf, System::Boolean& ProfOnSpine, Standard_Real Tol) ;

//!  Compute ACR on a  wire <br>
static /*instead*/  void ComputeACR(OCNaroWrappers::OCTopoDS_Wire^ wire, OCNaroWrappers::OCTColStd_Array1OfReal^ ACR) ;


static /*instead*/  OCTopoDS_Wire^ InsertACR(OCNaroWrappers::OCTopoDS_Wire^ wire, OCNaroWrappers::OCTColStd_Array1OfReal^ ACRcuts, Standard_Real prec) ;


};

}; // OCNaroWrappers

#endif
