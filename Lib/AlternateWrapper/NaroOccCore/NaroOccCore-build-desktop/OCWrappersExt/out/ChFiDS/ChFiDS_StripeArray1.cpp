// File generated by CPPExt (CPP file)
//

#include "ChFiDS_StripeArray1.h"
#include "../Converter.h"
#include "ChFiDS_Stripe.h"


using namespace OCNaroWrappers;

OCChFiDS_StripeArray1::OCChFiDS_StripeArray1(ChFiDS_StripeArray1* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCChFiDS_StripeArray1::OCChFiDS_StripeArray1(Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new ChFiDS_StripeArray1(Low, Up);
}

OCChFiDS_StripeArray1::OCChFiDS_StripeArray1(OCNaroWrappers::OCChFiDS_Stripe^ Item, Standard_Integer Low, Standard_Integer Up) 
{
  nativeHandle = new ChFiDS_StripeArray1(*((Handle_ChFiDS_Stripe*)Item->Handle), Low, Up);
}

 void OCChFiDS_StripeArray1::Init(OCNaroWrappers::OCChFiDS_Stripe^ V)
{
  ((ChFiDS_StripeArray1*)nativeHandle)->Init(*((Handle_ChFiDS_Stripe*)V->Handle));
}

 System::Boolean OCChFiDS_StripeArray1::IsAllocated()
{
  return OCConverter::StandardBooleanToBoolean(((ChFiDS_StripeArray1*)nativeHandle)->IsAllocated());
}

OCChFiDS_StripeArray1^ OCChFiDS_StripeArray1::Assign(OCNaroWrappers::OCChFiDS_StripeArray1^ Other)
{
  ChFiDS_StripeArray1* tmp = new ChFiDS_StripeArray1(0, 0);
  *tmp = ((ChFiDS_StripeArray1*)nativeHandle)->Assign(*((ChFiDS_StripeArray1*)Other->Handle));
  return gcnew OCChFiDS_StripeArray1(tmp);
}

 Standard_Integer OCChFiDS_StripeArray1::Length()
{
  return ((ChFiDS_StripeArray1*)nativeHandle)->Length();
}

 Standard_Integer OCChFiDS_StripeArray1::Lower()
{
  return ((ChFiDS_StripeArray1*)nativeHandle)->Lower();
}

 Standard_Integer OCChFiDS_StripeArray1::Upper()
{
  return ((ChFiDS_StripeArray1*)nativeHandle)->Upper();
}

 void OCChFiDS_StripeArray1::SetValue(Standard_Integer Index, OCNaroWrappers::OCChFiDS_Stripe^ Value)
{
  ((ChFiDS_StripeArray1*)nativeHandle)->SetValue(Index, *((Handle_ChFiDS_Stripe*)Value->Handle));
}

OCChFiDS_Stripe^ OCChFiDS_StripeArray1::Value(Standard_Integer Index)
{
  Handle(ChFiDS_Stripe) tmp = ((ChFiDS_StripeArray1*)nativeHandle)->Value(Index);
  return gcnew OCChFiDS_Stripe(&tmp);
}

OCChFiDS_Stripe^ OCChFiDS_StripeArray1::ChangeValue(Standard_Integer Index)
{
  Handle(ChFiDS_Stripe) tmp = ((ChFiDS_StripeArray1*)nativeHandle)->ChangeValue(Index);
  return gcnew OCChFiDS_Stripe(&tmp);
}


