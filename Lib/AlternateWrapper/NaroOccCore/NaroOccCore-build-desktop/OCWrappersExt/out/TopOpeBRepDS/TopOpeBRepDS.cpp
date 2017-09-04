// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepDS.h"
#include "../Converter.h"


using namespace OCNaroWrappers;



OCTCollection_AsciiString^ OCTopOpeBRepDS::SPrint(OCTopAbs_State S)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = TopOpeBRepDS::SPrint((TopAbs_State)S);
  return gcnew OCTCollection_AsciiString(tmp);
}

 Standard_OStream& OCTopOpeBRepDS::Print(OCTopAbs_State S, Standard_OStream& OS)
{
  return TopOpeBRepDS::Print((TopAbs_State)S, OS);
}

OCTCollection_AsciiString^ OCTopOpeBRepDS::SPrint(OCTopOpeBRepDS_Kind K)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = TopOpeBRepDS::SPrint((TopOpeBRepDS_Kind)K);
  return gcnew OCTCollection_AsciiString(tmp);
}

OCTCollection_AsciiString^ OCTopOpeBRepDS::SPrint(OCTopOpeBRepDS_Kind K, Standard_Integer I, OCNaroWrappers::OCTCollection_AsciiString^ B, OCNaroWrappers::OCTCollection_AsciiString^ A)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = TopOpeBRepDS::SPrint((TopOpeBRepDS_Kind)K, I, *((TCollection_AsciiString*)B->Handle), *((TCollection_AsciiString*)A->Handle));
  return gcnew OCTCollection_AsciiString(tmp);
}

 Standard_OStream& OCTopOpeBRepDS::Print(OCTopOpeBRepDS_Kind K, Standard_OStream& S)
{
  return TopOpeBRepDS::Print((TopOpeBRepDS_Kind)K, S);
}

 Standard_OStream& OCTopOpeBRepDS::Print(OCTopOpeBRepDS_Kind K, Standard_Integer I, Standard_OStream& S, OCNaroWrappers::OCTCollection_AsciiString^ B, OCNaroWrappers::OCTCollection_AsciiString^ A)
{
  return TopOpeBRepDS::Print((TopOpeBRepDS_Kind)K, I, S, *((TCollection_AsciiString*)B->Handle), *((TCollection_AsciiString*)A->Handle));
}

OCTCollection_AsciiString^ OCTopOpeBRepDS::SPrint(OCTopAbs_ShapeEnum T)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = TopOpeBRepDS::SPrint((TopAbs_ShapeEnum)T);
  return gcnew OCTCollection_AsciiString(tmp);
}

OCTCollection_AsciiString^ OCTopOpeBRepDS::SPrint(OCTopAbs_ShapeEnum T, Standard_Integer I)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = TopOpeBRepDS::SPrint((TopAbs_ShapeEnum)T, I);
  return gcnew OCTCollection_AsciiString(tmp);
}

 Standard_OStream& OCTopOpeBRepDS::Print(OCTopAbs_ShapeEnum T, Standard_Integer I, Standard_OStream& S)
{
  return TopOpeBRepDS::Print((TopAbs_ShapeEnum)T, I, S);
}

OCTCollection_AsciiString^ OCTopOpeBRepDS::SPrint(OCTopAbs_Orientation O)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = TopOpeBRepDS::SPrint((TopAbs_Orientation)O);
  return gcnew OCTCollection_AsciiString(tmp);
}

OCTCollection_AsciiString^ OCTopOpeBRepDS::SPrint(OCTopOpeBRepDS_Config C)
{
  TCollection_AsciiString* tmp = new TCollection_AsciiString();
  *tmp = TopOpeBRepDS::SPrint((TopOpeBRepDS_Config)C);
  return gcnew OCTCollection_AsciiString(tmp);
}

 Standard_OStream& OCTopOpeBRepDS::Print(OCTopOpeBRepDS_Config C, Standard_OStream& S)
{
  return TopOpeBRepDS::Print((TopOpeBRepDS_Config)C, S);
}

 System::Boolean OCTopOpeBRepDS::IsGeometry(OCTopOpeBRepDS_Kind K)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepDS::IsGeometry((TopOpeBRepDS_Kind)K));
}

 System::Boolean OCTopOpeBRepDS::IsTopology(OCTopOpeBRepDS_Kind K)
{
  return OCConverter::StandardBooleanToBoolean(TopOpeBRepDS::IsTopology((TopOpeBRepDS_Kind)K));
}

 OCTopAbs_ShapeEnum OCTopOpeBRepDS::KindToShape(OCTopOpeBRepDS_Kind K)
{
  return (OCTopAbs_ShapeEnum)(TopOpeBRepDS::KindToShape((TopOpeBRepDS_Kind)K));
}

 OCTopOpeBRepDS_Kind OCTopOpeBRepDS::ShapeToKind(OCTopAbs_ShapeEnum S)
{
  return (OCTopOpeBRepDS_Kind)(TopOpeBRepDS::ShapeToKind((TopAbs_ShapeEnum)S));
}


