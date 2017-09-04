// File generated by CPPExt (Transient)
//
#ifndef _IFSelect_Modifier_OCWrappers_HeaderFile
#define _IFSelect_Modifier_OCWrappers_HeaderFile

// include the wrapped class
#include <IFSelect_Modifier.hxx>
#include "../Converter.h"

#include "IFSelect_GeneralModifier.h"



namespace OCNaroWrappers
{

ref class OCIFSelect_ContextModif;
ref class OCInterface_InterfaceModel;
ref class OCInterface_Protocol;
ref class OCInterface_CopyTool;


//! This class gives a frame for Actions which can work globally <br>
//!           on a File once completely defined (i.e. afterwards) <br>
//! <br>
//!           Remark : if no Selection is set as criterium, the Modifier is <br>
//!           set to work and should consider all the content of the Model <br>
//!           produced. <br>
public ref class OCIFSelect_Modifier : OCIFSelect_GeneralModifier {

protected:
  // dummy constructor;
  OCIFSelect_Modifier(OCDummy^) : OCIFSelect_GeneralModifier((OCDummy^)nullptr) {};

public:

// constructor from native
OCIFSelect_Modifier(Handle(IFSelect_Modifier)* nativeHandle);

// Methods PUBLIC

//! Calls inherited Initialize, transmits to it the information <br>
//!           <maychangegraph> <br>
OCIFSelect_Modifier(System::Boolean maychangegraph);

~OCIFSelect_Modifier()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
