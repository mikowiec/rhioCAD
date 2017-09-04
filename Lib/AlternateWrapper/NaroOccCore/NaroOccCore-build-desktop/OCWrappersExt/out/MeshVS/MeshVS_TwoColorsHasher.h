// File generated by CPPExt (MPV)
//
#ifndef _MeshVS_TwoColorsHasher_OCWrappers_HeaderFile
#define _MeshVS_TwoColorsHasher_OCWrappers_HeaderFile

// include native header
#include <MeshVS_TwoColorsHasher.hxx>
#include "../Converter.h"




namespace OCNaroWrappers
{




public ref class OCMeshVS_TwoColorsHasher  {

protected:
  MeshVS_TwoColorsHasher* nativeHandle;
  OCMeshVS_TwoColorsHasher(OCDummy^) {};

public:
  property MeshVS_TwoColorsHasher* Handle
  {
    MeshVS_TwoColorsHasher* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCMeshVS_TwoColorsHasher(MeshVS_TwoColorsHasher* nativeHandle);

// Methods PUBLIC


static /*instead*/  Standard_Integer HashCode(MeshVS_TwoColors K, Standard_Integer Upper) ;


static /*instead*/  System::Boolean IsEqual(MeshVS_TwoColors K1, MeshVS_TwoColors K2) ;

~OCMeshVS_TwoColorsHasher()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif