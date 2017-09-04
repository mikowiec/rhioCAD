// File generated by CPPExt (CPP file)
//

#include "TColgp_Array2OfPnt2d.h"
#include "../Converter.h"
#include "../gp/gp_Pnt2d.h"


using namespace OCNaroWrappers;

OCTColgp_Array2OfPnt2d::OCTColgp_Array2OfPnt2d(TColgp_Array2OfPnt2d* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTColgp_Array2OfPnt2d::OCTColgp_Array2OfPnt2d(Standard_Integer R1, Standard_Integer R2, Standard_Integer C1, Standard_Integer C2) 
{
  nativeHandle = new TColgp_Array2OfPnt2d(R1, R2, C1, C2);
}

OCTColgp_Array2OfPnt2d::OCTColgp_Array2OfPnt2d(OCNaroWrappers::OCgp_Pnt2d^ Item, Standard_Integer R1, Standard_Integer R2, Standard_Integer C1, Standard_Integer C2) 
{
  nativeHandle = new TColgp_Array2OfPnt2d(*((gp_Pnt2d*)Item->Handle), R1, R2, C1, C2);
}

 void OCTColgp_Array2OfPnt2d::Init(OCNaroWrappers::OCgp_Pnt2d^ V)
{
  ((TColgp_Array2OfPnt2d*)nativeHandle)->Init(*((gp_Pnt2d*)V->Handle));
}

OCTColgp_Array2OfPnt2d^ OCTColgp_Array2OfPnt2d::Assign(OCNaroWrappers::OCTColgp_Array2OfPnt2d^ Other)
{
  TColgp_Array2OfPnt2d* tmp = new TColgp_Array2OfPnt2d(0, 0, 0, 0);
  *tmp = ((TColgp_Array2OfPnt2d*)nativeHandle)->Assign(*((TColgp_Array2OfPnt2d*)Other->Handle));
  return gcnew OCTColgp_Array2OfPnt2d(tmp);
}

 Standard_Integer OCTColgp_Array2OfPnt2d::ColLength()
{
  return ((TColgp_Array2OfPnt2d*)nativeHandle)->ColLength();
}

 Standard_Integer OCTColgp_Array2OfPnt2d::RowLength()
{
  return ((TColgp_Array2OfPnt2d*)nativeHandle)->RowLength();
}

 Standard_Integer OCTColgp_Array2OfPnt2d::LowerCol()
{
  return ((TColgp_Array2OfPnt2d*)nativeHandle)->LowerCol();
}

 Standard_Integer OCTColgp_Array2OfPnt2d::LowerRow()
{
  return ((TColgp_Array2OfPnt2d*)nativeHandle)->LowerRow();
}

 Standard_Integer OCTColgp_Array2OfPnt2d::UpperCol()
{
  return ((TColgp_Array2OfPnt2d*)nativeHandle)->UpperCol();
}

 Standard_Integer OCTColgp_Array2OfPnt2d::UpperRow()
{
  return ((TColgp_Array2OfPnt2d*)nativeHandle)->UpperRow();
}

 void OCTColgp_Array2OfPnt2d::SetValue(Standard_Integer Row, Standard_Integer Col, OCNaroWrappers::OCgp_Pnt2d^ Value)
{
  ((TColgp_Array2OfPnt2d*)nativeHandle)->SetValue(Row, Col, *((gp_Pnt2d*)Value->Handle));
}

OCgp_Pnt2d^ OCTColgp_Array2OfPnt2d::Value(Standard_Integer Row, Standard_Integer Col)
{
  gp_Pnt2d* tmp = new gp_Pnt2d();
  *tmp = ((TColgp_Array2OfPnt2d*)nativeHandle)->Value(Row, Col);
  return gcnew OCgp_Pnt2d(tmp);
}

OCgp_Pnt2d^ OCTColgp_Array2OfPnt2d::ChangeValue(Standard_Integer Row, Standard_Integer Col)
{
  gp_Pnt2d* tmp = new gp_Pnt2d();
  *tmp = ((TColgp_Array2OfPnt2d*)nativeHandle)->ChangeValue(Row, Col);
  return gcnew OCgp_Pnt2d(tmp);
}

