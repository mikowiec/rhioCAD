// File generated by CPPExt (MPV)
//
#ifndef _math_CompareOfValueAndWeight_OCWrappers_HeaderFile
#define _math_CompareOfValueAndWeight_OCWrappers_HeaderFile

// include native header
#include <math_CompareOfValueAndWeight.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCmath_ValueAndWeight;



public ref class OCmath_CompareOfValueAndWeight  {

protected:
  math_CompareOfValueAndWeight* nativeHandle;
  OCmath_CompareOfValueAndWeight(OCDummy^) {};

public:
  property math_CompareOfValueAndWeight* Handle
  {
    math_CompareOfValueAndWeight* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCmath_CompareOfValueAndWeight(math_CompareOfValueAndWeight* nativeHandle);

// Methods PUBLIC


OCmath_CompareOfValueAndWeight();

//! Returns True if <Left.Value()> is lower than <Right.Value()>. <br>
 /*instead*/  System::Boolean IsLower(OCNaroWrappers::OCmath_ValueAndWeight^ Left, OCNaroWrappers::OCmath_ValueAndWeight^ Right) ;

//! Returns True if <Left.Value()> is greater than <Right.Value()>. <br>
 /*instead*/  System::Boolean IsGreater(OCNaroWrappers::OCmath_ValueAndWeight^ Left, OCNaroWrappers::OCmath_ValueAndWeight^ Right) ;

//! returns True when <Right> and <Left> are equal. <br>
 /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCmath_ValueAndWeight^ Left, OCNaroWrappers::OCmath_ValueAndWeight^ Right) ;

~OCmath_CompareOfValueAndWeight()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
