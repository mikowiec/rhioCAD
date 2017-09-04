// File generated by CPPExt (CPP file)
//

#include "Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter.h"
#include "../Converter.h"
#include "../Adaptor2d/Adaptor2d_Curve2d.h"
#include "Geom2dInt_Geom2dCurveTool.h"
#include "../IntRes2d/IntRes2d_Domain.h"
#include "../Bnd/Bnd_Box2d.h"
#include "../gp/gp_Pnt2d.h"


using namespace OCNaroWrappers;

OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter(Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter* nativeHandle) : OCIntf_Polygon2d((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter(OCNaroWrappers::OCAdaptor2d_Curve2d^ Curve, Standard_Integer NbPnt, OCNaroWrappers::OCIntRes2d_Domain^ Domain, Standard_Real Tol) : OCIntf_Polygon2d((OCDummy^)nullptr)

{
  nativeHandle = new Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter(*((Adaptor2d_Curve2d*)Curve->Handle), NbPnt, *((IntRes2d_Domain*)Domain->Handle), Tol);
}

OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter(OCNaroWrappers::OCAdaptor2d_Curve2d^ Curve, Standard_Integer NbPnt, OCNaroWrappers::OCIntRes2d_Domain^ Domain, Standard_Real Tol, OCNaroWrappers::OCBnd_Box2d^ OtherBox) : OCIntf_Polygon2d((OCDummy^)nullptr)

{
  nativeHandle = new Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter(*((Adaptor2d_Curve2d*)Curve->Handle), NbPnt, *((IntRes2d_Domain*)Domain->Handle), Tol, *((Bnd_Box2d*)OtherBox->Handle));
}

 void OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::ComputeWithBox(OCNaroWrappers::OCAdaptor2d_Curve2d^ Curve, OCNaroWrappers::OCBnd_Box2d^ OtherBox)
{
  ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->ComputeWithBox(*((Adaptor2d_Curve2d*)Curve->Handle), *((Bnd_Box2d*)OtherBox->Handle));
}

 Standard_Real OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::DeflectionOverEstimation()
{
  return ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->DeflectionOverEstimation();
}

 void OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::SetDeflectionOverEstimation(Standard_Real x)
{
  ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->SetDeflectionOverEstimation(x);
}

 void OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::Closed(System::Boolean clos)
{
  ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->Closed(OCConverter::BooleanToStandardBoolean(clos));
}

 Standard_Integer OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::NbSegments()
{
  return ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->NbSegments();
}

 void OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::Segment(Standard_Integer theIndex, OCNaroWrappers::OCgp_Pnt2d^ theBegin, OCNaroWrappers::OCgp_Pnt2d^ theEnd)
{
  ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->Segment(theIndex, *((gp_Pnt2d*)theBegin->Handle), *((gp_Pnt2d*)theEnd->Handle));
}

 Standard_Real OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::InfParameter()
{
  return ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->InfParameter();
}

 Standard_Real OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::SupParameter()
{
  return ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->SupParameter();
}

 System::Boolean OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::AutoIntersectionIsPossible()
{
  return OCConverter::StandardBooleanToBoolean(((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->AutoIntersectionIsPossible());
}

 Standard_Real OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::ApproxParamOnCurve(Standard_Integer Index, Standard_Real ParamOnLine)
{
  return ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->ApproxParamOnCurve(Index, ParamOnLine);
}

 Standard_Integer OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::CalculRegion(Standard_Real x, Standard_Real y, Standard_Real x1, Standard_Real x2, Standard_Real y1, Standard_Real y2)
{
  return ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->CalculRegion(x, y, x1, x2, y1, y2);
}

 void OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter::Dump()
{
  ((Geom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter*)nativeHandle)->Dump();
}


