// File generated by CPPExt (Transient)
//
#ifndef _BRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger_OCWrappers_HeaderFile
#define _BRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger_OCWrappers_HeaderFile

// include the wrapped class
#include <BRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"

#include "BRepMesh_Vertex.h"


namespace OCNaroWrappers
{

ref class OCBRepMesh_Vertex;
ref class OCBRepMesh_VertexHasher;
ref class OCBRepMesh_DataMapOfMeshVertexInteger;
ref class OCBRepMesh_DataMapIteratorOfDataMapOfMeshVertexInteger;



public ref class OCBRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCBRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCBRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger(Handle(BRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger)* nativeHandle);

// Methods PUBLIC


OCBRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger(OCNaroWrappers::OCBRepMesh_Vertex^ K, Standard_Integer I, TCollection_MapNodePtr n);


 /*instead*/  OCBRepMesh_Vertex^ Key() ;


 /*instead*/  Standard_Integer Value() ;

~OCBRepMesh_DataMapNodeOfDataMapOfMeshVertexInteger()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
