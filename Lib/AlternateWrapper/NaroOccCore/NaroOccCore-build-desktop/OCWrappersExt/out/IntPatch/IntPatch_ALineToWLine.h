// File generated by CPPExt (MPV)
//
#ifndef _IntPatch_ALineToWLine_OCWrappers_HeaderFile
#define _IntPatch_ALineToWLine_OCWrappers_HeaderFile

// include native header
#include <IntPatch_ALineToWLine.hxx>
#include "../Converter.h"


#include "../IntSurf/IntSurf_Quadric.h"


namespace OCNaroWrappers
{

ref class OCIntSurf_Quadric;
ref class OCIntPatch_WLine;
ref class OCIntPatch_ALine;



public ref class OCIntPatch_ALineToWLine  {

protected:
  IntPatch_ALineToWLine* nativeHandle;
  OCIntPatch_ALineToWLine(OCDummy^) {};

public:
  property IntPatch_ALineToWLine* Handle
  {
    IntPatch_ALineToWLine* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCIntPatch_ALineToWLine(IntPatch_ALineToWLine* nativeHandle);

// Methods PUBLIC


OCIntPatch_ALineToWLine(OCNaroWrappers::OCIntSurf_Quadric^ Quad1, OCNaroWrappers::OCIntSurf_Quadric^ Quad2);


OCIntPatch_ALineToWLine(OCNaroWrappers::OCIntSurf_Quadric^ Quad1, OCNaroWrappers::OCIntSurf_Quadric^ Quad2, Standard_Real Deflection, Standard_Real PasMaxUV, Standard_Integer NbMaxPoints);


 /*instead*/  void SetTolParam(Standard_Real aT) ;


 /*instead*/  Standard_Real TolParam() ;


 /*instead*/  void SetTolOpenDomain(Standard_Real aT) ;


 /*instead*/  Standard_Real TolOpenDomain() ;


 /*instead*/  void SetTolTransition(Standard_Real aT) ;


 /*instead*/  Standard_Real TolTransition() ;


 /*instead*/  void SetTol3D(Standard_Real aT) ;


 /*instead*/  Standard_Real Tol3D() ;


 /*instead*/  void SetConstantParameter() ;


 /*instead*/  void SetUniformAbscissa() ;


 /*instead*/  void SetUniformDeflection() ;


 /*instead*/  OCIntPatch_WLine^ MakeWLine(OCNaroWrappers::OCIntPatch_ALine^ aline) ;


 /*instead*/  OCIntPatch_WLine^ MakeWLine(OCNaroWrappers::OCIntPatch_ALine^ aline, Standard_Real paraminf, Standard_Real paramsup) ;

~OCIntPatch_ALineToWLine()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
