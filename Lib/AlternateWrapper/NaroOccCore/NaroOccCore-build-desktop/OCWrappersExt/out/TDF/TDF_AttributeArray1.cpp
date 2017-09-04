// File generated by CPPExt (CPP file)
//

#include "TDF_AttributeArray1.h"
#include "../Converter.h"
#include "TDF_Attribute.h"


using namespace OCNaroWrappers;

OCTDF_AttributeArray1::OCTDF_AttributeArray1(TDF_AttributeArray1* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTDF_AttributeArray1::OCTDF_AttributeArray1(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new TDF_AttributeArray1(Low, Up);
}

OCTDF_AttributeArray1::OCTDF_AttributeArray1(OCNaroWrappers::OCTDF_Attribute^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new TDF_AttributeArray1(*((Handle_TDF_Attribute*)Item->Handle), Low, Up);
}

 void OCTDF_AttributeArray1::Init(OCNaroWrappers::OCTDF_Attribute^ V)
{
  ((TDF_AttributeArray1*)nativeHandle)->Init(*((Handle_TDF_Attribute*)V->Handle));
}

 System::Boolean OCTDF_AttributeArray1::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((TDF_AttributeArray1*)nativeHandle)->IsAllocated());
}

OCTDF_AttributeArray1^ OCTDF_AttributeArray1::Assign(OCNaroWrappers::OCTDF_AttributeArray1^ Other)
{
  TDF_AttributeArray1* tmp = new TDF_AttributeArray1(0, 0);
  *tmp = ((TDF_AttributeArray1*)nativeHandle)->Assign(*((TDF_AttributeArray1*)Other->Handle));
  return gcnew OCTDF_AttributeArray1(tmp);
}

 Standard_Integer OCTDF_AttributeArray1::Length()
{
  return ((TDF_AttributeArray1*)nativeHandle)->Length();
}

 Standard_Integer OCTDF_AttributeArray1::Lower()
{
  return ((TDF_AttributeArray1*)nativeHandle)->Lower();
}

 Standard_Integer OCTDF_AttributeArray1::Upper()
{
  return ((TDF_AttributeArray1*)nativeHandle)->Upper();
}

 void OCTDF_AttributeArray1::SetValue(Standard_Integer Index, OCNaroWrappers::OCTDF_Attribute^ Value)
{
  ((TDF_AttributeArray1*)nativeHandle)->SetValue(Index, *((Handle_TDF_Attribute*)Value->Handle));
}

OCTDF_Attribute^ OCTDF_AttributeArray1::Value(Standard_Integer Index)
{
  Handle(TDF_Attribute) tmp = ((TDF_AttributeArray1*)nativeHandle)->Value(Index);
  return gcnew OCTDF_Attribute(&tmp);
}

OCTDF_Attribute^ OCTDF_AttributeArray1::ChangeValue(Standard_Integer Index)
{
  Handle(TDF_Attribute) tmp = ((TDF_AttributeArray1*)nativeHandle)->ChangeValue(Index);
  return gcnew OCTDF_Attribute(&tmp);
}


