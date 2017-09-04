// File generated by CPPExt (CPP file)
//

#include "AIS_SymmetricRelation.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../Geom/Geom_Plane.h"
#include "../PrsMgr/PrsMgr_PresentationManager3d.h"
#include "../Prs3d/Prs3d_Presentation.h"
#include "../Prs3d/Prs3d_Projector.h"
#include "../PrsMgr/PrsMgr_PresentationManager2d.h"
#include "../Graphic2d/Graphic2d_GraphicObject.h"
#include "../Geom/Geom_Transformation.h"
#include "../SelectMgr/SelectMgr_Selection.h"


using namespace OCNaroWrappers;

OCAIS_SymmetricRelation::OCAIS_SymmetricRelation(Handle(AIS_SymmetricRelation)* nativeHandle) : OCAIS_Relation((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_AIS_SymmetricRelation(*nativeHandle);
}

OCAIS_SymmetricRelation::OCAIS_SymmetricRelation(OCNaroWrappers::OCTopoDS_Shape^ aSymmTool, OCNaroWrappers::OCTopoDS_Shape^ FirstShape, OCNaroWrappers::OCTopoDS_Shape^ SecondShape, OCNaroWrappers::OCGeom_Plane^ aPlane) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_SymmetricRelation(new AIS_SymmetricRelation(*((TopoDS_Shape*)aSymmTool->Handle), *((TopoDS_Shape*)FirstShape->Handle), *((TopoDS_Shape*)SecondShape->Handle), *((Handle_Geom_Plane*)aPlane->Handle)));
}

 System::Boolean OCAIS_SymmetricRelation::IsMovable()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_AIS_SymmetricRelation*)nativeHandle))->IsMovable());
}

 void OCAIS_SymmetricRelation::SetTool(OCNaroWrappers::OCTopoDS_Shape^ aSymmetricTool)
{
  (*((Handle_AIS_SymmetricRelation*)nativeHandle))->SetTool(*((TopoDS_Shape*)aSymmetricTool->Handle));
}

OCTopoDS_Shape^ OCAIS_SymmetricRelation::GetTool()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = (*((Handle_AIS_SymmetricRelation*)nativeHandle))->GetTool();
  return gcnew OCTopoDS_Shape(tmp);
}

 void OCAIS_SymmetricRelation::Compute(OCNaroWrappers::OCPrs3d_Projector^ aProjector, OCNaroWrappers::OCGeom_Transformation^ aTrsf, OCNaroWrappers::OCPrs3d_Presentation^ aPresentation)
{
  (*((Handle_AIS_SymmetricRelation*)nativeHandle))->Compute(*((Handle_Prs3d_Projector*)aProjector->Handle), *((Handle_Geom_Transformation*)aTrsf->Handle), *((Handle_Prs3d_Presentation*)aPresentation->Handle));
}


