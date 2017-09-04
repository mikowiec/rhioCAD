// File generated by CPPExt (CPP file)
//

#include "CDM_ListOfReferences.h"
#include "../Converter.h"
#include "CDM_ListIteratorOfListOfReferences.h"
#include "CDM_Reference.h"
#include "CDM_ListNodeOfListOfReferences.h"


using namespace OCNaroWrappers;

OCCDM_ListOfReferences::OCCDM_ListOfReferences(CDM_ListOfReferences* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCCDM_ListOfReferences::OCCDM_ListOfReferences() 
{
  nativeHandle = new CDM_ListOfReferences();
}

 void OCCDM_ListOfReferences::Assign(OCNaroWrappers::OCCDM_ListOfReferences^ Other)
{
  ((CDM_ListOfReferences*)nativeHandle)->Assign(*((CDM_ListOfReferences*)Other->Handle));
}

 Standard_Integer OCCDM_ListOfReferences::Extent()
{
  return ((CDM_ListOfReferences*)nativeHandle)->Extent();
}

 System::Boolean OCCDM_ListOfReferences::IsEmpty()
{
  return OCConverter::StandardBooleanToBoolean(((CDM_ListOfReferences*)nativeHandle)->IsEmpty());
}

 void OCCDM_ListOfReferences::Prepend(OCNaroWrappers::OCCDM_Reference^ I)
{
  ((CDM_ListOfReferences*)nativeHandle)->Prepend(*((Handle_CDM_Reference*)I->Handle));
}

 void OCCDM_ListOfReferences::Prepend(OCNaroWrappers::OCCDM_Reference^ I, OCNaroWrappers::OCCDM_ListIteratorOfListOfReferences^ theIt)
{
  ((CDM_ListOfReferences*)nativeHandle)->Prepend(*((Handle_CDM_Reference*)I->Handle), *((CDM_ListIteratorOfListOfReferences*)theIt->Handle));
}

 void OCCDM_ListOfReferences::Prepend(OCNaroWrappers::OCCDM_ListOfReferences^ Other)
{
  ((CDM_ListOfReferences*)nativeHandle)->Prepend(*((CDM_ListOfReferences*)Other->Handle));
}

 void OCCDM_ListOfReferences::Append(OCNaroWrappers::OCCDM_Reference^ I)
{
  ((CDM_ListOfReferences*)nativeHandle)->Append(*((Handle_CDM_Reference*)I->Handle));
}

 void OCCDM_ListOfReferences::Append(OCNaroWrappers::OCCDM_Reference^ I, OCNaroWrappers::OCCDM_ListIteratorOfListOfReferences^ theIt)
{
  ((CDM_ListOfReferences*)nativeHandle)->Append(*((Handle_CDM_Reference*)I->Handle), *((CDM_ListIteratorOfListOfReferences*)theIt->Handle));
}

 void OCCDM_ListOfReferences::Append(OCNaroWrappers::OCCDM_ListOfReferences^ Other)
{
  ((CDM_ListOfReferences*)nativeHandle)->Append(*((CDM_ListOfReferences*)Other->Handle));
}

OCCDM_Reference^ OCCDM_ListOfReferences::First()
{
  Handle(CDM_Reference) tmp = ((CDM_ListOfReferences*)nativeHandle)->First();
  return gcnew OCCDM_Reference(&tmp);
}

OCCDM_Reference^ OCCDM_ListOfReferences::Last()
{
  Handle(CDM_Reference) tmp = ((CDM_ListOfReferences*)nativeHandle)->Last();
  return gcnew OCCDM_Reference(&tmp);
}

 void OCCDM_ListOfReferences::RemoveFirst()
{
  ((CDM_ListOfReferences*)nativeHandle)->RemoveFirst();
}

 void OCCDM_ListOfReferences::Remove(OCNaroWrappers::OCCDM_ListIteratorOfListOfReferences^ It)
{
  ((CDM_ListOfReferences*)nativeHandle)->Remove(*((CDM_ListIteratorOfListOfReferences*)It->Handle));
}

 void OCCDM_ListOfReferences::InsertBefore(OCNaroWrappers::OCCDM_Reference^ I, OCNaroWrappers::OCCDM_ListIteratorOfListOfReferences^ It)
{
  ((CDM_ListOfReferences*)nativeHandle)->InsertBefore(*((Handle_CDM_Reference*)I->Handle), *((CDM_ListIteratorOfListOfReferences*)It->Handle));
}

 void OCCDM_ListOfReferences::InsertBefore(OCNaroWrappers::OCCDM_ListOfReferences^ Other, OCNaroWrappers::OCCDM_ListIteratorOfListOfReferences^ It)
{
  ((CDM_ListOfReferences*)nativeHandle)->InsertBefore(*((CDM_ListOfReferences*)Other->Handle), *((CDM_ListIteratorOfListOfReferences*)It->Handle));
}

 void OCCDM_ListOfReferences::InsertAfter(OCNaroWrappers::OCCDM_Reference^ I, OCNaroWrappers::OCCDM_ListIteratorOfListOfReferences^ It)
{
  ((CDM_ListOfReferences*)nativeHandle)->InsertAfter(*((Handle_CDM_Reference*)I->Handle), *((CDM_ListIteratorOfListOfReferences*)It->Handle));
}

 void OCCDM_ListOfReferences::InsertAfter(OCNaroWrappers::OCCDM_ListOfReferences^ Other, OCNaroWrappers::OCCDM_ListIteratorOfListOfReferences^ It)
{
  ((CDM_ListOfReferences*)nativeHandle)->InsertAfter(*((CDM_ListOfReferences*)Other->Handle), *((CDM_ListIteratorOfListOfReferences*)It->Handle));
}


