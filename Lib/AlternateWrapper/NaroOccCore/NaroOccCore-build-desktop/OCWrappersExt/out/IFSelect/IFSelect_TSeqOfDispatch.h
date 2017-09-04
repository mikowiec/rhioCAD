// File generated by CPPExt (MPV)
//
#ifndef _IFSelect_TSeqOfDispatch_OCWrappers_HeaderFile
#define _IFSelect_TSeqOfDispatch_OCWrappers_HeaderFile

// include native header
#include <IFSelect_TSeqOfDispatch.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BaseSequence.h"

#include "../TCollection/TCollection_BaseSequence.h"


namespace OCNaroWrappers
{

ref class OCIFSelect_Dispatch;
ref class OCIFSelect_SequenceNodeOfTSeqOfDispatch;



public ref class OCIFSelect_TSeqOfDispatch  : public OCTCollection_BaseSequence {

protected:
  // dummy constructor;
  OCIFSelect_TSeqOfDispatch(OCDummy^) : OCTCollection_BaseSequence((OCDummy^)nullptr) {};

public:

// constructor from native
OCIFSelect_TSeqOfDispatch(IFSelect_TSeqOfDispatch* nativeHandle);

// Methods PUBLIC


OCIFSelect_TSeqOfDispatch();


 /*instead*/  OCIFSelect_TSeqOfDispatch^ Assign(OCNaroWrappers::OCIFSelect_TSeqOfDispatch^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCIFSelect_Dispatch^ T) ;


 /*instead*/  void Append(OCNaroWrappers::OCIFSelect_TSeqOfDispatch^ S) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCIFSelect_Dispatch^ T) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCIFSelect_TSeqOfDispatch^ S) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCIFSelect_Dispatch^ T) ;


 /*instead*/  void InsertBefore(Standard_Integer Index, OCNaroWrappers::OCIFSelect_TSeqOfDispatch^ S) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCIFSelect_Dispatch^ T) ;


 /*instead*/  void InsertAfter(Standard_Integer Index, OCNaroWrappers::OCIFSelect_TSeqOfDispatch^ S) ;


 /*instead*/  OCIFSelect_Dispatch^ First() ;


 /*instead*/  OCIFSelect_Dispatch^ Last() ;


 /*instead*/  void Split(Standard_Integer Index, OCNaroWrappers::OCIFSelect_TSeqOfDispatch^ Sub) ;


 /*instead*/  OCIFSelect_Dispatch^ Value(Standard_Integer Index) ;


 /*instead*/  void SetValue(Standard_Integer Index, OCNaroWrappers::OCIFSelect_Dispatch^ I) ;


 /*instead*/  OCIFSelect_Dispatch^ ChangeValue(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer Index) ;


 /*instead*/  void Remove(Standard_Integer FromIndex, Standard_Integer ToIndex) ;

~OCIFSelect_TSeqOfDispatch()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
