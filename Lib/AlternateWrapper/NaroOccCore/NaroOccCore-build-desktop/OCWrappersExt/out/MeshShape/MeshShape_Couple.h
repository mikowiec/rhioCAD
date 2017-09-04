// File generated by CPPExt (MPV)
//
#ifndef _MeshShape_Couple_OCWrappers_HeaderFile
#define _MeshShape_Couple_OCWrappers_HeaderFile

// include native header
#include <MeshShape_Couple.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{




public ref class OCMeshShape_Couple  {

protected:
  MeshShape_Couple* nativeHandle;
  OCMeshShape_Couple(OCDummy^) {};

public:
  property MeshShape_Couple* Handle
  {
    MeshShape_Couple* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCMeshShape_Couple(MeshShape_Couple* nativeHandle);

// Methods PUBLIC


OCMeshShape_Couple();


OCMeshShape_Couple(Standard_Integer I1, Standard_Integer I2);


 /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCMeshShape_Couple^ other) ;

//! Returns a hashed value  denoting <me>.  This value <br>
//!          is in the range  1..<Upper>. <br>
//! <br>
 /*instead*/  Standard_Integer HashCode(Standard_Integer Upper) ;

~OCMeshShape_Couple()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
