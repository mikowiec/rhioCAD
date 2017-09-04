// File generated by CPPExt (Transient)
//
#ifndef _Graphic2d_HArray1OfVertex_OCWrappers_HeaderFile
#define _Graphic2d_HArray1OfVertex_OCWrappers_HeaderFile

// include the wrapped class
#include <Graphic2d_HArray1OfVertex.hxx>
#include "../Converter.h"

#include "../MMgt/MMgt_TShared.h"

#include "Graphic2d_Array1OfVertex.h"


namespace OCNaroWrappers
{

ref class OCGraphic2d_Vertex;
ref class OCGraphic2d_Array1OfVertex;



public ref class OCGraphic2d_HArray1OfVertex : OCMMgt_TShared {

protected:
  // dummy constructor;
  OCGraphic2d_HArray1OfVertex(OCDummy^) : OCMMgt_TShared((OCDummy^)nullptr) {};

public:

// constructor from native
OCGraphic2d_HArray1OfVertex(Handle(Graphic2d_HArray1OfVertex)* nativeHandle);

// Methods PUBLIC


OCGraphic2d_HArray1OfVertex(Standard_Integer Low, Standard_Integer Up);


OCGraphic2d_HArray1OfVertex(Standard_Integer Low, Standard_Integer Up, OCNaroWrappers::OCGraphic2d_Vertex^ V);


 /*instead*/  void Init(OCNaroWrappers::OCGraphic2d_Vertex^ V) ;


 /*instead*/  Standard_Integer Length() ;


 /*instead*/  Standard_Integer Lower() ;


 /*instead*/  Standard_Integer Upper() ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCGraphic2d_Vertex^ Value) ;


 /*instead*/  OCGraphic2d_Vertex^ Value(Standard_Integer Index) ;


 /*instead*/  OCGraphic2d_Vertex^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  OCGraphic2d_Array1OfVertex^ Array1() ;


 /*instead*/  OCGraphic2d_Array1OfVertex^ ChangeArray1() ;

~OCGraphic2d_HArray1OfVertex()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
