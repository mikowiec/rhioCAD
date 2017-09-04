// File generated by CPPExt (Transient)
//
#ifndef _IFSelect_SequenceNodeOfTSeqOfSelection_OCWrappers_HeaderFile
#define _IFSelect_SequenceNodeOfTSeqOfSelection_OCWrappers_HeaderFile

// include the wrapped class
#include <IFSelect_SequenceNodeOfTSeqOfSelection.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_SeqNode.h"



namespace OCNaroWrappers
{

ref class OCIFSelect_Selection;
ref class OCIFSelect_TSeqOfSelection;



public ref class OCIFSelect_SequenceNodeOfTSeqOfSelection : OCTCollection_SeqNode {

protected:
  // dummy constructor;
  OCIFSelect_SequenceNodeOfTSeqOfSelection(OCDummy^) : OCTCollection_SeqNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCIFSelect_SequenceNodeOfTSeqOfSelection(Handle(IFSelect_SequenceNodeOfTSeqOfSelection)* nativeHandle);

// Methods PUBLIC


OCIFSelect_SequenceNodeOfTSeqOfSelection(OCNaroWrappers::OCIFSelect_Selection^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p);


 /*instead*/  OCIFSelect_Selection^ Value() ;

~OCIFSelect_SequenceNodeOfTSeqOfSelection()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
