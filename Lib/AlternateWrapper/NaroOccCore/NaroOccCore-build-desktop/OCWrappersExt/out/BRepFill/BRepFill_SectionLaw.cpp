// File generated by CPPExt (CPP file)
//

#include "BRepFill_SectionLaw.h"
#include "../Converter.h"
#include "../GeomFill/GeomFill_HArray1OfSectionLaw.h"
#include "../GeomFill/GeomFill_SectionLaw.h"
#include "../TopoDS/TopoDS_Vertex.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopoDS/TopoDS_Wire.h"
#include "../TopoDS/TopoDS_Edge.h"


using namespace OCNaroWrappers;

OCBRepFill_SectionLaw::OCBRepFill_SectionLaw(Handle(BRepFill_SectionLaw)* nativeHandle) : OCMMgt_TShared((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_BRepFill_SectionLaw(*nativeHandle);
}

 Standard_Integer OCBRepFill_SectionLaw::NbLaw()
{
  return (*((Handle_BRepFill_SectionLaw*)nativeHandle))->NbLaw();
}

OCGeomFill_SectionLaw^ OCBRepFill_SectionLaw::Law(Standard_Integer Index)
{
  Handle(GeomFill_SectionLaw) tmp = (*((Handle_BRepFill_SectionLaw*)nativeHandle))->Law(Index);
  return gcnew OCGeomFill_SectionLaw(&tmp);
}

 System::Boolean OCBRepFill_SectionLaw::IsUClosed()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_BRepFill_SectionLaw*)nativeHandle))->IsUClosed());
}

 System::Boolean OCBRepFill_SectionLaw::IsVClosed()
{
  return OCConverter::StandardBooleanToBoolean((*((Handle_BRepFill_SectionLaw*)nativeHandle))->IsVClosed());
}

 void OCBRepFill_SectionLaw::Init(OCNaroWrappers::OCTopoDS_Wire^ W)
{
  (*((Handle_BRepFill_SectionLaw*)nativeHandle))->Init(*((TopoDS_Wire*)W->Handle));
}

OCTopoDS_Edge^ OCBRepFill_SectionLaw::CurrentEdge()
{
  TopoDS_Edge* tmp = new TopoDS_Edge();
  *tmp = (*((Handle_BRepFill_SectionLaw*)nativeHandle))->CurrentEdge();
  return gcnew OCTopoDS_Edge(tmp);
}

