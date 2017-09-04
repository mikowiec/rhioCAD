// File generated by CPPExt (CPP file)
//

#include "StepAP214_ApprovalItem.h"
#include "../Converter.h"
#include "../Standard/Standard_Transient.h"
#include "../StepRepr/StepRepr_AssemblyComponentUsageSubstitute.h"
#include "../StepBasic/StepBasic_DocumentFile.h"
#include "../StepRepr/StepRepr_MaterialDesignation.h"
#include "../StepVisual/StepVisual_MechanicalDesignGeometricPresentationRepresentation.h"
#include "../StepVisual/StepVisual_PresentationArea.h"
#include "../StepBasic/StepBasic_Product.h"
#include "../StepBasic/StepBasic_ProductDefinition.h"
#include "../StepBasic/StepBasic_ProductDefinitionFormation.h"
#include "../StepBasic/StepBasic_ProductDefinitionRelationship.h"
#include "../StepRepr/StepRepr_PropertyDefinition.h"
#include "../StepShape/StepShape_ShapeRepresentation.h"
#include "../StepBasic/StepBasic_SecurityClassification.h"


using namespace OCNaroWrappers;

OCStepAP214_ApprovalItem::OCStepAP214_ApprovalItem(StepAP214_ApprovalItem* nativeHandle) : OCStepData_SelectType((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepAP214_ApprovalItem::OCStepAP214_ApprovalItem() : OCStepData_SelectType((OCDummy^)nullptr)

{
  nativeHandle = new StepAP214_ApprovalItem();
}

 Standard_Integer OCStepAP214_ApprovalItem::CaseNum(OCNaroWrappers::OCStandard_Transient^ ent)
{
  return ((StepAP214_ApprovalItem*)nativeHandle)->CaseNum(*((Handle_Standard_Transient*)ent->Handle));
}

OCStepRepr_AssemblyComponentUsageSubstitute^ OCStepAP214_ApprovalItem::AssemblyComponentUsageSubstitute()
{
  Handle(StepRepr_AssemblyComponentUsageSubstitute) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->AssemblyComponentUsageSubstitute();
  return gcnew OCStepRepr_AssemblyComponentUsageSubstitute(&tmp);
}

OCStepBasic_DocumentFile^ OCStepAP214_ApprovalItem::DocumentFile()
{
  Handle(StepBasic_DocumentFile) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->DocumentFile();
  return gcnew OCStepBasic_DocumentFile(&tmp);
}

OCStepRepr_MaterialDesignation^ OCStepAP214_ApprovalItem::MaterialDesignation()
{
  Handle(StepRepr_MaterialDesignation) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->MaterialDesignation();
  return gcnew OCStepRepr_MaterialDesignation(&tmp);
}

OCStepVisual_MechanicalDesignGeometricPresentationRepresentation^ OCStepAP214_ApprovalItem::MechanicalDesignGeometricPresentationRepresentation()
{
  Handle(StepVisual_MechanicalDesignGeometricPresentationRepresentation) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->MechanicalDesignGeometricPresentationRepresentation();
  return gcnew OCStepVisual_MechanicalDesignGeometricPresentationRepresentation(&tmp);
}

OCStepVisual_PresentationArea^ OCStepAP214_ApprovalItem::PresentationArea()
{
  Handle(StepVisual_PresentationArea) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->PresentationArea();
  return gcnew OCStepVisual_PresentationArea(&tmp);
}

OCStepBasic_Product^ OCStepAP214_ApprovalItem::Product()
{
  Handle(StepBasic_Product) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->Product();
  return gcnew OCStepBasic_Product(&tmp);
}

OCStepBasic_ProductDefinition^ OCStepAP214_ApprovalItem::ProductDefinition()
{
  Handle(StepBasic_ProductDefinition) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->ProductDefinition();
  return gcnew OCStepBasic_ProductDefinition(&tmp);
}

OCStepBasic_ProductDefinitionFormation^ OCStepAP214_ApprovalItem::ProductDefinitionFormation()
{
  Handle(StepBasic_ProductDefinitionFormation) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->ProductDefinitionFormation();
  return gcnew OCStepBasic_ProductDefinitionFormation(&tmp);
}

OCStepBasic_ProductDefinitionRelationship^ OCStepAP214_ApprovalItem::ProductDefinitionRelationship()
{
  Handle(StepBasic_ProductDefinitionRelationship) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->ProductDefinitionRelationship();
  return gcnew OCStepBasic_ProductDefinitionRelationship(&tmp);
}

OCStepRepr_PropertyDefinition^ OCStepAP214_ApprovalItem::PropertyDefinition()
{
  Handle(StepRepr_PropertyDefinition) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->PropertyDefinition();
  return gcnew OCStepRepr_PropertyDefinition(&tmp);
}

OCStepShape_ShapeRepresentation^ OCStepAP214_ApprovalItem::ShapeRepresentation()
{
  StepShape_ShapeRepresentation* tmp = new StepShape_ShapeRepresentation();
  *tmp = ((StepAP214_ApprovalItem*)nativeHandle)->ShapeRepresentation();
  return gcnew OCStepShape_ShapeRepresentation(tmp);
}

OCStepBasic_SecurityClassification^ OCStepAP214_ApprovalItem::SecurityClassification()
{
  Handle(StepBasic_SecurityClassification) tmp = ((StepAP214_ApprovalItem*)nativeHandle)->SecurityClassification();
  return gcnew OCStepBasic_SecurityClassification(&tmp);
}


