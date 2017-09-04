// File generated by CPPExt (CPP file)
//

#include "AppParCurves_MultiBSpCurve.h"
#include "../Converter.h"
#include "../TColStd/TColStd_HArray1OfReal.h"
#include "../TColStd/TColStd_HArray1OfInteger.h"
#include "AppParCurves_Array1OfMultiPoint.h"
#include "../TColStd/TColStd_Array1OfReal.h"
#include "../TColStd/TColStd_Array1OfInteger.h"
#include "AppParCurves_MultiCurve.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Vec.h"
#include "../gp/gp_Vec2d.h"


using namespace OCNaroWrappers;

OCAppParCurves_MultiBSpCurve::OCAppParCurves_MultiBSpCurve(AppParCurves_MultiBSpCurve* nativeHandle) : OCAppParCurves_MultiCurve((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCAppParCurves_MultiBSpCurve::OCAppParCurves_MultiBSpCurve() : OCAppParCurves_MultiCurve((OCDummy^)nullptr)

{
  nativeHandle = new AppParCurves_MultiBSpCurve();
}

OCAppParCurves_MultiBSpCurve::OCAppParCurves_MultiBSpCurve(Standard_Integer NbPol) : OCAppParCurves_MultiCurve((OCDummy^)nullptr)

{
  nativeHandle = new AppParCurves_MultiBSpCurve(NbPol);
}

OCAppParCurves_MultiBSpCurve::OCAppParCurves_MultiBSpCurve(OCNaroWrappers::OCAppParCurves_Array1OfMultiPoint^ tabMU, OCNaroWrappers::OCTColStd_Array1OfReal^ Knots, OCNaroWrappers::OCTColStd_Array1OfInteger^ Mults) : OCAppParCurves_MultiCurve((OCDummy^)nullptr)

{
  nativeHandle = new AppParCurves_MultiBSpCurve(*((AppParCurves_Array1OfMultiPoint*)tabMU->Handle), *((TColStd_Array1OfReal*)Knots->Handle), *((TColStd_Array1OfInteger*)Mults->Handle));
}

OCAppParCurves_MultiBSpCurve::OCAppParCurves_MultiBSpCurve(OCNaroWrappers::OCAppParCurves_MultiCurve^ SC, OCNaroWrappers::OCTColStd_Array1OfReal^ Knots, OCNaroWrappers::OCTColStd_Array1OfInteger^ Mults) : OCAppParCurves_MultiCurve((OCDummy^)nullptr)

{
  nativeHandle = new AppParCurves_MultiBSpCurve(*((AppParCurves_MultiCurve*)SC->Handle), *((TColStd_Array1OfReal*)Knots->Handle), *((TColStd_Array1OfInteger*)Mults->Handle));
}

 void OCAppParCurves_MultiBSpCurve::SetKnots(OCNaroWrappers::OCTColStd_Array1OfReal^ theKnots)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->SetKnots(*((TColStd_Array1OfReal*)theKnots->Handle));
}

 void OCAppParCurves_MultiBSpCurve::SetMultiplicities(OCNaroWrappers::OCTColStd_Array1OfInteger^ theMults)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->SetMultiplicities(*((TColStd_Array1OfInteger*)theMults->Handle));
}

OCTColStd_Array1OfReal^ OCAppParCurves_MultiBSpCurve::Knots()
{
  TColStd_Array1OfReal* tmp = new TColStd_Array1OfReal(0, 0);
  *tmp = ((AppParCurves_MultiBSpCurve*)nativeHandle)->Knots();
  return gcnew OCTColStd_Array1OfReal(tmp);
}

OCTColStd_Array1OfInteger^ OCAppParCurves_MultiBSpCurve::Multiplicities()
{
  TColStd_Array1OfInteger* tmp = new TColStd_Array1OfInteger(0, 0);
  *tmp = ((AppParCurves_MultiBSpCurve*)nativeHandle)->Multiplicities();
  return gcnew OCTColStd_Array1OfInteger(tmp);
}

 Standard_Integer OCAppParCurves_MultiBSpCurve::Degree()
{
  return ((AppParCurves_MultiBSpCurve*)nativeHandle)->Degree();
}

 void OCAppParCurves_MultiBSpCurve::Value(Standard_Integer CuIndex, Standard_Real U, OCNaroWrappers::OCgp_Pnt^ Pt)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->Value(CuIndex, U, *((gp_Pnt*)Pt->Handle));
}

 void OCAppParCurves_MultiBSpCurve::Value(Standard_Integer CuIndex, Standard_Real U, OCNaroWrappers::OCgp_Pnt2d^ Pt)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->Value(CuIndex, U, *((gp_Pnt2d*)Pt->Handle));
}

 void OCAppParCurves_MultiBSpCurve::D1(Standard_Integer CuIndex, Standard_Real U, OCNaroWrappers::OCgp_Pnt^ Pt, OCNaroWrappers::OCgp_Vec^ V1)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->D1(CuIndex, U, *((gp_Pnt*)Pt->Handle), *((gp_Vec*)V1->Handle));
}

 void OCAppParCurves_MultiBSpCurve::D1(Standard_Integer CuIndex, Standard_Real U, OCNaroWrappers::OCgp_Pnt2d^ Pt, OCNaroWrappers::OCgp_Vec2d^ V1)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->D1(CuIndex, U, *((gp_Pnt2d*)Pt->Handle), *((gp_Vec2d*)V1->Handle));
}

 void OCAppParCurves_MultiBSpCurve::D2(Standard_Integer CuIndex, Standard_Real U, OCNaroWrappers::OCgp_Pnt^ Pt, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->D2(CuIndex, U, *((gp_Pnt*)Pt->Handle), *((gp_Vec*)V1->Handle), *((gp_Vec*)V2->Handle));
}

 void OCAppParCurves_MultiBSpCurve::D2(Standard_Integer CuIndex, Standard_Real U, OCNaroWrappers::OCgp_Pnt2d^ Pt, OCNaroWrappers::OCgp_Vec2d^ V1, OCNaroWrappers::OCgp_Vec2d^ V2)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->D2(CuIndex, U, *((gp_Pnt2d*)Pt->Handle), *((gp_Vec2d*)V1->Handle), *((gp_Vec2d*)V2->Handle));
}

 void OCAppParCurves_MultiBSpCurve::Dump(Standard_OStream& o)
{
  ((AppParCurves_MultiBSpCurve*)nativeHandle)->Dump(o);
}


