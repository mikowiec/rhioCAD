// File generated by CPPExt (CPP file)
//

#include "Prs3d_Presentation.h"
#include "../Converter.h"
#include "../Graphic3d/Graphic3d_Structure.h"
#include "../Graphic3d/Graphic3d_Group.h"
#include "Prs3d_Root.h"
#include "../Graphic3d/Graphic3d_StructureManager.h"
#include "../Graphic3d/Graphic3d_DataStructureManager.h"
#include "../TColStd/TColStd_Array2OfReal.h"
#include "Prs3d_ShadingAspect.h"
#include "../Geom/Geom_Transformation.h"


using namespace OCNaroWrappers;

OCPrs3d_Presentation::OCPrs3d_Presentation(Handle(Prs3d_Presentation)* nativeHandle) : OCGraphic3d_Structure((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Prs3d_Presentation(*nativeHandle);
}

OCPrs3d_Presentation::OCPrs3d_Presentation(OCNaroWrappers::OCGraphic3d_StructureManager^ aStructureManager, System::Boolean Init) : OCGraphic3d_Structure((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Prs3d_Presentation(new Prs3d_Presentation(*((Handle_Graphic3d_StructureManager*)aStructureManager->Handle), OCConverter::BooleanToStandardBoolean(Init)));
}

OCGraphic3d_Structure^ OCPrs3d_Presentation::Compute(OCNaroWrappers::OCGraphic3d_DataStructureManager^ aProjector)
{
  Handle(Graphic3d_Structure) tmp = (*((Handle_Prs3d_Presentation*)nativeHandle))->Compute(*((Handle_Graphic3d_DataStructureManager*)aProjector->Handle));
  return gcnew OCGraphic3d_Structure(&tmp);
}

OCGraphic3d_Structure^ OCPrs3d_Presentation::Compute(OCNaroWrappers::OCGraphic3d_DataStructureManager^ aProjector, OCNaroWrappers::OCTColStd_Array2OfReal^ AMatrix)
{
  Handle(Graphic3d_Structure) tmp = (*((Handle_Prs3d_Presentation*)nativeHandle))->Compute(*((Handle_Graphic3d_DataStructureManager*)aProjector->Handle), *((TColStd_Array2OfReal*)AMatrix->Handle));
  return gcnew OCGraphic3d_Structure(&tmp);
}

 void OCPrs3d_Presentation::Compute(OCNaroWrappers::OCGraphic3d_DataStructureManager^ aProjector, OCNaroWrappers::OCGraphic3d_Structure^ aStructure)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Compute(*((Handle_Graphic3d_DataStructureManager*)aProjector->Handle), *((Handle_Graphic3d_Structure*)aStructure->Handle));
}

 void OCPrs3d_Presentation::Compute(OCNaroWrappers::OCGraphic3d_DataStructureManager^ aProjector, OCNaroWrappers::OCTColStd_Array2OfReal^ AMatrix, OCNaroWrappers::OCGraphic3d_Structure^ aStructure)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Compute(*((Handle_Graphic3d_DataStructureManager*)aProjector->Handle), *((TColStd_Array2OfReal*)AMatrix->Handle), *((Handle_Graphic3d_Structure*)aStructure->Handle));
}

 void OCPrs3d_Presentation::Highlight()
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Highlight();
}

 void OCPrs3d_Presentation::Color(OCQuantity_NameOfColor aColor)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Color((Quantity_NameOfColor)aColor);
}

 void OCPrs3d_Presentation::BoundBox()
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->BoundBox();
}

 void OCPrs3d_Presentation::Display()
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Display();
}

 void OCPrs3d_Presentation::SetShadingAspect(OCNaroWrappers::OCPrs3d_ShadingAspect^ aShadingAspect)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->SetShadingAspect(*((Handle_Prs3d_ShadingAspect*)aShadingAspect->Handle));
}

 System::Boolean OCPrs3d_Presentation::IsPickable()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Prs3d_Presentation*)nativeHandle))->IsPickable());
}

 void OCPrs3d_Presentation::Transform(OCNaroWrappers::OCGeom_Transformation^ aTransformation)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Transform(*((Handle_Geom_Transformation*)aTransformation->Handle));
}

 void OCPrs3d_Presentation::Place(Quantity_Length X, Quantity_Length Y, Quantity_Length Z)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Place(X, Y, Z);
}

 void OCPrs3d_Presentation::Multiply(OCNaroWrappers::OCGeom_Transformation^ aTransformation)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Multiply(*((Handle_Geom_Transformation*)aTransformation->Handle));
}

 void OCPrs3d_Presentation::Move(Quantity_Length X, Quantity_Length Y, Quantity_Length Z)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Move(X, Y, Z);
}

OCGeom_Transformation^ OCPrs3d_Presentation::Transformation()
{
  Handle(Geom_Transformation) tmp = (*((Handle_Prs3d_Presentation*)nativeHandle))->Transformation();
  return gcnew OCGeom_Transformation(&tmp);
}

 void OCPrs3d_Presentation::Clear(System::Boolean WithDestruction)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Clear(OCConverter::BooleanToStandardBoolean(WithDestruction));
}

 void OCPrs3d_Presentation::Connect(OCNaroWrappers::OCPrs3d_Presentation^ aPresentation)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Connect(*((Handle_Prs3d_Presentation*)aPresentation->Handle));
}

 void OCPrs3d_Presentation::Remove(OCNaroWrappers::OCPrs3d_Presentation^ aPresentation)
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->Remove(*((Handle_Prs3d_Presentation*)aPresentation->Handle));
}

 void OCPrs3d_Presentation::RemoveAll()
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->RemoveAll();
}

 void OCPrs3d_Presentation::SetPickable()
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->SetPickable();
}

 void OCPrs3d_Presentation::SetUnPickable()
{
  (*((Handle_Prs3d_Presentation*)nativeHandle))->SetUnPickable();
}


