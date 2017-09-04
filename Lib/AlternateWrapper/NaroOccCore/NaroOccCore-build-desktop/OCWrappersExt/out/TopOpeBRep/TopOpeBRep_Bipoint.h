// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRep_Bipoint_OCWrappers_HeaderFile
#define _TopOpeBRep_Bipoint_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRep_Bipoint.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{




public ref class OCTopOpeBRep_Bipoint  {

protected:
  TopOpeBRep_Bipoint* nativeHandle;
  OCTopOpeBRep_Bipoint(OCDummy^) {};

public:
  property TopOpeBRep_Bipoint* Handle
  {
    TopOpeBRep_Bipoint* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopOpeBRep_Bipoint(TopOpeBRep_Bipoint* nativeHandle);

// Methods PUBLIC


OCTopOpeBRep_Bipoint();


OCTopOpeBRep_Bipoint(Standard_Integer I1, Standard_Integer I2);


 /*instead*/  Standard_Integer I1() ;


 /*instead*/  Standard_Integer I2() ;

~OCTopOpeBRep_Bipoint()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
