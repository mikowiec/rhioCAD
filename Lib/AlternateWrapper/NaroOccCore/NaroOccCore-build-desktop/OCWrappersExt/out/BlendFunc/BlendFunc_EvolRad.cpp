// File generated by CPPExt (CPP file)
//

#include "BlendFunc_EvolRad.h"
#include "../Converter.h"
#include "../Adaptor3d/Adaptor3d_HSurface.h"
#include "../Adaptor3d/Adaptor3d_HCurve.h"
#include "../Law/Law_Function.h"
#include "../math/math_Vector.h"
#include "../math/math_Matrix.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Vec.h"
#include "../gp/gp_Vec2d.h"
#include "../gp/gp_Circ.h"
#include "../TColStd/TColStd_Array1OfReal.h"
#include "../TColStd/TColStd_Array1OfInteger.h"
#include "../Blend/Blend_Point.h"
#include "../TColgp/TColgp_Array1OfPnt.h"
#include "../TColgp/TColgp_Array1OfVec.h"
#include "../TColgp/TColgp_Array1OfPnt2d.h"
#include "../TColgp/TColgp_Array1OfVec2d.h"


using namespace OCNaroWrappers;

OCBlendFunc_EvolRad::OCBlendFunc_EvolRad(BlendFunc_EvolRad* nativeHandle) : OCBlend_Function((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBlendFunc_EvolRad::OCBlendFunc_EvolRad(OCNaroWrappers::OCAdaptor3d_HSurface^ S1, OCNaroWrappers::OCAdaptor3d_HSurface^ S2, OCNaroWrappers::OCAdaptor3d_HCurve^ C, OCNaroWrappers::OCLaw_Function^ Law) : OCBlend_Function((OCDummy^)nullptr)

{
  nativeHandle = new BlendFunc_EvolRad(*((Handle_Adaptor3d_HSurface*)S1->Handle), *((Handle_Adaptor3d_HSurface*)S2->Handle), *((Handle_Adaptor3d_HCurve*)C->Handle), *((Handle_Law_Function*)Law->Handle));
}

 Standard_Integer OCBlendFunc_EvolRad::NbEquations()
{
  return ((BlendFunc_EvolRad*)nativeHandle)->NbEquations();
}

 System::Boolean OCBlendFunc_EvolRad::Value(OCNaroWrappers::OCmath_Vector^ X, OCNaroWrappers::OCmath_Vector^ F)
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->Value(*((math_Vector*)X->Handle), *((math_Vector*)F->Handle)));
}

 System::Boolean OCBlendFunc_EvolRad::Derivatives(OCNaroWrappers::OCmath_Vector^ X, OCNaroWrappers::OCmath_Matrix^ D)
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->Derivatives(*((math_Vector*)X->Handle), *((math_Matrix*)D->Handle)));
}

 System::Boolean OCBlendFunc_EvolRad::Values(OCNaroWrappers::OCmath_Vector^ X, OCNaroWrappers::OCmath_Vector^ F, OCNaroWrappers::OCmath_Matrix^ D)
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->Values(*((math_Vector*)X->Handle), *((math_Vector*)F->Handle), *((math_Matrix*)D->Handle)));
}

 void OCBlendFunc_EvolRad::Set(Standard_Real Param)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Set(Param);
}

 void OCBlendFunc_EvolRad::Set(Standard_Real First, Standard_Real Last)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Set(First, Last);
}

 void OCBlendFunc_EvolRad::GetTolerance(OCNaroWrappers::OCmath_Vector^ Tolerance, Standard_Real Tol)
{
  ((BlendFunc_EvolRad*)nativeHandle)->GetTolerance(*((math_Vector*)Tolerance->Handle), Tol);
}

 void OCBlendFunc_EvolRad::GetBounds(OCNaroWrappers::OCmath_Vector^ InfBound, OCNaroWrappers::OCmath_Vector^ SupBound)
{
  ((BlendFunc_EvolRad*)nativeHandle)->GetBounds(*((math_Vector*)InfBound->Handle), *((math_Vector*)SupBound->Handle));
}

 System::Boolean OCBlendFunc_EvolRad::IsSolution(OCNaroWrappers::OCmath_Vector^ Sol, Standard_Real Tol)
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->IsSolution(*((math_Vector*)Sol->Handle), Tol));
}

 Standard_Real OCBlendFunc_EvolRad::GetMinimalDistance()
{
  return ((BlendFunc_EvolRad*)nativeHandle)->GetMinimalDistance();
}

