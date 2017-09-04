// File generated by CPPExt (Transient)
//
#ifndef _TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox_OCWrappers_HeaderFile
#define _TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox_OCWrappers_HeaderFile

// include the wrapped class
#include <TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TopoDS/TopoDS_Shape.h"
#include "../Bnd/Bnd_Box.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCBnd_Box;
ref class OCTopTools_OrientedShapeMapHasher;
ref class OCTopOpeBRepTool_IndexedDataMapOfShapeBox;



public ref class OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox(Handle(TopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox)* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox(OCNaroWrappers::OCTopoDS_Shape^ K1, Standard_Integer K2, OCNaroWrappers::OCBnd_Box^ I, TCollection_MapNodePtr n1, TCollection_MapNodePtr n2);


 /*instead*/  OCTopoDS_Shape^ Key1() ;


 /*instead*/  Standard_Integer Key2() ;


 /*instead*/  TCollection_MapNodePtr& Next2() ;


 /*instead*/  OCBnd_Box^ Value() ;

~OCTopOpeBRepTool_IndexedDataMapNodeOfIndexedDataMapOfShapeBox()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
