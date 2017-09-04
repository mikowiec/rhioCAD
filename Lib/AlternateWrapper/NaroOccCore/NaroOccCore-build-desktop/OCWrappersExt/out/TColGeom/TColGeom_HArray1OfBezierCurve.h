// File generated by CPPExt (Transient)
//
#ifndef _TColGeom_HArray1OfBezierCurve_OCWrappers_HeaderFile
#define _TColGeom_HArray1OfBezierCurve_OCWrappers_HeaderFile

// include the wrapped class
#include <TColGeom_HArray1OfBezierCurve.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "TColGeom_Array1OfBezierCurve.h"


namespace OCNaroWrappers
{

ref class OCGeom_BezierCurve;
ref class OCTColGeom_Array1OfBezierCurve;



public ref class OCTColGeom_HArray1OfBezierCurve : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCTColGeom_HArray1OfBezierCurve(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCTColGeom_HArray1OfBezierCurve(Handle(TColGeom_HArray1OfBezierCurve)* nativeHandle);

// Methods PUBLIC


OCTColGeom_HArray1OfBezierCurve(Standard_Integer Low, Standard_Integer Up);


OCTColGeom_HArray1OfBezierCurve(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCGeom_BezierCurve^ V);


 /*instead*/  void Init(OCNaroWrappers::OCGeom_BezierCurve^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCGeom_BezierCurve^ Value) ;


 /*instead*/  OCGeom_BezierCurve^ Value(Standard_Integer Index) ;


 /*instead*/  OCGeom_BezierCurve^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCTColGeom_Array1OfBezierCurve^ Array1() ;


 /*instead*/  OCTColGeom_Array1OfBezierCurve^ ChangeArray1() ;

~OCTColGeom_HArray1OfBezierCurve()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif