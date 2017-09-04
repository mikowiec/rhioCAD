// File generated by CPPExt (MPV)
//
#ifndef _ChFiDS_ListIteratorOfListOfHElSpine_OCWrappers_HeaderFile
#define _ChFiDS_ListIteratorOfListOfHElSpine_OCWrappers_HeaderFile

// include native header
#include <ChFiDS_ListIteratorOfListOfHElSpine.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCChFiDS_ListOfHElSpine;
ref class OCChFiDS_HElSpine;
ref class OCChFiDS_ListNodeOfListOfHElSpine;



public ref class OCChFiDS_ListIteratorOfListOfHElSpine  {

protected:
  ChFiDS_ListIteratorOfListOfHElSpine* nativeHandle;
  OCChFiDS_ListIteratorOfListOfHElSpine(OCDummy^) {};

public:
  property ChFiDS_ListIteratorOfListOfHElSpine* Handle
  {
    ChFiDS_ListIteratorOfListOfHElSpine* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCChFiDS_ListIteratorOfListOfHElSpine(ChFiDS_ListIteratorOfListOfHElSpine* nativeHandle);

// Methods PUBLIC


OCChFiDS_ListIteratorOfListOfHElSpine();


OCChFiDS_ListIteratorOfListOfHElSpine(OCNaroWrappers::OCChFiDS_ListOfHElSpine^ L);


 /*instead*/  void Initialize(OCNaroWrappers::OCChFiDS_ListOfHElSpine^ L) ;


 /*instead*/  System::Boolean More() ;


 /*instead*/  void Next() ;


 /*instead*/  OCChFiDS_HElSpine^ Value() ;

~OCChFiDS_ListIteratorOfListOfHElSpine()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
