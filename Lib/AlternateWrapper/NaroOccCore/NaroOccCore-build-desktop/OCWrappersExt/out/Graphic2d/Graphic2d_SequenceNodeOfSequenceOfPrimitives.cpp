// File generated by CPPExt (CPP file)
//

#include "Graphic2d_SequenceNodeOfSequenceOfPrimitives.h"
#include "../Converter.h"
#include "Graphic2d_Primitive.h"
#include "Graphic2d_SequenceOfPrimitives.h"


using namespace OCNaroWrappers;

OCGraphic2d_SequenceNodeOfSequenceOfPrimitives::OCGraphic2d_SequenceNodeOfSequenceOfPrimitives(Handle(Graphic2d_SequenceNodeOfSequenceOfPrimitives)* nativeHandle) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Graphic2d_SequenceNodeOfSequenceOfPrimitives(*nativeHandle);
}

OCGraphic2d_SequenceNodeOfSequenceOfPrimitives::OCGraphic2d_SequenceNodeOfSequenceOfPrimitives(OCNaroWrappers::OCGraphic2d_Primitive^ I, TCollection_SeqNodePtr n, TCollection_SeqNodePtr p) : OCTCollection_SeqNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic2d_SequenceNodeOfSequenceOfPrimitives(new Graphic2d_SequenceNodeOfSequenceOfPrimitives(*((Handle_Graphic2d_Primitive*)I->Handle), n, p));
}

OCGraphic2d_Primitive^ OCGraphic2d_SequenceNodeOfSequenceOfPrimitives::Value()
{
  Handle(Graphic2d_Primitive) tmp = (*((Handle_Graphic2d_SequenceNodeOfSequenceOfPrimitives*)nativeHandle))->Value();
  return gcnew OCGraphic2d_Primitive(&tmp);
}


