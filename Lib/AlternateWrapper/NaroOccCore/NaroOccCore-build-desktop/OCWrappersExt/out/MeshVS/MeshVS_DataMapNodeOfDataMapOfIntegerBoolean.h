// File generated by CPPExt (Transient)
//
#ifndef _MeshVS_DataMapNodeOfDataMapOfIntegerBoolean_OCWrappers_HeaderFile
#define _MeshVS_DataMapNodeOfDataMapOfIntegerBoolean_OCWrappers_HeaderFile

// include the wrapped class
#include <MeshVS_DataMapNodeOfDataMapOfIntegerBoolean.hxx>
#include "../Converter.h"

#include "../TCollection/TCollection_MapNode.h"



namespace OCNaroWrappers
{

ref class OCTColStd_MapIntegerHasher;
ref class OCMeshVS_DataMapOfIntegerBoolean;
ref class OCMeshVS_DataMapIteratorOfDataMapOfIntegerBoolean;



public ref class OCMeshVS_DataMapNodeOfDataMapOfIntegerBoolean : OCTCollection_MapNode {

protected:
  // dummy constructor;
  OCMeshVS_DataMapNodeOfDataMapOfIntegerBoolean(OCDummy^) : OCTCollection_MapNode((OCDummy^)nullptr) {};

public:

// constructor from native
OCMeshVS_DataMapNodeOfDataMapOfIntegerBoolean(Handle(MeshVS_DataMapNodeOfDataMapOfIntegerBoolean)* nativeHandle);

// Methods PUBLIC


OCMeshVS_DataMapNodeOfDataMapOfIntegerBoolean(Standard_Integer K, System::Boolean I, TCollection_MapNodePtr n);


 /*instead*/  Standard_Integer Key() ;


 /*instead*/  System::Boolean Value() ;

~OCMeshVS_DataMapNodeOfDataMapOfIntegerBoolean()
{
  nativeHandle->Nullify();
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
