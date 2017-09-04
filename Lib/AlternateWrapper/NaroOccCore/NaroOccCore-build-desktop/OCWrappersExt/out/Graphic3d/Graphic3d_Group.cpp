// File generated by CPPExt (CPP file)
//

#include "Graphic3d_Group.h"
#include "../Converter.h"
#include "Graphic3d_GraphicDriver.h"
#include "../TColStd/TColStd_HArray1OfByte.h"
#include "Graphic3d_Structure.h"
#include "Graphic3d_AspectLine3d.h"
#include "Graphic3d_AspectFillArea3d.h"
#include "Graphic3d_AspectText3d.h"
#include "Graphic3d_AspectMarker3d.h"
#include "Graphic3d_Vertex.h"
#include "Graphic3d_Array1OfVertex.h"
#include "../TColStd/TColStd_Array1OfInteger.h"
#include "Graphic3d_Array1OfVertexC.h"
#include "../TCollection/TCollection_ExtendedString.h"
#include "Graphic3d_ArrayOfPrimitives.h"


using namespace OCNaroWrappers;

OCGraphic3d_Group::OCGraphic3d_Group(Handle(Graphic3d_Group)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Graphic3d_Group(*nativeHandle);
}

OCGraphic3d_Group::OCGraphic3d_Group(OCNaroWrappers::OCGraphic3d_Structure^ AStructure) : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_Group(new Graphic3d_Group(*((Handle_Graphic3d_Structure*)AStructure->Handle)));
}

 void OCGraphic3d_Group::Clear(System::Boolean theUpdateStructureMgr)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Clear(OCConverter::BooleanToStandardBoolean(theUpdateStructureMgr));
}

 void OCGraphic3d_Group::Remove()
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Remove();
}

 void OCGraphic3d_Group::SetGroupPrimitivesAspect()
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetGroupPrimitivesAspect();
}

 void OCGraphic3d_Group::SetGroupPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectLine3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetGroupPrimitivesAspect(*((Handle_Graphic3d_AspectLine3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetGroupPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectFillArea3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetGroupPrimitivesAspect(*((Handle_Graphic3d_AspectFillArea3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetGroupPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectText3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetGroupPrimitivesAspect(*((Handle_Graphic3d_AspectText3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetGroupPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectMarker3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetGroupPrimitivesAspect(*((Handle_Graphic3d_AspectMarker3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectLine3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetPrimitivesAspect(*((Handle_Graphic3d_AspectLine3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectFillArea3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetPrimitivesAspect(*((Handle_Graphic3d_AspectFillArea3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectText3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetPrimitivesAspect(*((Handle_Graphic3d_AspectText3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectMarker3d^ CTX)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetPrimitivesAspect(*((Handle_Graphic3d_AspectMarker3d*)CTX->Handle));
}

 void OCGraphic3d_Group::SetMinMaxValues(Standard_Real XMin, Standard_Real YMin, Standard_Real ZMin, Standard_Real XMax, Standard_Real YMax, Standard_Real ZMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->SetMinMaxValues(XMin, YMin, ZMin, XMax, YMax, ZMax);
}

 void OCGraphic3d_Group::Marker(OCNaroWrappers::OCGraphic3d_Vertex^ APoint, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Marker(*((Graphic3d_Vertex*)APoint->Handle), OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::MarkerSet(OCNaroWrappers::OCGraphic3d_Array1OfVertex^ ListVertex, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->MarkerSet(*((Graphic3d_Array1OfVertex*)ListVertex->Handle), OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Polygon(OCNaroWrappers::OCGraphic3d_Array1OfVertex^ ListVertex, OCGraphic3d_TypeOfPolygon AType, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Polygon(*((Graphic3d_Array1OfVertex*)ListVertex->Handle), (Graphic3d_TypeOfPolygon)AType, OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::PolygonSet(OCNaroWrappers::OCTColStd_Array1OfInteger^ Bounds, OCNaroWrappers::OCGraphic3d_Array1OfVertex^ ListVertex, OCGraphic3d_TypeOfPolygon AType, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->PolygonSet(*((TColStd_Array1OfInteger*)Bounds->Handle), *((Graphic3d_Array1OfVertex*)ListVertex->Handle), (Graphic3d_TypeOfPolygon)AType, OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Polyline(OCNaroWrappers::OCGraphic3d_Vertex^ APT1, OCNaroWrappers::OCGraphic3d_Vertex^ APT2, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Polyline(*((Graphic3d_Vertex*)APT1->Handle), *((Graphic3d_Vertex*)APT2->Handle), OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Polyline(OCNaroWrappers::OCGraphic3d_Array1OfVertex^ ListVertex, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Polyline(*((Graphic3d_Array1OfVertex*)ListVertex->Handle), OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Polyline(OCNaroWrappers::OCGraphic3d_Array1OfVertexC^ ListVertex, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Polyline(*((Graphic3d_Array1OfVertexC*)ListVertex->Handle), OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Text(System::String^ AText, OCNaroWrappers::OCGraphic3d_Vertex^ APoint, Standard_Real AHeight, Quantity_PlaneAngle AAngle, OCGraphic3d_TextPath ATp, OCGraphic3d_HorizontalTextAlignment AHta, OCGraphic3d_VerticalTextAlignment AVta, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Text(OCConverter::StringToStandardCString(AText), *((Graphic3d_Vertex*)APoint->Handle), AHeight, AAngle, (Graphic3d_TextPath)ATp, (Graphic3d_HorizontalTextAlignment)AHta, (Graphic3d_VerticalTextAlignment)AVta, OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Text(System::String^ AText, OCNaroWrappers::OCGraphic3d_Vertex^ APoint, Standard_Real AHeight, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Text(OCConverter::StringToStandardCString(AText), *((Graphic3d_Vertex*)APoint->Handle), AHeight, OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Text(OCNaroWrappers::OCTCollection_ExtendedString^ AText, OCNaroWrappers::OCGraphic3d_Vertex^ APoint, Standard_Real AHeight, Quantity_PlaneAngle AAngle, OCGraphic3d_TextPath ATp, OCGraphic3d_HorizontalTextAlignment AHta, OCGraphic3d_VerticalTextAlignment AVta, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Text(*((TCollection_ExtendedString*)AText->Handle), *((Graphic3d_Vertex*)APoint->Handle), AHeight, AAngle, (Graphic3d_TextPath)ATp, (Graphic3d_HorizontalTextAlignment)AHta, (Graphic3d_VerticalTextAlignment)AVta, OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::Text(OCNaroWrappers::OCTCollection_ExtendedString^ AText, OCNaroWrappers::OCGraphic3d_Vertex^ APoint, Standard_Real AHeight, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->Text(*((TCollection_ExtendedString*)AText->Handle), *((Graphic3d_Vertex*)APoint->Handle), AHeight, OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::AddPrimitiveArray(OCNaroWrappers::OCGraphic3d_ArrayOfPrimitives^ elem, System::Boolean EvalMinMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->AddPrimitiveArray(*((Handle_Graphic3d_ArrayOfPrimitives*)elem->Handle), OCConverter::BooleanToStandardBoolean(EvalMinMax));
}

 void OCGraphic3d_Group::RemovePrimitiveArray(Standard_Integer aRank)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->RemovePrimitiveArray(aRank);
}

 void OCGraphic3d_Group::RemovePrimitiveArrays()
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->RemovePrimitiveArrays();
}

 void OCGraphic3d_Group::UserDraw(Standard_Address AnObject, System::Boolean EvalMinMax, System::Boolean ContainsFacet)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->UserDraw(AnObject, OCConverter::BooleanToStandardBoolean(EvalMinMax), OCConverter::BooleanToStandardBoolean(ContainsFacet));
}

 Standard_Integer OCGraphic3d_Group::ArrayNumber()
{
  return (*((Handle_Graphic3d_Group*)nativeHandle))->ArrayNumber();
}

 void OCGraphic3d_Group::InitDefinedArray()
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->InitDefinedArray();
}

 void OCGraphic3d_Group::NextDefinedArray()
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->NextDefinedArray();
}

 System::Boolean OCGraphic3d_Group::MoreDefinedArray()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Graphic3d_Group*)nativeHandle))->MoreDefinedArray());
}

OCGraphic3d_ArrayOfPrimitives^ OCGraphic3d_Group::DefinedArray()
{
  Handle(Graphic3d_ArrayOfPrimitives) tmp = (*((Handle_Graphic3d_Group*)nativeHandle))->DefinedArray();
  return gcnew OCGraphic3d_ArrayOfPrimitives(&tmp);
}

 System::Boolean OCGraphic3d_Group::IsGroupPrimitivesAspectSet(OCGraphic3d_GroupAspect theAspect)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Graphic3d_Group*)nativeHandle))->IsGroupPrimitivesAspectSet((Graphic3d_GroupAspect)theAspect));
}

 void OCGraphic3d_Group::GroupPrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectLine3d^ CTXL, OCNaroWrappers::OCGraphic3d_AspectText3d^ CTXT, OCNaroWrappers::OCGraphic3d_AspectMarker3d^ CTXM, OCNaroWrappers::OCGraphic3d_AspectFillArea3d^ CTXF)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->GroupPrimitivesAspect(*((Handle_Graphic3d_AspectLine3d*)CTXL->Handle), *((Handle_Graphic3d_AspectText3d*)CTXT->Handle), *((Handle_Graphic3d_AspectMarker3d*)CTXM->Handle), *((Handle_Graphic3d_AspectFillArea3d*)CTXF->Handle));
}

 void OCGraphic3d_Group::PrimitivesAspect(OCNaroWrappers::OCGraphic3d_AspectLine3d^ CTXL, OCNaroWrappers::OCGraphic3d_AspectText3d^ CTXT, OCNaroWrappers::OCGraphic3d_AspectMarker3d^ CTXM, OCNaroWrappers::OCGraphic3d_AspectFillArea3d^ CTXF)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->PrimitivesAspect(*((Handle_Graphic3d_AspectLine3d*)CTXL->Handle), *((Handle_Graphic3d_AspectText3d*)CTXT->Handle), *((Handle_Graphic3d_AspectMarker3d*)CTXM->Handle), *((Handle_Graphic3d_AspectFillArea3d*)CTXF->Handle));
}

 System::Boolean OCGraphic3d_Group::ContainsFacet()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Graphic3d_Group*)nativeHandle))->ContainsFacet());
}

 System::Boolean OCGraphic3d_Group::IsDeleted()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Graphic3d_Group*)nativeHandle))->IsDeleted());
}

 System::Boolean OCGraphic3d_Group::IsEmpty()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Graphic3d_Group*)nativeHandle))->IsEmpty());
}

 void OCGraphic3d_Group::MinMaxValues(Standard_Real& XMin, Standard_Real& YMin, Standard_Real& ZMin, Standard_Real& XMax, Standard_Real& YMax, Standard_Real& ZMax)
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->MinMaxValues(XMin, YMin, ZMin, XMax, YMax, ZMax);
}

OCGraphic3d_Structure^ OCGraphic3d_Group::Structure()
{
  Handle(Graphic3d_Structure) tmp = (*((Handle_Graphic3d_Group*)nativeHandle))->Structure();
  return gcnew OCGraphic3d_Structure(&tmp);
}

 void OCGraphic3d_Group::BeginPrimitives()
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->BeginPrimitives();
}

 void OCGraphic3d_Group::EndPrimitives()
{
  (*((Handle_Graphic3d_Group*)nativeHandle))->EndPrimitives();
}

