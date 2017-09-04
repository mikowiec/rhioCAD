// File generated by CPPExt (MPV)
//
#ifndef _IntTools_CompareRange_OCWrappers_HeaderFile
#define _IntTools_CompareRange_OCWrappers_HeaderFile

// include native header
#include <IntTools_CompareRange.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCIntTools_Range;


//! Auxiliary class to provide a sorting Ranges, <br>
//!          taking  into  account a value of Left . <br>
public ref class OCIntTools_CompareRange  {

protected:
  IntTools_CompareRange* nativeHandle;
  OCIntTools_CompareRange(OCDummy^) {};

public:
  property IntTools_CompareRange* Handle
  {
    IntTools_CompareRange* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCIntTools_CompareRange(IntTools_CompareRange* nativeHandle);

// Methods PUBLIC


//! Empty constructor <br>
OCIntTools_CompareRange();


//! Initializes me by tolerance <br>
OCIntTools_CompareRange(Standard_Real aTol);


//! Returns True if <Left> is lower than <Right>. <br>
 /*instead*/  System::Boolean IsLower(OCNaroWrappers::OCIntTools_Range^ Left, OCNaroWrappers::OCIntTools_Range^ Right) ;


//! Returns True if <Left> is greater than <Right>. <br>
 /*instead*/  System::Boolean IsGreater(OCNaroWrappers::OCIntTools_Range^ Left, OCNaroWrappers::OCIntTools_Range^ Right) ;


//! Returns True when <Right> and <Left> are equal. <br>
 /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCIntTools_Range^ Left, OCNaroWrappers::OCIntTools_Range^ Right) ;

~OCIntTools_CompareRange()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
