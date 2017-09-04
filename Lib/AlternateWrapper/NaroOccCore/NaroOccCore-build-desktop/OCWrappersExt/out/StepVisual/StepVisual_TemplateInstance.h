// File generated by CPPExt (Transient)
//
#ifndef _StepVisual_TemplateInstance_OCWrappers_HeaderFile
#define _StepVisual_TemplateInstance_OCWrappers_HeaderFile

// include the wrapped class
#include <StepVisual_TemplateInstance.hxx>
#include "../Converter.h"

#include "../StepRepr/StepRepr_MappedItem.h"



namespace OCNaroWrappers
{




public ref class OCStepVisual_TemplateInstance : OCStepRepr_MappedItem {

protected:
  // dummy constructor;
  OCStepVisual_TemplateInstance(OCDummy^) : OCStepRepr_MappedItem((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepVisual_TemplateInstance(Handle(StepVisual_TemplateInstance)* nativeHandle);

// Methods PUBLIC

//! Returns a TemplateInstance <br>
OCStepVisual_TemplateInstance();

~OCStepVisual_TemplateInstance()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
