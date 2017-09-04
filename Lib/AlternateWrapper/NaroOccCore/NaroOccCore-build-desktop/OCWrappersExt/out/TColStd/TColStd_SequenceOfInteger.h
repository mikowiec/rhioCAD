// File generated by CPPExt (MPV)
//
#ifndef _TColStd_SequenceOfInteger_OCWrappers_HeaderFile
#define _TColStd_SequenceOfInteger_OCWrappers_HeaderFile

// include native header
#include <TColStd_SequenceOfInteger.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCTColStd_SequenceNodeOfSequenceOfInteger;



public ref class OCTColStd_SequenceOfInteger  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCTColStd_SequenceOfInteger(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCTColStd_SequenceOfInteger(TColStd_SequenceOfInteger* nativeHandle);

// Methods PUBLIC


OCTColStd_SequenceOfInteger();


 /*instead*/  OCTColStd_SequenceOfInteger^ Assign(OCNaroWrappers::OCTColStd_SequenceOfInteger^ Other) ;


 /*instead*/  void Append(Standard_Integer T) ;


 /*instead*/  void Append(OCNaroWrappers::OCTColStd_SequenceOfInteger^ S) ;


 /*instead*/  void Prepend(Standard_Integer T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTColStd_SequenceOfInteger^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, Standard_Integer T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCTColStd_SequenceOfInteger^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, Standard_Integer T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCTColStd_SequenceOfInteger^ S) ;


 /*instead*/  Standard_Integer First() ;


 /*instead*/  Standard_Integer Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCTColStd_SequenceOfInteger^ Sub) ;


 /*instead*/  Standard_Integer Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, Standard_Integer I) ;


 /*instead*/  Standard_Integer ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCTColStd_SequenceOfInteger()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif