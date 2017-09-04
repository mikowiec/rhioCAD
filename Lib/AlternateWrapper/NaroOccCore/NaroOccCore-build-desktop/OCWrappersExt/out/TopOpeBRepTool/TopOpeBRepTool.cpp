// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepTool.h"
#include "../Converter.h"


using namespace OCNaroWrappers;



 System::Boolean OCTopOpeBRepTool::PurgeClosingEdges(OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCTopoDS_Face^ FF, OCNaroWrappers::OCTopTools_DataMapOfShapeInteger^ MWisOld, OCNaroWrappers::OCTopTools_IndexedMapOfOrientedShape^ MshNOK)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::PurgeClosingEdges(*((TopoDS_Face*)F->Handle), *((TopoDS_Face*)FF->Handle), *((TopTools_DataMapOfShapeInteger*)MWisOld->Handle), *((TopTools_IndexedMapOfOrientedShape*)MshNOK->Handle)));
}

 System::Boolean OCTopOpeBRepTool::PurgeClosingEdges(OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCTopTools_ListOfShape^ LOF, OCNaroWrappers::OCTopTools_DataMapOfShapeInteger^ MWisOld, OCNaroWrappers::OCTopTools_IndexedMapOfOrientedShape^ MshNOK)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::PurgeClosingEdges(*((TopoDS_Face*)F->Handle), *((TopTools_ListOfShape*)LOF->Handle), *((TopTools_DataMapOfShapeInteger*)MWisOld->Handle), *((TopTools_IndexedMapOfOrientedShape*)MshNOK->Handle)));
}

 System::Boolean OCTopOpeBRepTool::CorrectONUVISO(OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCTopoDS_Face^ Fsp)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::CorrectONUVISO(*((TopoDS_Face*)F->Handle), *((TopoDS_Face*)Fsp->Handle)));
}

 System::Boolean OCTopOpeBRepTool::MakeFaces(OCNaroWrappers::OCTopoDS_Face^ F, OCNaroWrappers::OCTopTools_ListOfShape^ LOF, OCNaroWrappers::OCTopTools_IndexedMapOfOrientedShape^ MshNOK, OCNaroWrappers::OCTopTools_ListOfShape^ LOFF)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::MakeFaces(*((TopoDS_Face*)F->Handle), *((TopTools_ListOfShape*)LOF->Handle), *((TopTools_IndexedMapOfOrientedShape*)MshNOK->Handle), *((TopTools_ListOfShape*)LOFF->Handle)));
}

 System::Boolean OCTopOpeBRepTool::Regularize(OCNaroWrappers::OCTopoDS_Face^ aFace, OCNaroWrappers::OCTopTools_ListOfShape^ aListOfFaces, OCNaroWrappers::OCTopTools_DataMapOfShapeListOfShape^ ESplits)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::Regularize(*((TopoDS_Face*)aFace->Handle), *((TopTools_ListOfShape*)aListOfFaces->Handle), *((TopTools_DataMapOfShapeListOfShape*)ESplits->Handle)));
}

 System::Boolean OCTopOpeBRepTool::RegularizeWires(OCNaroWrappers::OCTopoDS_Face^ aFace, OCNaroWrappers::OCTopTools_DataMapOfShapeListOfShape^ OldWiresNewWires, OCNaroWrappers::OCTopTools_DataMapOfShapeListOfShape^ ESplits)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::RegularizeWires(*((TopoDS_Face*)aFace->Handle), *((TopTools_DataMapOfShapeListOfShape*)OldWiresNewWires->Handle), *((TopTools_DataMapOfShapeListOfShape*)ESplits->Handle)));
}

 System::Boolean OCTopOpeBRepTool::RegularizeFace(OCNaroWrappers::OCTopoDS_Face^ aFace, OCNaroWrappers::OCTopTools_DataMapOfShapeListOfShape^ OldWiresnewWires, OCNaroWrappers::OCTopTools_ListOfShape^ aListOfFaces)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::RegularizeFace(*((TopoDS_Face*)aFace->Handle), *((TopTools_DataMapOfShapeListOfShape*)OldWiresnewWires->Handle), *((TopTools_ListOfShape*)aListOfFaces->Handle)));
}

 System::Boolean OCTopOpeBRepTool::RegularizeShells(OCNaroWrappers::OCTopoDS_Solid^ aSolid, OCNaroWrappers::OCTopTools_DataMapOfShapeListOfShape^ OldSheNewShe, OCNaroWrappers::OCTopTools_DataMapOfShapeListOfShape^ FSplits)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepTool::RegularizeShells(*((TopoDS_Solid*)aSolid->Handle), *((TopTools_DataMapOfShapeListOfShape*)OldSheNewShe->Handle), *((TopTools_DataMapOfShapeListOfShape*)FSplits->Handle)));
}

 Standard_OStream& OCTopOpeBRepTool::Print(OCTopOpeBRepTool_OutCurveType OCT, Standard_OStream& S)
{
  return TopOpeBRepTool::Print((TopOpeBRepTool_OutCurveType)OCT, S);
}


