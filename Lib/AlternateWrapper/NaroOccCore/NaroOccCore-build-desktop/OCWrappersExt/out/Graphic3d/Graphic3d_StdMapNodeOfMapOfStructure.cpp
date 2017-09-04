// File generated by CPPExt (CPP file)
//

#include "Graphic3d_StdMapNodeOfMapOfStructure.h"
#include "../Converter.h"
#include "Graphic3d_Structure.h"
#include "../TColStd/TColStd_MapTransientHasher.h"
#include "Graphic3d_MapOfStructure.h"
#include "Graphic3d_MapIteratorOfMapOfStructure.h"


using namespace OCNaroWrappers;

OCGraphic3d_StdMapNodeOfMapOfStructure::OCGraphic3d_StdMapNodeOfMapOfStructure(Handle(Graphic3d_StdMapNodeOfMapOfStructure)* nativeHandle) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Graphic3d_StdMapNodeOfMapOfStructure(*nativeHandle);
}

OCGraphic3d_StdMapNodeOfMapOfStructure::OCGraphic3d_StdMapNodeOfMapOfStructure(OCNaroWrappers::OCGraphic3d_Structure^ K, TCollection_MapNodePtr n) : OCTCollection_MapNode((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_StdMapNodeOfMapOfStructure(new Graphic3d_StdMapNodeOfMapOfStructure(*((Handle_Graphic3d_Structure*)K->Handle), n));
}

OCGraphic3d_Structure^ OCGraphic3d_StdMapNodeOfMapOfStructure::Key()
{
  Handle(Graphic3d_Structure) tmp = (*((Handle_Graphic3d_StdMapNodeOfMapOfStructure*)nativeHandle))->Key();
  return gcnew OCGraphic3d_Structure(&tmp);
}


