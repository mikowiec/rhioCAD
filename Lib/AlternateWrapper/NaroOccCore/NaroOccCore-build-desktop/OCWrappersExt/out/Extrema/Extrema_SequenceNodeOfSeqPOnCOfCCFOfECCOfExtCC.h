// File generated by CPPExt (Transient)
//
#ifndef _Extrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC_OCWrappers_HeaderFile
#define _Extrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC_OCWrappers_HeaderFile

// include the wrapped class
#include <Extrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_SeqNode.h"

#include "Extrema_POnCurv.h"


namespace OCNaroWrappers
{

ref class OCExtrema_POnCurv;
ref class OCExtrema_SeqPOnCOfCCFOfECCOfExtCC;



public ref class OCExtrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC : OCTCollection_SeqNode {

protected:
  // dummy constructor;
  OCExtrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC(OCDummy^) : OCTCollection_SeqNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCExtrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC(Handle(Extrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC)* nativeHandle);

// Methods PUBLIC


OCExtrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC(OCNaroWrappers::OCExtrema_POnCurv^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p);


 /*instead*/  OCExtrema_POnCurv^ Value() ;

~OCExtrema_SequenceNodeOfSeqPOnCOfCCFOfECCOfExtCC()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
