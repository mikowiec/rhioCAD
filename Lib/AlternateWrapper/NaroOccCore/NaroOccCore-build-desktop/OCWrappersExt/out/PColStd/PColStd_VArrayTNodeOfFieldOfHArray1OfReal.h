// File generated by CPPExt (MPV)
//
#ifndef _PColStd_VArrayTNodeOfFieldOfHArray1OfReal_OCWrappers_HeaderFile
#define _PColStd_VArrayTNodeOfFieldOfHArray1OfReal_OCWrappers_HeaderFile

// include native header
#include <PColStd_VArrayTNodeOfFieldOfHArray1OfReal.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCPColStd_FieldOfHArray1OfReal;
ref class OCPColStd_VArrayNodeOfFieldOfHArray1OfReal;



public ref class OCPColStd_VArrayTNodeOfFieldOfHArray1OfReal  {

protected:
  PColStd_VArrayTNodeOfFieldOfHArray1OfReal* nativeHandle;
  OCPColStd_VArrayTNodeOfFieldOfHArray1OfReal(OCDummy^) {};

public:
  property PColStd_VArrayTNodeOfFieldOfHArray1OfReal* Handle
  {
    PColStd_VArrayTNodeOfFieldOfHArray1OfReal* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCPColStd_VArrayTNodeOfFieldOfHArray1OfReal(PColStd_VArrayTNodeOfFieldOfHArray1OfReal* nativeHandle);

// Methods PUBLIC


OCPColStd_VArrayTNodeOfFieldOfHArray1OfReal();


OCPColStd_VArrayTNodeOfFieldOfHArray1OfReal(Standard_Real aValue);


 /*instead*/  void SetValue(Standard_Real aValue) ;


 /*instead*/  Standard_Address Value() ;

~OCPColStd_VArrayTNodeOfFieldOfHArray1OfReal()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
