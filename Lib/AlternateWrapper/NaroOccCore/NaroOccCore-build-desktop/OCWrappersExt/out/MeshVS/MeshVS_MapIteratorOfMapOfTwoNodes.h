// File generated by CPPExt (MPV)
//
#ifndef _MeshVS_MapIteratorOfMapOfTwoNodes_OCWrappers_HeaderFile
#define _MeshVS_MapIteratorOfMapOfTwoNodes_OCWrappers_HeaderFile

// include native header
#include <MeshVS_MapIteratorOfMapOfTwoNodes.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_BasicMapIterator.h"

#include "../TCollection/TCollection_BasicMapIterator.h"


namespace OCNaroWrappers
{

ref class OCMeshVS_TwoNodesHasher;
ref class OCMeshVS_MapOfTwoNodes;
ref class OCMeshVS_StdMapNodeOfMapOfTwoNodes;



public ref class OCMeshVS_MapIteratorOfMapOfTwoNodes  : public OCTCollection_BasicMapIterator {

protected:
  // dummy constructor;
  OCMeshVS_MapIteratorOfMapOfTwoNodes(OCDummy^) : OCTCollection_BasicMapIterator((OCDummy^)nullptr) {};

public:

// constructor from native
OCMeshVS_MapIteratorOfMapOfTwoNodes(MeshVS_MapIteratorOfMapOfTwoNodes* nativeHandle);

// Methods PUBLIC


OCMeshVS_MapIteratorOfMapOfTwoNodes();


OCMeshVS_MapIteratorOfMapOfTwoNodes(OCNaroWrappers::OCMeshVS_MapOfTwoNodes^ aMap);


 /*instead*/  void Initialize(OCNaroWrappers::OCMeshVS_MapOfTwoNodes^ aMap) ;


 /*instead*/  MeshVS_TwoNodes& Key() ;

~OCMeshVS_MapIteratorOfMapOfTwoNodes()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
