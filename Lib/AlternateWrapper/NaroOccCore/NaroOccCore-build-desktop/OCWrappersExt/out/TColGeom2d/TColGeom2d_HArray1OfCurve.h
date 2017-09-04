// File generated by CPPExt (Transient)
//
#ifndef _TColGeom2d_HArray1OfCurve_OCWrappers_HeaderFile
#define _TColGeom2d_HArray1OfCurve_OCWrappers_HeaderFile

// include the wrapped class
#include <TColGeom2d_HArray1OfCurve.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "TColGeom2d_Array1OfCurve.h"


namespace OCNaroWrappers
{

ref class OCGeom2d_Curve;
ref class OCTColGeom2d_Array1OfCurve;



public ref class OCTColGeom2d_HArray1OfCurve : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCTColGeom2d_HArray1OfCurve(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCTColGeom2d_HArray1OfCurve(Handle(TColGeom2d_HArray1OfCurve)* nativeHandle);

// Methods PUBLIC


OCTColGeom2d_HArray1OfCurve(Standard_Integer Low, Standard_Integer Up);


OCTColGeom2d_HArray1OfCurve(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCGeom2d_Curve^ V);


 /*instead*/  void Init(OCNaroWrappers::OCGeom2d_Curve^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCGeom2d_Curve^ Value) ;


 /*instead*/  OCGeom2d_Curve^ Value(Standard_Integer Index) ;


 /*instead*/  OCGeom2d_Curve^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCTColGeom2d_Array1OfCurve^ Array1() ;


 /*instead*/  OCTColGeom2d_Array1OfCurve^ ChangeArray1() ;

~OCTColGeom2d_HArray1OfCurve()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
