// File generated by CPPExt (MPV)
//
#ifndef _Extrema_ELCCOfLocateExtCC_OCWrappers_HeaderFile
#define _Extrema_ELCCOfLocateExtCC_OCWrappers_HeaderFile

// include native header
#include <Extrema_ELCCOfLocateExtCC.hxx>
#include "../Converter.h"


#include "Extrema_CCFOfELCCOfLocateExtCC.h"


namespace OCNaroWrappers
{

ref class OCExtrema_LCCacheOfLocateExtCC;
ref class OCAdaptor3d_Curve;
ref class OCExtrema_CurveTool;
ref class OCTColgp_HArray1OfPnt;
ref class OCExtrema_POnCurv;
ref class OCgp_Pnt;
ref class OCgp_Vec;
ref class OCExtrema_CCFOfELCCOfLocateExtCC;
ref class OCExtrema_SeqPOnCOfCCFOfELCCOfLocateExtCC;



public ref class OCExtrema_ELCCOfLocateExtCC  {

protected:
  Extrema_ELCCOfLocateExtCC* nativeHandle;
  OCExtrema_ELCCOfLocateExtCC(OCDummy^) {};

public:
  property Extrema_ELCCOfLocateExtCC* Handle
  {
    Extrema_ELCCOfLocateExtCC* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCExtrema_ELCCOfLocateExtCC(Extrema_ELCCOfLocateExtCC* nativeHandle);

// Methods PUBLIC


OCExtrema_ELCCOfLocateExtCC();


OCExtrema_ELCCOfLocateExtCC(OCNaroWrappers::OCAdaptor3d_Curve^ C1, OCNaroWrappers::OCAdaptor3d_Curve^ C2, Standard_Integer NbU, Standard_Integer NbV, Standard_Real TolU, Standard_Real TolV);


OCExtrema_ELCCOfLocateExtCC(OCNaroWrappers::OCAdaptor3d_Curve^ C1, OCNaroWrappers::OCAdaptor3d_Curve^ C2, Standard_Real Uinf, Standard_Real Usup, Standard_Real Vinf, Standard_Real Vsup, Standard_Integer NbU, Standard_Integer NbV, Standard_Real TolU, Standard_Real TolV);


 /*instead*/  void SetCurveCache(Standard_Integer theRank, OCNaroWrappers::OCExtrema_LCCacheOfLocateExtCC^ theCache) ;


 /*instead*/  void SetTolerance(Standard_Real Tol) ;


 /*instead*/  void Perform() ;


 /*instead*/  System::Boolean IsDone() ;


 /*instead*/  Standard_Integer NbExt() ;


 /*instead*/  Standard_Real SquareDistance(Standard_Integer N) ;


 /*instead*/  void Points(Standard_Integer N, OCNaroWrappers::OCExtrema_POnCurv^ P1, OCNaroWrappers::OCExtrema_POnCurv^ P2) ;

~OCExtrema_ELCCOfLocateExtCC()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
