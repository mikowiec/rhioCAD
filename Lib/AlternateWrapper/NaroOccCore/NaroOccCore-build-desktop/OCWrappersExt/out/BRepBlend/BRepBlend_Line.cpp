// File generated by CPPExt (CPP file)
//

#include "BRepBlend_Line.h"
#include "../Converter.h"
#include "../Adaptor3d/Adaptor3d_HVertex.h"
#include "../Adaptor2d/Adaptor2d_HCurve2d.h"
#include "BRepBlend_PointOnRst.h"
#include "BRepBlend_SequenceOfPointOnRst.h"
#include "BRepBlend_Extremity.h"
#include "../Blend/Blend_Point.h"


using namespace OCNaroWrappers;

OCBRepBlend_Line::OCBRepBlend_Line(Handle(BRepBlend_Line)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_BRepBlend_Line(*nativeHandle);
}

OCBRepBlend_Line::OCBRepBlend_Line() : OCMMgt_TShared((OCDummy^)nullptr)

{
  nativeHandle = new Handle_BRepBlend_Line(new BRepBlend_Line());
}

 void OCBRepBlend_Line::Clear()
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->Clear();
}

 void OCBRepBlend_Line::Append(OCNaroWrappers::OCBlend_Point^ P)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->Append(*((Blend_Point*)P->Handle));
}

 void OCBRepBlend_Line::Prepend(OCNaroWrappers::OCBlend_Point^ P)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->Prepend(*((Blend_Point*)P->Handle));
}

 void OCBRepBlend_Line::InsertBefore(Standard_Integer Index, OCNaroWrappers::OCBlend_Point^ P)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->InsertBefore(Index, *((Blend_Point*)P->Handle));
}

 void OCBRepBlend_Line::Remove(Standard_Integer FromIndex, Standard_Integer ToIndex)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->Remove(FromIndex, ToIndex);
}

 void OCBRepBlend_Line::Set(OCIntSurf_TypeTrans TranS1, OCIntSurf_TypeTrans TranS2)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->Set((IntSurf_TypeTrans)TranS1, (IntSurf_TypeTrans)TranS2);
}

 void OCBRepBlend_Line::Set(OCIntSurf_TypeTrans Trans)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->Set((IntSurf_TypeTrans)Trans);
}

 void OCBRepBlend_Line::SetStartPoints(OCNaroWrappers::OCBRepBlend_Extremity^ StartPt1, OCNaroWrappers::OCBRepBlend_Extremity^ StartPt2)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->SetStartPoints(*((BRepBlend_Extremity*)StartPt1->Handle), *((BRepBlend_Extremity*)StartPt2->Handle));
}

 void OCBRepBlend_Line::SetEndPoints(OCNaroWrappers::OCBRepBlend_Extremity^ EndPt1, OCNaroWrappers::OCBRepBlend_Extremity^ EndPt2)
{
  (*((Handle_BRepBlend_Line*)nativeHandle))->SetEndPoints(*((BRepBlend_Extremity*)EndPt1->Handle), *((BRepBlend_Extremity*)EndPt2->Handle));
}

 Standard_Integer OCBRepBlend_Line::NbPoints()
{
  return (*((Handle_BRepBlend_Line*)nativeHandle))->NbPoints();
}

OCBlend_Point^ OCBRepBlend_Line::Point(Standard_Integer Index)
{
  Blend_Point* tmp = new Blend_Point();
  *tmp = (*((Handle_BRepBlend_Line*)nativeHandle))->Point(Index);
  return gcnew OCBlend_Point(tmp);
}

 OCIntSurf_TypeTrans OCBRepBlend_Line::TransitionOnS1()
{
  return (OCIntSurf_TypeTrans)((*((Handle_BRepBlend_Line*)nativeHandle))->TransitionOnS1());
}

 OCIntSurf_TypeTrans OCBRepBlend_Line::TransitionOnS2()
{
  return (OCIntSurf_TypeTrans)((*((Handle_BRepBlend_Line*)nativeHandle))->TransitionOnS2());
}

OCBRepBlend_Extremity^ OCBRepBlend_Line::StartPointOnFirst()
{
  BRepBlend_Extremity* tmp = new BRepBlend_Extremity();
  *tmp = (*((Handle_BRepBlend_Line*)nativeHandle))->StartPointOnFirst();
  return gcnew OCBRepBlend_Extremity(tmp);
}

OCBRepBlend_Extremity^ OCBRepBlend_Line::StartPointOnSecond()
{
  BRepBlend_Extremity* tmp = new BRepBlend_Extremity();
  *tmp = (*((Handle_BRepBlend_Line*)nativeHandle))->StartPointOnSecond();
  return gcnew OCBRepBlend_Extremity(tmp);
}

OCBRepBlend_Extremity^ OCBRepBlend_Line::EndPointOnFirst()
{
  BRepBlend_Extremity* tmp = new BRepBlend_Extremity();
  *tmp = (*((Handle_BRepBlend_Line*)nativeHandle))->EndPointOnFirst();
  return gcnew OCBRepBlend_Extremity(tmp);
}

OCBRepBlend_Extremity^ OCBRepBlend_Line::EndPointOnSecond()
{
  BRepBlend_Extremity* tmp = new BRepBlend_Extremity();
  *tmp = (*((Handle_BRepBlend_Line*)nativeHandle))->EndPointOnSecond();
  return gcnew OCBRepBlend_Extremity(tmp);
}

 OCIntSurf_TypeTrans OCBRepBlend_Line::TransitionOnS()
{
  return (OCIntSurf_TypeTrans)((*((Handle_BRepBlend_Line*)nativeHandle))->TransitionOnS());
}


