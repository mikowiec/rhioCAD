// File generated by CPPExt (CPP file)
//

#include "Geom2dLProp_CLProps2d.h"
#include "../Converter.h"
#include "../Geom2d/Geom2d_Curve.h"
#include "../gp/gp_Vec2d.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Dir2d.h"
#include "Geom2dLProp_Curve2dTool.h"


using namespace OCNaroWrappers;

OCGeom2dLProp_CLProps2d::OCGeom2dLProp_CLProps2d(Geom2dLProp_CLProps2d* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCGeom2dLProp_CLProps2d::OCGeom2dLProp_CLProps2d(OCNaroWrappers::OCGeom2d_Curve^ C, Standard_Integer N, Standard_Real Resolution) 
{
  nativeHandle = new Geom2dLProp_CLProps2d(*((Handle_Geom2d_Curve*)C->Handle), N, Resolution);
}

OCGeom2dLProp_CLProps2d::OCGeom2dLProp_CLProps2d(OCNaroWrappers::OCGeom2d_Curve^ C, Standard_Real U, Standard_Integer N, Standard_Real Resolution) 
{
  nativeHandle = new Geom2dLProp_CLProps2d(*((Handle_Geom2d_Curve*)C->Handle), U, N, Resolution);
}

OCGeom2dLProp_CLProps2d::OCGeom2dLProp_CLProps2d(Standard_Integer N, Standard_Real Resolution) 
{
  nativeHandle = new Geom2dLProp_CLProps2d(N, Resolution);
}

 void OCGeom2dLProp_CLProps2d::SetParameter(Standard_Real U)
{
  ((Geom2dLProp_CLProps2d*)nativeHandle)->SetParameter(U);
}

 void OCGeom2dLProp_CLProps2d::SetCurve(OCNaroWrappers::OCGeom2d_Curve^ C)
{
  ((Geom2dLProp_CLProps2d*)nativeHandle)->SetCurve(*((Handle_Geom2d_Curve*)C->Handle));
}

OCgp_Pnt2d^ OCGeom2dLProp_CLProps2d::Value()
{
  gp_Pnt2d* tmp = new gp_Pnt2d();
  *tmp = ((Geom2dLProp_CLProps2d*)nativeHandle)->Value();
  return gcnew OCgp_Pnt2d(tmp);
}

OCgp_Vec2d^ OCGeom2dLProp_CLProps2d::D1()
{
  gp_Vec2d* tmp = new gp_Vec2d();
  *tmp = ((Geom2dLProp_CLProps2d*)nativeHandle)->D1();
  return gcnew OCgp_Vec2d(tmp);
}

OCgp_Vec2d^ OCGeom2dLProp_CLProps2d::D2()
{
  gp_Vec2d* tmp = new gp_Vec2d();
  *tmp = ((Geom2dLProp_CLProps2d*)nativeHandle)->D2();
  return gcnew OCgp_Vec2d(tmp);
}

OCgp_Vec2d^ OCGeom2dLProp_CLProps2d::D3()
{
  gp_Vec2d* tmp = new gp_Vec2d();
  *tmp = ((Geom2dLProp_CLProps2d*)nativeHandle)->D3();
  return gcnew OCgp_Vec2d(tmp);
}

 System::Boolean OCGeom2dLProp_CLProps2d::IsTangentDefined()
{
  return OCConverter::StandardBooleanToBoolean(((Geom2dLProp_CLProps2d*)nativeHandle)->IsTangentDefined());
}

 void OCGeom2dLProp_CLProps2d::Tangent(OCNaroWrappers::OCgp_Dir2d^ D)
{
  ((Geom2dLProp_CLProps2d*)nativeHandle)->Tangent(*((gp_Dir2d*)D->Handle));
}

 Standard_Real OCGeom2dLProp_CLProps2d::Curvature()
{
  return ((Geom2dLProp_CLProps2d*)nativeHandle)->Curvature();
}

 void OCGeom2dLProp_CLProps2d::Normal(OCNaroWrappers::OCgp_Dir2d^ N)
{
  ((Geom2dLProp_CLProps2d*)nativeHandle)->Normal(*((gp_Dir2d*)N->Handle));
}

 void OCGeom2dLProp_CLProps2d::CentreOfCurvature(OCNaroWrappers::OCgp_Pnt2d^ P)
{
  ((Geom2dLProp_CLProps2d*)nativeHandle)->CentreOfCurvature(*((gp_Pnt2d*)P->Handle));
}


