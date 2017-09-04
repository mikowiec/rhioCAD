// File generated by CPPExt (Transient)
//
#ifndef _StepVisual_ContextDependentOverRidingStyledItem_OCWrappers_HeaderFile
#define _StepVisual_ContextDependentOverRidingStyledItem_OCWrappers_HeaderFile

// include the wrapped class
#include <StepVisual_ContextDependentOverRidingStyledItem.hxx>
#include "../Converter.h"

#include "StepVisual_OverRidingStyledItem.h"



namespace OCNaroWrappers
{

ref class OCStepVisual_HArray1OfStyleContextSelect;
ref class OCTCollection_HAsciiString;
ref class OCStepVisual_HArray1OfPresentationStyleAssignment;
ref class OCStepRepr_RepresentationItem;
ref class OCStepVisual_StyledItem;
ref class OCStepVisual_StyleContextSelect;



public ref class OCStepVisual_ContextDependentOverRidingStyledItem : OCStepVisual_OverRidingStyledItem {

protected:
  // dummy constructor;
  OCStepVisual_ContextDependentOverRidingStyledItem(OCDummy^) : OCStepVisual_OverRidingStyledItem((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepVisual_ContextDependentOverRidingStyledItem(Handle(StepVisual_ContextDependentOverRidingStyledItem)* nativeHandle);

// Methods PUBLIC

//! Returns a ContextDependentOverRidingStyledItem <br>
OCStepVisual_ContextDependentOverRidingStyledItem();


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepVisual_HArray1OfPresentationStyleAssignment^ aStyles, OCNaroWrappers::OCStepRepr_RepresentationItem^ aItem, OCNaroWrappers::OCStepVisual_StyledItem^ aOverRiddenStyle) override;


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCStepVisual_HArray1OfPresentationStyleAssignment^ aStyles, OCNaroWrappers::OCStepRepr_RepresentationItem^ aItem, OCNaroWrappers::OCStepVisual_StyledItem^ aOverRiddenStyle, OCNaroWrappers::OCStepVisual_HArray1OfStyleContextSelect^ aStyleContext) ;


 /*instead*/  void SetStyleContext(OCNaroWrappers::OCStepVisual_HArray1OfStyleContextSelect^ aStyleContext) ;


 /*instead*/  OCStepVisual_HArray1OfStyleContextSelect^ StyleContext() ;


 /*instead*/  OCStepVisual_StyleContextSelect^ StyleContextValue(Standard_Integer num) ;


 /*instead*/  Standard_Integer NbStyleContext() ;

~OCStepVisual_ContextDependentOverRidingStyledItem()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
