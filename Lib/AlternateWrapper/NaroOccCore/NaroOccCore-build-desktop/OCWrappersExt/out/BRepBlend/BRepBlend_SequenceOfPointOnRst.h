// File generated by CPPExt (MPV)
//
#ifndef _BRepBlend_SequenceOfPointOnRst_OCWrappers_HeaderFile
#define _BRepBlend_SequenceOfPointOnRst_OCWrappers_HeaderFile

// include native header
#include <BRepBlend_SequenceOfPointOnRst.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCBRepBlend_PointOnRst;
ref class OCBRepBlend_SequenceNodeOfSequenceOfPointOnRst;



public ref class OCBRepBlend_SequenceOfPointOnRst  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCBRepBlend_SequenceOfPointOnRst(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepBlend_SequenceOfPointOnRst(BRepBlend_SequenceOfPointOnRst* nativeHandle);

// Methods PUBLIC


OCBRepBlend_SequenceOfPointOnRst();


 /*instead*/  OCBRepBlend_SequenceOfPointOnRst^ Assign(OCNaroWrappers::OCBRepBlend_SequenceOfPointOnRst^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCBRepBlend_PointOnRst^ T) ;


 /*instead*/  void Append(OCNaroWrappers::OCBRepBlend_SequenceOfPointOnRst^ S) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCBRepBlend_PointOnRst^ T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCBRepBlend_SequenceOfPointOnRst^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCBRepBlend_PointOnRst^ T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCBRepBlend_SequenceOfPointOnRst^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCBRepBlend_PointOnRst^ T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCBRepBlend_SequenceOfPointOnRst^ S) ;


 /*instead*/  OCBRepBlend_PointOnRst^ First() ;


 /*instead*/  OCBRepBlend_PointOnRst^ Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCBRepBlend_SequenceOfPointOnRst^ Sub) ;


 /*instead*/  OCBRepBlend_PointOnRst^ Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCBRepBlend_PointOnRst^ I) ;


 /*instead*/  OCBRepBlend_PointOnRst^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCBRepBlend_SequenceOfPointOnRst()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
