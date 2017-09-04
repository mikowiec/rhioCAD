// File generated by CPPExt (Transient)
//
#ifndef _TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d_OCWrappers_HeaderFile
#define _TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d_OCWrappers_HeaderFile

// include the wrapped class
#include <TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TopoDS/TopoDS_Shape.h"
#include "../Bnd/Bnd_Box2d.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCBnd_Box2d;
ref class OCTopTools_OrientedShapeMapHasher;
ref class OCTopOpeBRepTool_IndexedDataMapOfShapeBox2d;



public ref class OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d(Handle(TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d)* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d(OCNaroWrappers::OCTopoDS_Shape^ K1, Standard_Integer K2, OCNaroWrappers::OCBnd_Box2d^ I, TCollection_MapNodePtr n1, TCollection_MapNodePtr n2);


 /*instead*/  OCTopoDS_Shape^ Key1() ;


 /*instead*/  Standard_Integer Key2() ;


 /*instead*/  TCollection_MapNodePtr& Next2() ;


 /*instead*/  OCBnd_Box2d^ Value() ;

~OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox2d()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
