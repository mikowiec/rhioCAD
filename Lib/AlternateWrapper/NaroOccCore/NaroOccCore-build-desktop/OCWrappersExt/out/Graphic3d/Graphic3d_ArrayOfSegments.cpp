// File generated by CPPExt (CPP file)
//

#include "Graphic3d_ArrayOfSegments.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCGraphic3d_ArrayOfSegments::OCGraphic3d_ArrayOfSegments(Handle(Graphic3d_ArrayOfSegments)* nativeHandle) : OCGraphic3d_ArrayOfPrimitives((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Graphic3d_ArrayOfSegments(*nativeHandle);
}

OCGraphic3d_ArrayOfSegments::OCGraphic3d_ArrayOfSegments(Standard_Integer maxVertexs, Standard_Integer maxEdges, System::Boolean hasVColors) : OCGraphic3d_ArrayOfPrimitives((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_ArrayOfSegments(new Graphic3d_ArrayOfSegments(maxVertexs, maxEdges, OCConverter::BooleanToStandardBoolean(hasVColors)));
}


