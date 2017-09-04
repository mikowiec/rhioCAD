// File generated by CPPExt (MPV)
//
#ifndef _TColStd_MapTransientHasher_OCWrappers_HeaderFile
#define _TColStd_MapTransientHasher_OCWrappers_HeaderFile

// include native header
#include <TColStd_MapTransientHasher.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCStandard_Transient;



public ref class OCTColStd_MapTransientHasher  {

protected:
  TColStd_MapTransientHasher* nativeHandle;
  OCTColStd_MapTransientHasher(OCDummy^) {};

public:
  property TColStd_MapTransientHasher* Handle
  {
    TColStd_MapTransientHasher* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTColStd_MapTransientHasher(TColStd_MapTransientHasher* nativeHandle);

// Methods PUBLIC


static /*instead*/  Standard_Integer HashCode(OCNaroWrappers::OCStandard_Transient^ K, Standard_Integer Upper) ;


static /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCStandard_Transient^ K1, OCNaroWrappers::OCStandard_Transient^ K2) ;

~OCTColStd_MapTransientHasher()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
