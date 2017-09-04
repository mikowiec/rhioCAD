// File generated by CPPExt (CPP file)
//

#include "BRep_PolygonOnClosedSurface.h"
#include "../Converter.h"
#include "../Poly/Poly_Polygon2D.h"
#include "../Geom/Geom_Surface.h"
#include "../TopLoc/TopLoc_Location.h"
#include "BRep_CurveRepresentation.h"


using namespace OCNaroWrappers;

OCBRep_PolygonOnClosedSurface::OCBRep_PolygonOnClosedSurface(Handle(BRep_PolygonOnClosedSurface)* nativeHandle) : OCBRep_PolygonOnSurface((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_BRep_PolygonOnClosedSurface(*nativeHandle);
}

OCBRep_PolygonOnClosedSurface::OCBRep_PolygonOnClosedSurface(OCNaroWrappers::OCPoly_Polygon2D^ P1, OCNaroWrappers::OCPoly_Polygon2D^ P2, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopLoc_Location^ L) : OCBRep_PolygonOnSurface((OCDummy^)nullptr)

{
  nativeHandle = new Handle_BRep_PolygonOnClosedSurface(new BRep_PolygonOnClosedSurface(*((Handle_Poly_Polygon2D*)P1->Handle), *((Handle_Poly_Polygon2D*)P2->Handle), *((Handle_Geom_Surface*)S->Handle), *((TopLoc_Location*)L->Handle)));
}

 System::Boolean OCBRep_PolygonOnClosedSurface::IsPolygonOnClosedSurface()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_BRep_PolygonOnClosedSurface*)nativeHandle))->IsPolygonOnClosedSurface());
}

OCPoly_Polygon2D^ OCBRep_PolygonOnClosedSurface::Polygon2()
{
  Handle(Poly_Polygon2D) tmp = (*((Handle_BRep_PolygonOnClosedSurface*)nativeHandle))->Polygon2();
  return gcnew OCPoly_Polygon2D(&tmp);
}

 void OCBRep_PolygonOnClosedSurface::Polygon2(OCNaroWrappers::OCPoly_Polygon2D^ P)
{
  (*((Handle_BRep_PolygonOnClosedSurface*)nativeHandle))->Polygon2(*((Handle_Poly_Polygon2D*)P->Handle));
}

OCBRep_CurveRepresentation^ OCBRep_PolygonOnClosedSurface::Copy()
{
  Handle(BRep_CurveRepresentation) tmp = (*((Handle_BRep_PolygonOnClosedSurface*)nativeHandle))->Copy();
  return gcnew OCBRep_CurveRepresentation(&tmp);
}


