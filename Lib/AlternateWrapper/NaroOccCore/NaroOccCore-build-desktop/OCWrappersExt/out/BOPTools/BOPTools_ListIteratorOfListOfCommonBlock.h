// File generated by CPPExt (MPV)
//
#ifndef _BOPTools_ListIteratorOfListOfCommonBlock_OCWrappers_HeaderFile
#define _BOPTools_ListIteratorOfListOfCommonBlock_OCWrappers_HeaderFile

// include native header
#include <BOPTools_ListIteratorOfListOfCommonBlock.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCBOPTools_ListOfCommonBlock;
ref class OCBOPTools_CommonBlock;
ref class OCBOPTools_ListNodeOfListOfCommonBlock;



public ref class OCBOPTools_ListIteratorOfListOfCommonBlock  {

protected:
  BOPTools_ListIteratorOfListOfCommonBlock* nativeHandle;
  OCBOPTools_ListIteratorOfListOfCommonBlock(OCDummy^) {};

public:
  property BOPTools_ListIteratorOfListOfCommonBlock* Handle
  {
    BOPTools_ListIteratorOfListOfCommonBlock* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBOPTools_ListIteratorOfListOfCommonBlock(BOPTools_ListIteratorOfListOfCommonBlock* nativeHandle);

// Methods PUBLIC


OCBOPTools_ListIteratorOfListOfCommonBlock();


OCBOPTools_ListIteratorOfListOfCommonBlock(OCNaroWrappers::OCBOPTools_ListOfCommonBlock^ L);


 /*instead*/  void Initialize(OCNaroWrappers::OCBOPTools_ListOfCommonBlock^ L) ;


 /*instead*/  System::Boolean More() ;


 /*instead*/  void Next() ;


 /*instead*/  OCBOPTools_CommonBlock^ Value() ;

~OCBOPTools_ListIteratorOfListOfCommonBlock()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
