// File generated by CPPExt (CPP file)
//

#include "MMgt_TShared.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCMMgt_TShared::OCMMgt_TShared(Handle(MMgt_TShared)* nativeHandle) : OCStandard_Transient((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_MMgt_TShared(*nativeHandle);
}

 void OCMMgt_TShared::Delete()
{
  (*((Handle_MMgt_TShared*)nativeHandle))->Delete();
}


