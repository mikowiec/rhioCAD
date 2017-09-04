// File generated by CPPExt (CPP file)
//

#include "BRepAlgo_Section.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../gp/gp_Pln.h"
#include "../Geom/Geom_Surface.h"
#include "../Geom2d/Geom2d_Curve.h"


using namespace OCNaroWrappers;

OCBRepAlgo_Section::OCBRepAlgo_Section(BRepAlgo_Section* nativeHandle) : OCBRepAlgo_BooleanOperation((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBRepAlgo_Section::OCBRepAlgo_Section(OCNaroWrappers::OCTopoDS_Shape^ Sh1, OCNaroWrappers::OCTopoDS_Shape^ Sh2, System::Boolean PerformNow) : OCBRepAlgo_BooleanOperation((OCDummy^)nullptr)

{
  nativeHandle = new BRepAlgo_Section(*((TopoDS_Shape*)Sh1->Handle), *((TopoDS_Shape*)Sh2->Handle), OCConverter::BooleanToStandardBoolean(PerformNow));
}

OCBRepAlgo_Section::OCBRepAlgo_Section(OCNaroWrappers::OCTopoDS_Shape^ Sh, OCNaroWrappers::OCgp_Pln^ Pl, System::Boolean PerformNow) : OCBRepAlgo_BooleanOperation((OCDummy^)nullptr)

{
  nativeHandle = new BRepAlgo_Section(*((TopoDS_Shape*)Sh->Handle), *((gp_Pln*)Pl->Handle), OCConverter::BooleanToStandardBoolean(PerformNow));
}

OCBRepAlgo_Section::OCBRepAlgo_Section(OCNaroWrappers::OCTopoDS_Shape^ Sh, OCNaroWrappers::OCGeom_Surface^ Sf, System::Boolean PerformNow) : OCBRepAlgo_BooleanOperation((OCDummy^)nullptr)

{
  nativeHandle = new BRepAlgo_Section(*((TopoDS_Shape*)Sh->Handle), *((Handle_Geom_Surface*)Sf->Handle), OCConverter::BooleanToStandardBoolean(PerformNow));
}

OCBRepAlgo_Section::OCBRepAlgo_Section(OCNaroWrappers::OCGeom_Surface^ Sf, OCNaroWrappers::OCTopoDS_Shape^ Sh, System::Boolean PerformNow) : OCBRepAlgo_BooleanOperation((OCDummy^)nullptr)

{
  nativeHandle = new BRepAlgo_Section(*((Handle_Geom_Surface*)Sf->Handle), *((TopoDS_Shape*)Sh->Handle), OCConverter::BooleanToStandardBoolean(PerformNow));
}

OCBRepAlgo_Section::OCBRepAlgo_Section(OCNaroWrappers::OCGeom_Surface^ Sf1, OCNaroWrappers::OCGeom_Surface^ Sf2, System::Boolean PerformNow) : OCBRepAlgo_BooleanOperation((OCDummy^)nullptr)

{
  nativeHandle = new BRepAlgo_Section(*((Handle_Geom_Surface*)Sf1->Handle), *((Handle_Geom_Surface*)Sf2->Handle), OCConverter::BooleanToStandardBoolean(PerformNow));
}

 void OCBRepAlgo_Section::Init1(OCNaroWrappers::OCTopoDS_Shape^ S1)
{
  ((BRepAlgo_Section*)nativeHandle)->Init1(*((TopoDS_Shape*)S1->Handle));
}

 void OCBRepAlgo_Section::Init1(OCNaroWrappers::OCgp_Pln^ Pl)
{
  ((BRepAlgo_Section*)nativeHandle)->Init1(*((gp_Pln*)Pl->Handle));
}

 void OCBRepAlgo_Section::Init1(OCNaroWrappers::OCGeom_Surface^ Sf)
{
  ((BRepAlgo_Section*)nativeHandle)->Init1(*((Handle_Geom_Surface*)Sf->Handle));
}

 void OCBRepAlgo_Section::Init2(OCNaroWrappers::OCTopoDS_Shape^ S2)
{
  ((BRepAlgo_Section*)nativeHandle)->Init2(*((TopoDS_Shape*)S2->Handle));
}

 void OCBRepAlgo_Section::Init2(OCNaroWrappers::OCgp_Pln^ Pl)
{
  ((BRepAlgo_Section*)nativeHandle)->Init2(*((gp_Pln*)Pl->Handle));
}

 void OCBRepAlgo_Section::Init2(OCNaroWrappers::OCGeom_Surface^ Sf)
{
  ((BRepAlgo_Section*)nativeHandle)->Init2(*((Handle_Geom_Surface*)Sf->Handle));
}

 void OCBRepAlgo_Section::Approximation(System::Boolean B)
{
  ((BRepAlgo_Section*)nativeHandle)->Approximation(OCConverter::BooleanToStandardBoolean(B));
}

 void OCBRepAlgo_Section::ComputePCurveOn1(System::Boolean B)
{
  ((BRepAlgo_Section*)nativeHandle)->ComputePCurveOn1(OCConverter::BooleanToStandardBoolean(B));
}

 void OCBRepAlgo_Section::ComputePCurveOn2(System::Boolean B)
{
  ((BRepAlgo_Section*)nativeHandle)->ComputePCurveOn2(OCConverter::BooleanToStandardBoolean(B));
}

 void OCBRepAlgo_Section::Build()
{
  ((BRepAlgo_Section*)nativeHandle)->Build();
}

 System::Boolean OCBRepAlgo_Section::HasAncestorFaceOn1(OCNaroWrappers::OCTopoDS_Shape^ E, OCNaroWrappers::OCTopoDS_Shape^ F)
{
  return OCConverter::StandardBooleanToBoolean(((BRepAlgo_Section*)nativeHandle)->HasAncestorFaceOn1(*((TopoDS_Shape*)E->Handle), *((TopoDS_Shape*)F->Handle)));
}

 System::Boolean OCBRepAlgo_Section::HasAncestorFaceOn2(OCNaroWrappers::OCTopoDS_Shape^ E, OCNaroWrappers::OCTopoDS_Shape^ F)
{
  return OCConverter::StandardBooleanToBoolean(((BRepAlgo_Section*)nativeHandle)->HasAncestorFaceOn2(*((TopoDS_Shape*)E->Handle), *((TopoDS_Shape*)F->Handle)));
}

OCGeom2d_Curve^ OCBRepAlgo_Section::PCurveOn1(OCNaroWrappers::OCTopoDS_Shape^ E)
{
  Handle(Geom2d_Curve) tmp = ((BRepAlgo_Section*)nativeHandle)->PCurveOn1(*((TopoDS_Shape*)E->Handle));
  return gcnew OCGeom2d_Curve(&tmp);
}

OCGeom2d_Curve^ OCBRepAlgo_Section::PCurveOn2(OCNaroWrappers::OCTopoDS_Shape^ E)
{
  Handle(Geom2d_Curve) tmp = ((BRepAlgo_Section*)nativeHandle)->PCurveOn2(*((TopoDS_Shape*)E->Handle));
  return gcnew OCGeom2d_Curve(&tmp);
}


