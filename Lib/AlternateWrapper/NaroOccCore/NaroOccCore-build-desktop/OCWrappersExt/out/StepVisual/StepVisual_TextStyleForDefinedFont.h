// File generated by CPPExt (Transient)
//
#ifndef _StepVisual_TextStyleForDefinedFont_OCWrappers_HeaderFile
#define _StepVisual_TextStyleForDefinedFont_OCWrappers_HeaderFile

// include the wrapped class
#include <StepVisual_TextStyleForDefinedFont.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"



namespace OCNaroWrappers
{

ref class OCStepVisual_Colour;



public ref class OCStepVisual_TextStyleForDefinedFont : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCStepVisual_TextStyleForDefinedFont(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepVisual_TextStyleForDefinedFont(Handle(StepVisual_TextStyleForDefinedFont)* nativeHandle);

// Methods PUBLIC

//! Returns a TextStyleForDefinedFont <br>
OCStepVisual_TextStyleForDefinedFont();


virtual /*instead*/  void Init(OCNaroWrappers::OCStepVisual_Colour^ aTextColour) ;


 /*instead*/  void SetTextColour(OCNaroWrappers::OCStepVisual_Colour^ aTextColour) ;


 /*instead*/  OCStepVisual_Colour^ TextColour() ;

~OCStepVisual_TextStyleForDefinedFont()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
