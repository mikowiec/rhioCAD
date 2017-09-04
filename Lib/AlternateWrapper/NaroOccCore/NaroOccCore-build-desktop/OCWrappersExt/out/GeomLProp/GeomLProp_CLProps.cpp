// File generated by CPPExt (CPP file)
//

#include "GeomLProp_CLProps.h"
#include "../Converter.h"
#include "../Geom/Geom_Curve.h"
#include "../gp/gp_Vec.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Dir.h"
#include "GeomLProp_CurveTool.h"


using namespace OCNaroWrappers;

OCGeomLProp_CLProps::OCGeomLProp_CLProps(GeomLProp_CLProps* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCGeomLProp_CLProps::OCGeomLProp_CLProps(OCNaroWrappers::OCGeom_Curve^ C, Standard_Integer N, Standard_Real Resolution) 
{
  nativeHandle = new GeomLProp_CLProps(*((Handle_Geom_Curve*)C->Handle), N, Resolution);
}

OCGeomLProp_CLProps::OCGeomLProp_CLProps(OCNaroWrappers::OCGeom_Curve^ C, Standard_Real U, Standard_Integer N, Standard_Real Resolution) 
{
  nativeHandle = new GeomLProp_CLProps(*((Handle_Geom_Curve*)C->Handle), U, N, Resolution);
}

OCGeomLProp_CLProps::OCGeomLProp_CLProps(Standard_Integer N, Standard_Real Resolution) 
{
  nativeHandle = new GeomLProp_CLProps(N, Resolution);
}

 void OCGeomLProp_CLProps::SetParameter(Standard_Real U)
{
  ((GeomLProp_CLProps*)nativeHandle)->SetParameter(U);
}

 void OCGeomLProp_CLProps::SetCurve(OCNaroWrappers::OCGeom_Curve^ C)
{
  ((GeomLProp_CLProps*)nativeHandle)->SetCurve(*((Handle_Geom_Curve*)C->Handle));
}

OCgp_Pnt^ OCGeomLProp_CLProps::Value()
{
  gp_Pnt* tmp = new gp_Pnt();
  *tmp = ((GeomLProp_CLProps*)nativeHandle)->Value();
  return gcnew OCgp_Pnt(tmp);
}

OCgp_Vec^ OCGeomLProp_CLProps::D1()
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = ((GeomLProp_CLProps*)nativeHandle)->D1();
  return gcnew OCgp_Vec(tmp);
}

OCgp_Vec^ OCGeomLProp_CLProps::D2()
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = ((GeomLProp_CLProps*)nativeHandle)->D2();
  return gcnew OCgp_Vec(tmp);
}

OCgp_Vec^ OCGeomLProp_CLProps::D3()
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = ((GeomLProp_CLProps*)nativeHandle)->D3();
  return gcnew OCgp_Vec(tmp);
}

 System::Boolean OCGeomLProp_CLProps::IsTangentDefined()
{
  return OCConverter::StandardBooleanToBoolean(((GeomLProp_CLProps*)nativeHandle)->IsTangentDefined());
}

 void OCGeomLProp_CLProps::Tangent(OCNaroWrappers::OCgp_Dir^ D)
{
  ((GeomLProp_CLProps*)nativeHandle)->Tangent(*((gp_Dir*)D->Handle));
}

 Standard_Real OCGeomLProp_CLProps::Curvature()
{
  return ((GeomLProp_CLProps*)nativeHandle)->Curvature();
}

 void OCGeomLProp_CLProps::Normal(OCNaroWrappers::OCgp_Dir^ N)
{
  ((GeomLProp_CLProps*)nativeHandle)->Normal(*((gp_Dir*)N->Handle));
}

 void OCGeomLProp_CLProps::CentreOfCurvature(OCNaroWrappers::OCgp_Pnt^ P)
{
  ((GeomLProp_CLProps*)nativeHandle)->CentreOfCurvature(*((gp_Pnt*)P->Handle));
}


