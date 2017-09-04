// File generated by CPPExt (CPP file)
//

#include "Adaptor2d_HLine2d.h"
#include "../Converter.h"
#include "Adaptor2d_Line2d.h"
#include "Adaptor2d_Curve2d.h"


using namespace OCNaroWrappers;

OCAdaptor2d_HLine2d::OCAdaptor2d_HLine2d(Handle(Adaptor2d_HLine2d)* nativeHandle) : OCAdaptor2d_HCurve2d((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Adaptor2d_HLine2d(*nativeHandle);
}

OCAdaptor2d_HLine2d::OCAdaptor2d_HLine2d() : OCAdaptor2d_HCurve2d((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Adaptor2d_HLine2d(new Adaptor2d_HLine2d());
}

OCAdaptor2d_HLine2d::OCAdaptor2d_HLine2d(OCNaroWrappers::OCAdaptor2d_Line2d^ C) : OCAdaptor2d_HCurve2d((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Adaptor2d_HLine2d(new Adaptor2d_HLine2d(*((Adaptor2d_Line2d*)C->Handle)));
}

 void OCAdaptor2d_HLine2d::Set(OCNaroWrappers::OCAdaptor2d_Line2d^ C)
{
  (*((Handle_Adaptor2d_HLine2d*)nativeHandle))->Set(*((Adaptor2d_Line2d*)C->Handle));
}

OCAdaptor2d_Curve2d^ OCAdaptor2d_HLine2d::Curve2d()
{
  Adaptor2d_Curve2d* tmp = new Adaptor2d_Curve2d();
  *tmp = (*((Handle_Adaptor2d_HLine2d*)nativeHandle))->Curve2d();
  return gcnew OCAdaptor2d_Curve2d(tmp);
}

OCAdaptor2d_Line2d^ OCAdaptor2d_HLine2d::ChangeCurve2d()
{
  Adaptor2d_Line2d* tmp = new Adaptor2d_Line2d();
  *tmp = (*((Handle_Adaptor2d_HLine2d*)nativeHandle))->ChangeCurve2d();
  return gcnew OCAdaptor2d_Line2d(tmp);
}


