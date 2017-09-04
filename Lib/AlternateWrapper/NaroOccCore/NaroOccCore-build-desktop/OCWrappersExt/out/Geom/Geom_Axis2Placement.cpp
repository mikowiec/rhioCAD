// File generated by CPPExt (CPP file)
//

#include "Geom_Axis2Placement.h"
#include "../Converter.h"
#include "../gp/gp_Ax2.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Dir.h"
#include "../gp/gp_Trsf.h"
#include "Geom_Geometry.h"


using namespace OCNaroWrappers;

OCGeom_Axis2Placement::OCGeom_Axis2Placement(Handle(Geom_Axis2Placement)* nativeHandle) : OCGeom_AxisPlacement((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Geom_Axis2Placement(*nativeHandle);
}

OCGeom_Axis2Placement::OCGeom_Axis2Placement(OCNaroWrappers::OCgp_Ax2^ A2) : OCGeom_AxisPlacement((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Geom_Axis2Placement(new Geom_Axis2Placement(*((gp_Ax2*)A2->Handle)));
}

OCGeom_Axis2Placement::OCGeom_Axis2Placement(OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Dir^ N, OCNaroWrappers::OCgp_Dir^ Vx) : OCGeom_AxisPlacement((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Geom_Axis2Placement(new Geom_Axis2Placement(*((gp_Pnt*)P->Handle), *((gp_Dir*)N->Handle), *((gp_Dir*)Vx->Handle)));
}

 void OCGeom_Axis2Placement::SetAx2(OCNaroWrappers::OCgp_Ax2^ A2)
{
  (*((Handle_Geom_Axis2Placement*)nativeHandle))->SetAx2(*((gp_Ax2*)A2->Handle));
}

 void OCGeom_Axis2Placement::SetDirection(OCNaroWrappers::OCgp_Dir^ V)
{
  (*((Handle_Geom_Axis2Placement*)nativeHandle))->SetDirection(*((gp_Dir*)V->Handle));
}

 void OCGeom_Axis2Placement::SetXDirection(OCNaroWrappers::OCgp_Dir^ Vx)
{
  (*((Handle_Geom_Axis2Placement*)nativeHandle))->SetXDirection(*((gp_Dir*)Vx->Handle));
}

 void OCGeom_Axis2Placement::SetYDirection(OCNaroWrappers::OCgp_Dir^ Vy)
{
  (*((Handle_Geom_Axis2Placement*)nativeHandle))->SetYDirection(*((gp_Dir*)Vy->Handle));
}

OCgp_Ax2^ OCGeom_Axis2Placement::Ax2()
{
  gp_Ax2* tmp = new gp_Ax2();
  *tmp = (*((Handle_Geom_Axis2Placement*)nativeHandle))->Ax2();
  return gcnew OCgp_Ax2(tmp);
}

OCgp_Dir^ OCGeom_Axis2Placement::XDirection()
{
  gp_Dir* tmp = new gp_Dir();
  *tmp = (*((Handle_Geom_Axis2Placement*)nativeHandle))->XDirection();
  return gcnew OCgp_Dir(tmp);
}

OCgp_Dir^ OCGeom_Axis2Placement::YDirection()
{
  gp_Dir* tmp = new gp_Dir();
  *tmp = (*((Handle_Geom_Axis2Placement*)nativeHandle))->YDirection();
  return gcnew OCgp_Dir(tmp);
}

 void OCGeom_Axis2Placement::Transform(OCNaroWrappers::OCgp_Trsf^ T)
{
  (*((Handle_Geom_Axis2Placement*)nativeHandle))->Transform(*((gp_Trsf*)T->Handle));
}

OCGeom_Geometry^ OCGeom_Axis2Placement::Copy()
{
  Handle(Geom_Geometry) tmp = (*((Handle_Geom_Axis2Placement*)nativeHandle))->Copy();
  return gcnew OCGeom_Geometry(&tmp);
}


