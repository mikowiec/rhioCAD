// File generated by CPPExt (CPP file)
//

#include "GeomConvert_BSplineCurveToBezierCurve.h"
#include "../Converter.h"
#include "../Geom/Geom_BSplineCurve.h"
#include "../Geom/Geom_BezierCurve.h"
#include "../TColGeom/TColGeom_Array1OfBezierCurve.h"
#include "../TColStd/TColStd_Array1OfReal.h"


using namespace OCNaroWrappers;

OCGeomConvert_BSplineCurveToBezierCurve::OCGeomConvert_BSplineCurveToBezierCurve(GeomConvert_BSplineCurveToBezierCurve* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCGeomConvert_BSplineCurveToBezierCurve::OCGeomConvert_BSplineCurveToBezierCurve(OCNaroWrappers::OCGeom_BSplineCurve^ BasisCurve) 
{
  nativeHandle = new GeomConvert_BSplineCurveToBezierCurve(*((Handle_Geom_BSplineCurve*)BasisCurve->Handle));
}

OCGeomConvert_BSplineCurveToBezierCurve::OCGeomConvert_BSplineCurveToBezierCurve(OCNaroWrappers::OCGeom_BSplineCurve^ BasisCurve, Standard_Real U1, Standard_Real U2, Standard_Real ParametricTolerance) 
{
  nativeHandle = new GeomConvert_BSplineCurveToBezierCurve(*((Handle_Geom_BSplineCurve*)BasisCurve->Handle), U1, U2, ParametricTolerance);
}

OCGeom_BezierCurve^ OCGeomConvert_BSplineCurveToBezierCurve::Arc(Standard_Integer Index)
{
  Handle(Geom_BezierCurve) tmp = ((GeomConvert_BSplineCurveToBezierCurve*)nativeHandle)->Arc(Index);
  return gcnew OCGeom_BezierCurve(&tmp);
}

 void OCGeomConvert_BSplineCurveToBezierCurve::Arcs(OCNaroWrappers::OCTColGeom_Array1OfBezierCurve^ Curves)
{
  ((GeomConvert_BSplineCurveToBezierCurve*)nativeHandle)->Arcs(*((TColGeom_Array1OfBezierCurve*)Curves->Handle));
}

 void OCGeomConvert_BSplineCurveToBezierCurve::Knots(OCNaroWrappers::OCTColStd_Array1OfReal^ TKnots)
{
  ((GeomConvert_BSplineCurveToBezierCurve*)nativeHandle)->Knots(*((TColStd_Array1OfReal*)TKnots->Handle));
}

 Standard_Integer OCGeomConvert_BSplineCurveToBezierCurve::NbArcs()
{
  return ((GeomConvert_BSplineCurveToBezierCurve*)nativeHandle)->NbArcs();
}


