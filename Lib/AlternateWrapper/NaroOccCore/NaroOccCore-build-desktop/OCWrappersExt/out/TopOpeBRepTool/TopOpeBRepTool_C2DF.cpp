// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepTool_C2DF.h"
#include "../Converter.h"
#include "../Geom2d/Geom2d_Curve.h"
#include "../TopoDS/TopoDS_Face.h"


using namespace OCNaroWrappers;

OCTopOpeBRepTool_C2DF::OCTopOpeBRepTool_C2DF(TopOpeBRepTool_C2DF* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTopOpeBRepTool_C2DF::OCTopOpeBRepTool_C2DF() 
{
  nativeHandle = new TopOpeBRepTool_C2DF();
}

OCTopOpeBRepTool_C2DF::OCTopOpeBRepTool_C2DF(OCNaroWrappers::OCGeom2d_Curve^ PC, Standard_Real f2d, Standard_Real l2d, Standard_Real tol, OCNaroWrappers::OCTopoDS_Face^ F) 
{
  nativeHandle = new TopOpeBRepTool_C2DF(*((Handle_Geom2d_Curve*)PC->Handle), f2d, l2d, tol, *((TopoDS_Face*)F->Handle));
}

 void OCTopOpeBRepTool_C2DF::SetPC(OCNaroWrappers::OCGeom2d_Curve^ PC, Standard_Real f2d, Standard_Real l2d, Standard_Real tol)
{
  ((TopOpeBRepTool_C2DF*)nativeHandle)->SetPC(*((Handle_Geom2d_Curve*)PC->Handle), f2d, l2d, tol);
}

 void OCTopOpeBRepTool_C2DF::SetFace(OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((TopOpeBRepTool_C2DF*)nativeHandle)->SetFace(*((TopoDS_Face*)F->Handle));
}

OCGeom2d_Curve^ OCTopOpeBRepTool_C2DF::PC(Standard_Real& f2d, Standard_Real& l2d, Standard_Real& tol)
{
  Handle(Geom2d_Curve) tmp = ((TopOpeBRepTool_C2DF*)nativeHandle)->PC(f2d, l2d, tol);
  return gcnew OCGeom2d_Curve(&tmp);
}

OCTopoDS_Face^ OCTopOpeBRepTool_C2DF::Face()
{
  TopoDS_Face* tmp = new TopoDS_Face();
  *tmp = ((TopOpeBRepTool_C2DF*)nativeHandle)->Face();
  return gcnew OCTopoDS_Face(tmp);
}

 System::Boolean OCTopOpeBRepTool_C2DF::IsPC(OCNaroWrappers::OCGeom2d_Curve^ PC)
{
  return OCConverter::StandardBooleanToBoolean(((TopOpeBRepTool_C2DF*)nativeHandle)->IsPC(*((Handle_Geom2d_Curve*)PC->Handle)));
}

 System::Boolean OCTopOpeBRepTool_C2DF::IsFace(OCNaroWrappers::OCTopoDS_Face^ F)
{
  return OCConverter::StandardBooleanToBoolean(((TopOpeBRepTool_C2DF*)nativeHandle)->IsFace(*((TopoDS_Face*)F->Handle)));
}


