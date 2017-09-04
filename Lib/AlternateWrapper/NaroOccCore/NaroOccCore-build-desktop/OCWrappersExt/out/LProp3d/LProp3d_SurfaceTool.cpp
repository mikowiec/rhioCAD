// File generated by CPPExt (CPP file)
//

#include "LProp3d_SurfaceTool.h"
#include "../Converter.h"
#include "../Adaptor3d/Adaptor3d_HSurface.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Vec.h"


using namespace OCNaroWrappers;

OCLProp3d_SurfaceTool::OCLProp3d_SurfaceTool(LProp3d_SurfaceTool* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 void OCLProp3d_SurfaceTool::Value(OCNaroWrappers::OCAdaptor3d_HSurface^ S, Standard_Real U, Standard_Real V, OCNaroWrappers::OCgp_Pnt^ P)
{
  LProp3d_SurfaceTool::Value(*((Handle_Adaptor3d_HSurface*)S->Handle), U, V, *((gp_Pnt*)P->Handle));
}

 void OCLProp3d_SurfaceTool::D1(OCNaroWrappers::OCAdaptor3d_HSurface^ S, Standard_Real U, Standard_Real V, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ D1U, OCNaroWrappers::OCgp_Vec^ D1V)
{
  LProp3d_SurfaceTool::D1(*((Handle_Adaptor3d_HSurface*)S->Handle), U, V, *((gp_Pnt*)P->Handle), *((gp_Vec*)D1U->Handle), *((gp_Vec*)D1V->Handle));
}

 void OCLProp3d_SurfaceTool::D2(OCNaroWrappers::OCAdaptor3d_HSurface^ S, Standard_Real U, Standard_Real V, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ D1U, OCNaroWrappers::OCgp_Vec^ D1V, OCNaroWrappers::OCgp_Vec^ D2U, OCNaroWrappers::OCgp_Vec^ D2V, OCNaroWrappers::OCgp_Vec^ DUV)
{
  LProp3d_SurfaceTool::D2(*((Handle_Adaptor3d_HSurface*)S->Handle), U, V, *((gp_Pnt*)P->Handle), *((gp_Vec*)D1U->Handle), *((gp_Vec*)D1V->Handle), *((gp_Vec*)D2U->Handle), *((gp_Vec*)D2V->Handle), *((gp_Vec*)DUV->Handle));
}

OCgp_Vec^ OCLProp3d_SurfaceTool::DN(OCNaroWrappers::OCAdaptor3d_HSurface^ S, Standard_Real U, Standard_Real V, Standard_Integer IU, Standard_Integer IV)
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = LProp3d_SurfaceTool::DN(*((Handle_Adaptor3d_HSurface*)S->Handle), U, V, IU, IV);
  return gcnew OCgp_Vec(tmp);
}

 Standard_Integer OCLProp3d_SurfaceTool::Continuity(OCNaroWrappers::OCAdaptor3d_HSurface^ S)
{
  return LProp3d_SurfaceTool::Continuity(*((Handle_Adaptor3d_HSurface*)S->Handle));
}

 void OCLProp3d_SurfaceTool::Bounds(OCNaroWrappers::OCAdaptor3d_HSurface^ S, Standard_Real& U1, Standard_Real& V1, Standard_Real& U2, Standard_Real& V2)
{
  LProp3d_SurfaceTool::Bounds(*((Handle_Adaptor3d_HSurface*)S->Handle), U1, V1, U2, V2);
}


