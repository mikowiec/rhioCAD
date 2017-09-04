// File generated by CPPExt (MPV)
//
#ifndef _TNaming_Builder_OCWrappers_HeaderFile
#define _TNaming_Builder_OCWrappers_HeaderFile

// include native header
#include <TNaming_Builder.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCTNaming_UsedShapes;
ref class OCTNaming_NamedShape;
ref class OCTDF_Label;
ref class OCTopoDS_Shape;


//! A tool to create and maintain topological attributes. <br>
//! Constructor creates an empty <br>
//! TNaming_NamedShape attribute at the given <br>
//! label. It allows adding "old shape" and "new <br>
//! shape" pairs with the specified evolution to this <br>
//! named shape. One evolution type per one <br>
//! builder must be used. <br>
public ref class OCTNaming_Builder  {

protected:
  TNaming_Builder* nativeHandle;
  OCTNaming_Builder(OCDummy^) {};

public:
  property TNaming_Builder* Handle
  {
    TNaming_Builder* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTNaming_Builder(TNaming_Builder* nativeHandle);

// Methods PUBLIC

//!  Create an   Builder. <br>
//!  Warning:  Before Addition copies the current Value, and clear <br>
OCTNaming_Builder(OCNaroWrappers::OCTDF_Label^ aLabel);

//!  Records the shape newShape which was <br>
//! generated during a topological construction. <br>
//!  As an example, consider the case of a face <br>
//!  generated in construction of a box. <br>
 /*instead*/  void Generated(OCNaroWrappers::OCTopoDS_Shape^ newShape) ;

//! Records the shape newShape which was <br>
//!  generated from the shape oldShape during a topological construction. <br>
//! As an example, consider the case of a face <br>
//! generated from an edge in construction of a prism. <br>
 /*instead*/  void Generated(OCNaroWrappers::OCTopoDS_Shape^ oldShape, OCNaroWrappers::OCTopoDS_Shape^ newShape) ;

//!  Records the shape oldShape which was deleted from the current label. <br>
//! As an example, consider the case of a face removed by a Boolean operation. <br>
 /*instead*/  void Delete(OCNaroWrappers::OCTopoDS_Shape^ oldShape) ;

//!  Records the shape newShape which is a <br>
//! modification of the shape oldShape. <br>
//! As an example, consider the case of a face split <br>
//!  or merged in a Boolean operation. <br>
//! <br>
 /*instead*/  void Modify(OCNaroWrappers::OCTopoDS_Shape^ oldShape, OCNaroWrappers::OCTopoDS_Shape^ newShape) ;

//!   Add a  Shape to the current label ,  This Shape is <br>
//!          unmodified.  Used for example  to define a set <br>
//!          of shapes under a label. <br>
 /*instead*/  void Select(OCNaroWrappers::OCTopoDS_Shape^ aShape, OCNaroWrappers::OCTopoDS_Shape^ inShape) ;

//! Returns the NamedShape which has been built or is under construction. <br>
 /*instead*/  OCTNaming_NamedShape^ NamedShape() ;

~OCTNaming_Builder()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
