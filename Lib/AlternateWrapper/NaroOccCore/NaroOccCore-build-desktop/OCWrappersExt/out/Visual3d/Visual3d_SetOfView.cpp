// File generated by CPPExt (CPP file)
//

#include "Visual3d_SetOfView.h"
#include "../Converter.h"
#include "Visual3d_SetIteratorOfSetOfView.h"
#include "Visual3d_View.h"
#include "Visual3d_SetListOfSetOfView.h"
#include "Visual3d_ListNodeOfSetListOfSetOfView.h"
#include "Visual3d_ListIteratorOfSetListOfSetOfView.h"


using namespace OCNaroWrappers;

OCVisual3d_SetOfView::OCVisual3d_SetOfView(Visual3d_SetOfView* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCVisual3d_SetOfView::OCVisual3d_SetOfView() 
{
  nativeHandle = new Visual3d_SetOfView();
}

 Standard_Integer OCVisual3d_SetOfView::Extent()
{
  return ((Visual3d_SetOfView*)nativeHandle)->Extent();
}

 System::Boolean OCVisual3d_SetOfView::IsEmpty()
{
  return OCConverter::StandardBooleanToBoolean(((Visual3d_SetOfView*)nativeHandle)->IsEmpty());
}

 void OCVisual3d_SetOfView::Clear()
{
  ((Visual3d_SetOfView*)nativeHandle)->Clear();
}

 System::Boolean OCVisual3d_SetOfView::Add(OCNaroWrappers::OCVisual3d_View^ T)
{
  return OCConverter::StandardBooleanToBoolean(((Visual3d_SetOfView*)nativeHandle)->Add(*((Handle_Visual3d_View*)T->Handle)));
}

 System::Boolean OCVisual3d_SetOfView::Remove(OCNaroWrappers::OCVisual3d_View^ T)
{
  return OCConverter::StandardBooleanToBoolean(((Visual3d_SetOfView*)nativeHandle)->Remove(*((Handle_Visual3d_View*)T->Handle)));
}

 void OCVisual3d_SetOfView::Union(OCNaroWrappers::OCVisual3d_SetOfView^ B)
{
  ((Visual3d_SetOfView*)nativeHandle)->Union(*((Visual3d_SetOfView*)B->Handle));
}

 void OCVisual3d_SetOfView::Intersection(OCNaroWrappers::OCVisual3d_SetOfView^ B)
{
  ((Visual3d_SetOfView*)nativeHandle)->Intersection(*((Visual3d_SetOfView*)B->Handle));
}

 void OCVisual3d_SetOfView::Difference(OCNaroWrappers::OCVisual3d_SetOfView^ B)
{
  ((Visual3d_SetOfView*)nativeHandle)->Difference(*((Visual3d_SetOfView*)B->Handle));
}

 System::Boolean OCVisual3d_SetOfView::Contains(OCNaroWrappers::OCVisual3d_View^ T)
{
  return OCConverter::StandardBooleanToBoolean(((Visual3d_SetOfView*)nativeHandle)->Contains(*((Handle_Visual3d_View*)T->Handle)));
}

 System::Boolean OCVisual3d_SetOfView::IsASubset(OCNaroWrappers::OCVisual3d_SetOfView^ S)
{
  return OCConverter::StandardBooleanToBoolean(((Visual3d_SetOfView*)nativeHandle)->IsASubset(*((Visual3d_SetOfView*)S->Handle)));
}

 System::Boolean OCVisual3d_SetOfView::IsAProperSubset(OCNaroWrappers::OCVisual3d_SetOfView^ S)
{
  return OCConverter::StandardBooleanToBoolean(((Visual3d_SetOfView*)nativeHandle)->IsAProperSubset(*((Visual3d_SetOfView*)S->Handle)));
}


