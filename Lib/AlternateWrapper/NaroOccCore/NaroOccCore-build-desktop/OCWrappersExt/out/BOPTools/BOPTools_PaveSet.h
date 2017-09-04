// File generated by CPPExt (MPV)
//
#ifndef _BOPTools_PaveSet_OCWrappers_HeaderFile
#define _BOPTools_PaveSet_OCWrappers_HeaderFile

// include native header
#include <BOPTools_PaveSet.hxx>
#include "../Converter.h"


#include "BOPTools_ListOfPave.h"


namespace OCNaroWrappers
{

ref class OCBOPTools_ListOfPave;
ref class OCBOPTools_Pave;



//! class for storing/sorting paves that <br>
//! belong to an edge <br>
public ref class OCBOPTools_PaveSet  {

protected:
  BOPTools_PaveSet* nativeHandle;
  OCBOPTools_PaveSet(OCDummy^) {};

public:
  property BOPTools_PaveSet* Handle
  {
    BOPTools_PaveSet* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCBOPTools_PaveSet(BOPTools_PaveSet* nativeHandle);

// Methods PUBLIC


//! Empty constructor <br>
OCBOPTools_PaveSet();


//! Access to the  list <br>
 /*instead*/  OCBOPTools_ListOfPave^ ChangeSet() ;


//! Access to the  list const <br>
 /*instead*/  OCBOPTools_ListOfPave^ Set() ;


//! Appends <aPave>  to the  list <br>
 /*instead*/  void Append(OCNaroWrappers::OCBOPTools_Pave^ aPave) ;


//! Sorts  list in increasing order of paves' parameters <br>
 /*instead*/  void SortSet() ;

~OCBOPTools_PaveSet()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
