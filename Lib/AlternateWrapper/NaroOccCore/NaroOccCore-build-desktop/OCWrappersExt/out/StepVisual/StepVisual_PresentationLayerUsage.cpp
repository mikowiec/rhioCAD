// File generated by CPPExt (CPP file)
//

#include "StepVisual_PresentationLayerUsage.h"
#include "../Converter.h"
#include "StepVisual_PresentationLayerAssignment.h"
#include "StepVisual_PresentationRepresentation.h"


using namespace OCNaroWrappers;

OCStepVisual_PresentationLayerUsage::OCStepVisual_PresentationLayerUsage(Handle(StepVisual_PresentationLayerUsage)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepVisual_PresentationLayerUsage(*nativeHandle);
}

OCStepVisual_PresentationLayerUsage::OCStepVisual_PresentationLayerUsage() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepVisual_PresentationLayerUsage(new StepVisual_PresentationLayerUsage());
}

 void OCStepVisual_PresentationLayerUsage::Init(OCNaroWrappers::OCStepVisual_PresentationLayerAssignment^ aAssignment, OCNaroWrappers::OCStepVisual_PresentationRepresentation^ aPresentation)
{
  (*((Handle_StepVisual_PresentationLayerUsage*)nativeHandle))->Init(*((Handle_StepVisual_PresentationLayerAssignment*)aAssignment->Handle), *((Handle_StepVisual_PresentationRepresentation*)aPresentation->Handle));
}

 void OCStepVisual_PresentationLayerUsage::SetAssignment(OCNaroWrappers::OCStepVisual_PresentationLayerAssignment^ aAssignment)
{
  (*((Handle_StepVisual_PresentationLayerUsage*)nativeHandle))->SetAssignment(*((Handle_StepVisual_PresentationLayerAssignment*)aAssignment->Handle));
}

OCStepVisual_PresentationLayerAssignment^ OCStepVisual_PresentationLayerUsage::Assignment()
{
  Handle(StepVisual_PresentationLayerAssignment) tmp = (*((Handle_StepVisual_PresentationLayerUsage*)nativeHandle))->Assignment();
  return gcnew OCStepVisual_PresentationLayerAssignment(&tmp);
}

 void OCStepVisual_PresentationLayerUsage::SetPresentation(OCNaroWrappers::OCStepVisual_PresentationRepresentation^ aPresentation)
{
  (*((Handle_StepVisual_PresentationLayerUsage*)nativeHandle))->SetPresentation(*((Handle_StepVisual_PresentationRepresentation*)aPresentation->Handle));
}

OCStepVisual_PresentationRepresentation^ OCStepVisual_PresentationLayerUsage::Presentation()
{
  Handle(StepVisual_PresentationRepresentation) tmp = (*((Handle_StepVisual_PresentationLayerUsage*)nativeHandle))->Presentation();
  return gcnew OCStepVisual_PresentationRepresentation(&tmp);
}