OCgp_Pnt^ OCBlendFunc_EvolRad::PointOnS1()
{
  gp_Pnt* tmp = new gp_Pnt();
  *tmp = ((BlendFunc_EvolRad*)nativeHandle)->PointOnS1();
  return gcnew OCgp_Pnt(tmp);
}

OCgp_Pnt^ OCBlendFunc_EvolRad::PointOnS2()
{
  gp_Pnt* tmp = new gp_Pnt();
  *tmp = ((BlendFunc_EvolRad*)nativeHandle)->PointOnS2();
  return gcnew OCgp_Pnt(tmp);
}

 System::Boolean OCBlendFunc_EvolRad::IsTangencyPoint()
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->IsTangencyPoint());
}

OCgp_Vec^ OCBlendFunc_EvolRad::TangentOnS1()
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = ((BlendFunc_EvolRad*)nativeHandle)->TangentOnS1();
  return gcnew OCgp_Vec(tmp);
}

OCgp_Vec2d^ OCBlendFunc_EvolRad::Tangent2dOnS1()
{
  gp_Vec2d* tmp = new gp_Vec2d();
  *tmp = ((BlendFunc_EvolRad*)nativeHandle)->Tangent2dOnS1();
  return gcnew OCgp_Vec2d(tmp);
}

OCgp_Vec^ OCBlendFunc_EvolRad::TangentOnS2()
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = ((BlendFunc_EvolRad*)nativeHandle)->TangentOnS2();
  return gcnew OCgp_Vec(tmp);
}

