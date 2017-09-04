// File generated by CPPExt (CPP file)
//

#include "math_BracketMinimum.h"
#include "../Converter.h"
#include "math_Function.h"


using namespace OCNaroWrappers;

OCmath_BracketMinimum::OCmath_BracketMinimum(math_BracketMinimum* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCmath_BracketMinimum::OCmath_BracketMinimum(OCNaroWrappers::OCmath_Function^ F, Standard_Real A, Standard_Real B) 
{
  nativeHandle = new math_BracketMinimum(*((math_Function*)F->Handle), A, B);
}

OCmath_BracketMinimum::OCmath_BracketMinimum(OCNaroWrappers::OCmath_Function^ F, Standard_Real A, Standard_Real B, Standard_Real FA) 
{
  nativeHandle = new math_BracketMinimum(*((math_Function*)F->Handle), A, B, FA);
}

OCmath_BracketMinimum::OCmath_BracketMinimum(OCNaroWrappers::OCmath_Function^ F, Standard_Real A, Standard_Real B, Standard_Real FA, Standard_Real FB) 
{
  nativeHandle = new math_BracketMinimum(*((math_Function*)F->Handle), A, B, FA, FB);
}

 System::Boolean OCmath_BracketMinimum::IsDone()
{
  return OCConverter::StandardBooleanToBoolean(((math_BracketMinimum*)nativeHandle)->IsDone());
}

 void OCmath_BracketMinimum::Values(Standard_Real& A, Standard_Real& B, Standard_Real& C)
{
  ((math_BracketMinimum*)nativeHandle)->Values(A, B, C);
}

 void OCmath_BracketMinimum::FunctionValues(Standard_Real& FA, Standard_Real& FB, Standard_Real& FC)
{
  ((math_BracketMinimum*)nativeHandle)->FunctionValues(FA, FB, FC);
}

 void OCmath_BracketMinimum::Dump(Standard_OStream& o)
{
  ((math_BracketMinimum*)nativeHandle)->Dump(o);
}


