// File generated by CPPExt (CPP file)
//

#include "GccInt_Bisec.h"
#include "../Converter.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Lin2d.h"
#include "../gp/gp_Circ2d.h"
#include "../gp/gp_Hypr2d.h"
#include "../gp/gp_Parab2d.h"
#include "../gp/gp_Elips2d.h"


using namespace OCNaroWrappers;

OCGccInt_Bisec::OCGccInt_Bisec(Handle(GccInt_Bisec)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_GccInt_Bisec(*nativeHandle);
}

OCgp_Pnt2d^ OCGccInt_Bisec::Point()
{
  gp_Pnt2d* tmp = new gp_Pnt2d();
  *tmp = (*((Handle_GccInt_Bisec*)nativeHandle))->Point();
  return gcnew OCgp_Pnt2d(tmp);
}

OCgp_Lin2d^ OCGccInt_Bisec::Line()
{
  gp_Lin2d* tmp = new gp_Lin2d();
  *tmp = (*((Handle_GccInt_Bisec*)nativeHandle))->Line();
  return gcnew OCgp_Lin2d(tmp);
}

OCgp_Circ2d^ OCGccInt_Bisec::Circle()
{
  gp_Circ2d* tmp = new gp_Circ2d();
  *tmp = (*((Handle_GccInt_Bisec*)nativeHandle))->Circle();
  return gcnew OCgp_Circ2d(tmp);
}

OCgp_Hypr2d^ OCGccInt_Bisec::Hyperbola()
{
  gp_Hypr2d* tmp = new gp_Hypr2d();
  *tmp = (*((Handle_GccInt_Bisec*)nativeHandle))->Hyperbola();
  return gcnew OCgp_Hypr2d(tmp);
}

OCgp_Parab2d^ OCGccInt_Bisec::Parabola()
{
  gp_Parab2d* tmp = new gp_Parab2d();
  *tmp = (*((Handle_GccInt_Bisec*)nativeHandle))->Parabola();
  return gcnew OCgp_Parab2d(tmp);
}

OCgp_Elips2d^ OCGccInt_Bisec::Ellipse()
{
  gp_Elips2d* tmp = new gp_Elips2d();
  *tmp = (*((Handle_GccInt_Bisec*)nativeHandle))->Ellipse();
  return gcnew OCgp_Elips2d(tmp);
}


