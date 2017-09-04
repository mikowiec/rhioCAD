// File generated by CPPExt (Transient)
//
#ifndef _BRep_PolygonOnClosedSurface_OCWrappers_HeaderFile
#define _BRep_PolygonOnClosedSurface_OCWrappers_HeaderFile

// include the wrapped class
#include <BRep_PolygonOnClosedSurface.hxx>
#include "../Converter.h"

#include "BRep_PolygonOnSurface.h"



namespace OCNaroWrappers
{

ref class OCPoly_Polygon2D;
ref class OCGeom_Surface;
ref class OCTopLoc_Location;
ref class OCBRep_CurveRepresentation;


//! Representation by two 2d polygons in the parametric <br>
//!          space of a surface. <br>
public ref class OCBRep_PolygonOnClosedSurface : OCBRep_PolygonOnSurface {

protected:
  // dummy constructor;
  OCBRep_PolygonOnClosedSurface(OCDummy^) : OCBRep_PolygonOnSurface((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRep_PolygonOnClosedSurface(Handle(BRep_PolygonOnClosedSurface)* nativeHandle);

// Methods PUBLIC


OCBRep_PolygonOnClosedSurface(OCNaroWrappers::OCPoly_Polygon2D^ P1, OCNaroWrappers::OCPoly_Polygon2D^ P2, OCNaroWrappers::OCGeom_Surface^ S, OCNaroWrappers::OCTopLoc_Location^ L);

//! returns True. <br>
virtual /*instead*/  System::Boolean IsPolygonOnClosedSurface() override;


virtual /*instead*/  OCPoly_Polygon2D^ Polygon2() override;


virtual /*instead*/  void Polygon2(OCNaroWrappers::OCPoly_Polygon2D^ P) override;

//! Return a copy of this representation. <br>
virtual /*instead*/  OCBRep_CurveRepresentation^ Copy() override;

~OCBRep_PolygonOnClosedSurface()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif