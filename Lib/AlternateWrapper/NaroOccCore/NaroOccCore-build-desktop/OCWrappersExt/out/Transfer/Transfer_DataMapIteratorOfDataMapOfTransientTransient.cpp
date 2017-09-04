// File generated by CPPExt (CPP file)
//

#include "Transfer_DataMapIteratorOfDataMapOfTransientTransient.h"
#include "../Converter.h"
#include "../Standard/Standard_Transient.h"
#include "../TColStd/TColStd_MapTransientHasher.h"
#include "Transfer_DataMapOfTransientTransient.h"
#include "Transfer_DataMapNodeOfDataMapOfTransientTransient.h"


using namespace OCNaroWrappers;

OCTransfer_DataMapIteratorOfDataMapOfTransientTransient::OCTransfer_DataMapIteratorOfDataMapOfTransientTransient(Transfer_DataMapIteratorOfDataMapOfTransientTransient* nativeHandle) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTransfer_DataMapIteratorOfDataMapOfTransientTransient::OCTransfer_DataMapIteratorOfDataMapOfTransientTransient() : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new Transfer_DataMapIteratorOfDataMapOfTransientTransient();
}

OCTransfer_DataMapIteratorOfDataMapOfTransientTransient::OCTransfer_DataMapIteratorOfDataMapOfTransientTransient(OCNaroWrappers::OCTransfer_DataMapOfTransientTransient^ aMap) : OCTCollection_BasicMapIterator((OCDummy^)nullptr)

{
  nativeHandle = new Transfer_DataMapIteratorOfDataMapOfTransientTransient(*((Transfer_DataMapOfTransientTransient*)aMap->Handle));
}

 void OCTransfer_DataMapIteratorOfDataMapOfTransientTransient::Initialize(OCNaroWrappers::OCTransfer_DataMapOfTransientTransient^ aMap)
{
  ((Transfer_DataMapIteratorOfDataMapOfTransientTransient*)nativeHandle)->Initialize(*((Transfer_DataMapOfTransientTransient*)aMap->Handle));
}

OCStandard_Transient^ OCTransfer_DataMapIteratorOfDataMapOfTransientTransient::Key()
{
  Handle(Standard_Transient) tmp = ((Transfer_DataMapIteratorOfDataMapOfTransientTransient*)nativeHandle)->Key();
  return gcnew OCStandard_Transient(&tmp);
}

OCStandard_Transient^ OCTransfer_DataMapIteratorOfDataMapOfTransientTransient::Value()
{
  Handle(Standard_Transient) tmp = ((Transfer_DataMapIteratorOfDataMapOfTransientTransient*)nativeHandle)->Value();
  return gcnew OCStandard_Transient(&tmp);
}


