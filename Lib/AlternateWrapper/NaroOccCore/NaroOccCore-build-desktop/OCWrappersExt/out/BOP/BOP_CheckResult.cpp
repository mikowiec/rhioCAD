// File generated by CPPExt (CPP file)
//

#include "BOP_CheckResult.h"
#include "../Converter.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../TopTools/TopTools_ListOfShape.h"


using namespace OCNaroWrappers;

OCBOP_CheckResult::OCBOP_CheckResult(BOP_CheckResult* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCBOP_CheckResult::OCBOP_CheckResult() 
{
  nativeHandle = new BOP_CheckResult();
}

 void OCBOP_CheckResult::SetShape1(OCNaroWrappers::OCTopoDS_Shape^ TheShape)
{
  ((BOP_CheckResult*)nativeHandle)->SetShape1(*((TopoDS_Shape*)TheShape->Handle));
}

 void OCBOP_CheckResult::AddFaultyShape1(OCNaroWrappers::OCTopoDS_Shape^ TheShape)
{
  ((BOP_CheckResult*)nativeHandle)->AddFaultyShape1(*((TopoDS_Shape*)TheShape->Handle));
}

 void OCBOP_CheckResult::SetShape2(OCNaroWrappers::OCTopoDS_Shape^ TheShape)
{
  ((BOP_CheckResult*)nativeHandle)->SetShape2(*((TopoDS_Shape*)TheShape->Handle));
}

 void OCBOP_CheckResult::AddFaultyShape2(OCNaroWrappers::OCTopoDS_Shape^ TheShape)
{
  ((BOP_CheckResult*)nativeHandle)->AddFaultyShape2(*((TopoDS_Shape*)TheShape->Handle));
}

OCTopoDS_Shape^ OCBOP_CheckResult::GetShape1()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((BOP_CheckResult*)nativeHandle)->GetShape1();
  return gcnew OCTopoDS_Shape(tmp);
}

OCTopoDS_Shape^ OCBOP_CheckResult::GetShape2()
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((BOP_CheckResult*)nativeHandle)->GetShape2();
  return gcnew OCTopoDS_Shape(tmp);
}

OCTopTools_ListOfShape^ OCBOP_CheckResult::GetFaultyShapes1()
{
  TopTools_ListOfShape* tmp = new TopTools_ListOfShape();
  *tmp = ((BOP_CheckResult*)nativeHandle)->GetFaultyShapes1();
  return gcnew OCTopTools_ListOfShape(tmp);
}

OCTopTools_ListOfShape^ OCBOP_CheckResult::GetFaultyShapes2()
{
  TopTools_ListOfShape* tmp = new TopTools_ListOfShape();
  *tmp = ((BOP_CheckResult*)nativeHandle)->GetFaultyShapes2();
  return gcnew OCTopTools_ListOfShape(tmp);
}

 void OCBOP_CheckResult::SetCheckStatus(OCBOP_CheckStatus TheStatus)
{
  ((BOP_CheckResult*)nativeHandle)->SetCheckStatus((BOP_CheckStatus)TheStatus);
}

 OCBOP_CheckStatus OCBOP_CheckResult::GetCheckStatus()
{
  return (OCBOP_CheckStatus)(((BOP_CheckResult*)nativeHandle)->GetCheckStatus());
}


