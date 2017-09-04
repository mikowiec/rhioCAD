// File generated by CPPExt (CPP file)
//

#include "Extrema_LocECC2dOfLocateExtCC2d.h"
#include "../Converter.h"
#include "../Adaptor2d/Adaptor2d_Curve2d.h"
#include "Extrema_Curve2dTool.h"
#include "Extrema_POnCurv2d.h"
#include "../gp/gp_Pnt2d.h"
#include "../gp/gp_Vec2d.h"
#include "Extrema_CCLocFOfLocECC2dOfLocateExtCC2d.h"
#include "Extrema_SeqPOnCOfCCLocFOfLocECC2dOfLocateExtCC2d.h"


using namespace OCNaroWrappers;

OCExtrema_LocECC2dOfLocateExtCC2d::OCExtrema_LocECC2dOfLocateExtCC2d(Extrema_LocECC2dOfLocateExtCC2d* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCExtrema_LocECC2dOfLocateExtCC2d::OCExtrema_LocECC2dOfLocateExtCC2d(OCNaroWrappers::OCAdaptor2d_Curve2d^ C1, OCNaroWrappers::OCAdaptor2d_Curve2d^ C2, Standard_Real U0, Standard_Real V0, Standard_Real TolU, Standard_Real TolV) 
{
  nativeHandle = new Extrema_LocECC2dOfLocateExtCC2d(*((Adaptor2d_Curve2d*)C1->Handle), *((Adaptor2d_Curve2d*)C2->Handle), U0, V0, TolU, TolV);
}

 System::Boolean OCExtrema_LocECC2dOfLocateExtCC2d::IsDone()
{
  return OCConverter::StandardBooleanToBoolean(((Extrema_LocECC2dOfLocateExtCC2d*)nativeHandle)->IsDone());
}

 Standard_Real OCExtrema_LocECC2dOfLocateExtCC2d::SquareDistance()
{
  return ((Extrema_LocECC2dOfLocateExtCC2d*)nativeHandle)->SquareDistance();
}

 void OCExtrema_LocECC2dOfLocateExtCC2d::Point(OCNaroWrappers::OCExtrema_POnCurv2d^ P1, OCNaroWrappers::OCExtrema_POnCurv2d^ P2)
{
  ((Extrema_LocECC2dOfLocateExtCC2d*)nativeHandle)->Point(*((Extrema_POnCurv2d*)P1->Handle), *((Extrema_POnCurv2d*)P2->Handle));
}


