// File generated by CPPExt (MPV)
//
#ifndef _MAT2d_BiInt_OCWrappers_HeaderFile
#define _MAT2d_BiInt_OCWrappers_HeaderFile

// include native header
#include <MAT2d_BiInt.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{



//! BiInt is a set of two integers. <br>
public ref class OCMAT2d_BiInt  {

protected:
  MAT2d_BiInt* nativeHandle;
  OCMAT2d_BiInt(OCDummy^) {};

public:
  property MAT2d_BiInt* Handle
  {
    MAT2d_BiInt* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCMAT2d_BiInt(MAT2d_BiInt* nativeHandle);

// Methods PUBLIC


OCMAT2d_BiInt(Standard_Integer I1, Standard_Integer I2);


 /*instead*/  Standard_Integer FirstIndex() ;


 /*instead*/  Standard_Integer SecondIndex() ;


 /*instead*/  void FirstIndex(Standard_Integer I1) ;


 /*instead*/  void SecondIndex(Standard_Integer I2) ;


 /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCMAT2d_BiInt^ B) ;

~OCMAT2d_BiInt()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
