// File generated by CPPExt (CPP file)
//

#include "Graphic3d_ArrayOfTriangles.h"
#include "../Converter.h"


using namespace OCNaroWrappers;

OCGraphic3d_ArrayOfTriangles::OCGraphic3d_ArrayOfTriangles(Handle(Graphic3d_ArrayOfTriangles)* nativeHandle) : OCGraphic3d_ArrayOfPrimitives((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_Graphic3d_ArrayOfTriangles(*nativeHandle);
}

OCGraphic3d_ArrayOfTriangles::OCGraphic3d_ArrayOfTriangles(Standard_Integer maxVertexs, Standard_Integer maxEdges, System::Boolean hasVNormals, System::Boolean hasVColors, System::Boolean hasTexels, System::Boolean hasEdgeInfos) : OCGraphic3d_ArrayOfPrimitives((OCDummy^)nullptr)

{
  nativeHandle = new Handle_Graphic3d_ArrayOfTriangles(new Graphic3d_ArrayOfTriangles(maxVertexs, maxEdges, OCConverter::BooleanToStandardBoolean(hasVNormals), OCConverter::BooleanToStandardBoolean(hasVColors), OCConverter::BooleanToStandardBoolean(hasTexels), OCConverter::BooleanToStandardBoolean(hasEdgeInfos)));
}


