// File generated by CPPExt (Transient)
//
#ifndef _IntSurf_SequenceNodeOfSequenceOfPntOn2S_OCWrappers_HeaderFile
#define _IntSurf_SequenceNodeOfSequenceOfPntOn2S_OCWrappers_HeaderFile

// include the wrapped class
#include <IntSurf_SequenceNodeOfSequenceOfPntOn2S.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_SeqNode.h"

#include "IntSurf_PntOn2S.h"


namespace OCNaroWrappers
{

ref class OCIntSurf_PntOn2S;
ref class OCIntSurf_SequenceOfPntOn2S;



public ref class OCIntSurf_SequenceNodeOfSequenceOfPntOn2S : OCTCollection_SeqNode {

protected:
  // dummy constructor;
  OCIntSurf_SequenceNodeOfSequenceOfPntOn2S(OCDummy^) : OCTCollection_SeqNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCIntSurf_SequenceNodeOfSequenceOfPntOn2S(Handle(IntSurf_SequenceNodeOfSequenceOfPntOn2S)* nativeHandle);

// Methods PUBLIC


OCIntSurf_SequenceNodeOfSequenceOfPntOn2S(OCNaroWrappers::OCIntSurf_PntOn2S^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p);


 /*instead*/  OCIntSurf_PntOn2S^ Value() ;

~OCIntSurf_SequenceNodeOfSequenceOfPntOn2S()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif