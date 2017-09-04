// File generated by CPPExt (MPV)
//
#ifndef _IntAna_Curve_OCWrappers_HeaderFile
#define _IntAna_Curve_OCWrappers_HeaderFile

// include native header
#include <IntAna_Curve.hxx>
#include "../Converter.h"


#include "../GeomAbs/GeomAbs_SurfaceType.h"
#include "../gp/gp_Ax3.h"


namespace OCNaroWrappers
{

ref class OCgp_Cylinder;
ref class OCgp_Cone;
ref class OCgp_Pnt;
ref class OCgp_Vec;


//! Definition of a parametric Curve which is the result <br>
//!          of the intersection between two quadrics. <br>
public ref class OCIntAna_Curve  {

protected:
  IntAna_Curve* nativeHandle;
  OCIntAna_Curve(OCDummy^) {};

public:
  property IntAna_Curve* Handle
  {
    IntAna_Curve* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCIntAna_Curve(IntAna_Curve* nativeHandle);

// Methods PUBLIC

//! Empty Constructor <br>
OCIntAna_Curve();

//! Sets the parameters used to compute Points and Derivative <br>
//!          on the curve. <br>
 /*instead*/  void SetCylinderQuadValues(OCNaroWrappers::OCgp_Cylinder^ Cylinder, Standard_Real Qxx, Standard_Real Qyy, Standard_Real Qzz, Standard_Real Qxy, Standard_Real Qxz, Standard_Real Qyz, Standard_Real Qx, Standard_Real Qy, Standard_Real Qz, Standard_Real Q1, Standard_Real Tol, Standard_Real DomInf, Standard_Real DomSup, System::Boolean TwoZForATheta, System::Boolean ZIsPositive) ;

//! Sets  the parameters used    to compute Points  and <br>
//!          Derivative on the curve. <br>
 /*instead*/  void SetConeQuadValues(OCNaroWrappers::OCgp_Cone^ Cone, Standard_Real Qxx, Standard_Real Qyy, Standard_Real Qzz, Standard_Real Qxy, Standard_Real Qxz, Standard_Real Qyz, Standard_Real Qx, Standard_Real Qy, Standard_Real Qz, Standard_Real Q1, Standard_Real Tol, Standard_Real DomInf, Standard_Real DomSup, System::Boolean TwoZForATheta, System::Boolean ZIsPositive) ;

//! Returns TRUE if the curve is not  infinite  at the <br>
//!          last parameter or at the first parameter of the domain. <br>
 /*instead*/  System::Boolean IsOpen() ;

//! Returns the paramatric domain of the curve. <br>
 /*instead*/  void Domain(Standard_Real& Theta1, Standard_Real& Theta2) ;

//! Returns TRUE if the function is constant. <br>
 /*instead*/  System::Boolean IsConstant() ;

//! Returns TRUE if the domain is open at the beginning. <br>
 /*instead*/  System::Boolean IsFirstOpen() ;

//! Returns TRUE if the domain is open at the end. <br>
 /*instead*/  System::Boolean IsLastOpen() ;

//! Returns the point at parameter Theta on the curve. <br>
 /*instead*/  OCgp_Pnt^ Value(Standard_Real Theta) ;

//! Returns the point and the first derivative at parameter <br>
//!          Theta on the curve. <br>
 /*instead*/  System::Boolean D1u(Standard_Real Theta, OCNaroWrappers::OCgp_Pnt^ P, OCNaroWrappers::OCgp_Vec^ V) ;

//! Tries to find the parameter of the point P on the curve. <br>
//!          If the method returns False, the "projection" is <br>
//!          impossible, and the value of Para is not significant. <br>
//!          If the method returns True, Para is the parameter of the <br>
//!          nearest intersection between the curve and the iso-theta <br>
//!          containing P. <br>
 /*instead*/  System::Boolean FindParameter(OCNaroWrappers::OCgp_Pnt^ P, Standard_Real& Para) ;

//! If flag is True, the Curve is not defined at the <br>
//!          first parameter of its domain. <br>
//! <br>
 /*instead*/  void SetIsFirstOpen(System::Boolean Flag) ;

//! If flag is True, the Curve is not defined at the <br>
//!          first parameter of its domain. <br>
 /*instead*/  void SetIsLastOpen(System::Boolean Flag) ;

//! Protected function. <br>
 /*instead*/  void InternalUVValue(Standard_Real Param, Standard_Real& U, Standard_Real& V, Standard_Real& A, Standard_Real& B, Standard_Real& C, Standard_Real& Co, Standard_Real& Si, Standard_Real& Di) ;


 /*instead*/  void SetDomain(Standard_Real Theta1, Standard_Real Theta2) ;

~OCIntAna_Curve()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
