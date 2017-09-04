// File generated by CPPExt (CPP file)
//

#include "Adaptor2d_HCurve2d.h"
#include "../Converter.h"
#include "Adaptor2d_Curve2d.h"
#include "../TColStd/TColStd_Array1OfReal.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Vec2d.h"
#include "../Geom2d/Geom2d_BezierCurve.h"
#include "../Geom2d/Geom2d_BSplineCurve.h"


using namespace OCNaroWrappers;

OCAdaptor2d_HCurve2d::OCAdaptor2d_HCurve2d(Handle(Adaptor2d_HCurve2d)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Adaptor2d_HCurve2d(*nativeHandle);
}

 Standard_Real OCAdaptor2d_HCurve2d::FirstParameter()
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->FirstParameter();
}

 Standard_Real OCAdaptor2d_HCurve2d::LastParameter()
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->LastParameter();
}

 OCGeomAbs_Shape OCAdaptor2d_HCurve2d::Continuity()
{
  return (OCGeomAbs_Shape)((*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Continuity());
}

 Standard_Integer OCAdaptor2d_HCurve2d::NbIntervals(OCGeomAbs_Shape S)
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->NbIntervals((GeomAbs_Shape)S);
}

 void OCAdaptor2d_HCurve2d::Intervals(OCNaroWrappers::OCTColStd_Array1OfReal^ T, OCGeomAbs_Shape S)
{
  (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Intervals(*((TColStd_Array1OfReal*)T->Handle), (GeomAbs_Shape)S);
}

OCAdaptor2d_HCurve2d^ OCAdaptor2d_HCurve2d::Trim(Standard_Real First, Standard_Real Last, Standard_Real Tol)
{
  Handle(Adaptor2d_HCurve2d) tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Trim(First, Last, Tol);
  return gcnew OCAdaptor2d_HCurve2d(&tmp);
}

 System::Boolean OCAdaptor2d_HCurve2d::IsClosed()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->IsClosed());
}

 System::Boolean OCAdaptor2d_HCurve2d::IsPeriodic()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->IsPeriodic());
}

 Standard_Real OCAdaptor2d_HCurve2d::Period()
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Period();
}

OCgp_Pnt2d^ OCAdaptor2d_HCurve2d::Value(Standard_Real U)
{
  gp_Pnt2d* tmp = new gp_Pnt2d();
  *tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Value(U);
  return gcnew OCgp_Pnt2d(tmp);
}

 void OCAdaptor2d_HCurve2d::D0(Standard_Real U, OCNaroWrappers::OCgp_Pnt2d^ P)
{
  (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->D0(U, *((gp_Pnt2d*)P->Handle));
}

 void OCAdaptor2d_HCurve2d::D1(Standard_Real U, OCNaroWrappers::OCgp_Pnt2d^ P, OCNaroWrappers::OCgp_Vec2d^ V)
{
  (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->D1(U, *((gp_Pnt2d*)P->Handle), *((gp_Vec2d*)V->Handle));
}

 void OCAdaptor2d_HCurve2d::D2(Standard_Real U, OCNaroWrappers::OCgp_Pnt2d^ P, OCNaroWrappers::OCgp_Vec2d^ V1, OCNaroWrappers::OCgp_Vec2d^ V2)
{
  (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->D2(U, *((gp_Pnt2d*)P->Handle), *((gp_Vec2d*)V1->Handle), *((gp_Vec2d*)V2->Handle));
}

 void OCAdaptor2d_HCurve2d::D3(Standard_Real U, OCNaroWrappers::OCgp_Pnt2d^ P, OCNaroWrappers::OCgp_Vec2d^ V1, OCNaroWrappers::OCgp_Vec2d^ V2, OCNaroWrappers::OCgp_Vec2d^ V3)
{
  (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->D3(U, *((gp_Pnt2d*)P->Handle), *((gp_Vec2d*)V1->Handle), *((gp_Vec2d*)V2->Handle), *((gp_Vec2d*)V3->Handle));
}

OCgp_Vec2d^ OCAdaptor2d_HCurve2d::DN(Standard_Real U, Standard_Integer N)
{
  gp_Vec2d* tmp = new gp_Vec2d();
  *tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->DN(U, N);
  return gcnew OCgp_Vec2d(tmp);
}

 Standard_Real OCAdaptor2d_HCurve2d::Resolution(Standard_Real R3d)
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Resolution(R3d);
}

 OCGeomAbs_CurveType OCAdaptor2d_HCurve2d::GetType()
{
  return (OCGeomAbs_CurveType)((*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->GetType());
}

OCgp_Lin2d^ OCAdaptor2d_HCurve2d::Line()
{
  gp_Lin2d* tmp = new gp_Lin2d();
  *tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Line();
  return gcnew OCgp_Lin2d(tmp);
}

OCgp_Circ2d^ OCAdaptor2d_HCurve2d::Circle()
{
  gp_Circ2d* tmp = new gp_Circ2d();
  *tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Circle();
  return gcnew OCgp_Circ2d(tmp);
}

OCgp_Elips2d^ OCAdaptor2d_HCurve2d::Ellipse()
{
  gp_Elips2d* tmp = new gp_Elips2d();
  *tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Ellipse();
  return gcnew OCgp_Elips2d(tmp);
}

OCgp_Hypr2d^ OCAdaptor2d_HCurve2d::Hyperbola()
{
  gp_Hypr2d* tmp = new gp_Hypr2d();
  *tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Hyperbola();
  return gcnew OCgp_Hypr2d(tmp);
}

OCgp_Parab2d^ OCAdaptor2d_HCurve2d::Parabola()
{
  gp_Parab2d* tmp = new gp_Parab2d();
  *tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Parabola();
  return gcnew OCgp_Parab2d(tmp);
}

 Standard_Integer OCAdaptor2d_HCurve2d::Degree()
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Degree();
}

 System::Boolean OCAdaptor2d_HCurve2d::IsRational()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->IsRational());
}

 Standard_Integer OCAdaptor2d_HCurve2d::NbPoles()
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->NbPoles();
}

 Standard_Integer OCAdaptor2d_HCurve2d::NbKnots()
{
  return (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->NbKnots();
}

OCGeom2d_BezierCurve^ OCAdaptor2d_HCurve2d::Bezier()
{
  Handle(Geom2d_BezierCurve) tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->Bezier();
  return gcnew OCGeom2d_BezierCurve(&tmp);
}

OCGeom2d_BSplineCurve^ OCAdaptor2d_HCurve2d::BSpline()
{
  Handle(Geom2d_BSplineCurve) tmp = (*((Handle_Adaptor2d_HCurve2d*)nativeHandle))->BSpline();
  return gcnew OCGeom2d_BSplineCurve(&tmp);
}

