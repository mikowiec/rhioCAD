// File generated by CPPExt (CPP file)
//

#include "IntPatch_WLine.h"
#include "../Converter.h"
#include "../IntSurf/IntSurf_LineOn2S.h"
#include "../Adaptor2d/Adaptor2d_HCurve2d.h"
#include "IntPatch_Point.h"
#include "../IntSurf/IntSurf_PntOn2S.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Pnt.h"


using namespace OCNaroWrappers;

OCIntPatch_WLine::OCIntPatch_WLine(Handle(IntPatch_WLine)* nativeHandle) : OCIntPatch_Line((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_IntPatch_WLine(*nativeHandle);
}

OCIntPatch_WLine::OCIntPatch_WLine(OCNaroWrappers::OCIntSurf_LineOn2S^ Line, System::Boolean Tang, OCIntSurf_TypeTrans Trans1, OCIntSurf_TypeTrans Trans2) : OCIntPatch_Line((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IntPatch_WLine(new IntPatch_WLine(*((Handle_IntSurf_LineOn2S*)Line->Handle), OCConverter::BooleanToStandardBoolean(Tang), (IntSurf_TypeTrans)Trans1, (IntSurf_TypeTrans)Trans2));
}

OCIntPatch_WLine::OCIntPatch_WLine(OCNaroWrappers::OCIntSurf_LineOn2S^ Line, System::Boolean Tang, OCIntSurf_Situation Situ1, OCIntSurf_Situation Situ2) : OCIntPatch_Line((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IntPatch_WLine(new IntPatch_WLine(*((Handle_IntSurf_LineOn2S*)Line->Handle), OCConverter::BooleanToStandardBoolean(Tang), (IntSurf_Situation)Situ1, (IntSurf_Situation)Situ2));
}

OCIntPatch_WLine::OCIntPatch_WLine(OCNaroWrappers::OCIntSurf_LineOn2S^ Line, System::Boolean Tang) : OCIntPatch_Line((OCDummy^)nullptr)

{
  nativeHandle = new Handle_IntPatch_WLine(new IntPatch_WLine(*((Handle_IntSurf_LineOn2S*)Line->Handle), OCConverter::BooleanToStandardBoolean(Tang)));
}

 void OCIntPatch_WLine::AddVertex(OCNaroWrappers::OCIntPatch_Point^ Pnt)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->AddVertex(*((IntPatch_Point*)Pnt->Handle));
}

 void OCIntPatch_WLine::SetPoint(Standard_Integer Index, OCNaroWrappers::OCIntPatch_Point^ Pnt)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->SetPoint(Index, *((IntPatch_Point*)Pnt->Handle));
}

 void OCIntPatch_WLine::Replace(Standard_Integer Index, OCNaroWrappers::OCIntPatch_Point^ Pnt)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->Replace(Index, *((IntPatch_Point*)Pnt->Handle));
}

 void OCIntPatch_WLine::SetFirstPoint(Standard_Integer IndFirst)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->SetFirstPoint(IndFirst);
}

 void OCIntPatch_WLine::SetLastPoint(Standard_Integer IndLast)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->SetLastPoint(IndLast);
}

 Standard_Integer OCIntPatch_WLine::NbPnts()
{
  return (*((Handle_IntPatch_WLine*)nativeHandle))->NbPnts();
}

OCIntSurf_PntOn2S^ OCIntPatch_WLine::Point(Standard_Integer Index)
{
  IntSurf_PntOn2S* tmp = new IntSurf_PntOn2S();
  *tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->Point(Index);
  return gcnew OCIntSurf_PntOn2S(tmp);
}

 System::Boolean OCIntPatch_WLine::HasFirstPoint()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IntPatch_WLine*)nativeHandle))->HasFirstPoint());
}

 System::Boolean OCIntPatch_WLine::HasLastPoint()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IntPatch_WLine*)nativeHandle))->HasLastPoint());
}

OCIntPatch_Point^ OCIntPatch_WLine::FirstPoint()
{
  IntPatch_Point* tmp = new IntPatch_Point();
  *tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->FirstPoint();
  return gcnew OCIntPatch_Point(tmp);
}

OCIntPatch_Point^ OCIntPatch_WLine::LastPoint()
{
  IntPatch_Point* tmp = new IntPatch_Point();
  *tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->LastPoint();
  return gcnew OCIntPatch_Point(tmp);
}

