// File generated by CPPExt (MPV)
//
#ifndef _StepGeom_BSplineCurve_OCWrappers_HeaderFile
#define _StepGeom_BSplineCurve_OCWrappers_HeaderFile

// include native header
#include <StepGeom_BSplineCurve.hxx>
#include "../Converter.h"

#include "StepGeom_BoundedCurve.h"

#include "StepGeom_BSplineCurveForm.h"
#include "../StepData/StepData_Logical.h"
#include "StepGeom_BoundedCurve.h"


namespace OCNaroWrappers
{

ref class OCStepGeom_HArray1OfCartesianPoint;
ref class OCTCollection_HAsciiString;
ref class OCStepGeom_CartesianPoint;



public ref class OCStepGeom_BSplineCurve  : public OCStepGeom_BoundedCurve {

protected:
  // dummy constructor;
  OCStepGeom_BSplineCurve(OCDummy^) : OCStepGeom_BoundedCurve((OCDummy^)nullptr) {};

public:

// constructor from native
OCStepGeom_BSplineCurve(StepGeom_BSplineCurve* nativeHandle);

// Methods PUBLIC

//! Returns a BSplineCurve <br>
OCStepGeom_BSplineCurve();


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName) ;


virtual /*instead*/  void Init(OCNaroWrappers::OCTCollection_HAsciiString^ aName, Standard_Integer aDegree, OCNaroWrappers::OCStepGeom_HArray1OfCartesianPoint^ aControlPointsList, OCStepGeom_BSplineCurveForm aCurveForm, OCStepData_Logical aClosedCurve, OCStepData_Logical aSelfIntersect) ;


 /*instead*/  void SetDegree(Standard_Integer aDegree) ;


 /*instead*/  Standard_Integer Degree() ;


 /*instead*/  void SetControlPointsList(OCNaroWrappers::OCStepGeom_HArray1OfCartesianPoint^ aControlPointsList) ;


 /*instead*/  OCStepGeom_HArray1OfCartesianPoint^ ControlPointsList() ;


 /*instead*/  OCStepGeom_CartesianPoint^ ControlPointsListValue(Standard_Integer num) ;


 /*instead*/  Standard_Integer NbControlPointsList() ;


 /*instead*/  void SetCurveForm(OCStepGeom_BSplineCurveForm aCurveForm) ;


 /*instead*/  OCStepGeom_BSplineCurveForm CurveForm() ;


 /*instead*/  void SetClosedCurve(OCStepData_Logical aClosedCurve) ;


 /*instead*/  OCStepData_Logical ClosedCurve() ;


 /*instead*/  void SetSelfIntersect(OCStepData_Logical aSelfIntersect) ;


 /*instead*/  OCStepData_Logical SelfIntersect() ;

~OCStepGeom_BSplineCurve()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif
