// File generated by CPPExt (CPP file)
//

#include "BRepLib_FindSurface.h"
#include "../Converter.h"
#include "../Geom/Geom_Surface.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopLoc/TopLoc_Location.h"


using namespace OCNaroWrappers;

OCBRepLib_FindSurface::OCBRepLib_FindSurface(BRepLib_FindSurface* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCBRepLib_FindSurface::OCBRepLib_FindSurface() 
{
  nativeHandle = new BRepLib_FindSurface();
}

OCBRepLib_FindSurface::OCBRepLib_FindSurface(OCNaroWrappers::OCTopoDS_Shape^ S, Standard_Real Tol, System::Boolean OnlyPlane, System::Boolean OnlyClosed) 
{
  nativeHandle = new BRepLib_FindSurface(*((TopoDS_Shape*)S->Handle), Tol, OCConverter::BooleanToStandardBoolean(OnlyPlane), OCConverter::BooleanToStandardBoolean(OnlyClosed));
}

 void OCBRepLib_FindSurface::Init(OCNaroWrappers::OCTopoDS_Shape^ S, Standard_Real Tol, System::Boolean OnlyPlane, System::Boolean OnlyClosed)
{
  ((BRepLib_FindSurface*)nativeHandle)->Init(*((TopoDS_Shape*)S->Handle), Tol, OCConverter::BooleanToStandardBoolean(OnlyPlane), OCConverter::BooleanToStandardBoolean(OnlyClosed));
}

 System::Boolean OCBRepLib_FindSurface::Found()
{
  return OCConverter::StandardBooleanToBoolean(((BRepLib_FindSurface*)nativeHandle)->Found());
}

OCGeom_Surface^ OCBRepLib_FindSurface::Surface()
{
  Handle(Geom_Surface) tmp = ((BRepLib_FindSurface*)nativeHandle)->Surface();
  return gcnew OCGeom_Surface(&tmp);
}

 Standard_Real OCBRepLib_FindSurface::Tolerance()
{
  return ((BRepLib_FindSurface*)nativeHandle)->Tolerance();
}

 Standard_Real OCBRepLib_FindSurface::ToleranceReached()
{
  return ((BRepLib_FindSurface*)nativeHandle)->ToleranceReached();
}

 System::Boolean OCBRepLib_FindSurface::Existed()
{
  return OCConverter::StandardBooleanToBoolean(((BRepLib_FindSurface*)nativeHandle)->Existed());
}

OCTopLoc_Location^ OCBRepLib_FindSurface::Location()
{
  TopLoc_Location* tmp = new TopLoc_Location();
  *tmp = ((BRepLib_FindSurface*)nativeHandle)->Location();
  return gcnew OCTopLoc_Location(tmp);
}


