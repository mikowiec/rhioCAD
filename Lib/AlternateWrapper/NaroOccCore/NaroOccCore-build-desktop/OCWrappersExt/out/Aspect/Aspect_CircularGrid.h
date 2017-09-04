// File generated by CPPExt (Transient)
//
#ifndef _Aspect_CircularGrid_OCWrappers_HeaderFile
#define _Aspect_CircularGrid_OCWrappers_HeaderFile

// include the wrapped class
#include <Aspect_CircularGrid.hxx>
#include "../Converter.h"

#include "Aspect_Grid.h"



namespace OCNaroWrappers
{




public ref class OCAspect_CircularGrid : OCAspect_Grid {

protected:
  // dummy constructor;
  OCAspect_CircularGrid(OCDummy^) : OCAspect_Grid((OCDummy^)nullptr) {};

public:

// constructor from native
OCAspect_CircularGrid(Handle(Aspect_CircularGrid)* nativeHandle);

// Methods PUBLIC

//! creates a new grid. By default this grid is not <br>
//!          active. <br>
OCAspect_CircularGrid(Quantity_Length aRadiusStep, Standard_Integer aDivisionNumber, Quantity_Length XOrigin, Quantity_Length anYOrigin, Quantity_PlaneAngle aRotationAngle);

//! defines the x step of the grid. <br>
 /*instead*/  void SetRadiusStep(Quantity_Length aStep) ;

//! defines the step of the grid. <br>
 /*instead*/  void SetDivisionNumber(Standard_Integer aNumber) ;


 /*instead*/  void SetGridValues(Quantity_Length XOrigin, Quantity_Length YOrigin, Quantity_Length RadiusStep, Standard_Integer DivisionNumber, Quantity_PlaneAngle RotationAngle) ;

//! returns the point of the grid the closest to the point X,Y <br>
 /*instead*/  void Compute(Quantity_Length X, Quantity_Length Y, Quantity_Length& gridX, Quantity_Length& gridY) ;

//! returns the x step of the grid. <br>
 /*instead*/  Quantity_Length RadiusStep() ;

//! returns the x step of the grid. <br>
 /*instead*/  Standard_Integer DivisionNumber() ;


virtual /*instead*/  void Init() ;

~OCAspect_CircularGrid()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
