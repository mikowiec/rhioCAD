// File generated by CPPExt (CPP file)
//

#include "BRepBuilderAPI_MakeFace.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Face.h"
#include "../gp/gp_Pln.h"
#include "../gp/gp_Cylinder.h"
#include "../gp/gp_Cone.h"
#include "../gp/gp_Sphere.h"
#include "../gp/gp_Torus.h"
#include "../Geom/Geom_Surface.h"
#include "../TopoDS/TopoDS_Wire.h"


using namespace OCNaroWrappers;

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(BRepBuilderAPI_MakeFace* nativeHandle) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace() : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace();
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCTopoDS_Face^ F) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((TopoDS_Face*)F->Handle));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Pln^ P) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Pln*)P->Handle));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Cylinder^ C) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Cylinder*)C->Handle));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Cone^ C) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Cone*)C->Handle));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Sphere^ S) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Sphere*)S->Handle));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Torus^ C) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Torus*)C->Handle));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCGeom_Surface^ S, Standard_Real TolDegen) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((Handle_Geom_Surface*)S->Handle), TolDegen);
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Pln^ P, Standard_Real UMin, Standard_Real UMax, Standard_Real VMin, Standard_Real VMax) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Pln*)P->Handle), UMin, UMax, VMin, VMax);
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Cylinder^ C, Standard_Real UMin, Standard_Real UMax, Standard_Real VMin, Standard_Real VMax) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Cylinder*)C->Handle), UMin, UMax, VMin, VMax);
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Cone^ C, Standard_Real UMin, Standard_Real UMax, Standard_Real VMin, Standard_Real VMax) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Cone*)C->Handle), UMin, UMax, VMin, VMax);
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Sphere^ S, Standard_Real UMin, Standard_Real UMax, Standard_Real VMin, Standard_Real VMax) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Sphere*)S->Handle), UMin, UMax, VMin, VMax);
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Torus^ C, Standard_Real UMin, Standard_Real UMax, Standard_Real VMin, Standard_Real VMax) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Torus*)C->Handle), UMin, UMax, VMin, VMax);
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCGeom_Surface^ S, Standard_Real UMin, Standard_Real UMax, Standard_Real VMin, Standard_Real VMax, Standard_Real TolDegen) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((Handle_Geom_Surface*)S->Handle), UMin, UMax, VMin, VMax, TolDegen);
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCTopoDS_Wire^ W, System::Boolean OnlyPlane) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((TopoDS_Wire*)W->Handle), OCConverter::BooleanToStandardBoolean(OnlyPlane));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Pln^ P, OCNaroWrappers::OCTopoDS_Wire^ W, System::Boolean Inside) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Pln*)P->Handle), *((TopoDS_Wire*)W->Handle), OCConverter::BooleanToStandardBoolean(Inside));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Cylinder^ C, OCNaroWrappers::OCTopoDS_Wire^ W, System::Boolean Inside) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Cylinder*)C->Handle), *((TopoDS_Wire*)W->Handle), OCConverter::BooleanToStandardBoolean(Inside));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Cone^ C, OCNaroWrappers::OCTopoDS_Wire^ W, System::Boolean Inside) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Cone*)C->Handle), *((TopoDS_Wire*)W->Handle), OCConverter::BooleanToStandardBoolean(Inside));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Sphere^ S, OCNaroWrappers::OCTopoDS_Wire^ W, System::Boolean Inside) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Sphere*)S->Handle), *((TopoDS_Wire*)W->Handle), OCConverter::BooleanToStandardBoolean(Inside));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCgp_Torus^ C, OCNaroWrappers::OCTopoDS_Wire^ W, System::Boolean Inside) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((gp_Torus*)C->Handle), *((TopoDS_Wire*)W->Handle), OCConverter::BooleanToStandardBoolean(Inside));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopoDS_Wire^ W, System::Boolean Inside) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((Handle_Geom_Surface*)S->Handle), *((TopoDS_Wire*)W->Handle), OCConverter::BooleanToStandardBoolean(Inside));
}

OCBRepBuilderAPI_MakeFace::OCBRepBuilderAPI_MakeFace(OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCTopoDS_Wire^ W) : OCBRepBuilderAPI_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepBuilderAPI_MakeFace(*((TopoDS_Face*)F->Handle), *((TopoDS_Wire*)W->Handle));
}

 void OCBRepBuilderAPI_MakeFace::Init(OCNaroWrappers::OCTopoDS_Face^ F)
{
  ((BRepBuilderAPI_MakeFace*)nativeHandle)->Init(*((TopoDS_Face*)F->Handle));
}

 void OCBRepBuilderAPI_MakeFace::Init(OCNaroWrappers::OCGeom_Surface^ S, System::Boolean Bound, Standard_Real TolDegen)
{
  ((BRepBuilderAPI_MakeFace*)nativeHandle)->Init(*((Handle_Geom_Surface*)S->Handle), OCConverter::BooleanToStandardBoolean(Bound), TolDegen);
}

 void OCBRepBuilderAPI_MakeFace::Init(OCNaroWrappers::OCGeom_Surface^ S, Standard_Real UMin, Standard_Real UMax, Standard_Real VMin, Standard_Real VMax, Standard_Real TolDegen)
{
  ((BRepBuilderAPI_MakeFace*)nativeHandle)->Init(*((Handle_Geom_Surface*)S->Handle), UMin, UMax, VMin, VMax, TolDegen);
}

 void OCBRepBuilderAPI_MakeFace::Add(OCNaroWrappers::OCTopoDS_Wire^ W)
{
  ((BRepBuilderAPI_MakeFace*)nativeHandle)->Add(*((TopoDS_Wire*)W->Handle));
}

 System::Boolean OCBRepBuilderAPI_MakeFace::IsDone()
{
  return OCConverter::StandardBooleanToBoolean(((BRepBuilderAPI_MakeFace*)nativeHandle)->IsDone());
}

 OCBRepBuilderAPI_FaceError OCBRepBuilderAPI_MakeFace::Error()
{
  return (OCBRepBuilderAPI_FaceError)(((BRepBuilderAPI_MakeFace*)nativeHandle)->Error());
}

OCTopoDS_Face^ OCBRepBuilderAPI_MakeFace::Face()
{
  TopoDS_Face* tmp = new TopoDS_Face();
  *tmp = ((BRepBuilderAPI_MakeFace*)nativeHandle)->Face();
  return gcnew OCTopoDS_Face(tmp);
}