OCIntPatch_Point^ OCIntPatch_WLine::FirstPoint(Standard_Integer& Indfirst)
{
  IntPatch_Point* tmp = new IntPatch_Point();
  *tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->FirstPoint(Indfirst);
  return gcnew OCIntPatch_Point(tmp);
}

OCIntPatch_Point^ OCIntPatch_WLine::LastPoint(Standard_Integer& Indlast)
{
  IntPatch_Point* tmp = new IntPatch_Point();
  *tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->LastPoint(Indlast);
  return gcnew OCIntPatch_Point(tmp);
}

 Standard_Integer OCIntPatch_WLine::NbVertex()
{
  return (*((Handle_IntPatch_WLine*)nativeHandle))->NbVertex();
}

OCIntPatch_Point^ OCIntPatch_WLine::Vertex(Standard_Integer Index)
{
  IntPatch_Point* tmp = new IntPatch_Point();
  *tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->Vertex(Index);
  return gcnew OCIntPatch_Point(tmp);
}

 void OCIntPatch_WLine::ComputeVertexParameters(Standard_Real Tol)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->ComputeVertexParameters(Tol);
}

OCIntSurf_LineOn2S^ OCIntPatch_WLine::Curve()
{
  Handle(IntSurf_LineOn2S) tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->Curve();
  return gcnew OCIntSurf_LineOn2S(&tmp);
}

 System::Boolean OCIntPatch_WLine::IsOutSurf1Box(OCNaroWrappers::OCgp_Pnt2d^ P1)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IntPatch_WLine*)nativeHandle))->IsOutSurf1Box(*((gp_Pnt2d*)P1->Handle)));
}

 System::Boolean OCIntPatch_WLine::IsOutSurf2Box(OCNaroWrappers::OCgp_Pnt2d^ P1)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IntPatch_WLine*)nativeHandle))->IsOutSurf2Box(*((gp_Pnt2d*)P1->Handle)));
}

 System::Boolean OCIntPatch_WLine::IsOutBox(OCNaroWrappers::OCgp_Pnt^ P)
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IntPatch_WLine*)nativeHandle))->IsOutBox(*((gp_Pnt*)P->Handle)));
}

 void OCIntPatch_WLine::SetPeriod(Standard_Real pu1, Standard_Real pv1, Standard_Real pu2, Standard_Real pv2)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->SetPeriod(pu1, pv1, pu2, pv2);
}

 Standard_Real OCIntPatch_WLine::U1Period()
{
  return (*((Handle_IntPatch_WLine*)nativeHandle))->U1Period();
}

 Standard_Real OCIntPatch_WLine::V1Period()
{
  return (*((Handle_IntPatch_WLine*)nativeHandle))->V1Period();
}

 Standard_Real OCIntPatch_WLine::U2Period()
{
  return (*((Handle_IntPatch_WLine*)nativeHandle))->U2Period();
}

 Standard_Real OCIntPatch_WLine::V2Period()
{
  return (*((Handle_IntPatch_WLine*)nativeHandle))->V2Period();
}

 void OCIntPatch_WLine::SetArcOnS1(OCNaroWrappers::OCAdaptor2d_HCurve2d^ A)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->SetArcOnS1(*((Handle_Adaptor2d_HCurve2d*)A->Handle));
}

 System::Boolean OCIntPatch_WLine::HasArcOnS1()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IntPatch_WLine*)nativeHandle))->HasArcOnS1());
}

OCAdaptor2d_HCurve2d^ OCIntPatch_WLine::GetArcOnS1()
{
  Handle(Adaptor2d_HCurve2d) tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->GetArcOnS1();
  return gcnew OCAdaptor2d_HCurve2d(&tmp);
}

 void OCIntPatch_WLine::SetArcOnS2(OCNaroWrappers::OCAdaptor2d_HCurve2d^ A)
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->SetArcOnS2(*((Handle_Adaptor2d_HCurve2d*)A->Handle));
}

 System::Boolean OCIntPatch_WLine::HasArcOnS2()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_IntPatch_WLine*)nativeHandle))->HasArcOnS2());
}

OCAdaptor2d_HCurve2d^ OCIntPatch_WLine::GetArcOnS2()
{
  Handle(Adaptor2d_HCurve2d) tmp = (*((Handle_IntPatch_WLine*)nativeHandle))->GetArcOnS2();
  return gcnew OCAdaptor2d_HCurve2d(&tmp);
}

 void OCIntPatch_WLine::Dump()
{
  (*((Handle_IntPatch_WLine*)nativeHandle))->Dump();
}

