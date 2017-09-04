// File generated by CPPExt (CPP file)
//

#include "IntTools_CArray1OfReal.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCIntTools_CArray1OfReal::OCIntTools_CArray1OfReal(IntTools_CArray1OfReal* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCIntTools_CArray1OfReal::OCIntTools_CArray1OfReal(Standard_Integer Length) 
{
  nativeHandle = new IntTools_CArray1OfReal(Length);
}

OCIntTools_CArray1OfReal::OCIntTools_CArray1OfReal(Standard_Real Item, Standard_Integer Length) 
{
  nativeHandle = new IntTools_CArray1OfReal(Item, Length);
}

 void OCIntTools_CArray1OfReal::Init(Standard_Real V)
{
  ((IntTools_CArray1OfReal*)nativeHandle)->Init(V);
}

 void OCIntTools_CArray1OfReal::Resize(Standard_Integer theNewLength)
{
  ((IntTools_CArray1OfReal*)nativeHandle)->Resize(theNewLength);
}

 Standard_Integer OCIntTools_CArray1OfReal::Length()
{
  return ((IntTools_CArray1OfReal*)nativeHandle)->Length();
}

 void OCIntTools_CArray1OfReal::Append(Standard_Real Value)
{
  ((IntTools_CArray1OfReal*)nativeHandle)->Append(Value);
}

 void OCIntTools_CArray1OfReal::SetValue(Standard_Integer Index, Standard_Real Value)
{
  ((IntTools_CArray1OfReal*)nativeHandle)->SetValue(Index, Value);
}

 Standard_Real OCIntTools_CArray1OfReal::Value(Standard_Integer Index)
{
  return ((IntTools_CArray1OfReal*)nativeHandle)->Value(Index);
}

 Standard_Real OCIntTools_CArray1OfReal::ChangeValue(Standard_Integer Index)
{
  return ((IntTools_CArray1OfReal*)nativeHandle)->ChangeValue(Index);
}

 System::Boolean OCIntTools_CArray1OfReal::IsEqual(OCNaroWrappers::OCIntTools_CArray1OfReal^ Other)
{
  return OCConverter::StandardBooleanToBoolean(((IntTools_CArray1OfReal*)nativeHandle)->IsEqual(*((IntTools_CArray1OfReal*)Other->Handle)));
}

