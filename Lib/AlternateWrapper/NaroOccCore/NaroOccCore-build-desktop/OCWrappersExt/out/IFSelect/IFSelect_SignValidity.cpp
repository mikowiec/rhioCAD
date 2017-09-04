// File generated by CPPExt (CPP file)
//

#include "IFSelect_SignValidity.h"
#include "../Converter.h"
#include "../Standard/Standard_Transient.h"
#include "../Interface/Interface_InterfaceModel.h"


using namespace OCNaroWrappers;

OCIFSelect_SignValidity::OCIFSelect_SignValidity(Handle(IFSelect_SignValidity)* nativeHandle) : OCIFSelect_Signature((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_IFSelect_SignValidity(*nativeHandle);
}

OCIFSelect_SignValidity::OCIFSelect_SignValidity() : OCIFSelect_Signature((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IFSelect_SignValidity(new IFSelect_SignValidity());
}

 System::String^ OCIFSelect_SignValidity::CVal(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  return OCConverter::StandardCStringToString(IFSelect_SignValidity::CVal(*((Handle_Standard_Transient*)ent->Handle), *((Handle_Interface_InterfaceModel*)model->Handle)));
}

 System::String^ OCIFSelect_SignValidity::Value(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  return OCConverter::StandardCStringToString((*((Handle_IFSelect_SignValidity*)nativeHandle))->Value(*((Handle_Standard_Transient*)ent->Handle), *((Handle_Interface_InterfaceModel*)model->Handle)));
}

