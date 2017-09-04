// File generated by CPPExt (Transient)
//
#ifndef _BRepClass3d_DataMapNodeOfMapOfInter_OCWrappers_HeaderFile
#define _BRepClass3d_DataMapNodeOfMapOfInter_OCWrappers_HeaderFile

// include the wrapped class
#include <BRepClass3d_DataMapNodeOfMapOfInter.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TopoDS/TopoDS_Shape.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTopTools_ShapeMapHasher;
ref class OCBRepClass3d_MapOfInter;
ref class OCBRepClass3d_DataMapIteratorOfMapOfInter;



public ref class OCBRepClass3d_DataMapNodeOfMapOfInter : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCBRepClass3d_DataMapNodeOfMapOfInter(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepClass3d_DataMapNodeOfMapOfInter(Handle(BRepClass3d_DataMapNodeOfMapOfInter)* nativeHandle);

// Methods PUBLIC


OCBRepClass3d_DataMapNodeOfMapOfInter(OCNaroWrappers::OCTopoDS_Shape^ K, Standard_Address I, TCollection_MapNodePtr n);


 /*instead*/  OCTopoDS_Shape^ Key() ;


 /*instead*/  Standard_Address Value() ;

~OCBRepClass3d_DataMapNodeOfMapOfInter()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
