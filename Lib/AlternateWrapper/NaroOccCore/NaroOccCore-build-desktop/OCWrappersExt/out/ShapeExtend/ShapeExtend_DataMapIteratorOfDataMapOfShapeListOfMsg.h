// File generated by CPPExt (MPV)
//
#ifndef _ShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg_OCWrappers_HeaderFile
#define _ShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg_OCWrappers_HeaderFile

// include native header
#include <ShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCMessage_ListOfMsg;
ref class OCTopTools_ShapeMapHasher;
ref class OCShapeExtend_DataMapOfShapeListOfMsg;
ref class OCShapeExtend_DataMapNodeOfDataMapOfShapeListOfMsg;



public ref class OCShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg(ShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg* nativeHandle);

// Methods PUBLIC


OCShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg();


OCShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg(OCNaroWrappers::OCShapeExtend_DataMapOfShapeListOfMsg^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCShapeExtend_DataMapOfShapeListOfMsg^ aMap) ;


 /*instead*/  OCTopoDS_Shape^ Key() ;


 /*instead*/  OCMessage_ListOfMsg^ Value() ;

~OCShapeExtend_DataMapIteratorOfDataMapOfShapeListOfMsg()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
