// File generated by CPPExt (CPP file)
//

#include "BOPTColStd_ListIteratorOfListOfListOfShape.h"
#include "../Converter.h"
#include "BOPTColStd_ListOfListOfShape.h"
#include "../TopTools/TopTools_ListOfShape.h"
#include "BOPTColStd_ListNodeOfListOfListOfShape.h"


using namespace OCNaroWrappers;

OCBOPTColStd_ListIteratorOfListOfListOfShape::OCBOPTColStd_ListIteratorOfListOfListOfShape(BOPTColStd_ListIteratorOfListOfListOfShape* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCBOPTColStd_ListIteratorOfListOfListOfShape::OCBOPTColStd_ListIteratorOfListOfListOfShape() 
{
  nativeHandle = new BOPTColStd_ListIteratorOfListOfListOfShape();
}

OCBOPTColStd_ListIteratorOfListOfListOfShape::OCBOPTColStd_ListIteratorOfListOfListOfShape(OCNaroWrappers::OCBOPTColStd_ListOfListOfShape^ L) 
{
  nativeHandle = new BOPTColStd_ListIteratorOfListOfListOfShape(*((BOPTColStd_ListOfListOfShape*)L->Handle));
}

 void OCBOPTColStd_ListIteratorOfListOfListOfShape::Initialize(OCNaroWrappers::OCBOPTColStd_ListOfListOfShape^ L)
{
  ((BOPTColStd_ListIteratorOfListOfListOfShape*)nativeHandle)->Initialize(*((BOPTColStd_ListOfListOfShape*)L->Handle));
}

 System::Boolean OCBOPTColStd_ListIteratorOfListOfListOfShape::More()
{
  return OCConverter::StandardBooleanToBoolean(((BOPTColStd_ListIteratorOfListOfListOfShape*)nativeHandle)->More());
}

 void OCBOPTColStd_ListIteratorOfListOfListOfShape::Next()
{
  ((BOPTColStd_ListIteratorOfListOfListOfShape*)nativeHandle)->Next();
}

OCTopTools_ListOfShape^ OCBOPTColStd_ListIteratorOfListOfListOfShape::Value()
{
  TopTools_ListOfShape* tmp = new TopTools_ListOfShape();
  *tmp = ((BOPTColStd_ListIteratorOfListOfListOfShape*)nativeHandle)->Value();
  return gcnew OCTopTools_ListOfShape(tmp);
}

