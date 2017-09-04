// File generated by CPPExt (Transient)
//
#ifndef _AIS_MidPointRelation_OCWrappers_HeaderFile
#define _AIS_MidPointRelation_OCWrappers_HeaderFile

// include the wrapped class
#include <AIS_MidPointRelation.hxx>
#include "../Converter.h"

#include "AIS_Relation.h"

#include "../TopoDS/TopoDS_Shape.h"
#include "../gp/gp_Pnt.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCGeom_Plane;
ref class OCPrsMgr_PresentationManager3d;
ref class OCPrs3d_Presentation;
ref class OCPrs3d_Projector;
ref class OCPrsMgr_PresentationManager2d;
ref class OCGraphic2d_GraphicObject;
ref class OCGeom_Transformation;
ref class OCSelectMgr_Selection;
ref class OCgp_Lin;
ref class OCgp_Pnt;
ref class OCgp_Circ;
ref class OCgp_Elips;


//! presentation of equal distance to point myMidPoint <br>
public ref class OCAIS_MidPointRelation : OCAIS_Relation {

protected:
  // dummy constructor;
  OCAIS_MidPointRelation(OCDummy^) : OCAIS_Relation((OCDummy^)nullptr) {};

public:

// constructor from native
OCAIS_MidPointRelation(Handle(AIS_MidPointRelation)* nativeHandle);

// Methods PUBLIC


OCAIS_MidPointRelation(OCNaroWrappers::OCTopoDS_Shape^ aSymmTool, OCNaroWrappers::OCTopoDS_Shape^ FirstShape, OCNaroWrappers::OCTopoDS_Shape^ SecondShape, OCNaroWrappers::OCGeom_Plane^ aPlane);


virtual /*instead*/  System::Boolean IsMovable() override;


 /*instead*/  void SetTool(OCNaroWrappers::OCTopoDS_Shape^ aMidPointTool) ;


 /*instead*/  OCTopoDS_Shape^ GetTool() ;

//! Computes the presentation according to a point of view <br>
//!          given by <aProjector>. <br>
//!          To be Used when the associated degenerated Presentations <br>
//!          have been transformed by <aTrsf> which is not a Pure <br>
//!          Translation. The HLR Prs can't be deducted automatically <br>
//!          WARNING :<aTrsf> must be applied <br>
//!           to the object to display before computation  !!! <br>
virtual /*instead*/  void Compute(OCNaroWrappers::OCPrs3d_Projector^ aProjector, OCNaroWrappers::OCGeom_Transformation^ aTrsf, OCNaroWrappers::OCPrs3d_Presentation^ aPresentation) override;

~OCAIS_MidPointRelation()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
