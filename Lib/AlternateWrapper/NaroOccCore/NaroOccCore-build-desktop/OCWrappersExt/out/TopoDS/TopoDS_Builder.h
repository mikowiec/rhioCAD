// File generated by CPPExt (MPV)
//
#ifndef _TopoDS_Builder_OCWrappers_HeaderFile
#define _TopoDS_Builder_OCWrappers_HeaderFile

// include native header
#include <TopoDS_Builder.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCTopoDS_TShape;
ref class OCTopoDS_Wire;
ref class OCTopoDS_Shell;
ref class OCTopoDS_Solid;
ref class OCTopoDS_CompSolid;
ref class OCTopoDS_Compound;


//! A  Builder is used   to  create  Topological  Data <br>
//!          Structures. <br>
//! <br>
//!          There are three groups of methods in the Builder : <br>
//! <br>
//!          The Make methods create Shapes. <br>
//! <br>
//!          The Add method includes a Shape in another Shape. <br>
//! <br>
//!          The Remove  method  removes a  Shape from an other <br>
//!          Shape. <br>
//! <br>
//!          The methods in Builder are not static. They can be <br>
//!          redefined in inherited builders. <br>
public ref class OCTopoDS_Builder  {

protected:
  TopoDS_Builder* nativeHandle;
  OCTopoDS_Builder(OCDummy^) {};

public:
  property TopoDS_Builder* Handle
  {
    TopoDS_Builder* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCTopoDS_Builder(TopoDS_Builder* nativeHandle);

// Methods PUBLIC

//! Make an empty Wire. <br>
 /*instead*/  void MakeWire(OCNaroWrappers::OCTopoDS_Wire^ W) ;

//! Make an empty Shell. <br>
 /*instead*/  void MakeShell(OCNaroWrappers::OCTopoDS_Shell^ S) ;

//! Make a Solid covering the whole 3D space. <br>
 /*instead*/  void MakeSolid(OCNaroWrappers::OCTopoDS_Solid^ S) ;

//! Make an empty Composite Solid. <br>
 /*instead*/  void MakeCompSolid(OCNaroWrappers::OCTopoDS_CompSolid^ C) ;

//! Make an empty Compound. <br>
 /*instead*/  void MakeCompound(OCNaroWrappers::OCTopoDS_Compound^ C) ;

//! Add the Shape C in the Shape S. <br>
//! Exceptions <br>
//! - TopoDS_FrozenShape if S is not free and cannot be modified. <br>
//! - TopoDS__UnCompatibleShapes if S and C are not compatible. <br>
 /*instead*/  void Add(OCNaroWrappers::OCTopoDS_Shape^ S, OCNaroWrappers::OCTopoDS_Shape^ C) ;

//! Remove the Shape C from the Shape S. <br>
//! Exceptions <br>
//! TopoDS_FrozenShape if S is frozen and cannot be modified. <br>
 /*instead*/  void Remove(OCNaroWrappers::OCTopoDS_Shape^ S, OCNaroWrappers::OCTopoDS_Shape^ C) ;

~OCTopoDS_Builder()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
