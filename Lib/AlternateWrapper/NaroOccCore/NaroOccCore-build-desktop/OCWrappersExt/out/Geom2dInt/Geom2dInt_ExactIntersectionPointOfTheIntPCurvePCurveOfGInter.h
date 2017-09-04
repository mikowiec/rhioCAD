// File generated by CPPExt (MPV)
//
#ifndef _Geom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter_OCWrappers_HeaderFile
#define _Geom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter_OCWrappers_HeaderFile

// include native header
#include <Geom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter.hxx>
#include "../Converter.h"


#include "Geom2dInt_TheDistBetweenPCurvesOfTheIntPCurvePCurveOfGInter.h"
#include "../math/math_Vector.h"


namespace OCNaroWrappers
{

ref class OCAdaptor2d_Curve2d;
ref class OCGeom2dInt_Geom2dCurveTool;
ref class OCGeom2dInt_TheProjPCurOfGInter;
ref class OCGeom2dInt_TheIntPCurvePCurveOfGInter;
ref class OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter;
ref class OCGeom2dInt_TheDistBetweenPCurvesOfTheIntPCurvePCurveOfGInter;



public ref class OCGeom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter  {

protected:
  Geom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter* nativeHandle;
  OCGeom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter(OCDummy^) {};

public:
  property Geom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter* Handle
  {
    Geom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCGeom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter(Geom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter* nativeHandle);

// Methods PUBLIC


OCGeom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter(OCNaroWrappers::OCAdaptor2d_Curve2d^ C1, OCNaroWrappers::OCAdaptor2d_Curve2d^ C2, Standard_Real Tol);


 /*instead*/  void Perform(OCNaroWrappers::OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter^ Poly1, OCNaroWrappers::OCGeom2dInt_ThePolygon2dOfTheIntPCurvePCurveOfGInter^ Poly2, Standard_Integer& NumSegOn1, Standard_Integer& NumSegOn2, Standard_Real& ParamOnSeg1, Standard_Real& ParamOnSeg2) ;


 /*instead*/  void Perform(Standard_Real Uo, Standard_Real Vo, Standard_Real UInf, Standard_Real VInf, Standard_Real USup, Standard_Real VSup) ;


 /*instead*/  Standard_Integer NbRoots() ;


 /*instead*/  void Roots(Standard_Real& U, Standard_Real& V) ;


 /*instead*/  System::Boolean AnErrorOccurred() ;

~OCGeom2dInt_ExactIntersectionPointOfTheIntPCurvePCurveOfGInter()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif