// File generated by CPPExt (MPV)
//
#ifndef _BOPTools_ListIteratorOfListOfPaveBlock_OCWrappers_HeaderFile
#define _BOPTools_ListIteratorOfListOfPaveBlock_OCWrappers_HeaderFile

// include native header
#include <BOPTools_ListIteratorOfListOfPaveBlock.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCBOPTools_ListOfPaveBlock;
ref class OCBOPTools_PaveBlock;
ref class OCBOPTools_ListNodeOfListOfPaveBlock;



public ref class OCBOPTools_ListIteratorOfListOfPaveBlock  {

protected:
  BOPTools_ListIteratorOfListOfPaveBlock* nativeHandle;
  OCBOPTools_ListIteratorOfListOfPaveBlock(OCDummy^) {};

public:
  property BOPTools_ListIteratorOfListOfPaveBlock* Handle
  {
    BOPTools_ListIteratorOfListOfPaveBlock* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBOPTools_ListIteratorOfListOfPaveBlock(BOPTools_ListIteratorOfListOfPaveBlock* nativeHandle);

// Methods PUBLIC


OCBOPTools_ListIteratorOfListOfPaveBlock();


OCBOPTools_ListIteratorOfListOfPaveBlock(OCNaroWrappers::OCBOPTools_ListOfPaveBlock^ L);


 /*instead*/  void Initialize(OCNaroWrappers::OCBOPTools_ListOfPaveBlock^ L) ;


 /*instead*/  System::Boolean More() ;


 /*instead*/  void Next() ;


 /*instead*/  OCBOPTools_PaveBlock^ Value() ;

~OCBOPTools_ListIteratorOfListOfPaveBlock()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
