// File generated by CPPExt (CPP file)
//

#include "IntSurf_QuadricTool.h"
#include "../Converter.h"
#include "IntSurf_Quadric.h"
#include "../gp/gp_Vec.h"


using namespace OCNaroWrappers;

OCIntSurf_QuadricTool::OCIntSurf_QuadricTool(IntSurf_QuadricTool* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 Standard_Real OCIntSurf_QuadricTool::Value(OCNaroWrappers::OCIntSurf_Quadric^ Quad, Standard_Real X, Standard_Real Y, Standard_Real Z)
{
  return IntSurf_QuadricTool::Value(*((IntSurf_Quadric*)Quad->Handle), X, Y, Z);
}

 void OCIntSurf_QuadricTool::Gradient(OCNaroWrappers::OCIntSurf_Quadric^ Quad, Standard_Real X, Standard_Real Y, Standard_Real Z, OCNaroWrappers::OCgp_Vec^ V)
{
  IntSurf_QuadricTool::Gradient(*((IntSurf_Quadric*)Quad->Handle), X, Y, Z, *((gp_Vec*)V->Handle));
}

 void OCIntSurf_QuadricTool::ValueAndGradient(OCNaroWrappers::OCIntSurf_Quadric^ Quad, Standard_Real X, Standard_Real Y, Standard_Real Z, Standard_Real& Val, OCNaroWrappers::OCgp_Vec^ Grad)
{
  IntSurf_QuadricTool::ValueAndGradient(*((IntSurf_Quadric*)Quad->Handle), X, Y, Z, Val, *((gp_Vec*)Grad->Handle));
}

 Standard_Real OCIntSurf_QuadricTool::Tolerance(OCNaroWrappers::OCIntSurf_Quadric^ Quad)
{
  return IntSurf_QuadricTool::Tolerance(*((IntSurf_Quadric*)Quad->Handle));
}


