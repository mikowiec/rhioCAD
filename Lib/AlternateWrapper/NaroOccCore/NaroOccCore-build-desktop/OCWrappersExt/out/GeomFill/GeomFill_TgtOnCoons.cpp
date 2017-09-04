// File generated by CPPExt (CPP file)
//

#include "GeomFill_TgtOnCoons.h"
#include "../Converter.h"
#include "GeomFill_CoonsAlgPatch.h"
#include "../gp/gp_Vec.h"


using namespace OCNaroWrappers;

OCGeomFill_TgtOnCoons::OCGeomFill_TgtOnCoons(Handle(GeomFill_TgtOnCoons)* nativeHandle) : OCGeomFill_TgtField((OCDummy^)nullptr)

{
  this->nativeHandle = new Handle_GeomFill_TgtOnCoons(*nativeHandle);
}

OCGeomFill_TgtOnCoons::OCGeomFill_TgtOnCoons(OCNaroWrappers::OCGeomFill_CoonsAlgPatch^ K, Standard_Integer I) : OCGeomFill_TgtField((OCDummy^)nullptr)

{
  nativeHandle = new Handle_GeomFill_TgtOnCoons(new GeomFill_TgtOnCoons(*((Handle_GeomFill_CoonsAlgPatch*)K->Handle), I));
}

OCgp_Vec^ OCGeomFill_TgtOnCoons::Value(Standard_Real W)
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = (*((Handle_GeomFill_TgtOnCoons*)nativeHandle))->Value(W);
  return gcnew OCgp_Vec(tmp);
}

OCgp_Vec^ OCGeomFill_TgtOnCoons::D1(Standard_Real W)
{
  gp_Vec* tmp = new gp_Vec();
  *tmp = (*((Handle_GeomFill_TgtOnCoons*)nativeHandle))->D1(W);
  return gcnew OCgp_Vec(tmp);
}

 void OCGeomFill_TgtOnCoons::D1(Standard_Real W, OCNaroWrappers::OCgp_Vec^ T, OCNaroWrappers::OCgp_Vec^ DT)
{
  (*((Handle_GeomFill_TgtOnCoons*)nativeHandle))->D1(W, *((gp_Vec*)T->Handle), *((gp_Vec*)DT->Handle));
}


