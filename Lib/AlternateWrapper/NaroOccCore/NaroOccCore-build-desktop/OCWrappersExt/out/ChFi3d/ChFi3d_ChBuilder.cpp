// File generated by CPPExt (CPP file)
//

#include "ChFi3d_ChBuilder.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopoDS/TopoDS_Edge.h"
#include "../TopoDS/TopoDS_Face.h"
#include "../ChFiDS/ChFiDS_SecHArray1.h"
#include "../ChFiDS/ChFiDS_SurfData.h"
#include "../ChFiDS/ChFiDS_HElSpine.h"
#include "../ChFiDS/ChFiDS_Spine.h"
#include "../BRepAdaptor/BRepAdaptor_HSurface.h"
#include "../Adaptor3d/Adaptor3d_TopolTool.h"
#include "../math/math_Vector.h"
#include "../BRepAdaptor/BRepAdaptor_HCurve2d.h"
#include "../ChFiDS/ChFiDS_SequenceOfSurfData.h"
#include "../TopoDS/TopoDS_Vertex.h"
#include "../ChFiDS/ChFiDS_Stripe.h"
#include "../ChFiDS/ChFiDS_ListOfStripe.h"


using namespace OCNaroWrappers;

OCChFi3d_ChBuilder::OCChFi3d_ChBuilder(ChFi3d_ChBuilder* nativeHandle) : OCChFi3d_Builder((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCChFi3d_ChBuilder::OCChFi3d_ChBuilder(OCNaroWrappers::OCTopoDS_Shape^ S, Standard_Real Ta) : OCChFi3d_Builder((OCDummy^)nullptr)

{
  nativeHandle = new ChFi3d_ChBuilder(*((TopoDS_Shape*)S->Handle), Ta);
}

 void OCChFi3d_ChBuilder::Add(OCNaroWrappers::OCTopoDS_Edge^ E)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->Add(*((TopoDS_Edge*)E->Handle));
}

 void OCChFi3d_ChBuilder::Add(Standard_Real Dis, OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->Add(Dis, *((TopoDS_Edge*)E->Handle), *((TopoDS_Face*)F->Handle));
}

 void OCChFi3d_ChBuilder::SetDist(Standard_Real Dis, Standard_Integer IC, OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->SetDist(Dis, IC, *((TopoDS_Face*)F->Handle));
}

 void OCChFi3d_ChBuilder::GetDist(Standard_Integer IC, Standard_Real& Dis)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->GetDist(IC, Dis);
}

 void OCChFi3d_ChBuilder::Add(Standard_Real Dis1, Standard_Real Dis2, OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->Add(Dis1, Dis2, *((TopoDS_Edge*)E->Handle), *((TopoDS_Face*)F->Handle));
}

 void OCChFi3d_ChBuilder::SetDists(Standard_Real Dis1, Standard_Real Dis2, Standard_Integer IC, OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->SetDists(Dis1, Dis2, IC, *((TopoDS_Face*)F->Handle));
}

 void OCChFi3d_ChBuilder::Dists(Standard_Integer IC, Standard_Real& Dis1, Standard_Real& Dis2)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->Dists(IC, Dis1, Dis2);
}

 void OCChFi3d_ChBuilder::AddDA(Standard_Real Dis, Standard_Real Angle, OCNaroWrappers::OCTopoDS_Edge^ E, OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->AddDA(Dis, Angle, *((TopoDS_Edge*)E->Handle), *((TopoDS_Face*)F->Handle));
}

 void OCChFi3d_ChBuilder::SetDistAngle(Standard_Real Dis, Standard_Real Angle, Standard_Integer IC, OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->SetDistAngle(Dis, Angle, IC, *((TopoDS_Face*)F->Handle));
}

 void OCChFi3d_ChBuilder::GetDistAngle(Standard_Integer IC, Standard_Real& Dis, Standard_Real& Angle, System::Boolean& DisOnFace1)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->GetDistAngle(IC, Dis, Angle, (Standard_Boolean&)(DisOnFace1));
}

 OCChFiDS_ChamfMethod OCChFi3d_ChBuilder::IsChamfer(Standard_Integer IC)
{
  return (OCChFiDS_ChamfMethod)(((ChFi3d_ChBuilder*)nativeHandle)->IsChamfer(IC));
}

 void OCChFi3d_ChBuilder::ResetContour(Standard_Integer IC)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->ResetContour(IC);
}

 void OCChFi3d_ChBuilder::Simulate(Standard_Integer IC)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->Simulate(IC);
}

 Standard_Integer OCChFi3d_ChBuilder::NbSurf(Standard_Integer IC)
{
  return ((ChFi3d_ChBuilder*)nativeHandle)->NbSurf(IC);
}

