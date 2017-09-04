// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepTool_ShapeTool.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../gp/gp_Pnt.h"
#include "../Geom/Geom_Curve.h"
#include "../TopoDS/TopoDS_Edge.h"
#include "../Geom/Geom_Surface.h"
#include "../TopoDS/TopoDS_Face.h"
#include "../BRepAdaptor/BRepAdaptor_Surface.h"
#include "../BRepAdaptor/BRepAdaptor_Curve.h"
#include "../gp/gp_Dir.h"


using namespace OCNaroWrappers;

OCTopOpeBRepTool_ShapeTool::OCTopOpeBRepTool_ShapeTool(TopOpeBRepTool_ShapeTool* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::Tolerance(OCNaroWrappers::OCTopoDS_Shape^ S)
{
  return TopOpeBRepTool_ShapeTool::Tolerance(*((TopoDS_Shape*)S->Handle));
}

OCgp_Pnt^ OCTopOpeBRepTool_ShapeTool::Pnt(OCNaroWrappers::OCTopoDS_Shape^ S)
{
  gp_Pnt* tmp = new gp_Pnt();
  *tmp = TopOpeBRepTool_ShapeTool::Pnt(*((TopoDS_Shape*)S->Handle));
  return gcnew OCgp_Pnt(tmp);
}

OCGeom_Curve^ OCTopOpeBRepTool_ShapeTool::BASISCURVE(OCNaroWrappers::OCGeom_Curve^ C)
{
  Handle(Geom_Curve) tmp = TopOpeBRepTool_ShapeTool::BASISCURVE(*((Handle_Geom_Curve*)C->Handle));
  return gcnew OCGeom_Curve(&tmp);
}

OCGeom_Curve^ OCTopOpeBRepTool_ShapeTool::BASISCURVE(OCNaroWrappers::OCTopoDS_Edge^ E)
{
  Handle(Geom_Curve) tmp = TopOpeBRepTool_ShapeTool::BASISCURVE(*((TopoDS_Edge*)E->Handle));
  return gcnew OCGeom_Curve(&tmp);
}

OCGeom_Surface^ OCTopOpeBRepTool_ShapeTool::BASISSURFACE(OCNaroWrappers::OCGeom_Surface^ S)
{
  Handle(Geom_Surface) tmp = TopOpeBRepTool_ShapeTool::BASISSURFACE(*((Handle_Geom_Surface*)S->Handle));
  return gcnew OCGeom_Surface(&tmp);
}

OCGeom_Surface^ OCTopOpeBRepTool_ShapeTool::BASISSURFACE(OCNaroWrappers::OCTopoDS_Face^ F)
{
  Handle(Geom_Surface) tmp = TopOpeBRepTool_ShapeTool::BASISSURFACE(*((TopoDS_Face*)F->Handle));
  return gcnew OCGeom_Surface(&tmp);
}

 void OCTopOpeBRepTool_ShapeTool::UVBOUNDS(OCNaroWrappers::OCGeom_Surface^ S, System::Boolean& UPeri, System::Boolean& VPeri, Standard_Real& Umin, Standard_Real& Umax, Standard_Real& Vmin, Standard_Real& Vmax)
{
  TopOpeBRepTool_ShapeTool::UVBOUNDS(*((Handle_Geom_Surface*)S->Handle), (Standard_Boolean&)(UPeri), (Standard_Boolean&)(VPeri), Umin, Umax, Vmin, Vmax);
}

 void OCTopOpeBRepTool_ShapeTool::UVBOUNDS(OCNaroWrappers::OCTopoDS_Face^ F, System::Boolean& UPeri, System::Boolean& VPeri, Standard_Real& Umin, Standard_Real& Umax, Standard_Real& Vmin, Standard_Real& Vmax)
{
  TopOpeBRepTool_ShapeTool::UVBOUNDS(*((TopoDS_Face*)F->Handle), (Standard_Boolean&)(UPeri), (Standard_Boolean&)(VPeri), Umin, Umax, Vmin, Vmax);
}

 void OCTopOpeBRepTool_ShapeTool::AdjustOnPeriodic(OCNaroWrappers::OCTopoDS_Shape^ S, Standard_Real& u, Standard_Real& v)
{
  TopOpeBRepTool_ShapeTool::AdjustOnPeriodic(*((TopoDS_Shape*)S->Handle), u, v);
}

 System::Boolean OCTopOpeBRepTool_ShapeTool::Closed(OCNaroWrappers::OCTopoDS_Shape^ S1, OCNaroWrappers::OCTopoDS_Shape^ S2)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool_ShapeTool::Closed(*((TopoDS_Shape*)S1->Handle), *((TopoDS_Shape*)S2->Handle)));
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::PeriodizeParameter(Standard_Real par, OCNaroWrappers::OCTopoDS_Shape^ EE, OCNaroWrappers::OCTopoDS_Shape^ FF)
{
  return TopOpeBRepTool_ShapeTool::PeriodizeParameter(par, *((TopoDS_Shape*)EE->Handle), *((TopoDS_Shape*)FF->Handle));
}

 System::Boolean OCTopOpeBRepTool_ShapeTool::ShapesSameOriented(OCNaroWrappers::OCTopoDS_Shape^ S1, OCNaroWrappers::OCTopoDS_Shape^ S2)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool_ShapeTool::ShapesSameOriented(*((TopoDS_Shape*)S1->Handle), *((TopoDS_Shape*)S2->Handle)));
}

 System::Boolean OCTopOpeBRepTool_ShapeTool::SurfacesSameOriented(OCNaroWrappers::OCBRepAdaptor_Surface^ S1, OCNaroWrappers::OCBRepAdaptor_Surface^ S2)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool_ShapeTool::SurfacesSameOriented(*((BRepAdaptor_Surface*)S1->Handle), *((BRepAdaptor_Surface*)S2->Handle)));
}

 System::Boolean OCTopOpeBRepTool_ShapeTool::FacesSameOriented(OCNaroWrappers::OCTopoDS_Shape^ F1, OCNaroWrappers::OCTopoDS_Shape^ F2)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool_ShapeTool::FacesSameOriented(*((TopoDS_Shape*)F1->Handle), *((TopoDS_Shape*)F2->Handle)));
}

 System::Boolean OCTopOpeBRepTool_ShapeTool::CurvesSameOriented(OCNaroWrappers::OCBRepAdaptor_Curve^ C1, OCNaroWrappers::OCBRepAdaptor_Curve^ C2)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool_ShapeTool::CurvesSameOriented(*((BRepAdaptor_Curve*)C1->Handle), *((BRepAdaptor_Curve*)C2->Handle)));
}

 System::Boolean OCTopOpeBRepTool_ShapeTool::EdgesSameOriented(OCNaroWrappers::OCTopoDS_Shape^ E1, OCNaroWrappers::OCTopoDS_Shape^ E2)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool_ShapeTool::EdgesSameOriented(*((TopoDS_Shape*)E1->Handle), *((TopoDS_Shape*)E2->Handle)));
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::EdgeData(OCNaroWrappers::OCBRepAdaptor_Curve^ BRAC, Standard_Real P, OCNaroWrappers::OCgp_Dir^ T, OCNaroWrappers::OCgp_Dir^ N, Standard_Real& C)
{
  return TopOpeBRepTool_ShapeTool::EdgeData(*((BRepAdaptor_Curve*)BRAC->Handle), P, *((gp_Dir*)T->Handle), *((gp_Dir*)N->Handle), C);
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::EdgeData(OCNaroWrappers::OCTopoDS_Shape^ E, Standard_Real P, OCNaroWrappers::OCgp_Dir^ T, OCNaroWrappers::OCgp_Dir^ N, Standard_Real& C)
{
  return TopOpeBRepTool_ShapeTool::EdgeData(*((TopoDS_Shape*)E->Handle), P, *((gp_Dir*)T->Handle), *((gp_Dir*)N->Handle), C);
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::Resolution3dU(OCNaroWrappers::OCGeom_Surface^ SU, Standard_Real Tol2d)
{
  return TopOpeBRepTool_ShapeTool::Resolution3dU(*((Handle_Geom_Surface*)SU->Handle), Tol2d);
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::Resolution3dV(OCNaroWrappers::OCGeom_Surface^ SU, Standard_Real Tol2d)
{
  return TopOpeBRepTool_ShapeTool::Resolution3dV(*((Handle_Geom_Surface*)SU->Handle), Tol2d);
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::Resolution3d(OCNaroWrappers::OCGeom_Surface^ SU, Standard_Real Tol2d)
{
  return TopOpeBRepTool_ShapeTool::Resolution3d(*((Handle_Geom_Surface*)SU->Handle), Tol2d);
}

 Standard_Real OCTopOpeBRepTool_ShapeTool::Resolution3d(OCNaroWrappers::OCTopoDS_Face^ F, Standard_Real Tol2d)
{
  return TopOpeBRepTool_ShapeTool::Resolution3d(*((TopoDS_Face*)F->Handle), Tol2d);
}


