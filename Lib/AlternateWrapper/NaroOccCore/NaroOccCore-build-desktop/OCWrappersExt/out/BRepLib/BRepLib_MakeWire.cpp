// File generated by CPPExt (CPP file)
//

#include "BRepLib_MakeWire.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Edge.h"
#include "../TopoDS/TopoDS_Wire.h"
#include "../TopTools/TopTools_ListOfShape.h"
#include "../TopoDS/TopoDS_Vertex.h"


using namespace OCNaroWrappers;

OCBRepLib_MakeWire::OCBRepLib_MakeWire(BRepLib_MakeWire* nativeHandle) : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  this->nativeHandle = nativeHandle;
}

OCBRepLib_MakeWire::OCBRepLib_MakeWire() : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepLib_MakeWire();
}

OCBRepLib_MakeWire::OCBRepLib_MakeWire(OCNaroWrappers::OCTopoDS_Edge^ E) : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepLib_MakeWire(*((TopoDS_Edge*)E->Handle));
}

OCBRepLib_MakeWire::OCBRepLib_MakeWire(OCNaroWrappers::OCTopoDS_Edge^ E1, OCNaroWrappers::OCTopoDS_Edge^ E2) : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepLib_MakeWire(*((TopoDS_Edge*)E1->Handle), *((TopoDS_Edge*)E2->Handle));
}

OCBRepLib_MakeWire::OCBRepLib_MakeWire(OCNaroWrappers::OCTopoDS_Edge^ E1, OCNaroWrappers::OCTopoDS_Edge^ E2, OCNaroWrappers::OCTopoDS_Edge^ E3) : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepLib_MakeWire(*((TopoDS_Edge*)E1->Handle), *((TopoDS_Edge*)E2->Handle), *((TopoDS_Edge*)E3->Handle));
}

OCBRepLib_MakeWire::OCBRepLib_MakeWire(OCNaroWrappers::OCTopoDS_Edge^ E1, OCNaroWrappers::OCTopoDS_Edge^ E2, OCNaroWrappers::OCTopoDS_Edge^ E3, OCNaroWrappers::OCTopoDS_Edge^ E4) : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepLib_MakeWire(*((TopoDS_Edge*)E1->Handle), *((TopoDS_Edge*)E2->Handle), *((TopoDS_Edge*)E3->Handle), *((TopoDS_Edge*)E4->Handle));
}

OCBRepLib_MakeWire::OCBRepLib_MakeWire(OCNaroWrappers::OCTopoDS_Wire^ W) : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepLib_MakeWire(*((TopoDS_Wire*)W->Handle));
}

OCBRepLib_MakeWire::OCBRepLib_MakeWire(OCNaroWrappers::OCTopoDS_Wire^ W, OCNaroWrappers::OCTopoDS_Edge^ E) : OCBRepLib_MakeShape((OCDummy^)nullptr)

{
  nativeHandle = new BRepLib_MakeWire(*((TopoDS_Wire*)W->Handle), *((TopoDS_Edge*)E->Handle));
}

 void OCBRepLib_MakeWire::Add(OCNaroWrappers::OCTopoDS_Edge^ E)
{
  ((BRepLib_MakeWire*)nativeHandle)->Add(*((TopoDS_Edge*)E->Handle));
}

 void OCBRepLib_MakeWire::Add(OCNaroWrappers::OCTopoDS_Wire^ W)
{
  ((BRepLib_MakeWire*)nativeHandle)->Add(*((TopoDS_Wire*)W->Handle));
}

 void OCBRepLib_MakeWire::Add(OCNaroWrappers::OCTopTools_ListOfShape^ L)
{
  ((BRepLib_MakeWire*)nativeHandle)->Add(*((TopTools_ListOfShape*)L->Handle));
}

 OCBRepLib_WireError OCBRepLib_MakeWire::Error()
{
  return (OCBRepLib_WireError)(((BRepLib_MakeWire*)nativeHandle)->Error());
}

OCTopoDS_Wire^ OCBRepLib_MakeWire::Wire()
{
  TopoDS_Wire* tmp = new TopoDS_Wire();
  *tmp = ((BRepLib_MakeWire*)nativeHandle)->Wire();
  return gcnew OCTopoDS_Wire(tmp);
}

OCTopoDS_Edge^ OCBRepLib_MakeWire::Edge()
{
  TopoDS_Edge* tmp = new TopoDS_Edge();
  *tmp = ((BRepLib_MakeWire*)nativeHandle)->Edge();
  return gcnew OCTopoDS_Edge(tmp);
}

OCTopoDS_Vertex^ OCBRepLib_MakeWire::Vertex()
{
  TopoDS_Vertex* tmp = new TopoDS_Vertex();
  *tmp = ((BRepLib_MakeWire*)nativeHandle)->Vertex();
  return gcnew OCTopoDS_Vertex(tmp);
}


