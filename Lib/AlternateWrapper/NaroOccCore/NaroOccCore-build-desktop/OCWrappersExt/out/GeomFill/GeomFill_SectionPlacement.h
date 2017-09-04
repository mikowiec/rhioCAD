// File generated by CPPExt (MPV)
//
#ifndef _GeomFill_SectionPlacement_OCWrappers_HeaderFile
#define _GeomFill_SectionPlacement_OCWrappers_HeaderFile

// include native header
#include <GeomFill_SectionPlacement.hxx>
#include "../Converter.h"


#include "../gp/gp_Ax1.h"
#include "../GeomAdaptor/GeomAdaptor_Curve.h"
#include "../Extrema/Extrema_ExtPC.h"
#include "../gp/gp_Pnt.h"


namespace OCNaroWrappers
{

ref class OCGeomFill_LocationLaw;
ref class OCGeom_Curve;
ref class OCGeom_Geometry;
ref class OCAdaptor3d_HCurve;
ref class OCgp_Trsf;
ref class OCgp_Mat;
ref class OCgp_Vec;


//! To place section in sweep Function <br>
public ref class OCGeomFill_SectionPlacement  {

protected:
  GeomFill_SectionPlacement* nativeHandle;
  OCGeomFill_SectionPlacement(OCDummy^) {};

public:
  property GeomFill_SectionPlacement* Handle
  {
    GeomFill_SectionPlacement* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCGeomFill_SectionPlacement(GeomFill_SectionPlacement* nativeHandle);

// Methods PUBLIC


OCGeomFill_SectionPlacement(OCNaroWrappers::OCGeomFill_LocationLaw^ L, OCNaroWrappers::OCGeom_Geometry^ Section);

//! To change the section Law <br>
 /*instead*/  void SetLocation(OCNaroWrappers::OCGeomFill_LocationLaw^ L) ;


 /*instead*/  void Perform(Standard_Real Tol) ;


 /*instead*/  void Perform(OCNaroWrappers::OCAdaptor3d_HCurve^ Path, Standard_Real Tol) ;


 /*instead*/  void Perform(Standard_Real ParamOnPath, Standard_Real Tol) ;


 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  Standard_Real ParameterOnPath() ;


 /*instead*/  Standard_Real ParameterOnSection() ;


 /*instead*/  Standard_Real Distance() ;


 /*instead*/  Standard_Real Angle() ;


 /*instead*/  OCgp_Trsf^ Transformation(System::Boolean WithTranslation, System::Boolean WithCorrection) ;

//! Compute the Section, in the coordinate syteme given by <br>
//!          the Location Law. <br>
//!          If <WithTranslation> contact beetween <br>
//!          <Section> and <Path> is forced. <br>
 /*instead*/  OCGeom_Curve^ Section(System::Boolean WithTranslation) ;

//! Compute the Section, in the coordinate syteme given by <br>
//!          the Location Law. <br>
//!          To have the Normal to section equal to the Location <br>
//!          Law Normal.  If <WithTranslation> contact beetween <br>
//!          <Section> and <Path> is forced. <br>
 /*instead*/  OCGeom_Curve^ ModifiedSection(System::Boolean WithTranslation) ;

~OCGeomFill_SectionPlacement()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
