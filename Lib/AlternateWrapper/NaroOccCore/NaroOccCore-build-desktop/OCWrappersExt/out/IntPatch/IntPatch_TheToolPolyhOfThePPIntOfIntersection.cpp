// File generated by CPPExt (CPP file)
//

#include "IntPatch_TheToolPolyhOfThePPIntOfIntersection.h"
#include "../Converter.h"
#include "IntPatch_ThePolyhedronOfThePPIntOfIntersection.h"
#include "../Bnd/Bnd_Box.h"
#include "../Bnd/Bnd_HArray1OfBox.h"
#include "../gp/gp_Pnt.h"


using namespace OCNaroWrappers;

OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::OCIntPatch_TheToolPolyhOfThePPIntOfIntersection(IntPatch_TheToolPolyhOfThePPIntOfIntersection* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCBnd_Box^ OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::Bounding(OCNaroWrappers::OCIntPatch_ThePolyhedronOfThePPIntOfIntersection^ thePolyh)
{
  Bnd_Box* tmp = new Bnd_Box();
  *tmp = IntPatch_TheToolPolyhOfThePPIntOfIntersection::Bounding(*((IntPatch_ThePolyhedronOfThePPIntOfIntersection*)thePolyh->Handle));
  return gcnew OCBnd_Box(tmp);
}

OCBnd_HArray1OfBox^ OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::ComponentsBounding(OCNaroWrappers::OCIntPatch_ThePolyhedronOfThePPIntOfIntersection^ thePolyh)
{
  Handle(Bnd_HArray1OfBox) tmp = IntPatch_TheToolPolyhOfThePPIntOfIntersection::ComponentsBounding(*((IntPatch_ThePolyhedronOfThePPIntOfIntersection*)thePolyh->Handle));
  return gcnew OCBnd_HArray1OfBox(&tmp);
}

 Standard_Real OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::DeflectionOverEstimation(OCNaroWrappers::OCIntPatch_ThePolyhedronOfThePPIntOfIntersection^ thePolyh)
{
  return IntPatch_TheToolPolyhOfThePPIntOfIntersection::DeflectionOverEstimation(*((IntPatch_ThePolyhedronOfThePPIntOfIntersection*)thePolyh->Handle));
}

 Standard_Integer OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::NbTriangles(OCNaroWrappers::OCIntPatch_ThePolyhedronOfThePPIntOfIntersection^ thePolyh)
{
  return IntPatch_TheToolPolyhOfThePPIntOfIntersection::NbTriangles(*((IntPatch_ThePolyhedronOfThePPIntOfIntersection*)thePolyh->Handle));
}

 void OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::Triangle(OCNaroWrappers::OCIntPatch_ThePolyhedronOfThePPIntOfIntersection^ thePolyh, Standard_Integer Index, Standard_Integer& P1, Standard_Integer& P2, Standard_Integer& P3)
{
  IntPatch_TheToolPolyhOfThePPIntOfIntersection::Triangle(*((IntPatch_ThePolyhedronOfThePPIntOfIntersection*)thePolyh->Handle), Index, P1, P2, P3);
}

OCgp_Pnt^ OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::Point(OCNaroWrappers::OCIntPatch_ThePolyhedronOfThePPIntOfIntersection^ thePolyh, Standard_Integer Index)
{
  gp_Pnt* tmp = new gp_Pnt();
  *tmp = IntPatch_TheToolPolyhOfThePPIntOfIntersection::Point(*((IntPatch_ThePolyhedronOfThePPIntOfIntersection*)thePolyh->Handle), Index);
  return gcnew OCgp_Pnt(tmp);
}

 Standard_Integer OCIntPatch_TheToolPolyhOfThePPIntOfIntersection::TriConnex(OCNaroWrappers::OCIntPatch_ThePolyhedronOfThePPIntOfIntersection^ thePolyh, Standard_Integer Triang, Standard_Integer Pivot, Standard_Integer Pedge, Standard_Integer& TriCon, Standard_Integer& OtherP)
{
  return IntPatch_TheToolPolyhOfThePPIntOfIntersection::TriConnex(*((IntPatch_ThePolyhedronOfThePPIntOfIntersection*)thePolyh->Handle), Triang, Pivot, Pedge, TriCon, OtherP);
}


