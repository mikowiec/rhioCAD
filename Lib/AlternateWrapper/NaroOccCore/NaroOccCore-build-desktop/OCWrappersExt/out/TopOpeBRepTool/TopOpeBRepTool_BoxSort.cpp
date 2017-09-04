// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepTool_BoxSort.h"
#include "../Converter.h"
#include "TopOpeBRepTool_HBoxTool.h"
#include "../Bnd/Bnd_HArray1OfBox.h"
#include "../TColStd/TColStd_HArray1OfInteger.h"
#include "../TopoDS/TopoDS_Shape.h"
#include "../Bnd/Bnd_Box.h"
#include "../TColStd/TColStd_ListIteratorOfListOfInteger.h"


using namespace OCNaroWrappers;

OCTopOpeBRepTool_BoxSort::OCTopOpeBRepTool_BoxSort(TopOpeBRepTool_BoxSort* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTopOpeBRepTool_BoxSort::OCTopOpeBRepTool_BoxSort() 
{
  nativeHandle = new TopOpeBRepTool_BoxSort();
}

OCTopOpeBRepTool_BoxSort::OCTopOpeBRepTool_BoxSort(OCNaroWrappers::OCTopOpeBRepTool_HBoxTool^ T) 
{
  nativeHandle = new TopOpeBRepTool_BoxSort(*((Handle_TopOpeBRepTool_HBoxTool*)T->Handle));
}

 void OCTopOpeBRepTool_BoxSort::SetHBoxTool(OCNaroWrappers::OCTopOpeBRepTool_HBoxTool^ T)
{
  ((TopOpeBRepTool_BoxSort*)nativeHandle)->SetHBoxTool(*((Handle_TopOpeBRepTool_HBoxTool*)T->Handle));
}

OCTopOpeBRepTool_HBoxTool^ OCTopOpeBRepTool_BoxSort::HBoxTool()
{
  Handle(TopOpeBRepTool_HBoxTool) tmp = ((TopOpeBRepTool_BoxSort*)nativeHandle)->HBoxTool();
  return gcnew OCTopOpeBRepTool_HBoxTool(&tmp);
}

 void OCTopOpeBRepTool_BoxSort::Clear()
{
  ((TopOpeBRepTool_BoxSort*)nativeHandle)->Clear();
}

 void OCTopOpeBRepTool_BoxSort::AddBoxes(OCNaroWrappers::OCTopoDS_Shape^ S, OCTopAbs_ShapeEnum TS, OCTopAbs_ShapeEnum TA)
{
  ((TopOpeBRepTool_BoxSort*)nativeHandle)->AddBoxes(*((TopoDS_Shape*)S->Handle), (TopAbs_ShapeEnum)TS, (TopAbs_ShapeEnum)TA);
}

 void OCTopOpeBRepTool_BoxSort::MakeHAB(OCNaroWrappers::OCTopoDS_Shape^ S, OCTopAbs_ShapeEnum TS, OCTopAbs_ShapeEnum TA)
{
  ((TopOpeBRepTool_BoxSort*)nativeHandle)->MakeHAB(*((TopoDS_Shape*)S->Handle), (TopAbs_ShapeEnum)TS, (TopAbs_ShapeEnum)TA);
}

OCBnd_HArray1OfBox^ OCTopOpeBRepTool_BoxSort::HAB()
{
  Handle(Bnd_HArray1OfBox) tmp = ((TopOpeBRepTool_BoxSort*)nativeHandle)->HAB();
  return gcnew OCBnd_HArray1OfBox(&tmp);
}

 void OCTopOpeBRepTool_BoxSort::MakeHABCOB(OCNaroWrappers::OCBnd_HArray1OfBox^ HAB, OCNaroWrappers::OCBnd_Box^ COB)
{
  TopOpeBRepTool_BoxSort::MakeHABCOB(*((Handle_Bnd_HArray1OfBox*)HAB->Handle), *((Bnd_Box*)COB->Handle));
}

OCTopoDS_Shape^ OCTopOpeBRepTool_BoxSort::HABShape(Standard_Integer I)
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((TopOpeBRepTool_BoxSort*)nativeHandle)->HABShape(I);
  return gcnew OCTopoDS_Shape(tmp);
}

 void OCTopOpeBRepTool_BoxSort::MakeCOB(OCNaroWrappers::OCTopoDS_Shape^ S, OCTopAbs_ShapeEnum TS, OCTopAbs_ShapeEnum TA)
{
  ((TopOpeBRepTool_BoxSort*)nativeHandle)->MakeCOB(*((TopoDS_Shape*)S->Handle), (TopAbs_ShapeEnum)TS, (TopAbs_ShapeEnum)TA);
}

 void OCTopOpeBRepTool_BoxSort::AddBoxesMakeCOB(OCNaroWrappers::OCTopoDS_Shape^ S, OCTopAbs_ShapeEnum TS, OCTopAbs_ShapeEnum TA)
{
  ((TopOpeBRepTool_BoxSort*)nativeHandle)->AddBoxesMakeCOB(*((TopoDS_Shape*)S->Handle), (TopAbs_ShapeEnum)TS, (TopAbs_ShapeEnum)TA);
}

OCTColStd_ListIteratorOfListOfInteger^ OCTopOpeBRepTool_BoxSort::Compare(OCNaroWrappers::OCTopoDS_Shape^ S)
{
  TColStd_ListIteratorOfListOfInteger* tmp = new TColStd_ListIteratorOfListOfInteger();
  *tmp = ((TopOpeBRepTool_BoxSort*)nativeHandle)->Compare(*((TopoDS_Shape*)S->Handle));
  return gcnew OCTColStd_ListIteratorOfListOfInteger(tmp);
}

OCTopoDS_Shape^ OCTopOpeBRepTool_BoxSort::TouchedShape(OCNaroWrappers::OCTColStd_ListIteratorOfListOfInteger^ I)
{
  TopoDS_Shape* tmp = new TopoDS_Shape();
  *tmp = ((TopOpeBRepTool_BoxSort*)nativeHandle)->TouchedShape(*((TColStd_ListIteratorOfListOfInteger*)I->Handle));
  return gcnew OCTopoDS_Shape(tmp);
}

OCBnd_Box^ OCTopOpeBRepTool_BoxSort::Box(OCNaroWrappers::OCTopoDS_Shape^ S)
{
  Bnd_Box* tmp = new Bnd_Box();
  *tmp = ((TopOpeBRepTool_BoxSort*)nativeHandle)->Box(*((TopoDS_Shape*)S->Handle));
  return gcnew OCBnd_Box(tmp);
}

 void OCTopOpeBRepTool_BoxSort::Destroy()
{
  ((TopOpeBRepTool_BoxSort*)nativeHandle)->Destroy();
}


