// File generated by CPPExt (CPP file)
//

#include "BOPTools_DEInfo.h"
#include "../Converter.h"
#include "../TColStd/TColStd_ListOfInteger.h"


using namespace OCNaroWrappers;

OCBOPTools_DEInfo::OCBOPTools_DEInfo(BOPTools_DEInfo* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCBOPTools_DEInfo::OCBOPTools_DEInfo() 
{
  nativeHandle = new BOPTools_DEInfo();
}

 void OCBOPTools_DEInfo::SetVertex(Standard_Integer nV)
{
  ((BOPTools_DEInfo*)nativeHandle)->SetVertex(nV);
}

 void OCBOPTools_DEInfo::SetFaces(OCNaroWrappers::OCTColStd_ListOfInteger^ aLF)
{
  ((BOPTools_DEInfo*)nativeHandle)->SetFaces(*((TColStd_ListOfInteger*)aLF->Handle));
}

OCTColStd_ListOfInteger^ OCBOPTools_DEInfo::Faces()
{
  TColStd_ListOfInteger* tmp = new TColStd_ListOfInteger();
  *tmp = ((BOPTools_DEInfo*)nativeHandle)->Faces();
  return gcnew OCTColStd_ListOfInteger(tmp);
}

OCTColStd_ListOfInteger^ OCBOPTools_DEInfo::ChangeFaces()
{
  TColStd_ListOfInteger* tmp = new TColStd_ListOfInteger();
  *tmp = ((BOPTools_DEInfo*)nativeHandle)->ChangeFaces();
  return gcnew OCTColStd_ListOfInteger(tmp);
}

 Standard_Integer OCBOPTools_DEInfo::Vertex()
{
  return ((BOPTools_DEInfo*)nativeHandle)->Vertex();
}

