// File generated by CPPExt (CPP file)
//

#include "PColStd_HOfInteger.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCPColStd_HOfInteger::OCPColStd_HOfInteger(PColStd_HOfInteger* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCPColStd_HOfInteger::OCPColStd_HOfInteger() 
{
  nativeHandle = new PColStd_HOfInteger();
}

 Standard_Integer OCPColStd_HOfInteger::HashCode(Standard_Integer MyKey, Standard_Integer Upper)
{
  return ((PColStd_HOfInteger*)nativeHandle)->HashCode(MyKey, Upper);
}

 System::Boolean OCPColStd_HOfInteger::Compare(Standard_Integer One, Standard_Integer Two)
{
  return OCConverter::StandardBooleanToBoolean(((PColStd_HOfInteger*)nativeHandle)->Compare(One, Two));
}


