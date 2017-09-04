// File generated by CPPExt (Transient)
//
#ifndef _TNaming_ListNodeOfListOfNamedShape_OCWrappers_HeaderFile
#define _TNaming_ListNodeOfListOfNamedShape_OCWrappers_HeaderFile

// include the wrapped class
#include <TNaming_ListNodeOfListOfNamedShape.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"



namespace OCNaroWrappers
{

ref class OCTNaming_NamedShape;
ref class OCTNaming_ListOfNamedShape;
ref class OCTNaming_ListIteratorOfListOfNamedShape;



public ref class OCTNaming_ListNodeOfListOfNamedShape : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCTNaming_ListNodeOfListOfNamedShape(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCTNaming_ListNodeOfListOfNamedShape(Handle(TNaming_ListNodeOfListOfNamedShape)* nativeHandle);

// Methods PUBLIC


OCTNaming_ListNodeOfListOfNamedShape(OCNaroWrappers::OCTNaming_NamedShape^ I, TCollection_MapNodePtr n);


 /*instead*/  OCTNaming_NamedShape^ Value() ;

~OCTNaming_ListNodeOfListOfNamedShape()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
