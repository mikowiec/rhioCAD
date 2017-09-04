// File generated by CPPExt (Transient)
//
#ifndef _StepVisual_HArray1OfSurfaceStyleElementSelect_OCWrappers_HeaderFile
#define _StepVisual_HArray1OfSurfaceStyleElementSelect_OCWrappers_HeaderFile

// include the wrapped class
#include <StepVisual_HArray1OfSurfaceStyleElementSelect.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "StepVisual_Array1OfSurfaceStyleElementSelect.h"


namespace OCNaroWrappers
{

ref class OCStepVisual_SurfaceStyleElementSelect;
ref class OCStepVisual_Array1OfSurfaceStyleElementSelect;



public ref class OCStepVisual_HArray1OfSurfaceStyleElementSelect : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCStepVisual_HArray1OfSurfaceStyleElementSelect(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepVisual_HArray1OfSurfaceStyleElementSelect(Handle(StepVisual_HArray1OfSurfaceStyleElementSelect)* nativeHandle);

// Methods PUBLIC


OCStepVisual_HArray1OfSurfaceStyleElementSelect(Standard_Integer Low, Standard_Integer Up);


OCStepVisual_HArray1OfSurfaceStyleElementSelect(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCStepVisual_SurfaceStyleElementSelect^ V);


 /*instead*/  void Init(OCNaroWrappers::OCStepVisual_SurfaceStyleElementSelect^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCStepVisual_SurfaceStyleElementSelect^ Value) ;


 /*instead*/  OCStepVisual_SurfaceStyleElementSelect^ Value(Standard_Integer Index) ;


 /*instead*/  OCStepVisual_SurfaceStyleElementSelect^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCStepVisual_Array1OfSurfaceStyleElementSelect^ Array1() ;


 /*instead*/  OCStepVisual_Array1OfSurfaceStyleElementSelect^ ChangeArray1() ;

~OCStepVisual_HArray1OfSurfaceStyleElementSelect()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif