// File generated by CPPExt (MPV)
//
#ifndef _BOPTools_SequenceOfCurves_OCWrappers_HeaderFile
#define _BOPTools_SequenceOfCurves_OCWrappers_HeaderFile

// include native header
#include <BOPTools_SequenceOfCurves.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCBOPTools_Curve;
ref class OCBOPTools_SequenceNodeOfSequenceOfCurves;



public ref class OCBOPTools_SequenceOfCurves  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCBOPTools_SequenceOfCurves(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCBOPTools_SequenceOfCurves(BOPTools_SequenceOfCurves* nativeHandle);

// Methods PUBLIC


OCBOPTools_SequenceOfCurves();


 /*instead*/  OCBOPTools_SequenceOfCurves^ Assign(OCNaroWrappers::OCBOPTools_SequenceOfCurves^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCBOPTools_Curve^ T) ;


 /*instead*/  void Append(OCNaroWrappers::OCBOPTools_SequenceOfCurves^ S) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCBOPTools_Curve^ T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCBOPTools_SequenceOfCurves^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCBOPTools_Curve^ T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCBOPTools_SequenceOfCurves^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCBOPTools_Curve^ T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCBOPTools_SequenceOfCurves^ S) ;


 /*instead*/  OCBOPTools_Curve^ First() ;


 /*instead*/  OCBOPTools_Curve^ Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCBOPTools_SequenceOfCurves^ Sub) ;


 /*instead*/  OCBOPTools_Curve^ Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCBOPTools_Curve^ I) ;


 /*instead*/  OCBOPTools_Curve^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCBOPTools_SequenceOfCurves()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