OCgp_Vec2d^ OCBlendFunc_EvolRad::Tangent2dOnS2()
{
  gp_Vec2d* tmp = new gp_Vec2d();
  *tmp = ((BlendFunc_EvolRad*)nativeHandle)->Tangent2dOnS2();
  return gcnew OCgp_Vec2d(tmp);
}

 void OCBlendFunc_EvolRad::Tangent(Standard_Real U1, Standard_Real V1, Standard_Real U2, Standard_Real V2, OCNaroWrappers::OCgp_Vec^ TgFirst, OCNaroWrappers::OCgp_Vec^ TgLast, OCNaroWrappers::OCgp_Vec^ NormFirst, OCNaroWrappers::OCgp_Vec^ NormLast)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Tangent(U1, V1, U2, V2, *((gp_Vec*)TgFirst->Handle), *((gp_Vec*)TgLast->Handle), *((gp_Vec*)NormFirst->Handle), *((gp_Vec*)NormLast->Handle));
}

 System::Boolean OCBlendFunc_EvolRad::TwistOnS1()
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->TwistOnS1());
}

 System::Boolean OCBlendFunc_EvolRad::TwistOnS2()
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->TwistOnS2());
}

 void OCBlendFunc_EvolRad::Set(Standard_Integer Choix)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Set(Choix);
}

 void OCBlendFunc_EvolRad::Set(OCBlendFunc_SectionShape TypeSection)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Set((BlendFunc_SectionShape)TypeSection);
}

 void OCBlendFunc_EvolRad::Section(Standard_Real Param, Standard_Real U1, Standard_Real V1, Standard_Real U2, Standard_Real V2, Standard_Real& Pdeb, Standard_Real& Pfin, OCNaroWrappers::OCgp_Circ^ C)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Section(Param, U1, V1, U2, V2, Pdeb, Pfin, *((gp_Circ*)C->Handle));
}

 System::Boolean OCBlendFunc_EvolRad::IsRational()
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->IsRational());
}

 Standard_Real OCBlendFunc_EvolRad::GetSectionSize()
{
  return ((BlendFunc_EvolRad*)nativeHandle)->GetSectionSize();
}

 void OCBlendFunc_EvolRad::GetMinimalWeight(OCNaroWrappers::OCTColStd_Array1OfReal^ Weigths)
{
  ((BlendFunc_EvolRad*)nativeHandle)->GetMinimalWeight(*((TColStd_Array1OfReal*)Weigths->Handle));
}

 Standard_Integer OCBlendFunc_EvolRad::NbIntervals(OCGeomAbs_Shape S)
{
  return ((BlendFunc_EvolRad*)nativeHandle)->NbIntervals((GeomAbs_Shape)S);
}

 void OCBlendFunc_EvolRad::Intervals(OCNaroWrappers::OCTColStd_Array1OfReal^ T, OCGeomAbs_Shape S)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Intervals(*((TColStd_Array1OfReal*)T->Handle), (GeomAbs_Shape)S);
}

 void OCBlendFunc_EvolRad::GetShape(Standard_Integer& NbPoles, Standard_Integer& NbKnots, Standard_Integer& Degree, Standard_Integer& NbPoles2d)
{
  ((BlendFunc_EvolRad*)nativeHandle)->GetShape(NbPoles, NbKnots, Degree, NbPoles2d);
}

 void OCBlendFunc_EvolRad::GetTolerance(Standard_Real BoundTol, Standard_Real SurfTol, Standard_Real AngleTol, OCNaroWrappers::OCmath_Vector^ Tol3d, OCNaroWrappers::OCmath_Vector^ Tol1D)
{
  ((BlendFunc_EvolRad*)nativeHandle)->GetTolerance(BoundTol, SurfTol, AngleTol, *((math_Vector*)Tol3d->Handle), *((math_Vector*)Tol1D->Handle));
}

 void OCBlendFunc_EvolRad::Knots(OCNaroWrappers::OCTColStd_Array1OfReal^ TKnots)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Knots(*((TColStd_Array1OfReal*)TKnots->Handle));
}

 void OCBlendFunc_EvolRad::Mults(OCNaroWrappers::OCTColStd_Array1OfInteger^ TMults)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Mults(*((TColStd_Array1OfInteger*)TMults->Handle));
}

 System::Boolean OCBlendFunc_EvolRad::Section(OCNaroWrappers::OCBlend_Point^ P, OCNaroWrappers::OCTColgp_Array1OfPnt^ Poles, OCNaroWrappers::OCTColgp_Array1OfVec^ DPoles, OCNaroWrappers::OCTColgp_Array1OfVec^ D2Poles, OCNaroWrappers::OCTColgp_Array1OfPnt2d^ Poles2d, OCNaroWrappers::OCTColgp_Array1OfVec2d^ DPoles2d, OCNaroWrappers::OCTColgp_Array1OfVec2d^ D2Poles2d, OCNaroWrappers::OCTColStd_Array1OfReal^ Weigths, OCNaroWrappers::OCTColStd_Array1OfReal^ DWeigths, OCNaroWrappers::OCTColStd_Array1OfReal^ D2Weigths)
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->Section(*((Blend_Point*)P->Handle), *((TColgp_Array1OfPnt*)Poles->Handle), *((TColgp_Array1OfVec*)DPoles->Handle), *((TColgp_Array1OfVec*)D2Poles->Handle), *((TColgp_Array1OfPnt2d*)Poles2d->Handle), *((TColgp_Array1OfVec2d*)DPoles2d->Handle), *((TColgp_Array1OfVec2d*)D2Poles2d->Handle), *((TColStd_Array1OfReal*)Weigths->Handle), *((TColStd_Array1OfReal*)DWeigths->Handle), *((TColStd_Array1OfReal*)D2Weigths->Handle)));
}

 System::Boolean OCBlendFunc_EvolRad::Section(OCNaroWrappers::OCBlend_Point^ P, OCNaroWrappers::OCTColgp_Array1OfPnt^ Poles, OCNaroWrappers::OCTColgp_Array1OfVec^ DPoles, OCNaroWrappers::OCTColgp_Array1OfPnt2d^ Poles2d, OCNaroWrappers::OCTColgp_Array1OfVec2d^ DPoles2d, OCNaroWrappers::OCTColStd_Array1OfReal^ Weigths, OCNaroWrappers::OCTColStd_Array1OfReal^ DWeigths)
{
  return OCConverter::StandardBooleanToBoolean(((BlendFunc_EvolRad*)nativeHandle)->Section(*((Blend_Point*)P->Handle), *((TColgp_Array1OfPnt*)Poles->Handle), *((TColgp_Array1OfVec*)DPoles->Handle), *((TColgp_Array1OfPnt2d*)Poles2d->Handle), *((TColgp_Array1OfVec2d*)DPoles2d->Handle), *((TColStd_Array1OfReal*)Weigths->Handle), *((TColStd_Array1OfReal*)DWeigths->Handle)));
}

 void OCBlendFunc_EvolRad::Section(OCNaroWrappers::OCBlend_Point^ P, OCNaroWrappers::OCTColgp_Array1OfPnt^ Poles, OCNaroWrappers::OCTColgp_Array1OfPnt2d^ Poles2d, OCNaroWrappers::OCTColStd_Array1OfReal^ Weigths)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Section(*((Blend_Point*)P->Handle), *((TColgp_Array1OfPnt*)Poles->Handle), *((TColgp_Array1OfPnt2d*)Poles2d->Handle), *((TColStd_Array1OfReal*)Weigths->Handle));
}

 void OCBlendFunc_EvolRad::Resolution(Standard_Integer IC2d, Standard_Real Tol, Standard_Real& TolU, Standard_Real& TolV)
{
  ((BlendFunc_EvolRad*)nativeHandle)->Resolution(IC2d, Tol, TolU, TolV);
}

