// File generated by CPPExt (Transient)
//
#ifndef _ChFiDS_ListNodeOfListOfStripe_OCWrappers_HeaderFile
#define _ChFiDS_ListNodeOfListOfStripe_OCWrappers_HeaderFile

// include the wrapped class
#include <ChFiDS_ListNodeOfListOfStripe.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"



namespace OCNaroWrappers
{

ref class OCChFiDS_Stripe;
ref class OCChFiDS_ListOfStripe;
ref class OCChFiDS_ListIteratorOfListOfStripe;



public ref class OCChFiDS_ListNodeOfListOfStripe : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCChFiDS_ListNodeOfListOfStripe(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCChFiDS_ListNodeOfListOfStripe(Handle(ChFiDS_ListNodeOfListOfStripe)* nativeHandle);

// Methods PUBLIC


OCChFiDS_ListNodeOfListOfStripe(OCNaroWrappers::OCChFiDS_Stripe^ I, TCollection_MapNodePtr n);


 /*instead*/  OCChFiDS_Stripe^ Value() ;

~OCChFiDS_ListNodeOfListOfStripe()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
