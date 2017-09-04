// File generated by CPPExt (CPP file)
//

#include "TColStd_HSetOfTransient.h"
#include "../Converter.h"
#include "../Standard/Standard_Transient.h"
#include "TColStd_SetOfTransient.h"


using namespace OCNaroWrappers;

OCTColStd_HSetOfTransient::OCTColStd_HSetOfTransient(Handle(TColStd_HSetOfTransient)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TColStd_HSetOfTransient(*nativeHandle);
}

OCTColStd_HSetOfTransient::OCTColStd_HSetOfTransient() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TColStd_HSetOfTransient(new TColStd_HSetOfTransient());
}

 Standard_Integer OCTColStd_HSetOfTransient::Extent()
{
  return (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Extent();
}

 System::Boolean OCTColStd_HSetOfTransient::IsEmpty()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TColStd_HSetOfTransient*)nativeHandle))->IsEmpty());
}

 void OCTColStd_HSetOfTransient::Clear()
{
  (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Clear();
}

 System::Boolean OCTColStd_HSetOfTransient::Add(OCNaroWrappers::OCStandard_Transient^ T)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Add(*((Handle_Standard_Transient*)T->Handle)));
}

 System::Boolean OCTColStd_HSetOfTransient::Remove(OCNaroWrappers::OCStandard_Transient^ T)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Remove(*((Handle_Standard_Transient*)T->Handle)));
}

OCTColStd_HSetOfTransient^ OCTColStd_HSetOfTransient::Union(OCNaroWrappers::OCTColStd_HSetOfTransient^ B)
{
  Handle(TColStd_HSetOfTransient) tmp = (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Union(*((Handle_TColStd_HSetOfTransient*)B->Handle));
  return gcnew OCTColStd_HSetOfTransient(&tmp);
}

OCTColStd_HSetOfTransient^ OCTColStd_HSetOfTransient::Intersection(OCNaroWrappers::OCTColStd_HSetOfTransient^ B)
{
  Handle(TColStd_HSetOfTransient) tmp = (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Intersection(*((Handle_TColStd_HSetOfTransient*)B->Handle));
  return gcnew OCTColStd_HSetOfTransient(&tmp);
}

OCTColStd_HSetOfTransient^ OCTColStd_HSetOfTransient::Difference(OCNaroWrappers::OCTColStd_HSetOfTransient^ B)
{
  Handle(TColStd_HSetOfTransient) tmp = (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Difference(*((Handle_TColStd_HSetOfTransient*)B->Handle));
  return gcnew OCTColStd_HSetOfTransient(&tmp);
}

 System::Boolean OCTColStd_HSetOfTransient::Contains(OCNaroWrappers::OCStandard_Transient^ T)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Contains(*((Handle_Standard_Transient*)T->Handle)));
}

 System::Boolean OCTColStd_HSetOfTransient::IsASubset(OCNaroWrappers::OCTColStd_HSetOfTransient^ S)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TColStd_HSetOfTransient*)nativeHandle))->IsASubset(*((Handle_TColStd_HSetOfTransient*)S->Handle)));
}

 System::Boolean OCTColStd_HSetOfTransient::IsAProperSubset(OCNaroWrappers::OCTColStd_HSetOfTransient^ S)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TColStd_HSetOfTransient*)nativeHandle))->IsAProperSubset(*((Handle_TColStd_HSetOfTransient*)S->Handle)));
}

OCTColStd_HSetOfTransient^ OCTColStd_HSetOfTransient::ShallowCopy()
{
  Handle(TColStd_HSetOfTransient) tmp = (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->ShallowCopy();
  return gcnew OCTColStd_HSetOfTransient(&tmp);
}

OCTColStd_SetOfTransient^ OCTColStd_HSetOfTransient::Set()
{
  TColStd_SetOfTransient* tmp = new TColStd_SetOfTransient();
  *tmp = (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->Set();
  return gcnew OCTColStd_SetOfTransient(tmp);
}

OCTColStd_SetOfTransient^ OCTColStd_HSetOfTransient::ChangeSet()
{
  TColStd_SetOfTransient* tmp = new TColStd_SetOfTransient();
  *tmp = (*((Handle_TColStd_HSetOfTransient*)nativeHandle))->ChangeSet();
  return gcnew OCTColStd_SetOfTransient(tmp);
}


