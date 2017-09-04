// File generated by CPPExt (MPV)
//
#ifndef _MAT2d_SequenceOfSequenceOfGeometry_OCWrappers_HeaderFile
#define _MAT2d_SequenceOfSequenceOfGeometry_OCWrappers_HeaderFile

// include native header
#include <MAT2d_SequenceOfSequenceOfGeometry.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCTColGeom2d_SequenceOfGeometry;
ref class OCMAT2d_SequenceNodeOfSequenceOfSequenceOfGeometry;



public ref class OCMAT2d_SequenceOfSequenceOfGeometry  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCMAT2d_SequenceOfSequenceOfGeometry(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCMAT2d_SequenceOfSequenceOfGeometry(MAT2d_SequenceOfSequenceOfGeometry* nativeHandle);

// Methods PUBLIC


OCMAT2d_SequenceOfSequenceOfGeometry();


 /*instead*/  OCMAT2d_SequenceOfSequenceOfGeometry^ Assign(OCNaroWrappers::OCMAT2d_SequenceOfSequenceOfGeometry^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCTColGeom2d_SequenceOfGeometry^ T) ;


 /*instead*/  void Append(OCNaroWrappers::OCMAT2d_SequenceOfSequenceOfGeometry^ S) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTColGeom2d_SequenceOfGeometry^ T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCMAT2d_SequenceOfSequenceOfGeometry^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCTColGeom2d_SequenceOfGeometry^ T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCMAT2d_SequenceOfSequenceOfGeometry^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCTColGeom2d_SequenceOfGeometry^ T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCMAT2d_SequenceOfSequenceOfGeometry^ S) ;


 /*instead*/  OCTColGeom2d_SequenceOfGeometry^ First() ;


 /*instead*/  OCTColGeom2d_SequenceOfGeometry^ Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCMAT2d_SequenceOfSequenceOfGeometry^ Sub) ;


 /*instead*/  OCTColGeom2d_SequenceOfGeometry^ Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCTColGeom2d_SequenceOfGeometry^ I) ;


 /*instead*/  OCTColGeom2d_SequenceOfGeometry^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCMAT2d_SequenceOfSequenceOfGeometry()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif