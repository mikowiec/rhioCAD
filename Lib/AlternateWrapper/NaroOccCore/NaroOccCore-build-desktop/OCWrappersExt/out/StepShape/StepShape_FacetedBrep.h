// File generated by CPPExt (MPV)
//
#ifndef _StepShape_FacetedBrep_OCWrappers_HeaderFile
#define _StepShape_FacetedBrep_OCWrappers_HeaderFile

// include native header
#include <StepShape_FacetedBrep.hxx>
#include "../Converter.h"

#include "StepShape_ManifoldSolidBrep.h"

#include "StepShape_ManifoldSolidBrep.h"


namespace OCNaroWrappers
{




public ref class OCStepShape_FacetedBrep  : public OCStepShape_ManifoldSolidBrep {

protected:
  // dummy constructor;
  OCStepShape_FacetedBrep(OCDummy^) : OCStepShape_ManifoldSolidBrep((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepShape_FacetedBrep(StepShape_FacetedBrep* nativeHandle);

// Methods PUBLIC

//! Returns a FacetedBrep <br>
OCStepShape_FacetedBrep();

~OCStepShape_FacetedBrep()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
