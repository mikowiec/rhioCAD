// File generated by CPPExt (Transient)
//
#ifndef _TColStd_StdMapNodeOfMapOfAsciiString_OCWrappers_HeaderFile
#define _TColStd_StdMapNodeOfMapOfAsciiString_OCWrappers_HeaderFile

// include the wrapped class
#include <TColStd_StdMapNodeOfMapOfAsciiString.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TCollection/TCollection_AsciiString.h"


namespace OCNaroWrappers
{

ref class OCTCollection_AsciiString;
ref class OCTColStd_MapOfAsciiString;
ref class OCTColStd_MapIteratorOfMapOfAsciiString;



public ref class OCTColStd_StdMapNodeOfMapOfAsciiString : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCTColStd_StdMapNodeOfMapOfAsciiString(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCTColStd_StdMapNodeOfMapOfAsciiString(Handle(TColStd_StdMapNodeOfMapOfAsciiString)* nativeHandle);

// Methods PUBLIC


OCTColStd_StdMapNodeOfMapOfAsciiString(OCNaroWrappers::OCTCollection_AsciiString^ K, TCollection_MapNodePtr n);


 /*instead*/  OCTCollection_AsciiString^ Key() ;

~OCTColStd_StdMapNodeOfMapOfAsciiString()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif