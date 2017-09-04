// File generated by CPPExt (Transient)
//
#ifndef _AppParCurves_HArray1OfMultiCurve_OCWrappers_HeaderFile
#define _AppParCurves_HArray1OfMultiCurve_OCWrappers_HeaderFile

// include the wrapped class
#include <AppParCurves_HArray1OfMultiCurve.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "AppParCurves_Array1OfMultiCurve.h"


namespace OCNaroWrappers
{

ref class OCAppParCurves_MultiCurve;
ref class OCAppParCurves_Array1OfMultiCurve;



public ref class OCAppParCurves_HArray1OfMultiCurve : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCAppParCurves_HArray1OfMultiCurve(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCAppParCurves_HArray1OfMultiCurve(Handle(AppParCurves_HArray1OfMultiCurve)* nativeHandle);

// Methods PUBLIC


OCAppParCurves_HArray1OfMultiCurve(Standard_Integer Low, Standard_Integer Up);


OCAppParCurves_HArray1OfMultiCurve(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCAppParCurves_MultiCurve^ V);


 /*instead*/  void Init(OCNaroWrappers::OCAppParCurves_MultiCurve^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCAppParCurves_MultiCurve^ Value) ;


 /*instead*/  OCAppParCurves_MultiCurve^ Value(Standard_Integer Index) ;


 /*instead*/  OCAppParCurves_MultiCurve^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCAppParCurves_Array1OfMultiCurve^ Array1() ;


 /*instead*/  OCAppParCurves_Array1OfMultiCurve^ ChangeArray1() ;

~OCAppParCurves_HArray1OfMultiCurve()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
