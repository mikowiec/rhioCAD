// File generated by CPPExt (MPV)
//
#ifndef _AppDef_MyGradientOfCompute_OCWrappers_HeaderFile
#define _AppDef_MyGradientOfCompute_OCWrappers_HeaderFile

// include native header
#include <AppDef_MyGradientOfCompute.hxx>
#include "../Converter.h"


#include "../AppParCurves/AppParCurves_MultiCurve.h"
#include "../math/math_Vector.h"


namespace OCNaroWrappers
{

ref class OCAppDef_MultiLine;
ref class OCAppDef_MyLineTool;
ref class OCAppDef_ParLeastSquareOfMyGradientOfCompute;
ref class OCAppDef_ResConstraintOfMyGradientOfCompute;
ref class OCAppDef_ParFunctionOfMyGradientOfCompute;
ref class OCAppDef_Gradient_BFGSOfMyGradientOfCompute;
ref class OCAppParCurves_HArray1OfConstraintCouple;
ref class OCmath_Vector;
ref class OCAppParCurves_MultiCurve;



public ref class OCAppDef_MyGradientOfCompute  {

protected:
  AppDef_MyGradientOfCompute* nativeHandle;
  OCAppDef_MyGradientOfCompute(OCDummy^) {};

public:
  property AppDef_MyGradientOfCompute* Handle
  {
    AppDef_MyGradientOfCompute* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCAppDef_MyGradientOfCompute(AppDef_MyGradientOfCompute* nativeHandle);

// Methods PUBLIC


OCAppDef_MyGradientOfCompute(OCNaroWrappers::OCAppDef_MultiLine^ SSP, Standard_Integer FirstPoint, Standard_Integer LastPoint, OCNaroWrappers::OCAppParCurves_HArray1OfConstraintCouple^ TheConstraints, OCNaroWrappers::OCmath_Vector^ Parameters, Standard_Integer Deg, Standard_Real Tol3d, Standard_Real Tol2d, Standard_Integer NbIterations);


 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  OCAppParCurves_MultiCurve^ Value() ;


 /*instead*/  Standard_Real Error(Standard_Integer Index) ;


 /*instead*/  Standard_Real MaxError3d() ;


 /*instead*/  Standard_Real MaxError2d() ;


 /*instead*/  Standard_Real AverageError() ;

~OCAppDef_MyGradientOfCompute()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
