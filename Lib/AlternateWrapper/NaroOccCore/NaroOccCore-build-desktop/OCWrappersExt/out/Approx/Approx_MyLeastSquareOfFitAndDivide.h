// File generated by CPPExt (MPV)
//
#ifndef _Approx_MyLeastSquareOfFitAndDivide_OCWrappers_HeaderFile
#define _Approx_MyLeastSquareOfFitAndDivide_OCWrappers_HeaderFile

// include native header
#include <Approx_MyLeastSquareOfFitAndDivide.hxx>
#include "../Converter.h"


#include "../AppParCurves/AppParCurves_MultiCurve.h"
#include "../math/math_Matrix.h"
#include "../math/math_Vector.h"
#include "../AppParCurves/AppParCurves_Constraint.h"


namespace OCNaroWrappers
{

ref class OCAppCont_Function;
ref class OCAppCont_FunctionTool;
ref class OCAppParCurves_MultiCurve;



public ref class OCApprox_MyLeastSquareOfFitAndDivide  {

protected:
  Approx_MyLeastSquareOfFitAndDivide* nativeHandle;
  OCApprox_MyLeastSquareOfFitAndDivide(OCDummy^) {};

public:
  property Approx_MyLeastSquareOfFitAndDivide* Handle
  {
    Approx_MyLeastSquareOfFitAndDivide* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCApprox_MyLeastSquareOfFitAndDivide(Approx_MyLeastSquareOfFitAndDivide* nativeHandle);

// Methods PUBLIC


OCApprox_MyLeastSquareOfFitAndDivide(OCNaroWrappers::OCAppCont_Function^ SSP, Standard_Real U0, Standard_Real U1, OCAppParCurves_Constraint FirstCons, OCAppParCurves_Constraint LastCons, Standard_Integer Deg, Standard_Integer NbPoints);


 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  OCAppParCurves_MultiCurve^ Value() ;


 /*instead*/  void Error(Standard_Real& F, Standard_Real& MaxE3d, Standard_Real& MaxE2d) ;

~OCApprox_MyLeastSquareOfFitAndDivide()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
