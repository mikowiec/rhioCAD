// File generated by CPPExt (MPV)
//
#ifndef _TNaming_ListOfIndexedDataMapOfShapeListOfShape_OCWrappers_HeaderFile
#define _TNaming_ListOfIndexedDataMapOfShapeListOfShape_OCWrappers_HeaderFile

// include native header
#include <TNaming_ListOfIndexedDataMapOfShapeListOfShape.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape;
ref class OCTopTools_IndexedDataMapOfShapeListOfShape;
ref class OCTNaming_ListNodeOfListOfIndexedDataMapOfShapeListOfShape;



public ref class OCTNaming_ListOfIndexedDataMapOfShapeListOfShape  {

protected:
  TNaming_ListOfIndexedDataMapOfShapeListOfShape* nativeHandle;
  OCTNaming_ListOfIndexedDataMapOfShapeListOfShape(OCDummy^) {};

public:
  property TNaming_ListOfIndexedDataMapOfShapeListOfShape* Handle
  {
    TNaming_ListOfIndexedDataMapOfShapeListOfShape* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTNaming_ListOfIndexedDataMapOfShapeListOfShape(TNaming_ListOfIndexedDataMapOfShapeListOfShape* nativeHandle);

// Methods PUBLIC


OCTNaming_ListOfIndexedDataMapOfShapeListOfShape();


 /*instead*/  void Assign(OCNaroWrappers::OCTNaming_ListOfIndexedDataMapOfShapeListOfShape^ Other) ;


 /*instead*/  Standard_Integer Extent() ;


 /*instead*/  System::Boolean IsEmpty() ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTopTools_IndexedDataMapOfShapeListOfShape^ I) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTopTools_IndexedDataMapOfShapeListOfShape^ I, OCNaroWrappers::OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape^ theIt) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTNaming_ListOfIndexedDataMapOfShapeListOfShape^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCTopTools_IndexedDataMapOfShapeListOfShape^ I) ;


 /*instead*/  void Append(OCNaroWrappers::OCTopTools_IndexedDataMapOfShapeListOfShape^ I, OCNaroWrappers::OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape^ theIt) ;


 /*instead*/  void Append(OCNaroWrappers::OCTNaming_ListOfIndexedDataMapOfShapeListOfShape^ Other) ;


 /*instead*/  OCTopTools_IndexedDataMapOfShapeListOfShape^ First() ;


 /*instead*/  OCTopTools_IndexedDataMapOfShapeListOfShape^ Last() ;


 /*instead*/  void RemoveFirst() ;


 /*instead*/  void Remove(OCNaroWrappers::OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape^ It) ;


 /*instead*/  void InsertBefore(OCNaroWrappers::OCTopTools_IndexedDataMapOfShapeListOfShape^ I, OCNaroWrappers::OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape^ It) ;


 /*instead*/  void InsertBefore(OCNaroWrappers::OCTNaming_ListOfIndexedDataMapOfShapeListOfShape^ Other, OCNaroWrappers::OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape^ It) ;


 /*instead*/  void InsertAfter(OCNaroWrappers::OCTopTools_IndexedDataMapOfShapeListOfShape^ I, OCNaroWrappers::OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape^ It) ;


 /*instead*/  void InsertAfter(OCNaroWrappers::OCTNaming_ListOfIndexedDataMapOfShapeListOfShape^ Other, OCNaroWrappers::OCTNaming_ListIteratorOfListOfIndexedDataMapOfShapeListOfShape^ It) ;

~OCTNaming_ListOfIndexedDataMapOfShapeListOfShape()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
