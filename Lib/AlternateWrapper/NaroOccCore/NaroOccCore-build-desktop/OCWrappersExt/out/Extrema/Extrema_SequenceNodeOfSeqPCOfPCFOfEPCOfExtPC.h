// File generated by CPPExt (Transient)
//
#ifndef _Extrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC_OCWrappers_HeaderFile
#define _Extrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC_OCWrappers_HeaderFile

// include the wrapped class
#include <Extrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_SeqNode.h"

#include "Extrema_POnCurv.h"


namespace OCNaroWrappers
{

ref class OCExtrema_POnCurv;
ref class OCExtrema_SeqPCOfPCFOfEPCOfExtPC;



public ref class OCExtrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC : OCTCollection_SeqNode {

protected:
  // dummy constructor;
  OCExtrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC(OCDummy^) : OCTCollection_SeqNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCExtrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC(Handle(Extrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC)* nativeHandle);

// Methods PUBLIC


OCExtrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC(OCNaroWrappers::OCExtrema_POnCurv^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p);


 /*instead*/  OCExtrema_POnCurv^ Value() ;

~OCExtrema_SequenceNodeOfSeqPCOfPCFOfEPCOfExtPC()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
