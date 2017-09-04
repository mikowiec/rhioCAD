// File generated by CPPExt (Package)
//

#ifndef _BRepMesh_OCWrappers_HeaderFile
#define _BRepMesh_OCWrappers_HeaderFile

// Include the wrapped header
#include <BRepMesh.hxx>

#include "BRepMesh_Vertex.h"
#include "BRepMesh_Edge.h"
#include "BRepMesh_Triangle.h"
#include "BRepMesh_ShapeTool.h"
#include "BRepMesh_Circ.h"
#include "BRepMesh_DiscretRoot.h"
#include "BRepMesh_DiscretFactory.h"
#include "BRepMesh_ComparatorOfVertexOfDelaun.h"
#include "BRepMesh_ComparatorOfIndexedVertexOfDelaun.h"
#include "BRepMesh_SelectorOfDataStructureOfDelaun.h"
#include "BRepMesh_Delaun.h"
#include "BRepMesh_DataStructureOfDelaun.h"
#include "BRepMesh_CircleTool.h"
#include "BRepMesh_VertexTool.h"
#include "BRepMesh_Array1OfVertexOfDelaun.h"
#include "BRepMesh_HArray1OfVertexOfDelaun.h"
#include "BRepMesh_HeapSortVertexOfDelaun.h"
#include "BRepMesh_HeapSortIndexedVertexOfDelaun.h"
#include "BRepMesh_NodeHasherOfDataStructureOfDelaun.h"
#include "BRepMesh_LinkHasherOfDataStructureOfDelaun.h"
#include "BRepMesh_ElemHasherOfDataStructureOfDelaun.h"
#include "BRepMesh_DataMapOfIntegerListOfInteger.h"
#include "BRepMesh_IDMapOfNodeOfDataStructureOfDelaun.h"
#include "BRepMesh_IDMapOfLinkOfDataStructureOfDelaun.h"
#include "BRepMesh_IMapOfElementOfDataStructureOfDelaun.h"
#include "BRepMesh_DataMapOfVertexInteger.h"
#include "BRepMesh_ListOfVertex.h"
#include "BRepMesh_ListOfXY.h"
#include "BRepMesh_DataMapOfIntegerListOfXY.h"
#include "BRepMesh_VertexHasher.h"
#include "BRepMesh_IndexedMapOfVertex.h"
#include "BRepMesh_DataMapOfShapeReal.h"
#include "BRepMesh_BiPoint.h"
#include "BRepMesh_Array1OfBiPoint.h"
#include "BRepMesh_FastDiscretFace.h"
#include "BRepMesh_FastDiscret.h"
#include "BRepMesh_FaceAttribute.h"
#include "BRepMesh_DataMapOfFaceAttribute.h"
#include "BRepMesh_Classifier.h"
#include "BRepMesh_IncrementalMesh.h"
#include "BRepMesh_GeomTool.h"
#include "BRepMesh_DataMapOfIntegerPnt.h"
#include "BRepMesh_PairOfPolygon.h"
#include "BRepMesh_DataMapOfShapePairOfPolygon.h"
#include "BRepMesh_DataMapNodeOfDataMapOfIntegerListOfInteger.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfIntegerListOfInteger.h"
#include "BRepMesh_IndexedDataMapNodeOfIDMapOfNodeOfDataStructureOfDelaun.h"
#include "BRepMesh_IndexedDataMapNodeOfIDMapOfLinkOfDataStructureOfDelaun.h"
#include "BRepMesh_IndexedMapNodeOfIMapOfElementOfDataStructureOfDelaun.h"
#include "BRepMesh_DataMapNodeOfDataMapOfVertexInteger.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfVertexInteger.h"
#include "BRepMesh_ListNodeOfListOfVertex.h"
#include "BRepMesh_ListIteratorOfListOfVertex.h"
#include "BRepMesh_ListNodeOfListOfXY.h"
#include "BRepMesh_ListIteratorOfListOfXY.h"
#include "BRepMesh_DataMapNodeOfDataMapOfIntegerListOfXY.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfIntegerListOfXY.h"
#include "BRepMesh_IndexedMapNodeOfIndexedMapOfVertex.h"
#include "BRepMesh_DataMapNodeOfDataMapOfShapeReal.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfShapeReal.h"
#include "BRepMesh_DataMapNodeOfDataMapOfFaceAttribute.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfFaceAttribute.h"
#include "BRepMesh_DataMapNodeOfDataMapOfIntegerPnt.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfIntegerPnt.h"
#include "BRepMesh_DataMapNodeOfDataMapOfShapePairOfPolygon.h"
#include "BRepMesh_DataMapIteratorOfDataMapOfShapePairOfPolygon.h"


namespace OCNaroWrappers
{
//! Instantiated   package for the   class of packages <br>
public ref class OCBRepMesh abstract sealed
{

public:
// Methods

//! call to incremental mesh. <br>
static /*instead*/  void Mesh(OCNaroWrappers::OCTopoDS_Shape^ S, Standard_Real d) ;


};

}; // OCNaroWrappers

#endif
