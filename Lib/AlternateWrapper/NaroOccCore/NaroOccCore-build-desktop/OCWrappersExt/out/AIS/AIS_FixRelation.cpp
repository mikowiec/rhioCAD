// File generated by CPPExt (CPP file)
//

#include "AIS_FixRelation.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../Geom/Geom_Plane.h"
#include "../TopoDS/TopoDS_Wire.h"
#include "../gp/gp_Pnt.h"
#include "../PrsMgr/PrsMgr_PresentationManager3d.h"
#include "../Prs3d/Prs3d_Presentation.h"
#include "../Prs3d/Prs3d_Projector.h"
#include "../PrsMgr/PrsMgr_PresentationManager2d.h"
#include "../Graphic2d/Graphic2d_GraphicObject.h"
#include "../Geom/Geom_Transformation.h"
#include "../SelectMgr/SelectMgr_Selection.h"
#include "../TopoDS/TopoDS_Vertex.h"
#include "../Geom/Geom_Curve.h"
#include "../TopoDS/TopoDS_Edge.h"
#include "../gp/gp_Lin.h"
#include "../gp/gp_Circ.h"


using namespace OCNaroWrappers;

OCAIS_FixRelation::OCAIS_FixRelation(Handle(AIS_FixRelation)* nativeHandle) : OCAIS_Relation((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_AIS_FixRelation(*nativeHandle);
}

OCAIS_FixRelation::OCAIS_FixRelation(OCNaroWrappers::OCTopoDS_Shape^ aShape, OCNaroWrappers::OCGeom_Plane^ aPlane, OCNaroWrappers::OCTopoDS_Wire^ aWire) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_FixRelation(new AIS_FixRelation(*((TopoDS_Shape*)aShape->Handle), *((Handle_Geom_Plane*)aPlane->Handle), *((TopoDS_Wire*)aWire->Handle)));
}

OCAIS_FixRelation::OCAIS_FixRelation(OCNaroWrappers::OCTopoDS_Shape^ aShape, OCNaroWrappers::OCGeom_Plane^ aPlane, OCNaroWrappers::OCTopoDS_Wire^ aWire, OCNaroWrappers::OCgp_Pnt^ aPosition, Standard_Real anArrowSize) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_FixRelation(new AIS_FixRelation(*((TopoDS_Shape*)aShape->Handle), *((Handle_Geom_Plane*)aPlane->Handle), *((TopoDS_Wire*)aWire->Handle), *((gp_Pnt*)aPosition->Handle), anArrowSize));
}

OCAIS_FixRelation::OCAIS_FixRelation(OCNaroWrappers::OCTopoDS_Shape^ aShape, OCNaroWrappers::OCGeom_Plane^ aPlane) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_FixRelation(new AIS_FixRelation(*((TopoDS_Shape*)aShape->Handle), *((Handle_Geom_Plane*)aPlane->Handle)));
}

OCAIS_FixRelation::OCAIS_FixRelation(OCNaroWrappers::OCTopoDS_Shape^ aShape, OCNaroWrappers::OCGeom_Plane^ aPlane, OCNaroWrappers::OCgp_Pnt^ aPosition, Standard_Real anArrowSize) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_FixRelation(new AIS_FixRelation(*((TopoDS_Shape*)aShape->Handle), *((Handle_Geom_Plane*)aPlane->Handle), *((gp_Pnt*)aPosition->Handle), anArrowSize));
}

OCTopoDS_Wire^ OCAIS_FixRelation::Wire()
{
  TopoDS_Wire* tmp = new TopoDS_Wire();
  *tmp = (*((Handle_AIS_FixRelation*)nativeHandle))->Wire();
  return gcnew OCTopoDS_Wire(tmp);
}

 void OCAIS_FixRelation::SetWire(OCNaroWrappers::OCTopoDS_Wire^ aWire)
{
  (*((Handle_AIS_FixRelation*)nativeHandle))->SetWire(*((TopoDS_Wire*)aWire->Handle));
}

 System::Boolean OCAIS_FixRelation::IsMovable()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_AIS_FixRelation*)nativeHandle))->IsMovable());
}

 void OCAIS_FixRelation::Compute(OCNaroWrappers::OCPrs3d_Projector^ aProjector, OCNaroWrappers::OCGeom_Transformation^ aTrsf, OCNaroWrappers::OCPrs3d_Presentation^ aPresentation)
{
  (*((Handle_AIS_FixRelation*)nativeHandle))->Compute(*((Handle_Prs3d_Projector*)aProjector->Handle), *((Handle_Geom_Transformation*)aTrsf->Handle), *((Handle_Prs3d_Presentation*)aPresentation->Handle));
}


