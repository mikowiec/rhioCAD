// File generated by CPPExt (CPP file)
//

#include "StepShape_SolidModel.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCStepShape_SolidModel::OCStepShape_SolidModel(StepShape_SolidModel* nativeHandle) : OCStepGeom_GeometricRepresentationItem((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepShape_SolidModel::OCStepShape_SolidModel() : OCStepGeom_GeometricRepresentationItem((OCDummy^)nullptr)

{
  nativeHandle = new StepShape_SolidModel();
}


