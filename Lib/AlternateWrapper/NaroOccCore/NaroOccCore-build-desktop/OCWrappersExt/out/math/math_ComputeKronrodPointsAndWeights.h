// File generated by CPPExt (MPV)
//
#ifndef _math_ComputeKronrodPointsAndWeights_OCWrappers_HeaderFile
#define _math_ComputeKronrodPointsAndWeights_OCWrappers_HeaderFile

// include native header
#include <math_ComputeKronrodPointsAndWeights.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCTColStd_HArray1OfReal;
ref class OCmath_Vector;



public ref class OCmath_ComputeKronrodPointsAndWeights  {

protected:
  math_ComputeKronrodPointsAndWeights* nativeHandle;
  OCmath_ComputeKronrodPointsAndWeights(OCDummy^) {};

public:
  property math_ComputeKronrodPointsAndWeights* Handle
  {
    math_ComputeKronrodPointsAndWeights* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCmath_ComputeKronrodPointsAndWeights(math_ComputeKronrodPointsAndWeights* nativeHandle);

// Methods PUBLIC


OCmath_ComputeKronrodPointsAndWeights(Standard_Integer Number);


 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  OCmath_Vector^ Points() ;


 /*instead*/  OCmath_Vector^ Weights() ;

~OCmath_ComputeKronrodPointsAndWeights()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
