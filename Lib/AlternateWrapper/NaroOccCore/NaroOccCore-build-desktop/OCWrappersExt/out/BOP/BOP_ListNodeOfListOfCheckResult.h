// File generated by CPPExt (Transient)
//
#ifndef _BOP_ListNodeOfListOfCheckResult_OCWrappers_HeaderFile
#define _BOP_ListNodeOfListOfCheckResult_OCWrappers_HeaderFile

// include the wrapped class
#include <BOP_ListNodeOfListOfCheckResult.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "BOP_CheckResult.h"


namespace OCNaroWrappers
{

ref class OCBOP_CheckResult;
ref class OCBOP_ListOfCheckResult;
ref class OCBOP_ListIteratorOfListOfCheckResult;



public ref class OCBOP_ListNodeOfListOfCheckResult : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCBOP_ListNodeOfListOfCheckResult(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCBOP_ListNodeOfListOfCheckResult(Handle(BOP_ListNodeOfListOfCheckResult)* nativeHandle);

// Methods PUBLIC


OCBOP_ListNodeOfListOfCheckResult(OCNaroWrappers::OCBOP_CheckResult^ I, TCollection_MapNodePtr n);


 /*instead*/  OCBOP_CheckResult^ Value() ;

~OCBOP_ListNodeOfListOfCheckResult()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
