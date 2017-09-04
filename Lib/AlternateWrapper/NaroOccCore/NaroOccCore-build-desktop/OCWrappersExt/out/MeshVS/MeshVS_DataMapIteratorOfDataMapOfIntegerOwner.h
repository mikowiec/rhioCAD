// File generated by CPPExt (MPV)
//
#ifndef _MeshVS_DataMapIteratorOfDataMapOfIntegerOwner_OCWrappers_HeaderFile
#define _MeshVS_DataMapIteratorOfDataMapOfIntegerOwner_OCWrappers_HeaderFile

// include native header
#include <MeshVS_DataMapIteratorOfDataMapOfIntegerOwner.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCSelectMgr_EntityOwner;
ref class OCTColStd_MapIntegerHasher;
ref class OCMeshVS_DataMapOfIntegerOwner;
ref class OCMeshVS_DataMapNodeOfDataMapOfIntegerOwner;



public ref class OCMeshVS_DataMapIteratorOfDataMapOfIntegerOwner  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCMeshVS_DataMapIteratorOfDataMapOfIntegerOwner(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCMeshVS_DataMapIteratorOfDataMapOfIntegerOwner(MeshVS_DataMapIteratorOfDataMapOfIntegerOwner* nativeHandle);

// Methods PUBLIC


OCMeshVS_DataMapIteratorOfDataMapOfIntegerOwner();


OCMeshVS_DataMapIteratorOfDataMapOfIntegerOwner(OCNaroWrappers::OCMeshVS_DataMapOfIntegerOwner^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCMeshVS_DataMapOfIntegerOwner^ aMap) ;


 /*instead*/  Standard_Integer Key() ;


 /*instead*/  OCSelectMgr_EntityOwner^ Value() ;

~OCMeshVS_DataMapIteratorOfDataMapOfIntegerOwner()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
