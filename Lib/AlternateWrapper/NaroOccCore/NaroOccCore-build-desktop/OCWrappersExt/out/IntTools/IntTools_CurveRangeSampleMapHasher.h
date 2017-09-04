// File generated by CPPExt (MPV)
//
#ifndef _IntTools_CurveRangeSampleMapHasher_OCWrappers_HeaderFile
#define _IntTools_CurveRangeSampleMapHasher_OCWrappers_HeaderFile

// include native header
#include <IntTools_CurveRangeSampleMapHasher.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCIntTools_CurveRangeSample;



public ref class OCIntTools_CurveRangeSampleMapHasher  {

protected:
  IntTools_CurveRangeSampleMapHasher* nativeHandle;
  OCIntTools_CurveRangeSampleMapHasher(OCDummy^) {};

public:
  property IntTools_CurveRangeSampleMapHasher* Handle
  {
    IntTools_CurveRangeSampleMapHasher* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCIntTools_CurveRangeSampleMapHasher(IntTools_CurveRangeSampleMapHasher* nativeHandle);

// Methods PUBLIC

//! Returns a HasCode value  for  the  Key <K>  in the <br>
//!          range 0..Upper. <br>
static /*instead*/  Standard_Integer HashCode(OCNaroWrappers::OCIntTools_CurveRangeSample^ K, Standard_Integer Upper) ;

//! Returns True  when the two  keys are the same. Two <br>
//!          same  keys  must   have  the  same  hashcode,  the <br>
//!          contrary is not necessary. <br>
//! <br>
static /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCIntTools_CurveRangeSample^ S1, OCNaroWrappers::OCIntTools_CurveRangeSample^ S2) ;

~OCIntTools_CurveRangeSampleMapHasher()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
