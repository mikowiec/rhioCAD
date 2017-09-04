// File generated by CPPExt (CPP file)
//

#include "AIS_RadiusDimension.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "../gp/gp_Pnt.h"
#include "../PrsMgr/PrsMgr_PresentationManager3d.h"
#include "../Prs3d/Prs3d_Presentation.h"
#include "../Prs3d/Prs3d_Projector.h"
#include "../PrsMgr/PrsMgr_PresentationManager2d.h"
#include "../Graphic2d/Graphic2d_GraphicObject.h"
#include "../Geom/Geom_Transformation.h"
#include "../SelectMgr/SelectMgr_Selection.h"


using namespace OCNaroWrappers;

OCAIS_RadiusDimension::OCAIS_RadiusDimension(Handle(AIS_RadiusDimension)* nativeHandle) : OCAIS_Relation((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_AIS_RadiusDimension(*nativeHandle);
}

OCAIS_RadiusDimension::OCAIS_RadiusDimension(OCNaroWrappers::OCTopoDS_Shape^ aShape, Standard_Real aVal, OCNaroWrappers::OCTCollection_ExtendedString^ aText) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_RadiusDimension(new AIS_RadiusDimension(*((TopoDS_Shape*)aShape->Handle), aVal, *((TCollection_ExtendedString*)aText->Handle)));
}

OCAIS_RadiusDimension::OCAIS_RadiusDimension(OCNaroWrappers::OCTopoDS_Shape^ aShape, Standard_Real aVal, OCNaroWrappers::OCTCollection_ExtendedString^ aText, OCNaroWrappers::OCgp_Pnt^ aPosition, OCDsgPrs_ArrowSide aSymbolPrs, Standard_Real anArrowSize) : OCAIS_Relation((OCDummy^)nullptr)

{
  nativeHandle = new Handle_AIS_RadiusDimension(new AIS_RadiusDimension(*((TopoDS_Shape*)aShape->Handle), aVal, *((TCollection_ExtendedString*)aText->Handle), *((gp_Pnt*)aPosition->Handle), (DsgPrs_ArrowSide)aSymbolPrs, anArrowSize));
}

 void OCAIS_RadiusDimension::SetFirstShape(OCNaroWrappers::OCTopoDS_Shape^ aFShape)
{
  (*((Handle_AIS_RadiusDimension*)nativeHandle))->SetFirstShape(*((TopoDS_Shape*)aFShape->Handle));
}

 OCAIS_KindOfDimension OCAIS_RadiusDimension::KindOfDimension()
{
  return (OCAIS_KindOfDimension)((*((Handle_AIS_RadiusDimension*)nativeHandle))->KindOfDimension());
}

 System::Boolean OCAIS_RadiusDimension::IsMovable()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_AIS_RadiusDimension*)nativeHandle))->IsMovable());
}

 System::Boolean OCAIS_RadiusDimension::DrawFromCenter()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_AIS_RadiusDimension*)nativeHandle))->DrawFromCenter());
}

 void OCAIS_RadiusDimension::SetDrawFromCenter(System::Boolean drawfromcenter)
{
  (*((Handle_AIS_RadiusDimension*)nativeHandle))->SetDrawFromCenter(OCConverter::BooleanToStandardBoolean(drawfromcenter));
}

 void OCAIS_RadiusDimension::Compute(OCNaroWrappers::OCPrs3d_Projector^ aProjector, OCNaroWrappers::OCGeom_Transformation^ aTrsf, OCNaroWrappers::OCPrs3d_Presentation^ aPresentation)
{
  (*((Handle_AIS_RadiusDimension*)nativeHandle))->Compute(*((Handle_Prs3d_Projector*)aProjector->Handle), *((Handle_Geom_Transformation*)aTrsf->Handle), *((Handle_Prs3d_Presentation*)aPresentation->Handle));
}


