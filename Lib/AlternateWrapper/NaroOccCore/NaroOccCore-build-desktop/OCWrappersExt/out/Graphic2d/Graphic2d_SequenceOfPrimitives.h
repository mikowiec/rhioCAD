// File generated by CPPExt (MPV)
//
#ifndef _Graphic2d_SequenceOfPrimitives_OCWrappers_HeaderFile
#define _Graphic2d_SequenceOfPrimitives_OCWrappers_HeaderFile

// include native header
#include <Graphic2d_SequenceOfPrimitives.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCGraphic2d_Primitive;
ref class OCGraphic2d_SequenceNodeOfSequenceOfPrimitives;



public ref class OCGraphic2d_SequenceOfPrimitives  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCGraphic2d_SequenceOfPrimitives(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCGraphic2d_SequenceOfPrimitives(Graphic2d_SequenceOfPrimitives* nativeHandle);

// Methods PUBLIC


OCGraphic2d_SequenceOfPrimitives();


 /*instead*/  OCGraphic2d_SequenceOfPrimitives^ Assign(OCNaroWrappers::OCGraphic2d_SequenceOfPrimitives^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCGraphic2d_Primitive^ T) ;


 /*instead*/  void Append(OCNaroWrappers::OCGraphic2d_SequenceOfPrimitives^ S) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCGraphic2d_Primitive^ T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCGraphic2d_SequenceOfPrimitives^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCGraphic2d_Primitive^ T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCGraphic2d_SequenceOfPrimitives^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCGraphic2d_Primitive^ T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCGraphic2d_SequenceOfPrimitives^ S) ;


 /*instead*/  OCGraphic2d_Primitive^ First() ;


 /*instead*/  OCGraphic2d_Primitive^ Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCGraphic2d_SequenceOfPrimitives^ Sub) ;


 /*instead*/  OCGraphic2d_Primitive^ Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCGraphic2d_Primitive^ I) ;


 /*instead*/  OCGraphic2d_Primitive^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCGraphic2d_SequenceOfPrimitives()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
