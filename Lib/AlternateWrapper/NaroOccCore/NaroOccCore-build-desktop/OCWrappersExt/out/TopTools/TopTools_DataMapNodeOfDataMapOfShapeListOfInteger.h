// File generated by CPPExt (Transient)
//
#ifndef _TopTools_DataMapNodeOfDataMapOfShapeListOfInteger_OCWrappers_HeaderFile
#define _TopTools_DataMapNodeOfDataMapOfShapeListOfInteger_OCWrappers_HeaderFile

// include the wrapped class
#include <TopTools_DataMapNodeOfDataMapOfShapeListOfInteger.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TopoDS/TopoDS_Shape.h"
#include "../TColStd/TColStd_ListOfInteger.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTColStd_ListOfInteger;
ref class OCTopTools_ShapeMapHasher;
ref class OCTopTools_DataMapOfShapeListOfInteger;
ref class OCTopTools_DataMapIteratorOfDataMapOfShapeListOfInteger;



public ref class OCTopTools_DataMapNodeOfDataMapOfShapeListOfInteger : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCTopTools_DataMapNodeOfDataMapOfShapeListOfInteger(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopTools_DataMapNodeOfDataMapOfShapeListOfInteger(Handle(TopTools_DataMapNodeOfDataMapOfShapeListOfInteger)* nativeHandle);

// Methods PUBLIC


OCTopTools_DataMapNodeOfDataMapOfShapeListOfInteger(OCNaroWrappers::OCTopoDS_Shape^ K, OCNaroWrappers::OCTColStd_ListOfInteger^ I, TCollection_MapNodePtr n);


 /*instead*/  OCTopoDS_Shape^ Key() ;


 /*instead*/  OCTColStd_ListOfInteger^ Value() ;

~OCTopTools_DataMapNodeOfDataMapOfShapeListOfInteger()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
