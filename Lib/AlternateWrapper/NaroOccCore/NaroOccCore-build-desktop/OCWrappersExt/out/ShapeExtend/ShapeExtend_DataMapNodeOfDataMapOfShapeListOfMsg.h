// File generated by CPPExt (Transient)
//
#ifndef _ShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg_OCWrappers_HeaderFile
#define _ShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg_OCWrappers_HeaderFile

// include the wrapped class
#include <ShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "../TopoDS/TopoDS_Shape.h"
#include "../Message/Message_ListOfMsg.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCMessage_ListOfMsg;
ref class OCTopTools_ShapeMapHasher;
ref class OCShapeExtend_DataMapOfShapeListOfMsg;
ref class OCShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg;



public ref class OCShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg(Handle(ShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg)* nativeHandle);

// Methods PUBLIC


OCShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg(OCNaroWrappers::OCTopoDS_Shape^ K, OCNaroWrappers::OCMessage_ListOfMsg^ I, TCollection_MapNodePtr n);


 /*instead*/  OCTopoDS_Shape^ Key() ;


 /*instead*/  OCMessage_ListOfMsg^ Value() ;

~OCShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
