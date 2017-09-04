// File generated by CPPExt (Transient)
//
#ifndef _TColStd_StdMapNodeOfMapOfInteger_OCWrappers_HeaderFile
#define _TColStd_StdMapNodeOfMapOfInteger_OCWrappers_HeaderFile

// include the wrapped class
#include <TColStd_StdMapNodeOfMapOfInteger.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"



namespace OCNaroWrappers
{

ref class OCTColStd_MapIntegerHasher;
ref class OCTColStd_MapOfInteger;
ref class OCTColStd_MapIteratorOfMapOfInteger;



public ref class OCTColStd_StdMapNodeOfMapOfInteger : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCTColStd_StdMapNodeOfMapOfInteger(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCTColStd_StdMapNodeOfMapOfInteger(Handle(TColStd_StdMapNodeOfMapOfInteger)* nativeHandle);

// Methods PUBLIC


OCTColStd_StdMapNodeOfMapOfInteger(Standard_Integer K, TCollection_MapNodePtr n);


 /*instead*/  Standard_Integer Key() ;

~OCTColStd_StdMapNodeOfMapOfInteger()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
