// File generated by CPPExt (CPP file)
//

#include "DBC_VArrayNodeOfVArrayOfReal.h"
#include "../Converter.h"
#include "DBC_VArrayOfReal.h"
#include "DBC_VArrayTNodeOfVArrayOfReal.h"


using namespace OCNaroWrappers;

OCDBC_VArrayNodeOfVArrayOfReal::OCDBC_VArrayNodeOfVArrayOfReal(Handle(DBC_VArrayNodeOfVArrayOfReal)* nativeHandle) : OCPStandard_ArrayNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_DBC_VArrayNodeOfVArrayOfReal(*nativeHandle);
}

OCDBC_VArrayNodeOfVArrayOfReal::OCDBC_VArrayNodeOfVArrayOfReal() : OCPStandard_ArrayNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_DBC_VArrayNodeOfVArrayOfReal(new DBC_VArrayNodeOfVArrayOfReal());
}

OCDBC_VArrayNodeOfVArrayOfReal::OCDBC_VArrayNodeOfVArrayOfReal(Standard_Real aValue) : OCPStandard_ArrayNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_DBC_VArrayNodeOfVArrayOfReal(new DBC_VArrayNodeOfVArrayOfReal(aValue));
}

 void OCDBC_VArrayNodeOfVArrayOfReal::SetValue(Standard_Real aValue)
{
  (*((Handle_DBC_VArrayNodeOfVArrayOfReal*)nativeHandle))->SetValue(aValue);
}

 Standard_Address OCDBC_VArrayNodeOfVArrayOfReal::Value()
{
  return (*((Handle_DBC_VArrayNodeOfVArrayOfReal*)nativeHandle))->Value();
}


