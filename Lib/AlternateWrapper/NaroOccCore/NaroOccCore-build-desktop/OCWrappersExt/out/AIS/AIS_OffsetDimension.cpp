// File generated by CPPExt (CPP file)
//

#include "AIS_OffsetDimension.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "../PrsMgr/PrsMgr_PresentationManager3d.h"
#include "../Prs3d/Prs3d_Presentation.h"
#include "../Prs3d/Prs3d_Projector.h"
#include "../PrsMgr/PrsMgr_PresentationManager2d.h"
#include "../Graphic2d/Graphic2d_GraphicObject.h"
#include "../Geom/Geom_Transformation.h"
#include "../SelectMgr/SelectMgr_Selection.h"
#include "../gp/gp_Trsf.h"


using namespace OCNaroWrappers;

OCAIS_OffsetDimension::OCAIS_OffsetDimension(Handle(AIS_OffsetDimension)* nativeHandle) : OCAIS_Relation((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_AIS_OffsetDimension(*nativeHandle);
}

OCAIS_OffsetDimension::OCAIS_OffsetDimension(OCNaroWrappers::OCTopoDS_Shape^ FistShape, OCNaroWrappers::OCTopoDS_Shape^ SecondShape, Standard_Real aVal, OCNaroWrappers::OCTCollection_ExtendedString^ aText) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_OffsetDimension(new AIS_OffsetDimension(*((TopoDS_Shape*)FistShape->Handle), *((TopoDS_Shape*)SecondShape->Handle), aVal, *((TCollection_ExtendedString*)aText->Handle)));
}

 void OCAIS_OffsetDimension::Compute(OCNaroWrappers::OCPrs3d_Projector^ aProjector, OCNaroWrappers::OCGeom_Transformation^ aTrsf, OCNaroWrappers::OCPrs3d_Presentation^ aPresentation)
{
  (*((Handle_AIS_OffsetDimension*)nativeHandle))->Compute(*((Handle_Prs3d_Projector*)aProjector->Handle), *((Handle_Geom_Transformation*)aTrsf->Handle), *((Handle_Prs3d_Presentation*)aPresentation->Handle));
}

 OCAIS_KindOfDimension OCAIS_OffsetDimension::KindOfDimension()
{
  return (OCAIS_KindOfDimension)((*((Handle_AIS_OffsetDimension*)nativeHandle))->KindOfDimension());
}

 System::Boolean OCAIS_OffsetDimension::IsMovable()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_AIS_OffsetDimension*)nativeHandle))->IsMovable());
}

 void OCAIS_OffsetDimension::SetRelativePos(OCNaroWrappers::OCgp_Trsf^ aTrsf)
{
  (*((Handle_AIS_OffsetDimension*)nativeHandle))->SetRelativePos(*((gp_Trsf*)aTrsf->Handle));
}


