// File generated by CPPExt (Transient)
//
#ifndef _BOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo_OCWrappers_HeaderFile
#define _BOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo_OCWrappers_HeaderFile

// include the wrapped class
#include <BOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TopoDS/TopoDS_Shape.h"
#include "BOP_ListOfFaceInfo.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCBOP_ListOfFaceInfo;
ref class OCTopTools_ShapeMapHasher;
ref class OCBOP_IndexedDataMapOfEdgeListFaceInfo;



public ref class OCBOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCBOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCBOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo(Handle(BOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo)* nativeHandle);

// Methods PUBLIC


OCBOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo(OCNaroWrappers::OCTopoDS_Shape^ K1, Standard_Integer K2, OCNaroWrappers::OCBOP_ListOfFaceInfo^ I, TCollection_MapNodePtr n1, TCollection_MapNodePtr n2);


 /*instead*/  OCTopoDS_Shape^ Key1() ;


 /*instead*/  Standard_Integer Key2() ;


 /*instead*/  TCollection_MapNodePtr& Next2() ;


 /*instead*/  OCBOP_ListOfFaceInfo^ Value() ;

~OCBOP_IndexedDataMapNodeOfIndexedDataMapOfEdgeListFaceInfo()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
