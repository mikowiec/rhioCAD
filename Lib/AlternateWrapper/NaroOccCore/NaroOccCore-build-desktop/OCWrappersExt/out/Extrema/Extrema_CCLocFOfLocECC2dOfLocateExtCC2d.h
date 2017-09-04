// File generated by CPPExt (MPV)
//
#ifndef _Extrema_CCLocFOfLocECC2dOfLocateExtCC2d_OCWrappers_HeaderFile
#define _Extrema_CCLocFOfLocECC2dOfLocateExtCC2d_OCWrappers_HeaderFile

// include native header
#include <Extrema_CCLocFOfLocECC2dOfLocateExtCC2d.hxx>
#include "../Converter.h"

#include "../math/math_FunctionSetWithDerivatives.h"

#include "../gp/gp_Pnt2d.h"
#include "../TColStd/TColStd_SequenceOfReal.h"
#include "Extrema_SeqPOnCOfCCLocFOfLocECC2dOfLocateExtCC2d.h"
#include "../math/math_FunctionSetWithDerivatives.h"


namespace OCNaroWrappers
{

ref class OCAdaptor2d_Curve2d;
ref class OCExtrema_Curve2dTool;
ref class OCExtrema_POnCurv2d;
ref class OCgp_Pnt2d;
ref class OCgp_Vec2d;
ref class OCExtrema_SeqPOnCOfCCLocFOfLocECC2dOfLocateExtCC2d;
ref class OCExtrema_SequenceNodeOfSeqPOnCOfCCLocFOfLocECC2dOfLocateExtCC2d;
ref class OCmath_Vector;
ref class OCmath_Matrix;



public ref class OCExtrema_CCLocFOfLocECC2dOfLocateExtCC2d  : public OCmath_FunctionSetWithDerivatives {

protected:
  // dummy constructor;
  OCExtrema_CCLocFOfLocECC2dOfLocateExtCC2d(OCDummy^) : OCmath_FunctionSetWithDerivatives((OCDummy^)nullptr) {};

public:

// constructor from native
OCExtrema_CCLocFOfLocECC2dOfLocateExtCC2d(Extrema_CCLocFOfLocECC2dOfLocateExtCC2d* nativeHandle);

// Methods PUBLIC


OCExtrema_CCLocFOfLocECC2dOfLocateExtCC2d(Standard_Real thetol);


OCExtrema_CCLocFOfLocECC2dOfLocateExtCC2d(OCNaroWrappers::OCAdaptor2d_Curve2d^ C1, OCNaroWrappers::OCAdaptor2d_Curve2d^ C2, Standard_Real thetol);


 /*instead*/  void SetCurve(Standard_Integer theRank, OCNaroWrappers::OCAdaptor2d_Curve2d^ C1) ;


 /*instead*/  void SetTolerance(Standard_Real theTol) ;


virtual /*instead*/  Standard_Integer NbVariables() ;


virtual /*instead*/  Standard_Integer NbEquations() ;


virtual /*instead*/  System::Boolean Value(OCNaroWrappers::OCmath_Vector^ UV, OCNaroWrappers::OCmath_Vector^ F) ;


 /*instead*/  System::Boolean Derivatives(OCNaroWrappers::OCmath_Vector^ UV, OCNaroWrappers::OCmath_Matrix^ DF) ;


 /*instead*/  System::Boolean Values(OCNaroWrappers::OCmath_Vector^ UV, OCNaroWrappers::OCmath_Vector^ F, OCNaroWrappers::OCmath_Matrix^ DF) ;


virtual /*instead*/  Standard_Integer GetStateNumber() override;


 /*instead*/  Standard_Integer NbExt() ;


 /*instead*/  Standard_Real SquareDistance(Standard_Integer N) ;


 /*instead*/  void Points(Standard_Integer N, OCNaroWrappers::OCExtrema_POnCurv2d^ P1, OCNaroWrappers::OCExtrema_POnCurv2d^ P2) ;


 /*instead*/  Standard_Address CurvePtr(Standard_Integer theRank) ;


 /*instead*/  Standard_Real Tolerance() ;

~OCExtrema_CCLocFOfLocECC2dOfLocateExtCC2d()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
