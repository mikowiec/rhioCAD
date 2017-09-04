// File generated by CPPExt (CPP file)
//

#include "PColStd_HArray1OfPersistent.h"
#include "../Converter.h"
#include "../Standard/Standard_Persistent.h"
#include "PColStd_FieldOfHArray1OfPersistent.h"
#include "PColStd_VArrayNodeOfFieldOfHArray1OfPersistent.h"
#include "PColStd_VArrayTNodeOfFieldOfHArray1OfPersistent.h"


using namespace OCNaroWrappers;

OCPColStd_HArray1OfPersistent::OCPColStd_HArray1OfPersistent(Handle(PColStd_HArray1OfPersistent)* nativeHandle) : OCStandard_Persistent((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_PColStd_HArray1OfPersistent(*nativeHandle);
}

OCPColStd_HArray1OfPersistent::OCPColStd_HArray1OfPersistent(Standard_Integer Low, Standard_Integer Up) : OCStandard_Persistent((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PColStd_HArray1OfPersistent(new PColStd_HArray1OfPersistent(Low, Up));
}

OCPColStd_HArray1OfPersistent::OCPColStd_HArray1OfPersistent(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCStandard_Persistent^ V) : OCStandard_Persistent((OCDummy^)nullptr)

{
  nativeHandle = new Handle_PColStd_HArray1OfPersistent(new PColStd_HArray1OfPersistent(Low, Up, *((Handle_Standard_Persistent*)V->Handle)));
}

 Standard_Integer OCPColStd_HArray1OfPersistent::Length()
{
  return (*((Handle_PColStd_HArray1OfPersistent*)nativeHandle))->Length();
}

 Standard_Integer OCPColStd_HArray1OfPersistent::Lower()
{
  return (*((Handle_PColStd_HArray1OfPersistent*)nativeHandle))->Lower();
}

 void OCPColStd_HArray1OfPersistent::SetValue(Standard_Integer Index, OCNaroWrappers::OCStandard_Persistent^ Value)
{
  (*((Handle_PColStd_HArray1OfPersistent*)nativeHandle))->SetValue(Index, *((Handle_Standard_Persistent*)Value->Handle));
}

 Standard_Integer OCPColStd_HArray1OfPersistent::Upper()
{
  return (*((Handle_PColStd_HArray1OfPersistent*)nativeHandle))->Upper();
}

OCStandard_Persistent^ OCPColStd_HArray1OfPersistent::Value(Standard_Integer Index)
{
  Handle(Standard_Persistent) tmp = (*((Handle_PColStd_HArray1OfPersistent*)nativeHandle))->Value(Index);
  return gcnew OCStandard_Persistent(&tmp);
}

OCStandard_Persistent^ OCPColStd_HArray1OfPersistent::ShallowCopy()
{
  Handle(Standard_Persistent) tmp = (*((Handle_PColStd_HArray1OfPersistent*)nativeHandle))->ShallowCopy();
  return gcnew OCStandard_Persistent(&tmp);
}

 void OCPColStd_HArray1OfPersistent::ShallowDump(Standard_OStream& s)
{
  (*((Handle_PColStd_HArray1OfPersistent*)nativeHandle))->ShallowDump(s);
}


