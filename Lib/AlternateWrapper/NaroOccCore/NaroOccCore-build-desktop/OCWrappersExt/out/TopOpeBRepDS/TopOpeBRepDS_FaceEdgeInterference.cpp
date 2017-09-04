// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepDS_FaceEdgeInterference.h"
#include "../Converter.h"
#include "TopOpeBRepDS_Transition.h"


using namespace OCNaroWrappers;

OCTopOpeBRepDS_FaceEdgeInterference::OCTopOpeBRepDS_FaceEdgeInterference(Handle(TopOpeBRepDS_FaceEdgeInterference)* nativeHandle) : OCTopOpeBRepDS_ShapeShapeInterference((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_TopOpeBRepDS_FaceEdgeInterference(*nativeHandle);
}

OCTopOpeBRepDS_FaceEdgeInterference::OCTopOpeBRepDS_FaceEdgeInterference(OCNaroWrappers::OCTopOpeBRepDS_Transition^ T, Standard_Integer S, Standard_Integer G, System::Boolean GIsBound, OCTopOpeBRepDS_Config C) : OCTopOpeBRepDS_ShapeShapeInterference((OCDummy^)nullptr)

{
  nativeHandle = new Handle_TopOpeBRepDS_FaceEdgeInterference(new TopOpeBRepDS_FaceEdgeInterference(*((TopOpeBRepDS_Transition*)T->Handle), S, G, OCConverter::BooleanToStandardBoolean(GIsBound), (TopOpeBRepDS_Config)C));
}

 Standard_OStream& OCTopOpeBRepDS_FaceEdgeInterference::Dump(Standard_OStream& OS)
{
  return (*((Handle_TopOpeBRepDS_FaceEdgeInterference*)nativeHandle))->Dump(OS);
}


