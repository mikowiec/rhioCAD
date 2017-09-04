// File generated by CPPExt (Transient)
//
#ifndef _MoniTool_Element_OCWrappers_HeaderFile
#define _MoniTool_Element_OCWrappers_HeaderFile

// include the wrapped class
#include <MoniTool_Element.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "MoniTool_AttrList.h"


namespace OCNaroWrappers
{

ref class OCStandard_Type;
ref class OCMoniTool_AttrList;


//! a Element allows to map any kind of object as a Key for a Map. <br>
//!           This works by defining, for a Hash Code, that of the real Key, <br>
//!           not of the Element which acts only as an intermediate. <br>
//!           When a Map asks for the HashCode of a Element, this one returns <br>
//!           the code it has determined at creation time <br>
public ref class OCMoniTool_Element : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCMoniTool_Element(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCMoniTool_Element(Handle(MoniTool_Element)* nativeHandle);

// Methods PUBLIC

//! Returns the HashCode which has been stored by SetHashCode <br>
//!           (remark that HashCode could be deferred then be defined by <br>
//!            sub-classes, the result is the same) <br>
 /*instead*/  Standard_Integer GetHashCode() ;

//! Returns the Type of the Value. By default, returns the <br>
//!           DynamicType of <me>, but can be redefined <br>
virtual /*instead*/  OCStandard_Type^ ValueType() ;

//! Returns the name of the Type of the Value. Default is name <br>
//!           of ValueType, unless it is for a non-handled object <br>
virtual /*instead*/  System::String^ ValueTypeName() ;

//! Returns (readonly) the Attribute List <br>
 /*instead*/  OCMoniTool_AttrList^ ListAttr() ;

//! Returns (modifiable) the Attribute List <br>
 /*instead*/  OCMoniTool_AttrList^ ChangeAttr() ;

~OCMoniTool_Element()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
