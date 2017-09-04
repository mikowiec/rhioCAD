// File generated by CPPExt (Transient)
//
#ifndef _Message_ListNodeOfListOfMsg_OCWrappers_HeaderFile
#define _Message_ListNodeOfListOfMsg_OCWrappers_HeaderFile

// include the wrapped class
#include <Message_ListNodeOfListOfMsg.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "Message_Msg.h"


namespace OCNaroWrappers
{

ref class OCMessage_Msg;
ref class OCMessage_ListOfMsg;
ref class OCMessage_ListIteratorOfListOfMsg;



public ref class OCMessage_ListNodeOfListOfMsg : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCMessage_ListNodeOfListOfMsg(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCMessage_ListNodeOfListOfMsg(Handle(Message_ListNodeOfListOfMsg)* nativeHandle);

// Methods PUBLIC


OCMessage_ListNodeOfListOfMsg(OCNaroWrappers::OCMessage_Msg^ I, TCollection_MapNodePtr n);


 /*instead*/  OCMessage_Msg^ Value() ;

~OCMessage_ListNodeOfListOfMsg()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
