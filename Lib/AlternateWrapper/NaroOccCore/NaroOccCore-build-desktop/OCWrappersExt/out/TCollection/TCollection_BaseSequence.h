// File generated by CPPExt (MPV)
//
#ifndef _TCollection_BaseSequence_OCWrappers_HeaderFile
#define _TCollection_BaseSequence_OCWrappers_HeaderFile

// include native header
#include <TCollection_BaseSequence.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{



//! Definition of a base class for all instanciations <br>
//!          of sequence. <br>
//! <br>
//!          The methods : Clear, Remove accepts a pointer to a <br>
//!          function  to use  to delete the  nodes. This allow <br>
//!          proper    call of  the  destructor  on  the Items. <br>
//!          Without adding a  virtual function pointer to each <br>
//!          node or each sequence. <br>
public ref class OCTCollection_BaseSequence  {

protected:
  TCollection_BaseSequence* nativeHandle;
  OCTCollection_BaseSequence(OCDummy^) {};

public:
  property TCollection_BaseSequence* Handle
  {
    TCollection_BaseSequence* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTCollection_BaseSequence(TCollection_BaseSequence* nativeHandle);

// Methods PUBLIC

//! returns True if the sequence <me> contains no elements. <br>
 /*instead*/  System::Boolean IsEmpty() ;

//! Returns  the  number  of element(s) in the <br>
//! sequence.  Returns zero if the sequence is empty. <br>
 /*instead*/  Standard_Integer Length() ;

//! Reverses the order of items on <me>. <br>
//!  Example: <br>
//! before <br>
//!   me = (A B C) <br>
//! after <br>
//!   me = (C B A) <br>
 /*instead*/  void Reverse() ;

//! Swaps  elements  which    are  located  at <br>
//! positions <I> and <J> in <me>. <br>
//! Raises an exception if I or J is out of bound. <br>
//!  Example: <br>
//! before <br>
//!   me = (A B C), I = 1, J = 3 <br>
//! after <br>
//!   me = (C B A) <br>
 /*instead*/  void Exchange(Standard_Integer I, Standard_Integer J) ;

~OCTCollection_BaseSequence()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
