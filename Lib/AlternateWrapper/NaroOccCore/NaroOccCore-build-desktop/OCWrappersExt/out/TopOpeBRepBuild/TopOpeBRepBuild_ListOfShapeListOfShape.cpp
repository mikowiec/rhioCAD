// File generated by CPPExt (CPP file)
//

#include "TopOpeBRepBuild_ListOfShapeListOfShape.h"
#include "../Converter.h"
#include "TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape.h"
#include "TopOpeBRepBuild_ShapeListOfShape.h"
#include "TopOpeBRepBuild_ListNodeOfListOfShapeListOfShape.h"


using namespace OCNaroWrappers;

OCTopOpeBRepBuild_ListOfShapeListOfShape::OCTopOpeBRepBuild_ListOfShapeListOfShape(TopOpeBRepBuild_ListOfShapeListOfShape* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTopOpeBRepBuild_ListOfShapeListOfShape::OCTopOpeBRepBuild_ListOfShapeListOfShape() 
{
  nativeHandle = new TopOpeBRepBuild_ListOfShapeListOfShape();
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Assign(OCNaroWrappers::OCTopOpeBRepBuild_ListOfShapeListOfShape^ Other)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Assign(*((TopOpeBRepBuild_ListOfShapeListOfShape*)Other->Handle));
}

 Standard_Integer OCTopOpeBRepBuild_ListOfShapeListOfShape::Extent()
{
  return ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Extent();
}

 System::Boolean OCTopOpeBRepBuild_ListOfShapeListOfShape::IsEmpty()
{
  return OCConverter::StandardBooleanToBoolean(((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->IsEmpty());
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Prepend(OCNaroWrappers::OCTopOpeBRepBuild_ShapeListOfShape^ I)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Prepend(*((TopOpeBRepBuild_ShapeListOfShape*)I->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Prepend(OCNaroWrappers::OCTopOpeBRepBuild_ShapeListOfShape^ I, OCNaroWrappers::OCTopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape^ theIt)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Prepend(*((TopOpeBRepBuild_ShapeListOfShape*)I->Handle), *((TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape*)theIt->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Prepend(OCNaroWrappers::OCTopOpeBRepBuild_ListOfShapeListOfShape^ Other)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Prepend(*((TopOpeBRepBuild_ListOfShapeListOfShape*)Other->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Append(OCNaroWrappers::OCTopOpeBRepBuild_ShapeListOfShape^ I)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Append(*((TopOpeBRepBuild_ShapeListOfShape*)I->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Append(OCNaroWrappers::OCTopOpeBRepBuild_ShapeListOfShape^ I, OCNaroWrappers::OCTopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape^ theIt)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Append(*((TopOpeBRepBuild_ShapeListOfShape*)I->Handle), *((TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape*)theIt->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Append(OCNaroWrappers::OCTopOpeBRepBuild_ListOfShapeListOfShape^ Other)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Append(*((TopOpeBRepBuild_ListOfShapeListOfShape*)Other->Handle));
}

OCTopOpeBRepBuild_ShapeListOfShape^ OCTopOpeBRepBuild_ListOfShapeListOfShape::First()
{
  TopOpeBRepBuild_ShapeListOfShape* tmp = new TopOpeBRepBuild_ShapeListOfShape();
  *tmp = ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->First();
  return gcnew OCTopOpeBRepBuild_ShapeListOfShape(tmp);
}

OCTopOpeBRepBuild_ShapeListOfShape^ OCTopOpeBRepBuild_ListOfShapeListOfShape::Last()
{
  TopOpeBRepBuild_ShapeListOfShape* tmp = new TopOpeBRepBuild_ShapeListOfShape();
  *tmp = ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Last();
  return gcnew OCTopOpeBRepBuild_ShapeListOfShape(tmp);
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::RemoveFirst()
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->RemoveFirst();
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::Remove(OCNaroWrappers::OCTopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape^ It)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->Remove(*((TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape*)It->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::InsertBefore(OCNaroWrappers::OCTopOpeBRepBuild_ShapeListOfShape^ I, OCNaroWrappers::OCTopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape^ It)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->InsertBefore(*((TopOpeBRepBuild_ShapeListOfShape*)I->Handle), *((TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape*)It->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::InsertBefore(OCNaroWrappers::OCTopOpeBRepBuild_ListOfShapeListOfShape^ Other, OCNaroWrappers::OCTopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape^ It)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->InsertBefore(*((TopOpeBRepBuild_ListOfShapeListOfShape*)Other->Handle), *((TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape*)It->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::InsertAfter(OCNaroWrappers::OCTopOpeBRepBuild_ShapeListOfShape^ I, OCNaroWrappers::OCTopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape^ It)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->InsertAfter(*((TopOpeBRepBuild_ShapeListOfShape*)I->Handle), *((TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape*)It->Handle));
}

 void OCTopOpeBRepBuild_ListOfShapeListOfShape::InsertAfter(OCNaroWrappers::OCTopOpeBRepBuild_ListOfShapeListOfShape^ Other, OCNaroWrappers::OCTopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape^ It)
{
  ((TopOpeBRepBuild_ListOfShapeListOfShape*)nativeHandle)->InsertAfter(*((TopOpeBRepBuild_ListOfShapeListOfShape*)Other->Handle), *((TopOpeBRepBuild_ListIteratorOfListOfShapeListOfShape*)It->Handle));
}


