// File generated by CPPExt (CPP file)
//

#include "Transfer_SimpleBinderOfTransient.h"
#include "../Converter.h"
#include "../Standard/Standard_Transient.h"
#include "../Standard/Standard_Type.h"
#include "Transfer_Binder.h"


using namespace OCNaroWrappers;

OCTransfer_SimpleBinderOfTransient::OCTransfer_SimpleBinderOfTransient(Handle(Transfer_SimpleBinderOfTransient)* nativeHandle) : OCTransfer_Binder((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Transfer_SimpleBinderOfTransient(*nativeHandle);
}

OCTransfer_SimpleBinderOfTransient::OCTransfer_SimpleBinderOfTransient() : OCTransfer_Binder((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Transfer_SimpleBinderOfTransient(new Transfer_SimpleBinderOfTransient());
}

OCStandard_Type^ OCTransfer_SimpleBinderOfTransient::ResultType()
{
  Handle(Standard_Type) tmp = (*((Handle_Transfer_SimpleBinderOfTransient*)nativeHandle))->ResultType();
  return gcnew OCStandard_Type(&tmp);
}

 System::String^ OCTransfer_SimpleBinderOfTransient::ResultTypeName()
{
  return OCConverter::StandardCStringToString((*((Handle_Transfer_SimpleBinderOfTransient*)nativeHandle))->ResultTypeName());
}

 void OCTransfer_SimpleBinderOfTransient::SetResult(OCNaroWrappers::OCStandard_Transient^ res)
{
  (*((Handle_Transfer_SimpleBinderOfTransient*)nativeHandle))->SetResult(*((Handle_Standard_Transient*)res->Handle));
}

OCStandard_Transient^ OCTransfer_SimpleBinderOfTransient::Result()
{
  Handle(Standard_Transient) tmp = (*((Handle_Transfer_SimpleBinderOfTransient*)nativeHandle))->Result();
  return gcnew OCStandard_Transient(&tmp);
}

 System::Boolean OCTransfer_SimpleBinderOfTransient::GetTypedResult(OCNaroWrappers::OCTransfer_Binder^ bnd, OCNaroWrappers::OCStandard_Type^ atype, OCNaroWrappers::OCStandard_Transient^ res)
{
  return OCConverter::StandardBooleanToBoolean(Transfer_SimpleBinderOfTransient::GetTypedResult(*((Handle_Transfer_Binder*)bnd->Handle), *((Handle_Standard_Type*)atype->Handle), *((Handle_Standard_Transient*)res->Handle)));
}


