// File generated by CPPExt (CPP file)
//

#include "StepVisual_MechanicalDesignGeometricPresentationArea.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepVisual_MechanicalDesignGeometricPresentationArea::OCStepVisual_MechanicalDesignGeometricPresentationArea(Handle(StepVisual_MechanicalDesignGeometricPresentationArea)* nativeHandle) : OCStepVisual_PresentationArea((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_StepVisual_MechanicalDesignGeometricPresentationArea(*nativeHandle);
}

OCStepVisual_MechanicalDesignGeometricPresentationArea::OCStepVisual_MechanicalDesignGeometricPresentationArea() : OCStepVisual_PresentationArea((OCDummy^)nullptr)

{
  nativeHandle = new Handle_StepVisual_MechanicalDesignGeometricPresentationArea(new StepVisual_MechanicalDesignGeometricPresentationArea());
}


