// File generated by CPPExt (MPV)
//
#ifndef _TopoDS_Iterator_OCWrappers_HeaderFile
#define _TopoDS_Iterator_OCWrappers_HeaderFile

// include native header
#include <TopoDS_Iterator.hxx>
#include "../Converter.h"


#include "TopoDS_Shape.h"
#include "TopoDS_ListIteratorOfListOfShape.h"
#include "../TopAbs/TopAbs_Orientation.h"
#include "../TopLoc/TopLoc_Location.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;


//! Iterates on the underlying shape underlying a given <br>
//! TopoDS_Shape object, providing access to its <br>
//! component sub-shapes. Each component shape is <br>
//! returned as a TopoDS_Shape with an orientation, <br>
//! and a compound of the original values and the relative values. <br>
public ref class OCTopoDS_Iterator  {

protected:
  TopoDS_Iterator* nativeHandle;
  OCTopoDS_Iterator(OCDummy^) {};

public:
  property TopoDS_Iterator* Handle
  {
    TopoDS_Iterator* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopoDS_Iterator(TopoDS_Iterator* nativeHandle);

// Methods PUBLIC

//! Creates an empty Iterator. <br>
OCTopoDS_Iterator();

//! Creates an Iterator on <S> sub-shapes. <br>
//!      Note: <br>
//! - If cumOri is true, the function composes all <br>
//!   sub-shapes with the orientation of S. <br>
//! - If cumLoc is true, the function multiplies all <br>
//!   sub-shapes by the location of S, i.e. it applies to <br>
//!   each sub-shape the transformation that is associated with S. <br>
OCTopoDS_Iterator(OCNaroWrappers::OCTopoDS_Shape^ S, System::Boolean cumOri, System::Boolean cumLoc);

//! Initializes this iterator with shape S. <br>
//! Note: <br>
//! - If cumOri is true, the function composes all <br>
//!   sub-shapes with the orientation of S. <br>
//! - If cumLoc is true, the function multiplies all <br>
//!   sub-shapes by the location of S, i.e. it applies to <br>
//!   each sub-shape the transformation that is associated with S. <br>
 /*instead*/  void Initialize(OCNaroWrappers::OCTopoDS_Shape^ S, System::Boolean cumOri, System::Boolean cumLoc) ;

//! Returns true if there is another sub-shape in the <br>
//! shape which this iterator is scanning. <br>
 /*instead*/  System::Boolean More() ;

//! Moves on to the next sub-shape in the shape which <br>
//! this iterator is scanning. <br>
//! Exceptions <br>
//! Standard_NoMoreObject if there are no more sub-shapes in the shape. <br>
 /*instead*/  void Next() ;

//! Returns the current sub-shape in the shape which <br>
//! this iterator is scanning. <br>
//! Exceptions <br>
//! Standard_NoSuchObject if there is no current sub-shape. <br>
 /*instead*/  OCTopoDS_Shape^ Value() ;

~OCTopoDS_Iterator()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
