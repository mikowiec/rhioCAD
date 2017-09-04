// File generated by CPPExt (Transient)
//
#ifndef _TColgp_HArray1OfVec2d_OCWrappers_HeaderFile
#define _TColgp_HArray1OfVec2d_OCWrappers_HeaderFile

// include the wrapped class
#include <TColgp_HArray1OfVec2d.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "TColgp_Array1OfVec2d.h"


namespace OCNaroWrappers
{

ref class OCgp_Vec2d;
ref class OCTColgp_Array1OfVec2d;



public ref class OCTColgp_HArray1OfVec2d : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCTColgp_HArray1OfVec2d(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCTColgp_HArray1OfVec2d(Handle(TColgp_HArray1OfVec2d)* nativeHandle);

// Methods PUBLIC


OCTColgp_HArray1OfVec2d(Standard_Integer Low, Standard_Integer Up);


OCTColgp_HArray1OfVec2d(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCgp_Vec2d^ V);


 /*instead*/  void Init(OCNaroWrappers::OCgp_Vec2d^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCgp_Vec2d^ Value) ;


 /*instead*/  OCgp_Vec2d^ Value(Standard_Integer Index) ;


 /*instead*/  OCgp_Vec2d^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCTColgp_Array1OfVec2d^ Array1() ;


 /*instead*/  OCTColgp_Array1OfVec2d^ ChangeArray1() ;

~OCTColgp_HArray1OfVec2d()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
