// File generated by CPPExt (Transient)
//
#ifndef _AppDef_HArray1OfMultiPointConstraint_OCWrappers_HeaderFile
#define _AppDef_HArray1OfMultiPointConstraint_OCWrappers_HeaderFile

// include the wrapped class
#include <AppDef_HArray1OfMultiPointConstraint.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "AppDef_Array1OfMultiPointConstraint.h"


namespace OCNaroWrappers
{

ref class OCAppDef_MultiPointConstraint;
ref class OCAppDef_Array1OfMultiPointConstraint;



public ref class OCAppDef_HArray1OfMultiPointConstraint : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCAppDef_HArray1OfMultiPointConstraint(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCAppDef_HArray1OfMultiPointConstraint(Handle(AppDef_HArray1OfMultiPointConstraint)* nativeHandle);

// Methods PUBLIC


OCAppDef_HArray1OfMultiPointConstraint(Standard_Integer Low, Standard_Integer Up);


OCAppDef_HArray1OfMultiPointConstraint(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCAppDef_MultiPointConstraint^ V);


 /*instead*/  void Init(OCNaroWrappers::OCAppDef_MultiPointConstraint^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCAppDef_MultiPointConstraint^ Value) ;


 /*instead*/  OCAppDef_MultiPointConstraint^ Value(Standard_Integer Index) ;


 /*instead*/  OCAppDef_MultiPointConstraint^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCAppDef_Array1OfMultiPointConstraint^ Array1() ;


 /*instead*/  OCAppDef_Array1OfMultiPointConstraint^ ChangeArray1() ;

~OCAppDef_HArray1OfMultiPointConstraint()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
