// File generated by CPPExt (CPP file)
//

#include "TDataStd_PatternStd.h"
#include "../Converter.h"
#include "../TNaming/TNaming_NamedShape.h"
#include "TDataStd_Real.h"
#include "TDataStd_Integer.h"
#include "../Standard/Standard_GUID.h"
#include "../TDF/TDF_Label.h"
#include "TDataStd_Array1OfTrsf.h"
#include "../TDF/TDF_Attribute.h"
#include "../TDF/TDF_RelocationTable.h"
#include "../TDF/TDF_DataSet.h"


using namespace OCNaroWrappers;

OCTDataStd_PatternStd::OCTDataStd_PatternStd(Handle(TDataStd_PatternStd)* nativeHandle) : OCTDataStd_Pattern((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TDataStd_PatternStd(*nativeHandle);
}

OCStandard_GUID^ OCTDataStd_PatternStd::GetPatternID()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = TDataStd_PatternStd::GetPatternID();
  return gcnew OCStandard_GUID(tmp);
}

OCTDataStd_PatternStd^ OCTDataStd_PatternStd::Set(OCNaroWrappers::OCTDF_Label^ label)
{
  Handle(TDataStd_PatternStd) tmp = TDataStd_PatternStd::Set(*((TDF_Label*)label->Handle));
  return gcnew OCTDataStd_PatternStd(&tmp);
}

OCTDataStd_PatternStd::OCTDataStd_PatternStd() : OCTDataStd_Pattern((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TDataStd_PatternStd(new TDataStd_PatternStd());
}

 void OCTDataStd_PatternStd::Signature(Standard_Integer signature)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Signature(signature);
}

 void OCTDataStd_PatternStd::Axis1(OCNaroWrappers::OCTNaming_NamedShape^ Axis1)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis1(*((Handle_TNaming_NamedShape*)Axis1->Handle));
}

 void OCTDataStd_PatternStd::Axis2(OCNaroWrappers::OCTNaming_NamedShape^ Axis2)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis2(*((Handle_TNaming_NamedShape*)Axis2->Handle));
}

 void OCTDataStd_PatternStd::Axis1Reversed(System::Boolean Axis1Reversed)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis1Reversed(OCConverter::BooleanToStandardBoolean(Axis1Reversed));
}

 void OCTDataStd_PatternStd::Axis2Reversed(System::Boolean Axis2Reversed)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis2Reversed(OCConverter::BooleanToStandardBoolean(Axis2Reversed));
}

 void OCTDataStd_PatternStd::Value1(OCNaroWrappers::OCTDataStd_Real^ value)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Value1(*((Handle_TDataStd_Real*)value->Handle));
}

 void OCTDataStd_PatternStd::Value2(OCNaroWrappers::OCTDataStd_Real^ value)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Value2(*((Handle_TDataStd_Real*)value->Handle));
}

 void OCTDataStd_PatternStd::NbInstances1(OCNaroWrappers::OCTDataStd_Integer^ NbInstances1)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->NbInstances1(*((Handle_TDataStd_Integer*)NbInstances1->Handle));
}

 void OCTDataStd_PatternStd::NbInstances2(OCNaroWrappers::OCTDataStd_Integer^ NbInstances2)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->NbInstances2(*((Handle_TDataStd_Integer*)NbInstances2->Handle));
}

 void OCTDataStd_PatternStd::Mirror(OCNaroWrappers::OCTNaming_NamedShape^ plane)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Mirror(*((Handle_TNaming_NamedShape*)plane->Handle));
}

 Standard_Integer OCTDataStd_PatternStd::Signature()
{
  return (*((Handle_TDataStd_PatternStd*)nativeHandle))->Signature();
}

OCTNaming_NamedShape^ OCTDataStd_PatternStd::Axis1()
{
  Handle(TNaming_NamedShape) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis1();
  return gcnew OCTNaming_NamedShape(&tmp);
}

OCTNaming_NamedShape^ OCTDataStd_PatternStd::Axis2()
{
  Handle(TNaming_NamedShape) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis2();
  return gcnew OCTNaming_NamedShape(&tmp);
}

 System::Boolean OCTDataStd_PatternStd::Axis1Reversed()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis1Reversed());
}

 System::Boolean OCTDataStd_PatternStd::Axis2Reversed()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_TDataStd_PatternStd*)nativeHandle))->Axis2Reversed());
}

OCTDataStd_Real^ OCTDataStd_PatternStd::Value1()
{
  Handle(TDataStd_Real) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->Value1();
  return gcnew OCTDataStd_Real(&tmp);
}

OCTDataStd_Real^ OCTDataStd_PatternStd::Value2()
{
  Handle(TDataStd_Real) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->Value2();
  return gcnew OCTDataStd_Real(&tmp);
}

OCTDataStd_Integer^ OCTDataStd_PatternStd::NbInstances1()
{
  Handle(TDataStd_Integer) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->NbInstances1();
  return gcnew OCTDataStd_Integer(&tmp);
}

OCTDataStd_Integer^ OCTDataStd_PatternStd::NbInstances2()
{
  Handle(TDataStd_Integer) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->NbInstances2();
  return gcnew OCTDataStd_Integer(&tmp);
}

OCTNaming_NamedShape^ OCTDataStd_PatternStd::Mirror()
{
  Handle(TNaming_NamedShape) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->Mirror();
  return gcnew OCTNaming_NamedShape(&tmp);
}

 Standard_Integer OCTDataStd_PatternStd::NbTrsfs()
{
  return (*((Handle_TDataStd_PatternStd*)nativeHandle))->NbTrsfs();
}

 void OCTDataStd_PatternStd::ComputeTrsfs(OCNaroWrappers::OCTDataStd_Array1OfTrsf^ Trsfs)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->ComputeTrsfs(*((TDataStd_Array1OfTrsf*)Trsfs->Handle));
}

OCStandard_GUID^ OCTDataStd_PatternStd::PatternID()
{
  Standard_GUID* tmp = new Standard_GUID();
  *tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->PatternID();
  return gcnew OCStandard_GUID(tmp);
}

 void OCTDataStd_PatternStd::Restore(OCNaroWrappers::OCTDF_Attribute^ With)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Restore(*((Handle_TDF_Attribute*)With->Handle));
}

OCTDF_Attribute^ OCTDataStd_PatternStd::NewEmpty()
{
  Handle(TDF_Attribute) tmp = (*((Handle_TDataStd_PatternStd*)nativeHandle))->NewEmpty();
  return gcnew OCTDF_Attribute(&tmp);
}

 void OCTDataStd_PatternStd::Paste(OCNaroWrappers::OCTDF_Attribute^ Into, OCNaroWrappers::OCTDF_RelocationTable^ RT)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->Paste(*((Handle_TDF_Attribute*)Into->Handle), *((Handle_TDF_RelocationTable*)RT->Handle));
}

 void OCTDataStd_PatternStd::References(OCNaroWrappers::OCTDF_DataSet^ aDataSet)
{
  (*((Handle_TDataStd_PatternStd*)nativeHandle))->References(*((Handle_TDF_DataSet*)aDataSet->Handle));
}

 Standard_OStream& OCTDataStd_PatternStd::Dump(Standard_OStream& anOS)
{
  return (*((Handle_TDataStd_PatternStd*)nativeHandle))->Dump(anOS);
}


