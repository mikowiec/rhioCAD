// File generated by CPPExt (Transient)
//
#ifndef _StepVisual_AreaInSet_OCWrappers_HeaderFile
#define _StepVisual_AreaInSet_OCWrappers_HeaderFile

// include the wrapped class
#include <StepVisual_AreaInSet.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"



namespace OCNaroWrappers
{

ref class OCStepVisual_PresentationArea;
ref class OCStepVisual_PresentationSet;



public ref class OCStepVisual_AreaInSet : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCStepVisual_AreaInSet(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepVisual_AreaInSet(Handle(StepVisual_AreaInSet)* nativeHandle);

// Methods PUBLIC

//! Returns a AreaInSet <br>
OCStepVisual_AreaInSet();


virtual /*instead*/  void Init(OCNaroWrappers::OCStepVisual_PresentationArea^ aArea, OCNaroWrappers::OCStepVisual_PresentationSet^ aInSet) ;


 /*instead*/  void SetArea(OCNaroWrappers::OCStepVisual_PresentationArea^ aArea) ;


 /*instead*/  OCStepVisual_PresentationArea^ Area() ;


 /*instead*/  void SetInSet(OCNaroWrappers::OCStepVisual_PresentationSet^ aInSet) ;


 /*instead*/  OCStepVisual_PresentationSet^ InSet() ;

~OCStepVisual_AreaInSet()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
