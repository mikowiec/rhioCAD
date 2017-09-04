// File generated by CPPExt (MPV)
//
#ifndef _Geom2dHatch_ClassifierOfHatcher_OCWrappers_HeaderFile
#define _Geom2dHatch_ClassifierOfHatcher_OCWrappers_HeaderFile

// include native header
#include <Geom2dHatch_ClassifierOfHatcher.hxx>
#include "../Converter.h"


#include "Geom2dHatch_FClass2dOfClassifierOfHatcher.h"
#include "../Geom2dAdaptor/Geom2dAdaptor_Curve.h"
#include "../IntRes2d/IntRes2d_Position.h"
#include "../TopAbs/TopAbs_State.h"


namespace OCNaroWrappers
{

ref class OCGeom2dHatch_ElementsOfHatcher;
ref class OCGeom2dAdaptor_Curve;
ref class OCGeom2dHatch_Intersector;
ref class OCGeom2dHatch_FClass2dOfClassifierOfHatcher;
ref class OCgp_Pnt2d;



public ref class OCGeom2dHatch_ClassifierOfHatcher  {

protected:
  Geom2dHatch_ClassifierOfHatcher* nativeHandle;
  OCGeom2dHatch_ClassifierOfHatcher(OCDummy^) {};

public:
  property Geom2dHatch_ClassifierOfHatcher* Handle
  {
    Geom2dHatch_ClassifierOfHatcher* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCGeom2dHatch_ClassifierOfHatcher(Geom2dHatch_ClassifierOfHatcher* nativeHandle);

// Methods PUBLIC


OCGeom2dHatch_ClassifierOfHatcher();


OCGeom2dHatch_ClassifierOfHatcher(OCNaroWrappers::OCGeom2dHatch_ElementsOfHatcher^ F, OCNaroWrappers::OCgp_Pnt2d^ P, Standard_Real Tol);


 /*instead*/  void Perform(OCNaroWrappers::OCGeom2dHatch_ElementsOfHatcher^ F, OCNaroWrappers::OCgp_Pnt2d^ P, Standard_Real Tol) ;


 /*instead*/  OCTopAbs_State State() ;


 /*instead*/  System::Boolean Rejected() ;


 /*instead*/  System::Boolean NoWires() ;


 /*instead*/  OCGeom2dAdaptor_Curve^ Edge() ;


 /*instead*/  Standard_Real EdgeParameter() ;


 /*instead*/  OCIntRes2d_Position Position() ;

~OCGeom2dHatch_ClassifierOfHatcher()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
