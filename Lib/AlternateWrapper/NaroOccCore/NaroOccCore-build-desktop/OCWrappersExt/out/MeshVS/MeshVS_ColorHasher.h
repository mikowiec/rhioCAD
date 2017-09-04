// File generated by CPPExt (MPV)
//
#ifndef _MeshVS_ColorHasher_OCWrappers_HeaderFile
#define _MeshVS_ColorHasher_OCWrappers_HeaderFile

// include native header
#include <MeshVS_ColorHasher.hxx>
#include "../Converter.h"

#include "../TColStd/TColStd_MapIntegerHasher.h"

#include "../TColStd/TColStd_MapIntegerHasher.h"


namespace OCNaroWrappers
{

ref class OCQuantity_Color;


//! Hasher for using in ColorToIdsMap from MeshVS <br>
public ref class OCMeshVS_ColorHasher  : public OCTColStd_MapIntegerHasher {

protected:
  // dummy constructor;
  OCMeshVS_ColorHasher(OCDummy^) : OCTColStd_MapIntegerHasher((OCDummy^)nullptr) {};

public:

// constructor from native
OCMeshVS_ColorHasher(MeshVS_ColorHasher* nativeHandle);

// Methods PUBLIC


static /*instead*/  Standard_Integer HashCode(OCNaroWrappers::OCQuantity_Color^ K, Standard_Integer Upper) ;


static /*instead*/  System::Boolean IsEqual(OCNaroWrappers::OCQuantity_Color^ K1, OCNaroWrappers::OCQuantity_Color^ K2) ;

~OCMeshVS_ColorHasher()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
