// File generated by CPPExt (Transient)
//
#ifndef _Aspect_WidthMap_OCWrappers_HeaderFile
#define _Aspect_WidthMap_OCWrappers_HeaderFile

// include the wrapped class
#include <Aspect_WidthMap.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "Aspect_SequenceOfWidthMapEntry.h"
#include "Aspect_WidthOfLine.h"


namespace OCNaroWrappers
{

ref class OCAspect_WidthMapEntry;


//! This class defines a WidthMap object. <br>
public ref class OCAspect_WidthMap : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCAspect_WidthMap(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCAspect_WidthMap(Handle(Aspect_WidthMap)* nativeHandle);

// Methods PUBLIC

//! Creates a width map. <br>
OCAspect_WidthMap();

//! Adds an entry in the Width map <me>. <br>
//!  Warning: Raises BadAccess if WidthMap size is exceeded. <br>
 /*instead*/  void AddEntry(OCNaroWrappers::OCAspect_WidthMapEntry^ AnEntry) ;

//! Search an identical line width entry in the width map <me> <br>
//! and returns the WidthMapEntry Index if exist. <br>
//! Or add a new entry and returns the computed WidthMapEntry index used. <br>
 /*instead*/  Standard_Integer AddEntry(OCAspect_WidthOfLine aStyle) ;

//! Search an identical line width entry in the width map <me> <br>
//! and returns the WidthMapEntry Index if exist. <br>
//! Or add a new entry and returns the computed WidthMapEntry index used. <br>
 /*instead*/  Standard_Integer AddEntry(Quantity_Length aStyle) ;

//! Returns the Allocated widthmap Size <br>
 /*instead*/  Standard_Integer Size() ;

//! Returns the WidthMapEntry.Index of the WidthMap <br>
//!          at rank <aWidthmapIndex> . <br>
 /*instead*/  Standard_Integer Index(Standard_Integer aWidthmapIndex) ;

//! Returns the Width map entry with the index <AnIndex>. <br>
//!  Warning: Raises BadAccess if the index less than 1 or <br>
//!	    greater than Size. <br>
 /*instead*/  OCAspect_WidthMapEntry^ Entry(Standard_Integer AnIndex) ;


 /*instead*/  void Dump() ;

~OCAspect_WidthMap()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
