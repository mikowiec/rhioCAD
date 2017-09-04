// File generated by CPPExt (MPV)
//
#ifndef _StepAP214_Array1OfPresentedItemSelect_OCWrappers_HeaderFile
#define _StepAP214_Array1OfPresentedItemSelect_OCWrappers_HeaderFile

// include native header
#include <StepAP214_Array1OfPresentedItemSelect.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCStepAP214_PresentedItemSelect;



public ref class OCStepAP214_Array1OfPresentedItemSelect  {

protected:
  StepAP214_Array1OfPresentedItemSelect* nativeHandle;
  OCStepAP214_Array1OfPresentedItemSelect(OCDummy^) {};

public:
  property StepAP214_Array1OfPresentedItemSelect* Handle
  {
    StepAP214_Array1OfPresentedItemSelect* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCStepAP214_Array1OfPresentedItemSelect(StepAP214_Array1OfPresentedItemSelect* nativeHandle);

// Methods PUBLIC


OCStepAP214_Array1OfPresentedItemSelect(Standard_Integer Low, Standard_Integer Up);


OCStepAP214_Array1OfPresentedItemSelect(OCNaroWrappers::OCStepAP214_PresentedItemSelect^ Item, Standard_Integer Low, Standard_Integer Up);


 /*instead*/  void Init(OCNaroWrappers::OCStepAP214_PresentedItemSelect^ V) ;


 /*instead*/  System::Boolean IsAllocated() ;


 /*instead*/  OCStepAP214_Array1OfPresentedItemSelect^ Assign(OCNaroWrappers::OCStepAP214_Array1OfPresentedItemSelect^ Other) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCStepAP214_PresentedItemSelect^ Value) ;


 /*instead*/  OCStepAP214_PresentedItemSelect^ Value(Standard_Integer Index) ;


 /*instead*/  OCStepAP214_PresentedItemSelect^ ChangeValue(Standard_Integer Index) ;

~OCStepAP214_Array1OfPresentedItemSelect()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
