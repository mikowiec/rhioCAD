// File generated by CPPExt (CPP file)
//

#include "StepShape_GeometricallyBoundedWireframeShapeRepresentation.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepShape_GeometricallyBoundedWireframeShapeRepresentation::OCStepShape_GeometricallyBoundedWireframeShapeRepresentation(StepShape_GeometricallyBoundedWireframeShapeRepresentation* nativeHandle) : OCStepShape_ShapeRepresentation((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepShape_GeometricallyBoundedWireframeShapeRepresentation::OCStepShape_GeometricallyBoundedWireframeShapeRepresentation() : OCStepShape_ShapeRepresentation((OCDummy^)nullptr)

{
  nativeHandle = new StepShape_GeometricallyBoundedWireframeShapeRepresentation();
}

