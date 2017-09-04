// File generated by CPPExt (MPV)
//
#ifndef _GeomAPI_IntCS_OCWrappers_HeaderFile
#define _GeomAPI_IntCS_OCWrappers_HeaderFile

// include native header
#include <GeomAPI_IntCS.hxx>
#include "../Converter.h"


#include "../IntCurveSurface/IntCurveSurface_HInter.h"


namespace OCNaroWrappers
{

ref class OCGeom_Curve;
ref class OCGeom_Surface;
ref class OCgp_Pnt;


//! This class implements methods for <br>
//!  computing intersection points and  segments between a <br>
public ref class OCGeomAPI_IntCS  {

protected:
  GeomAPI_IntCS* nativeHandle;
  OCGeomAPI_IntCS(OCDummy^) {};

public:
  property GeomAPI_IntCS* Handle
  {
    GeomAPI_IntCS* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCGeomAPI_IntCS(GeomAPI_IntCS* nativeHandle);

// Methods PUBLIC

//! Creates an empty object. Use the <br>
//! function Perform for further initialization of the algorithm by <br>
//! the curve and the surface. <br>
OCGeomAPI_IntCS();

//! Computes the intersections between <br>
//! the curve C and the surface S. <br>
//! Warning <br>
//! Use function IsDone to verify that the intersections are computed successfully. <br>
OCGeomAPI_IntCS(OCNaroWrappers::OCGeom_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S);

//! This function Initializes an algorithm with the curve C and the <br>
//! surface S and computes the intersections between C and S. <br>
//! Warning <br>
//! Use function IsDone to verify that the intersections are computed successfully. <br>
 /*instead*/  void Perform(OCNaroWrappers::OCGeom_Curve^ C, OCNaroWrappers::OCGeom_Surface^ S) ;

//! Returns true if the intersections are successfully computed. <br>
 /*instead*/  System::Boolean IsDone() ;

//! Returns the number of Intersection Points <br>
//!          if IsDone returns True. <br>
//!          else NotDone is raised. <br>
 /*instead*/  Standard_Integer NbPoints() ;

//! Returns the Intersection Point of range <Index>in case of cross intersection. <br>
//!         Raises NotDone if the computation has failed or if <br>
//!          the computation has not been done <br>
//!          raises OutOfRange if Index is not in the range <1..NbPoints> <br>
 /*instead*/  OCgp_Pnt^ Point(Standard_Integer Index) ;

//! Returns parameter W on the curve <br>
//! and (parameters U,V) on the surface of the computed intersection point <br>
//! of index Index in case of cross intersection. <br>
//! Exceptions <br>
//! StdFail_NotDone if intersection algorithm fails or is not initialized. <br>
//! Standard_OutOfRange if Index is not in the range [ 1,NbPoints ], where <br>
//! NbPoints is the number of computed intersection points. <br>
 /*instead*/  void Parameters(Standard_Integer Index, Quantity_Parameter& U, Quantity_Parameter& V, Quantity_Parameter& W) ;

//! Returns the number of computed <br>
//! intersection segments in case of tangential intersection. <br>
//! Exceptions <br>
//! StdFail_NotDone if the intersection algorithm fails or is not initialized. <br>
 /*instead*/  Standard_Integer NbSegments() ;

//! Returns the computed intersection <br>
//! segment of index Index in case of tangential intersection. <br>
//! Intersection segment is a portion of the initial curve tangent to surface. <br>
//! Exceptions <br>
//! StdFail_NotDone if intersection algorithm fails or is not initialized. <br>
//! Standard_OutOfRange if Index is not in the range [ 1,NbSegments ], <br>
//! where NbSegments is the number of computed intersection segments. <br>
 /*instead*/  OCGeom_Curve^ Segment(Standard_Integer Index) ;

//! Returns the parameters of the first (U1,V1) and the last (U2,V2) points <br>
//! of curve's segment on the surface in case of tangential intersection. <br>
//! Index is the number of computed intersection segments. <br>
//! Exceptions <br>
//! StdFail_NotDone if intersection algorithm fails or is not initialized. <br>
//! Standard_OutOfRange if Index is not in the range [ 1,NbSegments ], <br>
//! where NbSegments is the number of computed intersection segments. <br>
 /*instead*/  void Parameters(Standard_Integer Index, Quantity_Parameter& U1, Quantity_Parameter& V1, Quantity_Parameter& U2, Quantity_Parameter& V2) ;

~OCGeomAPI_IntCS()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
