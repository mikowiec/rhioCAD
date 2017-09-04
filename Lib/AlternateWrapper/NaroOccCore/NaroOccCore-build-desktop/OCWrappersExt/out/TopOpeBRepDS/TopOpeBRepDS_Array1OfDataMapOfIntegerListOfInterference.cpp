// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference.h"
#include "../Converter.h"
#include "TopOpeBRepDS_DataMapOfIntegerListOfInterference.h"


using namespace OCNaroWrappers;

OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference(TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference(Low, Up);
}

OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference(OCNaroWrappers::OCTopOpeBRepDS_DataMapOfIntegerListOfInterference^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference(*((TopOpeBRepDS_DataMapOfIntegerListOfInterference*)Item->Handle), Low, Up);
}

 void OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::Init(OCNaroWrappers::OCTopOpeBRepDS_DataMapOfIntegerListOfInterference^ V)
{
  ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->Init(*((TopOpeBRepDS_DataMapOfIntegerListOfInterference*)V->Handle));
}

 System::Boolean OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->IsAllocated());
}

OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference^ OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::Assign(OCNaroWrappers::OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference^ Other)
{
  TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference* tmp = new TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference(0, 0);
  *tmp = ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->Assign(*((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)Other->Handle));
  return gcnew OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference(tmp);
}

 Standard_Integer OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::Length()
{
  return ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->Length();
}

 Standard_Integer OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::Lower()
{
  return ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->Lower();
}

 Standard_Integer OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::Upper()
{
  return ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->Upper();
}

 void OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::SetValue(Standard_Integer Index, OCNaroWrappers::OCTopOpeBRepDS_DataMapOfIntegerListOfInterference^ Value)
{
  ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->SetValue(Index, *((TopOpeBRepDS_DataMapOfIntegerListOfInterference*)Value->Handle));
}

OCTopOpeBRepDS_DataMapOfIntegerListOfInterference^ OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::Value(Standard_Integer Index)
{
  TopOpeBRepDS_DataMapOfIntegerListOfInterference* tmp = new TopOpeBRepDS_DataMapOfIntegerListOfInterference(0);
  *tmp = ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->Value(Index);
  return gcnew OCTopOpeBRepDS_DataMapOfIntegerListOfInterference(tmp);
}

OCTopOpeBRepDS_DataMapOfIntegerListOfInterference^ OCTopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference::ChangeValue(Standard_Integer Index)
{
  TopOpeBRepDS_DataMapOfIntegerListOfInterference* tmp = new TopOpeBRepDS_DataMapOfIntegerListOfInterference(0);
  *tmp = ((TopOpeBRepDS_Array1OfDataMapOfIntegerListOfInterference*)nativeHandle)->ChangeValue(Index);
  return gcnew OCTopOpeBRepDS_DataMapOfIntegerListOfInterference(tmp);
}


