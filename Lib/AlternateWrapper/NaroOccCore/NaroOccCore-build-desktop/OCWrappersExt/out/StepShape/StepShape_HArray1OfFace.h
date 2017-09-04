// File generated by CPPExt (Transient)
//
#ifndef _StepShape_HArray1OfFace_OCWrappers_HeaderFile
#define _StepShape_HArray1OfFace_OCWrappers_HeaderFile

// include the wrapped class
#include <StepShape_HArray1OfFace.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "StepShape_Array1OfFace.h"


namespace OCNaroWrappers
{

ref class OCStepShape_Face;
ref class OCStepShape_Array1OfFace;



public ref class OCStepShape_HArray1OfFace : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCStepShape_HArray1OfFace(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepShape_HArray1OfFace(Handle(StepShape_HArray1OfFace)* nativeHandle);

// Methods PUBLIC


OCStepShape_HArray1OfFace(Standard_Integer Low, Standard_Integer Up);


OCStepShape_HArray1OfFace(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCStepShape_Face^ V);


 /*instead*/  void Init(OCNaroWrappers::OCStepShape_Face^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCStepShape_Face^ Value) ;


 /*instead*/  OCStepShape_Face^ Value(Standard_Integer Index) ;


 /*instead*/  OCStepShape_Face^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCStepShape_Array1OfFace^ Array1() ;


 /*instead*/  OCStepShape_Array1OfFace^ ChangeArray1() ;

~OCStepShape_HArray1OfFace()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
