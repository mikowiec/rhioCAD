// File generated by CPPExt (MPV)
//
#ifndef _AppDef_MyBSplGradientOfBSplineCompute_OCWrappers_HeaderFile
#define _AppDef_MyBSplGradientOfBSplineCompute_OCWrappers_HeaderFile

// include native header
#include <AppDef_MyBSplGradientOfBSplineCompute.hxx>
#include "../Converter.h"


#include "../AppParCurves/AppParCurves_MultiBSpCurve.h"
#include "../math/math_Vector.h"


namespace OCNaroWrappers
{

ref class OCAppDef_MultiLine;
ref class OCAppDef_MyLineTool;
ref class OCAppDef_BSpParLeastSquareOfMyBSplGradientOfBSplineCompute;
ref class OCAppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute;
ref class OCAppDef_BSpGradient_BFGSOfMyBSplGradientOfBSplineCompute;
ref class OCAppParCurves_HArray1OfConstraintCouple;
ref class OCmath_Vector;
ref class OCTColStd_Array1OfReal;
ref class OCTColStd_Array1OfInteger;
ref class OCAppParCurves_MultiBSpCurve;



public ref class OCAppDef_MyBSplGradientOfBSplineCompute  {

protected:
  AppDef_MyBSplGradientOfBSplineCompute* nativeHandle;
  OCAppDef_MyBSplGradientOfBSplineCompute(OCDummy^) {};

public:
  property AppDef_MyBSplGradientOfBSplineCompute* Handle
  {
    AppDef_MyBSplGradientOfBSplineCompute* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCAppDef_MyBSplGradientOfBSplineCompute(AppDef_MyBSplGradientOfBSplineCompute* nativeHandle);

// Methods PUBLIC


OCAppDef_MyBSplGradientOfBSplineCompute(OCNaroWrappers::OCAppDef_MultiLine^ SSP, Standard_Integer FirstPoint, Standard_Integer LastPoint, OCNaroWrappers::OCAppParCurves_HArray1OfConstraintCouple^ TheConstraints, OCNaroWrappers::OCmath_Vector^ Parameters, OCNaroWrappers::OCTColStd_Array1OfReal^ Knots, OCNaroWrappers::OCTColStd_Array1OfInteger^ Mults, Standard_Integer Deg, Standard_Real Tol3d, Standard_Real Tol2d, Standard_Integer NbIterations);


OCAppDef_MyBSplGradientOfBSplineCompute(OCNaroWrappers::OCAppDef_MultiLine^ SSP, Standard_Integer FirstPoint, Standard_Integer LastPoint, OCNaroWrappers::OCAppParCurves_HArray1OfConstraintCouple^ TheConstraints, OCNaroWrappers::OCmath_Vector^ Parameters, OCNaroWrappers::OCTColStd_Array1OfReal^ Knots, OCNaroWrappers::OCTColStd_Array1OfInteger^ Mults, Standard_Integer Deg, Standard_Real Tol3d, Standard_Real Tol2d, Standard_Integer NbIterations, Standard_Real lambda1, Standard_Real lambda2);


 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  OCAppParCurves_MultiBSpCurve^ Value() ;


 /*instead*/  Standard_Real Error(Standard_Integer Index) ;


 /*instead*/  Standard_Real MaxError3d() ;


 /*instead*/  Standard_Real MaxError2d() ;


 /*instead*/  Standard_Real AverageError() ;

~OCAppDef_MyBSplGradientOfBSplineCompute()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
