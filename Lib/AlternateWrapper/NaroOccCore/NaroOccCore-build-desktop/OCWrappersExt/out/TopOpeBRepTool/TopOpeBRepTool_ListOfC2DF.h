// File generated by CPPExt (MPV)
//
#ifndef _TopOpeBRepTool_ListOfC2DF_OCWrappers_HeaderFile
#define _TopOpeBRepTool_ListOfC2DF_OCWrappers_HeaderFile

// include native header
#include <TopOpeBRepTool_ListOfC2DF.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCTopOpeBRepTool_ListIteratorOfListOfC2DF;
ref class OCTopOpeBRepTool_C2DF;
ref class OCTopOpeBRepTool_ListNodeOfListOfC2DF;



public ref class OCTopOpeBRepTool_ListOfC2DF  {

protected:
  TopOpeBRepTool_ListOfC2DF* nativeHandle;
  OCTopOpeBRepTool_ListOfC2DF(OCDummy^) {};

public:
  property TopOpeBRepTool_ListOfC2DF* Handle
  {
    TopOpeBRepTool_ListOfC2DF* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopOpeBRepTool_ListOfC2DF(TopOpeBRepTool_ListOfC2DF* nativeHandle);

// Methods PUBLIC


OCTopOpeBRepTool_ListOfC2DF();


 /*instead*/  void Assign(OCNaroWrappers::OCTopOpeBRepTool_ListOfC2DF^ Other) ;


 /*instead*/  Standard_Integer Extent() ;


 /*instead*/  System::Boolean IsEmpty() ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I, OCNaroWrappers::OCTopOpeBRepTool_ListIteratorOfListOfC2DF^ theIt) ;


 /*instead*/  void Prepend(OCNaroWrappers::OCTopOpeBRepTool_ListOfC2DF^ Other) ;


 /*instead*/  void Append(OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I) ;


 /*instead*/  void Append(OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I, OCNaroWrappers::OCTopOpeBRepTool_ListIteratorOfListOfC2DF^ theIt) ;


 /*instead*/  void Append(OCNaroWrappers::OCTopOpeBRepTool_ListOfC2DF^ Other) ;


 /*instead*/  OCTopOpeBRepTool_C2DF^ First() ;


 /*instead*/  OCTopOpeBRepTool_C2DF^ Last() ;


 /*instead*/  void RemoveFirst() ;


 /*instead*/  void Remove(OCNaroWrappers::OCTopOpeBRepTool_ListIteratorOfListOfC2DF^ It) ;


 /*instead*/  void InsertBefore(OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I, OCNaroWrappers::OCTopOpeBRepTool_ListIteratorOfListOfC2DF^ It) ;


 /*instead*/  void InsertBefore(OCNaroWrappers::OCTopOpeBRepTool_ListOfC2DF^ Other, OCNaroWrappers::OCTopOpeBRepTool_ListIteratorOfListOfC2DF^ It) ;


 /*instead*/  void InsertAfter(OCNaroWrappers::OCTopOpeBRepTool_C2DF^ I, OCNaroWrappers::OCTopOpeBRepTool_ListIteratorOfListOfC2DF^ It) ;


 /*instead*/  void InsertAfter(OCNaroWrappers::OCTopOpeBRepTool_ListOfC2DF^ Other, OCNaroWrappers::OCTopOpeBRepTool_ListIteratorOfListOfC2DF^ It) ;

~OCTopOpeBRepTool_ListOfC2DF()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
