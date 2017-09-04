// File generated by CPPExt (CPP file)
//

#include "gce_MakeScale2d.h"
#include "../Converter.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Trsf2d.h"


using namespace OCNaroWrappers;

OCgce_MakeScale2d::OCgce_MakeScale2d(gce_MakeScale2d* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCgce_MakeScale2d::OCgce_MakeScale2d(OCNaroWrappers::OCgp_Pnt2d^ Point, Standard_Real Scale) 
{
  nativeHandle = new gce_MakeScale2d(*((gp_Pnt2d*)Point->Handle), Scale);
}

OCgp_Trsf2d^ OCgce_MakeScale2d::Value()
{
  gp_Trsf2d* tmp = new gp_Trsf2d();
  *tmp = ((gce_MakeScale2d*)nativeHandle)->Value();
  return gcnew OCgp_Trsf2d(tmp);
}

OCgp_Trsf2d^ OCgce_MakeScale2d::Operator()
{
  gp_Trsf2d* tmp = new gp_Trsf2d();
  *tmp = ((gce_MakeScale2d*)nativeHandle)->Operator();
  return gcnew OCgp_Trsf2d(tmp);
}


