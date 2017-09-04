// File generated by CPPExt (CPP file)
//

#include "IntTools_CArray1OfInteger.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCIntTools_CArray1OfInteger::OCIntTools_CArray1OfInteger(IntTools_CArray1OfInteger* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCIntTools_CArray1OfInteger::OCIntTools_CArray1OfInteger(Standard_Integer Length) 
{
  nativeHandle = new IntTools_CArray1OfInteger(Length);
}

OCIntTools_CArray1OfInteger::OCIntTools_CArray1OfInteger(Standard_Integer Item, Standard_Integer Length) 
{
  nativeHandle = new IntTools_CArray1OfInteger(Item, Length);
}

 void OCIntTools_CArray1OfInteger::Init(Standard_Integer V)
{
  ((IntTools_CArray1OfInteger*)nativeHandle)->Init(V);
}

 void OCIntTools_CArray1OfInteger::Resize(Standard_Integer theNewLength)
{
  ((IntTools_CArray1OfInteger*)nativeHandle)->Resize(theNewLength);
}

 Standard_Integer OCIntTools_CArray1OfInteger::Length()
{
  return ((IntTools_CArray1OfInteger*)nativeHandle)->Length();
}

 void OCIntTools_CArray1OfInteger::Append(Standard_Integer Value)
{
  ((IntTools_CArray1OfInteger*)nativeHandle)->Append(Value);
}

 void OCIntTools_CArray1OfInteger::SetValue(Standard_Integer Index, Standard_Integer Value)
{
  ((IntTools_CArray1OfInteger*)nativeHandle)->SetValue(Index, Value);
}

 Standard_Integer OCIntTools_CArray1OfInteger::Value(Standard_Integer Index)
{
  return ((IntTools_CArray1OfInteger*)nativeHandle)->Value(Index);
}

 Standard_Integer OCIntTools_CArray1OfInteger::ChangeValue(Standard_Integer Index)
{
  return ((IntTools_CArray1OfInteger*)nativeHandle)->ChangeValue(Index);
}

 System::Boolean OCIntTools_CArray1OfInteger::IsEqual(OCNaroWrappers::OCIntTools_CArray1OfInteger^ Other)
{
  return OCConverter::StandardBooleanToBoolean(((IntTools_CArray1OfInteger*)nativeHandle)->IsEqual(*((IntTools_CArray1OfInteger*)Other->Handle)));
}


