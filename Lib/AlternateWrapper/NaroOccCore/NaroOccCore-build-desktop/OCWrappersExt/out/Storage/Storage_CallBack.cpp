// File generated by CPPExt (CPP file)
//

#include "Storage_CallBack.h"
#include "../Converter.h"
#include "../Standard/Standard_Persistent.h"
#include "Storage_Schema.h"
#include "Storage_BaseDriver.h"


using namespace OCNaroWrappers;

OCStorage_CallBack::OCStorage_CallBack(Handle(Storage_CallBack)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Storage_CallBack(*nativeHandle);
}


