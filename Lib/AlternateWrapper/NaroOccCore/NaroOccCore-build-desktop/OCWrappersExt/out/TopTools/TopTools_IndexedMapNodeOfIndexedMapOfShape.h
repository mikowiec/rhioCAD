// File generated by CPPExt (Transient)
//
#ifndef _TopTools_IndexedMapNodeOfIndexedMapOfShape_OCWrappers_HeaderFile
#define _TopTools_IndexedMapNodeOfIndexedMapOfShape_OCWrappers_HeaderFile

// include the wrapped class
#include <TopTools_IndexedMapNodeOfIndexedMapOfShape.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TopoDS/TopoDS_Shape.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTopTools_ShapeMapHasher;
ref class OCTopTools_IndexedMapOfShape;



public ref class OCTopTools_IndexedMapNodeOfIndexedMapOfShape : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCTopTools_IndexedMapNodeOfIndexedMapOfShape(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopTools_IndexedMapNodeOfIndexedMapOfShape(Handle(TopTools_IndexedMapNodeOfIndexedMapOfShape)* nativeHandle);

// Methods PUBLIC


OCTopTools_IndexedMapNodeOfIndexedMapOfShape(OCNaroWrappers::OCTopoDS_Shape^ K1, Standard_Integer K2, TCollection_MapNodePtr n1, TCollection_MapNodePtr n2);


 /*instead*/  OCTopoDS_Shape^ Key1() ;


 /*instead*/  Standard_Integer Key2() ;


 /*instead*/  TCollection_MapNodePtr& Next2() ;

~OCTopTools_IndexedMapNodeOfIndexedMapOfShape()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
