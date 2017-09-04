// File generated by CPPExt (CPP file)
//

#include "BOPTools_CArray1OfVEInterference.h"
#include "../Converter.h"
#include "BOPTools_VEInterference.h"


using namespace OCNaroWrappers;

OCBOPTools_CArray1OfVEInterference::OCBOPTools_CArray1OfVEInterference(BOPTools_CArray1OfVEInterference* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCBOPTools_CArray1OfVEInterference::OCBOPTools_CArray1OfVEInterference(Standard_Integer Length, Standard_Integer BlockLength) 
{
  nativeHandle = new BOPTools_CArray1OfVEInterference(Length, BlockLength);
}

 void OCBOPTools_CArray1OfVEInterference::Resize(Standard_Integer theNewLength)
{
  ((BOPTools_CArray1OfVEInterference*)nativeHandle)->Resize(theNewLength);
}

 Standard_Integer OCBOPTools_CArray1OfVEInterference::Length()
{
  return ((BOPTools_CArray1OfVEInterference*)nativeHandle)->Length();
}

 Standard_Integer OCBOPTools_CArray1OfVEInterference::Extent()
{
  return ((BOPTools_CArray1OfVEInterference*)nativeHandle)->Extent();
}

 Standard_Integer OCBOPTools_CArray1OfVEInterference::FactLength()
{
  return ((BOPTools_CArray1OfVEInterference*)nativeHandle)->FactLength();
}

 Standard_Integer OCBOPTools_CArray1OfVEInterference::Append(OCNaroWrappers::OCBOPTools_VEInterference^ Value)
{
  return ((BOPTools_CArray1OfVEInterference*)nativeHandle)->Append(*((BOPTools_VEInterference*)Value->Handle));
}

 void OCBOPTools_CArray1OfVEInterference::Remove(Standard_Integer Index)
{
  ((BOPTools_CArray1OfVEInterference*)nativeHandle)->Remove(Index);
}

OCBOPTools_VEInterference^ OCBOPTools_CArray1OfVEInterference::Value(Standard_Integer Index)
{
  BOPTools_VEInterference* tmp = new BOPTools_VEInterference();
  *tmp = ((BOPTools_CArray1OfVEInterference*)nativeHandle)->Value(Index);
  return gcnew OCBOPTools_VEInterference(tmp);
}

OCBOPTools_VEInterference^ OCBOPTools_CArray1OfVEInterference::ChangeValue(Standard_Integer Index)
{
  BOPTools_VEInterference* tmp = new BOPTools_VEInterference();
  *tmp = ((BOPTools_CArray1OfVEInterference*)nativeHandle)->ChangeValue(Index);
  return gcnew OCBOPTools_VEInterference(tmp);
}

 void OCBOPTools_CArray1OfVEInterference::SetBlockLength(Standard_Integer aBL)
{
  ((BOPTools_CArray1OfVEInterference*)nativeHandle)->SetBlockLength(aBL);
}

 Standard_Integer OCBOPTools_CArray1OfVEInterference::BlockLength()
{
  return ((BOPTools_CArray1OfVEInterference*)nativeHandle)->BlockLength();
}

 void OCBOPTools_CArray1OfVEInterference::Purge()
{
  ((BOPTools_CArray1OfVEInterference*)nativeHandle)->Purge();
}


