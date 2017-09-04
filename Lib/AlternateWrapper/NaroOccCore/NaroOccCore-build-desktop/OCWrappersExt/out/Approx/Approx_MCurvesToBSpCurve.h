// File generated by CPPExt (MPV)
//
#ifndef _Approx_MCurvesToBSpCurve_OCWrappers_HeaderFile
#define _Approx_MCurvesToBSpCurve_OCWrappers_HeaderFile

// include native header
#include <Approx_MCurvesToBSpCurve.hxx>
#include "../Converter.h"


#include "../AppParCurves/AppParCurves_MultiBSpCurve.h"
#include "../AppParCurves/AppParCurves_SequenceOfMultiCurve.h"


namespace OCNaroWrappers
{

ref class OCAppParCurves_MultiCurve;
ref class OCAppParCurves_SequenceOfMultiCurve;
ref class OCAppParCurves_MultiBSpCurve;



public ref class OCApprox_MCurvesToBSpCurve  {

protected:
  Approx_MCurvesToBSpCurve* nativeHandle;
  OCApprox_MCurvesToBSpCurve(OCDummy^) {};

public:
  property Approx_MCurvesToBSpCurve* Handle
  {
    Approx_MCurvesToBSpCurve* get()
    {
      return nativeHandle;
    }
  }


// constructor from native
OCApprox_MCurvesToBSpCurve(Approx_MCurvesToBSpCurve* nativeHandle);

// Methods PUBLIC


OCApprox_MCurvesToBSpCurve();


 /*instead*/  void Reset() ;


 /*instead*/  void Append(OCNaroWrappers::OCAppParCurves_MultiCurve^ MC) ;


 /*instead*/  void Perform() ;


 /*instead*/  void Perform(OCNaroWrappers::OCAppParCurves_SequenceOfMultiCurve^ TheSeq) ;

//! return the composite MultiCurves as a MultiBSpCurve. <br>
 /*instead*/  OCAppParCurves_MultiBSpCurve^ Value() ;

//! return the composite MultiCurves as a MultiBSpCurve. <br>
 /*instead*/  OCAppParCurves_MultiBSpCurve^ ChangeValue() ;

~OCApprox_MCurvesToBSpCurve()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
