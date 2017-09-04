// File generated by CPPExt (CPP file)
//

#include "MDF_SequenceNodeOfASDriverSequence.h"
#include "../Converter.h"
#include "MDF_ASDriver.h"
#include "MDF_ASDriverSequence.h"


using namespace OCNaroWrappers;

OCMDF_SequenceNodeOfASDriverSequence::OCMDF_SequenceNodeOfASDriverSequence(Handle(MDF_SequenceNodeOfASDriverSequence)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_MDF_SequenceNodeOfASDriverSequence(*nativeHandle);
}

OCMDF_SequenceNodeOfASDriverSequence::OCMDF_SequenceNodeOfASDriverSequence(OCNaroWrappers::OCMDF_ASDriver^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_MDF_SequenceNodeOfASDriverSequence(new MDF_SequenceNodeOfASDriverSequence(*((Handle_MDF_ASDriver*)I->Handle), n, p));
}

OCMDF_ASDriver^ OCMDF_SequenceNodeOfASDriverSequence::Value()
{
  Handle(MDF_ASDriver) tmp = (*((Handle_MDF_SequenceNodeOfASDriverSequence*)nativeHandle))->Value();
  return gcnew OCMDF_ASDriver(&tmp);
}


