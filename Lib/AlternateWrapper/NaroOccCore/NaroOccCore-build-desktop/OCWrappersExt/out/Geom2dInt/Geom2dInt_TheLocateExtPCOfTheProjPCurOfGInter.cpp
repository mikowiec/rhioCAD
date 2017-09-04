// File generated by CPPExt (CPP file)
//

#include "Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter.h"
#include "../Converter.h"
#include "../Adaptor2d/Adaptor2d_Curve2d.h"
#include "Geom2dInt_Geom2dCurveTool.h"
#include "../Extrema/Extrema_POnCurv2d.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Vec2d.h"
#include "Geom2dInt_PCLocFOfTheLocateExtPCOfTheProjPCurOfGInter.h"
#include "Geom2dInt_SeqPCOfPCLocFOfTheLocateExtPCOfTheProjPCurOfGInter.h"


using namespace OCNaroWrappers;

OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter(Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter() 
{
  nativeHandle = new Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter();
}

OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter(OCNaroWrappers::OCgp_Pnt2d^ P, OCNaroWrappers::OCAdaptor2d_Curve2d^ C, Standard_Real U0, Standard_Real TolU) 
{
  nativeHandle = new Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter(*((gp_Pnt2d*)P->Handle), *((Adaptor2d_Curve2d*)C->Handle), U0, TolU);
}

OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter(OCNaroWrappers::OCgp_Pnt2d^ P, OCNaroWrappers::OCAdaptor2d_Curve2d^ C, Standard_Real U0, Standard_Real Umin, Standard_Real Usup, Standard_Real TolU) 
{
  nativeHandle = new Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter(*((gp_Pnt2d*)P->Handle), *((Adaptor2d_Curve2d*)C->Handle), U0, Umin, Usup, TolU);
}

 void OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::Initialize(OCNaroWrappers::OCAdaptor2d_Curve2d^ C, Standard_Real Umin, Standard_Real Usup, Standard_Real TolU)
{
  ((Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter*)nativeHandle)->Initialize(*((Adaptor2d_Curve2d*)C->Handle), Umin, Usup, TolU);
}

 void OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::Perform(OCNaroWrappers::OCgp_Pnt2d^ P, Standard_Real U0)
{
  ((Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter*)nativeHandle)->Perform(*((gp_Pnt2d*)P->Handle), U0);
}

 System::Boolean OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::IsDone()
{
  return OCConverter::StandardBooleanToBoolean(((Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter*)nativeHandle)->IsDone());
}

 Standard_Real OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::SquareDistance()
{
  return ((Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter*)nativeHandle)->SquareDistance();
}

 System::Boolean OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::IsMin()
{
  return OCConverter::StandardBooleanToBoolean(((Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter*)nativeHandle)->IsMin());
}

OCExtrema_POnCurv2d^ OCGeom2dInt_TheLocateExtPCOfTheProjPCurOfGInter::Point()
{
  Extrema_POnCurv2d* tmp = new Extrema_POnCurv2d();
  *tmp = ((Geom2dInt_TheLocateExtPCOfTheProjPCurOfGInter*)nativeHandle)->Point();
  return gcnew OCExtrema_POnCurv2d(tmp);
}