OCChFiDS_SecHArray1^ OCChFi3d_ChBuilder::Sect(Standard_Integer IC, Standard_Integer IS)
{
  Handle(ChFiDS_SecHArray1) tmp = ((ChFi3d_ChBuilder*)nativeHandle)->Sect(IC, IS);
  return gcnew OCChFiDS_SecHArray1(&tmp);
}

 void OCChFi3d_ChBuilder::SimulSurf(OCNaroWrappers::OCChFiDS_SurfData^ Data, OCNaroWrappers::OCChFiDS_HElSpine^ Guide, OCNaroWrappers::OCChFiDS_Spine^ Spine, Standard_Integer Choix, OCNaroWrappers::OCBRepAdaptor_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_TopolTool^ I1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC1, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref1, System::Boolean& Decroch1, OCNaroWrappers::OCBRepAdaptor_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_TopolTool^ I2, OCTopAbs_Orientation Or2, Standard_Real Fleche, Standard_Real TolGuide, Standard_Real& First, Standard_Real& Last, System::Boolean Inside, System::Boolean Appro, System::Boolean Forward, System::Boolean RecP, System::Boolean RecS, System::Boolean RecRst, OCNaroWrappers::OCmath_Vector^ Soldep)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->SimulSurf(*((Handle_ChFiDS_SurfData*)Data->Handle), *((Handle_ChFiDS_HElSpine*)Guide->Handle), *((Handle_ChFiDS_Spine*)Spine->Handle), Choix, *((Handle_BRepAdaptor_HSurface*)S1->Handle), *((Handle_Adaptor3d_TopolTool*)I1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC1->Handle), *((Handle_BRepAdaptor_HSurface*)Sref1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref1->Handle), (Standard_Boolean&)(Decroch1), *((Handle_BRepAdaptor_HSurface*)S2->Handle), *((Handle_Adaptor3d_TopolTool*)I2->Handle), (TopAbs_Orientation)Or2, Fleche, TolGuide, First, Last, OCConverter::BooleanToStandardBoolean(Inside), OCConverter::BooleanToStandardBoolean(Appro), OCConverter::BooleanToStandardBoolean(Forward), OCConverter::BooleanToStandardBoolean(RecP), OCConverter::BooleanToStandardBoolean(RecS), OCConverter::BooleanToStandardBoolean(RecRst), *((math_Vector*)Soldep->Handle));
}

 void OCChFi3d_ChBuilder::SimulSurf(OCNaroWrappers::OCChFiDS_SurfData^ Data, OCNaroWrappers::OCChFiDS_HElSpine^ Guide, OCNaroWrappers::OCChFiDS_Spine^ Spine, Standard_Integer Choix, OCNaroWrappers::OCBRepAdaptor_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_TopolTool^ I1, OCTopAbs_Orientation Or1, OCNaroWrappers::OCBRepAdaptor_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_TopolTool^ I2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC2, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref2, System::Boolean& Decroch2, Standard_Real Fleche, Standard_Real TolGuide, Standard_Real& First, Standard_Real& Last, System::Boolean Inside, System::Boolean Appro, System::Boolean Forward, System::Boolean RecP, System::Boolean RecS, System::Boolean RecRst, OCNaroWrappers::OCmath_Vector^ Soldep)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->SimulSurf(*((Handle_ChFiDS_SurfData*)Data->Handle), *((Handle_ChFiDS_HElSpine*)Guide->Handle), *((Handle_ChFiDS_Spine*)Spine->Handle), Choix, *((Handle_BRepAdaptor_HSurface*)S1->Handle), *((Handle_Adaptor3d_TopolTool*)I1->Handle), (TopAbs_Orientation)Or1, *((Handle_BRepAdaptor_HSurface*)S2->Handle), *((Handle_Adaptor3d_TopolTool*)I2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC2->Handle), *((Handle_BRepAdaptor_HSurface*)Sref2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref2->Handle), (Standard_Boolean&)(Decroch2), Fleche, TolGuide, First, Last, OCConverter::BooleanToStandardBoolean(Inside), OCConverter::BooleanToStandardBoolean(Appro), OCConverter::BooleanToStandardBoolean(Forward), OCConverter::BooleanToStandardBoolean(RecP), OCConverter::BooleanToStandardBoolean(RecS), OCConverter::BooleanToStandardBoolean(RecRst), *((math_Vector*)Soldep->Handle));
}

 void OCChFi3d_ChBuilder::SimulSurf(OCNaroWrappers::OCChFiDS_SurfData^ Data, OCNaroWrappers::OCChFiDS_HElSpine^ Guide, OCNaroWrappers::OCChFiDS_Spine^ Spine, Standard_Integer Choix, OCNaroWrappers::OCBRepAdaptor_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_TopolTool^ I1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC1, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref1, System::Boolean& Decroch1, OCTopAbs_Orientation Or1, OCNaroWrappers::OCBRepAdaptor_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_TopolTool^ I2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC2, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref2, System::Boolean& Decroch2, OCTopAbs_Orientation Or2, Standard_Real Fleche, Standard_Real TolGuide, Standard_Real& First, Standard_Real& Last, System::Boolean Inside, System::Boolean Appro, System::Boolean Forward, System::Boolean RecP1, System::Boolean RecRst1, System::Boolean RecP2, System::Boolean RecRst2, OCNaroWrappers::OCmath_Vector^ Soldep)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->SimulSurf(*((Handle_ChFiDS_SurfData*)Data->Handle), *((Handle_ChFiDS_HElSpine*)Guide->Handle), *((Handle_ChFiDS_Spine*)Spine->Handle), Choix, *((Handle_BRepAdaptor_HSurface*)S1->Handle), *((Handle_Adaptor3d_TopolTool*)I1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC1->Handle), *((Handle_BRepAdaptor_HSurface*)Sref1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref1->Handle), (Standard_Boolean&)(Decroch1), (TopAbs_Orientation)Or1, *((Handle_BRepAdaptor_HSurface*)S2->Handle), *((Handle_Adaptor3d_TopolTool*)I2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC2->Handle), *((Handle_BRepAdaptor_HSurface*)Sref2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref2->Handle), (Standard_Boolean&)(Decroch2), (TopAbs_Orientation)Or2, Fleche, TolGuide, First, Last, OCConverter::BooleanToStandardBoolean(Inside), OCConverter::BooleanToStandardBoolean(Appro), OCConverter::BooleanToStandardBoolean(Forward), OCConverter::BooleanToStandardBoolean(RecP1), OCConverter::BooleanToStandardBoolean(RecRst1), OCConverter::BooleanToStandardBoolean(RecP2), OCConverter::BooleanToStandardBoolean(RecRst2), *((math_Vector*)Soldep->Handle));
}

 System::Boolean OCChFi3d_ChBuilder::PerformSurf(OCNaroWrappers::OCChFiDS_SequenceOfSurfData^ Data, OCNaroWrappers::OCChFiDS_HElSpine^ Guide, OCNaroWrappers::OCChFiDS_Spine^ Spine, Standard_Integer Choix, OCNaroWrappers::OCBRepAdaptor_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_TopolTool^ I1, OCNaroWrappers::OCBRepAdaptor_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_TopolTool^ I2, Standard_Real MaxStep, Standard_Real Fleche, Standard_Real TolGuide, Standard_Real& First, Standard_Real& Last, System::Boolean Inside, System::Boolean Appro, System::Boolean Forward, System::Boolean RecOnS1, System::Boolean RecOnS2, OCNaroWrappers::OCmath_Vector^ Soldep, System::Boolean& Intf, System::Boolean& Intl)
{
  return OCConverter::StandardBooleanToBoolean(((ChFi3d_ChBuilder*)nativeHandle)->PerformSurf(*((ChFiDS_SequenceOfSurfData*)Data->Handle), *((Handle_ChFiDS_HElSpine*)Guide->Handle), *((Handle_ChFiDS_Spine*)Spine->Handle), Choix, *((Handle_BRepAdaptor_HSurface*)S1->Handle), *((Handle_Adaptor3d_TopolTool*)I1->Handle), *((Handle_BRepAdaptor_HSurface*)S2->Handle), *((Handle_Adaptor3d_TopolTool*)I2->Handle), MaxStep, Fleche, TolGuide, First, Last, OCConverter::BooleanToStandardBoolean(Inside), OCConverter::BooleanToStandardBoolean(Appro), OCConverter::BooleanToStandardBoolean(Forward), OCConverter::BooleanToStandardBoolean(RecOnS1), OCConverter::BooleanToStandardBoolean(RecOnS2), *((math_Vector*)Soldep->Handle), (Standard_Boolean&)(Intf), (Standard_Boolean&)(Intl)));
}

 void OCChFi3d_ChBuilder::PerformSurf(OCNaroWrappers::OCChFiDS_SequenceOfSurfData^ Data, OCNaroWrappers::OCChFiDS_HElSpine^ Guide, OCNaroWrappers::OCChFiDS_Spine^ Spine, Standard_Integer Choix, OCNaroWrappers::OCBRepAdaptor_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_TopolTool^ I1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC1, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref1, System::Boolean& Decroch1, OCNaroWrappers::OCBRepAdaptor_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_TopolTool^ I2, OCTopAbs_Orientation Or2, Standard_Real MaxStep, Standard_Real Fleche, Standard_Real TolGuide, Standard_Real& First, Standard_Real& Last, System::Boolean Inside, System::Boolean Appro, System::Boolean Forward, System::Boolean RecP, System::Boolean RecS, System::Boolean RecRst, OCNaroWrappers::OCmath_Vector^ Soldep)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->PerformSurf(*((ChFiDS_SequenceOfSurfData*)Data->Handle), *((Handle_ChFiDS_HElSpine*)Guide->Handle), *((Handle_ChFiDS_Spine*)Spine->Handle), Choix, *((Handle_BRepAdaptor_HSurface*)S1->Handle), *((Handle_Adaptor3d_TopolTool*)I1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC1->Handle), *((Handle_BRepAdaptor_HSurface*)Sref1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref1->Handle), (Standard_Boolean&)(Decroch1), *((Handle_BRepAdaptor_HSurface*)S2->Handle), *((Handle_Adaptor3d_TopolTool*)I2->Handle), (TopAbs_Orientation)Or2, MaxStep, Fleche, TolGuide, First, Last, OCConverter::BooleanToStandardBoolean(Inside), OCConverter::BooleanToStandardBoolean(Appro), OCConverter::BooleanToStandardBoolean(Forward), OCConverter::BooleanToStandardBoolean(RecP), OCConverter::BooleanToStandardBoolean(RecS), OCConverter::BooleanToStandardBoolean(RecRst), *((math_Vector*)Soldep->Handle));
}

 void OCChFi3d_ChBuilder::PerformSurf(OCNaroWrappers::OCChFiDS_SequenceOfSurfData^ Data, OCNaroWrappers::OCChFiDS_HElSpine^ Guide, OCNaroWrappers::OCChFiDS_Spine^ Spine, Standard_Integer Choix, OCNaroWrappers::OCBRepAdaptor_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_TopolTool^ I1, OCTopAbs_Orientation Or1, OCNaroWrappers::OCBRepAdaptor_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_TopolTool^ I2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC2, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref2, System::Boolean& Decroch2, Standard_Real MaxStep, Standard_Real Fleche, Standard_Real TolGuide, Standard_Real& First, Standard_Real& Last, System::Boolean Inside, System::Boolean Appro, System::Boolean Forward, System::Boolean RecP, System::Boolean RecS, System::Boolean RecRst, OCNaroWrappers::OCmath_Vector^ Soldep)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->PerformSurf(*((ChFiDS_SequenceOfSurfData*)Data->Handle), *((Handle_ChFiDS_HElSpine*)Guide->Handle), *((Handle_ChFiDS_Spine*)Spine->Handle), Choix, *((Handle_BRepAdaptor_HSurface*)S1->Handle), *((Handle_Adaptor3d_TopolTool*)I1->Handle), (TopAbs_Orientation)Or1, *((Handle_BRepAdaptor_HSurface*)S2->Handle), *((Handle_Adaptor3d_TopolTool*)I2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC2->Handle), *((Handle_BRepAdaptor_HSurface*)Sref2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref2->Handle), (Standard_Boolean&)(Decroch2), MaxStep, Fleche, TolGuide, First, Last, OCConverter::BooleanToStandardBoolean(Inside), OCConverter::BooleanToStandardBoolean(Appro), OCConverter::BooleanToStandardBoolean(Forward), OCConverter::BooleanToStandardBoolean(RecP), OCConverter::BooleanToStandardBoolean(RecS), OCConverter::BooleanToStandardBoolean(RecRst), *((math_Vector*)Soldep->Handle));
}

 void OCChFi3d_ChBuilder::PerformSurf(OCNaroWrappers::OCChFiDS_SequenceOfSurfData^ Data, OCNaroWrappers::OCChFiDS_HElSpine^ Guide, OCNaroWrappers::OCChFiDS_Spine^ Spine, Standard_Integer Choix, OCNaroWrappers::OCBRepAdaptor_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_TopolTool^ I1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC1, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref1, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref1, System::Boolean& Decroch1, OCTopAbs_Orientation Or1, OCNaroWrappers::OCBRepAdaptor_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_TopolTool^ I2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PC2, OCNaroWrappers::OCBRepAdaptor_HSurface^ Sref2, OCNaroWrappers::OCBRepAdaptor_HCurve2d^ PCref2, System::Boolean& Decroch2, OCTopAbs_Orientation Or2, Standard_Real MaxStep, Standard_Real Fleche, Standard_Real TolGuide, Standard_Real& First, Standard_Real& Last, System::Boolean Inside, System::Boolean Appro, System::Boolean Forward, System::Boolean RecP1, System::Boolean RecRst1, System::Boolean RecP2, System::Boolean RecRst2, OCNaroWrappers::OCmath_Vector^ Soldep)
{
  ((ChFi3d_ChBuilder*)nativeHandle)->PerformSurf(*((ChFiDS_SequenceOfSurfData*)Data->Handle), *((Handle_ChFiDS_HElSpine*)Guide->Handle), *((Handle_ChFiDS_Spine*)Spine->Handle), Choix, *((Handle_BRepAdaptor_HSurface*)S1->Handle), *((Handle_Adaptor3d_TopolTool*)I1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC1->Handle), *((Handle_BRepAdaptor_HSurface*)Sref1->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref1->Handle), (Standard_Boolean&)(Decroch1), (TopAbs_Orientation)Or1, *((Handle_BRepAdaptor_HSurface*)S2->Handle), *((Handle_Adaptor3d_TopolTool*)I2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PC2->Handle), *((Handle_BRepAdaptor_HSurface*)Sref2->Handle), *((Handle_BRepAdaptor_HCurve2d*)PCref2->Handle), (Standard_Boolean&)(Decroch2), (TopAbs_Orientation)Or2, MaxStep, Fleche, TolGuide, First, Last, OCConverter::BooleanToStandardBoolean(Inside), OCConverter::BooleanToStandardBoolean(Appro), OCConverter::BooleanToStandardBoolean(Forward), OCConverter::BooleanToStandardBoolean(RecP1), OCConverter::BooleanToStandardBoolean(RecRst1), OCConverter::BooleanToStandardBoolean(RecP2), OCConverter::BooleanToStandardBoolean(RecRst2), *((math_Vector*)Soldep->Handle));
}

 Standard_Integer OCChFi3d_ChBuilder::FindChoiceDistAngle(Standard_Integer Choice, System::Boolean DisOnF1)
{
  return ((ChFi3d_ChBuilder*)nativeHandle)->FindChoiceDistAngle(Choice, OCConverter::BooleanToStandardBoolean(DisOnF1));
}


