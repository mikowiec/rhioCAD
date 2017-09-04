// File generated by CPPExt (MPV)
//
#ifndef _IntSurf_SequenceOfInteriorPoint_OCWrappers_HeaderFile
#define _IntSurf_SequenceOfInteriorPoint_OCWrappers_HeaderFile

// include native header
#include <IntSurf_SequenceOfInteriorPoint.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCIntSurf_InteriorPoint;
ref class OCIntSurf_SequenceNodeOfSequenceOfInteriorPoint;



public ref class OCIntSurf_SequenceOfInteriorPoint  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCIntSurf_SequenceOfInteriorPoint(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCIntSurf_SequenceOfInteriorPoint(IntSurf_SequenceOfInteriorPoint* nativeHandle);

// Methods PUBLIC


OCIntSurf_SequenceOfInteriorPoint();


 /*instead*/  OCIntSurf_SequenceOfInteriorPoint^ Assign(OCNaroWrappers::OCIntSurf_SequenceOfInteriorPoint^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCIntSurf_InteriorPoint^ T) ;


 /*instead*/  void Append(OCNaroWrappers::OCIntSurf_SequenceOfInteriorPoint^ S) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCIntSurf_InteriorPoint^ T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCIntSurf_SequenceOfInteriorPoint^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCIntSurf_InteriorPoint^ T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCIntSurf_SequenceOfInteriorPoint^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCIntSurf_InteriorPoint^ T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCIntSurf_SequenceOfInteriorPoint^ S) ;


 /*instead*/  OCIntSurf_InteriorPoint^ First() ;


 /*instead*/  OCIntSurf_InteriorPoint^ Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCIntSurf_SequenceOfInteriorPoint^ Sub) ;


 /*instead*/  OCIntSurf_InteriorPoint^ Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCIntSurf_InteriorPoint^ I) ;


 /*instead*/  OCIntSurf_InteriorPoint^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCIntSurf_SequenceOfInteriorPoint()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
