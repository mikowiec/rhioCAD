// File generated by CPPExt (CPP file)
//

#include "Extrema_ECCOfExtCC.h"
#include "../Converter.h"
#include "Extrema_CCacheOfExtCC.h"
#include "../Adaptor3d/Adaptor3d_Curve.h"
#include "Extrema_CurveTool.h"
#include "../TColgp/TColgp_HArray1OfPnt.h"
#include "Extrema_POnCurv.h"
#include "../gp/gp_Pnt.h"
#include "../gp/gp_Vec.h"
#include "Extrema_CCFOfECCOfExtCC.h"
#include "Extrema_SeqPOnCOfCCFOfECCOfExtCC.h"


using namespace OCNaroWrappers;

OCExtrema_ECCOfExtCC::OCExtrema_ECCOfExtCC(Extrema_ECCOfExtCC* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCExtrema_ECCOfExtCC::OCExtrema_ECCOfExtCC() 
{
  nativeHandle = new Extrema_ECCOfExtCC();
}

OCExtrema_ECCOfExtCC::OCExtrema_ECCOfExtCC(OCNaroWrappers::OCAdaptor3d_Curve^ C1, OCNaroWrappers::OCAdaptor3d_Curve^ C2, Standard_Integer NbU, Standard_Integer NbV, Standard_Real TolU, Standard_Real TolV) 
{
  nativeHandle = new Extrema_ECCOfExtCC(*((Adaptor3d_Curve*)C1->Handle), *((Adaptor3d_Curve*)C2->Handle), NbU, NbV, TolU, TolV);
}

OCExtrema_ECCOfExtCC::OCExtrema_ECCOfExtCC(OCNaroWrappers::OCAdaptor3d_Curve^ C1, OCNaroWrappers::OCAdaptor3d_Curve^ C2, Standard_Real Uinf, Standard_Real Usup, Standard_Real Vinf, Standard_Real Vsup, Standard_Integer NbU, Standard_Integer NbV, Standard_Real TolU, Standard_Real TolV) 
{
  nativeHandle = new Extrema_ECCOfExtCC(*((Adaptor3d_Curve*)C1->Handle), *((Adaptor3d_Curve*)C2->Handle), Uinf, Usup, Vinf, Vsup, NbU, NbV, TolU, TolV);
}

 void OCExtrema_ECCOfExtCC::SetCurveCache(Standard_Integer theRank, OCNaroWrappers::OCExtrema_CCacheOfExtCC^ theCache)
{
  ((Extrema_ECCOfExtCC*)nativeHandle)->SetCurveCache(theRank, *((Handle_Extrema_CCacheOfExtCC*)theCache->Handle));
}

 void OCExtrema_ECCOfExtCC::SetTolerance(Standard_Real Tol)
{
  ((Extrema_ECCOfExtCC*)nativeHandle)->SetTolerance(Tol);
}

 void OCExtrema_ECCOfExtCC::Perform()
{
  ((Extrema_ECCOfExtCC*)nativeHandle)->Perform();
}

 System::Boolean OCExtrema_ECCOfExtCC::IsDone()
{
  return OCConverter::StandardBooleanToBoolean(((Extrema_ECCOfExtCC*)nativeHandle)->IsDone());
}

 Standard_Integer OCExtrema_ECCOfExtCC::NbExt()
{
  return ((Extrema_ECCOfExtCC*)nativeHandle)->NbExt();
}

 Standard_Real OCExtrema_ECCOfExtCC::SquareDistance(Standard_Integer N)
{
  return ((Extrema_ECCOfExtCC*)nativeHandle)->SquareDistance(N);
}

 void OCExtrema_ECCOfExtCC::Points(Standard_Integer N, OCNaroWrappers::OCExtrema_POnCurv^ P1, OCNaroWrappers::OCExtrema_POnCurv^ P2)
{
  ((Extrema_ECCOfExtCC*)nativeHandle)->Points(N, *((Extrema_POnCurv*)P1->Handle), *((Extrema_POnCurv*)P2->Handle));
}


