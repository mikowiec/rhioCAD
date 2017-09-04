// File generated by CPPExt (MPV)
//
#ifndef _IntCurveSurface_TheCSFunctionOfHInter_OCWrappers_HeaderFile
#define _IntCurveSurface_TheCSFunctionOfHInter_OCWrappers_HeaderFile

// include native header
#include <IntCurveSurface_TheCSFunctionOfHInter.hxx>
#include "../Converter.h"

#include "../math/math_FunctionSetWithDerivatives.h"

#include "../gp/gp_Pnt.h"
#include "../math/math_FunctionSetWithDerivatives.h"


namespace OCNaroWrappers
{

ref class OCAdaptor3d_HSurface;
ref class OCAdaptor3d_HCurve;
ref class OCAdaptor3d_HSurfaceTool;
ref class OCIntCurveSurface_TheHCurveTool;
ref class OCmath_Vector;
ref class OCmath_Matrix;
ref class OCgp_Pnt;



public ref class OCIntCurveSurface_TheCSFunctionOfHInter  : public OCmath_FunctionSetWithDerivatives {

protected:
  // dummy constructor;
  OCIntCurveSurface_TheCSFunctionOfHInter(OCDummy^) : OCmath_FunctionSetWithDerivatives((OCDummy^)nullptr) {};

public:

// constructor from native
OCIntCurveSurface_TheCSFunctionOfHInter(IntCurveSurface_TheCSFunctionOfHInter* nativeHandle);

// Methods PUBLIC


OCIntCurveSurface_TheCSFunctionOfHInter(OCNaroWrappers::OCAdaptor3d_HSurface^ S, OCNaroWrappers::OCAdaptor3d_HCurve^ C);


 /*instead*/  Standard_Integer NbVariables() ;


 /*instead*/  Standard_Integer NbEquations() ;


 /*instead*/  System::Boolean Value(OCNaroWrappers::OCmath_Vector^ X, OCNaroWrappers::OCmath_Vector^ F) ;


 /*instead*/  System::Boolean Derivatives(OCNaroWrappers::OCmath_Vector^ X, OCNaroWrappers::OCmath_Matrix^ D) ;


 /*instead*/  System::Boolean Values(OCNaroWrappers::OCmath_Vector^ X, OCNaroWrappers::OCmath_Vector^ F, OCNaroWrappers::OCmath_Matrix^ D) ;


 /*instead*/  OCgp_Pnt^ Point() ;


 /*instead*/  Standard_Real Root() ;


 /*instead*/  OCAdaptor3d_HSurface^ AuxillarSurface() ;


 /*instead*/  OCAdaptor3d_HCurve^ AuxillarCurve() ;

~OCIntCurveSurface_TheCSFunctionOfHInter()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
