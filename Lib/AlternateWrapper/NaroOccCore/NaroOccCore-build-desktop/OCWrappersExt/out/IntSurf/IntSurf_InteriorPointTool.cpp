// File generated by CPPExt (CPP file)
//

#include "IntSurf_InteriorPointTool.h"
#include "../Converter.h"
#include "IntSurf_InteriorPoint.h"


using namespace OCNaroWrappers;

OCIntSurf_InteriorPointTool::OCIntSurf_InteriorPointTool(IntSurf_InteriorPointTool* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCgp_Pnt^ OCIntSurf_InteriorPointTool::Value3d(OCNaroWrappers::OCIntSurf_InteriorPoint^ PStart)
{
  gp_Pnt* tmp = new gp_Pnt();
  *tmp = IntSurf_InteriorPointTool::Value3d(*((IntSurf_InteriorPoint*)PStart->Handle));
  return gcnew OCgp_Pnt(tmp);
}

 void OCIntSurf_InteriorPointTool::Value2d(OCNaroWrappers::OCIntSurf_InteriorPoint^ PStart, Standard_Real& U, Standard_Real& V)
{
  IntSurf_InteriorPointTool::Value2d(*((IntSurf_InteriorPoint*)PStart->Handle), U, V);
}

OCgp_Vec^ OCIntSurf_InteriorPointTool::Direction3d(OCNaroWrappers::OCIntSurf_InteriorPoint^ PStart)
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = IntSurf_InteriorPointTool::Direction3d(*((IntSurf_InteriorPoint*)PStart->Handle));
  return gcnew OCgp_Vec(tmp);
}

OCgp_Dir2d^ OCIntSurf_InteriorPointTool::Direction2d(OCNaroWrappers::OCIntSurf_InteriorPoint^ PStart)
{
  gp_Dir2d* tmp = new gp_Dir2d();
  *tmp = IntSurf_InteriorPointTool::Direction2d(*((IntSurf_InteriorPoint*)PStart->Handle));
  return gcnew OCgp_Dir2d(tmp);
}


