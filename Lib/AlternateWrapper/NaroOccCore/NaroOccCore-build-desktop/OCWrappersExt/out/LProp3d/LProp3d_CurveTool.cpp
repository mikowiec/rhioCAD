// File generated by CPPExt (CPP file)
//

#include "LProp3d_CurveTool.h"
#include "../Converter.h"
#include "../Adaptor3d/Adaptor3d_HCurve.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Vec.h"


using namespace OCNaroWrappers;

OCLProp3d_CurveTool::OCLProp3d_CurveTool(LProp3d_CurveTool* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 void OCLProp3d_CurveTool::Value(OCNaroWrappers::OCAdaptor3d_HCurve^ C, Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P)
{
  LProp3d_CurveTool::Value(*((Handle_Adaptor3d_HCurve*)C->Handle), U, *((gp_Pnt*)P->Handle));
}

 void OCLProp3d_CurveTool::D1(OCNaroWrappers::OCAdaptor3d_HCurve^ C, Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1)
{
  LProp3d_CurveTool::D1(*((Handle_Adaptor3d_HCurve*)C->Handle), U, *((gp_Pnt*)P->Handle), *((gp_Vec*)V1->Handle));
}

 void OCLProp3d_CurveTool::D2(OCNaroWrappers::OCAdaptor3d_HCurve^ C, Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2)
{
  LProp3d_CurveTool::D2(*((Handle_Adaptor3d_HCurve*)C->Handle), U, *((gp_Pnt*)P->Handle), *((gp_Vec*)V1->Handle), *((gp_Vec*)V2->Handle));
}

 void OCLProp3d_CurveTool::D3(OCNaroWrappers::OCAdaptor3d_HCurve^ C, Standard_Real U, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V1, OCNaroWrappers::OCgp_Vec^ V2, OCNaroWrappers::OCgp_Vec^ V3)
{
  LProp3d_CurveTool::D3(*((Handle_Adaptor3d_HCurve*)C->Handle), U, *((gp_Pnt*)P->Handle), *((gp_Vec*)V1->Handle), *((gp_Vec*)V2->Handle), *((gp_Vec*)V3->Handle));
}

 Standard_Integer OCLProp3d_CurveTool::Continuity(OCNaroWrappers::OCAdaptor3d_HCurve^ C)
{
  return LProp3d_CurveTool::Continuity(*((Handle_Adaptor3d_HCurve*)C->Handle));
}

 Standard_Real OCLProp3d_CurveTool::FirstParameter(OCNaroWrappers::OCAdaptor3d_HCurve^ C)
{
  return LProp3d_CurveTool::FirstParameter(*((Handle_Adaptor3d_HCurve*)C->Handle));
}

 Standard_Real OCLProp3d_CurveTool::LastParameter(OCNaroWrappers::OCAdaptor3d_HCurve^ C)
{
  return LProp3d_CurveTool::LastParameter(*((Handle_Adaptor3d_HCurve*)C->Handle));
}


