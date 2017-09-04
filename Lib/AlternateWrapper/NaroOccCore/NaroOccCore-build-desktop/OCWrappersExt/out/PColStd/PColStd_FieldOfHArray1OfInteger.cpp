// File generated by CPPExt (CPP file)
//

#include "PColStd_FieldOfHArray1OfInteger.h"
#include "../Converter.h"
#include "PColStd_VArrayNodeOfFieldOfHArray1OfInteger.h"
#include "PColStd_VArrayTNodeOfFieldOfHArray1OfInteger.h"


using namespace OCNaroWrappers;

OCPColStd_FieldOfHArray1OfInteger::OCPColStd_FieldOfHArray1OfInteger(PColStd_FieldOfHArray1OfInteger* nativeHandle) : OCDBC_BaseArray((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCPColStd_FieldOfHArray1OfInteger::OCPColStd_FieldOfHArray1OfInteger() : OCDBC_BaseArray((OCDummy^)nullptr)

{
  nativeHandle = new PColStd_FieldOfHArray1OfInteger();
}

OCPColStd_FieldOfHArray1OfInteger::OCPColStd_FieldOfHArray1OfInteger(Standard_Integer Size) : OCDBC_BaseArray((OCDummy^)nullptr)

{
  nativeHandle = new PColStd_FieldOfHArray1OfInteger(Size);
}

OCPColStd_FieldOfHArray1OfInteger::OCPColStd_FieldOfHArray1OfInteger(OCNaroWrappers::OCPColStd_FieldOfHArray1OfInteger^ Varray) : OCDBC_BaseArray((OCDummy^)nullptr)

{
  nativeHandle = new PColStd_FieldOfHArray1OfInteger(*((PColStd_FieldOfHArray1OfInteger*)Varray->Handle));
}

 void OCPColStd_FieldOfHArray1OfInteger::Resize(Standard_Integer Size)
{
  ((PColStd_FieldOfHArray1OfInteger*)nativeHandle)->Resize(Size);
}

 void OCPColStd_FieldOfHArray1OfInteger::Assign(OCNaroWrappers::OCPColStd_FieldOfHArray1OfInteger^ Other)
{
  ((PColStd_FieldOfHArray1OfInteger*)nativeHandle)->Assign(*((PColStd_FieldOfHArray1OfInteger*)Other->Handle));
}

 void OCPColStd_FieldOfHArray1OfInteger::SetValue(Standard_Integer Index, Standard_Integer Value)
{
  ((PColStd_FieldOfHArray1OfInteger*)nativeHandle)->SetValue(Index, Value);
}

 Standard_Integer OCPColStd_FieldOfHArray1OfInteger::Value(Standard_Integer Index)
{
  return ((PColStd_FieldOfHArray1OfInteger*)nativeHandle)->Value(Index);
}


