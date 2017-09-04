// File generated by CPPExt (CPP file)
//

#include "PCDM_SequenceNodeOfSequenceOfDocument.h"
#include "../Converter.h"
#include "PCDM_Document.h"
#include "PCDM_SequenceOfDocument.h"


using namespace OCNaroWrappers;

OCPCDM_SequenceNodeOfSequenceOfDocument::OCPCDM_SequenceNodeOfSequenceOfDocument(Handle(PCDM_SequenceNodeOfSequenceOfDocument)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_PCDM_SequenceNodeOfSequenceOfDocument(*nativeHandle);
}

OCPCDM_SequenceNodeOfSequenceOfDocument::OCPCDM_SequenceNodeOfSequenceOfDocument(OCNaroWrappers::OCPCDM_Document^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PCDM_SequenceNodeOfSequenceOfDocument(new PCDM_SequenceNodeOfSequenceOfDocument(*((Handle_PCDM_Document*)I->Handle), n, p));
}

OCPCDM_Document^ OCPCDM_SequenceNodeOfSequenceOfDocument::Value()
{
  Handle(PCDM_Document) tmp = (*((Handle_PCDM_SequenceNodeOfSequenceOfDocument*)nativeHandle))->Value();
  return gcnew OCPCDM_Document(&tmp);
}

