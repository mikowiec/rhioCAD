// File generated by CPPExt (CPP file)
//

#include "XSControl_SignTransferStatus.h"
#include "../Converter.h"
#include "XSControl_TransferReader.h"
#include "../Transfer/Transfer_TransientProcess.h"
#include "../Standard/Standard_Transient.h"
#include "../Interface/Interface_InterfaceModel.h"


using namespace OCNaroWrappers;

OCXSControl_SignTransferStatus::OCXSControl_SignTransferStatus(Handle(XSControl_SignTransferStatus)* nativeHandle) : OCIFSelect_Signature((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_XSControl_SignTransferStatus(*nativeHandle);
}

OCXSControl_SignTransferStatus::OCXSControl_SignTransferStatus() : OCIFSelect_Signature((OCDummy^)nullptr)

{
  nativeHandle = new Handle_XSControl_SignTransferStatus(new XSControl_SignTransferStatus());
}

OCXSControl_SignTransferStatus::OCXSControl_SignTransferStatus(OCNaroWrappers::OCXSControl_TransferReader^ TR) : OCIFSelect_Signature((OCDummy^)nullptr)

{
  nativeHandle = new Handle_XSControl_SignTransferStatus(new XSControl_SignTransferStatus(*((Handle_XSControl_TransferReader*)TR->Handle)));
}

 void OCXSControl_SignTransferStatus::SetReader(OCNaroWrappers::OCXSControl_TransferReader^ TR)
{
  (*((Handle_XSControl_SignTransferStatus*)nativeHandle))->SetReader(*((Handle_XSControl_TransferReader*)TR->Handle));
}

 void OCXSControl_SignTransferStatus::SetMap(OCNaroWrappers::OCTransfer_TransientProcess^ TP)
{
  (*((Handle_XSControl_SignTransferStatus*)nativeHandle))->SetMap(*((Handle_Transfer_TransientProcess*)TP->Handle));
}

OCTransfer_TransientProcess^ OCXSControl_SignTransferStatus::Map()
{
  Handle(Transfer_TransientProcess) tmp = (*((Handle_XSControl_SignTransferStatus*)nativeHandle))->Map();
  return gcnew OCTransfer_TransientProcess(&tmp);
}

OCXSControl_TransferReader^ OCXSControl_SignTransferStatus::Reader()
{
  Handle(XSControl_TransferReader) tmp = (*((Handle_XSControl_SignTransferStatus*)nativeHandle))->Reader();
  return gcnew OCXSControl_TransferReader(&tmp);
}

 System::String^ OCXSControl_SignTransferStatus::Value(OCNaroWrappers::OCStandard_Transient^ ent, OCNaroWrappers::OCInterface_InterfaceModel^ model)
{
  return OCConverter::StandardCStringToString((*((Handle_XSControl_SignTransferStatus*)nativeHandle))->Value(*((Handle_Standard_Transient*)ent->Handle), *((Handle_Interface_InterfaceModel*)model->Handle)));
}


