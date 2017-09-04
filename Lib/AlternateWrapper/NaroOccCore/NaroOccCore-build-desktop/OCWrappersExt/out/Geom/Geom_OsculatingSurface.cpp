// File generated by CPPExt (CPP file)
//

#include "Geom_OsculatingSurface.h"
#include "../Converter.h"
#include "Geom_Surface.h"
#include "Geom_HSequenceOfBSplineSurface.h"
#include "../TColStd/TColStd_HSequenceOfInteger.h"
#include "Geom_BSplineSurface.h"
#include "Geom_SequenceOfBSplineSurface.h"


using namespace OCNaroWrappers;

OCGeom_OsculatingSurface::OCGeom_OsculatingSurface(Geom_OsculatingSurface* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCGeom_OsculatingSurface::OCGeom_OsculatingSurface() 
{
  nativeHandle = new Geom_OsculatingSurface();
}

OCGeom_OsculatingSurface::OCGeom_OsculatingSurface(OCNaroWrappers::OCGeom_Surface^ BS, Standard_Real Tol) 
{
  nativeHandle = new Geom_OsculatingSurface(*((Handle_Geom_Surface*)BS->Handle), Tol);
}

 void OCGeom_OsculatingSurface::Init(OCNaroWrappers::OCGeom_Surface^ BS, Standard_Real Tol)
{
  ((Geom_OsculatingSurface*)nativeHandle)->Init(*((Handle_Geom_Surface*)BS->Handle), Tol);
}

OCGeom_Surface^ OCGeom_OsculatingSurface::BasisSurface()
{
  Handle(Geom_Surface) tmp = ((Geom_OsculatingSurface*)nativeHandle)->BasisSurface();
  return gcnew OCGeom_Surface(&tmp);
}

 Standard_Real OCGeom_OsculatingSurface::Tolerance()
{
  return ((Geom_OsculatingSurface*)nativeHandle)->Tolerance();
}

 System::Boolean OCGeom_OsculatingSurface::UOscSurf(Standard_Real U, Standard_Real V, System::Boolean& t, OCNaroWrappers::OCGeom_BSplineSurface^ L)
{
  return OCConverter::StandardBooleanToBoolean(((Geom_OsculatingSurface*)nativeHandle)->UOscSurf(U, V, (Standard_Boolean&)(t), *((Handle_Geom_BSplineSurface*)L->Handle)));
}

 System::Boolean OCGeom_OsculatingSurface::VOscSurf(Standard_Real U, Standard_Real V, System::Boolean& t, OCNaroWrappers::OCGeom_BSplineSurface^ L)
{
  return OCConverter::StandardBooleanToBoolean(((Geom_OsculatingSurface*)nativeHandle)->VOscSurf(U, V, (Standard_Boolean&)(t), *((Handle_Geom_BSplineSurface*)L->Handle)));
}


