// File generated by CPPExt (Transient)
//
#ifndef _TCollection_MapNode_OCWrappers_HeaderFile
#define _TCollection_MapNode_OCWrappers_HeaderFile

// include the wrapped class
#include <TCollection_MapNode.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"



namespace OCNaroWrappers
{




public ref class OCTCollection_MapNode : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCTCollection_MapNode(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCTCollection_MapNode(Handle(TCollection_MapNode)* nativeHandle);

// Methods PUBLIC


OCTCollection_MapNode(TCollection_MapNodePtr n);


 /*instead*/  TCollection_MapNodePtr& Next() ;

~OCTCollection_MapNode()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
