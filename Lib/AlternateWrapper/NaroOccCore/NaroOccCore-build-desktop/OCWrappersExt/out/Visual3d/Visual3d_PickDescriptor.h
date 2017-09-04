// File generated by CPPExt (MPV)
//
#ifndef _Visual3d_PickDescriptor_OCWrappers_HeaderFile
#define _Visual3d_PickDescriptor_OCWrappers_HeaderFile

// include native header
#include <Visual3d_PickDescriptor.hxx>
#include "../Converter.h"


#include "Visual3d_ContextPick.h"


namespace OCNaroWrappers
{

ref class OCVisual3d_HSequenceOfPickPath;
ref class OCVisual3d_ContextPick;
ref class OCVisual3d_PickPath;
ref class OCGraphic3d_Structure;


//! This class contains the pick information. <br>
//!	    It contains a certain number of PickPaths. <br>
public ref class OCVisual3d_PickDescriptor  {

protected:
  Visual3d_PickDescriptor* nativeHandle;
  OCVisual3d_PickDescriptor(OCDummy^) {};

public:
  property Visual3d_PickDescriptor* Handle
  {
    Visual3d_PickDescriptor* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCVisual3d_PickDescriptor(Visual3d_PickDescriptor* nativeHandle);

// Methods PUBLIC

//! Creates a PickDescriptor <me>. <br>
OCVisual3d_PickDescriptor(OCNaroWrappers::OCVisual3d_ContextPick^ CTX);

//! Adds a PickPath to PickDescriptor <me>. <br>
 /*instead*/  void AddPickPath(OCNaroWrappers::OCVisual3d_PickPath^ APickPath) ;

//! Erases all the information in <me>. <br>
 /*instead*/  void Clear() ;

//! Returns the pick depth, that is the <br>
//!	    number of PickPaths available in the PickDescriptor. <br>
 /*instead*/  Standard_Integer Depth() ;

//! Returns the group of PickPaths of <me>. <br>
 /*instead*/  OCVisual3d_HSequenceOfPickPath^ PickPath() ;

//! Returns the root structure. <br>
//!	    If the pick order was of the type TOO_TOPFIRST <br>
//!	    then it's the first structure. <br>
//!	    If the pick order was of the type TOO_BOTTOMFIRST <br>
//!	    Then it's the last structure. <br>
//!	    The pick order is set by the method SetOrder <br>
//!	    from ContextPick. <br>
//!  Category: Inquire methods <br>
//!  Warning: Raises PickError if Depth == 0 (no picked structure). <br>
 /*instead*/  OCGraphic3d_Structure^ TopStructure() ;

//! Returns the root structure pickid. <br>
//!	    If the pick order was of the type TOO_TOPFIRST <br>
//!	    then it's the first pickid. <br>
//!	    If the pick order was of the type TOO_BOTTOMFIRST <br>
//!	    then it's the last pickid. <br>
//!	    The pick order is set by the method SetOrder <br>
//!	    from ContextPick. <br>
//!  Category: Inquire methods <br>
//!  Warning: Raises PickError if Depth == 0 (no picked structure). <br>
 /*instead*/  Standard_Integer TopPickId() ;

//! Returns the root structure element number. <br>
//!	    If the pick order was of the type TOO_TOPFIRST <br>
//!	    then it's the first element number. <br>
//!	    If the pick order was of the type TOO_BOTTOMFIRST <br>
//!	    then it's the last element number. <br>
//!	    The pick order is set by the method SetOrder <br>
//!	    from ContextPick. <br>
//!  Category: Inquire methods <br>
//!  Warning: Raises PickError if Depth == 0 (no picked structure). <br>
 /*instead*/  Standard_Integer TopElementNumber() ;

~OCVisual3d_PickDescriptor()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
