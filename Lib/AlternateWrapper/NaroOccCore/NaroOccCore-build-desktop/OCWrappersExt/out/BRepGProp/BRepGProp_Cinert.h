// File generated by CPPExt (MPV)
//
#ifndef _BRepGProp_Cinert_OCWrappers_HeaderFile
#define _BRepGProp_Cinert_OCWrappers_HeaderFile

// include native header
#include <BRepGProp_Cinert.hxx>
#include "../Converter.h"

#include "../GProp/GProp_GProps.h"

#include "../GProp/GProp_GProps.h"


namespace OCNaroWrappers
{

ref class OCBRepAdaptor_Curve;
ref class OCBRepGProp_EdgeTool;
ref class OCgp_Pnt;



public ref class OCBRepGProp_Cinert  : public OCGProp_GProps {

protected:
  // dummy constructor;
  OCBRepGProp_Cinert(OCDummy^) : OCGProp_GProps((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepGProp_Cinert(BRepGProp_Cinert* nativeHandle);

// Methods PUBLIC


OCBRepGProp_Cinert();


OCBRepGProp_Cinert(OCNaroWrappers::OCBRepAdaptor_Curve^ C, OCNaroWrappers::OCgp_Pnt^ CLocation);


 /*instead*/  void SetLocation(OCNaroWrappers::OCgp_Pnt^ CLocation) ;


 /*instead*/  void Perform(OCNaroWrappers::OCBRepAdaptor_Curve^ C) ;

~OCBRepGProp_Cinert()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
