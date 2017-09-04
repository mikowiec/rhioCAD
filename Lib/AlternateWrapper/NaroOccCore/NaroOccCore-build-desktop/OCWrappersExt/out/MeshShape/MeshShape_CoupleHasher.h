// File generated by CPPExt (MPV)
//
#ifndef _MeshShape_CoupleHasher_OCWrappers_HeaderFile
#define _MeshShape_CoupleHasher_OCWrappers_HeaderFile

// include native header
#include <MeshShape_CoupleHasher.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{

ref class OCMeshShape_Couple;



public ref class OCMeshShape_CoupleHasher  {

protected:
  MeshShape_CoupleHasher* nativeHandle;
  OCMeshShape_CoupleHasher(OCDummy^) {};

public:
  property MeshShape_CoupleHasher* Handle
  {
    MeshShape_CoupleHasher* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCMeshShape_CoupleHasher(MeshShape_CoupleHasher* nativeHandle);

// Methods PUBLIC

//! Returns a HasCode value  for  the  Key <K>  in the <br>
//!          range 0..Upper. <br>
static /*instead*/  Standard_Integer HashCode(OCNaroWrappers::OCMeshShape_Couple^ S, Standard_Integer Upper) ;

//! Returns True  when the two  keys are the same. Two <br>
//!          same  keys  must   have  the  same  hashcode,  the <br>
//!          contrary is not necessary. <br>
//! <br>
static /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCMeshShape_Couple^ S1, OCNaroWrappers::OCMeshShape_Couple^ S2) ;

~OCMeshShape_CoupleHasher()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
