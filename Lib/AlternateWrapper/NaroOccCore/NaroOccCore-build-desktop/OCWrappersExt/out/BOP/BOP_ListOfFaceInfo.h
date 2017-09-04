// File generated by CPPExt (MPV)
//
#ifndef _BOP_ListOfFaceInfo_OCWrappers_HeaderFile
#define _BOP_ListOfFaceInfo_OCWrappers_HeaderFile

// include native header
#include <BOP_ListOfFaceInfo.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCBOP_ListIteratorOfListOfFaceInfo;
ref class OCBOP_FaceInfo;
ref class OCBOP_ListNodeOfListOfFaceInfo;



public ref class OCBOP_ListOfFaceInfo  {

protected:
  BOP_ListOfFaceInfo* nativeHandle;
  OCBOP_ListOfFaceInfo(OCDummy^) {};

public:
  property BOP_ListOfFaceInfo* Handle
  {
    BOP_ListOfFaceInfo* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBOP_ListOfFaceInfo(BOP_ListOfFaceInfo* nativeHandle);

// Methods PUBLIC


OCBOP_ListOfFaceInfo();


 /*instead*/  void Assign(OCNaroWrappers::OCBOP_ListOfFaceInfo^ Other) ;


 /*instead*/  Standard_Integer Extent() ;


 /*instead*/  System::Boolean IsEmpty() ;


 /*instead*/  void Prepend(OCNaroWrappers::OCBOP_FaceInfo^ I) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCBOP_FaceInfo^ I, OCNaroWrappers::OCBOP_ListIteratorOfListOfFaceInfo^ theIt) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCBOP_ListOfFaceInfo^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCBOP_FaceInfo^ I) ;


 /*instead*/  void Append(OCNaroWrappers::OCBOP_FaceInfo^ I, OCNaroWrappers::OCBOP_ListIteratorOfListOfFaceInfo^ theIt) ;


 /*instead*/  void Append(OCNaroWrappers::OCBOP_ListOfFaceInfo^ Other) ;


 /*instead*/  OCBOP_FaceInfo^ First() ;


 /*instead*/  OCBOP_FaceInfo^ Last() ;


 /*instead*/  void RemoveFirst() ;


 /*instead*/  void Remove(OCNaroWrappers::OCBOP_ListIteratorOfListOfFaceInfo^ It) ;


 /*instead*/  void InsertBefore(OCNaroWrappers::OCBOP_FaceInfo^ I, OCNaroWrappers::OCBOP_ListIteratorOfListOfFaceInfo^ It) ;


 /*instead*/  void InsertBefore(OCNaroWrappers::OCBOP_ListOfFaceInfo^ Other, OCNaroWrappers::OCBOP_ListIteratorOfListOfFaceInfo^ It) ;


 /*instead*/  void InsertAfter(OCNaroWrappers::OCBOP_FaceInfo^ I, OCNaroWrappers::OCBOP_ListIteratorOfListOfFaceInfo^ It) ;


 /*instead*/  void InsertAfter(OCNaroWrappers::OCBOP_ListOfFaceInfo^ Other, OCNaroWrappers::OCBOP_ListIteratorOfListOfFaceInfo^ It) ;

~OCBOP_ListOfFaceInfo()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
