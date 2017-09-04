// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepDS_Surface_OCWrappers_HeaderFile
#define _TopOpeBRepDS_Surface_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepDS_Surface.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCGeom_Surface;


//! A Geom poimt and a tolerance. <br>
public ref class OCTopOpeBRepDS_Surface  {

protected:
  TopOpeBRepDS_Surface* nativeHandle;
  OCTopOpeBRepDS_Surface(OCDummy^) {};

public:
  property TopOpeBRepDS_Surface* Handle
  {
    TopOpeBRepDS_Surface* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopOpeBRepDS_Surface(TopOpeBRepDS_Surface* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepDS_Surface();


OCTopOpeBRepDS_Surface(OCNaroWrappers::OCGeom_Surface^ P, Standard_Real T);


OCTopOpeBRepDS_Surface(OCNaroWrappers::OCTopOpeBRepDS_Surface^ Other);


 /*instead*/  void Assign(OCNaroWrappers::OCTopOpeBRepDS_Surface^ Other) ;


 /*instead*/  OCGeom_Surface^ Surface() ;


 /*instead*/  Standard_Real Tolerance() ;

//! Update the tolerance <br>
 /*instead*/  void Tolerance(Standard_Real tol) ;


 /*instead*/  System::Boolean Keep() ;


 /*instead*/  void ChangeKeep(System::Boolean B) ;

~OCTopOpeBRepDS_Surface()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
