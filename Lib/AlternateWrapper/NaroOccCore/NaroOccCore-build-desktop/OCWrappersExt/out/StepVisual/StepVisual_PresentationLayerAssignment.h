// File generated by CPPExt (Transient)
//
#ifndef _StepVisual_PresentationLayerAssignment_OCWrappers_HeaderFile
#define _StepVisual_PresentationLayerAssignment_OCWrappers_HeaderFile

// include the wrapped class
#include <StepVisual_PresentationLayerAssignment.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"



namespace OCNaroWrappers
{

ref class OCTCollection_HAsciiString;
ref class OCStepVisual_HArray1OfLayeredItem;
ref class OCStepVisual_LayeredItem;



public ref class OCStepVisual_PresentationLayerAssignment : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCStepVisual_PresentationLayerAssignment(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepVisual_PresentationLayerAssignment(Handle(StepVisual_PresentationLayerAssignment)* nativeHandle);

// Methods PUBLIC

//! Returns a PresentationLayerAssignment <br>
OCStepVisual_PresentationLayerAssignment();


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, OCNaroWrappers::OCTCollection_HAsciiString^ aDescription, OCNaroWrappers::OCStepVisual_HArray1OfLayeredItem^ aAssignedItems) ;


 /*instead*/  void SetName(OCNaroWrappers::OCTCollection_HAsciiString^ aName) ;


 /*instead*/  OCTCollection_HAsciiString^ Name() ;


 /*instead*/  void SetDescription(OCNaroWrappers::OCTCollection_HAsciiString^ aDescription) ;


 /*instead*/  OCTCollection_HAsciiString^ Description() ;


 /*instead*/  void SetAssignedItems(OCNaroWrappers::OCStepVisual_HArray1OfLayeredItem^ aAssignedItems) ;


 /*instead*/  OCStepVisual_HArray1OfLayeredItem^ AssignedItems() ;


 /*instead*/  OCStepVisual_LayeredItem^ AssignedItemsValue(Standard_Integer num) ;


 /*instead*/  Standard_Integer NbAssignedItems() ;

~OCStepVisual_PresentationLayerAssignment()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
