// File generated by CPPExt (Transient)
//
#ifndef _BOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger_OCWrappers_HeaderFile
#define _BOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger_OCWrappers_HeaderFile

// include the wrapped class
#include <BOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"



namespace OCNaroWrappers
{

ref class OCTColStd_MapIntegerHasher;
ref class OCBOPTColStd_IndexedDataMapOfIntegerInteger;



public ref class OCBOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCBOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCBOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger(Handle(BOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger)* nativeHandle);

// Methods PUBLIC


OCBOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger(Standard_Integer K1, Standard_Integer K2, Standard_Integer I, TCollection_MapNodePtr n1, TCollection_MapNodePtr n2);


 /*instead*/  Standard_Integer Key1() ;


 /*instead*/  Standard_Integer Key2() ;


 /*instead*/  TCollection_MapNodePtr& Next2() ;


 /*instead*/  Standard_Integer Value() ;

~OCBOPTColStd_IndexedDataMapNodeOfIndexedDataMapOfIntegerInteger()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
