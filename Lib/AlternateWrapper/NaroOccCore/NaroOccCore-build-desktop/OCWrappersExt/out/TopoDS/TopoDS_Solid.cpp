// File generated by CPPExt (CPP file)
//

#include "TopoDS_Solid.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCTopoDS_Solid::OCTopoDS_Solid(TopoDS_Solid* nativeHandle) : OCTopoDS_Shape((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCTopoDS_Solid::OCTopoDS_Solid() : OCTopoDS_Shape((OCDummy^)nullptr)

{
  nativeHandle = new TopoDS_Solid();
}


