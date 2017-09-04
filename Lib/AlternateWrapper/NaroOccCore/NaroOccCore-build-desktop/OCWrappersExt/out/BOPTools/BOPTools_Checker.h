// File generated by CPPExt (MPV)
//
#ifndef _BOPTools_Checker_OCWrappers_HeaderFile
#define _BOPTools_Checker_OCWrappers_HeaderFile

// include native header
#include <BOPTools_Checker.hxx>
#include "../Converter.h"

#include "BOPTools_PaveFiller.h"

#include "../TopoDS/TopoDS_Shape.h"
#include "BOPTools_ListOfCheckResults.h"
#include "BOPTools_PaveFiller.h"
#include "../TopAbs/TopAbs_ShapeEnum.h"


namespace OCNaroWrappers
{

ref class OCTopoDS_Shape;
ref class OCBOPTools_InterferencePool;
ref class OCBOPTools_ListOfCheckResults;



//!  class that provides the algorithm <br>
//!  to  check a shape on self-interference. <br>
public ref class OCBOPTools_Checker  : public OCBOPTools_PaveFiller {

protected:
  // dummy constructor;
  OCBOPTools_Checker(OCDummy^) : OCBOPTools_PaveFiller((OCDummy^)nullptr) {};

public:

// constructor from native
OCBOPTools_Checker(BOPTools_Checker* nativeHandle);

// Methods PUBLIC


//! Empty Contructor <br>
OCBOPTools_Checker();


//! Contructs the object using the shape <aS> to check <br>
OCBOPTools_Checker(OCNaroWrappers::OCTopoDS_Shape^ aS);


//! Contructs the object using the <InterferencePool> <br>
OCBOPTools_Checker(OCNaroWrappers::OCBOPTools_InterferencePool^ aIP);


//! Destructor <br>
virtual /*instead*/  void Destroy() override;

//! if <StopOnFirstFaulty == Standard_True> the process stops <br>
//!          and the exception throws; otherwise all faulties are searched <br>
 /*instead*/  void SetPerformType(System::Boolean StopOnFirstFaulty) ;


//! Launches  the  algorithm <br>
virtual /*instead*/  void Perform() override;


//! Selector <br>
 /*instead*/  void SetShape(OCNaroWrappers::OCTopoDS_Shape^ aS) ;


//! Selector <br>
 /*instead*/  OCTopoDS_Shape^ Shape() ;

//! returnes a result of check <br>
 /*instead*/  OCBOPTools_ListOfCheckResults^ GetCheckResult() ;


//! Selector. <br>
//! Retrns TRUE if there is interferred sub-shapes . <br>
 /*instead*/  System::Boolean HasFaulty() ;

~OCBOPTools_Checker()
{
  delete nativeHandle;
}

};

}; // OCNaroWrappers

#endif