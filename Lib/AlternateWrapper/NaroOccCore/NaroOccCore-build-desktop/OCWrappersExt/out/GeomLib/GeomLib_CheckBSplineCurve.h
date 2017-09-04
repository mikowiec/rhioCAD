// File generated by CPPExt (MPV)
//
#ifndef _GeomLib_CheckBSplineCurve_OCWrappers_HeaderFile
#define _GeomLib_CheckBSplineCurve_OCWrappers_HeaderFile

// include native header
#include <GeomLib_CheckBSplineCurve.hxx>
#include "../Converter.h"


#include "../gp/gp_Pnt.h"


namespace OCNaroWrappers
{

ref class OCGeom_BSplineCurve;


//! this class is used to  construct the BSpline curve <br>
//!          from an Approximation ( ApproxAFunction from AdvApprox). <br>
public ref class OCGeomLib_CheckBSplineCurve  {

protected:
  GeomLib_CheckBSplineCurve* nativeHandle;
  OCGeomLib_CheckBSplineCurve(OCDummy^) {};

public:
  property GeomLib_CheckBSplineCurve* Handle
  {
    GeomLib_CheckBSplineCurve* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCGeomLib_CheckBSplineCurve(GeomLib_CheckBSplineCurve* nativeHandle);

// Methods PUBLIC


OCGeomLib_CheckBSplineCurve(OCNaroWrappers::OCGeom_BSplineCurve^ Curve, Standard_Real Tolerance, Standard_Real AngularTolerance);


 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  void NeedTangentFix(System::Boolean& FirstFlag, System::Boolean& SecondFlag) ;


 /*instead*/  void FixTangent(System::Boolean FirstFlag, System::Boolean LastFlag) ;

//!  modifies the curve <br>
//! by fixing the first or the last tangencies <br>
//! <br>//! if Index3D not in the Range [1,Nb3dSpaces] <br>//! if the Approx is not Done <br>
 /*instead*/  OCGeom_BSplineCurve^ FixedTangent(System::Boolean FirstFlag, System::Boolean LastFlag) ;

~OCGeomLib_CheckBSplineCurve()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
