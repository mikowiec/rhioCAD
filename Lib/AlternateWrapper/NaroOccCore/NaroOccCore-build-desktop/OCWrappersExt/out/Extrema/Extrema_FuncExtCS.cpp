// File generated by CPPExt (CPP file)
//

#include "Extrema_FuncExtCS.h"
#include "../Converter.h"
#include "../Adaptor3d/Adaptor3d_Curve.h"
#include "../Adaptor3d/Adaptor3d_Surface.h"
#include "../math/math_Vector.h"
#include "../math/math_Matrix.h"
#include "Extrema_POnCurv.h"
#include "Extrema_POnSurf.h"


using namespace OCNaroWrappers;

OCExtrema_FuncExtCS::OCExtrema_FuncExtCS(Extrema_FuncExtCS* nativeHandle) : OCmath_FunctionSetWithDerivatives((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCExtrema_FuncExtCS::OCExtrema_FuncExtCS() : OCmath_FunctionSetWithDerivatives((OCDummy^)nullptr)

{
  nativeHandle = new Extrema_FuncExtCS();
}

OCExtrema_FuncExtCS::OCExtrema_FuncExtCS(OCNaroWrappers::OCAdaptor3d_Curve^ C, OCNaroWrappers::OCAdaptor3d_Surface^ S) : OCmath_FunctionSetWithDerivatives((OCDummy^)nullptr)

{
  nativeHandle = new Extrema_FuncExtCS(*((Adaptor3d_Curve*)C->Handle), *((Adaptor3d_Surface*)S->Handle));
}

 void OCExtrema_FuncExtCS::Initialize(OCNaroWrappers::OCAdaptor3d_Curve^ C, OCNaroWrappers::OCAdaptor3d_Surface^ S)
{
  ((Extrema_FuncExtCS*)nativeHandle)->Initialize(*((Adaptor3d_Curve*)C->Handle), *((Adaptor3d_Surface*)S->Handle));
}

 Standard_Integer OCExtrema_FuncExtCS::NbVariables()
{
  return ((Extrema_FuncExtCS*)nativeHandle)->NbVariables();
}

 Standard_Integer OCExtrema_FuncExtCS::NbEquations()
{
  return ((Extrema_FuncExtCS*)nativeHandle)->NbEquations();
}

 System::Boolean OCExtrema_FuncExtCS::Value(OCNaroWrappers::OCmath_Vector^ UV, OCNaroWrappers::OCmath_Vector^ F)
{
  return OCConverter::StandardBooleanToBoolean(((Extrema_FuncExtCS*)nativeHandle)->Value(*((math_Vector*)UV->Handle), *((math_Vector*)F->Handle)));
}

 System::Boolean OCExtrema_FuncExtCS::Derivatives(OCNaroWrappers::OCmath_Vector^ UV, OCNaroWrappers::OCmath_Matrix^ DF)
{
  return OCConverter::StandardBooleanToBoolean(((Extrema_FuncExtCS*)nativeHandle)->Derivatives(*((math_Vector*)UV->Handle), *((math_Matrix*)DF->Handle)));
}

 System::Boolean OCExtrema_FuncExtCS::Values(OCNaroWrappers::OCmath_Vector^ UV, OCNaroWrappers::OCmath_Vector^ F, OCNaroWrappers::OCmath_Matrix^ DF)
{
  return OCConverter::StandardBooleanToBoolean(((Extrema_FuncExtCS*)nativeHandle)->Values(*((math_Vector*)UV->Handle), *((math_Vector*)F->Handle), *((math_Matrix*)DF->Handle)));
}

 Standard_Integer OCExtrema_FuncExtCS::GetStateNumber()
{
  return ((Extrema_FuncExtCS*)nativeHandle)->GetStateNumber();
}

 Standard_Integer OCExtrema_FuncExtCS::NbExt()
{
  return ((Extrema_FuncExtCS*)nativeHandle)->NbExt();
}

 Standard_Real OCExtrema_FuncExtCS::SquareDistance(Standard_Integer N)
{
  return ((Extrema_FuncExtCS*)nativeHandle)->SquareDistance(N);
}

OCExtrema_POnCurv^ OCExtrema_FuncExtCS::PointOnCurve(Standard_Integer N)
{
  Extrema_POnCurv* tmp = new Extrema_POnCurv();
  *tmp = ((Extrema_FuncExtCS*)nativeHandle)->PointOnCurve(N);
  return gcnew OCExtrema_POnCurv(tmp);
}

OCExtrema_POnSurf^ OCExtrema_FuncExtCS::PointOnSurface(Standard_Integer N)
{
  Extrema_POnSurf* tmp = new Extrema_POnSurf();
  *tmp = ((Extrema_FuncExtCS*)nativeHandle)->PointOnSurface(N);
  return gcnew OCExtrema_POnSurf(tmp);
}


