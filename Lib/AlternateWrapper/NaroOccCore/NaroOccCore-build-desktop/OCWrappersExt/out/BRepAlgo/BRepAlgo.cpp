// File generated by CPPExt (CPP file)
//

#include "BRepAlgo.h"
#include "../Converter.h"


using namespace OCNaroWrappers;



OCTopoDS_Wire^ OCBRepAlgo::ConcatenateWire(OCNaroWrappers::OCTopoDS_Wire^ Wire, OCGeomAbs_Shape Option, Standard_Real AngularTolerance)
{
  TopoDS_Wire* tmp = new TopoDS_Wire();
  *tmp = BRepAlgo::ConcatenateWire(*((TopoDS_Wire*)Wire->Handle), (GeomAbs_Shape)Option, AngularTolerance);
  return gcnew OCTopoDS_Wire(tmp);
}

 System::Boolean OCBRepAlgo::IsValid(OCNaroWrappers::OCTopoDS_Shape^ S)
{
  return OCConverter::StandardBooleanToBoolean(BRepAlgo::IsValid(*((TopoDS_Shape*)S->Handle)));
}

 System::Boolean OCBRepAlgo::IsValid(OCNaroWrappers::OCTopTools_ListOfShape^ theArgs, OCNaroWrappers::OCTopoDS_Shape^ theResult, System::Boolean closedSolid, System::Boolean GeomCtrl)
{
  return OCConverter::StandardBooleanToBoolean(BRepAlgo::IsValid(*((TopTools_ListOfShape*)theArgs->Handle), *((TopoDS_Shape*)theResult->Handle), OCConverter::BooleanToStandardBoolean(closedSolid), OCConverter::BooleanToStandardBoolean(GeomCtrl)));
}

 System::Boolean OCBRepAlgo::IsTopologicallyValid(OCNaroWrappers::OCTopoDS_Shape^ S)
{
  return OCConverter::StandardBooleanToBoolean(BRepAlgo::IsTopologicallyValid(*((TopoDS_Shape*)S->Handle)));
}


