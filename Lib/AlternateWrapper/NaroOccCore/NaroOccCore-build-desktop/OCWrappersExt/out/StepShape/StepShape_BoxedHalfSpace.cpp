// File generated by CPPExt (CPP file)
//

#include "StepShape_BoxedHalfSpace.h"
#include "../Converter.h"
#include "StepShape_BoxDomain.h"
#include "../TCollection/TCollection_HAsciiString.h"
#include "../StepGeom/StepGeom_Surface.h"


using namespace OCNaroWrappers;

OCStepShape_BoxedHalfSpace::OCStepShape_BoxedHalfSpace(StepShape_BoxedHalfSpace* nativeHandle) : OCStepShape_HalfSpaceSolid((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCStepShape_BoxedHalfSpace::OCStepShape_BoxedHalfSpace() : OCStepShape_HalfSpaceSolid((OCDummy^)nullptr)

{
  nativeHandle = new StepShape_BoxedHalfSpace();
}

 void OCStepShape_BoxedHalfSpace::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Surface^ aBaseSurface, System::Boolean aAgreementFlag)
{
  ((StepShape_BoxedHalfSpace*)nativeHandle)->Init(*((Handle_TCollection_HAsciiString*)aName->Handle), *((StepGeom_Surface*)aBaseSurface->Handle), OCConverter::BooleanToStandardBoolean(aAgreementFlag));
}

 void OCStepShape_BoxedHalfSpace::Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepGeom_Surface^ aBaseSurface, System::Boolean aAgreementFlag, OCNaroWrappers::OCStepShape_BoxDomain^ aEnclosure)
{
  ((StepShape_BoxedHalfSpace*)nativeHandle)->Init(*((Handle_TCollection_HAsciiString*)aName->Handle), *((StepGeom_Surface*)aBaseSurface->Handle), OCConverter::BooleanToStandardBoolean(aAgreementFlag), *((Handle_StepShape_BoxDomain*)aEnclosure->Handle));
}

 void OCStepShape_BoxedHalfSpace::SetEnclosure(OCNaroWrappers::OCStepShape_BoxDomain^ aEnclosure)
{
  ((StepShape_BoxedHalfSpace*)nativeHandle)->SetEnclosure(*((Handle_StepShape_BoxDomain*)aEnclosure->Handle));
}

OCStepShape_BoxDomain^ OCStepShape_BoxedHalfSpace::Enclosure()
{
  Handle(StepShape_BoxDomain) tmp = ((StepShape_BoxedHalfSpace*)nativeHandle)->Enclosure();
  return gcnew OCStepShape_BoxDomain(&tmp);
}

