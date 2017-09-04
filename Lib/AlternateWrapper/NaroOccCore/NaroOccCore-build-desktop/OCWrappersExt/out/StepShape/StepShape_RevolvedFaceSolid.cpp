// File generated by CPPExt (CPP file)
//

#include "StepShape_RevolvedFaceSolid.h"
#include "../Converter.h"
#include "../TCollection/TCollection_HAsciiString.h"
#include "StepShape_FaceSurface.h"
#include "../StepGeom/StepGeom_Axis1Placement.h"


using namespace OCNaroWrappers;

OCStepShape_RevolvedFaceSolid::OCStepShape_RevolvedFaceSolid(StepShape_RevolvedFaceSolid* nativeHandle) : OCStepShape_SweptFaceSolid((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepShape_RevolvedFaceSolid::OCStepShape_RevolvedFaceSolid() : OCStepShape_SweptFaceSolid((OCDummy^)nullptr)

{
  nativeHandle = new StepShape_RevolvedFaceSolid();
}

 void OCStepShape_RevolvedFaceSolid::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepShape_FaceSurface^ aSweptArea)
{
  ((StepShape_RevolvedFaceSolid*)nativeHandle)->Init(*((Handle_TCollection_HAsciiString*)aName->Handle), *((StepShape_FaceSurface*)aSweptArea->Handle));
}

 void OCStepShape_RevolvedFaceSolid::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepShape_FaceSurface^ aSweptArea, OCNaroWrappers::OCStepGeom_Axis1Placement^ aAxis, Standard_Real aAngle)
{
  ((StepShape_RevolvedFaceSolid*)nativeHandle)->Init(*((Handle_TCollection_HAsciiString*)aName->Handle), *((StepShape_FaceSurface*)aSweptArea->Handle), *((StepGeom_Axis1Placement*)aAxis->Handle), aAngle);
}

 void OCStepShape_RevolvedFaceSolid::SetAxis(OCNaroWrappers::OCStepGeom_Axis1Placement^ aAxis)
{
  ((StepShape_RevolvedFaceSolid*)nativeHandle)->SetAxis(*((StepGeom_Axis1Placement*)aAxis->Handle));
}

OCStepGeom_Axis1Placement^ OCStepShape_RevolvedFaceSolid::Axis()
{
  StepGeom_Axis1Placement* tmp = new StepGeom_Axis1Placement();
  *tmp = ((StepShape_RevolvedFaceSolid*)nativeHandle)->Axis();
  return gcnew OCStepGeom_Axis1Placement(tmp);
}

 void OCStepShape_RevolvedFaceSolid::SetAngle(Standard_Real aAngle)
{
  ((StepShape_RevolvedFaceSolid*)nativeHandle)->SetAngle(aAngle);
}

 Standard_Real OCStepShape_RevolvedFaceSolid::Angle()
{
  return ((StepShape_RevolvedFaceSolid*)nativeHandle)->Angle();
}


